﻿using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class InputManager : IInputService
    {
        public Brand InputBrand()
        {
            Brand brand = new Brand();

            Console.Write("Marka Id: ");
            brand.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Marka Adı: ");
            brand.BrandName= Console.ReadLine();

            return brand;
        }

        public Car InputCar()
        {
            Car car = new Car();

            Console.Write("Araba Id: ");
            car.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Araba Marka Id: ");
            car.BrandId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Araba Renk Id: ");
            car.ColorId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Araba Model Yılı: ");
            car.ModelYear = Convert.ToInt32(Console.ReadLine());

            Console.Write("Araba Günlük ücret: ");
            car.DailyPrice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Araba Açıklama: ");
            car.Description = Console.ReadLine();

            return car;
        }

        public Color InputColor()
        {
            Color color = new Color();

            Console.Write("Renk Id: ");
            color.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Renk Adı: ");
            color.ColorName = Console.ReadLine();

            return color;
        }

        public Customer InputCustomer()
        {
            Customer customer = new Customer();

            Console.Write("Müşteri Id: ");
            customer.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Müşteri Kullanıcı Id: ");
            customer.UserId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Şirket Adı: ");
            customer.CompanyName = Console.ReadLine();

            return customer;
        }

        public int InputId()
        {
            Console.Write("Id giriniz: ");
            int Id = Convert.ToInt32(Console.ReadLine());

            return Id;
        }

        public Rental InputRental()
        {
            Rental rental = new Rental();

            Console.WriteLine("Kiralama Id: " );
            rental.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiralama Araba Id: ");
            rental.CarId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiralama Müşteri Id: ");
            rental.CustomerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiralama Tarih: ");
            rental.RentDate = Convert.ToDateTime(Console.ReadLine());

            return rental;
        }

        public User InputUser()
        {
            User user = new User();

            Console.WriteLine("Kullanıcı Id: " );
            user.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kullanıcı Ado: ");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("Kullanıcı Soyadı: ");
            user.LastName = Console.ReadLine();

            Console.WriteLine("Kullanıcı Email: ");
            user.Email = Console.ReadLine();

            Console.WriteLine("Kullanıcı Şifresi: ");
            user.Password = Convert.ToInt32(Console.ReadLine());

            return user;
        }

        public int InputTitle()
        {
            Console.WriteLine("İslemler\n------------------------");
            Console.WriteLine("1-->Marka İslemleri\n" +
                "2-->Araba İslemleri\n" +
                "3-->Renk İslemleri\n" +
                "4-->Müşteri İslemleri\n" +
                "5-->Kullanıcı İslemleri\n" +
                "6-->Kiralama İslemleri\n");
            Console.Write("İslem Girniz: ");
            int title = Convert.ToInt32(Console.ReadLine());
            return title;
        }
        public int Inputoperation(int operation)
        {
            switch (operation)
            {
                
                case 1: Console.WriteLine("1-->Id'ye Göre Marka Getir\n" +
                    "2-->Markaları Listele\n" +
                    "3-->Marka Ekle\n" +
                    "4-->Marka Güncelle\n" +
                    "5-->Marka Sil\n");
                    break;

                case 2:
                    Console.WriteLine("1-->Id'ye Göre Araba Getir\n" +
                    "2-->Arabaları Listele\n" +
                    "3-->Araba Ekle\n" +
                    "4-->Araba Güncelle\n" +
                    "5-->Araba Sil\n"+
                    "6-->Marka Id'ye Göre Araba Getir\n"+
                    "7-->Renk Id'ye Göre Araba Getir\n"+
                    "8-->Arabaları Detaylı Listele\n");
                    break;

                case 3:
                    Console.WriteLine("1-->Id'ye Göre Renk Getir\n" +
                    "2-->Renkleri Listele\n" +
                    "3-->Renk Ekle\n" +
                    "4-->Renk Güncelle\n" +
                    "5-->Renk Sil\n");
                    break;

                case 4:
                    Console.WriteLine("1-->Id'ye Göre Müşteri Getir\n" +
                    "2-->Müşterileri Listele\n" +
                    "3-->Müşteri Ekle\n" +
                    "4-->Müşteri Güncelle\n" +
                    "5-->Müşteri Sil\n");
                    break;

                case 5:
                    Console.WriteLine("1-->Id'ye Göre Kiralama Getir\n" +
                    "2-->Kiralamaları Listele\n" +
                    "3-->Kiralama Ekle\n" +
                    "4-->Kiralama Güncelle\n" +
                    "5-->Kiralam Sil\n");
                    break;

                case 6:
                    Console.WriteLine("1-->Id'ye Göre Kullanıcı Getir\n" +
                    "2-->Kullancıları Listele\n" +
                    "3-->Kullanıcı Ekle\n" +
                    "4-->Kullanıcı Güncelle\n" +
                    "5-->Kullanıcı Sil\n");
                    break;
            }

            Console.Write("İslem Girniz: ");
            int operation2 = Convert.ToInt32(Console.ReadLine());
            return operation2;
        }

    }
}