//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarberShopSalon.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Record
    {
        public int id { get; set; }
        public int Serviceid { get; set; }
        public int Barberid { get; set; }
        public int Clientid { get; set; }
        public System.DateTime DateandTime { get; set; }
        public string Comment { get; set; }
    
        public virtual Barber Barber { get; set; }
        public virtual Service Service { get; set; }
    }
}
