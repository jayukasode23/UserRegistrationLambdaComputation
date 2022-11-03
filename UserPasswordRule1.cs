using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistationWithLambdaExpression
{
    public class UserPasswordRule1
    {
        string UserPass1 = "^[A-Z]{1}[A-z a-z]{7,15}$";

        public string ValidPasswordCheckusingLambda(string password) => Regex.IsMatch(password, UserPass1) ? "Password is Valid" : "Password is Not Valid";

    }
}

