//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dispatcher
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipments()
        {
            this.CertificateEquipment = new HashSet<CertificateEquipment>();
            this.OperationHistory = new HashSet<OperationHistory>();
        }
    
        public int IDEquipment { get; set; }
        public string InventoryNumber { get; set; }
        public string Name { get; set; }
        public string Destiny { get; set; }
        public Nullable<int> Room { get; set; }
        public Nullable<int> District { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Routing { get; set; }
        public Nullable<int> CertificationPeriod { get; set; }
        public Nullable<int> Capacity { get; set; }
        public Nullable<int> Lenght { get; set; }
        public Nullable<int> Width { get; set; }
        public Nullable<int> Height { get; set; }
        public Nullable<int> Weight { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CertificateEquipment> CertificateEquipment { get; set; }
        public virtual EquipmentStatus EquipmentStatus { get; set; }
        public virtual Rooms Rooms { get; set; }
        public virtual Routing Routing1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationHistory> OperationHistory { get; set; }
    }
}