using System;
using System.Collections.Generic;
using System.Text;

namespace BootCampAM23
{
    public class Player
    {
        //Properties
        public int ID { get; set; } //Assign 0 to the actual player... all others are monsters!
        public string Name { get; set; }
        public int Health { get; set; }
        //Jim is asking you to customize this... ArmorSlots, Inventory, Emotes, HasMagic, Class, Gold, XP, Speed, Upgrades
        
        //Constructors...
        public Player()
        {

        }

        public Player(int iD, string name, int health)
        {
            ID = iD;
            Name = name;
            Health = health;
        }
    }
}
