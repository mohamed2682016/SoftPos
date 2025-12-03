namespace SoftPos.Resources
{
    /// <summary>
    /// ترجمات صفحات المصادقة - Authentication Pages Translations
    /// </summary>
    public static class AuthTranslations
    {
        // ===== Login Page - صفحة تسجيل الدخول =====
        public static class Login
        {
            public static string Title => "تسجيل الدخول";
            public static string Email => "البريد الإلكتروني";
            public static string Password => "كلمة المرور";
            public static string RememberMe => "تذكرني";
            public static string SignIn => "تسجيل الدخول";
            public static string ForgotPassword => "نسيت كلمة المرور؟";
            public static string ResetPassword => "إعادة تعيين كلمة المرور";
            public static string EnterEmail => "أدخل البريد الإلكتروني";
            public static string EnterPassword => "أدخل كلمة المرور";
            public static string LoginFailed => "فشل تسجيل الدخول";
            public static string InvalidCredentials => "بيانات اعتماد غير صحيحة";
            public static string AccountLocked => "الحساب مقفل";
            public static string AccountDisabled => "الحساب معطل";
            public static string LoginSuccess => "تم تسجيل الدخول بنجاح";
            public static string WelcomeBack => "مرحباً بعودتك";
            public static string Loading => "جاري تسجيل الدخول...";
        }

        // ===== Register Page - صفحة التسجيل =====
        public static class Register
        {
            public static string Title => "إنشاء حساب جديد";
            public static string FullName => "الاسم الكامل";
            public static string Email => "البريد الإلكتروني";
            public static string Password => "كلمة المرور";
            public static string ConfirmPassword => "تأكيد كلمة المرور";
            public static string Phone => "رقم الهاتف";
            public static string Address => "العنوان";
            public static string City => "المدينة";
            public static string Country => "الدولة";
            public static string ZipCode => "الرمز البريدي";
            public static string Role => "الدور";
          
            public static string AlreadyHaveAccount => "لديك حساب بالفعل؟";
            public static string SignInHere => "سجل الدخول هنا";
            public static string RegistrationSuccess => "تم إنشاء الحساب بنجاح";
            public static string RegistrationFailed => "فشل في إنشاء الحساب";
            public static string EmailExists => "البريد الإلكتروني موجود بالفعل";
            public static string PasswordMismatch => "كلمات المرور غير متطابقة";
            public static string InvalidEmail => "بريد إلكتروني غير صحيح";
            public static string WeakPassword => "كلمة مرور ضعيفة";
            public static string TermsAndConditions => "الشروط والأحكام";
            public static string AcceptTerms => "أوافق على الشروط والأحكام";
            public static string Loading => "جاري إنشاء الحساب...";
        }

        // ===== Profile Page - صفحة الملف الشخصي =====
        public static class Profile
        {
            public static string Title => "الملف الشخصي";
            public static string PersonalInfo => "المعلومات الشخصية";
            public static string ContactInfo => "معلومات الاتصال";
            public static string SecurityInfo => "معلومات الأمان";
            public static string Preferences => "التفضيلات";
            public static string FullName => "الاسم الكامل";
            public static string Email => "البريد الإلكتروني";
            public static string Phone => "رقم الهاتف";
            public static string Mobile => "رقم الجوال";
            public static string Address => "العنوان";
            public static string City => "المدينة";
            public static string Country => "الدولة";
            public static string ZipCode => "الرمز البريدي";
            public static string DateOfBirth => "تاريخ الميلاد";
            public static string Gender => "الجنس";
            public static string Male => "ذكر";
            public static string Female => "أنثى";
            public static string Other => "آخر";
            public static string ProfilePicture => "صورة الملف الشخصي";
            public static string UploadPicture => "رفع صورة";
            public static string RemovePicture => "إزالة الصورة";
            public static string SaveChanges => "حفظ التغييرات";
            public static string Cancel => "إلغاء";
            public static string UpdateSuccess => "تم تحديث الملف الشخصي بنجاح";
            public static string UpdateFailed => "فشل في تحديث الملف الشخصي";
            public static string Loading => "جاري تحديث الملف الشخصي...";
        }

        // ===== Change Password Page - صفحة تغيير كلمة المرور =====
        public static class ChangePassword
        {
            public static string Title => "تغيير كلمة المرور";
            public static string CurrentPassword => "كلمة المرور الحالية";
            public static string NewPassword => "كلمة المرور الجديدة";
            public static string ConfirmNewPassword => "تأكيد كلمة المرور الجديدة";
            public static string Cancel => "إلغاء";
            public static string PasswordChanged => "تم تغيير كلمة المرور بنجاح";
            public static string PasswordChangeFailed => "فشل في تغيير كلمة المرور";
            public static string CurrentPasswordIncorrect => "كلمة المرور الحالية غير صحيحة";
            public static string NewPasswordMismatch => "كلمات المرور الجديدة غير متطابقة";
            public static string WeakNewPassword => "كلمة المرور الجديدة ضعيفة";
            public static string SamePassword => "كلمة المرور الجديدة مطابقة للحالية";
            public static string Loading => "جاري تغيير كلمة المرور...";
        }

        // ===== User Management - إدارة المستخدمين =====
        public static class UserManagement
        {
            public static string Title => "إدارة المستخدمين";
            public static string Users => "المستخدمين";
            public static string AddUser => "إضافة مستخدم";
            public static string EditUser => "تعديل المستخدم";
            public static string DeleteUser => "حذف المستخدم";
            public static string ViewUser => "عرض المستخدم";
            public static string UserDetails => "تفاصيل المستخدم";
            public static string Username => "اسم المستخدم";
            public static string FullName => "الاسم الكامل";
            public static string Email => "البريد الإلكتروني";
            public static string Phone => "رقم الهاتف";
            public static string Role => "الدور";
            public static string Status => "الحالة";
            public static string Active => "نشط";
            public static string Inactive => "غير نشط";
            public static string LastLogin => "آخر تسجيل دخول";
            public static string CreatedDate => "تاريخ الإنشاء";
            public static string Actions => "الإجراءات";
            public static string Search => "بحث";
            public static string Filter => "تصفية";
            public static string Sort => "ترتيب";
            public static string Export => "تصدير";
            public static string Import => "استيراد";
            public static string Print => "طباعة";
            public static string Save => "حفظ";
            public static string Cancel => "إلغاء";
            public static string Delete => "حذف";
            public static string Edit => "تعديل";
            public static string View => "عرض";
            public static string Create => "إنشاء";
            public static string Update => "تحديث";
        }

        // ===== Role Management - إدارة الأدوار =====
        public static class RoleManagement
        {
            public static string Title => "إدارة الأدوار";
            public static string Roles => "الأدوار";
            public static string AddRole => "إضافة دور";
            public static string EditRole => "تعديل الدور";
            public static string DeleteRole => "حذف الدور";
            public static string ViewRole => "عرض الدور";
            public static string RoleDetails => "تفاصيل الدور";
            public static string RoleName => "اسم الدور";
            public static string RoleDescription => "وصف الدور";
            public static string Permissions => "الصلاحيات";
            public static string Status => "الحالة";
            public static string Active => "نشط";
            public static string Inactive => "غير نشط";
            public static string CreatedDate => "تاريخ الإنشاء";
            public static string Actions => "الإجراءات";
            public static string Search => "بحث";
            public static string Filter => "تصفية";
            public static string Sort => "ترتيب";
            public static string Export => "تصدير";
            public static string Import => "استيراد";
            public static string Print => "طباعة";
            public static string Save => "حفظ";
            public static string Cancel => "إلغاء";
            public static string Delete => "حذف";
            public static string Edit => "تعديل";
            public static string View => "عرض";
            public static string Create => "إنشاء";
            public static string Update => "تحديث";
        }

        // ===== Permission Management - إدارة الصلاحيات =====
        public static class PermissionManagement
        {
            public static string Title => "إدارة الصلاحيات";
            public static string Permissions => "الصلاحيات";
            public static string AddPermission => "إضافة صلاحية";
            public static string EditPermission => "تعديل الصلاحية";
            public static string DeletePermission => "حذف الصلاحية";
            public static string ViewPermission => "عرض الصلاحية";
            public static string PermissionDetails => "تفاصيل الصلاحية";
            public static string PermissionName => "اسم الصلاحية";
            public static string PermissionDescription => "وصف الصلاحية";
            public static string Module => "الوحدة";
            public static string Action => "الإجراء";
            public static string Status => "الحالة";
            public static string Active => "نشط";
            public static string Inactive => "غير نشط";
            public static string CreatedDate => "تاريخ الإنشاء";
            public static string Actions => "الإجراءات";
            public static string Search => "بحث";
            public static string Filter => "تصفية";
            public static string Sort => "ترتيب";
            public static string Export => "تصدير";
            public static string Import => "استيراد";
            public static string Print => "طباعة";
            public static string Save => "حفظ";
            public static string Cancel => "إلغاء";
            public static string Delete => "حذف";
            public static string Edit => "تعديل";
            public static string View => "عرض";
            public static string Create => "إنشاء";
            public static string Update => "تحديث";
        }

        // ===== Verification Page - صفحة التحقق =====
        public static class Verification
        {
            public static string Title => "التحقق من الحساب";
            public static string VerificationCode => "كود التحقق";
            public static string EnterVerificationCode => "أدخل كود التحقق";
            public static string Verify => "تحقق";
            public static string ResendCode => "إعادة إرسال الكود";
            public static string VerificationSuccess => "تم التحقق بنجاح";
            public static string VerificationFailed => "فشل في التحقق";
            public static string InvalidCode => "كود غير صحيح";
            public static string CodeExpired => "انتهت صلاحية الكود";
            public static string Loading => "جاري التحقق...";
        }

        // ===== Forgot Password Page - صفحة نسيان كلمة المرور =====
        public static class ForgotPassword
        {
            public static string Title => "نسيان كلمة المرور";
            public static string Email => "البريد الإلكتروني";
            public static string EnterEmail => "أدخل البريد الإلكتروني";
            public static string SendResetLink => "إرسال رابط إعادة التعيين";
            public static string BackToLogin => "العودة لتسجيل الدخول";
            public static string ResetLinkSent => "تم إرسال رابط إعادة التعيين";
            public static string ResetLinkFailed => "فشل في إرسال رابط إعادة التعيين";
            public static string EmailNotFound => "البريد الإلكتروني غير موجود";
            public static string Loading => "جاري إرسال رابط إعادة التعيين...";
        }

        // ===== Reset Password Page - صفحة إعادة تعيين كلمة المرور =====
        public static class ResetPassword
        {
            public static string Title => "إعادة تعيين كلمة المرور";
            public static string NewPassword => "كلمة المرور الجديدة";
            public static string ConfirmNewPassword => "تأكيد كلمة المرور الجديدة";
            public static string PasswordReset => "تم إعادة تعيين كلمة المرور بنجاح";
            public static string PasswordResetFailed => "فشل في إعادة تعيين كلمة المرور";
            public static string InvalidToken => "رمز غير صحيح";
            public static string TokenExpired => "انتهت صلاحية الرمز";
            public static string Loading => "جاري إعادة تعيين كلمة المرور...";
        }

        // ===== Common Auth Terms - المصطلحات الشائعة =====
        public static class Common
        {
            public static string Authentication => "المصادقة";
            public static string Authorization => "الترخيص";
            public static string User => "المستخدم";
            public static string Users => "المستخدمين";
            public static string Role => "الدور";
            public static string Roles => "الأدوار";
            public static string Permission => "الصلاحية";
            public static string Permissions => "الصلاحيات";
            public static string Login => "تسجيل الدخول";
            public static string Logout => "تسجيل الخروج";
            public static string Register => "التسجيل";
            public static string Profile => "الملف الشخصي";
            public static string Password => "كلمة المرور";
            public static string Email => "البريد الإلكتروني";
            public static string Phone => "رقم الهاتف";
            public static string Address => "العنوان";
            public static string Status => "الحالة";
            public static string Actions => "الإجراءات";
            public static string Create => "إنشاء";
            public static string Edit => "تعديل";
            public static string Delete => "حذف";
            public static string View => "عرض";
            public static string Save => "حفظ";
            public static string Cancel => "إلغاء";
            public static string Search => "بحث";
            public static string Filter => "تصفية";
            public static string Sort => "ترتيب";
            public static string Export => "تصدير";
            public static string Import => "استيراد";
            public static string Print => "طباعة";
        }

        // ===== Validation Messages - رسائل التحقق =====
        public static class Validation
        {
            public static string EmailRequired => "البريد الإلكتروني مطلوب";
            public static string PasswordRequired => "كلمة المرور مطلوبة";
            public static string FullNameRequired => "الاسم الكامل مطلوب";
            public static string PhoneRequired => "رقم الهاتف مطلوب";
            public static string AddressRequired => "العنوان مطلوب";
            public static string InvalidEmail => "بريد إلكتروني غير صحيح";
            public static string InvalidPhone => "رقم هاتف غير صحيح";
            public static string WeakPassword => "كلمة مرور ضعيفة";
            public static string PasswordMismatch => "كلمات المرور غير متطابقة";
            public static string RequiredField => "هذا الحقل مطلوب";
            public static string InvalidData => "بيانات غير صحيحة";
            public static string DuplicateEmail => "البريد الإلكتروني موجود بالفعل";
            public static string DuplicateUsername => "اسم المستخدم موجود بالفعل";
            public static string InvalidCredentials => "بيانات اعتماد غير صحيحة";
            public static string AccountLocked => "الحساب مقفل";
            public static string AccountDisabled => "الحساب معطل";
            public static string SessionExpired => "انتهت صلاحية الجلسة";
            public static string AccessDenied => "تم رفض الوصول";
            public static string PermissionDenied => "تم رفض الإذن";
        }

        // ===== Success Messages - رسائل النجاح =====
        public static class Success
        {
            public static string LoginSuccess => "تم تسجيل الدخول بنجاح";
            public static string LogoutSuccess => "تم تسجيل الخروج بنجاح";
            public static string RegistrationSuccess => "تم إنشاء الحساب بنجاح";
            public static string ProfileUpdated => "تم تحديث الملف الشخصي بنجاح";
            public static string PasswordChanged => "تم تغيير كلمة المرور بنجاح";
            public static string PasswordReset => "تم إعادة تعيين كلمة المرور بنجاح";
            public static string UserCreated => "تم إنشاء المستخدم بنجاح";
            public static string UserUpdated => "تم تحديث المستخدم بنجاح";
            public static string UserDeleted => "تم حذف المستخدم بنجاح";
            public static string RoleCreated => "تم إنشاء الدور بنجاح";
            public static string RoleUpdated => "تم تحديث الدور بنجاح";
            public static string RoleDeleted => "تم حذف الدور بنجاح";
            public static string PermissionCreated => "تم إنشاء الصلاحية بنجاح";
            public static string PermissionUpdated => "تم تحديث الصلاحية بنجاح";
            public static string PermissionDeleted => "تم حذف الصلاحية بنجاح";
            public static string VerificationSuccess => "تم التحقق بنجاح";
            public static string DataSaved => "تم حفظ البيانات بنجاح";
            public static string DataUpdated => "تم تحديث البيانات بنجاح";
            public static string DataDeleted => "تم حذف البيانات بنجاح";
        }

        // ===== Error Messages - رسائل الخطأ =====
        public static class Error
        {
            public static string LoginFailed => "فشل تسجيل الدخول";
            public static string LogoutFailed => "فشل تسجيل الخروج";
            public static string RegistrationFailed => "فشل في إنشاء الحساب";
            public static string ProfileUpdateFailed => "فشل في تحديث الملف الشخصي";
            public static string PasswordChangeFailed => "فشل في تغيير كلمة المرور";
            public static string PasswordResetFailed => "فشل في إعادة تعيين كلمة المرور";
            public static string UserCreationFailed => "فشل في إنشاء المستخدم";
            public static string UserUpdateFailed => "فشل في تحديث المستخدم";
            public static string UserDeletionFailed => "فشل في حذف المستخدم";
            public static string RoleCreationFailed => "فشل في إنشاء الدور";
            public static string RoleUpdateFailed => "فشل في تحديث الدور";
            public static string RoleDeletionFailed => "فشل في حذف الدور";
            public static string PermissionCreationFailed => "فشل في إنشاء الصلاحية";
            public static string PermissionUpdateFailed => "فشل في تحديث الصلاحية";
            public static string PermissionDeletionFailed => "فشل في حذف الصلاحية";
            public static string VerificationFailed => "فشل في التحقق";
            public static string ErrorLoadingData => "خطأ في تحميل البيانات";
            public static string ErrorSavingData => "خطأ في حفظ البيانات";
            public static string ErrorDeletingData => "خطأ في حذف البيانات";
            public static string NetworkError => "خطأ في الشبكة";
            public static string ServerError => "خطأ في الخادم";
            public static string SessionExpired => "انتهت صلاحية الجلسة";
            public static string AccessDenied => "تم رفض الوصول";
            public static string PermissionDenied => "تم رفض الإذن";
        }
    }
}


