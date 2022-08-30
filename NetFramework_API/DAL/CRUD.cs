using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework_API.DAL 
{ 
    public interface CRUD<TEntity>
    {
        List<TEntity> getAll();
        TEntity getById(long Id);
        void update(TEntity DBEntity, TEntity entity);
        void delete(TEntity entity);
        void create(TEntity entity);
    }
}
