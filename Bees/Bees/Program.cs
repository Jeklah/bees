using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace _Bees { // Added underscore to start of namespace to avoid confusion with class name.
    public class Bees {
        public float health = 100;
        public int DEATH;  // capitals as this will be a constant for each child class, albeit different for each child class.
        public Boolean dead = false;
        public string beeName;
        private Random random = new Random();


        public void damage() {
            float dmg = random.Next(100);
            if (0 <= dmg && dmg <= 100) {  // Input check to see if it is within the correct range.
                health = health - dmg;
                if (health <= 0) {
                    dead = true;
                }
            }
            else {
                Console.WriteLine("Please enter a valid number between 0 and 100.");
            }
        }

        public string getHealth() {
            return this.health.ToString();
        }

        public void healthStatus() {
            Console.Write("The health of this bee is: ");
            Console.WriteLine(health);
        }                                                                   
                                                                            
        public void getName() {
            Console.Write("The type of bee this is is a ");
            Console.WriteLine(beeName);
        }
    }

    public class Worker : Bees {

        public Worker() {  // constructor for Worker class.
            this.DEATH = 70;
            beeName = "work";
        }
    }

    public class Drone : Bees {
        public Drone() {  // constructor for Drone class
            this.DEATH = 50;
            beeName = "drone";
        }
    }

    public class Queen : Bees { // constructor for Queen class
        public Queen() {
            this.DEATH = 20;
            beeName = "queen";
        }
    }

    class Drivers { // driver class

        static void Main(string[] args) {
            List<Bees> beeList = new List<Bees>();
            for (int x = 0; x < 10; ++x) {
                Worker bee_W  = new Worker();
                beeList.Add(bee_W);
                Drone bee_D = new Drone();
                beeList.Add(bee_D);
                Queen bee_Q = new Queen();
                beeList.Add(bee_Q);
            }

            for (int x=0; x < beeList.Count; ++x) {  // it was at this point I realised I should have done this using forms and not a console
                beeList[x].damage();  // program due to the lack of buttons.
                beeList[x].getName();
                beeList[x].healthStatus();
            }
        }
    }
}


