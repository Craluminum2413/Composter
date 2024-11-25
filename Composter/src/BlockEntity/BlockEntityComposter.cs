
namespace Composter;

public class BlockEntityComposter : BlockEntityGenericTypedContainer
{
    protected override void InitInventory(Block block)
    {
        base.InitInventory(block);
        container.Inventory.OnAcquireTransitionSpeed += (type, stack, mul) =>
        {
            return type == EnumTransitionType.Perish ? Core.Config.PerishRate : container.GetPerishRate();
        };
    }
}