//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExampModelViewController.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personel
    {
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public int departman_id { get; set; }
    
        public virtual Departman Departman { get; set; }
    }
}
