﻿using System;

namespace _Bees { // Added underscore to start of namespace to avoid confusion with class name.
    public class Bees {
        protected float health = 100;
        protected int DEATH;  // capitals as this will be a constant for each child class, albeit different for each child class.

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

        public void healthStatus()
        {
            Console.WriteLine("The health of this bee is: ", getHealth());
        }
    }

    public class Worker: Bees {

        public Worker() {  // constructor for Worker class.
            this.DEATH = 70;
            healthStatus();
        }
    }

    public class Drone: Bees {
        public Drone() {
            this.DEATH = 50;
            healthStatus();
        }
    }

    public class Queen: Bees {
        public Queen() {
            this.DEATH = 20;
            healthStatus();
        }
    }

    static void Main(string[] args) {
        Console.WriteLine("Hello World!");
    }
}


