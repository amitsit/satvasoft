﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Satvasoft.API.Entities
{
    public class PortfolioTechnologyEntity
    {
        public int Id { get; set; }
        public string TechnologyText { get; set; }
        public int PortfolioId { get; set; }
    }
}