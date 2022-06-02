using System;
using System.Collections.Generic;
using System.Text;

namespace homework2
{
    internal class User
    {

        private string _username;
        private string _password;



        public string UserName
        {
            get
            {
                return _username;
            }
            set
            {
                if (string.IsNullOrEmpty(value) && value.Length > 5 && value.Length < 26)
                    _username = value;
            }
        }
        public string Password
        {
            get
            {
                return _password;

            }
            set
            {

                if (string.IsNullOrWhiteSpace(value) && value.Length > 7 && value.Length < 26)
                {
                    bool check = false;

                    for (int i = 0; i < value.Length; i++)
                    {
                        if (Char.IsUpper(value[i]))

                            break;

                        if (Char.IsLower(value[i]))

                            break;

                        if (Char.IsDigit(value[i]))
                            break;
                        check = true;
                    }


                    _password = value;
                }
            }
        }
       
        public bool HasDigit(string str)
        {
            for (int i=0;i<str.Length;i++)
            {
                if (Char.IsDigit(str[i]))
                    return true;
            }
            return false;
        }
        public bool HasUpper(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                    return true;
            }
            return false;
        }
        public bool HasLower(string str)
        {
            for (int i=0;i<str.Length;i++)
            {
                if (Char.IsUpper(str[i]))
                    return true;
            }
            return false;
        }
    }
}
      