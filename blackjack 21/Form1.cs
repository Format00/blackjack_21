using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int sayac = 0;
        int sayacb = 0;
        int para = 500;
        int topbahis = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            button7.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            label13.Visible = true;
            label16.Text = para.ToString();
            para = 500;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button2.Enabled = true;
            sayac++;
            if (sayac == 1)
            {
                int a1, a2, toplam;
                a1 = rnd.Next(1, 11);
                a2 = rnd.Next(1, 11);
                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                toplam = a1 + a2;
                label11.Text = toplam.ToString();
                if (toplam == 21)
                {
                    label13.Text = "Kazandınız";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button7.Enabled = true;
                }
                if (toplam > 21)
                {
                    label13.Text = "Kaybettiniz";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button7.Enabled = true;
                }

                int b1, b2, toplamb;
                b1 = rnd.Next(1, 11);
                b2 = rnd.Next(1, 11);
                label8.Text = b1.ToString();
                label7.Text = b2.ToString();
                toplamb = b1 + b2;
                label12.Text = toplamb.ToString();
                if (toplamb == 21)
                {
                    label13.Text = "Kaybettiniz";
                    button7.Enabled = true;
                }
                if (toplamb > 21)
                {
                    label13.Text = "Kazandınız";
                    button7.Enabled = true;
                }


            }
            if (sayac == 2)
            {
                int a3, toplam;
                a3 = rnd.Next(1, 11);
                label3.Text = a3.ToString();

                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + a3;
                label11.Text = toplam.ToString();
                if (toplam == 21)
                {
                    label13.Text = "Kazandınız";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button7.Enabled = true;
                }
                if (toplam > 21)
                {
                    label13.Text = "Kaybettiniz";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button7.Enabled = true;
                }

            }
            if (sayac == 3)
            {
                int a4, toplam;
                a4 = rnd.Next(1, 11);
                label4.Text = a4.ToString();

                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + a4;
                label11.Text = toplam.ToString();
                if (toplam == 21)
                {
                    label13.Text = "Kazandınız";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button7.Enabled = true;
                }
                if (toplam > 21)
                {
                    label13.Text = "Kaybettiniz";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button7.Enabled = true;
                }

            }
            if (sayac == 4)
            {
                int a5, toplam;
                a5 = rnd.Next(1, 11);
                label21.Text = a5.ToString();

                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + Convert.ToInt32(label4.Text) + a5;
                label11.Text = toplam.ToString();
                if (toplam == 21)
                {
                    label13.Text = "Kazandınız";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button7.Enabled = true;
                }
                if (toplam > 21)
                {
                    label13.Text = "Kaybettiniz";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button7.Enabled = true;
                }
            }
            if (sayac == 5)
            {
                int a6, toplam;
                a6 = rnd.Next(1, 11);
                label20.Text = a6.ToString();

                toplam = Convert.ToInt32(label1.Text) + Convert.ToInt32(label2.Text) + Convert.ToInt32(label3.Text) + Convert.ToInt32(label4.Text) + Convert.ToInt32(label21.Text) + a6;
                label11.Text = toplam.ToString();
                if (toplam == 21)
                {
                    label13.Text = "Kazandınız";
                   button1.Enabled = false;
                   button2.Enabled = false;
                    button7.Enabled = true;
                }
                if (toplam > 21)
                {
                    label13.Text = "Kaybettiniz";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button7.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayacb++;
            if (sayacb == 1)
            {
                int b3, toplamb;

                b3 = rnd.Next(1, 11);
                label6.Text = b3.ToString();
                toplamb = Convert.ToInt32(label8.Text) + Convert.ToInt32(label7.Text) + b3;
                label12.Text = toplamb.ToString();
                if (toplamb == 21)
                {
                    label13.Text = "Kaybettiniz";
                    button7.Enabled = true;
                }
                if (toplamb > 21)
                {
                    label13.Text = "Kazandınız";
                    button7.Enabled = true;
                }
            }
            if (sayacb == 2)
            {
                int b4, toplamb;

                b4 = rnd.Next(1, 11);
                label5.Text = b4.ToString();
                toplamb = Convert.ToInt32(label8.Text) + Convert.ToInt32(label7.Text) + Convert.ToInt32(label6.Text) + b4;
                label12.Text = toplamb.ToString();
                if (toplamb == 21)
                {
                    label13.Text = "Kaybettiniz";
                    button7.Enabled = true;
                }
                if (toplamb > 21)
                {
                    label13.Text = "Kazandınız";
                    button7.Enabled = true;
                }
            }
            if (sayacb == 3)
            {
                int b5, toplamb;

                b5 = rnd.Next(1, 11);
                label19.Text = b5.ToString();
                toplamb = Convert.ToInt32(label8.Text) + Convert.ToInt32(label7.Text) + Convert.ToInt32(label6.Text) + Convert.ToInt32(label5.Text) + b5;
                label12.Text = toplamb.ToString();
                if (toplamb == 21)
                {
                    label13.Text = "Kaybettiniz";
                    button7.Enabled = true;
                }
                if (toplamb > 21)
                {
                    button7.Enabled = true;
                    label13.Text = "Kazandınız";
                }
            }
            if (sayacb == 4)
            {
                int b6, toplamb;

                b6 = rnd.Next(1, 11);
                label18.Text = b6.ToString();
                toplamb = Convert.ToInt32(label8.Text) + Convert.ToInt32(label7.Text) + Convert.ToInt32(label6.Text) + Convert.ToInt32(label5.Text) + Convert.ToInt32(label19.Text) + b6;
                label12.Text = toplamb.ToString();
                if (toplamb == 21)
                {
                    label13.Text = "Kaybettiniz";
                    button7.Enabled = true;
                }
                if (toplamb > 21)
                {
                    label13.Text = "Kazandınız";
                    button7.Enabled = true;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(para > 0)
            {
                button1.Enabled = true;
                topbahis = topbahis + 10;
                para = para - 10;
                label14.Text = topbahis.ToString();
                label16.Text = para.ToString();
            }
            else
            {
                label13.Text = "Oyun Bitti";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (para > 0)
            {
                button1.Enabled = true;
                topbahis = topbahis + 20;
                para = para - 20;
                label14.Text = topbahis.ToString();
                label16.Text = para.ToString();
            }
            else
            {
                label13.Text = "Oyun Bitti";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(para > 0)
            {
                button1.Enabled = true;
                topbahis = topbahis + 50;
                para = para - 50;
                label14.Text = topbahis.ToString();
                label16.Text = para.ToString();
            }
            else
            {
                label13.Text = "Oyun Bitti";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(para > 0)
            {
                button1.Enabled = true;
                topbahis = topbahis + 100;
                para = para - 100;
                label14.Text = topbahis.ToString();
                label16.Text = para.ToString();
            }
            else
            {
                label13.Text = "Oyun Bitti";
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {  
            button6.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            timer1.Enabled = false;
            int kazanılanpara;
            if (label13.Text == "Kazandınız")
            {
                kazanılanpara = topbahis * 2;
                para = kazanılanpara + para;
                label16.Text = para.ToString();
            }
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label21.Text = "0";
            label20.Text = "0";
            label8.Text = "0";
            label7.Text = "0";
            label6.Text = "0";
            label5.Text = "0";
            label19.Text = "0";
            label18.Text = "0";
            label11.Text = "0";
            label12.Text = "0";
            sayac = 0;
            sayacb = 0;
            button7.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            topbahis = 0;
            label14.Text = topbahis.ToString();

            label13.Text = "Yeni Tur Başladı";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(label13.Text == "Kazandınız")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;

            }
            if(label13.Text == "Kaybettiniz")
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }

        }
    }
}
