//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Emlak_Sitesi_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web;
    public partial class Resim
    {
        public int ResimID { get; set; }
        public string ResimYolu { get; set; }
        public HttpPostedFileBase yol { get; set; }
        public int ilanID { get; set; }
    }
}