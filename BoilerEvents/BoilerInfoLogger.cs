using System.IO;

namespace BoilerEvents
{
    public class BoilerInfoLogger
    {
        readonly FileStream fs;
        readonly StreamWriter sw;

        public BoilerInfoLogger(string filename)
        {
            fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.AutoFlush = true;
        }

        public void Logger(string info)
        {
            sw.WriteLine(info);
        }

        public void Close()
        {
            sw.Close();
            fs.Close();
        }
    }
}
