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
    
    public partial class VideoComment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VideoComment()
        {
            this.U_Reply_VideoComment = new HashSet<U_Reply_VideoComment>();
        }
    
        public int VideoCommentID { get; set; }
        public string Commentcotent { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public int likenum { get; set; }
        public int UserID { get; set; }
        public int VideoID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<U_Reply_VideoComment> U_Reply_VideoComment { get; set; }
        public virtual Users Users { get; set; }
        public virtual Video Video { get; set; }
    }
}
