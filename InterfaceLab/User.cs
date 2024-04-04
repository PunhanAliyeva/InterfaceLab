using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLab
{
    internal class User : IAccount
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string fullname, string email, string password)
        {
            Fullname = fullname;
            Email = email;
            Password = password;
        }
        public bool PasswordChecker(string password)
        {
            char[] arr = password.ToCharArray();               ///1 d 3 7 s r T
            if (password.Length >= 8)
            {
                int lowCount = 0;
                int upCount = 0;
                int digCount = 0;

                foreach (char c in arr)
                {
                    if (char.IsUpper(c))
                    {
                        upCount++;
                    }
                    if(char.IsLower(c))
                    {
                        lowCount++;
                    }
                    if (char.IsDigit(c))
                    {
                        digCount++;
                    }
                   
                }
                if (upCount > 0)
                {
                    if (digCount > 0)
                    {
                        if (lowCount > 0)
                        {
                            return true;
                        }
                    }
                }
                
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Fullname:{Fullname} Email:{Email}");
        }
    }
}
