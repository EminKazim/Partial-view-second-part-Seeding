using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigrations.Models
{
    public class AboutDetail:BaseEntity
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
    }
}
