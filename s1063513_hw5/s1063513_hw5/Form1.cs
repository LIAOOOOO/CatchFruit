using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s1063513_hw5
{
    public partial class Form1 : Form
    {
        
        int x;
        int y;
        Image img0 = Properties.Resources._8_0;
        Image img1 = Properties.Resources._8_1;
        Image img2 = Properties.Resources._8_2;
        Image img3 = Properties.Resources._8_3;
        Image img4 = Properties.Resources._8_4;
        Image img5 = Properties.Resources._8_5;
        Image img6 = Properties.Resources._8_6;
        Image img7 = Properties.Resources._8_7;
        Image img8 = Properties.Resources._8_8;
        Rectangle rect1;
        Rectangle rect2;
        Rectangle rect3;
        Rectangle rect4;
        Rectangle rect5;
        Rectangle rect6;
        Rectangle rect7;
        Rectangle rect8;
        Rectangle rect9;
        Rectangle rect10;
        Rectangle rect11;
        Rectangle rect12;
        Rectangle rect13;
        Rectangle rect14;
        Rectangle rect15;
        Rectangle rect16;
        int time = 0;
        int buffer = 0;
        bool play = true;
        bool yes = true;
        List<int> pos = new List<int>();
        List<int> chose = new List<int>();
        List<bool> ok = new List<bool>();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            label1.Text = time.ToString() + "Seconds";
            x = this.ClientSize.Width / 2; // 視窗客戶區的中心點
            y = this.ClientSize.Height / 2;
            rect1 = new Rectangle(x - 100, y - 100, 50, 50);
            rect2 = new Rectangle(x - 100, y - 50, 50, 50);
            rect3 = new Rectangle(x - 100, y, 50, 50);
            rect4 = new Rectangle(x - 100, y + 50, 50, 50);
            rect5 = new Rectangle(x - 50, y - 100, 50, 50);
            rect6 = new Rectangle(x - 50, y - 50, 50, 50);
            rect7 = new Rectangle(x - 50, y, 50, 50);
            rect8 = new Rectangle(x - 50, y + 50, 50, 50);
            rect9 = new Rectangle(x, y - 100, 50, 50);
            rect10 = new Rectangle(x, y - 50, 50, 50);
            rect11 = new Rectangle(x, y, 50, 50);
            rect12 = new Rectangle(x, y + 50, 50, 50);
            rect13 = new Rectangle(x + 50, y - 100, 50, 50);
            rect14 = new Rectangle(x + 50, y - 50, 50, 50);
            rect15 = new Rectangle(x + 50, y, 50, 50);
            rect16 = new Rectangle(x + 50, y + 50, 50, 50);

            Graphics gr1 = this.CreateGraphics();
            Graphics gr2 = this.CreateGraphics();
            Graphics gr3 = this.CreateGraphics();
            Graphics gr4 = this.CreateGraphics();
            Graphics gr5 = this.CreateGraphics();
            Graphics gr6 = this.CreateGraphics();
            Graphics gr7 = this.CreateGraphics();
            Graphics gr8 = this.CreateGraphics();
            Graphics gr9 = this.CreateGraphics();
            Graphics gr10 = this.CreateGraphics();
            Graphics gr11 = this.CreateGraphics();
            Graphics gr12 = this.CreateGraphics();
            Graphics gr13 = this.CreateGraphics();
            Graphics gr14 = this.CreateGraphics();
            Graphics gr15 = this.CreateGraphics();
            Graphics gr16 = this.CreateGraphics();
            gr1.DrawRectangle(Pens.Black, rect1);
            gr2.DrawRectangle(Pens.Black, rect2);
            gr3.DrawRectangle(Pens.Black, rect3);
            gr4.DrawRectangle(Pens.Black, rect4);
            gr5.DrawRectangle(Pens.Black, rect5);
            gr6.DrawRectangle(Pens.Black, rect6);
            gr7.DrawRectangle(Pens.Black, rect7);
            gr8.DrawRectangle(Pens.Black, rect8);
            gr9.DrawRectangle(Pens.Black, rect9);
            gr10.DrawRectangle(Pens.Black, rect10);
            gr11.DrawRectangle(Pens.Black, rect11);
            gr12.DrawRectangle(Pens.Black, rect12);
            gr13.DrawRectangle(Pens.Black, rect13);
            gr14.DrawRectangle(Pens.Black, rect14);
            gr15.DrawRectangle(Pens.Black, rect15);
            gr16.DrawRectangle(Pens.Black, rect16);
            Random rd = new Random();
            int r;
            pos.Clear();
            for (int i = 0; i < 16; i++)
            {
            a:
                r = rd.Next(16);
                for (int j = 0; j < pos.Count; j++)
                {
                    if (pos[j] == r)
                        goto a;
                }
                pos.Add(r);
                ok.Add(false);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics gr1 = this.CreateGraphics();
            Graphics gr2 = this.CreateGraphics();
            Graphics gr3 = this.CreateGraphics();
            Graphics gr4 = this.CreateGraphics();
            Graphics gr5 = this.CreateGraphics();
            Graphics gr6 = this.CreateGraphics();
            Graphics gr7 = this.CreateGraphics();
            Graphics gr8 = this.CreateGraphics();
            Graphics gr9 = this.CreateGraphics();
            Graphics gr10 = this.CreateGraphics();
            Graphics gr11 = this.CreateGraphics();
            Graphics gr12 = this.CreateGraphics();
            Graphics gr13 = this.CreateGraphics();
            Graphics gr14 = this.CreateGraphics();
            Graphics gr15 = this.CreateGraphics();
            Graphics gr16 = this.CreateGraphics();
            gr1.DrawRectangle(Pens.Black, rect1);
            gr2.DrawRectangle(Pens.Black, rect2);
            gr3.DrawRectangle(Pens.Black, rect3);
            gr4.DrawRectangle(Pens.Black, rect4);
            gr5.DrawRectangle(Pens.Black, rect5);
            gr6.DrawRectangle(Pens.Black, rect6);
            gr7.DrawRectangle(Pens.Black, rect7);
            gr8.DrawRectangle(Pens.Black, rect8);
            gr9.DrawRectangle(Pens.Black, rect9);
            gr10.DrawRectangle(Pens.Black, rect10);
            gr11.DrawRectangle(Pens.Black, rect11);
            gr12.DrawRectangle(Pens.Black, rect12);
            gr13.DrawRectangle(Pens.Black, rect13);
            gr14.DrawRectangle(Pens.Black, rect14);
            gr15.DrawRectangle(Pens.Black, rect15);
            gr16.DrawRectangle(Pens.Black, rect16);
            if (yes)
            {
                Graphics g1 = this.CreateGraphics();
                if (rect1.Contains(e.Location))
                {
                    gr1.DrawRectangle(Pens.Black, rect1);
                    chose.Add(pos[0]);
                    int a = pos[0] % 8;
                    if (a == 1)
                        g1.DrawImage(img1, rect1);
                    else if (a == 2)
                        g1.DrawImage(img2, rect1);
                    else if (a == 3)
                        g1.DrawImage(img3, rect1);
                    else if (a == 4)
                        g1.DrawImage(img4, rect1);
                    else if (a == 5)
                        g1.DrawImage(img5, rect1);
                    else if (a == 6)
                        g1.DrawImage(img6, rect1);
                    else if (a == 7)
                        g1.DrawImage(img7, rect1);
                    else if (a == 0)
                        g1.DrawImage(img8, rect1);
                }

                if (rect2.Contains(e.Location))
                {
                    chose.Add(pos[1]);
                    int a = pos[1] % 8;
                    if (a == 1)
                        g1.DrawImage(img1, rect2);
                    else if (a == 2)
                        g1.DrawImage(img2, rect2);
                    else if (a == 3)
                        g1.DrawImage(img3, rect2);
                    else if (a == 4)
                        g1.DrawImage(img4, rect2);
                    else if (a == 5)
                        g1.DrawImage(img5, rect2);
                    else if (a == 6)
                        g1.DrawImage(img6, rect2);
                    else if (a == 7)
                        g1.DrawImage(img7, rect2);
                    else if (a == 0)
                        g1.DrawImage(img8, rect2);
                }

                if (rect3.Contains(e.Location))
                {
                    chose.Add(pos[2]);
                    int a = pos[2] % 8;
                    if (a == 1)
                        g1.DrawImage(img1, rect3);
                    else if (a == 2)
                        g1.DrawImage(img2, rect3);
                    else if (a == 3)
                        g1.DrawImage(img3, rect3);
                    else if (a == 4)
                        g1.DrawImage(img4, rect3);
                    else if (a == 5)
                        g1.DrawImage(img5, rect3);
                    else if (a == 6)
                        g1.DrawImage(img6, rect3);
                    else if (a == 7)
                        g1.DrawImage(img7, rect3);
                    else if (a == 0)
                        g1.DrawImage(img8, rect3);
                }

                if (rect4.Contains(e.Location))
                {
                    chose.Add(pos[3]);
                    int a = pos[3] % 8;
                    if (a == 1)
                        g1.DrawImage(img1, rect4);
                    else if (a == 2)
                        g1.DrawImage(img2, rect4);
                    else if (a == 3)
                        g1.DrawImage(img3, rect4);
                    else if (a == 4)
                        g1.DrawImage(img4, rect4);
                    else if (a == 5)
                        g1.DrawImage(img5, rect4);
                    else if (a == 6)
                        g1.DrawImage(img6, rect4);
                    else if (a == 7)
                        g1.DrawImage(img7, rect4);
                    else if (a == 0)
                        g1.DrawImage(img8, rect4);
                }

                if (rect5.Contains(e.Location))
                {
                    chose.Add(pos[4]);
                    int a = pos[4] % 8;
                    if (a == 1)
                        g1.DrawImage(img1, rect5);
                    else if (a == 2)
                        g1.DrawImage(img2, rect5);
                    else if (a == 3)
                        g1.DrawImage(img3, rect5);
                    else if (a == 4)
                        g1.DrawImage(img4, rect5);
                    else if (a == 5)
                        g1.DrawImage(img5, rect5);
                    else if (a == 6)
                        g1.DrawImage(img6, rect5);
                    else if (a == 7)
                        g1.DrawImage(img7, rect5);
                    else if (a == 0)
                        g1.DrawImage(img8, rect5);
                }

                if (rect6.Contains(e.Location))
                {
                    chose.Add(pos[5]);
                    int a = pos[5] % 8;
                    if (a == 1)
                        g1.DrawImage(img1, rect6);
                    else if (a == 2)
                        g1.DrawImage(img2, rect6);
                    else if (a == 3)
                        g1.DrawImage(img3, rect6);
                    else if (a == 4)
                        g1.DrawImage(img4, rect6);
                    else if (a == 5)
                        g1.DrawImage(img5, rect6);
                    else if (a == 6)
                        g1.DrawImage(img6, rect6);
                    else if (a == 7)
                        g1.DrawImage(img7, rect6);
                    else if (a == 0)
                        g1.DrawImage(img8, rect6);
                }

                if (rect7.Contains(e.Location))
                {
                    chose.Add(pos[6]);
                    int a = pos[6] % 8;
                    if (a == 1)
                        g1.DrawImage(img1, rect7);
                    else if (a == 2)
                        g1.DrawImage(img2, rect7);
                    else if (a == 3)
                        g1.DrawImage(img3, rect7);
                    else if (a == 4)
                        g1.DrawImage(img4, rect7);
                    else if (a == 5)
                        g1.DrawImage(img5, rect7);
                    else if (a == 6)
                        g1.DrawImage(img6, rect7);
                    else if (a == 7)
                        g1.DrawImage(img7, rect7);
                    else if (a == 0)
                        g1.DrawImage(img8, rect7);
                }

                if (rect8.Contains(e.Location))
                {
                    chose.Add(pos[7]);
                    int a = pos[7] % 8;
                    if (a == 1)
                        g1.DrawImage(img1, rect8);
                    else if (a == 2)
                        g1.DrawImage(img2, rect8);
                    else if (a == 3)
                        g1.DrawImage(img3, rect8);
                    else if (a == 4)
                        g1.DrawImage(img4, rect8);
                    else if (a == 5)
                        g1.DrawImage(img5, rect8);
                    else if (a == 6)
                        g1.DrawImage(img6, rect8);
                    else if (a == 7)
                        g1.DrawImage(img7, rect8);
                    else if (a == 0)
                        g1.DrawImage(img8, rect8);
                }

                if (rect9.Contains(e.Location))
                {
                    chose.Add(pos[8]);
                    int a = pos[8] % 8;
                    if (a == 1)
                        g1.DrawImage(img1, rect9);
                    else if (a == 2)
                        g1.DrawImage(img2, rect9);
                    else if (a == 3)
                        g1.DrawImage(img3, rect9);
                    else if (a == 4)
                        g1.DrawImage(img4, rect9);
                    else if (a == 5)
                        g1.DrawImage(img5, rect9);
                    else if (a == 6)
                        g1.DrawImage(img6, rect9);
                    else if (a == 7)
                        g1.DrawImage(img7, rect9);
                    else if (a == 0)
                        g1.DrawImage(img8, rect9);
                }

                if (rect10.Contains(e.Location))
                {
                    chose.Add(pos[9]);
                    int a = pos[9] % 8;
                    if (a == 1)
                        g1.DrawImage(img1, rect10);
                    else if (a == 2)
                        g1.DrawImage(img2, rect10);
                    else if (a == 3)
                        g1.DrawImage(img3, rect10);
                    else if (a == 4)
                        g1.DrawImage(img4, rect10);
                    else if (a == 5)
                        g1.DrawImage(img5, rect10);
                    else if (a == 6)
                        g1.DrawImage(img6, rect10);
                    else if (a == 7)
                        g1.DrawImage(img7, rect10);
                    else if (a == 0)
                        g1.DrawImage(img8, rect10);
                }

                if (rect11.Contains(e.Location))
                {
                    chose.Add(pos[10]);
                    int a = pos[10] % 8;
                    if (a == 1)
                        g1.DrawImage(img1, rect11);
                    else if (a == 2)
                        g1.DrawImage(img2, rect11);
                    else if (a == 3)
                        g1.DrawImage(img3, rect11);
                    else if (a == 4)
                        g1.DrawImage(img4, rect11);
                    else if (a == 5)
                        g1.DrawImage(img5, rect11);
                    else if (a == 6)
                        g1.DrawImage(img6, rect11);
                    else if (a == 7)
                        g1.DrawImage(img7, rect11);
                    else if (a == 0)
                        g1.DrawImage(img8, rect11);
                }

                if (rect12.Contains(e.Location))
                {
                    chose.Add(pos[11]);
                    int a = pos[11] % 8;
                    if (a == 1)
                        g1.DrawImage(img1, rect12);
                    else if (a == 2)
                        g1.DrawImage(img2, rect12);
                    else if (a == 3)
                        g1.DrawImage(img3, rect12);
                    else if (a == 4)
                        g1.DrawImage(img4, rect12);
                    else if (a == 5)
                        g1.DrawImage(img5, rect12);
                    else if (a == 6)
                        g1.DrawImage(img6, rect12);
                    else if (a == 7)
                        g1.DrawImage(img7, rect12);
                    else if (a == 0)
                        g1.DrawImage(img8, rect12);
                }

                if (rect13.Contains(e.Location))
                {
                    chose.Add(pos[12]);
                    int a = pos[12] % 8;
                    if (a == 1)
                        g1.DrawImage(img1, rect13);
                    else if (a == 2)
                        g1.DrawImage(img2, rect13);
                    else if (a == 3)
                        g1.DrawImage(img3, rect13);
                    else if (a == 4)
                        g1.DrawImage(img4, rect13);
                    else if (a == 5)
                        g1.DrawImage(img5, rect13);
                    else if (a == 6)
                        g1.DrawImage(img6, rect13);
                    else if (a == 7)
                        g1.DrawImage(img7, rect13);
                    else if (a == 0)
                        g1.DrawImage(img8, rect13);
                }

                if (rect14.Contains(e.Location))
                {
                    chose.Add(pos[13]);
                    int a = pos[13] % 8;
                    if (a == 1)
                        g1.DrawImage(img1, rect14);
                    else if (a == 2)
                        g1.DrawImage(img2, rect14);
                    else if (a == 3)
                        g1.DrawImage(img3, rect14);
                    else if (a == 4)
                        g1.DrawImage(img4, rect14);
                    else if (a == 5)
                        g1.DrawImage(img5, rect14);
                    else if (a == 6)
                        g1.DrawImage(img6, rect14);
                    else if (a == 7)
                        g1.DrawImage(img7, rect14);
                    else if (a == 0)
                        g1.DrawImage(img8, rect14);
                }

                if (rect15.Contains(e.Location))
                {
                    chose.Add(pos[14]);
                    int a = pos[14] % 8;
                    if (a == 1)
                        g1.DrawImage(img1, rect15);
                    else if (a == 2)
                        g1.DrawImage(img2, rect15);
                    else if (a == 3)
                        g1.DrawImage(img3, rect15);
                    else if (a == 4)
                        g1.DrawImage(img4, rect15);
                    else if (a == 5)
                        g1.DrawImage(img5, rect15);
                    else if (a == 6)
                        g1.DrawImage(img6, rect15);
                    else if (a == 7)
                        g1.DrawImage(img7, rect15);
                    else if (a == 0)
                        g1.DrawImage(img8, rect15);
                }

                if (rect16.Contains(e.Location))
                {
                    chose.Add(pos[15]);
                    int a = pos[15] % 8;
                    if (a == 1)
                        g1.DrawImage(img1, rect16);
                    else if (a == 2)
                        g1.DrawImage(img2, rect16);
                    else if (a == 3)
                        g1.DrawImage(img3, rect16);
                    else if (a == 4)
                        g1.DrawImage(img4, rect16);
                    else if (a == 5)
                        g1.DrawImage(img5, rect16);
                    else if (a == 6)
                        g1.DrawImage(img6, rect16);
                    else if (a == 7)
                        g1.DrawImage(img7, rect16);
                    else if (a == 0)
                        g1.DrawImage(img8, rect16);
                }

                if (chose.Count == 2)
                {
                    buffer = time;
                    yes = false;
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics gr1 = this.CreateGraphics();
            Graphics gr2 = this.CreateGraphics();
            Graphics gr3 = this.CreateGraphics();
            Graphics gr4 = this.CreateGraphics();
            Graphics gr5 = this.CreateGraphics();
            Graphics gr6 = this.CreateGraphics();
            Graphics gr7 = this.CreateGraphics();
            Graphics gr8 = this.CreateGraphics();
            Graphics gr9 = this.CreateGraphics();
            Graphics gr10 = this.CreateGraphics();
            Graphics gr11 = this.CreateGraphics();
            Graphics gr12 = this.CreateGraphics();
            Graphics gr13 = this.CreateGraphics();
            Graphics gr14 = this.CreateGraphics();
            Graphics gr15 = this.CreateGraphics();
            Graphics gr16 = this.CreateGraphics();
            gr1.DrawRectangle(Pens.Black, rect1);
            gr2.DrawRectangle(Pens.Black, rect2);
            gr3.DrawRectangle(Pens.Black, rect3);
            gr4.DrawRectangle(Pens.Black, rect4);
            gr5.DrawRectangle(Pens.Black, rect5);
            gr6.DrawRectangle(Pens.Black, rect6);
            gr7.DrawRectangle(Pens.Black, rect7);
            gr8.DrawRectangle(Pens.Black, rect8);
            gr9.DrawRectangle(Pens.Black, rect9);
            gr10.DrawRectangle(Pens.Black, rect10);
            gr11.DrawRectangle(Pens.Black, rect11);
            gr12.DrawRectangle(Pens.Black, rect12);
            gr13.DrawRectangle(Pens.Black, rect13);
            gr14.DrawRectangle(Pens.Black, rect14);
            gr15.DrawRectangle(Pens.Black, rect15);
            gr16.DrawRectangle(Pens.Black, rect16);
            if (play)
            {
                Graphics g = this.CreateGraphics();
                g.DrawImage(img0, rect1);
                g.DrawImage(img0, rect2);
                g.DrawImage(img0, rect3);
                g.DrawImage(img0, rect4);
                g.DrawImage(img0, rect5);
                g.DrawImage(img0, rect6);
                g.DrawImage(img0, rect7);
                g.DrawImage(img0, rect8);
                g.DrawImage(img0, rect9);
                g.DrawImage(img0, rect10);
                g.DrawImage(img0, rect11);
                g.DrawImage(img0, rect12);
                g.DrawImage(img0, rect13);
                g.DrawImage(img0, rect14);
                g.DrawImage(img0, rect15);
                g.DrawImage(img0, rect16);

                gr1.DrawRectangle(Pens.Black, rect1);
                gr2.DrawRectangle(Pens.Black, rect2);
                gr3.DrawRectangle(Pens.Black, rect3);
                gr4.DrawRectangle(Pens.Black, rect4);
                gr5.DrawRectangle(Pens.Black, rect5);
                gr6.DrawRectangle(Pens.Black, rect6);
                gr7.DrawRectangle(Pens.Black, rect7);
                gr8.DrawRectangle(Pens.Black, rect8);
                gr9.DrawRectangle(Pens.Black, rect9);
                gr10.DrawRectangle(Pens.Black, rect10);
                gr11.DrawRectangle(Pens.Black, rect11);
                gr12.DrawRectangle(Pens.Black, rect12);
                gr13.DrawRectangle(Pens.Black, rect13);
                gr14.DrawRectangle(Pens.Black, rect14);
                gr15.DrawRectangle(Pens.Black, rect15);
                gr16.DrawRectangle(Pens.Black, rect16);
                play = false;
            }
            time++;
            label1.Text = time.ToString() + "Seconds";
            Graphics g1 = this.CreateGraphics();
            if (chose.Count == 2)
            {
                int a1 = chose[0];
                int a2 = chose[1];
                if (a1 % 8 != a2 % 8 && buffer != time)
                {
                    chose.Clear();
                    yes = true;
                    for (int i = 0; i < pos.Count; i++)
                    {
                        if (pos[i] == a1 || pos[i] == a2)
                        {
                            if (i == 0)
                                g1.DrawImage(img0, rect1);
                            else if (i == 1)
                                g1.DrawImage(img0, rect2);
                            else if (i == 2)
                                g1.DrawImage(img0, rect3);
                            else if (i == 3)
                                g1.DrawImage(img0, rect4);
                            else if (i == 4)
                                g1.DrawImage(img0, rect5);
                            else if (i == 5)
                                g1.DrawImage(img0, rect6);
                            else if (i == 6)
                                g1.DrawImage(img0, rect7);
                            else if (i == 7)
                                g1.DrawImage(img0, rect8);
                            else if (i == 8)
                                g1.DrawImage(img0, rect9);
                            else if (i == 9)
                                g1.DrawImage(img0, rect10);
                            else if (i == 10)
                                g1.DrawImage(img0, rect11);
                            else if (i == 11)
                                g1.DrawImage(img0, rect12);
                            else if (i == 12)
                                g1.DrawImage(img0, rect13);
                            else if (i == 13)
                                g1.DrawImage(img0, rect14);
                            else if (i == 14)
                                g1.DrawImage(img0, rect15);
                            else if (i == 15)
                                g1.DrawImage(img0, rect16);
                        }
                    }
                }
                else if (a1 % 8 == a2 % 8 && buffer != time)
                {
                    yes = true;
                    for (int i = 0; i < pos.Count; i++)
                    {
                        if (pos[i] == chose[0] || pos[i] == chose[1])
                        {
                            if (i == 0)
                                ok[0] = true;
                            else if (i == 1)
                                ok[1] = true;
                            else if (i == 2)
                                ok[2] = true;
                            else if (i == 3)
                                ok[3] = true;
                            else if (i == 4)
                                ok[4] = true;
                            else if (i == 5)
                                ok[5] = true;
                            else if (i == 6)
                                ok[6] = true;
                            else if (i == 7)
                                ok[7] = true;
                            else if (i == 8)
                                ok[8] = true;
                            else if (i == 9)
                                ok[9] = true;
                            else if (i == 10)
                                ok[10] = true;
                            else if (i == 11)
                                ok[11] = true;
                            else if (i == 12)
                                ok[12] = true;
                            else if (i == 13)
                                ok[13] = true;
                            else if (i == 14)
                                ok[14] = true;
                            else if (i == 15)
                                ok[15] = true;
                        }
                    }
                    chose.Clear();
                }

                for (int i = 0; i < ok.Count; i++)
                {
                    if (!ok[i])
                        break;
                    else if (i == ok.Count - 1)
                        timer1.Stop();
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, rect1); // 繪出矩形
            e.Graphics.DrawRectangle(Pens.Black, rect2);
            e.Graphics.DrawRectangle(Pens.Black, rect3);
            e.Graphics.DrawRectangle(Pens.Black, rect4); // 繪出矩形
            e.Graphics.DrawRectangle(Pens.Black, rect5);
            e.Graphics.DrawRectangle(Pens.Black, rect6);
            e.Graphics.DrawRectangle(Pens.Black, rect7); // 繪出矩形
            e.Graphics.DrawRectangle(Pens.Black, rect8);
            e.Graphics.DrawRectangle(Pens.Black, rect9);
            e.Graphics.DrawRectangle(Pens.Black, rect10);
            e.Graphics.DrawRectangle(Pens.Black, rect11); // 繪出矩形
            e.Graphics.DrawRectangle(Pens.Black, rect12);
            e.Graphics.DrawRectangle(Pens.Black, rect13);
            e.Graphics.DrawRectangle(Pens.Black, rect14); // 繪出矩形
            e.Graphics.DrawRectangle(Pens.Black, rect15);
            e.Graphics.DrawRectangle(Pens.Black, rect16);
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pos.Clear();
            ok.Clear();
            chose.Clear();
            play = true;
            time = 0;
            buffer = 0;
            Random rd = new Random();
            int r;
            for (int i = 0; i < 16; i++)
            {
            a:
                r = rd.Next(16);
                for (int j = 0; j < pos.Count; j++)
                {
                    if (pos[j] == r)
                        goto a;
                }
                pos.Add(r);
                ok.Add(false);
            }
            timer1.Start();
        }
    }
}
