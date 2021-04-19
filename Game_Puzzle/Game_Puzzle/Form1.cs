using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Puzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            check();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            check();
        }
        private void check()
        {
            if(b1.Text == "1" && b2.Text == "2" && b3.Text == "3" && b4.Text == "4" &&
                b5.Text == "5" && b6.Text == "6" && b7.Text == "7" && b8.Text == "8"
                 && b9.Text == "9" && b10.Text == "10" && b11.Text == "11" && b12.Text == "12"&&
                b13.Text == "13" && b14.Text == "14" && b15.Text == "15"&&
                b16.Text == " ")
                MessageBox.Show("You win !_!");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            String s = b1.Text;
            if (b2.Text == " ")
            {
                b2.Text = s;
                b1.Text = " ";
                b2.Image = b1.Image;
                b1.Image = null;
            }
            else if (b5.Text == " ")
            {
                b5.Text = s;
                b1.Text = " ";
                b5.Image = b1.Image;
                b1.Image = null;
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            String s = b2.Text;
            if (b1.Text == " ")
            {
                b1.Text = s;
                b2.Text = " ";
                b1.Image = b2.Image;
                b2.Image = null;
            }
            else if (b3.Text == " ")
            {
                b3.Text = s;
                b2.Text = " ";
                b3.Image = b2.Image;
                b2.Image = null;
            }
            else if (b6.Text == " ")
            {
                b6.Text = s;
                b2.Text = " ";
                b6.Image = b2.Image;
                b2.Image = null;
            }
        }

        private void b12_Click(object sender, EventArgs e)
        {
            String s = b12.Text;
            if (b8.Text == " ")
            {
                b8.Text = s;
                b12.Text = " ";
                b8.Image = b12.Image;
                b12.Image = null;
            }
            else if (b11.Text == " ")
            {
                b11.Text = s;
                b12.Text = " ";
                b11.Image = b12.Image;
                b12.Image = null;
            }
            else if (b16.Text == " ")
            {
                b16.Text = s;
                b12.Text = " ";
                b16.Image = b12.Image;
                b12.Image = null;
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            String s = b3.Text;
            if (b2.Text == " ")
            {
                b2.Text = s;
                b3.Text = " ";
                b2.Image = b3.Image;
                b3.Image = null;
            }
            else if (b4.Text == " ")
            {
                b4.Text = s;
                b3.Text = " ";
                b4.Image = b3.Image;
                b3.Image = null;
            }
            else if (b7.Text == " ")
            {
                b7.Text = s;
                b3.Text = " ";
                b7.Image = b3.Image;
                b3.Image = null;
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            String s = b4.Text;
            if (b3.Text == " ")
            {
                b3.Text = s;
                b4.Text = " ";
                b3.Image = b4.Image;
                b4.Image = null;
            }
            else if (b8.Text == " ")
            {
                b8.Text = s;
                b4.Text = " ";
                b8.Image = b4.Image;
                b4.Image = null;
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            String s = b5.Text;
            if (b1.Text == " ")
            {
                b1.Text = s;
                b5.Text = " ";
                b1.Image = b5.Image;
                b5.Image = null;
            }
            else if (b6.Text == " ")
            {
                b6.Text = s;
                b5.Text = " ";
                b6.Image = b5.Image;
                b5.Image = null;
            }
            else if (b9.Text == " ")
            {
                b9.Text = s;
                b5.Text = " ";
                b9.Image = b5.Image;
                b5.Image = null;
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            String s = b6.Text;
            if (b2.Text == " ")
            {
                b2.Text = s;
                b6.Text = " ";
                b2.Image = b6.Image;
                b6.Image = null;
            }
            else if (b5.Text == " ")
            {
                b5.Text = s;
                b6.Text = " ";
                b5.Image = b6.Image;
                b6.Image = null;
            }
            else if (b7.Text == " ")
            {
                b7.Text = s;
                b6.Text = " ";
                b7.Image = b6.Image;
                b6.Image = null;
            }
            else if (b10.Text == " ")
            {
                b10.Text = s;
                b6.Text = " ";
                b10.Image = b6.Image;
                b6.Image = null;
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            String s = b7.Text;
            if (b3.Text == " ")
            {
                b3.Text = s;
                b7.Text = " ";
                b3.Image = b7.Image;
                b7.Image = null;
            }
            else if (b6.Text == " ")
            {
                b6.Text = s;
                b7.Text = " ";
                b6.Image = b7.Image;
                b7.Image = null;
            }
            else if (b8.Text == " ")
            {
                b8.Text = s;
                b7.Text = " ";
                b8.Image = b7.Image;
                b7.Image = null;
            }
            else if (b11.Text == " ")
            {
                b11.Text = s;
                b7.Text = " ";
                b11.Image = b7.Image;
                b7.Image = null;
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            String s = b8.Text;
            if (b4.Text == " ")
            {
                b4.Text = s;
                b8.Text = " ";
                b4.Image = b8.Image;
                b8.Image = null;
            }
            else if (b7.Text == " ")
            {
                b7.Text = s;
                b8.Text = " ";
                b7.Image = b8.Image;
                b8.Image = null;
            }
            else if (b12.Text == " ")
            {
                b12.Text = s;
                b8.Text = " ";
                b12.Image = b8.Image;
                b8.Image = null;
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            String s = b9.Text;
            if (b5.Text == " ")
            {
                b5.Text = s;
                b9.Text = " ";
                b5.Image = b9.Image;
                b9.Image = null;
            }
            else if (b10.Text == " ")
            {
                b10.Text = s;
                b9.Text = " ";
                b10.Image = b9.Image;
                b9.Image = null;
            }
            else if (b13.Text == " ")
            {
                b13.Text = s;
                b9.Text = " ";
                b13.Image = b9.Image;
                b9.Image = null;
            }
        }

        private void b10_Click(object sender, EventArgs e)
        {
            String s = b10.Text;
            if (b6.Text == " ")
            {
                b6.Text = s;
                b10.Text = " ";
                b6.Image = b10.Image;
                b10.Image = null;
            }
            else if (b9.Text == " ")
            {
                b9.Text = s;
                b10.Text = " ";
                b9.Image = b10.Image;
                b10.Image = null;
            }
            else if (b11.Text == " ")
            {
                b11.Text = s;
                b10.Text = " ";
                b11.Image = b10.Image;
                b10.Image = null;
            }
            else if (b14.Text == " ")
            {
                b14.Text = s;
                b10.Text = " ";
                b14.Image = b10.Image;
                b10.Image = null;
            }
        }

        private void b11_Click(object sender, EventArgs e)
        {
            String s = b11.Text;
            if (b7.Text == " ")
            {
                b7.Text = s;
                b11.Text = " ";
                b7.Image = b11.Image;
                b11.Image = null;
            }
            else if (b10.Text == " ")
            {
                b10.Text = s;
                b11.Text = " ";
                b10.Image = b11.Image;
                b11.Image = null;
            }
            else if (b12.Text == " ")
            {
                b12.Text = s;
                b11.Text = " ";
                b12.Image = b11.Image;
                b11.Image = null;
            }
            else if (b15.Text == " ")
            {
                b15.Text = s;
                b11.Text = " ";
                b15.Image = b11.Image;
                b11.Image = null;
            }
        }

        private void b13_Click(object sender, EventArgs e)
        {
            String s = b13.Text;
            if (b9.Text == " ")
            {
                b9.Text = s;
                b13.Text = " ";
                b9.Image = b13.Image;
                b13.Image = null;
            }
            else if (b14.Text == " ")
            {
                b14.Text = s;
                b13.Text = " ";
                b14.Image = b13.Image;
                b13.Image = null;
            }
        }

        private void b14_Click(object sender, EventArgs e)
        {
            String s = b14.Text;
            if (b10.Text == " ")
            {
                b10.Text = s;
                b14.Text = " ";
                b10.Image = b14.Image;
                b14.Image = null;
            }
            else if (b13.Text == " ")
            {
                b13.Text = s;
                b14.Text = " ";
                b13.Image = b14.Image;
                b14.Image = null;
            }
            else if (b15.Text == " ")
            {
                b15.Text = s;
                b14.Text = " ";
                b15.Image = b14.Image;
                b14.Image = null;
            }
        }

        private void b15_Click(object sender, EventArgs e)
        {
            String s = b15.Text;
            if (b11.Text == " ")
            {
                b11.Text = s;
                b15.Text = " ";
                b11.Image = b15.Image;
                b15.Image = null;
            }
            else if (b14.Text == " ")
            {
                b14.Text = s;
                b15.Text = " ";
                b14.Image = b15.Image;
                b15.Image = null;
            }
            else if (b16.Text == " ")
            {
                b16.Text = s;
                b15.Text = " ";
                b16.Image = b15.Image;
                b15.Image = null;
            }
        }

        private void b16_Click(object sender, EventArgs e)
        {
            String s = b16.Text;
            if (b12.Text == " ")
            {
                b12.Text = s;
                b16.Text = " ";
                b12.Image = b16.Image;
                b16.Image = null;
            }
            else if (b15.Text == " ")
            {
                b15.Text = s;
                b16.Text = " ";
                b15.Image = b16.Image;
                b16.Image = null;
            }
            if (b1.Text == "1" && b2.Text == "2" && b3.Text == "3" && b4.Text == "4" &&
             b5.Text == "5" && b6.Text == "6" && b7.Text == "7" && b8.Text == "8"
              && b9.Text == "9" && b10.Text == "10" && b11.Text == "11" && b12.Text == "12" &&
             b13.Text == "13" && b14.Text == "14" && b15.Text == "15" &&
             b16.Text == " ")
                MessageBox.Show("You win !_!");
        }
        
        private void next_Click(object sender, EventArgs e)
        {
            String s = b4.Text;
            b4.Text = b9.Text;
            b9.Text = s;
            Image a = b4.Image;
            b4.Image = b9.Image;
            b9.Image = a;
            //
            s = b1.Text;
            b1.Text = b5.Text;
            b5.Text = s;
            a = b1.Image;
            b1.Image = b5.Image;
            b5.Image = a;
            //
            s = b2.Text;
            b2.Text = b7.Text;
            b7.Text = s;
            a = b2.Image;
            b2.Image = b7.Image;
            b7.Image = a;
            //
            s = b3.Text;
            b3.Text = b8.Text;
            b8.Text = s;
            a = b3.Image;
            b3.Image = b8.Image;
            b8.Image = a;
            //
            s = b14.Text;
            b14.Text = b10.Text;
            b10.Text = s;
            a = b14.Image;
            b14.Image = b10.Image;
            b10.Image = a;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (b1.Text == "1" && b2.Text == "2" && b3.Text == "3" && b4.Text == "4" &&
                b5.Text == "5" && b6.Text == "6" && b7.Text == "7" && b8.Text == "8"
                 && b9.Text == "9" && b10.Text == "10" && b11.Text == "11" && b12.Text == "12" 
                 && b13.Text == "13" && b14.Text == "14" && b15.Text == "15" &&
                b16.Text == " ")
                MessageBox.Show("You win !_!");
            else
                MessageBox.Show("Cố lên nào... Sắp thắng rồi nè !!");
        }

        private void ones_Click(object sender, EventArgs e)
        {
            //b1.Text = "1"; b1.Image = Image.FromFile("E:\\Image\\16.jpg");
            ////b1.Image = Image.FromFile(Properties.Resources);
            ////b1.Image = Image.FromFile("Resources\\16.jpg");

            //b2.Text = "2"; b2.Image = Image.FromFile("E:\\Image\\15.jpg");
            //b3.Text = "3"; b3.Image = Image.FromFile("E:\\Image\\14.jpg");
            //b4.Text = "4"; b4.Image = Image.FromFile("E:\\Image\\13.jpg");
            //b5.Text = "5"; b5.Image = Image.FromFile("E:\\Image\\12.jpg");
            //b6.Text = "6"; b6.Image = Image.FromFile("E:\\Image\\11.jpg");
            //b7.Text = "7"; b7.Image = Image.FromFile("E:\\Image\\10.jpg");
            //b8.Text = "8"; b8.Image = Image.FromFile("E:\\Image\\9.jpg");
            //b9.Text = "9"; b9.Image = Image.FromFile("E:\\Image\\8.jpg");
            //b10.Text = "10"; b10.Image = Image.FromFile("E:\\Image\\7.jpg");
            //b11.Text = "11"; b11.Image = Image.FromFile("E:\\Image\\6.jpg");
            //b12.Text = "12"; b12.Image = Image.FromFile("E:\\Image\\5.jpg");
            //b13.Text = "13"; b13.Image = Image.FromFile("E:\\Image\\4.jpg");
            //b14.Text = "14"; b14.Image = Image.FromFile("E:\\Image\\3.jpg");
            //b15.Text = " "; b15.Image = null;
            //b16.Text = "15"; b16.Image = Image.FromFile("E:\\Image\\2.jpg");

            b1.Text = "1";
            b2.Text = "2";
            b3.Text = "3";
            b4.Text = "4";
            b5.Text = "5";
            b6.Text = "6";
            b7.Text = "7";
            b8.Text = "8";
            b9.Text = "9";
            b10.Text = "10";
            b11.Text = "11";
            b12.Text = "12";
            b13.Text = "13";
            b14.Text = "14";
            b15.Text = " ";
            b16.Text = "15";
            //
            b1.Image = new Bitmap(Application.StartupPath + "\\Resources\\16.jpg");
            b2.Image = new Bitmap(Application.StartupPath + "\\Resources\\15.jpg");
            b3.Image = new Bitmap(Application.StartupPath + "\\Resources\\14.jpg");
            b4.Image = new Bitmap(Application.StartupPath + "\\Resources\\13.jpg");
            b5.Image = new Bitmap(Application.StartupPath + "\\Resources\\12.jpg");
            b6.Image = new Bitmap(Application.StartupPath + "\\Resources\\11.jpg");
            b7.Image = new Bitmap(Application.StartupPath + "\\Resources\\10.jpg");
            b8.Image = new Bitmap(Application.StartupPath + "\\Resources\\9.jpg");
            b9.Image = new Bitmap(Application.StartupPath + "\\Resources\\8.jpg");
            b10.Image = new Bitmap(Application.StartupPath + "\\Resources\\7.jpg");
            b11.Image = new Bitmap(Application.StartupPath + "\\Resources\\6.jpg");
            b12.Image = new Bitmap(Application.StartupPath + "\\Resources\\5.jpg");
            b13.Image = new Bitmap(Application.StartupPath + "\\Resources\\4.jpg");
            b14.Image = new Bitmap(Application.StartupPath + "\\Resources\\3.jpg");
            b15.Image = null;
            b16.Image = new Bitmap(Application.StartupPath + "\\Resources\\2.jpg");
        }
    }
}
