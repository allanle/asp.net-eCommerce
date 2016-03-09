using eCommerce.Contracts.Repositories;
using eCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Services
{
    public class BasketService
    {
        IRepositoryBase<Basket> baskets;
        private IRepositoryBase<Voucher> vouchers;
        private IRepositoryBase<VoucherType> vourcherTypes;
        private IReportsitoryBase<BasketVoucher> basketVouchers;

        public const string BasketSessionName = "eCommerceBasket";

        public BasketService(IRepositoryBase<Basket> baskets, IRepositoryBase<Voucher>, IRepositoryBase<BasketVoucher> basketVouchers, IRepositoryBase<VoucherType> voucherTypes)
        {

        }
    }
}
