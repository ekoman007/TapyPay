﻿using SharedKernel; 

namespace Analytics.Domain.Aggregates.AnalyticsAggregates
{
    // Statistika për aktivitetin e përdoruesve
    public class UserActivityAnalytics : AggregateRoot<int>
    {
        public string TenantId { get; set; }
        public DateTime Date { get; set; }
        public int NewUsersCount { get; set; }
        public int ActiveUsersCount { get; set; }
    }
}
