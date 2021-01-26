using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SwordDamageWPF
{
    class SwordDamage
    {
        public SwordDamage(int roll)
        {
            this.roll = roll;
        }

        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        private int roll;
        private bool flaming;
        private bool magic;


        /// <summary>
        /// Damage property
        /// </summary>
        public int Damage { get; private set; }

        /// <summary>
        /// Roll property, Takes the roll as a value, and then calls the CalculateDamage method
        /// </summary>
        public int Roll {
            get { return roll; }
            set { roll = value; CalculateDamage(); }
        }
        /// <summary>
        /// Flaming property, Sets the Flaming value of the sword on or off, and then calls the CalculateDamage method
        /// </summary>
        public bool Flaming {
            get { return flaming; }
            set { flaming = value; CalculateDamage(); } 
        }
        /// <summary>
        /// Magic property,  Sets the Magic value of the sword on or off, and then calls the CalculateDamage method
        /// </summary>
        public bool Magic { 
            get { return magic; }
            set { magic = value; CalculateDamage(); }
        }



        private void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;

        }
    }
}
