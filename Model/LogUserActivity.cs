using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace mschreiber_Software2_c969Project.Model
{
    internal class LogUserActivity
    {

        public static void ActivateLog(string userName)
        {
            // Get the current date and time
            DateTime currentTime = DateTime.Now;
            bool LoginError = false;

            // Construct the log message

            string logMessage = $"The User {userName} logged in at {currentTime}";
            string selectQuery = $"SELECT COUNT(*) FROM users WHERE username = '{userName}'";

            //TODO fix this error checking for if the username exists or not
            
            if (selectQuery != userName)
            {
                string ErrorLogMessage = $"Failed Attempt using login {userName}.\nAt {currentTime}";
                LoginError = true;
            }

            // Define the file path for the log file
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string logFileName = "user_activity_log.txt";
            string logFilePath = Path.Combine(desktopPath, logFileName);

            // Check if the log file exists
            bool logFileExists = File.Exists(logFilePath);

            // If the log file exists, append the new log message to the end of the file
            if (logFileExists)
            {
                File.AppendAllText(logFilePath, logMessage + Environment.NewLine);   
            }
            // otherwise...
            else
            {
                File.WriteAllText(logFilePath, logMessage + Environment.NewLine);
            }

            //if (logFileExists && LoginError == true ) 
            //{ File.AppendAllText(logFilePath, ErrorlogMessage + Environment.NewLine); }
        }
    }
}
