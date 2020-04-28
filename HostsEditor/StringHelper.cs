using System;
using System.Drawing;

namespace HostsEditor
{
    /// <summary>
    /// Contains various utilities to manipulate strings for the program.
    /// </summary>
    class StringHelper
    {
        /// <summary>
        /// Represents a validation result when adding/editing a host entry.
        /// </summary>
        public struct ValidationResult
        {
            public Color color;
            public string output;

            /// <summary>
            /// Creates a validation result with the specified colour and output.
            /// </summary>
            /// <param name="color">Colour to style the output with</param>
            /// <param name="output">Output to show to user when adding/editing a host</param>
            public ValidationResult(Color color, string output)
            {
                this.color = color;
                this.output = output;
            }
        }

        /// <summary>
        /// Validates an input against the correct format for an IPv4/IPv6 address.
        /// </summary>
        /// <param name="input">Input to validate as an IP address</param>
        /// <returns>Whether the input is a valid IP address</returns>
        public static bool ValidateIP(string input)
        {
            return Uri.CheckHostName(input).ToString() == "IPv4"
                || Uri.CheckHostName(input).ToString() == "IPv6";
        }

        /// <summary>
        /// Validates an input against the correct format for a hostname.
        /// </summary>
        /// <param name="input">Input to validate as a hostname</param>
        /// <returns>Whether the input is a valid hostname</returns>
        public static bool ValidateHostname(string input)
        {
            return Uri.CheckHostName(input).ToString() == "Dns";
        }

        /// <summary>
        /// Generates a validation result to be used when adding/editing a host.
        /// </summary>
        /// <param name="ipValid">Whether the IP address entered is valid</param>
        /// <param name="hostValid">Whether the hostname entered is valid</param>
        /// <returns>ValidationResult to be used when showing whether a host is valid</returns>
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
