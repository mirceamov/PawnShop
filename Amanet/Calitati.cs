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
    
    public partial class Calitati
    {
        public Calitati()
        {
            this.ContracteProduses = new HashSet<ContracteProduse>();
        }
    
        public int id { get; set; }
        public string denumire { get; set; }
        public System.DateTime creatLa { get; set; }
        public System.DateTime modificatLa { get; set; }
        public bool inactiv { get; set; }
        public int lockVersion { get; set; }
    
        public virtual ICollection<ContracteProduse> ContracteProduses { get; set; }
    }
}
