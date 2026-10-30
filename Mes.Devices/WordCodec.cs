using System;
using System.Text;

namespace Mes.Devices
{
    /// <summary>
    /// 字（16 位寄存器）与字节 / 浮点 / ASCII 之间的换算，整个上位机只这一份。
    ///
    /// 只此一份是重点：换算一旦在 PlcBase 上放一套、外面再抄一套静态的，
    /// 改字节顺序时就只改得动一处，于是"读回来的条码是对的、写进去的是反的"
    /// 这种只在现场才暴露的问题就有了藏身地方。
    ///
    /// 一条必须记住的规则：一个浮点占两个字，所以参数下标 = (地址 − 块首地址) / 2。
    /// 少除这个 2，读到的是隔壁参数的半个字。
    /// </summary>
    public static class WordCodec
    {
        /// <summary>
        /// 字数组转字节：低字节在前。这与 BitConverter.GetBytes(short) 在小端机器上的结果一致，
        /// 所以原 PlcBase 里"高低位反转"的 FromShort 和 ConvertShortArrayToByteArray 其实是同一件事，
        /// 这里合并成一个方法。
        /// </summary>
        public static byte[] WordsToBytes(short[] words)
        {
            var bytes = new byte[words.Length * 2];
            for (var i = 0; i < words.Length; i++)
            {
                bytes[i * 2] = (byte)(words[i] & 0xFF);
                bytes[i * 2 + 1] = (byte)((words[i] >> 8) & 0xFF);
            }
            return bytes;
        }

        public static short[] BytesToWords(byte[] bytes)
        {
            if (bytes.Length % 2 != 0)
            {
                throw new ArgumentException("字节数组长度必须是偶数。", "bytes");
            }
            var words = new short[bytes.Length / 2];
            for (var i = 0; i < words.Length; i++)
            {
                words[i] = BitConverter.ToInt16(bytes, i * 2);
            }
            return words;
        }

        /// <summary>浮点拆成两个字，写入 PLC 用。</summary>
        public static short[] FloatToWords(double value)
        {
            var floatBytes = BitConverter.GetBytes((float)value);
            return new[] { BitConverter.ToInt16(floatBytes, 0), BitConverter.ToInt16(floatBytes, 2) };
        }

        /// <summary>两个字合成一个浮点，长度不是 2 直接抛：静默返回 0 会把测量值骗成合格。</summary>
        public static float WordsToFloat(short[] words)
        {
            if (words == null || words.Length != 2)
            {
                throw new ArgumentException("一个浮点固定占 2 个字，传进来的字数是 "
                    + (words == null ? 0 : words.Length) + "。", "words");
            }
            var bytes = WordsToBytes(words);
            return BitConverter.ToSingle(bytes, 0);
        }

        /// <summary>
        /// 连续字 → 浮点数组。返回个数是字数的一半，所以调用方传进来的 length 是**字数**：
        /// ReadFloatArray("MW50000", 2230) 拿回来是 1115 个浮点。
        /// </summary>
        public static double[] WordsToFloats(short[] words)
        {
            if (words.Length % 2 != 0)
            {
                throw new ArgumentException("浮点必须整字成对，传进来的字数是奇数：" + words.Length, "words");
            }
            var values = new double[words.Length / 2];
            for (var i = 0; i < values.Length; i++)
            {
                values[i] = WordsToFloat(new[] { words[i * 2], words[i * 2 + 1] });
            }
            return values;
        }

        /// <summary>条码区读回来的一段字 → 字符串（每个字低字节在前，每字一个 ASCII 字符）。</summary>
        public static string WordsToAscii(short[] words)
        {
            var text = new char[words.Length * 2];
            var count = 0;
            for (var i = 0; i < words.Length; i++)
            {
                text[count++] = (char)(words[i] & 0xFF);
                text[count++] = (char)((words[i] >> 8) & 0xFF);
            }
            return new string(text, 0, count).TrimEnd('\0', ' ');
        }

        /// <summary>WordsToAscii 的反向，往条码区塞码用，wordCount 不够补 0。</summary>
        public static short[] AsciiToWords(string text, int wordCount)
        {
            text = text ?? string.Empty;
            var words = new short[wordCount];
            for (var i = 0; i < wordCount; i++)
            {
                int lo = i * 2 < text.Length ? text[i * 2] : 0;
                int hi = i * 2 + 1 < text.Length ? text[i * 2 + 1] : 0;
                words[i] = (short)((lo & 0xFF) | ((hi & 0xFF) << 8));
            }
            return words;
        }

        /// <summary>
        /// 把 "MB62050" / "MX62050" / "MX1000.0" 这种位地址拆成所在的字地址和字内的字节序号。
        /// 汇川的位区是从 MW 字里拆出来的：字地址 = 位地址 / 2，字内下标 = 位地址 % 2。
        ///
        /// 读和写必须走同一个解析：一边吃掉 ".0" 一边不吃，
        /// 就会出现同一个地址读得出、写不进去（FormatException）。
        /// </summary>
        public static bool TrySplitBitByte(string address, out int wordAddress, out int byteIndex)
        {
            wordAddress = 0;
            byteIndex = 0;
            if (string.IsNullOrEmpty(address)) return false;

            var digits = new StringBuilder();
            foreach (var ch in address)
            {
                if (ch >= '0' && ch <= '9') digits.Append(ch);
                else if (ch == '.') break;
            }
            if (digits.Length == 0) return false;

            int bitAddress;
            if (!int.TryParse(digits.ToString(), out bitAddress)) return false;
            var upper = address.ToUpperInvariant();
            if (upper.Contains("MB") || upper.Contains("MX"))
            {
                wordAddress = bitAddress / 2;
                byteIndex = bitAddress % 2;
                return true;
            }
            return false;
        }
    }
}
