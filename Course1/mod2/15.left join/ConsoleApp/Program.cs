using System;
using System.Linq;

namespace ConsoleApp
{

    class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LanguageId { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Language[] languages = {
                new Language{Id=1,Name="English"},
                new Language{Id=2,Name="中文"},
                new Language{Id=3,Name="日本語"}
            };

            Person[] people =  {
                new Person{Id=1, Name="aaa",LanguageId=1},
                new Person{Id=2, Name="bbb",LanguageId=1},
                new Person{Id=3, Name="ccc",LanguageId=2},
            };


            var query = from w in languages
                        join p in people
                        on w.Id equals p.LanguageId into temp
                        select (w, temp);

            foreach (var item in query)
            {
                Console.WriteLine(item.w.Name);

                foreach (var i in item.temp)
                {
                    Console.WriteLine($"    {i.Name}" );
                }
            }
        }
    }
}
