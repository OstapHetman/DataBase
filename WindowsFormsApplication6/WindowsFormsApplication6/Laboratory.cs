//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication6
{
    using System;
    using System.Collections.Generic;
    
    public partial class Laboratory
    {
        public Laboratory()
        {
            this.Engineer_1 = new HashSet<Engineer_1>();
        }
    
        public int ID { get; set; }
        public Nullable<int> C__room { get; set; }
        public string Type_of_research { get; set; }
        public string Who_works { get; set; }
        public Nullable<int> HospitalID { get; set; }
    
        public virtual ICollection<Engineer_1> Engineer_1 { get; set; }
        public virtual Hospital Hospital { get; set; }
        public virtual Type_of_analysis Type_of_analysis { get; set; }
    }
}
