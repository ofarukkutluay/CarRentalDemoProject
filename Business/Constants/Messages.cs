using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDailyPriceInvalid = "Araç günlük fiyatı 0 olamaz";
        public static string MaintenanceTime = "Bakım saatleri arasındasınız";
        public static string CarsListed = " Tüm araçlar getirildi";
        public static string CarUpdated = "Araç güncellendi";
        public static string CarDeleted = "Araç Silindi";
        internal static string BrandInvalidError;

        public static string BrandAdded { get; internal set; }
    }
}
