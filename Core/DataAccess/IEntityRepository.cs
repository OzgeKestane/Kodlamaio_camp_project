using Core.Entities;

using System.Linq.Expressions;

namespace Core.DataAccess
{//generic constraint -- generic kısıtlaması 
    //T:class ; referans tip olmalı 
    //new() ; newlenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //Expression filtreler yazabilmemizi sağlıyor getAll'ın içerisine, sorgu gibi LINQ ile
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


    }
}
