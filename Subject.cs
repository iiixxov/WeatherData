using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Subject
    {
        void regObserver(Observer o);
        void removeObserver(Observer o);
        void notifyObservers();
    }
}
