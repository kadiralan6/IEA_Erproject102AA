//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IEA_Erproject102AA_Main.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDepartmanlar
    {
        public int Id { get; set; }
        public Nullable<int> GrupId { get; set; }
        public string DeptAdi { get; set; }
        public Nullable<bool> isActive { get; set; }
    
        public virtual tblCariGruplari tblCariGruplari { get; set; }
    }
}
