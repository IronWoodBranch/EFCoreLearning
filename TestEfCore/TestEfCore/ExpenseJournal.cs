using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEfCore
{
    public class ExpenseJournal
    {
        public int Id { get; set; }
        public required string JournalName { get; set; }
        public int UserID { get; set; }
    }
}
