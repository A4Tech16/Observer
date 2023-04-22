using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IObservable<TypeDefinition>
    {
        void Subscribe(IObserver<TypeDefinition> observer); //      
        void unSubscribe(IObserver<TypeDefinition> observer);
        void Notify(TypeDefinition data ); //       Уведомление 
    }
}
