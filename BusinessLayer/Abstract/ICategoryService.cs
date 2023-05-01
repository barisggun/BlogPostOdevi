using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void Create(Category category);
        void Update(Category category);
        void Delete(Category category);
        Category Get(int id);
        List<Category> ListAll();
    }
}
