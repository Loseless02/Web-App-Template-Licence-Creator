using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace try3.Pages
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using static System.Net.Mime.MediaTypeNames;

    namespace RazorPagesDemo.Pages.Forms
    {
        public class IndexModel : PageModel
        {
            public void OnGet()
            {
            }

            public void OnPostInsert()
            {
                if (!String.IsNullOrEmpty(Gold))
                {
                    //Gold is selected

                    Values.Add(Gold);
                }
                if (!String.IsNullOrEmpty(Silver))
                {
                    //Silver is selected
                    Values.Add(Silver);
                }
                if (!String.IsNullOrEmpty(Green))
                {
                    //Green is selected
                    Values.Add(Green);
                }
                if (!String.IsNullOrEmpty(White))
                {
                    //Black is selected
                    Values.Add(White);
                }
                if (!String.IsNullOrEmpty(Black))
                {
                    //Black is selected
                    Values.Add(Black);
                }
                if (!String.IsNullOrEmpty(Red))
                {
                    //Black is selected
                    Values.Add(Red);
                }
                if (!String.IsNullOrEmpty(test))
                {
                    //Black is selected
                    Values.Add(test);
                }
            }

            [BindProperty]
            public string? Gold { get; set; }
            [BindProperty]
            public string? Silver { get; set; }
            [BindProperty]
            public string? Green { get; set; }
            [BindProperty]
            public string? Black { get; set; }
            [BindProperty]
            public string? White { get; set; }
            [BindProperty]
            public string? Red { get; set; }
            [BindProperty]
            public string? test { get; set; }
            [BindProperty]
            public string? lookup { get; set; }
            [BindProperty]
            public string? hello { get; set; }

            public List<string> Values { get; set; } = new List<string>();
        }
    }


    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            string dateTime = DateTime.Now.ToString("d", new CultureInfo("en-US"));
            ViewData["TimeStamp"] = dateTime;
        }
    }

}
