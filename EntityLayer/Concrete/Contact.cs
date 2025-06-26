using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Contact
	{
        [Key]
        public int ContectID { get; set; }

		[StringLength(100)]
		public string UserName { get; set; }

		[StringLength(50)]
		public string UserMail { get; set; }

		[StringLength(50)]
		public string Subject { get; set; }

        public string Message { get; set; }

        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; } // Navigation property to Heading

        //public DateTime MessageDate { get; set; }
        //public bool Status { get; set; } // true for read, false for unread
        //public string UserPhone { get; set; } // Added phone number property
        //public string UserImage { get; set; } // Added user image property
        //public string UserSurname { get; set; } // Added user surname property
        //public string UserTitle { get; set; } // Added user title property
        //public string UserAddress { get; set; } // Added user address property
        //public string UserCity { get; set; } // Added user city property
        //public string UserCountry { get; set; } // Added user country property
        //public string UserState { get; set; } // Added user state property
        //public string UserZipCode { get; set; } // Added user zip code property
        //public string UserCompany { get; set; } // Added user company property
        //public string UserWebsite { get; set; } // Added user website property
        //public string UserSocialMedia { get; set; } // Added user social media property
        //public string UserNotes { get; set; } // Added user notes property
        //public string UserEmail { get; set; } // Added user email property
        //public string UserFax { get; set; } // Added user fax property
        //public string UserDepartment { get; set; } // Added user department property
        //public string UserPosition { get; set; } // Added user position property
        //public string UserLanguage { get; set; } // Added user language property
        //public string UserTimezone { get; set; } // Added user timezone propert
    }
}
