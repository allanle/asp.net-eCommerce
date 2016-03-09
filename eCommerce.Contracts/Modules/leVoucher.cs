using eCommerce.Contracts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Contracts.Modules
{
    public interface leVoucher
    {
        void ProcessVoucher(IVoucher voucher, IBasket basket, IBasketVoucher basketVoucher);
    }
}
