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
    
    public partial class Patient
    {
        public Patient()
        {
            this.Analysis = new HashSet<Analysis>();
        }
    
        public int SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DocrotsID { get; set; }
    
        public virtual ICollection<Analysis> Analysis { get; set; }
        public virtual DOCTORS_1 DOCTORS_1 { get; set; }
    }
}
