using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistationWithLambdaExpression
{
    public class UserValidEmail
    {
        string Email = "^[a-z]{3,5}['.'][a-z]{3,7}['@'][a-z]{3}$";

        public string ValidEmailCheckusingLambda(string email) => Regex.IsMatch(email, Email) ? "Email is Valid" : "Email is Not Valid";

    }
}
