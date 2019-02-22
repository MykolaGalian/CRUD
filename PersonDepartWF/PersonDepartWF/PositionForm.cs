using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonDepartLib;
using PersonDepartLib.Model;
using PersonDepartLib.Context;
using System.Data.Entity;

namespace PersonDepartWF
{
    public partial class PositionForm : Form
    {
        public PositionForm()
        {
            InitializeComponent();
        }

        Position pos_ = new Position(); // создадим временный обьект Position 
        int posID = 0;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWF f1 = new MainWF(); //открывается главная форма для обычного пользователя
            f1.ShowDialog();
        }

        void lbPositionView()  // вывод списка всех долнжостей на предприятии в ListBox
        {
            lbPosition.DataSource = Position.Position_List();  //список должностей (всех)
            lbPosition.DisplayMember = "PositionName";
            lbPosition.ValueMember = "PositionID";      
        }

        private void PositionForm_Load(object sender, EventArgs e)
        {
            lbPositionView();
            Clear();
        }             

        private void lbPosition_DoubleClick(object sender, EventArgs e)  // вывод инфо в текстБокс по двойному щелчку на строчке
        {
            posID = Convert.ToInt32(lbPosition.SelectedValue);

            using (PerDepContext db = new PerDepContext())
            {
                pos_ = Position.RecPosition(posID, db); // статический метод из класса Position
                tbPosName.Text = pos_.PositionName;
            }            
        }

        void Clear() // очистка текстбоксов формы
        {
            tbPosName.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)  // добавление новой должности
        {
            pos_.PositionName = tbPosName.Text.Trim();  // записываем в поля временного обьекта pos_ 

            if (tbPosName.Text != "")
            {
                pos_.Add_Position(); //  метод из класса Position - добавление должности
                Clear();
                lbPositionView();
                MessageBox.Show("Посада додана в загальний список");

            }
            else MessageBox.Show("Заповніть поле з назвою посади");            
        }

        private void btnSave_Click(object sender, EventArgs e)  // изменение в название существующей должности
        {
            pos_.PositionName = tbPosName.Text.Trim();  // записываем в поля временного обьекта pos_ 

            if (tbPosName.Text != "")
            {
                pos_.Save_ModificationOfPos(); //  метод из класса Position -сохранение изменений для должности
                Clear();
                lbPositionView();
                MessageBox.Show("Зміни внесені");
            }
            else MessageBox.Show("Заповніть поле з назвою посади");           
        }
        
    }
}


