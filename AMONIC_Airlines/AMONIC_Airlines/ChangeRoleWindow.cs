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
    public partial class ChangeRoleWindow : Form
    {
        private PrivateFontCollection privateFontCollection = new PrivateFontCollection();
        public ChangeRoleWindow()
        {
            InitializeComponent();
            privateFontCollection.AddFontFile(Environment.CurrentDirectory.TrimEnd(@"bin\Debug".ToCharArray()) + @"\Fonts\TeXGyreAdventor-Regular.ttf");
            Font = new Font(privateFontCollection.Families[0], 8);
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Событие кнопки btn_cancel при нажатии закрывает диалоговое окно.
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Изменение роли пользователя.
        private void btn_apply_Click(object sender, EventArgs e)
        {
            //Если выбранный элемент ComboBox не равен пустой строке и если свойства Text элементов TextBox не равны пустым строкам,
            //то происходит изменение роли пользователя, если такой пользователь действительно существует и находится в таблице Users.
            //Иначе выводится сообщение о том, что не все поля заполнены.
            if (txt_email.Text != "" && txt_first_name.Text != "" && txt_last_name.Text != "" && cmb_offices.SelectedItem.ToString() != "")
            {
                int OfficeID = 0;
                using (SqlConnection connection = new SqlConnection(@"Data Source=localhost;database=Session1_10_74;Integrated Security=True"))
                {
                    connection.Open();
                    SqlCommand query = new SqlCommand($"SELECT ID FROM Offices WHERE Title = \'{cmb_offices.SelectedItem.ToString()}\'", connection);
                    SqlDataReader reader = query.ExecuteReader();
                    if (reader.Read()) OfficeID = (int)reader.GetValue(0);
                    reader.Close();
                    query = new SqlCommand($"SELECT * FROM Users WHERE Email = \'{txt_email.Text}\' AND FirstName = \'{txt_first_name.Text}\' AND LastName = \'{txt_last_name.Text}\' AND OfficeID = {OfficeID}", connection);
                    reader = query.ExecuteReader();
                    //По результатам запроса если такой пользователь действительно существует и запрос возвращает результат в виде строки,
                    //которая соответствует данному пользователю, то происходит изменение роли пользователя исходя из выбранного элемента RadioButton
                    //и текущей роли пользователя.
                    //Иначе выводится сообщение о том, что такого пользователя не существует.
                    if (reader.HasRows)
                    {
                        reader.Close();
                        query = new SqlCommand($"SELECT RoleID FROM Users WHERE Email = \'{txt_email.Text}\'", connection);
                        reader = query.ExecuteReader();
                        //Если выбран RadioButton, отвечающий за изменение роли с Administrator на User,
                        //то происходит проверка не равна ли текущая роль выбранной роли.
                        if (radiobtn_user.Checked)
                        {
                            //Если поток доступен для чтения и запрос возвращает первую таблицу результат которой равен 1,
                            //то происходит изменение роли пользователя с Administrator на User.
                            //Иначе выводится сообщение о том, что текущий пользователь уже имеет роль User.
                            if (reader.Read() && (int)reader.GetValue(0) == 1)
                            {
                                reader.Close();
                                query = new SqlCommand($"UPDATE Users SET RoleID = 2 WHERE Email = \'{txt_email.Text}\'", connection);
                                query.ExecuteReader();
                                MessageBox.Show("The role of this user has been changed from Administrator to User", "Success");
                            }
                            else if (reader.Read() && (int)reader.GetValue(0) == 2) MessageBox.Show("The role of this user is already User", "Error");
                        }
                        else if (radiobtn_admin.Checked)
                        {
                            //Следующий код работает точно так же, как и код выше, только условия немного изменены.
                            if (reader.Read() && (int)reader.GetValue(0) == 2)
                            {
                                reader.Close();
                                query = new SqlCommand($"UPDATE Users SET RoleID = 1 WHERE Email = \'{txt_email.Text}\'", connection);
                                query.ExecuteReader();
                                MessageBox.Show("The role of this user has been changed from User to Administrator", "Success");
                            }
                            else if (reader.Read() && (int)reader.GetValue(0) == 1) MessageBox.Show("The role of this user is already Administrator", "Error");
                        }
                        else MessageBox.Show("Do not select any one role", "Error");
                    }
                    else MessageBox.Show("This user was not found", "Error");
                    connection.Close();
                }
            }
            else MessageBox.Show("Not all fields are filled in", "Error");
        }
    }
}
