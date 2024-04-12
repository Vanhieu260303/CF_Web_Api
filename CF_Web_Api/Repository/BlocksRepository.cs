using CF_Web_Api.Data;
using CF_Web_Api.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace CF_Web_Api.Repository
{
    public class BlocksRepository : IBlocksRepository
    {
        private readonly DataContext _dbcontext;

        public BlocksRepository(DataContext dbcontext)
        {
            _dbcontext=dbcontext;
        }

        public bool BlocksExits(Guid Id)
        {
            return _dbcontext.Blocks.Any(p => p.Id == Id);
        }

        public Blocks GetBlock(Guid Id)
        {
            return _dbcontext.Blocks.Where(p => p.Id == Id).FirstOrDefault();
        }

        public Blocks GetBlock(string Name)
        {
            return _dbcontext.Blocks.Where(p => p.BlockName == Name).FirstOrDefault();
        }

        public ICollection<Blocks> GetBlocks()
        {
            return  _dbcontext.Blocks.ToList();
        }

        
       
    }
}
