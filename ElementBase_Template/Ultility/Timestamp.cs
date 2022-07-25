using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBase_Template.Ultility
{
    public class Timestamp
    {
        public class ultility
        {
            /// <summary>
            /// Chuyển đổi Datetime (UTC) sang Timestamp (UTC) - Unit: second
            /// </summary>
            /// <param name="date">UTC Date</param>
            /// <returns></returns>
            public int getTimestampUTC_second(DateTime date)
            {
                int Timestamp = (int)date.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
                return Timestamp;
            }

            /// <summary>
            /// Chuyển đổi Datetime (UTC) sang Timestamp (Local) - Unit: second
            /// </summary>
            /// <param name="date">Local Date</param>
            /// <returns></returns>
            public int getTimestampLocal_second(DateTime date)
            {
                int temp = (int)date.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
                int Timestamp = temp + 7 * 60 * 60; // GMT: +7 VietNam
                return Timestamp;
            }

            /// <summary>
            /// Chuyển đổi Datetime (UTC) sang Timestamp (UTC)- Unit: ms
            /// </summary>
            /// <param name="date">UTC Datetime</param>
            /// <returns></returns>
            public int getTimestampUTC_milisecond(DateTime date)
            {
                int Timestamp = (int)date.Subtract(new DateTime(1970,1,1)).TotalMilliseconds;
                return Timestamp;
            }

            /// <summary>
            /// Chuyển đổi Datetime (UTC) sang timestamp (Local) - Unit: ms
            /// </summary>
            /// <param name="date"></param>
            /// <returns></returns>
            public int getTimestampLocal_milisecond(DateTime date)
            {
                int temp = (int)date.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
                int Timestamp = temp + 7 * 60 * 60*1000;  // GMT: +7 VietNam
                return Timestamp;
            }

            /// <summary>
            /// Tính chênh lệch thời gian giữa mốc T2 và T1 - UTC - Unit: second
            /// </summary>
            /// <param name="T1">UTC Datetime</param>
            /// <param name="T2">UTC Datetime</param>
            /// <returns></returns>
            public int Subtract_second(DateTime T1, DateTime T2)
            {
                int T1_Timestamp = (int)T1.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
                int T2_Timestamp = (int)T2.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
                int T2T1 = T2_Timestamp - T1_Timestamp;

                return T2T1;
            }

            /// <summary>
            /// Tính chênh lệch thời gian giữa mốc T2 và T1 - UTC - Unit: ms
            /// </summary>
            /// <param name="T1">UTC Datetime</param>
            /// <param name="T2">UTC Datetime</param>
            /// <returns></returns>
            public int Subtract_milisecond(DateTime T1, DateTime T2)
            {
                int T1_Timestamp = (int)T1.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
                int T2_Timestamp = (int)T2.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
                int T2T1 = T2_Timestamp - T1_Timestamp;

                return T2T1;
            }

            /// <summary>
            /// Chuyển Datetime (Local) sang Timestamp (UTC)
            /// </summary>
            /// <param name="date">Local Datetime</param>
            /// <returns>Timestamp UTC in second unit</returns>
            public int getTime_LocalToUTC_second(DateTime date)
            {
                int temp = (int)date.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
                int Timestamp = temp - 7 * 60 * 60; // GMT: +7 VietNam
                return Timestamp;
            }

            /// <summary>
            /// Chuyển Datetime (Local) sang Timestamp (UTC)- Unit: ms
            /// </summary>
            /// <param name="date">(Local) Datetime</param>
            /// <returns></returns>
            public int getTime_LocalToUTC_milisecond(DateTime date)
            {
                int temp = (int)date.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
                int Timestamp = temp - 7 * 60 * 60*1000; // GMT: +7 VietNam
                return Timestamp;
            }



        }
    }
}
