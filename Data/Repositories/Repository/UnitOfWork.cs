using Data.Repositories.IRepository;
using Microsoft.Extensions.Options;
using SharedTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Repository
{
    public class UnitOfWork : IUnitOfWork
    {       
        private readonly AppDbContext _context;
        private readonly IOptions<AppSettings> _appsetting;
        public UnitOfWork(AppDbContext context,IOptions<AppSettings>appSettings)
        {
            _context = context;
            _appsetting = appSettings;
        }
        public ICategoryRepository Category => new CategoryRepository(_context);
        public IArticleRepository Article => new ArticleRepository(_context);
        public IUserRepository User => new UserRepository(_context,_appsetting);
        public void Dispose()
        {
            _context.Dispose();
        }
        public void Save()
        {
            _context.SaveChanges(); //****
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();  
        }
       
    }
}
