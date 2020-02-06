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
    
    public partial class Video
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Video()
        {
            this.VideoComment = new HashSet<VideoComment>();
            this.VideoLike = new HashSet<VideoLike>();
            this.VideoSelect = new HashSet<VideoSelect>();
            this.VideoTrasmit = new HashSet<VideoTrasmit>();
        }
    
        public int VideoID { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Intro { get; set; }
        public string Adress { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public Nullable<int> likenum { get; set; }
        public int UserID { get; set; }
    
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VideoComment> VideoComment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VideoLike> VideoLike { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VideoSelect> VideoSelect { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VideoTrasmit> VideoTrasmit { get; set; }
    }
}
