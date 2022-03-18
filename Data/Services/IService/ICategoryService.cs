using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services.IService
{
    public interface ICategoryService : IService<Category>
    {
        Task Add(CategoryDto categoryDto);
        void Update(Article article);
    }
}
