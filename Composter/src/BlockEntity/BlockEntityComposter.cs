
namespace Composter;

public class BlockEntityComposter : BlockEntityGenericTypedContainer
{
    protected override void InitInventory(Block block)
    {
        base.InitInventory(block);
        container.Inventory.OnAcquireTransitionSpeed += (type, stack, mul) => { return Core.Config.PerishRate; };
    }
}