using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigrations.Models
{
    public class GiftHead:BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
