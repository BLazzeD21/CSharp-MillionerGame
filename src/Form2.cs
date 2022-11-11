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
    public partial class frmMillioner : Form
    {
        public frmMillioner()
        {
            InitializeComponent();
        }
        ListBox question_box = new ListBox();//Невидимый listbox с вопросами
        ListBox answer_box1 = new ListBox();//Невидимый listbox с первым ответом
        ListBox answer_box2 = new ListBox();//Невидимый listbox со вторым ответом
        ListBox answer_box3 = new ListBox();//Невидимый listbox с третьим ответом
        ListBox answer_box4 = new ListBox();//Невидимый listbox с четвертым ответом
        ListBox answer_box = new ListBox();//Невидимый listbox с правильным ответом
        ListBox RandomNumbers = new ListBox();//Невидимый listbox с рандомными числами
        bool starter;
        Random myRnd = new Random();
        int q;//номер вопроса из базы данных
        int number;//номер вопросам по порядку
        int spisok;//колличество правильных ответов
        int numbers;//рандомное число из списка ListBox RandomNumbers
        int p;//сумма выигрыша (номер из checkedListBox1)
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmMillioner_Load(object sender, EventArgs e)
        {
           
            question_box.Items.Add("Сколько веков стоит город Санкт-Петербург?");
            question_box.Items.Add("Сколько продолжалась блокада Ленинграда?");
            question_box.Items.Add("Какая станция метро ближайшая к Медному всаднику?");
            question_box.Items.Add("Как называются фигуры на Банковском мосту?");
            question_box.Items.Add("У какого вокзала стоит памятник 'Ленин на броневике'?");
            question_box.Items.Add("Какой адрес Зимнего дворца?");
            question_box.Items.Add("На каком острове расположена Петропавловская крепость?");
            question_box.Items.Add("Петербургская команда по футболу называется:");
            question_box.Items.Add("Где находится дворец 'Мое удовольствие'?");
            question_box.Items.Add("Какой мост в Петербурге самый широкий?");
            question_box.Items.Add("Есть ли 8 марта в Австралии?");
            question_box.Items.Add("Больному нужно сделать пять уколов, по уколу через каждые полчаса. Сколько на это потребуется времени?");
            question_box.Items.Add("На руках 10 пальцев. Сколько пальцев на 10 руках?");
            question_box.Items.Add("Обычно месяц заканчивается 30 или 31 числом. В каком месяце есть 28 число?");
            question_box.Items.Add("Где находится Панель задач?");
            question_box.Items.Add("Какое число делится на все числа без остатка?");
            question_box.Items.Add("В информатике 'Винт' - это:");
            question_box.Items.Add("К чему можно отнести выражение:'А все-таки она вертится'?");
            question_box.Items.Add("Конфета и фантик стоят вместе 10 копеек. Конфета на 8 копеек дороже. Сколько стоит конфета и сколько фантик?");
            question_box.Items.Add("Во сколько раз километр длиннее карата?");

            answer_box1.Items.Add("300");
            answer_box2.Items.Add("почти 3");
            answer_box3.Items.Add("3");
            answer_box4.Items.Add("1703");
            answer_box1.Items.Add("900 дней");
            answer_box2.Items.Add("1000 дней");
            answer_box3.Items.Add("1200 дней");
            answer_box4.Items.Add("3 года");
            answer_box1.Items.Add("Невский проспект");
            answer_box2.Items.Add("Садовая (Сенная)");
            answer_box3.Items.Add("Чернышевская");
            answer_box4.Items.Add("Адмиралтейская");
            answer_box1.Items.Add("Сфинксы");
            answer_box2.Items.Add("Грифоны");
            answer_box3.Items.Add("Бюсты");
            answer_box4.Items.Add("Гардемарины");
            answer_box1.Items.Add("У Ленинского");
            answer_box2.Items.Add("У Витебского");
            answer_box3.Items.Add("У Финляндского");
            answer_box4.Items.Add("У Московского");
            answer_box1.Items.Add("Дворцовая набережная, 1");
            answer_box2.Items.Add("Дворцовая набережная, 2");
            answer_box3.Items.Add("Дворцовая набережная, 34");
            answer_box4.Items.Add("Нева, 8");
            answer_box1.Items.Add("На Каменном");
            answer_box2.Items.Add("На Заячьем");
            answer_box3.Items.Add("На Волковом");
            answer_box4.Items.Add("На Лосином");
            answer_box1.Items.Add("Факел");
            answer_box2.Items.Add("Плакал");
            answer_box3.Items.Add("Зенит");
            answer_box4.Items.Add("Аршавин-ball");
            answer_box1.Items.Add("Пушкин");
            answer_box2.Items.Add("Павловск");
            answer_box3.Items.Add("Петергоф");
            answer_box4.Items.Add("Гатчина");
            answer_box1.Items.Add("Красный");
            answer_box2.Items.Add("Синий");
            answer_box3.Items.Add("Певческий");
            answer_box4.Items.Add("Литейный");
            answer_box1.Items.Add("Да");
            answer_box2.Items.Add("Нет");
            answer_box3.Items.Add("8 марта празднуется только в Европе");
            answer_box4.Items.Add("8 марта вообще не существует");
            answer_box1.Items.Add("2,5 часа");
            answer_box2.Items.Add("3 часа");
            answer_box3.Items.Add("2 часа");
            answer_box4.Items.Add("1,5 часа");
            answer_box1.Items.Add("100");
            answer_box2.Items.Add("50");
            answer_box3.Items.Add("10");
            answer_box4.Items.Add("20");
            answer_box1.Items.Add("В феврале");
            answer_box2.Items.Add("Во всех");
            answer_box3.Items.Add("В летних");
            answer_box4.Items.Add("В зимних");
            answer_box1.Items.Add("Обычно снизу экрана монитора");
            answer_box2.Items.Add("Занимает весь экран");
            answer_box3.Items.Add("На пульте телевизора");
            answer_box4.Items.Add("В Главном меню");
            answer_box1.Items.Add("Целое");
            answer_box2.Items.Add("1");
            answer_box3.Items.Add("0");
            answer_box4.Items.Add("-1");
            answer_box1.Items.Add("Вентилятор охлаждения процессора");
            answer_box2.Items.Add("Жесткий магнитный диск");
            answer_box3.Items.Add("Регулятор яркости монитора");
            answer_box4.Items.Add("Винт крепления материнской платы");
            answer_box1.Items.Add("Дискета");
            answer_box2.Items.Add("Мышь");
            answer_box3.Items.Add("Системная шина");
            answer_box4.Items.Add("Клавиатура");
            answer_box1.Items.Add("8 и 2");
            answer_box2.Items.Add("9 и 1");
            answer_box3.Items.Add("10 и 0");
            answer_box4.Items.Add("7 и 3");
            answer_box1.Items.Add("В 1000");
            answer_box2.Items.Add("В 10 000");
            answer_box3.Items.Add("Так не бывает");
            answer_box4.Items.Add("Бывает в Южном полушарии");

            answer_box.Items.Add("3");
            answer_box.Items.Add("900 дней");
            answer_box.Items.Add("Садовая (Сенная)");
            answer_box.Items.Add("Грифоны");
            answer_box.Items.Add("У Финляндского");
            answer_box.Items.Add("Дворцовая набережная, 34");
            answer_box.Items.Add("На Заячьем");
            answer_box.Items.Add("Зенит");
            answer_box.Items.Add("Петергоф");
            answer_box.Items.Add("Синий");
            answer_box.Items.Add("Да");
            answer_box.Items.Add("2 часа");
            answer_box.Items.Add("50");
            answer_box.Items.Add("Во всех");
            answer_box.Items.Add("Обычно снизу экрана монитора");
            answer_box.Items.Add("0");
            answer_box.Items.Add("Жесткий магнитный диск");
            answer_box.Items.Add("Дискета");
            answer_box.Items.Add("9 и 1");
            answer_box.Items.Add("Так не бывает");
            number = 0;
            spisok = 0;
            q= 1;
        }
        private void start_Click(object sender, EventArgs e)
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            label3.Visible = true;
            number++;
            label3.Text = "Вопрос №" + number.ToString();
           
            panel1.Enabled = true;
            if (starter)
            {
                if (radioButton1.Checked == true)
                {
                    if (radioButton1.Text.ToString() == answer_box.Items[q].ToString())
                    {
                        radioButton1.BackColor = Color.Green;
                        MessageBox.Show("Правильно!");
                        spisok++;

                    }
                    else
                   
                    {
                        radioButton1.BackColor = Color.Red;


                        if (radioButton1.Text.ToString() == answer_box.Items[q].ToString())
                        {
                            radioButton1.BackColor = Color.Green;
                        }
                        else
                        {
                            if (radioButton2.Text.ToString() == answer_box.Items[q].ToString())
                            {
                                radioButton2.BackColor = Color.Green;
                            }
                            else
                            {
                                if (radioButton3.Text.ToString() == answer_box.Items[q].ToString())
                                {
                                    radioButton3.BackColor = Color.Green;
                                }
                                else
                                {
                                    if (radioButton4.Text.ToString() == answer_box.Items[q].ToString())
                                    {

                                        radioButton4.BackColor = Color.Green;
                                    }
                                }
                            }
                        }
                        MessageBox.Show("Неправильно!\n" + "Правильный ответ: \n" + answer_box.Items[q].ToString());

                    }

                }
                else
                {
                    if (radioButton2.Checked == true)
                    {
                        if (radioButton2.Text.ToString() == answer_box.Items[q].ToString())
                        {
                            radioButton2.BackColor = Color.Green;
                            MessageBox.Show("Правильно!");
                            spisok++;

                        }
                        else
                       
                        {
                            radioButton2.BackColor = Color.Red;

                            if (radioButton1.Text.ToString() == answer_box.Items[q].ToString())
                            {
                                radioButton1.BackColor = Color.Green;
                            }
                            else
                            {
                                if (radioButton2.Text.ToString() == answer_box.Items[q].ToString())
                                {
                                    radioButton2.BackColor = Color.Green;
                                }
                                else
                                {
                                    if (radioButton3.Text.ToString() == answer_box.Items[q].ToString())
                                    {
                                        radioButton3.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (radioButton4.Text.ToString() == answer_box.Items[q].ToString())
                                        {
                                            radioButton4.BackColor = Color.Green;
                                        }
                                    }
                                }
                            }
                            MessageBox.Show("Неправильно!\n" + "Правильный ответ: \n" + answer_box.Items[q].ToString());
                        }
                    }


                    else
                    {
                        if (radioButton3.Checked == true)
                        {
                            if (radioButton3.Text.ToString() == answer_box.Items[q].ToString())
                            {

                                radioButton3.BackColor = Color.Green;
                                MessageBox.Show("Правильно!");
                                spisok++;
                            }
                            else
                            
                            {
                                radioButton3.BackColor = Color.Red;

                                if (radioButton1.Text.ToString() == answer_box.Items[q].ToString())
                                {
                                    radioButton1.BackColor = Color.Green;
                                }
                                else
                                {
                                    if (radioButton2.Text.ToString() == answer_box.Items[q].ToString())
                                    {
                                        radioButton2.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (radioButton3.Text.ToString() == answer_box.Items[q].ToString())
                                        {
                                            radioButton3.BackColor = Color.Green;
                                        }
                                        else
                                        {
                                            if (radioButton4.Text.ToString() == answer_box.Items[q].ToString())
                                            {
                                                radioButton4.BackColor = Color.Green;
                                            }
                                        }
                                    }
                                }
                                MessageBox.Show("Неправильно!\n" + "Правильный ответ: \n" + answer_box.Items[q].ToString());

                            }
                        }
                        else
                        {
                            if (radioButton4.Checked == true)
                            {
                                if (radioButton4.Text.ToString() == answer_box.Items[q].ToString())
                                {
                                    radioButton4.BackColor = Color.Green;
                                    MessageBox.Show("Правильно!");
                                    spisok++;

                                }
                                else
                             
                                {
                                    radioButton4.BackColor = Color.Red;

                                    if (radioButton1.Text.ToString() == answer_box.Items[q].ToString())
                                    {
                                        radioButton1.BackColor = Color.Green;
                                    }
                                    else
                                    {
                                        if (radioButton2.Text.ToString() == answer_box.Items[q].ToString())
                                        {
                                            radioButton2.BackColor = Color.Green;
                                        }
                                        else
                                        {
                                            if (radioButton3.Text.ToString() == answer_box.Items[q].ToString())
                                            {
                                                radioButton3.BackColor = Color.Green;
                                            }
                                            else
                                            {
                                                if (radioButton4.Text.ToString() == answer_box.Items[q].ToString())
                                                {
                                                    radioButton4.BackColor = Color.Green;
                                                }
                                            }
                                        }
                                    }
                                    MessageBox.Show("Неправильно!\n" + "Правильный ответ: \n" + answer_box.Items[q].ToString());
                                }
                            }
                        }
                    }
                }
            }



            else
            {
                start.Text = "Ответить";
                starter = true;
                RandomNumbers.Items.Clear();
                for (int i = 0; i < 20; i++)
                {
                    RandomNumbers.Items.Add(i);//В список добавляется 20 чисел 
                }
                //Числа в списке перемешиваются 
                Random myRnd = new Random();
                int t;
                for (int i = 0; i < RandomNumbers.Items.Count; i++)
                {
                    int m = myRnd.Next(RandomNumbers.Items.Count);
                    int n = myRnd.Next(RandomNumbers.Items.Count);
                    t = (int)RandomNumbers.Items[i];
                    RandomNumbers.Items[i] = RandomNumbers.Items[m];
                    RandomNumbers.Items[m] = t;
                    numbers = 0;
                }
            }


            q = (int)RandomNumbers.Items[numbers];//числа по порядку(каждый раз по нажатию на кнопку) присваиваются к переменной 
            for (int i = 0; i < spisok; i++)
            {

                p = 11 - i;

                checkedListBox1.SetItemChecked(p, true);//В checkedlistbox отмечена сумма которую вы уже заработали
            }
             
                if (numbers == 12)
                {
                    numbers = 0;
                    if (spisok == 0)
                    {
                        //Сброс настроек для начала новой игры
                        start.Text = "Начали";
                        number = 0;
                        starter = false;
                        spisok = 0;
                        for (int i = 0; i < 12; i++)
                        {
                            checkedListBox1.SetItemChecked(i, false);
                        }
                        textBox1.Text = " ";
                        radioButton1.Text = " ";
                        radioButton2.Text = " ";
                        radioButton3.Text = " ";
                        radioButton4.Text = " ";
                        radioButton1.Visible = false;
                        radioButton2.Visible = false;
                        radioButton3.Visible = false;
                        radioButton4.Visible = false;
                        label3.Visible = false;

                        MessageBox.Show("Игра закончена!!!\r\n" + "Вы не выиграли денег.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);//Вывод суммы выигрыша в отдельном окне
                    }
                    else
                    {
                        //Сброс настроек для начала новой игры
                        number = 0;
                        starter = false;
                        spisok = 0;
                        for (int i = 0; i < 12; i++)
                        {
                            checkedListBox1.SetItemChecked(i, false);
                        }
                        textBox1.Text = "";
                        radioButton1.Text = "";
                        radioButton2.Text = "";
                        radioButton3.Text = "";
                        radioButton4.Text = "";
                        radioButton1.Visible = false;
                        radioButton2.Visible = false;
                        radioButton3.Visible = false;
                        radioButton4.Visible = false;
                        label3.Visible = false;
                        MessageBox.Show("Игра закончена!!!\r\n" + "Вы выиграли " + (string)checkedListBox1.Items[p] + " рублей.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);//Вывод суммы выигрыша в отдельном окне
                        start.Text = "Начали";
                       
                    }
                }
                else
                {
                    //Программа выводит новый вопрос и новые варианты ответа
                    numbers++;
                    textBox1.Text = question_box.Items[q].ToString();
                    radioButton1.Text = answer_box1.Items[q].ToString();
                    radioButton2.Text = answer_box2.Items[q].ToString();
                    radioButton3.Text = answer_box3.Items[q].ToString();
                    radioButton4.Text = answer_box4.Items[q].ToString();
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton1.BackColor = Color.Orange;
                    radioButton2.BackColor = Color.Orange;
                    radioButton3.BackColor = Color.Orange;
                    radioButton4.BackColor = Color.Orange;
                  
                }




              
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            radioButton1.BackColor = Color.Yellow;
            radioButton2.BackColor = Color.Orange;
            radioButton3.BackColor = Color.Orange;
            radioButton4.BackColor = Color.Orange;

        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            radioButton1.BackColor = Color.Orange;
            radioButton2.BackColor = Color.Yellow;
            radioButton3.BackColor = Color.Orange;
            radioButton4.BackColor = Color.Orange;
        }

        private void radioButton3_MouseClick(object sender, MouseEventArgs e)
        {
            radioButton1.BackColor = Color.Orange;
            radioButton2.BackColor = Color.Orange;
            radioButton3.BackColor = Color.Yellow;
            radioButton4.BackColor = Color.Orange;
        }

        private void radioButton4_MouseClick(object sender, MouseEventArgs e)
        {
            radioButton1.BackColor = Color.Orange;
            radioButton2.BackColor = Color.Orange;
            radioButton3.BackColor = Color.Orange;
            radioButton4.BackColor = Color.Yellow;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void information_Click(object sender, EventArgs e)
        {
            Form3 frm;
             frm = new Form3();
             frm.ShowDialog();
             
        }


    }
}

