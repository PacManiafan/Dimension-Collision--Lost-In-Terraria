using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace DimentionCollision.Items
{
	public class AustinsPhone : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("Ausin's Phone. Somehow it's still at 100% and it's clustered with a lot of things on it. Somehow you walk faster when distracted");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 40;
			item.value = Item.sellPrice(silver: 34);
			item.rare = ItemRarityID.Yellow;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.statDefense += 0;
			player.allDamage += 0f;
			player.maxRunSpeed += 40;
			player.statLifeMax2 += 0;
			player.statManaMax2 += 0;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wire, 15);
			recipe.AddIngredient(ItemID. Glass, 20);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}