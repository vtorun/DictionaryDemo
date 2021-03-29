using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyListDictionary<int, string> futbolcular = new MyListDictionary<int, string>();
            futbolcular.Add(27,"Dimitar Ivankov");
            futbolcular.Add(04, "Ömer Erdoğan");
            futbolcular.Add(21, "Ali Tandoğan");
            futbolcular.Add(17, "Pablo Batalla");
            futbolcular.Add(10, "Volkan Şen");
            futbolcular.Add(09, "Sercan Yıldırım");

            Console.WriteLine(futbolcular.Length);
            futbolcular.Listing();

        }
    }
}
