using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistationWithLambdaExpression
{
    public class UserMobileNumber
    {
        string Mobile = "^[91]{2}[\\s][6-9]{1}[0-9]{9}$";

        public string ValidMobilenumberCheckusingLambda(string mobilenumber) => Regex.IsMatch(mobilenumber, Mobile) ? "Mobile Number  is Valid" : "Mobile Number is Not Valid";
    }
}
