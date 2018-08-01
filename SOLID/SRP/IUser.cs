using System;
using System.Collections.Generic;
using System.Text;

// Single Responsibility Principal: Do one thing and do it well.

namespace Demo.SOLID.SRP
{
    interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
    }

    interface ILogger
    {
        void LogError(string error);
    }

    interface IEmail 
    { 
        bool SendEmail(string emailContent);
    }
}
