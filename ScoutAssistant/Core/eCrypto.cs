using System.Security.Cryptography;
using System.Text;

namespace ScoutAssistant.Extensions
{
    /// <summary>
    /// Exposes a collection of JSON extensions.
    /// </summary>
    public static class eCrypto
    {
        /// <summary>
        /// Creates a SHA256 hash based on the string.
        /// </summary>
        /// <param name="str">The string to be hashed.</param>
        /// <returns>
        /// Returns the string hashed as SHA256; otherwise returns original value.
        /// </returns>
        public static string ToSHA256(this string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                SHA256Managed sha = new SHA256Managed();
                StringBuilder h = new StringBuilder();

                foreach (byte b in sha.ComputeHash(Encoding.UTF8.GetBytes(string.Format("Atlanta{0}Falcons", str))))
                    h.Append(b.ToString("x2"));

                return h.ToString();
            }
            else
            {
                return str;
            }
        }
    }
}