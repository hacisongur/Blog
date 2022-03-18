using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public  class ArticleDTO
    {
      
        public int Id { get; set; }
    
        public string? Title { get; set; }
       
        public string? BlogContent { get; set; }
     
        public DateTime ArticleDate { get; set; }
     
        public int CategorId { get; set; }    
    
    }
}
