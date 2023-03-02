using System;
using System.Collections.Generic;
using System.Text;

namespace BootCampAM23
{
    public static class MiniDC
    {
        public static void StartDC()
        {
            Console.WriteLine("Welcome to The Red Stone Temple!");
            Console.WriteLine("What is your player's name? ");
            string pName = Console.ReadLine();
            Player player = new Player(0, pName, 50);

            //Create some monsters...
            Player[] monster = new Player[5];
            monster[1] = new Player(1, "MC Steve", 20);
            monster[2] = new Player(2, "Aracanos", 7);
            monster[3] = new Player(3, "Gregggor the Small Giant", 100);
            monster[4] = new Player(4, "Frida the Fearless", 42);

            //Dealing with the world...
            int maxX = 11;
            int maxY = 11;
            Location[,] location = new Location[maxX, maxY];
            location[5, 5] = new Location("Home", "You see a glowing red stone that looks comfortable to sit upon.", 0);
            location[4, 4] = new Location("Treasure Room", "You see golden goblets and silver daggars. You hear a deep rumbling groan.", 3);
            location[1, 6] = new Location("Mount Olympus", "You climb a steep path and find a platimum throne.", 1);
            location[4, 3] = new Location("The Cave", "You enter a pitch black cave, be carful!", 2);

            //Set the player location...
            int pX = 5;
            int pY = 5;

            //Create a die
            Random dice = new Random();

            //Game begins...
            while (true)
            {
                //Display the location & player health...
                Console.WriteLine("\n------------------------------------");
                Console.WriteLine("\tYour health: {0}", player.Health);
                Console.WriteLine("\tYour Location: ({0},{1})", pX, pY);

                //Tell player details about where they are...
                if( location[pX,pY] != null)
                {
                    Console.WriteLine("\t *** {0} ***", location[pX, pY].LocationName);
                    Console.WriteLine("\t ### {0} ###", location[pX, pY].Description);

                    //Monster Detection
                    if (location[pX,pY].MonsterID !=0)
                    {
                        int mID = location[pX, pY].MonsterID;
                        Console.WriteLine("\t !! You encounter {0} with health {1} !!", monster[mID].Name, monster[mID].Health);

                        //Battle Begins Here!
                        int damageToMonster = dice.Next(1, 20); // roll a d20
                        int damageToPlayer = dice.Next(1, 20);

                        //Deduct from health
                        player.Health -= damageToPlayer;
                        monster[mID].Health -= damageToMonster;

                        //Speak the results...
                        Console.WriteLine("\t\t !!!You take {0} damage!", damageToPlayer);
                        Console.WriteLine("\t\t !!! {0} takes {1} damage!", monster[mID].Name, damageToMonster);
                        Console.WriteLine("\t\t !!! Your Health: {0}.    Their Health: {1}", player.Health, monster[mID].Health);

                        //Deal with death...
                        if(monster[mID].Health <= 0)
                        {
                            Console.WriteLine("\t\t\t !!! You KILL {0} !!!", monster[mID].Name);
                            location[pX, pY].MonsterID = 0; //Removes monster from the room
                            //location[pX, pY] = Null; //Optional
                        }
                        if( player.Health <= 0)
                        {
                            Console.WriteLine("WOW, I was not expecting that, hate to tell you but... You died");
                            return;
                        }

                    }

                }


                //Add a special healing room....
                if(pX == 8 && pY == 8)
                {
                    Console.WriteLine("You start feeling better!!! Nice.");
                    player.Health += dice.Next(1, 6);
                }

                //Ask for user commands...
                Console.Write("Your wish is my command > ");
                string cmd = Console.ReadLine().ToLower().Trim();
                if(cmd == "q" || cmd == "quit")
                {
                    Console.WriteLine("Thanks for playing. Insert 25 cents to play again! And then again and again...");
                    return;
                }

                //Movement...
                if (cmd == "n") pY--;
                if (cmd == "s") pY++;
                if (cmd == "e") pX++;
                if (cmd == "w") pX--;

                //Solve the OFF World problem...
                pX = Math.Clamp(pX, 0, maxX - 1);
                pY = Math.Clamp(pY, 0, maxY - 1);

                if (cmd == "m") Location.DrawMap(location, pX, pY);

                if (cmd == "save") SaveLoadData.SavePlayerData(player);

                try //Error trapping!!!!
                {
                    if (cmd == "load") player = SaveLoadData.LoadPlayerData(player);
                }
                catch
                {
                    Console.WriteLine("Could not restore player data");
                }
                
            }



        }


    }
}
