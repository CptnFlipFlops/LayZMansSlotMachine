using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SlotMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int points = 500;
        private void Form1_Load(object sender, EventArgs e)
        {
           
            label1.Text = "Points = 500";
        }

        public List<Int32> GetResults()
        {
            List<Int32> list1 = new List<int>();
            Random rnd = new Random();

            for (int i = 1; i <= 9; i++)
            {
                list1.Add(rnd.Next(1, 10));
                //  MessageBox.Show(list1[i].ToString());
            }


            return list1;

        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            if (points < 0)
            {
                MessageBox.Show("YOU LOST!!!!!!!!!");
            }
            else
            {

            points -= 20;
            }
            label1.Text = "Points = " + points.ToString();
            string s = "";
            List<Int32> list = new List<Int32>();
            list = GetResults();
            int d = 0;
            foreach (var item in list)
            {

                s = s + item;
                if (d == 2 || d == 5)
                {
                    s = s + "\n";
                }
                d++;

            }
            //s = s + "========";

            if (list[0] == list[1] && list[1] == list[2])
            {
                points = points + 50;
            }
            if (list[3] == list[4] && list[4] == list[5])
            {
                points = points + 100;
            }
            if (list[6] == list[7] && list[7] == list[8])
            {
                points = points + 50;
            }


            if (list[0] == list[3] && list[3] == list[6])
            {
                points = points + 50;
            }
            if (list[1] == list[4] && list[4] == list[7])
            {
                points = points + 100;
            }
            if (list[2] == list[5] && list[5] == list[8])
            {
                points = points + 50;
            }

            label1.Text = "Points = " + points.ToString();



            panel1.BackgroundImage = Image.FromFile(@"C:\Users\Sean\Documents\Development\College\SlotMachine\" + list[0].ToString() + ".png");
            panel2.BackgroundImage = Image.FromFile(@"C:\Users\Sean\Documents\Development\College\SlotMachine\" + list[1].ToString() + ".png");
            panel3.BackgroundImage = Image.FromFile(@"C:\Users\Sean\Documents\Development\College\SlotMachine\" + list[2].ToString() + ".png");

            panel4.BackgroundImage = Image.FromFile(@"C:\Users\Sean\Documents\Development\College\SlotMachine\" + list[3].ToString() + ".png");
            panel5.BackgroundImage = Image.FromFile(@"C:\Users\Sean\Documents\Development\College\SlotMachine\" + list[4].ToString() + ".png");
            panel6.BackgroundImage = Image.FromFile(@"C:\Users\Sean\Documents\Development\College\SlotMachine\" + list[5].ToString() + ".png");

            panel7.BackgroundImage = Image.FromFile(@"C:\Users\Sean\Documents\Development\College\SlotMachine\" + list[6].ToString() + ".png");
            panel8.BackgroundImage = Image.FromFile(@"C:\Users\Sean\Documents\Development\College\SlotMachine\" + list[7].ToString() + ".png");
            panel9.BackgroundImage = Image.FromFile(@"C:\Users\Sean\Documents\Development\College\SlotMachine\" + list[8].ToString() + ".png");


           // MessageBox.Show(s);
        }
    }
}
