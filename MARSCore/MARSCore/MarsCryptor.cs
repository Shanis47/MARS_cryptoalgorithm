using System;

namespace MARSCore
{
    public class MarsCryptor
    {
        private const int BlockSize = 4;

        private readonly UInt32[] _key = new uint[14];

        public UInt32[] Key
        {
            get { return _key; }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                if (value.Length > 14 || value.Length < 4)
                    throw new ArgumentException("Key must have length from 4 to 14 32bit word");

                Array.Copy(value, _key, value.Length);
            }
        }

        public uint[] Encrypt(uint[] data)
        {
            var result = new uint[(data.Length / BlockSize + 1) * BlockSize];
            var block = new uint[BlockSize];
            for (int i = 0; i < data.Length; i += BlockSize)
            {
                Array.Copy(data, i, block, 0, i+BlockSize < data.Length? BlockSize: data.Length-i-1);
                block = EncryptBlock(block);
                Array.Copy(block, 0, result, i, BlockSize);
                Array.Clear(block, 0, BlockSize);
            }

            return result;
        }

        private uint[] EncryptBlock(uint[] block)
        {
            throw new NotImplementedException();
        }

        public uint[] Decript(uint[] data)
        {
            var result = new uint[(data.Length / BlockSize + 1) * BlockSize];
            var block = new uint[BlockSize];
            for (int i = 0; i < data.Length; i += BlockSize)
            {
                Array.Copy(data, i, block, 0, i + BlockSize < data.Length ? BlockSize : data.Length - i - 1);
                block = DecryptBlock(block);
                Array.Copy(block, 0, result, i, BlockSize);
                Array.Clear(block, 0, BlockSize);
            }

            return result;
        }

        private uint[] DecryptBlock(uint[] block)
        {
            throw new NotImplementedException();
        }
    }
}
