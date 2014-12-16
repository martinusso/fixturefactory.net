using System;
using System.Linq;

namespace FixtureFactory
{
    public class GeneratorValues
    {
        public object GetValue(Type type)
        {
            if (type == typeof(string))
                return GetString();
            if (type == typeof(bool))
                return GetBoolean();
            if (type == typeof(System.DateTime))
                return GetDateTime();

            // Integral Types
            if (type == typeof(sbyte))
                return GetSByte();
            if (type == typeof(byte))
                return GetByte();
            if (type == typeof(char))
                return GetChar();
            if (type == typeof(short))
                return GetShort();
            if (type == typeof(ushort))
                return GetUShort();
            if (type == typeof(int))
                return GetInt();
            if (type == typeof(uint))
                return GetUInt();
            if (type == typeof(long))
                return GetLong();
            if (type == typeof(ulong))
                return GetULong();

            // Floating-Point Types
            if (type == typeof(float))
                return GetFloat();
            if (type == typeof(double))
                return GetDouble();
            if (type == typeof(decimal))
                return GetDecimal();

            return null;
        }

        /// <summary>
        /// Type: string
        /// </summary>
        /// <returns>returns a random string</returns>
        private string GetString()
        {
            var allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(
                Enumerable.Repeat(allowedChars, 32)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
        }

        /// <summary>
        /// Type: bool
        /// .NET Framework type: System.Boolean
        /// </summary>
        /// <returns>returns a random bool</returns>
        private bool GetBoolean()
        {
            var random = new Random();
            return random.Next(0, 1) == 0;
        }

        /// <summary>
        /// Type: System.DateTime
        /// </summary>
        /// <returns>returns a new DateTime</returns>
        private DateTime GetDateTime()
        {
            return new DateTime();
        }

        /// <summary>
        /// sbyte -128 to 127 Signed 8-bit integer
        /// </summary>
        /// <returns>returns a random sbyte</returns>
        private sbyte GetSByte()
        {
            var random = new Random();
            return (sbyte)random.Next(-128, 127);
        }

        /// <summary>
        /// byte 0 to 255 Unsigned 8-bit integer
        /// </summary>
        /// <returns>returns a random byte</returns>
        private byte GetByte()
        {
            var random = new Random();
            return (byte)random.Next(0, 255);
        }

        /// <summary>
        /// Type: char
        /// Allowed chars: abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789
        /// Size: Unicode 16-bit character
        /// </summary>
        /// <returns>returns a random char</returns>
        private char GetChar()
        {
            var allowedChars = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            int i = random.Next(0, allowedChars.Length - 1);
            return allowedChars[i];
        }

        /// <summary>
        /// short
        /// Range: -32,768 to 32,767
        /// Size: Signed 16-bit integer
        /// </summary>
        /// <returns>returns a random short</returns>
        private short GetShort()
        {
            var random = new Random();
            return (short)random.Next(-32768, 32767);
        }

        /// <summary>
        /// ushort
        /// Range: 0 to 65,535
        /// Size: Unsigned 16-bit integer
        /// </summary>
        /// <returns>returns a random ushort</returns>
        private ushort GetUShort()
        {
            var random = new Random();
            return (ushort)random.Next(0, 65535);
        }

        /// <summary>
        /// int
        /// Range: -2,147,483,648 to 2,147,483,647
        /// Size: Signed 32-bit integer
        /// </summary>
        /// <returns>returns a random int</returns>
        private int GetInt()
        {
            var random = new Random();
            return random.Next(-2147483648, 2147483647);
        }

        /// <summary>
        /// uint
        /// Range: 0 to 4,294,967,295
        /// Size: Unsigned 32-bit integer
        /// </summary>
        /// <returns>returns a random uint</returns>
        private uint GetUInt()
        {
            var random = new Random();
            uint thirtyBits = (uint)random.Next(1 << 30);
            uint twoBits = (uint)random.Next(1 << 2);
            return (thirtyBits << 2) | twoBits;
        }

        /// <summary>
        /// long
        /// Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        /// Size: Signed 64-bit integer
        /// </summary>
        /// <returns>returns a random long</returns>
        private long GetLong()
        {
            return (long)GetInt();
        }

        /// <summary>
        /// ulong
        /// Range: 0 to 18,446,744,073,709,551,615
        /// Size: Unsigned 64-bit integer
        /// </summary>
        /// <returns>returns a random ulong</returns>
        private ulong GetULong()
        {
            return (ulong)GetUInt();
        }

        /// <summary>
        /// float
        /// Range: ±1.5e−45 to ±3.4e38
        /// Size: 7 digits
        /// </summary>
        /// <returns>returns a random float</returns>
        private float GetFloat()
        {
            var random = new Random();
            return (float)random.NextDouble();
        }

        /// <summary>
        /// Type: double
        /// Range: ±5.0e−324 to ±1.7e308
        /// Size: 15-16 digits
        /// </summary>
        /// <returns>returns a random double</returns>
        private double GetDouble()
        {
            var random = new Random();
            return random.NextDouble();
        }

        /// <summary>
        /// Type: decimal
        /// Precision: 28-29 significant digits
        /// .NET Framework type: System.Decimal
        /// </summary>
        /// <returns>returns a random decimal</returns>
        private decimal GetDecimal()
        {
            var random = new Random();
            return (decimal)random.NextDouble();
        }
    }
}
