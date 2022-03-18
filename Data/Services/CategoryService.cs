using Data.Repositories.IRepository;
using Data.Services.IService;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class CategoryService : Services<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }

        public Task Add(CategoryDto categoryDto)
        {
            throw new NotImplementedException();
        }

        public void Update(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
