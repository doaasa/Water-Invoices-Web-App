using System;
using System.Collections.Generic;

#nullable disable

namespace Water_Invoices_Project.Models
{
    public partial class NwcRrealEstateType
    {
        public NwcRrealEstateType()
        {
            NwcInvoices = new HashSet<NwcInvoice>();
            NwcSubscriptionFiles = new HashSet<NwcSubscriptionFile>();
        }

        public string NwcRrealEstateTypesCode { get; set; }
        public string NwcRrealEstateTypesName { get; set; }
        public string NwcRrealEstateTypesReasons { get; set; }

        public virtual ICollection<NwcInvoice> NwcInvoices { get; set; }
        public virtual ICollection<NwcSubscriptionFile> NwcSubscriptionFiles { get; set; }
    }
}
