using System;
using System.IO;
using NUnit.Framework;

namespace StarkLogger.Test
{
    [TestFixture]
    public class LoggerTest
    {
        public string LogDirPath;
        public string LogFileName = "Log.log";

        private void InitializeLogger()
        {
            LogDirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
            Directory.CreateDirectory(LogDirPath);
            Logger.Initialize(LogDirPath, LogFileName);
        }

        [Test]
        public void Info_CreatesLogFile()
        {
            InitializeLogger();
            Logger.GetInstance().Info("Info");
            Logger.GetInstance().DeInit();
            Assert.IsTrue(File.Exists(Path.Combine(LogDirPath, LogFileName)));
            File.Delete(Path.Combine(LogDirPath, LogFileName));
        }

        [Test]
        public void Error_CreatesLogFile()
        {
            var exception =
                new Exception("message",
                    new Exception("inner message",
                        new Exception("inner most message")));
            InitializeLogger();
            Logger.GetInstance().Error(exception);
            Logger.GetInstance().DeInit();
            Assert.IsTrue(File.Exists(Path.Combine(LogDirPath, LogFileName)));
            File.Delete(Path.Combine(LogDirPath, LogFileName));
        }

        [Test]
        public void Initialize_Again_NoChange()
        {
            InitializeLogger();
            InitializeLogger();
            Assert.IsNotNull(Logger.GetInstance());
        }
    }
}