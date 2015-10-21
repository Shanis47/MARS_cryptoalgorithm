namespace MARSCore
{
    public class MarsWrapper
    {
        private readonly MarsCryptor _cryptor;

        public byte[] Key
        {
            get { return ConvertToBytes(_cryptor.Key); }
            set { _cryptor.Key = FormatData(value); }
        }

        public MarsWrapper()
        {
            _cryptor = new MarsCryptor();
        }

        public byte[] Encrypt(byte[] inputData)
        {
            var formattedData = FormatData(inputData);
            var encryptedData = _cryptor.Encrypt(formattedData);
            return ConvertToBytes(encryptedData);
        }

        public byte[] Decrypt(byte[] inputData)
        {
            var formattedData = FormatData(inputData);
            var decryptedData = _cryptor.Decrypt(formattedData);
            return ConvertToBytes(decryptedData);
        }

        private byte[] ConvertToBytes(uint[] data)
        {
            var result = new byte[data.Length * 4];
            for (int i = 0; i < data.Length; i++)
            {
                result[i*4 + 3] = (byte) (data[i] & 0xff);
                result[i*4 + 2] = (byte) ((data[i] >> 8) & 0xff);
                result[i*4 + 1] = (byte) ((data[i] >> 16) & 0xff);
                result[i*4] = (byte) ((data[i] >> 24) & 0xff);
            }

            return result;
        }

        private uint[] FormatData(byte[] inputData)
        {
            var result = new uint[inputData.Length/4 + ((inputData.Length & 3) == 0 ? 0 : 1)];
            for (int i = 0; i < result.Length; i ++)
            {
                result[i] = inputData[i*4];
                result[i] = (result[i] << 8) | inputData[i*4 + 1];
                result[i] = (result[i] << 8) | inputData[i*4 + 2];
                result[i] = (result[i] << 8) | inputData[i*4 + 3];
            }

            return result;
        }
    }
}
