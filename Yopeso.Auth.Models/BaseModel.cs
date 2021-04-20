using System;

namespace Yopeso.Auth.Models
{
    public abstract class BaseModel
    {
        protected BaseModel()
        {
            CreatedAt = new DateTime();
            LastEdit = CreatedAt;
        }

        public DateTime CreatedAt { get; }
        public DateTime LastEdit { get; set; }
    }
}