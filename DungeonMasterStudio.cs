using System;

namespace dmtool{
    public class DungeonMasterStudio{
        public static void Main(string[] args) {
            bool again;
            do{
                start();
                again = yesNo();
            }while(again == true);
            Character character = new Character();
            Console.WriteLine(character.toString());
        }
        public static bool yesNo(){
            bool error;
            bool again = false;
            do {
                error = false;
                Console.Write("Roll again? (Y/N): ");
                char confirm = Console.ReadLine()[0];
                if (confirm == 'Y' || confirm == 'y') {
                again = true;
        
                } else if (confirm == 'N' || confirm == 'n') {
                again = false;
                } else {
                Console.WriteLine("Please enter 'Y' or 'N' only");
                error = true;
                }
            } while (error == true);
            return again;
        }
        public static void start(){
            Console.Write("How many dice do you want to roll? ");
            int rollNum = int.Parse(Console.ReadLine());
            Console.Write("What sided dice? ");
            int diceSide = int.Parse(Console.ReadLine());
            display(rollNum, diceSide);
        }

        public static int roll(int dice) {// returns a int
            Random r = new Random();
            int rollNum = r.Next(dice) + 1;
            return rollNum; // must have return statement
        }

        public static void display(int numRoll, int dice) {// returns nothing
            int[] rolls = new int[numRoll];
            int total = 0;
            for (int i = 0; i < numRoll; i++) {
                rolls[i] = roll(dice);
                Console.WriteLine("Roll " + (i + 1) + ": " + rolls[i]);
                total = rolls[i] + total;
            }
            Console.WriteLine("Total of rolls: "+total);
        }
    }
}

