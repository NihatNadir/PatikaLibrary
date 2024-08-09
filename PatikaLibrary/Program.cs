using System;
namespace PatikaLibrary
{
    class Program // Class: Nesne yönelimli programlamada, veri ve işlevleri bir arada tutan yapıdır.
    {
        public static void Main(string[] args)
        {
            // New: Sınıftan yeni bir nesne oluşturmak için kullanılan anahtar kelimedir.
            PatikaLibrary newBook1 = new PatikaLibrary(); // Parametre almadan oluşturulan nesne            
            newBook1.Name = "Adı Aylin";
            newBook1.AuthorName = "Ayşe";
            newBook1.AuthorSurName = "Kulin";
            newBook1.PageNumber = 398;
            newBook1.Publisher = "Remzi Kitabevi";            
            Console.Write("Default Constructor");
            newBook1.TellInfo();

            // New: Sınıftan yeni bir nesne oluşturmak için kullanılan anahtar kelimedir.
            // Kitap adı, Yazar Adı, Sayfa Sayısı, Yayınevi  bilgilerini alıp bu değerleri nesne üretim aşamasında atayan bir metot
            PatikaLibrary newBook2 = new PatikaLibrary("Daha Başka Kitap","Mehmet",450,"Gamma Yayınları"); // Parametre alarak oluşturulan nesne
            Console.Write("\nParametreli Constructor");
            newBook2.TellInfo();
        }
    }
}