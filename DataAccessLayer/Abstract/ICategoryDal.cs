using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        //List<Category> ListAllCategory();

        //void AddCategory(Category category);

        //void DeleteCategory(Category category);

        //void UpdateCategory(Category category);

        //Category GetById(int id); //bir kategori üzerinde silme güncelleme işlemi yapacağımda onu id ile getirmeliyim.  Id'ye göre getir, Id'ye göre al.
    }
}
