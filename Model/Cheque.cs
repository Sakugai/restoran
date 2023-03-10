//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restoran.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cheque
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cheque()
        {
            this.ChequePosition = new HashSet<ChequePosition>();
        }
    
        public int ChequeId { get; set; }
        public string Title { get; set; }
        public decimal TotalCost { get; set; }
        public bool IsClosed { get; set; }
        public System.DateTime OpeningDate { get; set; }
        public int WaiterId { get; set; }
        public int TableId { get; set; }
    
        public virtual Table Table { get; set; }
        public virtual Waiter Waiter { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChequePosition> ChequePosition { get; set; }
    }
}
