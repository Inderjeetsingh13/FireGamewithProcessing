using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGamewithProcessing
{
    public class fire
    {
        //this method id user define that is used to display the 2nd page which is fully loaded
        public String play() {
            return "2nd.jpg";
        }
        public int fireGun() {
                //generate the random no fire the triger means which trigger generate the fire sound
                Random instance = new Random();
                int no=instance.Next(2,5);
            //returning the no to fire 
            return no;
        }
        // generate the sound of fire 
        public int sound() {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("fireSound.wav");
            player.Play();
            Random instance = new Random();
            int Win = instance.Next(1, 5);
            return Win;
        }
    }
}
