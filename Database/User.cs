//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KFC.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    
        public virtual Role Role1 { get; set; }
    }
}