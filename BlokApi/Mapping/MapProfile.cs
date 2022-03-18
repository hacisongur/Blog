using AutoMapper;
using Models;
using Models.DTO;

namespace BlokApi.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Article, ArticleDTO>().ReverseMap();
        }
    }
}
