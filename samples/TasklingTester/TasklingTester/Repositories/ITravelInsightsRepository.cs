﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasklingTester
{
    public interface ITravelInsightsRepository
    {
        void Add(IList<TravelInsight> insights);
    }
}
