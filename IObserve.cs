using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface IObserver<TypeDefinition>
    {
        void updater(TypeDefinition data); // Метод будет вызываться когда наблюдатель будет получать уведомление 

    }
}
