using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
namespace NorthWind.ConsoleApp.Services
{
    public class AppLogger(IEnumerable<IUserActionWriter> writers) : IAppLogger
    {
        public void WriteLog(string message)
        {
            UserActions Log = new UserActions("System", message);
            foreach (var Writer in writers)
                Writer.Write(Log);
        }
    }
}
