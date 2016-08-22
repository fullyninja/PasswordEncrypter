using PasswordEncrypter.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordEncrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "";

            if (args.Count() == 1)
            {
                password = args[0];
            }
            else
            { 
                Console.WriteLine("PasswordEncrypter.exe <password>");
            }

            var secPassword = StringEncrypter.ToSecureString(password);
            string encryptedPassword = StringEncrypter.EncryptString(secPassword);

            Console.Write(encryptedPassword);
        }
    }
}
