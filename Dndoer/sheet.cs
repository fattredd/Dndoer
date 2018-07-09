using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dndoer
{
    public class Sheet
    {
        public Sheet(string Name, string Race, int Str, int Dex, int Con, int Int, int Wis, int Cha, int MaxHP)
        {
            this.Name = Name;
            this.Race = Race;
            this.Exp = 0;

            // Stats
            this.Strength = new Stat(Str);
            this.Dexterity = new Stat(Dex);
            this.Constitution = new Stat(Con);
            this.Intelligence = new Stat(Int);
            this.Wisdom = new Stat(Wis);
            this.Charisma = new Stat(Cha);

            // Skills
            int[] a = DB.RaceSkills[this.Race];
            this.Acrobatics = new Skill(this.Dexterity, a[0]);
            this.AnimalHandling = new Skill(this.Wisdom, a[1]);
            this.Arcana = new Skill(this.Intelligence, a[2]);
            this.Athletics = new Skill(this.Strength, a[3]);
            this.Deception = new Skill(this.Charisma, a[4]);
            this.History = new Skill(this.Intelligence, a[5]);
            this.Insight = new Skill(this.Wisdom, a[6]);
            this.Intimidation = new Skill(this.Charisma, a[7]);
            this.Investigation = new Skill(this.Intelligence, a[8]);
            this.Medicine = new Skill(this.Wisdom, a[9]);
            this.Nature = new Skill(this.Intelligence, a[10]);
            this.Perception = new Skill(this.Wisdom, a[11]);
            this.Performance = new Skill(this.Charisma, a[12]);
            this.Persuasion = new Skill(this.Charisma, a[13]);
            this.Religion = new Skill(this.Intelligence, a[14]);
            this.SleightofHand = new Skill(this.Dexterity, a[15]);
            this.Stealth = new Skill(this.Dexterity, a[16]);
            this.Survival = new Skill(this.Wisdom, a[17]);

            // Status
            this.HP = new Status(MaxHP);
            this.DealthSaves = new Status(3, false);
        }

        private readonly DB DB;

        public string Name;
        public string Race;
        public int Exp;

        // Stats
        public Stat Strength;
        public Stat Dexterity;
        public Stat Constitution;
        public Stat Intelligence;
        public Stat Wisdom;
        public Stat Charisma;

        // Skills
        public Skill Acrobatics;
        public Skill AnimalHandling;
        public Skill Arcana;
        public Skill Athletics;
        public Skill Deception;
        public Skill History;
        public Skill Insight;
        public Skill Intimidation;
        public Skill Investigation;
        public Skill Medicine;
        public Skill Nature;
        public Skill Perception;
        public Skill Performance;
        public Skill Persuasion;
        public Skill Religion;
        public Skill SleightofHand;
        public Skill Stealth;
        public Skill Survival;

        // Status
        public Status HP;
        public Status DealthSaves;
    }

    public class Stat
    {
        public Stat(int BaseStat, int Modifier = 0)
        {
            this.BaseStat = BaseStat;
            this.Modifier = Modifier;
        }

        private readonly int BaseStat;
        private readonly int Modifier;

        public int Get() { return this.BaseStat + this.Modifier; }
        public int GetMod() { return this.Modifier; }
    }

    public class Skill
    {
        public Skill(Stat BaseStat, int Modifier = 0, bool Profession = false)
        {
            this.Profession = Profession;
            this.Modifier = Modifier;
            this.BaseStat = BaseStat.Get();
        }

        public bool Profession;
        public int Modifier;
        private int BaseStat;

        public int Get() { return this.BaseStat + this.Modifier + (this.Profession ? 2 : 0); }
        public void SetProfession(bool x = true) { this.Profession = x; }
    }

    public class Status
    {
        public Status(int Max, bool Falling = true)
        {
            this.Max = Max;
            this.Falling = Falling;
            this.Current = (this.Falling ? this.Max : 0);
        }   

        private readonly int Max;
        private int Current;
        private readonly bool Falling;

        public void Hit(int i) { this.Current += (this.Falling ? -1 * i : i); }
        public void Restore(int i) { this.Current -= (this.Falling ? -1 * i : i); }
        public void Set(int i) { this.Current = i; }
        public void Reset() { this.Current -= this.Max; }
        public float GetPercent() { return ( (float)this.Current / (float)this.Max ) * 100; }
    }

    
}
