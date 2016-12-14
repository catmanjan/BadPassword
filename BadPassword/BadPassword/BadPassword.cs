using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadPassword
{
    public static class BadPassword
    {
        /// <summary>
        /// Check a string against a compiled index of common passwords. 
        /// </summary>
        /// <param name="password">Plain-text unencrypted user entered password.</param>
        /// <returns>True if</returns>
        public static bool IsBadPassword(this string password)
        {
            return false;
        }
    }
}
