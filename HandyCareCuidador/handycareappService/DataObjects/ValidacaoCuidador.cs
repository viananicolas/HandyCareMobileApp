using Microsoft.Azure.Mobile.Server;

namespace handycareappService.DataObjects
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ValidacaoCuidador")]
    public partial class ValidacaoCuidador:EntityData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ValidacaoCuidador()
        {
            Cuidador = new HashSet<Cuidador>();
        }

        [Column(TypeName = "image")]
        //[Required]
        public byte[] ValDocumento { get; set; }

        public bool ValValidado { get; set; }

        [StringLength(36)]
        public string CorenEnfermeiro { get; set; }

        public virtual CorenEnfermeiro CorenEnfermeiro1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cuidador> Cuidador { get; set; }
    }
}
