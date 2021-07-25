using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DimensionCollision
{
    public class DCPlayer : ModPlayer
    {
        public bool phone;

        public override void ResetEffects()
        {
            phone = false;
        }

        public override void PostUpdateRunSpeeds()
        {
            if (phone)
                player.moveSpeed += .4f;
        }
    }
}
