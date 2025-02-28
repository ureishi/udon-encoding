using UdonSharp;
using Koyashiro.UdonTest;

namespace Koyashiro
{
    namespace UdonEncoding.Test
    {
        public class UdonUTF32Test : UdonSharpBehaviour
        {
            public void Start()
            {
                Assert.Equal(new byte[] { 0x61, 0x00, 0x00, 0x00, 0x62, 0x00, 0x00, 0x00, 0x63, 0x00, 0x00, 0x00 }, UdonUTF32.GetBytes("abc"));
                Assert.Equal(new byte[] { 0x14, 0xf9, 0x01, 0x00, 0x5b, 0xf3, 0x01, 0x00, 0x63, 0xf3, 0x01, 0x00 }, UdonUTF32.GetBytes("🤔🍛🍣"));

                Assert.Equal("abc", UdonUTF32.GetString(new byte[] { 0x61, 0x00, 0x00, 0x00, 0x62, 0x00, 0x00, 0x00, 0x63, 0x00, 0x00, 0x00 }));
                Assert.Equal("🤔🍛🍣", UdonUTF32.GetString(new byte[] { 0x14, 0xf9, 0x01, 0x00, 0x5b, 0xf3, 0x01, 0x00, 0x63, 0xf3, 0x01, 0x00 }));
            }
        }
    }
}
