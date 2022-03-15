using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigrations.Models
{
    public class Carousel:BaseEntity
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public string  Text { get; set; }
        public string Position { get; set; }
    }
}
