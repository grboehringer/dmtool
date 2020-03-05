import java.util.*;

public class DungeonMasterStudio{
    public static void main(String[] args) {
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
    public static String nameGenerator() {
        Random rand = new Random();

        String[] firstName = {"Dave","Steve"};
        String[] lastName = {"Smith","Carl"};
        String name = firstName[rand.nextInt(2)] + " " + lastName[rand.nextInt(2)];
        return name;
    }
}
