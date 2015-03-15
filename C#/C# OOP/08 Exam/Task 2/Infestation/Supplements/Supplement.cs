﻿namespace Infestation.Supplements
{
    public abstract class Supplement : ISupplement
    {
        public Supplement(int power, int health, int aggression)
        {
            this.PowerEffect = power;
            this.HealthEffect = health;
            this.AggressionEffect = aggression;
        }

        public int PowerEffect
        {
            get;
            protected set;
        }

        public int HealthEffect
        {
            get;
            protected set;
        }

        public int AggressionEffect
        {
            get;
            protected set;
        }

        public virtual void ReactTo(ISupplement otherSupplement)
        {
            // what should be inside?
        }
    }
}
