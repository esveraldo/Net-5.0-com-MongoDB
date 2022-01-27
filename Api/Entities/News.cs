using Api.Entities.Base;
using Api.Entities.Enums;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities
{
    public class News : Entity
    {
        public News(string hat, string title, string text, string author, string img, string link, Status status)
        {
            Hat = hat;
            Title = title;
            Text = text;
            Author = author;
            Img = img;
            Link = link;
            PublishDate = DateTime.Now;
            Status = status;
        }

        public Status ChangesStatus(Status status)
        {
            switch (status)
            {
                case Status.Active:
                    status = Status.Active;
                    break;
                case Status.Inactive:
                    status = Status.Inactive;
                    break;
                case Status.Draft:
                    status = Status.Draft;
                    break;
            }
            return status;
        }

        [BsonElement("hat")]
        public string Hat { get; private set; }

        [BsonElement("title")]
        public string Title { get; private set; }

        [BsonElement("text")]
        public string Text { get; private set; }

        [BsonElement("author")]
        public string Author { get; private set; }

        [BsonElement("img")]
        public string Img { get; private set; }

        [BsonElement("link")]
        public string Link { get; private set; }

        [BsonElement("publishDate")]
        public DateTime PublishDate { get; private set; }

        [BsonElement("active")]
        public Status Status { get; private set; }
    }
}
