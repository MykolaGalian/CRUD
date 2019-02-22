using PersonDepartLib;
using PersonDepartLib.Context;
using PersonDepartLib.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonDepartWF
{
    public partial class LoginForm : Form
    {
        User user_ = new User();  // создадим обьект класса User

        public LoginForm()
        {
            InitializeComponent();
        }


        enum State_ { admin, user, none }  // права пользователей
        private State_ Rights = State_.none; // по умолчанию значение - "неопределено"

        private void btClear_inter_Click(object sender, EventArgs e) 
        {
            Clear();
        }

        void Clear() // очистка текстбоксов
        {
            tbUserName.Text = tbPass.Text = "";           
        }

        private void btInter_Click(object sender, EventArgs e)
        {
            
            //задание содержания текстбоксов полям сущности User
            //user_.Login = tbUserName.Text;
            //user_.Password = tbPass.Text;

            using (PerDepContext db = new PerDepContext())
            {  
                // запрос к таб. Users_ есть ли обьект с введенным логином и паролем
                user_ = User.Log_In_UserAdmin(tbUserName.Text, tbPass.Text, db); // возврат сущности по Login / Password
                                                                        // статический метод из класса User 

                if (user_ != null)
                {
                    if (user_.TypeOfUser == "Admin")  // если у пользователя тип учетной записи - Админ - то открывается форма управления пользователями
                    {
                        Rights = State_.admin;
                    }

                    else  // если нет прав администратора то обычный вход 
                    {
                        Rights = State_.user;
                    }
                }
                else MessageBox.Show("Невiрний пароль або логiн");               
            }
            Clear();

            if (Rights == State_.admin)
            {
                this.Hide();
                AdminForm A1 = new AdminForm();
                A1.ShowDialog();  //открывается форма управления пользователями - для администратора
            }
            else if (Rights == State_.user)
            {                
                this.Hide();
                MainWF f1 = new MainWF(); //открывается главная форма для обычного пользователя
                f1.ShowDialog();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Database.SetInitializer(new ManInitializer()); // !!!!!!!!!!!!! инициализация бд
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit(); // при ручном закрытии формы
        }
    }
}
