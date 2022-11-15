using System;

namespace Lesson1
{
    //Создать класс с именем Address.
    //В теле класса требуется создать поля: index, country, city, street, house, apartment.Для каждого поля, создать свойство
    //с двумя методами доступа.
    //Создать экземпляр класса Address.
    //В поля экземпляра записать информацию о почтовом адресе.  
    //Выведите на экран значения полей, описывающих адрес.

    class Adress
    {
        private string index = null;
        private string country = null;
        private string city = null;
        private string street = null;
        private string house = null;
        private string apartment = null;

        public string Index
        {
            set
            {
                index = value;
            }
            get
            {
                return index;
            }
        }

        public string Country
        {
            set
            {
                country = value;
            }
            get
            {
                return country;
            }
        }
        public string City
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }
        }
        public string Street
        {
            set
            {
                street = value;
            }
            get
            {
                return street;
            }
        }
        public string House
        {
            set
            {
                house = value;
            }
            get
            {
                return house;
            }
        }
        public string Apartment
        {
            set
            {
                apartment = value;
            }
            get
            {
                return apartment;
            }
        }
    }

    class Program
    {

        static void Main()
        {
            Adress adress = new Adress();
            adress.Index = "220101";
            adress.Country = "Belarus";
            adress.City = "Minsk";
            adress.Street = "Plehanova";
            adress.House = "93";
            adress.Apartment = "51";

            Console.WriteLine("Адрес проживания: " + adress.Country + " " + adress.City + " " + adress.Street + " " + adress.House + " " + adress.Apartment + " " + adress.Index);

            Console.ReadKey();
        }
    }
}

