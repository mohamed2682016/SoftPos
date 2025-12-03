using System;

using SoftPos.Utilities;
namespace SoftPos.Utilities
{
    /// <summary>
    /// مساعد للتعامل مع التواريخ والأوقات بتوقيت القاهرة
    /// </summary>
    public static class DateTimeHelper
    {
        // توقيت القاهرة (Africa/Cairo)
        private static readonly TimeZoneInfo CairoTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Egypt Standard Time");

        /// <summary>
        /// الحصول على التاريخ والوقت الحالي بتوقيت القاهرة
        /// </summary>
        public static DateTime Now
        {
            get
            {
                return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, CairoTimeZone);
            }
        }

        /// <summary>
        /// الحصول على التاريخ فقط بتوقيت القاهرة
        /// </summary>
        public static DateTime Today
        {
            get
            {
                return Now.Date;
            }
        }

        /// <summary>
        /// تحويل تاريخ UTC إلى توقيت القاهرة
        /// </summary>
        public static DateTime ConvertFromUtc(DateTime utcDateTime)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, CairoTimeZone);
        }

        /// <summary>
        /// تحويل تاريخ من توقيت القاهرة إلى UTC
        /// </summary>
        public static DateTime ConvertToUtc(DateTime cairoDateTime)
        {
            return TimeZoneInfo.ConvertTimeToUtc(cairoDateTime, CairoTimeZone);
        }
    }
}
