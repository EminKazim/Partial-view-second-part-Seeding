using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigrations.Models
{
    public class Blog:BaseEntity
    {
        public string Image { get; set; }
        public string Date { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
