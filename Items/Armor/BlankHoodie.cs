using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace DimentionCollision.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class BlankHoodie : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A White hoodie. seems like it could be dyed.");
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.rare = ItemRarityID.White;
            item.defense = 10;
        }
        public override void UpdateEquip(Player player)
        {
            player.rangedDamage += 0.1f;
            player.rangedCrit += 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 15);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}