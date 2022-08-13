using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProject
{
    public partial class Form3 : Form
    {
        Image roll1 = new Bitmap(@"C:\Users\student\OneDrive - Monterey Trail High School DATA\GameProject\Pictures\cube1.jpg");
        Image roll2 = new Bitmap(@"C:\Users\student\OneDrive - Monterey Trail High School DATA\GameProject\Pictures\cube2.jpg");
        Image roll3 = new Bitmap(@"C:\Users\student\OneDrive - Monterey Trail High School DATA\GameProject\Pictures\cube3.jpg");
        Image roll4 = new Bitmap(@"C:\Users\student\OneDrive - Monterey Trail High School DATA\GameProject\Pictures\cube4.jpg");
        Image roll5 = new Bitmap(@"C:\Users\student\OneDrive - Monterey Trail High School DATA\GameProject\Pictures\cube5.jpg");
        Image roll6 = new Bitmap(@"C:\Users\student\OneDrive - Monterey Trail High School DATA\GameProject\Pictures\cube6.jpg");

        // Instances
        Die player1roll = new Die();
        Die player2roll = new Die();
        boat boat1 = new boat();
        boat boat2 = new boat();


        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player1roll.diePic = pictureBox1;
            player1roll.roll();
            player1roll.setDiePic();

            boat1.boatPic = pictureBox3;
            boat1.boatSail = player1roll.Face;
            // MessageBox.Show("player1roll =", player1roll.Face.ToString()); Testing puyrposes

            boat1.moveBoat();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player2roll.diePic = pictureBox2;
            player2roll.roll();
            player2roll.setDiePic2();

            boat2.boatPic = pictureBox4;
            boat2.boatSail = player2roll.Face;
            // MessageBox.Show("player1roll =", player1roll.Face.ToString()); Testing puyrposes

            boat2.moveBoat2();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            boat1.boatPic = pictureBox3;
            boat1.boatSail = 3;

            boat1.moveBoat();  
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
