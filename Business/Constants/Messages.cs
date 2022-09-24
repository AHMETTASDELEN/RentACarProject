using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //General Messages
        public static string MaintenanceTime = "Sistem bakımda";


        //Car Messages
        public static string CarAdded = "Araba Eklendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        public static string CarNotAdded = "Araba Eklenemedi";
        public static string CarNotDeleted = "Araba Silinemedi";
        public static string CarNotUpdated = "Araba Güncellenemedi";

        public static string CarListed = "Arabalar listelendi";
        public static string CarDescriptionInvalid = "Araba açıklaması geçersiz";
        public static string CarPriceInvalid = "Araba günlük fiyatı 0'dan büyük olmalı";


        //Brand Messages
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandNotAdded = "Marka Eklenemedi";
        public static string BrandNotDeleted = "Marka Silinemedi";
        public static string BrandNotUpdated = "Marka Güncellenemedi";

        public static string BrandsListed = "Markalar Listelendi";
        public static string BrandNotFound = "Marka Bulunamadı";
        public static string BrandNameInvalid = "Marka adı geçersiz";
        public static string SameBrandNameExist = "Aynı araba markası mevcut";


        //Color Messages
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorNotAdded = "Renk Eklenemedi";
        public static string ColorNotDeleted = "Renk Silinemedi";
        public static string ColorNotUpdated = "Renk Güncellenemedi";

        public static string ColorsListed = "Renkler Listelendi";
        public static string ColorNotFound = "Renk Bulunamadı";
        public static string ColorNameInvalid = "Renk adı geçersiz";
        public static string SameColorNameExist = "Aynı renk adı mevcut";


        //Customer Messages
        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";

        public static string CustomersListed = "Müşteriler Listelendi";
        public static string CustomerNameInvalid = "Müşteri adı geçersiz";


        //User Messages
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UsersListed = "Kullanıcılar Listelendi";
        public static string UserNameInvalid = "Kullanıcı adı geçersiz";


        //Rental Messages
        public static string RentalAdded = "Kiralanma Eklendi";
        public static string RentalDeleted = "Kiralanma Silindi";
        public static string RentalUpdated = "Kiralanma Güncellendi";
        public static string RentalsListed = "Kiralamalar Listelendi";
        public static string RentalNotReturn = "Araç Teslim Edilmemiş";


        //CarImage 
        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageUpdated = "Araba resmi güncellendi";
        public static string CarImagesListed = "Araba resimleri listelendi";
        public static string AuthorizationDenied = "Yetkiniz Yok";
    }
}
