using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int MemberID { get; set; }
        public Member Member { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal? FineAmount { get; set; }
    }
}
