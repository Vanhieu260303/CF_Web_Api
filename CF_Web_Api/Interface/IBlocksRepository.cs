using CF_Web_Api.Data;

namespace CF_Web_Api.Interface
{
    public interface IBlocksRepository
    {
        ICollection<Blocks> GetBlocks();
        Blocks GetBlock(Guid Id);
        Blocks GetBlock(string Name);
        bool BlocksExits(Guid Id);
    }
}
