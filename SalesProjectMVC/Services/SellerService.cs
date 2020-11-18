﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesProjectMVC.Models;

namespace SalesProjectMVC.Services
{
    public class SellerService
    {
        private readonly SalesProjectMVCContext _context;

        public SellerService(SalesProjectMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
