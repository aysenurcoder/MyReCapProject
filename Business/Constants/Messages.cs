using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //Marka için mesajlar
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandNameInvalid = "Marka ismi geçersiz.";

        //Araba için mesajlar
        public static string CarAdded = "Araba eklendi.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarUpdated = "Araba güncellendi.";
        internal static string CarsListed="Arabalar listelendi.";
        internal static string MaintenanceTime = "Sistem bakımda.";

        //Renk için mesajlar
        public static string ColorAdded = "Renk eklendi.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorUpdated = "Renk güncellendi.";

        //Müşteri için mesajlar
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        internal static string CustomerListed = "Müşteriler listelendi.";

        //Oto Kiralama için mesajlar
        public static string RentalAdded = "Kiralama işlemi başarılı.";
        public static string RentalAddedError = "Kiralama işleminin gerçekleşebilmesi için önce araç teslim edilmelidir.";
        public static string RentalDeleted = "Kiralama işlemi silindi.";
        public static string RentalUpdated = "Kiralama işlemi güncellendi.";
        public static string RentalUpdatedReturnDate = " Araç Teslim Alındı.";
        public static string RentalUpdatedReturnDateError = " Araç Zaten Teslim Alınmış.";

        //Kullanıcılar için mesajar
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        internal static string UserListed = "Kullanıcılar listelendi.";
    }
}
