//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CursoMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Nullable<int> idState { get; set; }
        public Nullable<int> edad { get; set; }
        public string token_recovery { get; set; }
        public Nullable<System.DateTime> date_created { get; set; }
    
        public virtual cstate cstate { get; set; }
    }
}