using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostsEditor
{
    class StringHelper
    {
        public struct ValidationResult
        {
            public Color color;
            public string output;

            public ValidationResult(Color color, string output)
            {
                this.color = color;
                this.output = output;
            }
        }

        public static bool ValidateIPv4(string input)
        {
            return Uri.CheckHostName(input).ToString() == "IPv4";
        }

        public static bool ValidateHostname(string input)
        {
            return Uri.CheckHostName(input).ToString() == "Dns";
        }

        public static ValidationResult GenerateValidationResult(bool ipValid, bool hostValid)
        {
            if (ipValid)
            {
                if (hostValid)
                    return new ValidationResult(Color.Green, "Input valid");
                else
                    return new ValidationResult(Color.Red, "Invalid host");
            }
            else
                return new ValidationResult(Color.Red, "Invalid IP");
        }
    }
}
