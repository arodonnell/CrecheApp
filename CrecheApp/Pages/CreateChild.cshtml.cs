using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrecheApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.IdentityModel.Tokens;

namespace CrecheApp.Pages
{
    public class CreateChildModel : PageModel
    {
        private readonly ChildContext _db;

        public CreateChildModel(ChildContext db)
        {
            _db = db;
        }

        [BindProperty]

        public Child Child { get; set; } = new Child();


        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {   //Find number of days selected from individual bool days
                bool[] selectDays = {Child.Monday, Child.Tuesday, Child.Wednesday, Child.Thursday, Child.Friday};

                Child.DaysRequested = GetDays(selectDays);
                //add student tot he DB
                _db.Children.Add(Child);
                await _db.SaveChangesAsync();
                return RedirectToPage("ListChild");
            }
            else
            {
                return Page();
            }
        }
        //count number of days selecte with loop method
        private int GetDays(bool[] days)
        {
            int daysselected = 0;
            for (int i = 0; i < 5; i++)
            {
                if (days[i] == true)
                {
                    daysselected++;
                }
            }
            return daysselected;
        }
    }
}