﻿/*
 У системі зробити ролі для користувачів (Admin, User, та ін);
При запуску програми ми бачимо форму входу.
Вводимо логін та пароль. 
Якщо це був адмін, йому зявляється форма для роботи з користувачами.
Якщо це був user він може побачити про себе інформацію, змінити пароль.
Адмін може забанити коривачів (якщо в нього IsActive = false) він немає права входити.

Коли працює адмін він може шукати користувачів
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registration_app_winform
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fmMain());
        }
    }
}
