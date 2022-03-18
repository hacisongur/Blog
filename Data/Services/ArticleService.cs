using Data.Repositories.IRepository;
using Data.Services.IService;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class ArticleService : Services<Article>, IArticleService
    {
        public ArticleService(IUnitOfWork unitOfWork, IRepository<Article> repository) : base(unitOfWork, repository)
        {
        }
    }
}
