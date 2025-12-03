namespace SoftPos.Utilities
{
    public static class DatabaseSettings
    {
        private const string DatabaseVersionKey = "DatabaseVersion";
        private const string LastResetDateKey = "LastResetDate";
        
        public static int CurrentDatabaseVersion => 1;
        
        /// <summary>
        /// الحصول على إصدار قاعدة البيانات المحفوظ
        /// </summary>
        public static int GetSavedDatabaseVersion()
        {
            return Preferences.Get(DatabaseVersionKey, 0);
        }
        
        /// <summary>
        /// حفظ إصدار قاعدة البيانات
        /// </summary>
        public static void SaveDatabaseVersion(int version)
        {
            Preferences.Set(DatabaseVersionKey, version);
        }
        
        /// <summary>
        /// فحص ما إذا كانت قاعدة البيانات تحتاج إلى تحديث
        /// </summary>
        public static bool NeedsDatabaseUpdate()
        {
            var savedVersion = GetSavedDatabaseVersion();
            return savedVersion < CurrentDatabaseVersion;
        }
        
        /// <summary>
        /// حفظ تاريخ آخر إعادة تعيين لقاعدة البيانات
        /// </summary>
        public static void SaveLastResetDate()
        {
            Preferences.Set(LastResetDateKey, DateTime.UtcNow.ToString());
        }
        
        /// <summary>
        /// الحصول على تاريخ آخر إعادة تعيين لقاعدة البيانات
        /// </summary>
        public static DateTime? GetLastResetDate()
        {
            var dateString = Preferences.Get(LastResetDateKey, string.Empty);
            if (DateTime.TryParse(dateString, out var date))
            {
                return date;
            }
            return null;
        }
        
        /// <summary>
        /// فحص ما إذا كان يجب إعادة تعيين قاعدة البيانات (إذا كان آخر إعادة تعيين منذ أكثر من يوم)
        /// </summary>
        public static bool ShouldResetDatabase()
        {
            var lastReset = GetLastResetDate();
            if (lastReset == null)
            {
                return false; // لم يتم إعادة التعيين من قبل
            }
            
            // إعادة التعيين فقط إذا كان آخر إعادة تعيين منذ أكثر من يوم
            return DateTime.UtcNow.Subtract(lastReset.Value).TotalDays > 1;
        }
        
        /// <summary>
        /// مسح جميع إعدادات قاعدة البيانات
        /// </summary>
        public static void ClearDatabaseSettings()
        {
            Preferences.Remove(DatabaseVersionKey);
            Preferences.Remove(LastResetDateKey);
        }
    }
}