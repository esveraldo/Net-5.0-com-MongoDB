using Api.Entities.Base;
using Api.Infra.Data.Contracts;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Infra.Data.Connection
{
    public class MongoRepository<T> : IMongoRepository<T> where T : Entity
    {
        private readonly IMongoCollection<T> _model;

        public MongoRepository(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _model = database.GetCollection<T>(typeof(T).Name.ToLower());
        }

        public List<T> Get()
        {
           return _model.Find(active => true).ToList();
        }

        public T Get(string id)
        {
            return _model.Find<T>(entity => entity.Id == id).FirstOrDefault();
        }

        public T Create(T entity)
        {
            _model.InsertOne(entity);
            return entity;
        }

        public void Update(string id, T entity)
        {
            _model.ReplaceOne(entity => entity.Id == id, entity);
        }

        public void Remove(string id)
        {
            _model.DeleteOne(entity => entity.Id == id);
        }
    }
}
