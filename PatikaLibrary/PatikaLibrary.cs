using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaLibrary
{
    internal class PatikaLibrary // Class: Nesne yönelimli programlamada, veri ve işlevleri bir arada tutan yapıdır.
    {

        

        private string name; // name field
        private string authorName; // authorName field
        private string authorSurName; // authorSurName field
        private int pageNumber; // pageNumber field
        private string publisher; // publisher field
        private DateTime registration; // registration field

        public string Name // Name property name field alanına güvenli ve kontrollü erişim sağlanır.
                           // Property: Bir sınıftaki alanlara güvenli erişim sağlayan kapsayıcı özelliktir.
        {
            get 
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string AuthorName // AuthorName property authorName field alanına güvenli ve kontrollü erişim sağlanır.
        {
            get
            {
                return authorName;
            }
            set
            {
                authorName = value;
            }
        }

        public string AuthorSurName // AuthorSurName property authorSurName field alanına güvenli ve kontrollü erişim sağlanır.
        {
            get
            {
                return authorSurName;
            }
            set
            {
                authorSurName = value;
            }
        }

        public int PageNumber // PageNumber property pageNumber field alanına güvenli ve kontrollü erişim sağlanır.
        {
            get
            {
                return pageNumber;
            }
            set
            {
                pageNumber = value;
            }
        }

        public string Publisher // Publisher property publisher field alanına güvenli ve kontrollü erişim sağlanır.
        {
            get
            {
                return publisher;
            }
            set
            {
                publisher = value;
            }
        }

        public DateTime Registration // Registration property registration field alanına güvenli ve kontrollü erişim sağlanır.
        { 
            get
            { 
                return registration; 
            } 
            set 
            {
                registration = value;
            }
        }


        public PatikaLibrary()
        // Constructor: Bir sınıftan nesne oluşturulurken çalışan yöntemdir. Default Constructor
        // Yayın tarihini nesne oluşturulurken veriyoruz.
        {
            Registration = DateTime.Now;
        }


        public PatikaLibrary(string name, string authorName,int pageNumber,string publisher)
        // Constructor: Bir sınıftan nesne oluşturulurken çalışan, başlangıç değerlerini atayan özel yöntemdir. Parametreli Constructor
        // Kitap adı, Yazar Adı, Sayfa Sayısı, Yayınevi  bilgilerini alıp bu değerleri nesne üretim aşamasında atayan bir metot
        // Yayın tarihini nesne oluşturulurken veriyoruz.

        {
            Name = name;
            AuthorName = authorName;            
            PageNumber = pageNumber;
            Publisher = publisher;
            Registration = DateTime.Now;
            

        }

        public void TellInfo()
        {
            Console.WriteLine($" ile oluşturulan kitap nesnesi\nKitap Adı : {name}\nYazar Adı : {authorName} \nSayfa Sayısı : {pageNumber}\nYayınevi : {publisher}\nKayıt Tarihi : {registration.ToString("dd.MM.yyyy")}");
        }



    }
}

