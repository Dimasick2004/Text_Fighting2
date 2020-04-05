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
    public partial class Menu : Form
    {
        SoundPlayer sf = new SoundPlayer(@"C:\Users\User\Desktop\Text_Fighting2\Fight_of_Mans\Resources\Dark Souls 3 – Soul of Cinder.wav");
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sf.Play();
        }
    
        private void button3_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Разработчик данного проекта: Назаренко Дмитрий. На данный момент игра полностью не готова.";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                Fight f = new Fight();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label2.Text = "Текстовый файтинг на двоих, который состоит из угадывания действий противника. Игрок выбирает направление атаки, ваш оппонент, который должен не знать о направлении атаки, выбирает направление блока. Если угадывает - сохраняет свои hp, если не угадывает - теряет.";
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "Автор данного проекта Дмитрий Назаренко.";
        }
    }
}
