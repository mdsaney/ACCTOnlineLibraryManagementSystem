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
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.Borrows = new HashSet<Borrow>();
        }
    
        public int BookID { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public string Publication { get; set; }
        public string Description { get; set; }
        public System.DateTime EntryAt { get; set; }
        public string ISBN { get; set; }
        public string FileName { get; set; }
        public Nullable<int> ImageSize { get; set; }
        public byte[] ImageData { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Borrow> Borrows { get; set; }
    }
}
