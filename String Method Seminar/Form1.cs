using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Method_Seminar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //1
        {
            string ad = textBox1.Text;
            int uzunluq = ad.Length;
            label1.Text = uzunluq.ToString();

        }

        private void button2_Click(object sender, EventArgs e) //2SubString
        {
            string ad = textBox1.Text;
            string adbos = ad.TrimStart();
            int index = adbos.IndexOf(' ');
           
            string soyad = adbos.Substring(index);
            string esoyad = soyad.Trim(); 
            label1.Text = esoyad;
            
        }

        private void button3_Click(object sender, EventArgs e) //2Split
        {
            string ad = textBox1.Text;
            string adbos = ad.TrimStart();

            
            string[] soyad2 = adbos.Split(' ');

            for (int i = 1; i < soyad2.Length; i++)
            {
                if (soyad2[i] == string.Empty)
                {
                    continue;
                }
                else
                {
                    label1.Text = soyad2[i];
                    
                }

            } 
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string adbos = ad.TrimStart();

            int uzun = ad.Length;
            string[] soyad2 = adbos.Split(' ');

            for (int i = 1; i < soyad2.Length; i++)
            {
                if (soyad2[i] == string.Empty)
                {
                    continue;
                }
                else
                {
                    label1.Text = soyad2[i];
                    break;
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)//4
        {
            string cumle = textBox1.Text;
            string[] sozler = cumle.Split(' ');
            /*List<char> herfler = cumle.ToList();
            herfler.Sort();*/
            Array.Sort(sozler);
            foreach (var item in sozler)
            {
                listBox1.Items.Add(item);
            }
            
        }

        private void button7_Click(object sender, EventArgs e)//5
        {
            string soz = textBox1.Text;
            string basoz = soz.ToLower();
            char herf = basoz[0];
            
            bool netice = herf.Equals('a');

            label1.Text = netice.ToString();
            
        }

        private void button8_Click(object sender, EventArgs e)//6
        {
            int asay = 0;int isay = 0;int esay = 0;
            string soz = textBox1.Text;
            List<char> herfler = soz.ToList();
            foreach (var item in soz)
            {
                if (item == 'a')
                {
                    asay++;
                    
                }
                if (item=='e')
                {
                    esay++;
                }
                if (item=='i')
                {
                    isay++;
                }
            }
            label1.Text = "A="+asay + " E=" + esay + " I=" + isay;


        }

        private void button9_Click(object sender, EventArgs e)//7
        {
            int cem = 0;
            string herf = "";
            int eded = 0;
            string soz = textBox1.Text;
            List<char> herfler = soz.ToList();
            foreach (var item in herfler)
            {
                eded = (int)item;
                herf = item.ToString();
                string netice = string.Concat(herf,"  herfinin qiymeti=  ",eded);
                listBox1.Items.Add(netice);
                int say = (int)item;
                cem += say;
                netice = "";
            }
            label1.Text = cem.ToString();
        }

        private void button10_Click(object sender, EventArgs e)//8
        {
            string netice = "";
            string ad = textBox1.Text;
            int aduzun = ad.Length;
            List<char> herfler = ad.ToList();
            
            for (int i = aduzun-1; i >= 0; i--)
            {
                netice += herfler[i];
            }
            label1.Text = netice;        }

        private void button11_Click(object sender, EventArgs e)//9
        {
            int say = 0;
            string cumle = textBox1.Text;//abtyuabtyu
            int uzun = cumle.Length;
            List<char> herfler = cumle.ToList();
            
            for (int i = 0; i < uzun; i++)
            { 
                   if (herfler[i] == 'a' && herfler[i + 1] == 'b')
                   {
                        say++;
                   }
            }
            label1.Text = say.ToString();

        }

        private void button12_Click(object sender, EventArgs e)//10
        {
            int j = 0;
            string sozler = textBox1.Text;
            string[] soz = new string[2];
            string adevvel = sozler.TrimStart();
            string adson = adevvel.TrimEnd();
            
            string[] kesme = adson.Split(' ');
            
            for (int i = 0;i<kesme.Length;i++) {

                if (kesme[i] != string.Empty)
                {
                    
                    soz[j] = kesme[i];
                    
                    //listBox1.Items.Add(soz[j]);
                    j++;
                }
                else
                {
                    continue;
                }

            }
           
           string ilksoz = soz[0].ToLower();
            string ikincisoz = soz[1].ToLower();
            char ilksozonherf = ilksoz[ilksoz.Length - 1];
            char sonsozilkherf = ikincisoz[0];
            bool netice = ilksozonherf.Equals(sonsozilkherf);
            label1.Text = netice.ToString();


        }

       
    }
}
