﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinuVorm
{
    class films : Form
    {
        Button btne_sal_2;
        Button btne_sal_1;
        Button btne_sal_3;
        public films()
        {
            this.ClientSize = new System.Drawing.Size(390, 200);
            BackColor = Color.LightGray;
            this.Text = "Saali filmi";
            Label message = new Label();
            Button[] btn = new Button[4];
            string[] texts = new string[4];
            TableLayoutPanel tlp = new TableLayoutPanel();
            Button btn_tabel;
            int btn_w, btn_h;
            //int choose;

            btne_sal_1 = new Button();
            btne_sal_1.Text = "Тушканьчик зарождение";
            btne_sal_1.Location = new Point(250, 60);
            btne_sal_1.Height = 40;
            btne_sal_1.Width = 100;
            btne_sal_1.BackColor = Color.DarkGray;
            btne_sal_1.Font = new Font("Times New Roman", 10.0f);
            btne_sal_1.Click += Start_btn_2_Click1;
            /*if (btne_sal_1.KeyPress)
            {
                int choose = choose + 1;
            }*/

            btne_sal_2 = new Button();
            btne_sal_2.Text = "Тушканьчик потеря";
            btne_sal_2.Location = new Point(145, 60);
            btne_sal_2.Height = 40;
            btne_sal_2.Width = 100;
            btne_sal_2.BackColor = Color.DarkGray;
            btne_sal_2.Font = new Font("Times New Roman", 10.0f);
            btne_sal_2.Click += btne_Click;


            btne_sal_3 = new Button();
            btne_sal_3.Text = "Тушканьчик распятие";
            btne_sal_3.Location = new Point(40, 60);
            btne_sal_3.Height = 40;
            btne_sal_3.Width = 100;
            btne_sal_3.BackColor = Color.DarkGray;
            btne_sal_3.Font = new Font("Times New Roman", 10.0f);
            btne_sal_3.Click += Btne_sal_3_Click;



            this.Controls.Add(btne_sal_1);
            this.Controls.Add(btne_sal_2);
            this.Controls.Add(btne_sal_3);


        }

        private void Btne_sal_3_Click(object sender, EventArgs e)
        {
            Bilerid uus_aken = new Bilerid();
            this.Hide();
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }

        private void Start_btn_2_Click1(object sender, EventArgs e)
        {
            MyForm uus_aken = new MyForm(12, 12);
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }

        private void btne_Click(object sender, EventArgs e)                      //кол-во кнопок
        {
            MyForm uus_aken = new MyForm(9, 9);
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }
    }
}
