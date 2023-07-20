using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Water_Invoices_Project.Models
{
    public partial class NwcInvoice
    {
        public string NwcInvoicesNo { get; set; }
        public string NwcInvoicesYear { get; set; }
        public string NwcInvoicesRrealEstateTypes { get; set; }
        public string NwcInvoicesSubscriptionNo { get; set; }
        public string NwcInvoicesSubscriberNo { get; set; }
        public DateTime? NwcInvoicesDate { get; set; }
        public DateTime? NwcInvoicesFrom { get; set; }
        public DateTime? NwcInvoicesTo { get; set; }
        public decimal? NwcInvoicesPreviousConsumptionAmount { get; set; }
        public decimal? NwcInvoicesCurrentConsumptionAmount { get; set; }
        public decimal? NwcInvoicesAmountConsumption { get; set; }
        public decimal? NwcInvoicesServiceFee { get; set; }
        public decimal? NwcInvoicesTaxRate { get; set; }
        public bool? NwcInvoicesIsThereSanitation { get; set; }
        public decimal? NwcInvoicesConsumptionValue { get; set; }
        public decimal? NwcInvoicesWastewaterConsumptionValue { get; set; }
        public decimal? NwcInvoicesTotalInvoice { get; set; }
        public decimal? NwcInvoicesTaxValue { get; set; }
        public decimal? NwcInvoicesTotalBill { get; set; }
        public string NwcInvoicesTotalReasons { get; set; }


        [NotMapped]
        public int M { get; set; }

        [NotMapped]
        public string SubscriberName { get; set; }

        [NotMapped]
        public string Date { get; set; }

        [NotMapped]
        public bool Waste { get; set; }


        [NotMapped]
        public int Unit { get; set; }


        public virtual NwcRrealEstateType NwcInvoicesRrealEstateTypesNavigation { get; set; }
        public virtual NwcSubscriberFile NwcInvoicesSubscriberNoNavigation { get; set; }
        public virtual NwcSubscriptionFile NwcInvoicesSubscriptionNoNavigation { get; set; }
    }
}
