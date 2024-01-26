using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UralAjans3.Models
{
    public class cls_ContactUs
    {
		UralAjansEntities context = new UralAjansEntities();
        public static bool AddMessage(ContactUs contactus)
        {
			try
			{
				using (UralAjansEntities context = new UralAjansEntities())
				{
					contactus.DateTime = DateTime.Now;
					context.ContactUs.Add(contactus);
					context.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
				throw;
			}
        }
    }
}