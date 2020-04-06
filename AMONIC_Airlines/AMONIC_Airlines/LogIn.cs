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
    public partial class LogIn : Form
    {
        //Количество неудачных попыток входа в систему
        private int LoginCountFalse = 0;
        //Количество секунд, после которых можно снова войти в систему
        private int TempTick = 10;
        //Коллекция шрифтов. Нужна для того, чтобы подключить нужный шрифт
        private PrivateFontCollection privateFontCollection = new PrivateFontCollection();
        public LogIn()
        {
            InitializeComponent();
            //Поставка значений для свойств формы и некоторых элементов управления, подключение шрифта, добавление его в коллекцию и использование.
            //Также подключение логотипа для ЭУ PictureBox (pcr_logo).
            privateFontCollection.AddFontFile(Environment.CurrentDirectory.TrimEnd(@"bin\Debug".ToCharArray()) + @"\Fonts\TeXGyreAdventor-Regular.ttf");
            Font = new Font(privateFontCollection.Families[0], 8);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            pcr_logo.SizeMode = PictureBoxSizeMode.AutoSize;
            pcr_logo.ImageLocation = Environment.CurrentDirectory.TrimEnd(@"bin\Debug".ToCharArray()) + @"\Images\DS2017_TP09_color@2x.png";
            lb_false_timer.Visible = false;
        }

        //Событие при нажатии на кнопку Exit - закрытие программы
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Событие при нажатии на кнопку Login
        private void btn_login_Click(object sender, EventArgs e)
        {
            //Если событие Enabled элемента управления Timer (Login_timer) имеет значение false, то выполняется сравнение Email адреса и пароля, 
            //введённых с клавиатуры в два элемента управления TextBox, а именно - txtLogin и txtPassword.
            if (!Login_timer.Enabled)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=localhost;database=Session1_10_74;Integrated Security=True");
                connection.Open();
                SqlCommand commandAutentification = new SqlCommand("SELECT * FROM Users WHERE Email = @email AND UserPassword = @password", connection);
                commandAutentification.Parameters.AddWithValue("@email", txtLogin.Text);
                commandAutentification.Parameters.AddWithValue("@password", txtPassword.Text);
                SqlDataReader readerAutentification = commandAutentification.ExecuteReader();
                //Если с потока возможно чтение каких-либо данных, то в дальнейшем происходит проверка на роль (User или Administrator) по столбцу в базе данных.
                if (readerAutentification.Read())
                {
                    switch ((int)readerAutentification.GetValue(1))
                    {
                        //Если аккаунт в дальнейшем является активным (проверяется значение в столбце Active) и является администратором (значение в столбце RoleID), 
                        //то текущее окно сворачивается, создаётся экземпляр класса AdminWindow, который является окном администратора, после чего вызывается метод Show(), 
                        //которая отображает созданный экземпляр.
                        //
                        //Если аккаунт неактивен, но является администратором, то выводится сообщение о том, что этот аккаунт не активен. Также работает и с пользователями.
                        //
                        //Если аккаунт является активным и является пользователем, то в свойство класса Users передаётся значение свойства Text из txtLogin. (см. класс Users)
                        case 1:
                            if ((bool)readerAutentification.GetValue(8))
                            {
                                this.Hide();
                                AdminWindow admin_window = new AdminWindow();
                                admin_window.Show();
                            }
                            else MessageBox.Show("This account not active.", "Error");
                            break;
                        case 2:
                            if ((bool)readerAutentification.GetValue(8))
                            {
                                Users.Email = txtLogin.Text;
                                this.Hide();
                                UserWindow user_window = new UserWindow();
                                user_window.Show();
                            }
                            else MessageBox.Show("This account not active.", "Error");
                            break;
                    }
                }
                else
                {
                    //Иначе, если в потоке чтения не находится никаких данных, то выводится сообщение о том, что логин или пароль введены неверно и переменная, 
                    //содержащая количество неудачных входов в систему, инкрементируется.
                    MessageBox.Show("Incorrect login or password.", "Error");
                    LoginCountFalse++;
                    //Если значение переменной LoginCountFalse равно 3, то свойство Enabled ЭУ Timer (Login_timer) устанавливается в значение true, которое запускает сам таймер.
                    //Также свойство Visible элемента управления Label (lb_false_timer) устанавливается в значение true, т.е. происходит отображение элемента управления на форме. 
                    if (LoginCountFalse == 3)
                    {
                        Login_timer.Enabled = true;
                        lb_false_timer.Visible = true;
                    }
                }
                connection.Close();
            }
        }

        //Событие Tick элемента управления Timer (Login_timer)
        private void Login_timer_Tick(object sender, EventArgs e)
        {
            //Пока переменная TempTick не меньше 0 - происходит декрементация значения переменной TempTick и вывод соответствующего текста.
            //Сам же текст говорит о том, что пользователь ввёл некорректные логин или пароль, 
            //и что нужно подождать определённое количество времени, отсчёт которого выводится вместе с текстом.
            //
            //Свойство Interval элемента управления Login_timer равна 1000 миллисекундам, что эквивалентно одной секунде. 
            if (TempTick < 0)
            {
                LoginCountFalse = 0;
                TempTick = 10;
                Login_timer.Enabled = false;
                lb_false_timer.Visible = false;
            }
            lb_false_timer.Text = $"You incorrect input login or password .\nWait {TempTick} sec.";
            TempTick--;
        }
    }
}
