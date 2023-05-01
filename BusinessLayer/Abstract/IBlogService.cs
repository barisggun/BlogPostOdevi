using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void Create(Blog blog);
        void Update(Blog blog);
        void Delete(Blog blog);
        Blog Get(int id);
        List<Blog> ListAll();
    }
}
