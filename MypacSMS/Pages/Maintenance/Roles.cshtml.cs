using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MypacSMS.Models;
using MypacSMS.Data;

namespace MypacSMS.Pages.Maintenance
{
    public class RolesModel : PageModel
    {
        private readonly MypacSMSContext _context;

        public RolesModel(MypacSMSContext context)
        {
            _context = context;
        }

        public IList<AspNetRoles> AspNetRoles { get; set; }
        public IQueryable<AspNetRoles> Roles { get; set; }
        
        public void OnGet()
        {
            Roles = _context.Set<AspNetRoles>() ;
        }

    }
}