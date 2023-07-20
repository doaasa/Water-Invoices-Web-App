using System;
using System.Collections.Generic;

#nullable disable

namespace Water_Invoices_Project.Models
{
    public partial class NwcDefaultSliceValue
    {
        public string NwcDefaultSliceValuesCode { get; set; }
        public string NwcDefaultSliceValuesName { get; set; }
        public int? NwcDefaultSliceValuesCondtion { get; set; }
        public decimal? NwcDefaultSliceValuesWaterPrice { get; set; }
        public decimal? NwcDefaultSliceValuesSanitationPrice { get; set; }
        public string NwcDefaultSliceValuesReasons { get; set; }
    }
}
