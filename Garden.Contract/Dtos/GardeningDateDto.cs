﻿using MyGarden.GardenKnowledge.Domain;
using System.Collections.Generic;

namespace Garden.Contract.Dtos
{
    public class GardeningDateDto
    {
        public IEnumerable<Month> Months { get; set; }

        public IEnumerable<Season> Seasons { get; set; }

        public DurationDto Duration { get; set;  }
    }

    public class DurationDto
    {
        public int Quantity { get; set; }
        public TimeUnit TimeUnit { get; set; }
    }
}
