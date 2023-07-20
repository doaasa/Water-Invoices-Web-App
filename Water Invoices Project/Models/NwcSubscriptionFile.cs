using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Water_Invoices_Project.Models
{
    public partial class NwcSubscriptionFile
    {
        public NwcSubscriptionFile()
        {
            NwcInvoices = new HashSet<NwcInvoice>();
        }

        public string NwcSubscriptionFileNo { get; set; }
        public string NwcSubscriptionFileSubscriberCode { get; set; }
        public string NwcSubscriptionFileRrealEstateTypesCode { get; set; }
        public decimal? NwcSubscriptionFileUnitNo { get; set; }
        public bool? NwcSubscriptionFileIsThereSanitation { get; set; }
        public decimal? NwcSubscriptionFileLastReadingMeter { get; set; }
        public string NwcSubscriptionFileReasons { get; set; }

        [NotMapped]
        public int M { get; set; }

        [NotMapped]
        public string SubscriberName { get; set; }

        [NotMapped]
        public string Type { get; set; }

        [NotMapped]
        public string Phone { get; set; }

        [NotMapped]
        public string YesorNo { get; set; }

        public virtual NwcRrealEstateType NwcSubscriptionFileRrealEstateTypesCodeNavigation { get; set; }
        public virtual NwcSubscriberFile NwcSubscriptionFileSubscriberCodeNavigation { get; set; }
        public virtual ICollection<NwcInvoice> NwcInvoices { get; set; }
    }
}
