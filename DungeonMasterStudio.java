import java.util.*;
public class DungeonMasterStudio{
    public static void main(String[] args) {
        boolean again;
        do{
            start();
            again = yesNo();
        }while(again == true);
        Character character = new Character();
        System.out.println(character.toString());
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
    }
}
class Character{
    String[] name;
    public Character(){
        name = generateName();
    }
    public String[] generateName() {
        final Scanner s = new Scanner(System.in);

        final Random rand = new Random();

        final String[] name = new String[2];
        
        System.out.print("Race: ");
        final String race = s.nextLine();
        System.out.print("Gender: ");
        final String gender = s.nextLine();

        final String[] dwarfMale = {"Adrik", "Alberich", "Baern", "Barendd", "Brottor",
            "Bruenor", "Dain", "Darrak", "Delg", "Eberk", "Einkil", "Fargrim",
            "Flint", "Gardain", "Harbek", "Kildrak", "Morgran", "Orsik",
            "Oskar", "Rangrim", "Rurik", "Taklinn", "Thoradin", "Thorin",
            "Tordek", "Traubon", "Travok", "Ulfgar", "Veit", "Vondal"};

        final String[] dwarfFemale = {"Amber", "Artin", "Audhild", "Bardryn",
            "Dagnal", "Diesa", "Eldeth", "Falkrunn", "Finellen", "Gunnloda",
            "Gurdis", "Helja", "Hlin", "Kathra", "Kristryd", "Ilde", "Liftrasa",
            "Mardred", "Riswynn", "Sannl", "Torbera", "Torgga", "Vistra"};

        final String[] dwarfLast = {"Balderk", "Battlehammer", "Brawnanvil",
            "Dankil", "Fireforge", "Frostbeard", "Gorunn", "Holderhek",
            "Ironfist", "Loderr", "Lutgehr", "Rumnaheim", "Strakeln",
            "Torunn", "Ungart"};

        final String[] elfMale = {"Adran", "Aelar", "Aramil", "Arannis",
            "Aust", "Beiro", "Berrian", "Carric", "Enialis", "Erdan", "Erevan",
            "Galinndan", "Hadarai", "Heian", "Himo", "Immeral", "Ivellios",
            "Laucian", "Mindartis", "Paelias", "Peren", "Quarion", "Riardon",
            "Rolen", "Soveliss", "Thamior", "Tharivol", "Theren", "Varis"};

        final String[] elfFemale = {"Adrie", "Althaea", "Anastrianna",
            "Andraste", "Antinua", "Bethrynna", "Birel", "Caelynn",
            "Drusilia", "Enna", "Felosial", "Ielenia", "Jelenneth", "Keyleth",
            "Leshanna", "Lia", "Meriele", "Mialee", "Naivara", "Quelenna",
            "Quillathe", "Sariel", "Shanairra", "Shava", "Silaqui",
            "Theirastra", "Thia", "Vadania", "Valanthe", "Xanaphia"};

        final String[] elfLast = {"Amakiir", "Am astacia", "Galanodel", 
            "H olim ion", "Ilphelkiir", "Liadon", "Meliamne",
            "Nai'lo", "Siannodel", "Xiloscient"};

        final String[] halflingMale = {"Alton", "Ander", "Cade", "Corrin", "Eldon", "Errich",
            "Finnan", "Garret", "Lindal", "Lyle", "Merric", "Milo", "Osborn",
            "Perrin", "Reed", "Roscoe", "Wellby"};

        final String[] halflingFemale = {"Andry", "Bree", "Callie", "Cora", "Euphemia",
            "Jillian", "Kithri", "Lavinia", "Lidda", "Merla", "Nedda", "Paela",
            "Portia", "Seraphina", "Shaena", "Trym", "Vani", "Verna"};

        final String[] halflingLast = {"Brushgather", "Goodbarrel", "Greenbottle",
            "High-hill", "Hilltopple", "Leagallow", "Tealeaf", "Thorngage",
            "Tosscobble", "Underbough"};

        final String[] dragonbornMale = {"Arjhan", "Balasar", "Bharash", "Donaar", "Ghesh",
            "Heskan", "Kriv", "Medrash", "Mehen", "Nadarr", "Pandjed",
            "Patrin", "Rhogar", "Shamash", "Shedinn", "Tarhun", "Torinn"};

        final String[] dragonbornFemale = {"Akra", "Biri", "Daar", "Farideh", "Harann",
            "Flavilar", "Jheri", "Kava", "Korinn", "Mishann", "Nala", "Perra",
            "Raiann", "Sora", "Surina", "Thava", "Uadjit"};

        final String[] dragonbornLast = {"Clethtinthiallor", "Daardendrian", "Delmirev",
            "Drachedandion", "Fenkenkabradon", "Kepeshkmolik",
            "Kerrhylon", "Kimbatuul", "Linxakasendalor", "Myastan",
            "Nemmonis", "Norixius", "Ophinshtalajiir", "Prexijandilin",
            "Shestendeliath", "Turnuroth", "Verthisathurgiesh", "Yarjerit"};

        final String[] gnomeMale = {"Alston", "Alvyn", "Boddynock", "Brocc", "Burgell",
            "Dimble", "Eldon", "Erky", "Fonkin", "Frug", "Gerbo", "Gimble",
            "Glim", "Jebeddo", "Kellen", "Namfoodle", "Orryn", "Roondar",
            "Seebo", "Sindri", "Warryn", "Wrenn", "Zook"};

        final String[] gnomeFemale = {"Bimpnottin", "Breena", "Caramip", "Carlin",
            "Donella", "Duvamil", "Ella", "Ellyjobell", "Ellywick", "Lilli",
            "Loopmottin", "Lorilla", "Mardnab", "Nissa", "Nyx", "Oda", "Orla",
            "Roywyn", "Shamil", "Tana", "Waywocket", "Zanna"};

        final String[] gnomeLast = {"Beren", "Daergel", "Folkor", "Garrick", "Nackle",
            "Murnig", "Ningel", "Raulnor", "Scheppen", "Timbers", "Turen"};

        final String[] orcMale = {"Dench", "Feng", "Gell", "Henk", "Holg", "Imsh",
            "Keth", "Krusk", "Mhurren", "Ront", "Shump", "Thokk"};
        
        final String[] orcFemale = {"Baggi", "Emen", "Engong", "Kansif",
            "Myev", "Neega", "Ovak", "Ownka", "Shautha", "Sutha", "Vola",
            "Volen", "Yevelda"};

        final String[] tieflingMale = {"Akmenos", "Amnon", "Barakas",
            "Damakos", "Ekemon", "Iados", "Kairon", "Leucis", "Melech",
            "Mordai", "Morthos", "Pelaios", "Skamos", "Therai"};

        final String[] tieflingFemale = {"Akta", "Anakis", "Bryseis", "Criella",
            "Damaia", "Ea", "Kallista", "Lerissa", "Makaria", "Nemeia",
            "Orianna", "Phelaia", "Rieta"};

        final String[] tieflingLast = {"Art", "Carrion", "Chant", "Creed", "Despair",
            "Excellence", "Fear", "Glory", "Hope", "Ideal", "Music", "Nowhere",
            "Open", "Poetry", "Quest", "Random", "Reverence", "Sorrow",
            "Temerity", "Torment", "Weary"};

        

        switch (race){
            case "dwarf":
                if (gender.equals("male")){
                    name[0] = dwarfMale[rand.nextInt(dwarfMale.length)];
                }
                else{
                    name[0] = dwarfFemale[rand.nextInt(dwarfFemale.length)];
                }
                name[1] = dwarfLast[rand.nextInt(dwarfLast.length)];
            break;
            case "elf":
                if (gender.equals("male")){
                    name[0] = elfMale[rand.nextInt(elfMale.length)];
                }
                else{
                    name[0] = elfFemale[rand.nextInt(elfFemale.length)];
                }
                name[1] = elfLast[rand.nextInt(elfLast.length)];
            break;
            case "halfling":
                if (gender.equals("male")){
                    name[0] = halflingMale[rand.nextInt(halflingMale.length)];
                }
                else{
                    name[0] = halflingFemale[rand.nextInt(halflingFemale.length)];
                }
                name[1] = halflingLast[rand.nextInt(halflingLast.length)];
            break;
            case "dragonborn":
                if (gender.equals("male")){
                    name[0] = dragonbornMale[rand.nextInt(dragonbornMale.length)];
                }
                else{
                name[0] = dragonbornFemale[rand.nextInt(dragonbornFemale.length)]; 
                }
                name[1] = dragonbornLast[rand.nextInt(dragonbornLast.length)];
            break;
            case "gnome":
                if (gender.equals("male")){
                    name[0] = gnomeMale[rand.nextInt(gnomeMale.length)];
                }
                else{
                    name[0] = gnomeFemale[rand.nextInt(gnomeFemale.length)];
                }
                name[1] = gnomeLast[rand.nextInt(gnomeLast.length)];
            break;
            case "orc":
                if (gender.equals("male")){
                    name[0] = orcMale[rand.nextInt(orcMale.length)];
                }
                else{
                name[0] = orcFemale[rand.nextInt(orcFemale.length)]; 
                }
                name[1] = " ";
            break;
            case "tiefling":
                if (gender.equals("male")){
                    name[0] = tieflingMale[rand.nextInt(tieflingMale.length)];
                }
                else{
                    name[0] = tieflingFemale[rand.nextInt(tieflingFemale.length)];
                }
                name[1] = tieflingLast[rand.nextInt(tieflingLast.length)];
            break;
            default:
                name[0] = "Invalid";
                name[1] = "input.";
            break;
        }
        return name;
    }

    public String toString(){
        String output = name[0] + " " + name[1];
        return output;
    }
}
