using System.IO;

namespace BadPassword
{
    public static class BadPassword
    {
        /// <summary>
        /// Concatenated list of passwords as loaded from the bad passwords index project. See the <a href="https://github.com/robsheldon/bad-passwords-index">bad-passwords-index project</a> for more information about the contents of this list.
        /// </summary>
        public static string Passwords;

        /// <summary>
        /// Location of file to load passwords from.
        /// </summary>
        public static string PasswordFileName = "bad-passwords-index/bad_passwords.txt";

        /// <summary>
        /// Check a string against a compiled index of common passwords. 
        /// </summary>
        /// <param name="password">Plain-text unencrypted user entered password.</param>
        /// <returns>True if the password is in the list of commonly used bad passwords.</returns>
        public static bool IsBadPassword(this string password)
        {
            // Passwords have not been loaded, attempt to load from set location
            if (Passwords == null)
            {
                var path = Path.GetFullPath(PasswordFileName);

                // Check for file existence before loading
                if (!File.Exists(path))
                {
                    throw new FileNotFoundException("BadPassword could not find index file to load bad passwords from", path);
                }

                try
                {
                    // Not sure if this is the fastest way to do this, I guess checking for the password as we load would be faster?
                    using (var sr = File.OpenText(path))
                    {
                        Passwords = sr.ReadToEnd();
                    }
                }
                catch
                {
                    throw;
                }
            }

            // Remove the input password from the bad passwords lists and subtract its length from the original bad list
            var compareLength = Passwords.Length - Passwords.Replace(password, string.Empty).Length;

            // If the input rounds into the length it must have occured at least once
            return compareLength / password.Length > 0;
        }
    }
}
