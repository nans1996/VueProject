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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ProductList = new HashSet<ProductList>();
        }
    
        public int Id { get; set; }
        public string Identificator { get; set; }
        public string Name { get; set; }
        public int Id_category { get; set; }
        public int Id_supplier { get; set; }
        public string Country { get; set; }
        public Nullable<int> Number { get; set; }
        public decimal Price { get; set; }
        public string Accounting_date { get; set; }
        public string Info { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductList> ProductList { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
