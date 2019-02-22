using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonDepartLib;
using PersonDepartLib.Model;
using PersonDepartLib.Context;
using System.Data.Entity;

namespace PersonDepartWF
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm()); // открытие формы входа в приложение (логин/пароль)
            //Application.Run(new EmployeeForm());



        }
    }
}
