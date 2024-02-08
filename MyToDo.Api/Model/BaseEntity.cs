using System;

namespace MyToDo.Api.Model
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime UpdateTime { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
