//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class reportes
    {
        public int codigo { get; set; }
        public string resultados { get; set; }
        public int administradores_codigo { get; set; }
    
        public virtual administradores administradores { get; set; }
    }
}
