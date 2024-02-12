using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class Notification
    {
        public int NotificationID { get; set; }
        public int MemberID { get; set; }
        public Member Member { get; set; }
        public string NotificationType { get; set; }
        public DateTime NotificationDate { get; set; }
        public string Message { get; set; }
    }
}
