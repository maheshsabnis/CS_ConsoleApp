//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CS_EF_Demo_Database_Furst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emp
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public string Designation { get; set; }
        public int DeptNo { get; set; }
    
        public virtual Dept Dept { get; set; }
    }
}