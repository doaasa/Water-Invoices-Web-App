using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Water_Invoices_Project.Models
{
    public partial class NwcSubscriberFile
    {
        public NwcSubscriberFile()
        {
            NwcInvoices = new HashSet<NwcInvoice>();
            NwcSubscriptionFiles = new HashSet<NwcSubscriptionFile>();
        }

        public string NwcSubscriberFileId { get; set; }
        public string NwcSubscriberFileName { get; set; }
        public string NwcSubscriberFileCity { get; set; }
        public string NwcSubscriberFileArea { get; set; }
        public string NwcSubscriberFileMobile { get; set; }
        public string NwcSubscriberFileReasons { get; set; }
       
        [NotMapped]
        public int M { get; set; }
        
        [NotMapped]
        public int Counter { get; set; }
        public virtual ICollection<NwcInvoice> NwcInvoices { get; set; }
        public virtual ICollection<NwcSubscriptionFile> NwcSubscriptionFiles { get; set; }
    }
}
