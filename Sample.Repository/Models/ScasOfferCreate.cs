using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ScasOfferCreate
    {
        public string ScasOrgUnitCode { get; set; }
        public string ScasEnrolmentTypeCode { get; set; }
        public decimal ScasNumClass { get; set; }
        public decimal ScasEnrolmentTypeCapacity { get; set; }
        public decimal MaxPlaces { get; set; }
    }
}
