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
    
    public partial class Answer
    {
        public int AnswerId { get; set; }
        public string Content { get; set; }
        public int QuestionId { get; set; }
        public bool Right { get; set; }
    
        public virtual Question Question { get; set; }
    }
}
