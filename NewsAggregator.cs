using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public sealed class NewsAggregator : IObservable<News>
    {
        private readonly List<IObserver<News>> _observers;

        public NewsAggregator()
        {
            _observers = new List<IObserver<News>>();
        }

        public void Notify(News data)
        {
            foreach (IObserver<News> observer in _observers)
            {
                observer.updater(data);
            } 
        }

        public void Subscribe(IObserver<News> observer)
        {
            _observers.Add(observer);
        }

        public void unSubscribe(IObserver<News> observer)
        {
            _observers.Remove(observer);
        }
    }
}
