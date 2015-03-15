﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation.Supplements
{
    public class Weapon : Supplement
    {
        private const int Power = 10;
        private const int Aggression = 3;

        public Weapon()
            : base(Supplement.Zero, Supplement.Zero, Supplement.Zero)
        {
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is WeaponrySkill)
            {
                this.PowerEffect = Power;
                this.AggressionEffect = Aggression;
            }
        }
    }
}
