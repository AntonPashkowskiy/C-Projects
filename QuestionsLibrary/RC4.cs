
namespace LFSR_GEFFE_RC4
{
    class RC4
    {
        private byte[] SBox;

        public RC4(byte[] key)
        {
            SBox = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                SBox[i] = (byte)i;
            }

            int j = 0;
            for (int i = 0; i < 256; i++)
            {
                j = (j + SBox[i] + key[i % key.Length]) % 256;
                Swap(ref SBox[i],ref SBox[j]);
            } 
        }

        private void Swap(ref byte s1, ref byte s2)
        {
            byte tmp = s1;
            s1 = s2;
            s2 = tmp;
        }

        public byte[] Crypt(byte[] plaintext)
        {
            byte[] cipherText = new byte[plaintext.Length];
            int i = 0, j = 0;
            byte keyByte;

            for (int k = 0; k < plaintext.Length; k++)
            {
                i = ++i % 256;
                j = (j + SBox[i]) % 256;
                Swap(ref SBox[i], ref SBox[j]);
                keyByte = SBox[(SBox[i] + SBox[j]) % 256];
                cipherText[k] = (byte)(plaintext[k] ^ keyByte);
            }

            return cipherText;
        }
    }
}
