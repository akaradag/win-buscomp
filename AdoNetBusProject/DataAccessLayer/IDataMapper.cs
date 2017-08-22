using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    interface IDataMapper<TEntity>
    {
        TEntity Get(int key);
        List<TEntity> GetAll();
        int Insert(TEntity item);
        int Update(TEntity item);
        int Delete(TEntity item);
    }
}
