//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Analysis
    {
        public int ID { get; set; }
        public string Type_of_analysis { get; set; }
        public string State_of_analysis { get; set; }
        public Nullable<System.DateTime> Date_created { get; set; }
        public string Author { get; set; }
        public int Patient_SSN { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual Type_of_analysis Type_of_analysis1 { get; set; }
    }
}
