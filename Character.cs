using System;
using System.Collections.Generic;

namespace dmtool{
    public class Character{
        string[] name;
        Race race;
        string gender;
        Background background;
        Class clss;
        int[] abilities = new int[6] {0, 0, 0, 0, 0, 0};
        // 0 = Str, 1 = Dex, 2 = Con, 3 = Int, 4 = Wis, 5 = Cha
        bool[] savingProf = new bool[6] {false, false, false, false, false, false};
        // 0 = Str, 1 = Dex, 2 = Con, 3 = Int, 4 = Wis, 5 = Cha
        bool[,] skillProf = new bool[19, 2] {{false, false}, {false, false}, {false, false}, {false, false},
         {false, false}, {false, false}, {false, false}, {false, false}, {false, false}, {false, false}, 
         {false, false}, {false, false}, {false, false}, {false, false}, {false, false}, {false, false}, 
         {false, false}, {false, false}, {false, false}};
        /* 0 = Acrobatics, 1 = Animal Handling, 2 = Arcana, 3 = Athletics, 4 = Deception, 5 = History,
         * 6 = Insight, 7 = Intimidation, 8 = Investigation, 9 = Medicine, 10 = Nature, 11 = Perception,
         * 12 = Performance, 13 = Persuasion, 14 = Religion, 15 = Sleight of Hand, 16 = Stealth, 
         * 17 = Survival, 18 = Tool
         */
        bool[] armorProf = new bool[4] {false, false, false, false};
        // 0 = Light, 1 = Medium, 2 = Heavy, 3 = Shields
        bool[] weaponProf = new bool[3] {false, false, false};
        // 0 = Simple, 1 = Martial, 2 = Other
        List<Feature> Features = new List<Feature>();


        public Character(){
            name = generateName();
        }
        public string[] generateName() {
            

            Random rand = new Random();

            string[] name = new string[2];
            
            Console.Write("Race: ");
            string race = Console.ReadLine();
            Console.Write("Gender: ");
            string gender = Console.ReadLine();

            string[] dwarfMale = {"Adrik", "Alberich", "Baern", "Barendd", "Brottor",
                "Bruenor", "Dain", "Darrak", "Delg", "Eberk", "Einkil", "Fargrim",
                "Flint", "Gardain", "Harbek", "Kildrak", "Morgran", "Orsik",
                "Oskar", "Rangrim", "Rurik", "Taklinn", "Thoradin", "Thorin",
                "Tordek", "Traubon", "Travok", "Ulfgar", "Veit", "Vondal"};

            string[] dwarfFemale = {"Amber", "Artin", "Audhild", "Bardryn",
                "Dagnal", "Diesa", "Eldeth", "Falkrunn", "Finellen", "Gunnloda",
                "Gurdis", "Helja", "Hlin", "Kathra", "Kristryd", "Ilde", "Liftrasa",
                "Mardred", "Riswynn", "Sannl", "Torbera", "Torgga", "Vistra"};

            string[] dwarfLast = {"Balderk", "Battlehammer", "Brawnanvil",
                "Dankil", "Fireforge", "Frostbeard", "Gorunn", "Holderhek",
                "Ironfist", "Loderr", "Lutgehr", "Rumnaheim", "Strakeln",
                "Torunn", "Ungart"};

            string[] elfMale = {"Adran", "Aelar", "Aramil", "Arannis",
                "Aust", "Beiro", "Berrian", "Carric", "Enialis", "Erdan", "Erevan",
                "Galinndan", "Hadarai", "Heian", "Himo", "Immeral", "Ivellios",
                "Laucian", "Mindartis", "Paelias", "Peren", "Quarion", "Riardon",
                "Rolen", "Soveliss", "Thamior", "Tharivol", "Theren", "Varis"};

            string[] elfFemale = {"Adrie", "Althaea", "Anastrianna",
                "Andraste", "Antinua", "Bethrynna", "Birel", "Caelynn",
                "Drusilia", "Enna", "Felosial", "Ielenia", "Jelenneth", "Keyleth",
                "Leshanna", "Lia", "Meriele", "Mialee", "Naivara", "Quelenna",
                "Quillathe", "Sariel", "Shanairra", "Shava", "Silaqui",
                "Theirastra", "Thia", "Vadania", "Valanthe", "Xanaphia"};

            string[] elfLast = {"Amakiir", "Am astacia", "Galanodel", 
                "H olim ion", "Ilphelkiir", "Liadon", "Meliamne",
                "Nai'lo", "Siannodel", "Xiloscient"};

            string[] halflingMale = {"Alton", "Ander", "Cade", "Corrin", "Eldon", "Errich",
                "Finnan", "Garret", "Lindal", "Lyle", "Merric", "Milo", "Osborn",
                "Perrin", "Reed", "Roscoe", "Wellby"};

            string[] halflingFemale = {"Andry", "Bree", "Callie", "Cora", "Euphemia",
                "Jillian", "Kithri", "Lavinia", "Lidda", "Merla", "Nedda", "Paela",
                "Portia", "Seraphina", "Shaena", "Trym", "Vani", "Verna"};

            string[] halflingLast = {"Brushgather", "Goodbarrel", "Greenbottle",
                "High-hill", "Hilltopple", "Leagallow", "Tealeaf", "Thorngage",
                "Tosscobble", "Underbough"};

            string[] dragonbornMale = {"Arjhan", "Balasar", "Bharash", "Donaar", "Ghesh",
                "Heskan", "Kriv", "Medrash", "Mehen", "Nadarr", "Pandjed",
                "Patrin", "Rhogar", "Shamash", "Shedinn", "Tarhun", "Torinn"};

            string[] dragonbornFemale = {"Akra", "Biri", "Daar", "Farideh", "Harann",
                "Flavilar", "Jheri", "Kava", "Korinn", "Mishann", "Nala", "Perra",
                "Raiann", "Sora", "Surina", "Thava", "Uadjit"};

            string[] dragonbornLast = {"Clethtinthiallor", "Daardendrian", "Delmirev",
                "Drachedandion", "Fenkenkabradon", "Kepeshkmolik",
                "Kerrhylon", "Kimbatuul", "Linxakasendalor", "Myastan",
                "Nemmonis", "Norixius", "Ophinshtalajiir", "Prexijandilin",
                "Shestendeliath", "Turnuroth", "Verthisathurgiesh", "Yarjerit"};

            string[] gnomeMale = {"Alston", "Alvyn", "Boddynock", "Brocc", "Burgell",
                "Dimble", "Eldon", "Erky", "Fonkin", "Frug", "Gerbo", "Gimble",
                "Glim", "Jebeddo", "Kellen", "Namfoodle", "Orryn", "Roondar",
                "Seebo", "Sindri", "Warryn", "Wrenn", "Zook"};

            string[] gnomeFemale = {"Bimpnottin", "Breena", "Caramip", "Carlin",
                "Donella", "Duvamil", "Ella", "Ellyjobell", "Ellywick", "Lilli",
                "Loopmottin", "Lorilla", "Mardnab", "Nissa", "Nyx", "Oda", "Orla",
                "Roywyn", "Shamil", "Tana", "Waywocket", "Zanna"};

            string[] gnomeLast = {"Beren", "Daergel", "Folkor", "Garrick", "Nackle",
                "Murnig", "Ningel", "Raulnor", "Scheppen", "Timbers", "Turen"};

            string[] orcMale = {"Dench", "Feng", "Gell", "Henk", "Holg", "Imsh",
                "Keth", "Krusk", "Mhurren", "Ront", "Shump", "Thokk"};
            
            string[] orcFemale = {"Baggi", "Emen", "Engong", "Kansif",
                "Myev", "Neega", "Ovak", "Ownka", "Shautha", "Sutha", "Vola",
                "Volen", "Yevelda"};

            string[] tieflingMale = {"Akmenos", "Amnon", "Barakas",
                "Damakos", "Ekemon", "Iados", "Kairon", "Leucis", "Melech",
                "Mordai", "Morthos", "Pelaios", "Skamos", "Therai"};

            string[] tieflingFemale = {"Akta", "Anakis", "Bryseis", "Criella",
                "Damaia", "Ea", "Kallista", "Lerissa", "Makaria", "Nemeia",
                "Orianna", "Phelaia", "Rieta"};

            string[] tieflingLast = {"Art", "Carrion", "Chant", "Creed", "Despair",
                "Excellence", "Fear", "Glory", "Hope", "Ideal", "Music", "Nowhere",
                "Open", "Poetry", "Quest", "Random", "Reverence", "Sorrow",
                "Temerity", "Torment", "Weary"};

            

            switch (race){
                case "dwarf":
                    if (gender.Equals("male")){
                        name[0] = dwarfMale[rand.Next(dwarfMale.Length)];
                    }
                    else{
                        name[0] = dwarfFemale[rand.Next(dwarfFemale.Length)];
                    }
                    name[1] = dwarfLast[rand.Next(dwarfLast.Length)];
                break;
                case "elf":
                    if (gender.Equals("male")){
                        name[0] = elfMale[rand.Next(elfMale.Length)];
                    }
                    else{
                        name[0] = elfFemale[rand.Next(elfFemale.Length)];
                    }
                    name[1] = elfLast[rand.Next(elfLast.Length)];
                break;
                case "halfling":
                    if (gender.Equals("male")){
                        name[0] = halflingMale[rand.Next(halflingMale.Length)];
                    }
                    else{
                        name[0] = halflingFemale[rand.Next(halflingFemale.Length)];
                    }
                    name[1] = halflingLast[rand.Next(halflingLast.Length)];
                break;
                case "dragonborn":
                    if (gender.Equals("male")){
                        name[0] = dragonbornMale[rand.Next(dragonbornMale.Length)];
                    }
                    else{
                    name[0] = dragonbornFemale[rand.Next(dragonbornFemale.Length)]; 
                    }
                    name[1] = dragonbornLast[rand.Next(dragonbornLast.Length)];
                break;
                case "gnome":
                    if (gender.Equals("male")){
                        name[0] = gnomeMale[rand.Next(gnomeMale.Length)];
                    }
                    else{
                        name[0] = gnomeFemale[rand.Next(gnomeFemale.Length)];
                    }
                    name[1] = gnomeLast[rand.Next(gnomeLast.Length)];
                break;
                case "orc":
                    if (gender.Equals("male")){
                        name[0] = orcMale[rand.Next(orcMale.Length)];
                    }
                    else{
                    name[0] = orcFemale[rand.Next(orcFemale.Length)]; 
                    }
                    name[1] = " ";
                break;
                case "tiefling":
                    if (gender.Equals("male")){
                        name[0] = tieflingMale[rand.Next(tieflingMale.Length)];
                    }
                    else{
                        name[0] = tieflingFemale[rand.Next(tieflingFemale.Length)];
                    }
                    name[1] = tieflingLast[rand.Next(tieflingLast.Length)];
                break;
                default:
                    name[0] = "Invalid";
                    name[1] = "input.";
                break;
            }
            return name;
        }

        public string toString(){
            string output = name[0] + " " + name[1];
            return output;
        }
    }
}