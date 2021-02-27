using System.Diagnostics;
using System.IO;

namespace BasicWebServer
{
    public class Mymethods
    {
        public string mymethod(string s1, string s2)
        {
            return "<HTML><BODY> Hello " + s1 + " et " + s2 + "</BODY></HTML>";
        }

        public string mymethod2(string s1, string s2)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"C:\Users\Rachid\source\repos\eiin839\TD2\ExecTest\bin\Debug\ExecTest.exe"; // Specify exe name.
            start.Arguments = s1 + " " + s2;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;

            //
            // Start the process.
            //
            using (Process process = Process.Start(start))
            {
                //
                // Read in all the text from the process with the StreamReader.
                //
                using (StreamReader reader = process.StandardOutput)
                {
                    return reader.ReadToEnd();
                }
            }
        }

        public string myMethod3(string param1, string param2)
        {
            string fileName = @"C:\Users\Rachid\source\repos\eiin839\TD2\BasicWebServer\execTest.py " + param1 + " " + param2;
            string pathPy = @"C:\Users\Rachid\AppData\Local\Microsoft\WindowsApps\python3.9.exe";
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(pathPy, fileName);
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();
            return p.StandardOutput.ReadToEnd();    
        }
    }
}
