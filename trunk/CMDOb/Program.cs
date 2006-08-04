using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Obfuscation;

namespace CMDOb
{
    /// <summary>
    /// UI implimentation for the Obfuscation class. Through this class we will recieve and handle events
    /// </summary>
    class ObfuscatorUI : Obfuscation.IObfuscatorUI
    {
        #region IObfuscatorUI Members

        public void StatusUpdate(string status)
        {
            Console.WriteLine(status);
        }

        public void Done()
        {
            Console.WriteLine("Done.");
        }

        public void Error(string errorText)
        {
            Console.WriteLine("Error: " + errorText);
        }
        #endregion
    }


    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1 || args[0] == "/?")
            {
                OutputUsage();
                return;
            }

            if (!File.Exists(args[0]))
            {
                Console.WriteLine("Can not find the specified PHP Obfustator Project File: " + args[0]);
                return;
            }

            ObfuscationConfig config = null;
            try
            {
                config = ObfuscationConfig.Open(args[0]);
            }
            catch(Exception)
            {
                Console.WriteLine("Could not open the specified PHP Obfuscator Project File: " + args[0]);
                return;
            }

            if(null == config)
            {
                Console.WriteLine("Could not open the specified PHP Obfuscator Project File: " + args[0]);
                return;
            }

            try
            {
                ObfuscatorUI ui = new ObfuscatorUI();
                Obfuscator obfuscator = new Obfuscator(ui);
                obfuscator.OutputPatterns();
                obfuscator.Start(config, false);
            }
            catch (Exception exp)
            {
                Console.WriteLine("There was an error obfuscating your project: " + exp.Message);
                return;
            }

        }

        static void OutputUsage()
        {
            Console.WriteLine("Obfuscates PHP source code based on a PHP Obfuscator project file\n");
            Console.WriteLine("CMDOB ProjectFile\n");
            Console.WriteLine("  ProjectFile\tPHP Obfuscator File created by the PHP Obfuscator Application");
        }


    }
}
