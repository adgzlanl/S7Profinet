﻿using System;
using System.Collections.Generic;
using System.Text;
using PROFINET_STEP_7.Profinet;

namespace PROFINET_STEP_7.Types
{
    public static class Timer
    {
        // publics
        #region FromByteArray
        public static double FromByteArray(byte[] bytes)
        {
            double wert = 0;
            Int16 value = (Int16)Types.Word.FromBytes(bytes[1], bytes[0]);
            string txt = Conversion.ValToBinString(value);
            wert = Conversion.BinStringToInt(txt.Substring(4, 4)) * 100.0;
            wert += Conversion.BinStringToInt(txt.Substring(8, 4)) * 10.0;
            wert += Conversion.BinStringToInt(txt.Substring(12, 4));
            switch (txt.Substring(2, 2))
            {
                case "00":
                    wert *= 0.01;
                    break;
                case "01":
                    wert *= 0.1;
                    break;
                case "10":
                    wert *= 1.0;
                    break;
                case "11":
                    wert *= 10.0;
                    break;
            }
            return wert;
        }
        #endregion

        #region ToByteArray
        public static byte[] ToByteArray(UInt16 value)
        {
            byte[] bytes = new byte[2];
            int x = 2;
            long valLong = (long)((UInt16)value);
            for (int cnt = 0; cnt < x; cnt++)
            {
                Int64 x1 = (Int64)Math.Pow(256, (cnt));

                Int64 x3 = (Int64)(valLong / x1);
                bytes[x - cnt - 1] = (byte)(x3 & 255);
                valLong -= bytes[x - cnt - 1] * x1;
            }
            return bytes;
        }

        public static byte[] ToByteArray(UInt16[] value)
        {
            ByteArray arr = new ByteArray();
            foreach (UInt16 val in value)
                arr.Add(ToByteArray(val));
            return arr.array;
        }
        #endregion
        #region ToArray
        public static double[] ToArray(byte[] bytes)
        {
            double[] values = new double[bytes.Length / 2];

            int counter = 0;
            for (int cnt = 0; cnt < bytes.Length / 2; cnt++)
                values[cnt] = FromByteArray(new byte[] { bytes[counter++], bytes[counter++] });

            return values;
        }
        #endregion
    }
}
