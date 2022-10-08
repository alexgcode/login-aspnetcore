using System;
using System.Text;
using System.Security.Cryptography;

namespace aspLogin.Helpers;

public static class HelperCryptography {
    
    public static string GenerateSalt()
    {
        Random random = new Random();
        string salt = "";
        for(int i=1;i<50;i++)
        {
            int number = random.Next(0,255);
            char letra = Convert.ToChar(number);
            salt = salt + letra;
        }

        return salt;
    }

    public static byte[] EncryptPassword(string pass, string salt)
    {
        string content = pass + salt;
        var sha = SHA256.Create();
        byte[] output = Encoding.UTF8.GetBytes(content);
        for(int i=1; i<=107;i++)
        {
            output = sha.ComputeHash(output);
        }
        sha.Clear();
        return output;
    }

    public static bool compareArrays(byte[] a, byte[] b)
    {
        bool iguales = true;
        if (a.Length != b.Length)
        {
            iguales = false;
        }
        else
        {
            //comparamos byte a byte
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Equals(b[i]) == false)
                {
                    iguales = false;
                    break;
                }
            }
        }

        return iguales;
    }
}
