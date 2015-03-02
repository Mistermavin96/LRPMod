using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TAPI;
using Terraria;

namespace LRPMod.Projectiles
{
    public class ChloroplasmProj : ModItem
    {
        public ChloroplasmProj(ModBase modBase, Projectile projectile);

			public void vampireHeal(int dmg, Player owner, ref int damage)
            {
                owner.statLife += (int)(damage *  0.1f);
            }
    }
}