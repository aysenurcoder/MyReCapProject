using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandNameInvalid = "Marka ismi geçersiz.";

        
        public static string CarAdded = "Araba eklendi.";
        public static string CarAddedError = "Araba eklenemedi.Arabanın günlük fiyatı 0 dan büyük olmalıdır.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarUpdated = "Araba güncellendi.";
        internal static string CarsListed="Arabalar listelendi.";
        internal static string MaintenanceTime = "Sistem bakımda.";

        
        public static string ColorAdded = "Renk eklendi.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorUpdated = "Renk güncellendi.";

        
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        internal static string CustomerListed = "Müşteriler listelendi.";

        
        public static string RentalAdded = "Kiralama işlemi başarılı.";
        public static string RentalAddedError = "Kiralama işleminin gerçekleşebilmesi için önce araç teslim edilmelidir.";
        public static string RentalDeleted = "Kiralama işlemi silindi.";
        public static string RentalUpdated = "Kiralama işlemi güncellendi.";
        public static string RentalUpdatedReturnDate = " Araç Teslim Alındı.";
        public static string RentalUpdatedReturnDateError = " Araç Zaten Teslim Alınmış.";
        public static string RentalListedCarAndCustomer = "Araç kiralamalar listelendi";


        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        internal static string UserListed = "Kullanıcılar listelendi.";


        public static string CarImageAdded = "Araba'nın resmi eklendi.";
        public static string CarImageDeleted = "Araba'nın resmi silindi.";
        public static string CarImageUpdated = "Araba'nın resmi güncellendi.";
        public static string CarImageAddError = "Bir araba'nın en fazla 5 resmi olabilir.";


        public static string AuthorizationDenied= "Yetkiniz yok.";
        public static string UserRegistered= "Kullanıcı başarıyla kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists= "Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        
    }
}
