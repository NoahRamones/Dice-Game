using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Programmer : Ryan Luong
 Description : This class is to move the boats according to the number rolled on the die
 */
namespace GameProject
{
    class boat
    {
        // declares the fields to use in the class
        public PictureBox boatPic { get; set; }
        public int boatSail { get; set; } // set # of steps boat sails

        public void moveBoat()
        {
            for(int steps=1; steps <=boatSail; steps++)
            {
            Point tempLocation = boatPic.Location; // creats a point variable to store the location of the picture box
            tempLocation.X += 20; // changes the x cord of the templocation 10 pixel further
            boatPic.Location = tempLocation; // moves the boat picture to the location of the templocation point
            System.Threading.Thread.Sleep(1000); // 1 second pause
            }
        }

        public void moveBoat2()
        {
            for (int steps = 1; steps <= boatSail; steps++)
            {
                Point tempLocation = boatPic.Location; // creats a point variable to store the location of the picture box
                tempLocation.X += 20; // changes the x cord of the templocation 10 pixel further
                boatPic.Location = tempLocation; // moves the boat picture to the location of the templocation point
                System.Threading.Thread.Sleep(1000); // 1 second pause
            }
        }




    }
}
