using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Fight_of_Mans
{
    public partial class Fight : Form
    {
        SoundPlayer sf = new SoundPlayer(@"C:\Users\User\source\repos\Fight_of_Mans\Fight_of_Mans\Resources\Yuka Kitamura – Main Menu [DARK SOULS III].wav");
        static int hp1 = 100; bool ttt= false;
        static int hp2 = 100;
        int num_1;
        int num_2;
        int num_3;
        int num_4;
        int result = 100;
        int result1 = 100;
        public Fight()
        {
            InitializeComponent();
            while (result > 0 && result1 > 0)
            {
                if (ttt == false)
                {
                    button1.Show();
                    button2.Show();
                    button7.Show();
                    button8.Show();
                    button3.Hide();
                    button4.Hide();
                    button5.Hide();
                    button6.Hide();

                }
                else
                {
                    button1.Hide();
                    button2.Hide();
                    button7.Hide();
                    button8.Hide();
                    button3.Show();
                    button4.Show();
                    button5.Show();
                    button6.Show();
                }
            }
            MessageBox.Show("khdgikhdikh");

        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        ////////////////////////////////////////////////////////////// 1 vs 2
        private void Fight_Load(object sender, EventArgs e)
        {
            ///sf.Play();
     
        }

        private void button1_Click(object sender, EventArgs e)//атака сверху первого
        {
            num_1 = 1;
        
        }

        private void button2_Click(object sender, EventArgs e)//атака снизу первого
        {
             num_1 = 2;
       
        }

        private void button7_Click(object sender, EventArgs e)//защита сверху второго
        {
            num_3 = 1;
            if (num_1 != num_3)
            {
                result = hp2 - 30;
            }
            if (num_1 == num_3)
            {
                result = hp2 - 0;
            }
            label2.Text = result.ToString();

            ttt = true;
        }

        private void button8_Click(object sender, EventArgs e)//защита снизу второго
        {
            num_3 = 2;
            if (num_1 != num_3)
            {
                result = hp2 - 30;
            }
            if (num_1 == num_3)
            {
                result = hp2 - 0;
            }
            label2.Text = result.ToString();

            ttt = true;
        }


       /////////////////////////////////////////////////////////////////////////////// 2 vs 1
     
       

        private void button3_Click(object sender, EventArgs e)
        {
            num_2 = 1;
  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num_2 = 2;
           
        }


        private void button5_Click1(object sender, EventArgs e)
        {
            num_4 = 1;
            if (num_2 != num_4)
            {
                result1 = hp1 - 30;
            }

            if (num_2 == num_4)
            {
                result1 = hp1 - 0;
            }
            label1.Text = result1.ToString();

            ttt = false;

        }

        private void button6_Click1(object sender, EventArgs e)
        {
            num_4 = 2;
            if (num_2 != num_4)
            {
                result1 = hp1 - 30;
            }
            if (num_2 == num_4)
            {
                result1 = hp1 - 0;
            }
            label1.Text = result1.ToString();

            ttt = false;

        }
        //////////////////////////////////////////////////////////// 1 vs 2
        

    }
}
