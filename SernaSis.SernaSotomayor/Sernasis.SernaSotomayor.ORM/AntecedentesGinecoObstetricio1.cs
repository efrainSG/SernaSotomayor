//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sernasis.SernaSotomayor.ORM
{
    using System;
    using System.Collections.Generic;
    
    public partial class AntecedentesGinecoObstetricio1
    {
        public int Id { get; set; }
        public int IdHistoria { get; set; }
        public Nullable<System.DateTime> FUR { get; set; }
        public Nullable<System.DateTime> Papanicolaou { get; set; }
        public Nullable<System.DateTime> Mastografia { get; set; }
        public int IdCatalogo { get; set; }
    
        public virtual Catalogo Catalogo { get; set; }
        public virtual HistoriaClinica HistoriaClinica { get; set; }
    }
}
