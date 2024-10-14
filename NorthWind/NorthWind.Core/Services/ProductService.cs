using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;


namespace NorthWind.ConsoleApp.Services
{
    internal class ProductService(IUserActionWriter writer) : IProductService
    {
        public void Add(string user, string prodcutName)
        {
            UserActions Action = new UserActions(user, $"Created: {prodcutName}");
            writer.Write(Action);
        }
    }
}