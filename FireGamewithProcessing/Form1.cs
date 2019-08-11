using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireGamewithProcessing
{
    public partial class Form1 : Form
    {
        // global variable declaration area that is accessed by all the method in the form 
        //this varaible is used for the help of timer that is used to display the area of game 
        int tmr = 0, fire = 0, clck = 0, shoot = 0, btnTrigger = 0, countTriger = 0;

        fire instance = new fire();

        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            timer1.Start();
            Fire.Enabled = false;
            shoot = instance.fireGun();
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            image.ImageLocation = instance.play();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //this method is used to load the bullet in to the sniper for shoot 
            //for this we have call the method of another class that is used to display this task
            //for this we have call the method of another class that is used to display this task
            //for this we have call the method of another class that is used to display this task
            //for this we have call the method of another class that is used to display this task
            image.ImageLocation = "snipper.jpg";
            Fire.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clck = 0;
            fire = 0;
            shoot = instance.fireGun();
            btnTrigger=0;
            countTriger=-0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnTrigger++;
            countTriger++;
            if (btnTrigger== shoot) {
                int chk = instance.sound();
                shoot = instance.fireGun();
            }
            if (btnTrigger==6 && countTriger==6) {
                MessageBox.Show("You have only one more chance to play ");
                btnTrigger = 0;
            }

            if (countTriger==12) {

                MessageBox.Show("Your game is over click on play again");
            }
        }

        //this method is used at the starting of the game that is display the loading image in front of the user 
        // when the timer is equal to 10 then the game spot will be visible for playing the fire game 
        public void timer1_Tick(object sender, EventArgs e)
        {
            tmr++;
            if (tmr==10) {
                //when the condition is true then the loading image will be disappear 
                process.Visible = false;
                //after that stop the timer for 2nd task
                timer1.Stop();
                //after stoping the timer the game spot will be visible with this code 
                groupBox1.Visible = true;
            }
        }
        
        public void PlayButton_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void Fire_Click(object sender, EventArgs e)
        {
             fire++;
            //compare the generated no with the no of triger when they are equal thenit will generate a sound effect 
            image.ImageLocation = "fire.jpg";
            int chk = 0;
            if (fire==shoot) {
                //calling the method that is used to generate  the sound of fire
                chk=instance.sound();
                fire = 0;
                clck++;
                //calling the method to generate the another no to fire
                shoot = instance.fireGun();

                if (clck==1) {
                    MessageBox.Show("Now This is Your last cahnce to shot ");
                }
            }
            
            //this condition is used to find the winner or looser if the player win the game the celebration sound will be genreate other wise the looser message will be display 
            if (chk == clck && clck>0 && chk>0) {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("celebration.wav");
                player.Play();
                MessageBox.Show("Winner of the Game");
                System.Windows.Forms.Application.Exit();
            }
            //that is used to generate the message to stop the game 
            if (clck==2) {
                MessageBox.Show("Game is Finished and you loos the game Run again ");
                Fire.Enabled = false;
            }

        }
    }
}
