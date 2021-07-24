using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace DimentionCollision.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class AustinsHoodie : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A blue hoodie with a small rootbeer stain. due to the power of bullshit, it gives magical abilities, but with a cost.");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.rare = ItemRarityID.Orange;
            item.defense = 10;
        }
        public override void UpdateEquip(Player player)
        {
            player.rangedDamage += 0.4f;
            player.rangedCrit += 4;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 15);
            recipe.AddIngredient(ModContent.ItemType<BlankHoodie>());
            recipe.AddIngredient(ItemID.BlueDye, 5);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}