﻿using System;
using System.Collections.Generic;
using System.Text;
using PROFINET_STEP_7;
using PROFINET_STEP_7.Profinet;

namespace PROFINET_STEP_7.Types
{
    public static class Double
    {
        // publics
        #region FromByteArray
        public static double FromByteArray(byte[] bytes)
        {
            byte v1 = bytes[0];
            byte v2 = bytes[1];
            byte v3 = bytes[2];
            byte v4 = bytes[3];

            if ((int)v1 + v2 + v3 + v4 == 0)
            {
                return 0.0;
            }
            else
            {
                // nun String bilden
                string txt = ValToBinString(v1) + ValToBinString(v2) + ValToBinString(v3) + ValToBinString(v4);
                // erstmal das Vorzeichen
                int vz = int.Parse(txt.Substring(0, 1));
                int exd = Conversion.BinStringToInt(txt.Substring(1, 8));
                string ma = txt.Substring(9, 23);
                double mantisse = 1;
                double faktor = 1.0;

                //das ist die Anzahl der restlichen bit's
                for (int cnt = 0; cnt <= 22; cnt++)
                {
                    faktor = faktor / 2.0;
                    //entspricht 2^-y
                    if (ma.Substring(cnt, 1) == "1")
                    {
                        mantisse = mantisse + faktor;
                    }
                }
                return Math.Pow((-1), vz) * Math.Pow(2, (exd - 127)) * mantisse;
            }
        }
        #endregion
        #region FromDWord
        public static double FromDWord(Int32 value)
        {
            byte[] b = PROFINET_STEP_7.Types.DInt.ToByteArray(value);
            double d = FromByteArray(b);
            return d;
        }

        public static double FromDWord(UInt32 value)
        {
            byte[] b = PROFINET_STEP_7.Types.DWord.ToByteArray(value);
            double d = FromByteArray(b);
            return d;
        }
        #endregion

        #region ToByteArray
        public static byte[] ToByteArray(double value)
        {
            double wert = (double)value;
            string binString = "";
            byte[] bytes = new byte[4];
            if (wert != 0f)
            {
                if (wert < 0)
                {
                    wert *= -1;
                    binString = "1";
                }
                else
                {
                    binString = "0";
                }
                int exponent = (int)Math.Floor((double)Math.Log(wert) / Math.Log(2.0));
                wert = wert / (Math.Pow(2, exponent)) - 1;

                binString += ValToBinString((byte)(exponent + 127));
                for (int cnt = 1; cnt <= 23; cnt++)
                {
                    if (!(wert - System.Math.Pow(2, -cnt) < 0))
                    {
                        wert = wert - System.Math.Pow(2, -cnt);
                        binString += "1";
                    }
                    else
                        binString += "0";
                }
                bytes[0] = (byte)BinStringToByte(binString.Substring(0, 8));
                bytes[1] = (byte)BinStringToByte(binString.Substring(8, 8));
                bytes[2] = (byte)BinStringToByte(binString.Substring(16, 8));
                bytes[3] = (byte)BinStringToByte(binString.Substring(24, 8));

            }
            else
            {
                bytes[0] = 0;
                bytes[1] = 0;
                bytes[2] = 0;
                bytes[3] = 0;
            }
            return bytes;
        }

        public static byte[] ToByteArray(double[] value)
        {
            ByteArray arr = new ByteArray();
            foreach (double val in value)
                arr.Add(ToByteArray(val));
            return arr.array;
        }
        #endregion
        #region ToArray
        public static double[] ToArray(byte[] bytes)
        {
            double[] values = new double[bytes.Length / 4];

            int counter = 0;
            for (int cnt = 0; cnt < bytes.Length / 4; cnt++)
                values[cnt] = FromByteArray(new byte[] { bytes[counter++], bytes[counter++], bytes[counter++], bytes[counter++] });

            return values;
        }
        #endregion
        
        // privates
        #region ValToBinString
        private static string ValToBinString(byte value)
        {
            string txt = "";

            for (int cnt = 7; cnt >= 0; cnt += -1)
            {
                if ((value & (byte)Math.Pow(2, cnt)) > 0)
                    txt += "1";
                else
                    txt += "0";
            }
            return txt;
        }
        #endregion
        #region BinStringToByte
        private static byte? BinStringToByte(string txt)
        {
            int cnt = 0;
            int ret = 0;

            if (txt.Length == 8)
            {
                for (cnt = 7; cnt >= 0; cnt += -1)
                {
                    if (int.Parse(txt.Substring(cnt, 1)) == 1)
                    {
                        ret += (int)(Math.Pow(2, (txt.Length - 1 - cnt)));
                    }
                }
                return (byte)ret;
            }
            return null;
        }
        #endregion
    }
}
