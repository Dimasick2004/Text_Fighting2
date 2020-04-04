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
    public partial class Intro : Form
    {
        //SoundPlayer sf = new SoundPlayer(@"C:\Users\User\source\repos\Fight_of_Mans\Fight_of_Mans\Resources\EA Sports – intro.wav");
        public Intro()
        {
            InitializeComponent();
        }

        private void Intro_Load(object sender, EventArgs e)
        {
          //  sf.Play();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Menu f = new Menu();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
