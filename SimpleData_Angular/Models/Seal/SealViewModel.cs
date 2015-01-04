using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleData_Angular.Models.Seal
{
	public class SealViewModel
	{
		public Guid SealGuid { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public Guid? PhotoGuid { get; set; }
		public bool IsActive { get; set; }
	}
}