using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace DimensionCollision.Items.Accessories
{
    public class SealedCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A crystal shines 3 colors. Blue, Black, and Yellow... it gives a strange aura like people are inside them");
        }
        public override void SetDefaults()
        {
            item.width = 64;
            item.height = 64;
        }

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			if (player.name == "Austin" || player.name == "Sage" || player.name == "Sophie")
				
			{
				player.statDefense += 40;
				player.allDamage += 0.2f;
				player.maxRunSpeed += 40;
				player.statLifeMax2 += 40;
				player.statManaMax2 += 30;
			}
			else
			{
				player.statDefense += 20;
				player.allDamage += 0.1f;
				player.maxRunSpeed += 20;
				player.statLifeMax2 += 35;
				player.statManaMax2 += 20;
			}
		}
	}
}
