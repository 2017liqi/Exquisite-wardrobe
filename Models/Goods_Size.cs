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
    
    public partial class Goods_Size
    {
        public int Goods_SizeID { get; set; }
        public int StorageAmount { get; set; }
        public string GoodsImage { get; set; }
        public int GoodsID { get; set; }
        public int SizeID { get; set; }
    
        public virtual Goods Goods { get; set; }
        public virtual Size Size { get; set; }
    }
}
