using System;

namespace CoreTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var marsCore = new MARSCore.MarsCryptor();
            uint[] key = { 0x5094d03, 0x33c4b0e, 0x396f59a, 0x254fec6, 0x48eb689, 0x12c312f, 0x20be8e5, 0x5268f58 };
            marsCore.Key = key;

            uint[] data = { 0x48eb689, 0x12c312f, 0x20be8e5, 0x5268f58, 0x48eb689, 0x12c312f, 0x20be8e5, 0x5268f58 };
            var enc = marsCore.Encrypt(data);
            var dec = marsCore.Decript(enc);

            for(int i = 0; i < data.Length; i++)
                Console.WriteLine(data[i]+"  " + dec[i]);

            Console.ReadLine();
        }
    }
}
