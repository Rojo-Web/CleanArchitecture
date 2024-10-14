using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;


namespace NorthWind.Writers
{
    internal class FileWriter : IUserActionWriter
    {
        public void Write(UserActions action)
        {
            File.AppendAllText("AppLogs.txt",
                    string.Format("FileWriter: {0},{1},{2}", action.CreatedDateTime, action.User, action.Description)
                );
        }
    }
}
