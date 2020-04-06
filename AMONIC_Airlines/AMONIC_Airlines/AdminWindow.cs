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
    public partial class AdminWindow : Form
    {
        private PrivateFontCollection privateFontCollection = new PrivateFontCollection();
        public AdminWindow()
        {
            InitializeComponent();
            privateFontCollection.AddFontFile(Environment.CurrentDirectory.TrimEnd(@"bin\Debug".ToCharArray()) + @"\Fonts\TeXGyreAdventor-Regular.ttf");
            Font = new Font(privateFontCollection.Families[0], 8);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterScreen;
            dgv_offices.ReadOnly = true;
            dgv_offices.MultiSelect = true;
        }

        //Функция для обработки запросов по выводу данных о всех пользователях, работающих в разных офисах.
        private void OutputUsersByOffices()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=localhost;database=Session1_10_74;Integrated Security=True"))
            {
                connect.Open();
                DataSet data = new DataSet();
                string strQuery = $"SELECT Users.FirstName AS [Name], Users.LastName AS [Last\nName], {DateTime.Today.Year} - YEAR(Users.Birthdate) AS [Age], Roles.Title AS [User Role], Users.Email AS [Email Address], Offices.Title AS [Office] FROM (Users INNER JOIN Roles ON Users.RoleID = Roles.ID) INNER JOIN Offices ON Users.OfficeID = Offices.ID";
                SqlCommand command = new SqlCommand(strQuery, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                dgv_offices.DataSource = data.Tables[0];
                connect.Close();
            }
        }

        //Перегрузка функции OutputUsersByOffices, метод принимает параметр office типа string для вывода в DataGridView информацию о пользователях, работающих в соответствующем офисе.
        //Именно в формальный параметр office передаётся выбранное значение из ComboBox, которое является местонахождением офиса и фактическим параметром данной функции.
        private void OutputUsersByOffices(string office)
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=localhost;database=Session1_10_74;Integrated Security=True"))
            {
                connect.Open();
                DataSet data = new DataSet();
                string strQuery = $"SELECT Users.FirstName AS [Name], Users.LastName AS [Last\nName], {DateTime.Today.Year} - YEAR(Users.Birthdate) AS [Age], Roles.Title AS [User Role], Users.Email AS [Email Address], Offices.Title AS [Office] FROM (Users INNER JOIN Roles ON Users.RoleID = Roles.ID) INNER JOIN Offices ON Users.OfficeID = Offices.ID WHERE Offices.Title = \'{office}\'";
                SqlCommand command = new SqlCommand(strQuery, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                dgv_offices.DataSource = data.Tables[0];
                connect.Close();
            }
        }

        //Кнопка MenuStrip для закрытия приложения.
        private void exit_admin_ms_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Если выбран элемент "All offices", то вызывается функция OutputUsersByOffices().
        //Иначе вызывается перегруженная функция OutputUsersByOffices(), в которую в качестве
        //параметра передаётся выбранный элемент в виде строки.
        private void cmb_offices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_offices.SelectedItem.ToString() == "All offices") OutputUsersByOffices();
            else OutputUsersByOffices(cmb_offices.SelectedItem.ToString());
        }

        //Событие закрывает приложение если была закрыта форма.
        private void AdminWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Событие для включения/выключения активности пользователей.
        private void btn_enable_disable_login_Click(object sender, EventArgs e)
        {
            //Если пользователь выбрал количество строк больше нуля, 
            //то выполняется цикл, который проходится по всем выбранным строкам и отправляет запрос.
            if (dgv_offices.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dgv_offices.SelectedRows.Count; i++)
                {
                    //Запрос SELECT нужен для того, чтобы узнать активность выбранных пользователей, 
                    //после чего обновить состояние столбца Active и изменить его значение на противоположное 
                    //в зависимости от текущего значения.
                    using (SqlConnection connect = new SqlConnection(@"Data Source=localhost;database=Session1_10_74;Integrated Security=True"))
                    {
                        connect.Open();
                        SqlCommand IsActiveQuery = new SqlCommand($"SELECT Active FROM Users WHERE Email = \'{dgv_offices.SelectedRows[i].Cells[4].Value.ToString()}\'", connect);
                        SqlDataReader dataReader = IsActiveQuery.ExecuteReader();
                        if (dataReader.Read())
                        {
                            if ((bool)dataReader.GetValue(0))
                            {
                                dataReader.Close();
                                SqlCommand updateQuery = new SqlCommand($"UPDATE Users SET Active = 0 WHERE Email = \'{dgv_offices.SelectedRows[i].Cells[4].Value.ToString()}\'", connect);
                                updateQuery.ExecuteReader();
                                dgv_offices.SelectedRows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                            else
                            {
                                dataReader.Close();
                                SqlCommand updateQuery = new SqlCommand($"UPDATE Users SET Active = 1 WHERE Email = \'{dgv_offices.SelectedRows[i].Cells[4].Value.ToString()}\'", connect);
                                updateQuery.ExecuteReader();
                                dgv_offices.SelectedRows[i].DefaultCellStyle.BackColor = Color.Green;
                            }
                        }
                        connect.Close();
                    }
                }
            }
        }

        //Создаёт экземпляр класса AddUserWindow, который соответствует окну добавления новых пользователей,
        //после чего отображает это диалоговое окно как модальное.
        private void add_user_admin_ms_Click(object sender, EventArgs e)
        {
            AddUserWindow addUserWindow = new AddUserWindow();
            addUserWindow.ShowDialog();
        }

        //Создаёт экземпляр класса ChangeRoleWindow, который соответствует окну изменения роли пользователя, 
        //после чего отображает это диалоговое окно как модальное.
        private void btn_change_role_Click(object sender, EventArgs e)
        {
            ChangeRoleWindow changeRoleWindow = new ChangeRoleWindow();
            changeRoleWindow.ShowDialog();
        }
    }
}
