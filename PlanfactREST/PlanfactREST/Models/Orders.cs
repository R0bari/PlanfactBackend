//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlanfactREST.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        public int order_id { get; set; }
        public int sum { get; set; }
        public System.DateTime date_time { get; set; }
        public string status { get; set; }
        public int client_id { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
