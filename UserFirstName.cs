using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistationWithLambdaExpression
{
    public class UserFirstName
    {
        string Firstname = "^[A-Z]{1}[a-z]{3,8}$";

        public string FirstnameCheckusingLambda(string firstname) => Regex.IsMatch(firstname, Firstname) ? "FirstName is Valid" : "FirstName is Not Valid";

    }
}
