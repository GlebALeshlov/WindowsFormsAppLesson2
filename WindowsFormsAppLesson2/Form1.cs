using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLesson2
{
    //Это метод инициализации
    public partial class Form1 : Form
    {
        //Это метод загрузки формы
        public Form1()
        {
            InitializeComponent();
        }

       //Это
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "=^_^=";
            button1.BackColor= Color.Red;
            button1.Enabled= false;
            label1.Text = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "НЕ НАЖИМАЙ!!!";
            label1.Text = "Made by Кто-то";
            textBox1.Text = "Сотри тут";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackColor= Color.Orange;
            button1.Text = "НЕ НАЖИМАЙ!!!";
        }
    }
}
