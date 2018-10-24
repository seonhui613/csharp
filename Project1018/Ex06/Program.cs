using System;

using System.IO;



namespace Akadia.SimpleDelegate
{
    public class MyClass
    {
        public delegate void LogHandler(string message);

        void Process(LogHandler logHandler)
        {
            //(채워 주세요...)

        }
    }

    public class FileLogger
    {
        FileStream fileStream;
        StreamWriter streamWriter;

        // Constructor

            public FileLogger(string filename)
            {
                fileStream = new FileStream(filename, FileMode.Create);
                streamWriter = new StreamWriter(fileStream);
            }

            // Member Function which is used in the Delegate

            public void Logger(string s)
            {
                streamWriter.WriteLine(s);
            }

            public void Close()
            {
                streamWriter.Close();
                fileStream.Close();
            }
    }

    public class TestApplication
    {
        static void Main(string[] args)
        {
            FileLogger fl = new FileLogger("c:\\GitHub\\process.log");

            MyClass myClass = new MyClass();

            MyClass.LogHandler myLogger =  ;//

            //(채워 주세요  )

            fl.Close();

        }

    }

}