﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public interface ISortStrategy
    {
        void Sort(List<string> list);
    }
}
