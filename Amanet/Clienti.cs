//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Amanet
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clienti
    {
        public Clienti()
        {
            this.ContracteAntets = new HashSet<ContracteAntet>();
        }
    
        public int id { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string domiciliul { get; set; }
        public string ciSerie { get; set; }
        public string ciNumar { get; set; }
        public string ciEliberatDe { get; set; }
        public Nullable<System.DateTime> ciEliberatLa { get; set; }
        public string telefon { get; set; }
        public System.DateTime creatLa { get; set; }
        public System.DateTime modificatLa { get; set; }
        public bool inactiv { get; set; }
        public int lockVersion { get; set; }
    
        public virtual ICollection<ContracteAntet> ContracteAntets { get; set; }
    }
}