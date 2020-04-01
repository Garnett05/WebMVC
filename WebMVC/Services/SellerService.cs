using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Data;
using WebMVC.Models;

namespace WebMVC.Services
{
    public class SellerService
    {
        private readonly WebMVCContext _context;

        public SellerService(WebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
