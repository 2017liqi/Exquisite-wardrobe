//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NoteTrasmit
    {
        public int NoteTrasmitID { get; set; }
        public string AddContent { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public int UserID { get; set; }
        public int NoteID { get; set; }
    
        public virtual Note Note { get; set; }
        public virtual Users Users { get; set; }
    }
}
