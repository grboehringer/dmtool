namespace dmtool{
    public class Spell{
        private string name;
        private int level;
        private string school;
        private string time;
        private string range;
        private string components;
        private string duration;
        private string description;
        private string damageType;
        public Spell(string spellName, int spellLevel, string spellSchool, string spellTime, string spellRange, 
                    string spellComponents, string spellDuration, string spellDescription, string spellDamageType){
            name = spellName;
            level = spellLevel;
            school = spellSchool;
            time = spellTime;
            range = spellRange;
            components = spellComponents;
            duration = spellDuration;
            description = spellDescription;
            damageType = spellDamageType;
        }
    }
}