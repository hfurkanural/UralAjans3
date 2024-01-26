using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UralAjans3.MVVM
{
    public class ContactUs
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageID { get; set; }


        [DisplayName("Adınız"), Required, StringLength(100)]
        public string SenderName { get; set; }


        [DisplayName("Firma Adı"), StringLength(100)]
        public string CompanyName { get; set; }


        [DisplayName("Mesajınız"), Required, StringLength(4000)]
        public string Message { get; set; }
    }
}