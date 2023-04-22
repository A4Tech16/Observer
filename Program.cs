using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            NewsAggregator newsAggregator = new NewsAggregator();
            Reader Tim = new Reader("Timoha");
            Reader Egor = new Reader("Egor");

            newsAggregator.Subscribe(Tim);
            newsAggregator.Subscribe(Egor);


            News news1 = new News("Title1", "Content1");
            News news2 = new News("Title2", "Content2");
            News news3 = new News("Title3", "Content3");

            newsAggregator.Notify(news1);
            Thread.Sleep(1000);
            newsAggregator.Notify(news2);
            Thread.Sleep(1000);
            newsAggregator.Notify(news3);
            Thread.Sleep(1000);
        }
    }
}
