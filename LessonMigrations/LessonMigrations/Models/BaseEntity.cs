using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigrations.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool İsDeleted { get; set; }
    }
}
