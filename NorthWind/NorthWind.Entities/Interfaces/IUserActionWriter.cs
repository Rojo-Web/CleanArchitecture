﻿

using NorthWind.Entities.ValueObjects;

namespace NorthWind.Entities.Interfaces
{
    public interface IUserActionWriter
    {
        void Write(UserActions action);
    }
}
