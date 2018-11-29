using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactAppUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Главное окно программы";
            this.Size = new Size(400, 250);

          /*  //Создаем кнопку
            var button = new Button();
            button.Text = "Сменить заголовок окна";
            button.Size = new Size(150, 25);
            button.Location = new Point(150, 150);
            //Подписываем кнопку на обработчик
            button.Click += Button_Click;
            //Помещаем кнопку на форму
            this.Controls.Add(button);
            */
        }
        //Обработчик события нажатия кнопки
        private void Button_Click(object sender, EventArgs e)
        {
            //Здесь пишем код, который должен выполняться
            // каждый раз при нажатии на кнопку.
            this.Text = "Новый заголовок";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
