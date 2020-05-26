using System;
using System.Collections.Generic;
namespace dmtool{
    public class Race{
        string race;
        int[] ability = new int[6];
        int speed;
        // 0 = Str, 1 = Dex, 2 = Con, 3 = Int, 4 = Wis, 5 = Cha
        List<Feature> raceFeatures = new List<Feature>(); 
        
        public void calcAbility(){
            int[] raceAbility = {0, 0, 0, 0, 0, 0};
            switch(race){
                case "Hill Dwarf":
                    raceAbility[2] = 2;
                    raceAbility[4] = 1;
                    break;
                case "Mountain Dwarf":
                    raceAbility[0] = 2;
                    break;
                case "High Elf":
                    raceAbility[1] = 2;
                    break;
                case "Wood Elf":
                    raceAbility[1] = 2;
                    raceAbility[4] = 1;
                    break;
                case "Dark Elf":
                    raceAbility[1] = 2;
                    raceAbility[5] = 1;
                    break;
                case "Lightfoot Halfling":
                    raceAbility[1] = 2;
                    raceAbility[5] = 1;
                    break;
                case "Stout Halfling":
                    raceAbility[1] = 2;
                    raceAbility[2] = 1;
                    break;
                case "Human":
                    raceAbility[0] = 1;
                    raceAbility[1] = 1;
                    raceAbility[2] = 1;
                    raceAbility[3] = 1;
                    raceAbility[4] = 1;
                    raceAbility[5] = 1;
                    break;
                case "Dragonborn":
                    raceAbility[0] = 2;
                    raceAbility[5] = 1;
                    break;
                case "Forest Gnome":
                    raceAbility[1] = 1;
                    raceAbility[3] = 2;
                    break;
                case "Rock Gnome":
                    raceAbility[1] = 1;
                    raceAbility[2] = 1;
                    break;
                case "Half-Elf":
                    raceAbility[3] = 1;
                    raceAbility[5] = 2;
                    break;
                case "Half-Orc":
                    raceAbility[0] = 2;
                    raceAbility[2] = 1;
                    break;
                case "Tiefling":
                    raceAbility[3] = 1;
                    raceAbility[5] = 2;
                    break;
                default:
                    break;
            }
            ability = raceAbility;
        }

        public void calcSpeed(){
            switch(race){
                case "Hill Dwarf":
                case "Mountain Dwarf":
                    speed = 25;
                    break;
                case "High Elf":
                case "Wood Elf":
                case "Dark Elf":
                    speed = 30;
                    break;
                case "Lightfoot Halfling":
                case "Stout Halfling":
                    speed = 25;
                    break;
                case "Human":
                    speed = 30;
                    break;
                case "Dragonborn":
                    speed = 30;
                    break;
                case "Forest Gnome":
                case "Rock Gnome":
                    speed = 25;
                    break;
                case "Half-Elf":
                    speed = 30;
                    break;
                case "Half-Orc":
                    speed = 30;
                    break;
                case "Tiefling":
                    speed = 30;
                    break;
                default:
                    break;
            }
        }
    }
}