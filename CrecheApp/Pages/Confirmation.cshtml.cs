using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrecheApp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CrecheApp.Pages
{
    public class ConfirmationModel : PageModel
    {
        private readonly ChildContext _context;

        public ConfirmationModel(ChildContext context)
        {
            _context = context;
        }
        public IList<Child> Child { get; set; }
        public string Message { get; private set; }
        public string Cost { get; private set; }
        public async Task OnGetAsync()
        {
            Child = await _context.Children.ToListAsync();
            //retrieve last child data entered to DB
            Child C = Child.Last();

            // output message to confirmation page
            Message = string.Format("Thank you! You have chosen {0} days {1} day care.",
                C.DaysRequested, C.FullOrPart);
            //output calculation to confirmation page
            Cost = string.Format("The fee for this service is €{0} per week", GetCost(C.FullOrPart, C.DaysRequested));
        }
        //costing calculation
        private decimal GetCost(string FullorPart, int days)
        {
            decimal cost = 0, partTime = 20m, fullTime = 35m;
            decimal numDays = days;
            //Check if 10% discount applies to more than 3 days selected
            if (days > 3)
            {
                {
                    if (FullorPart == "parttime")
                    {
                        cost = ((partTime * numDays) * 90) / 100;
                    }

                    else if (FullorPart == "fulltime")
                    {
                        cost = ((fullTime * numDays) * 90) / 100;
                    }
                }
            }
            else if (FullorPart == "fulltime")
            {
                cost = numDays * fullTime;
            }

            else if (FullorPart == "parttime")
            {
                cost = numDays * partTime;
            }

            return cost;

        }
    }


}