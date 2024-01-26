using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UralAjans3.Models;

namespace UralAjans3.MVVM
{
    public class MainPageModel
    {
        public List<Employees> employeeList_name { get; set; }
        public List<Employees> employeeList_role { get; set; }
        public List<Employees> employeeList_photo { get; set; }

        public string SenderName { get; set; }
        public string CompanyName { get; set; }
        public string Message { get; set; }
    }
}