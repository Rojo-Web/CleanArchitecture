﻿
using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
namespace NorthWind.ConsoleApp.Services
{
    public class AppLogger(IUserActionWriter writer)
    {
        public void WriteLog(string message)
        {
            UserActions Log = new UserActions("System",message);
            writer.Write(Log);
        }
    }
}
