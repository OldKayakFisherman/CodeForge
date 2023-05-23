using System.Security.Cryptography;

namespace CommonLib;

public static class RandomUtility
{
    /// <summary>
    /// Generates a random nonce for general use
    /// </summary>
    /// <param name="nonceLength">Length of nonce required</param>
    /// <returns></returns>
    public static string GenerateRandomNonce()
    {
        string retval = string.Empty;
        List<string> forbiddenCharacters = new List<string>(){"#", "$", "=", "@", "/", "+"};
        
        //Allocate a buffer
        var byteArray = new byte[10];
        if (byteArray == null) throw new ArgumentNullException(nameof(byteArray));
        //Generate a cryptographically random set of bytes
        using (var rnd = RandomNumberGenerator.Create())
        {
            rnd.GetBytes(byteArray);
        }

        //Base64 encode and then return
        retval = Convert.ToBase64String(byteArray);

        //Strip unfriendly characters out
        foreach (var ch in forbiddenCharacters)
        {
            if (retval.IndexOf(ch, StringComparison.Ordinal) >= 0)
            {
                retval = retval.Replace(ch, string.Empty);
            }
        }

        return retval;
    }
}