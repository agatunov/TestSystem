//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestSystem.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class FinishedTest
    {
        public int FinishedTestId { get; set; }
        public int TestId { get; set; }
        public int UserId { get; set; }
        public int Points { get; set; }
        public System.TimeSpan Time { get; set; }
        public System.DateTime DateEnd { get; set; }
    
        public virtual Test Test { get; set; }
        public virtual User User { get; set; }
    }
}
