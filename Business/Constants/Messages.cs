using Core.Entities.Concrete;

namespace Bussiness.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç eklendi...";
        public static string CarNameInvalid = "Araç ismi geçersiz...";
        public static string MaintenanceTime = "Bakım Zamanı...";
        public static string CarListed = "Araçlar Listelendi...";
        public static string CarImageLimitExceeded = "Sadece 5 tane resim ekleyebilirsiniz...";
        public static string AuthorizationDenied = "Bu işlem için yetkiniz yok...";

        public static string UserRegistered = "Kullanıcı kaydedildi...";
        public static string UserNotFound = "Kullanıcı Bulunamadı...";
        public static string PasswordError = "Şifre Hatalı...";
        public static string UserAlreadyExists = "Kullanıcı zaten kayıtlı...";
        public static string SuccessfullLogin = "Kullanıcı girişi başarılı...";

        public static string AccessTokenCreated = "Access token oluşturuldu...";
    }
}
