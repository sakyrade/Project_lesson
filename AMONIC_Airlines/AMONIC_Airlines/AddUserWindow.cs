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
    public partial class AddUserWindow : Form
    {
        private PrivateFontCollection privateFontCollection = new PrivateFontCollection();
        public AddUserWindow()
        {
            InitializeComponent();
            privateFontCollection.AddFontFile(Environment.CurrentDirectory.TrimEnd(@"bin\Debug".ToCharArray()) + @"\Fonts\TeXGyreAdventor-Regular.ttf");
            Font = new Font(privateFontCollection.Families[0], 8);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        //При нажатии на кнопку btn_save_Click происходит добавление пользователя в таблицу Users.
        private void btn_save_Click(object sender, EventArgs e)
        {
            int ID = 0, OfficeID = 0;
            //Если выбранное значение в ComboBox не равно пустой строке и если остальные свойства Text элементов TextBox не равны пустой строке,
            //то выполняются действия по добавлению нового пользователя в таблицу Users.
            //Иначе выводится сообщение о том, что не все поля заполнены.
            if (cmb_offices.SelectedItem.ToString() != "" && txt_email.Text != "" && txt_first_name.Text != "" && txt_last_name.Text != "" && txt_birthdate.Text != "" && txt_password.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=localhost;database=Session1_10_74;Integrated Security=True"))
                {
                    //Т.к. поле ID таблицы Users без автоинкрементации, то следующий запрос нужен для того,
                    //чтобы получить последний (максимальный) номер ID (они начинаются с единицы и каждый раз увеличиваются на 1),
                    //после чего этот номер ID увеличивается на 1.
                    connection.Open();
                    SqlCommand query = new SqlCommand("SELECT MAX(ID) FROM Users", connection);
                    SqlDataReader reader = query.ExecuteReader();
                    if (reader.Read()) ID = (int)reader.GetValue(0) + 1;
                    reader.Close();
                    query = new SqlCommand($"SELECT ID FROM Offices WHERE Title = \'{cmb_offices.SelectedItem.ToString()}\'", connection);
                    reader = query.ExecuteReader();
                    if (reader.Read()) OfficeID = (int)reader.GetValue(0);
                    reader.Close();
                    query = new SqlCommand($"SELECT COUNT(*) FROM Users WHERE Email = \'{txt_email.Text}\'", connection);
                    reader = query.ExecuteReader();
                    //Если же поток доступен для чтения и запрос возвращает таблицу со значением в первом столбце больше нуля,
                    //то выводится сообщение о том, что такой Email уже существует (Email у каждого уникальный).
                    //Иначе отправляется запрос на вставку нового пользователя в таблицу Users.
                    //
                    //По умолчанию добавляется пользователь с ролью User, поле Active по умолчанию имеет значение 1 (или же True).
                    if (reader.Read() && (int)reader.GetValue(0) > 0) MessageBox.Show("This email already exists", "Error");
                    else
                    {
                        reader.Close();
                        query = new SqlCommand($"INSERT INTO Users(ID, RoleID, Email, UserPassword, FirstName, LastName, OfficeID, Birthdate, Active) VALUES({ID}, 2, \'{txt_email.Text}\', \'{txt_password.Text}\', \'{txt_first_name.Text}\', \'{txt_last_name.Text}\', {OfficeID}, \'{txt_birthdate.Text}\', 1)", connection);
                        query.ExecuteReader();
                        MessageBox.Show("The user was added successfully", "Success");
                    }
                    connection.Close();
                }
                
            }
            else MessageBox.Show("Not all fields are filled in", "Error");
        }

        //Событие кнопки btn_cancel при нажатии закрывает диалоговое окно.
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
