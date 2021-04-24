﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinanceManager.Client.Properties
{
    public static class Constants
    {
        // 10 seconds to get response from api call
        public const int ApiTimeOut = 10000;

        public const int MonthsInYear = 12;
        public static IReadOnlyList<string> Months { get; } = new ReadOnlyCollection<string>(new[]
        {
            "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
        });
    }
}
