using Maru.Net.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Maru.Net.Models
{
    public class Logger
    {
        public static bool writeToLogfile = false;
        public static string logfilePath = null;
        private static StreamWriter _writer = null;

        public static void Log(object CallingClass, string LogMessage, ConsoleColor Color = ConsoleColor.White)
        {
            LogMessage = $"[Maru.Net | {DateTime.Now}] <{CallingClass.GetType().ToString()}> {LogMessage}";

            Console.ForegroundColor = Color;
            Console.WriteLine(LogMessage);
            Console.ResetColor();

            if (File.Exists(logfilePath) && 
                writeToLogfile == true) {

                try {

                    _writer = new StreamWriter(logfilePath, true);
                    _writer.WriteLineAsync(LogMessage);
                    _writer.Close();
                    _writer = null;

                } catch (Exception msg) {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"[Maru.Net | {DateTime.Now.ToString()}] <WARNING> Couldn't write log to logfile. See stacktrace:\n{msg.StackTrace}");
                    Console.ResetColor();

                } finally {

                    if (_writer != null) {
                        _writer.Close();
                    }
                }
            } 
        }
    }
}
