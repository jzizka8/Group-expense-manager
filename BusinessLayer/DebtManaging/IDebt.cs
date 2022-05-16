using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.DebtManaging
{
    public interface IDebt
    {
        public User Debtor { get;  }
        public User Payee { get;  }
        public decimal Amount { get; }
    }
}
