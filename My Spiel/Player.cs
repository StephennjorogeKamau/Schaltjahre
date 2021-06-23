namespace My_Spiel
{
    class Player
    {
        //variable.
         private int life;
        private int mana;
        private int maxlife;
         private int minlife;
        private int maxmana;
        private int minmana;
        
        //konstruktor

        public Player(int life, int maxlife, int mana, int maxmana)
         {
            this.minlife = 0;
            this.minmana = 0;
            this.life = life;
            this.mana = mana;
            this.maxlife = maxlife;
            this.maxmana = maxmana;


         }

        //creat a methode for Attack
        public void Attack()
        {
            if (life > minlife)
            {
                life -= 10;
                if (life < minlife)
                {
                    life = minlife;
                }
            }
        }

        //creat a methode for spell
        public void Spell()
        {
            if (mana > minmana)
            {
                mana -= 10;
                if (mana < minmana)
                {
                    mana = minmana;
                }
            }
        }

        //The basic idea behind using Generic is to allow type(Integer, String, … etc and user-defined types)
        // to be a parameter to methods, classes, and interfaces. Advantages of Generics are Reuserbility, Type Safety, Perfomance.
        private int genericRegenerate(int value, int maxValue)
        {
            if (value < maxValue)
            {
                value += 10;
                if (value > maxValue)
                {
                    value = maxValue;
                }
            }
            return value;
        }

        public void RegenerateMana()
        {
            /*if (life < maxlife)
            {
                life += 10;
                if (life > maxlife)
                {
                    life = maxlife;
                }
            }*/
            mana = genericRegenerate(mana, maxmana);
        }

        public void Heal()
        
        {
            /*if (life < maxlife)
            {
                life += 10;
                if (life > maxlife)
                {
                    life = maxlife;
                }
            }*/

            life = genericRegenerate(life, maxlife);
        }

        // create a method for is defeated
        public bool IsDefeated()
        {
             return life == 0;
        }

        public int GetLife()
        {
            return life;
        }

        public int GetMana()
         {
             return mana;
         }


    }
}
