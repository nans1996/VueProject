//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductList
    {
        public int Id { get; set; }
        public int Id_product { get; set; }
        public int Id_selling { get; set; }
        public int Number { get; set; }
    
        public virtual Selling Selling { get; set; }
        public virtual Product Product { get; set; }
    }
}
