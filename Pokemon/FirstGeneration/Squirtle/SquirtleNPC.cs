using System;

namespace Terramon.Pokemon.Squirtle
{
    public class SquirtleNPC : ParentPokemonNPC
    {
        public override Type HomeClass() => typeof(Squirtle);

        public override void SetDefaults()
        {
            base.SetDefaults();
            npc.width = 20;
            npc.height = 20;
        }
    }
}