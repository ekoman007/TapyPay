﻿using SharedKernel; 

namespace Partner.Domain.Aggregates.PartnerAggregates
{
    public class PartnerAddress : AggregateRoot<int>
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
    }

}
