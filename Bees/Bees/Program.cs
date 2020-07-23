using System;
using System.Security.Cryptography.X509Certificates;

namespace _Bees { // Added underscore to start of namespace to avoid confusion with class name.
    public class Bees {
        private float health = 100;
        public int DEATH;  // capitals as this will be a constant for each child class, albeit different for each child class.
        public Boolean dead = false;


        public void damage(int dmg) {
            if (0 <= dmg && dmg <= 100) {  // Input check to see if it is within the correct range.
                health = health - dmg;
            }
            else {
                Console.WriteLine("Please enter a valid number between 0 and 100.");
            }
        }

        public string getHealth() {
            return this.health.ToString();
        }

        public void healthStatus() {
            Console.WriteLine("The health of this bee is: ", getHealth());
        }
    }

    public class Worker : Bees {

        public Worker() {  // constructor for Worker class.
            this.DEATH = 70;
        }
    }

    public class Drone : Bees {
        public Drone() {  // constructor for Drone class
            this.DEATH = 50;
        }
    }

    public class Queen : Bees { // constructor for Queen class
        public Queen() {
            this.DEATH = 20;
        }
    }

    class Drivers { // driver class

        static void Main(string[] args) {
            for (int x = 0; x < 10; ++x) {

            }
        }
    }
}


