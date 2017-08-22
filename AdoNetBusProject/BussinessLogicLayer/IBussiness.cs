using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer
{
    interface IBussiness<TEntity> where TEntity : class
    {
        List<TEntity> GetAllBLL();
        TEntity GetBLL(int key);

        bool SaveBLL(TEntity item);
        bool UpdateBLL(TEntity item);
        bool DeleteBLL(TEntity item);
    }
}
