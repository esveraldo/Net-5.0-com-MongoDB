using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Infra.Data.Contracts
{
    public interface IMongoRepository<T>
    {
        List<T> Get();
        T Get(string id);
        T Create(T entity);
        void Update(string id, T entity);
        void Remove(string id);
    }
}
