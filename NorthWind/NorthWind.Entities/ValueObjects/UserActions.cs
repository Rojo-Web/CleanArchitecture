

namespace NorthWind.Entities.ValueObjects
{
    public class UserActions(string user, string description)
    { 
        public DateTime CreatedDateTime { get; } = DateTime.Now;
        public string User => user;
        public string Description => description;

    }
}
