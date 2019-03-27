using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    // Funkcija za generiranje sluchajna lozinka 
    // PasswordStrenght e tip enumeracija (easy, normal , hard) static string generatePassword ( PasswordStrenght passwordStrenght ) { 
    // easy lozinkata treba da ima do 6 znaci (samo mali bukvi) 
    // normal lozinkata treba da ima od 6 do 10 znaci (da sodrzhi golemi bukvi i 
    // brojki 
    // hard loznikata treba da ima povekje od 10 znaci i da sodrzhi mali, golemi 
    // bukvi i specijalni znaci }
    class Program
    {
        enum PasswordStrength : int
        {
            easy = 1,
            normal = 2,
            hard = 3
        }

        static String generatePassword(PasswordStrength password)
        {
            StringBuilder newPassword = new StringBuilder();
            Random random = new Random();
            String allChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789~`!@#$%^&*()_-+=";
            //0-26 small
            //27-53 caps
            //54-63 numbers
            //63-79 special chars
            if (password.Equals(PasswordStrength.easy)) // generate Easy, 6 mali bukvi
            {
                int length = random.Next(1, 6); // LENGTH OF PASSWORD
                for(int i = 0; i<length; i++)
                {
                    int num = random.Next(0, 26);
                    newPassword.Append(allChars.ElementAt(num));
                }
            }
            else if (password.Equals(PasswordStrength.normal)) // generate Normal, 6-10 golemi bukvi i broevi
            {
                int length = random.Next(6, 10); // LENGTH OF PASSWORD
                for (int i = 0; i < length; i++)
                {
                    int num = random.Next(27, 63);
                    newPassword.Append(allChars.ElementAt(num));
                }
            }
            else if (password.Equals(PasswordStrength.hard)) // generate Hard, 10+ bukvi, broevi, specijalni znaci
            {
                int length = random.Next(10,20); // LENGTH OF PASSWORD MY MAX=20 chars
                for (int i = 0; i < length; i++)
                {
                    int num = random.Next(0, 79);
                    newPassword.Append(allChars.ElementAt(num));
                }
            }
            return newPassword.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input your passwords! \n Ex: pass1 pass2 pass3");
            String passLine = Console.ReadLine();
            char[] delimiter = { ' ' };
            String[] parts = passLine.Split(delimiter);

            String easyPassword = generatePassword(PasswordStrength.easy);
            String normalPassword = generatePassword(PasswordStrength.normal);
            String hardPassword = generatePassword(PasswordStrength.hard);

            for (int i = 0; i < 3; i++)
            {
                String tempPassword;
                if (i == 0)
                    tempPassword = easyPassword;
                else if (i == 1)
                    tempPassword = normalPassword;
                else
                    tempPassword = hardPassword;

                foreach (String pass in parts)
                {
                    if (pass.Equals(tempPassword))
                    {
                        Console.WriteLine("Congratulations, you nailed the password!! *confetti drops*");
                        Console.WriteLine("Your password: " + pass);
                        Console.WriteLine("Our password: " + tempPassword);
                        Environment.Exit(1);
                    }
                }
            }
            Console.WriteLine("Sorry, you didn't guess our passwords! *sad noise*");
            Console.WriteLine("-Our passwords-\nEasy password: " + easyPassword);
            Console.WriteLine("Normal password: " + normalPassword);
            Console.WriteLine("Hard password: " + hardPassword);
            Console.ReadKey();
        }
    }
}
