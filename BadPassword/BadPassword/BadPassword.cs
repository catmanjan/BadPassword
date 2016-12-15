using System.IO;

namespace BadPassword
{
    public static class BadPassword
    {
        /// <summary>
        /// Concatenated list of passwords as loaded from the bad passwords index project. See the <a href="https://github.com/robsheldon/bad-passwords-index">bad-passwords-index project</a> for more information about the contents of this list.
        /// </summary>
        public static string Passwords = Properties.Resources.Passwords;

        /// <summary>
        /// Check a string against a compiled index of common passwords. 
        /// </summary>
        /// <param name="password">Plain-text unencrypted user entered password.</param>
        /// <returns>True if the password is in the list of commonly used bad passwords.</returns>
        public static bool IsBadPassword(this string password)
        {
            // Remove the input password from the bad passwords lists and subtract its length from the original bad list
            var compareLength = Passwords.Length - Passwords.Replace(password, string.Empty).Length;

            // If the input rounds into the length it must have occured at least once
            return compareLength / password.Length > 0;
        }
    }
}
