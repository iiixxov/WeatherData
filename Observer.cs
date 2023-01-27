using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface Observer
    {
        void update(float temperature, float humidity, float pressure);
    }
}
