using AutoMapper;
using Data.Services.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTO;


namespace BLOGN.API.Controllers
{
    [Route("api/v1/Article")]
    //[Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _categoryService;
        private readonly IMapper _mapper;
        public ArticleController(IArticleService categoryService, IMapper mapper)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var articles = await _categoryService.GetAll();
            var articlesDto = _mapper.Map<IEnumerable<ArticleDTO>>(articles);

            return Ok(articlesDto);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get(int Id)
        {
            var category = await _categoryService.Get(Id);
            var categoryDto = _mapper.Map<ArticleDTO>(category);
            return Ok(categoryDto);
        }

        [HttpPost]
        public async Task<IActionResult> Save(ArticleDTO categoryDto)
        {
            var category = _mapper.Map<Article>(categoryDto);
            var newArticle = await _categoryService.Add(category);
            return Created(String.Empty, null); // _mapper.Map<ArticleDto>(newArticle));
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Put(int Id, ArticleDTO articleDto)
        {
            if (Id == 0)
            {
                return BadRequest();
            }

            var article = _mapper.Map<Article>(articleDto);
            _categoryService.Update(article);
            return NoContent();
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete(int Id)
        {
            var entity = _categoryService.Delete(Id);
            return NoContent();
        }
    }
}