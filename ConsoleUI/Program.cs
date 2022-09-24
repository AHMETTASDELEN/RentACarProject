using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarDetailsTest();
            //CarTest();
            //BrandTest();
            //ColorTest();
            //UserTest();
            //UserDetailsTest();
        }

        private static void UserDetailsTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetUserDetails();
            if (result.Success)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.FirstName + user.LastName + "/" + user.CompanyName);
                }
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetAll();
            if (result.Success)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.FirstName);
                }
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description);
                }
            }
        }

        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine
                    (car.ModelYear + " " + car.BrandName + " " + car.Description + " " + car.ColorName
                    + " / PRİCE = " + car.DailyPrice + " TL");
                }
            }
        }
    }
}
