using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace Terramon.Pokemon.FirstGeneration.Normal.Dragonite
{
    public class DragoniteNPC : NotCatchablePKMNBirdFlying
    { public override string Texture => "Terramon/Pokemon/FirstGeneration/Normal/Dragonite/Dragonite";
        public override Type HomeClass()
        {
            return typeof(Dragonite);
        }

        public override void SetDefaults()
        {
            base.SetDefaults();
            npc.width = 20;
            npc.height = 20;
            npc.scale = 1f;
        }



        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            Player player = spawnInfo.player;
            if (PlayerIsInForest(player))
                return 0f;
            return 0f;
        }
    }
}
