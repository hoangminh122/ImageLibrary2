using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using ImageLibrary.MongoDB.ApplicationBase.Entity;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoDB.Bson;
using System.Linq;

namespace ImageLibrary.MongoDB.Repository
{
    public interface IMongoRepository<TEntity, TPrimaryKey> where TEntity : class, IEntity<TPrimaryKey>
    {
        IMongoCollection<TEntity> Collection { get; }

        int Count();
        int Count(Expression<Func<TEntity,bool>> predicate);
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predication);
        bool Delete(Expression<Func<TEntity,bool>> predicate);
        bool Delete(ObjectId id);
        bool Delete(TEntity entity);
        bool Delete(TPrimaryKey id);
        Task<bool> DeleteAsync(Expression<Func<TEntity,bool>> predication);
        Task<bool> DeleteAsync(ObjectId id);
        Task<bool> DeleteAsync(TEntity entity);
        Task<bool> DeleteAsync(TPrimaryKey id);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
        TEntity FirstOrDefault(ObjectId id);
        TEntity FirstOrDefault(TPrimaryKey id);
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> FirstOrDefaultAsync(ObjectId id);
        TEntity Get(ObjectId id);
        TEntity Get(TPrimaryKey id);
        IQueryable<TEntity> GetAll();
        List<TEntity> GetAllList();
        List<TEntity> GetAllList(Expression<Func<TEntity,bool>> predicate);
        Task<List<TEntity>> GetAllListAsync();
        Task<List<TEntity>> GetAllListAsync(Expression<Func<TEntity,bool>> predicate);




    }
}
