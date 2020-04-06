using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMONIC_Airlines
{
    public partial class UserWindow : Form
    {
        //Поле logon_time отвечает за время входа пользователя в систему.
        private TimeSpan logon_time;
        //Поле logout_time отвечает за время выхода пользователя из системы.
        private TimeSpan logout_time;
        private PrivateFontCollection privateFontCollection = new PrivateFontCollection();
        //Поле btn_exit_not_clicked проверяет была ли нажата клавиша btn_exit.
        private bool btn_exit_not_clicked = true;
        public UserWindow()
        {
            InitializeComponent();
            privateFontCollection.AddFontFile(Environment.CurrentDirectory.TrimEnd(@"bin\Debug".ToCharArray()) + @"\Fonts\TeXGyreAdventor-Regular.ttf");
            Font = new Font(privateFontCollection.Families[0], 8);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterScreen;
            dgv_users_audit.ReadOnly = true;
            logon_time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            //Полное время, проведённое в системе.
            TimeSpan fulltime = new TimeSpan();
            //Количество критических ошибок
            int CriticalCrashesCount = 0;
            using (SqlConnection connection = new SqlConnection(@"Data Source=localhost;database=Session1_10_74;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand query = new SqlCommand($"SELECT ID, FirstName, LastName FROM Users WHERE Email = \'{Users.Email}\'", connection);
                SqlDataReader reader = query.ExecuteReader();
                if (reader.Read())
                {
                    lb_welcome.Text = $"Hi {reader.GetValue(1)} {reader.GetValue(2)}, Welcome to AMONIC Airlines Automation System.";
                    Users.ID = (int)reader.GetValue(0);
                }
                reader.Close();
                query = new SqlCommand($"SELECT Session_date AS [Date], Logon_time AS [Logon time], Logout_time AS [Logout time], Session_time AS [Time spent on system], Unsuccessfull_logout_reason AS [Unsuccessfull logout reason] FROM Users_audit WHERE ID_user = {Users.ID}", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(query);
                DataSet data = new DataSet();
                adapter.Fill(data);
                dgv_users_audit.DataSource = data.Tables[0];
                connection.Close();
            }
            for (int i = 0; i < dgv_users_audit.RowCount; i++)
            {
                if (dgv_users_audit.Rows[i].Cells[4].Value == null) break;
                if (dgv_users_audit.Rows[i].Cells[4].Value.ToString() != "")
                {
                    CriticalCrashesCount++;
                    dgv_users_audit.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    continue;
                }
                fulltime += (TimeSpan)dgv_users_audit.Rows[i].Cells[3].Value;
            }
            lb_full_time.Text = $"Time spent on system: {fulltime}";
            lb_num_of_crashes.Text = $"Number of crashes: {CriticalCrashesCount}";
        }

        private void menu_strip_exit_Click(object sender, EventArgs e)
        {
            btn_exit_not_clicked = false;
            logout_time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            using (SqlConnection connection = new SqlConnection(@"Data Source=localhost;database=Session1_10_74;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"INSERT INTO Users_audit(ID_user, Session_date, Logon_time, Logout_time, Session_time) VALUES({Users.ID}, \'{DateTime.Now.ToShortDateString()}\', \'{logon_time}\', \'{logout_time}\', \'{logout_time - logon_time}\')", connection);
                command.ExecuteReader();
                connection.Close();
            }
            Application.Exit();
        }

        private void UserWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlConnection connection;
            SqlCommand query;
            if (btn_exit_not_clicked)
            {
                using (connection = new SqlConnection(@"Data Source=localhost;database=Session1_10_74;Integrated Security=True"))
                {
                    connection.Open();
                    query = new SqlCommand($"INSERT INTO Users_audit(ID_user, Session_date, Logon_time, Unsuccessfull_logout_reason) VALUES({Users.ID}, \'{DateTime.Now.ToShortDateString()}\', \'{logon_time}\', \'UncorrectedClosed\')", connection);
                    query.ExecuteReader();
                    connection.Close();
                    Application.Exit();
                }
            }
            else if (e.CloseReason.ToString() != "UserClosing")
            {
                if (e.CloseReason.ToString() != "ApplicationExitCall")
                {
                    using (connection = new SqlConnection(@"Data Source=localhost;database=Session1_10_74;Integrated Security=True"))
                    {
                        connection.Open();
                        query = new SqlCommand($"INSERT INTO Users_audit(ID_user, Session_date, Logon_time, Unsuccessfull_logout_reason) VALUES({Users.ID}, \'{DateTime.Now.ToShortDateString()}\', \'{logon_time}\', \'{e.CloseReason.ToString()}\')", connection);
                        query.ExecuteReader();
                        connection.Close();
                        Application.Exit();
                    }
                }
                using (connection = new SqlConnection(@"Data Source=localhost;database=Session1_10_74;Integrated Security=True"))
                {
                    connection.Open();
                    query = new SqlCommand($"INSERT INTO Users_audit(ID_user, Session_date, Logon_time, Unsuccessfull_logout_reason) VALUES({Users.ID}, \'{DateTime.Now.ToShortDateString()}\', \'{logon_time}\', \'{e.CloseReason.ToString()}\')", connection);
                    query.ExecuteReader();
                    connection.Close();
                    Application.Exit();
                }
            }
            else Application.Exit();
        }
    }
}
