using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities.Base
{
    public abstract class Entity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        private DateTime _createdAt;

        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { _createdAt = value == null ? DateTime.UtcNow : value; }
        }
        private DateTime _updateAt;
        public DateTime UpdateAt
        {
            get { return _updateAt; }
            set { _updateAt = value; }
        }
        public bool Ativo { get; set; }

    }
}
