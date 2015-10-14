using System.IO;

namespace MARSCore
{
    class Logger
    {
        private StreamWriter _logFile = null;
        public void OpenLog(string name)
        {
            _logFile = new StreamWriter(name, false);
        }

        public void Log(string data)
        {
            _logFile.WriteLine(data);
        }

        public void CloseLog()
        {
            _logFile.Close();
        }
    }
}
