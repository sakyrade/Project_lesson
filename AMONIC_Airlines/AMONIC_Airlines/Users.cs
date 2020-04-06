using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMONIC_Airlines
{
    //Класс Users нужен для того, чтобы передать из формы LogIn, а конкретнее, 
    //значение свойства Text элемента управления TextBox (txtLogin.Text) в форму UserWindow,
    //чтобы в дальнейшем сформировать запрос в базу данных и выбрать ID, соответствующий Email пользователя.
    //
    //Класс Users в какой-то степени отражает соответствующую роль в БД.
    class Users
    {
        //Поле Email нужно для хранения Email текущего пользователя, который вошёл в систему.
        public static string Email { get; set; }
        //Поле ID нужно для хранения ID текущего пользователя, который вошёл в систему.
        public static int ID { get; set; }
    }
}
