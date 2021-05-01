using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes.Itearator
{
    public interface Iterator
    {
        Object next();
        bool hastNext();
    }
}
