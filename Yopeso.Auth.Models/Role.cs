namespace Yopeso.Auth.Models
{
    public class Role: BaseModel
    {
        public ulong Id { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }
    }
}