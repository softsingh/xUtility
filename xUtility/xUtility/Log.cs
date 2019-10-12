using System;
using System.IO;

namespace xUtility
{
    class Log
    {
        public static string LOG_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\xUtility\log\";
        
        public static bool CreateEntry(string LogText = "", string Key = "", int RepeatTextCount = 1, bool TimeStamp = true)
        {
            try
            {
                if (!Directory.Exists(LOG_FOLDER))
                {
                    Directory.CreateDirectory(LOG_FOLDER);
                }

                using (StreamWriter sw = File.AppendText(LOG_FOLDER + @"log.txt"))
                {
                    if (LogText == "")
                    {
                        sw.WriteLine();
                    }
                    else if (RepeatTextCount > 1)
                    {
                        string MyText = string.Empty;

                        for(int i = 0; i < RepeatTextCount; i++)
                        {
                            MyText = MyText + LogText;
                        }

                        sw.WriteLine(MyText);
                    }
                    else
                    {
                        if (TimeStamp == true)
                        {
                            if (Key == "")
                                sw.WriteLine("{0} : {1}", DateTime.Now, LogText);
                            else
                                sw.WriteLine("{0} [{1}] : {2}", DateTime.Now, Key, LogText);
                        }
                        else
                        {
                            if (Key == "")
                                sw.WriteLine(LogText);
                            else
                                sw.WriteLine("[{0}] : {1}", Key, LogText);
                        }
                    }
                }

                return true;
            }
            catch(Exception Ex)
            {
                return false;
            }
        }
    }
}
