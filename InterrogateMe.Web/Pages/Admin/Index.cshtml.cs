using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterrogateMe.Core.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterrogateMe.Web.Pages.Admin
{
    public class IndexModel : PageModel
    {
        #region Private Variables
        private readonly IRepository _repository;

        #endregion
        public IndexModel(IRepository repository)
        {
            _repository = repository;
        }

        public void OnGet()
        {

        }
    }
}