using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slidex.Services
{
    public interface INotificationService
    {
        void Notify(string message, string title);
    }
}
