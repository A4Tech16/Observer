using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public sealed class Reader : IObserver<News>
    {
        public string Name { get; set; }
        public Reader(string name)
        {
            Name = name;
        }

     /*   public void Update(News news)
        {
            Console.WriteLine(Name);
            Console.WriteLine(news.Title);
            Console.WriteLine(news.Content);
            Console.WriteLine("==============\n");
        }*/

        public void updater(News news)
        {
            Console.WriteLine(Name);
            Console.WriteLine(news.Title);
            Console.WriteLine(news.Content);
            Console.WriteLine("==============\n");
        }
    }
}
