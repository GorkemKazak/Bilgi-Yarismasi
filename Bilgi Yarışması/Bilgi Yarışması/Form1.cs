using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soru = 1;
        int para = 0;

        //timer_degiskenler
        int kalansure = 60;
        int siradakisure = 5;
    

        //MAIN CODES---------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            kalansure = 60;
            tkalansure.Start();
            button1.Text = "Sıradaki";
            button1.Enabled = false;
            if (soru == 1)
            {                
                lbsoru.Text = "Aşağıdakilerden Hangisi Doğal Sayıdır?";
                yaz("-1", "-2.5", "0", "-0","500");
            }
            if (soru == 2)
            {
                lbsoru.Text = "Bazı aylar 30, bazıları 31 çeker; kaç ayda 28 gün vardır?";
                yaz("2", "4", "7", "12", "1500");
            }
        }   //SORU KOD BLOĞU
        private void btemin_Click(object sender, EventArgs e)
        {
            lbemin.Visible = false;
            btemin.Visible = false;
            if (soru == 1)
            {                
                if (c.Checked == true)
                {
                    dogru(500);                 
                }
                else
                {
                    yanlıs();
                }
            }
            //emin olduğu soru 2'ise:
            else if (soru == 2)
            {
                if (d.Checked == true)
                {
                    dogru(2000);
                }
                else
                {
                    yanlıs();
                }
            }         
        }    //CEVAP KONTROL KOD BLOĞU

        //METOTS---------------------------------------------------
        public void yaz(string sıka,string sıkb,string sıkc, string sıkd,string oduls)
        {
            a.Visible = true;
            b.Visible = true;
            c.Visible = true;
            d.Visible = true;
            odul.Visible = true;
            lbemin.Visible = true;
            btemin.Visible = true;
            a.Text = sıka;
            b.Text = sıkb;
            c.Text = sıkc;
            d.Text = sıkd;
            odul.Text = oduls;
        }   //SORU YAZDIRMA METOT
        public void dogru(int paras)
        {
            tkalansure.Stop();
            lbdogru.Visible = true;
            para = paras;
            soru++;
            lbsiradaki.Visible = true;
            tsiradakisure.Start();
            lbpara.Text = "Toplam para = " + para.ToString();
        }   //CEVAP DOGRUYSA METOT
        public void yanlıs()
        {
            tkalansure.Stop();
            lbdogru.Visible = true;
            lbdogru.Text = "CEVAP YANLIŞ";
            lbdogru.ForeColor = Color.Red;
            MessageBox.Show("YARIŞMADAN KAZANCINIZ: " + para + " TL.");
            lbemin.Enabled = false;
            lbkalansure.Enabled = false;
            lbpara.Enabled = false;
            lbsiradaki.Enabled = false;
            lbsoru.Enabled = false;
        }   //CEVAP YANLIŞSA METOT
        

        //TIMERS---------------------------------------------------
        private void tkalansure_Tick(object sender, EventArgs e)
        {
            kalansure--;
            lbkalansure.Text = "Kalan Süre: " + kalansure.ToString();
            if (kalansure <= 60 && kalansure >= 40)
                lbkalansure.ForeColor = Color.Green;
            if (kalansure <=40 && kalansure >= 20)
                lbkalansure.ForeColor = Color.Yellow;
            if (kalansure <= 20 && kalansure >= 0)
                lbkalansure.ForeColor = Color.Red;
            if (kalansure == 0)
            {
                lbemin.Enabled = false;
                lbkalansure.Enabled = false;
                lbpara.Enabled = false;
                lbsiradaki.Enabled = false;
                lbsoru.Enabled = false;
                lbdogru.Text = "SÜRENİZ BİTTİ";
                lbdogru.ForeColor = Color.Red;

                tkalansure.Stop();
                MessageBox.Show("SÜRENİZ BİTTİ !");

            }
        }  //KALAN SURE SAYAN TIMER

        private void tsiradakisure_Tick(object sender, EventArgs e)
        {
            siradakisure--;
            lbsiradaki.Text = "Sıradaki Soruya: " + siradakisure.ToString();
            if (siradakisure == 0)
            {
                tsiradakisure.Stop();
                button1.Enabled = true;
                lbsiradaki.Visible = false;
                lbdogru.Visible = false;
                siradakisure = 5;
            }
        }   //SIRADAKİ SURE SAYAN TIMER

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
