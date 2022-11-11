using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Millioner
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }
        bool listavatarka;//Переменная для выдвижного списка с выбором аватарок
        private void OK_Click(object sender, EventArgs e)
        {
            if (textBoxWelcome.Text == String.Empty)//Проверка на пустоту текстбокса
            {
                MessageBox.Show("Напишите свое имя!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label2.Visible = false;
                label3.Visible = false;
                numericUpDown1.Visible = false;
                OK2.Visible = false;
            }
            else
            {
                MessageBox.Show("Здравствуйте , " + textBoxWelcome.Text, "Добро пожаловать!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label2.Visible = true;
                label3.Visible = true;
                numericUpDown1.Visible = true;
                OK2.Visible = true;
                this.AcceptButton = OK2;
            }

        }

        private void OK2_Click(object sender, EventArgs e)
        {
           
                if (numericUpDown1.Value == 6)
                {
                    MessageBox.Show("Правильно!", "", MessageBoxButtons.OK);
                    this.Hide();//Закрытие формы 1
                    frmMillioner frm = new frmMillioner();//создание новой формы 
                    frm.nickname.Text = textBoxWelcome.Text;//Текст с Textbox на form1 переходит на Textbox на form2
                    if (radioButton1.Checked == true)
                    {
                        frm.avatarka.Image = avatarka1.Image;
                    }
                    if (radioButton2.Checked == true)
                    {
                        frm.avatarka.Image = avatarka2.Image;
                    }
                    if (radioButton3.Checked == true)
                    {
                        frm.avatarka.Image = avatarka3.Image;
                    }
                    if (radioButton4.Checked == true)
                    {
                        frm.avatarka.Image = avatarka4.Image;
                    }
                    frm.ShowDialog();//Открытие формы 2

                }


                else
                {
                    MessageBox.Show(" Не правильно! Увидимся в следующий раз! ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();//Закрытие программы
                }
           
        }

        private void listAvatarka_Click(object sender, EventArgs e)
        {
            
            if (listavatarka)
            {
                listAvatarka.Text = "Выбрать аватарку";
                this.Size = new Size(402, 326);
                listavatarka = false;
            }
            else
            {
                listAvatarka.Text = "Свернуть меню";
                listavatarka = true;
                this.Size = new Size(402, 549);
            }
            
        }

        private void FormWelcome_Load(object sender, EventArgs e)
        {

        }
    }
}
