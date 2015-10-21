namespace MARSCore
{
    public class MarsWrapper
    {
        private readonly MarsCryptor _cryptor;

        public uint[] Key
        {
            get { return _cryptor.Key; }
            set { _cryptor.Key = value; }
        }

        public MarsWrapper()
        {
            _cryptor = new MarsCryptor();
        }

        public byte[] Encrypt(byte[] inputData)
        {
            var formattedData = FormatData(inputData);
            var encruptedData = _cryptor.Encrypt(formattedData);
            return ConvertToBytes(encruptedData);
        }

        public byte[] Decrypt(byte[] inputData)
        {
            var formattedData = FormatData(inputData);
            var encruptedData = _cryptor.Decrypt(formattedData);
            return ConvertToBytes(encruptedData);
        }

        private byte[] ConvertToBytes(uint[] encruptedData)
        {
            var result = new byte[encruptedData.Length * 4];
            for (int i = 0; i < encruptedData.Length; i++)
            {
                result[i*4] = (byte)(encruptedData[i] & 0xff);
                result[i * 4 + 1] = (byte)((encruptedData[i] >> 8) & 0xff);
                result[i * 4 + 2] = (byte)((encruptedData[i] >> 16) & 0xff);
                result[i * 4 + 3] = (byte)((encruptedData[i] >> 24) & 0xff);
            }

            return result;
        }

        private uint[] FormatData(byte[] inputData)
        {
            var result = new uint[inputData.Length/4 + ((inputData.Length & 3) == 0 ? 0 : 1)];
            for (int i = 0; i < result.Length; i ++)
            {
                result[i] = inputData[i*4];
                result[i] = (result[i] << 8) | inputData[i + 1];
                result[i] = (result[i] << 8) | inputData[i + 2];
                result[i] = (result[i] << 8) | inputData[i + 3];
            }

            return result;
        }
    }
}
