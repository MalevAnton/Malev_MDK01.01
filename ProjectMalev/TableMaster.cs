//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectMalev
{
    using System;
    using System.Collections.Generic;
    
    public partial class TableMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TableMaster()
        {
            this.MasterPhoto = new HashSet<MasterPhoto>();
            this.TableApplication = new HashSet<TableApplication>();
        }
    
        public int idMaster { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Fatherland { get; set; }
        public System.DateTime Birthday { get; set; }
        public string Login { get; set; }
        public int Password { get; set; }
        public int idGender { get; set; }
        public int idRole { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MasterPhoto> MasterPhoto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TableApplication> TableApplication { get; set; }
        public virtual TableGender TableGender { get; set; }
        public virtual TableRole TableRole { get; set; }
    }
}
