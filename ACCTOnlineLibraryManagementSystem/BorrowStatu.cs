//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACCTOnlineLibraryManagementSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class BorrowStatu
    {
        public int BorrowStatusID { get; set; }
        public int BorrowID { get; set; }
        public Nullable<int> TotalFine { get; set; }
        public Nullable<int> NumberOfBooksBorrowed { get; set; }
    
        public virtual Borrow Borrow { get; set; }
    }
}
