using System;

namespace dm{
    public class DungeonMasterStudio{
        public static void main(String[] args) {
            boolean again;
            do{
                start();
                again = yesNo();
            }while(again == true);
            Character character = new Character();
            Console.WriteLine(character.toString());
        }
        public static boolean yesNo(){
            boolean error;
            boolean again = false;
            do {
                error = false;
                Console.Write("Roll again? (Y/N): ");
                char confirm = s.nextLine().charAt(0);
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
            int rollNum = Integer.parseInt(s.nextLine());
            Console.Write("What sided dice? ");
            int diceSide = Integer.parseInt(s.nextLine());
            display(rollNum, diceSide);
        }

        public static int roll(int dice) {// returns a int
            Random r = new Random();
            int rollNum = r.nextInt(dice) + 1;
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

