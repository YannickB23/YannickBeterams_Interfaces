using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YannickBeterams_Interfaces.Interfaces
{
    public interface ITransaction
    {
        void ShowTransaction();
        double GetAmount();
        string ShowBankName();
    }
}
