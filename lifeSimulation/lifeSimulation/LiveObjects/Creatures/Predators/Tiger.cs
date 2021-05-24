﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lifeSimulation
{
    class Tiger : Predator<TigersFood>, HumansFood
    {
        public Tiger(int x, int y, Map map) : base(x, y, map)
        {

        }
        public override void Birth()
        {
            AbilityToBirth = false;
            CurFromBirth = 100;
            Tiger baby = new Tiger(x, y, map);
            baby.CurFromBirth = 100;
            baby.AbilityToBirth = false;
            map.allLiveObjects.Add(baby);
        }

        public override void setKindAndName()
        {
            KindForDisplay = "Predator";
            NameForDisplay = "Tiger";
        }
    }
}
