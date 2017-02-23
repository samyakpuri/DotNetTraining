//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeManagementLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project
    {
        public Project()
        {
            this.Employees = new HashSet<Employee>();
        }
    
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public short ProjectStatus { get; set; }
        public int ProjectManager { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.DateTime UpdateDate { get; set; }
    
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Status Status { get; set; }
    }
}