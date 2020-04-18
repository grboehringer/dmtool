import java.util.*;
<<<<<<< HEAD
public class DungeonMasterStudio{
    public static void main(String[] args) {
        boolean again;
        do{
            start();
            again = yesNo();
        }while(again == true);
        boolean again;
        do{
            start();
            again = yesNo();
        }while(again == true);
        Scanner s = new Scanner (System.in);
        String newName;
        char again;
        boolean repeat;
        do{
            newName = nameGenerator();
            System.out.println(newName);
            System.out.print("Again? ");
            again = s.nextLine().charAt(0);
            switch (again) {
                case 'y':
                case 'Y':
                    repeat = true;
                    break;
                case 'n':
                case 'N':
                    repeat = false;
                    break;
                default:
                    repeat = false;
                    break;
            }
        }while(repeat);
    }
    public static boolean yesNo(){
        Scanner s = new Scanner(System.in);
        boolean error;
        boolean again = false;
        do {
            error = false;
            System.out.print("Roll again? (Y/N): ");
            char confirm = s.nextLine().charAt(0);
            if (confirm == 'Y' || confirm == 'y') {
              again = true;
    
            } else if (confirm == 'N' || confirm == 'n') {
              again = false;
            } else {
              System.out.println("Please enter 'Y' or 'N' only");
              error = true;
            }
          } while (error == true);
          return again;
    }
    public static void start(){
        Scanner s = new Scanner(System.in);
        System.out.print("How many dice do you want to roll? ");
        int rollNum = Integer.parseInt(s.nextLine());
        System.out.print("What sided dice? ");
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
            System.out.println("Roll " + (i + 1) + ": " + rolls[i]);
            total = rolls[i] + total;
        }
        System.out.println("Total of rolls: "+total);
=======


        
>>>>>>> origin/nameGenerator
    }
    
    public static String nameGenerator() {
        Random rand = new Random();

        String[] firstName = {"Dave","Steve"};
        String[] lastName = {"Smith","Carl"};
        String name = firstName[rand.nextInt(2)] + " " + lastName[rand.nextInt(2)];
        return name;
    }
}
