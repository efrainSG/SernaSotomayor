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
    
    public partial class AntecedentesGinecoObstetricio
    {
        public int IdPaciente { get; set; }
        public Nullable<System.DateTime> Menarca { get; set; }
        public byte G { get; set; }
        public byte P { get; set; }
        public byte C { get; set; }
        public byte A { get; set; }
    
        public virtual Paciente Paciente { get; set; }
    }
}
