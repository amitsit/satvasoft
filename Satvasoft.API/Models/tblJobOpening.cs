//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Satvasoft.API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblJobOpening
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; }
        public string JobCode { get; set; }
        public string Loaction { get; set; }
        public Nullable<int> Openings { get; set; }
        public Nullable<int> SalaryRange { get; set; }
        public Nullable<int> ExperienceId { get; set; }
        public string Qualification { get; set; }
        public string ImageUrl { get; set; }
    }
}