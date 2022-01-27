using Api.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Entities.ViewModels
{
    public class NewsViewModel
    {
        public string Id { get; set; }
        public string Hat { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public string Img { get; set; }
        public string Link { get; set; }
        public Status Status { get; set; }

    }
}
