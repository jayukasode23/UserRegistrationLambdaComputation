using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistationWithLambdaExpression
{
    public class UserLastName
    {
        string Lastname = "^[A-Z]{1}[a-z]{6}$";
        public string LastnameCheckusingLambda(string lastname) => Regex.IsMatch(lastname, Lastname) ? "LastName is Valid" : "LastName is Not Valid";

    }
}
