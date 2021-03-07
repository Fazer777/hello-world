using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\TASK4");

        public Form1()
        {
    
                InitializeComponent();
           
            int Condition = Properties.Settings.Default.condition; // Условие для вывода конкретного значения
            int Colour = Properties.Settings.Default.Colour; // Условие для вывода цвета
             Properties.Settings.Default.open_sum++; // Количество запусков программы
            int open_sum = Properties.Settings.Default.open_sum;
            Properties.Settings.Default.Save(); // Сохранение переменных
            if (open_sum == 1) // Определение какой посчету запуск программы
            {
            }
            else
            {
                using (key.OpenSubKey(@"SOFTWARE\TASK4"))
                {
                    textBox1.Text = key.GetValue("Параметр").ToString(); // При повторном запуске программы выводим текст пользователя
                }

                using (key.OpenSubKey(@"SOFTWARE\TASK4")) // Цикл определения размера окна из реестра
                {
                    if (Condition == 1) 
                    {
                        this.Height = (int)key.GetValue("Высота окна");
                        this.Width = (int)key.GetValue("Ширина окна");
                    }
                    else if (Condition == 2)
                    {
                        this.Height = (int)key.GetValue("Высота окна");
                        this.Width = (int)key.GetValue("Ширина окна");
                    }
                    else if (Condition == 3)
                    {
                        this.Height = (int)key.GetValue("Высота окна");
                        this.Width = (int)key.GetValue("Ширина окна");
                    }
                    else if (Condition == 4)
                    {
                        this.Height = (int)key.GetValue("Высота окна");
                        this.Width = (int)key.GetValue("Ширина окна");
                    }
                }

                using (key.OpenSubKey(@"SOFTWARE\TASK4")) // Цикл определения размера окна из реестра
                {
                    if (Colour == 1)
                    {
                        string Code = (string)key.GetValue("ЦветФона");
                        this.BackColor = ColorTranslator.FromHtml(Code);
                    }
                    else if (Colour == 2)
                    {
                        string Code = (string)key.GetValue("ЦветФона");
                        this.BackColor = ColorTranslator.FromHtml(Code);
                    }
                    else if (Colour == 3)
                    {
                        string Code = (string)key.GetValue("ЦветФона");
                        this.BackColor = ColorTranslator.FromHtml(Code);
                    }
                    else if (Colour == 4)
                    {
                        string Code = (string)key.GetValue("ЦветФона");
                        this.BackColor = ColorTranslator.FromHtml(Code);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            using (key.OpenSubKey(@"SOFTWARE\TASK4"))
            {
                string Parametr = textBox1.Text; // Записываем введеный текст пользователем в переменную
                key.SetValue("Параметр", Parametr);// Создаем параметр со значением (значение - введеный текст пользователем)
            }
        }

        private void button1_Click(object sender, EventArgs e) // Разрешение окна 640 х 480 (кнопка 1)
        {
            Properties.Settings.Default.condition = 1; 
            Properties.Settings.Default.Save();
            int Height = this.Height = 480;
            int Width = this.Width = 640;
            using (key.OpenSubKey(@"SOFTWARE\TASK4"))
            {
                key.SetValue("Высота окна", Height);
                key.SetValue("Ширина окна", Width);
            }

        }

        private void button4_Click(object sender, EventArgs e)  // Разрешение окна 750 х 450 (кнопка 4)
        {
            Properties.Settings.Default.condition = 2;
            Properties.Settings.Default.Save();
            int Height = this.Height = 450;
            int Width = this.Width = 750;
            using (key.OpenSubKey(@"SOFTWARE\TASK4"))
            {
                key.SetValue("Высота окна", Height);
                key.SetValue("Ширина окна", Width);
            }
        }

        private void button2_Click(object sender, EventArgs e)// Разрешение окна 800 х 600
        {
            Properties.Settings.Default.condition = 3;
            Properties.Settings.Default.Save();
            int Height = this.Height = 600;
            int Width = this.Width = 800;
            using (key.OpenSubKey(@"SOFTWARE\TASK4"))
            {
                key.SetValue("Высота окна", Height);
                key.SetValue("Ширина окна", Width);
            }
        }

        private void button3_Click(object sender, EventArgs e)// Разрешение окна 816 х 489 (стандартное разрешение окна WinForms)
        {
            Properties.Settings.Default.condition = 4;
            Properties.Settings.Default.Save();
            int Height = this.Height = 489;
            int Width = this.Width = 816;
            using (key.OpenSubKey(@"SOFTWARE\TASK4"))
            {
                key.SetValue("Высота окна", Height);
                key.SetValue("Ширина окна", Width);
            }
        }

        private void button5_Click(object sender, EventArgs e)// Смена цвета фона на БЕЛЫЙ
        {
            string CodeColor = "#FFFFFF";
            this.BackColor = Color.White;
            Properties.Settings.Default.Colour = 1;
            Properties.Settings.Default.Save();
            using (key.OpenSubKey(@"SOFTWARE\TASK4"))
            {
                key.SetValue("ЦветФона", CodeColor);
            }
        }
        private void button6_Click(object sender, EventArgs e) // Смена цвета фона на ЗЕЛЕНЫЙ
        {
            string CodeColor = "#FF008000";
            this.BackColor = Color.Green;
            Properties.Settings.Default.Colour = 2; 
            Properties.Settings.Default.Save();
            
            using (key.OpenSubKey(@"SOFTWARE\TASK4"))
            {
                key.SetValue("ЦветФона", CodeColor);
            }
        }
        private void button7_Click(object sender, EventArgs e)// Смена цвета фона на ЖЕЛТЫЙ
        {
            string CodeColor = "#FFFF00";
            this.BackColor = Color.Yellow;
            Properties.Settings.Default.Colour = 3; 
            Properties.Settings.Default.Save();
            using (key.OpenSubKey(@"SOFTWARE\TASK4"))
            {
                key.SetValue("ЦветФона", CodeColor);
            }
        }
        private void button8_Click(object sender, EventArgs e) // Смена цвета фона на СЕРЫЙ
        {
            string CodeColor = "#808080";
            this.BackColor = Color.Gray;
            Properties.Settings.Default.Colour = 4; 
            Properties.Settings.Default.Save();
            using (key.OpenSubKey(@"SOFTWARE\TASK4"))
            {
                key.SetValue("ЦветФона", CodeColor);
            }
        }
    }
}
