using System;

namespace StarkLogger
{
    public interface ILogger
    {
        void Info(string message);
        void Error(Exception ex);
        void DeInit();
    }
}