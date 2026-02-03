using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Module4.Pages;

public class IndexModel : PageModel
{
    // attributes are variables that describe the class
    // they hold data for that class

    [BindProperty]
    public string[] Shows { get;set; } = new string[3];
    public string[] SampleShows {get;set;}
    public bool ShowResults {get;set;} = false;
    //method that is called when 
    //homepage index.cshtml is initially displayed


    public void OnGet()
    {
        SampleShows = new string[] {"A Christmas Carol", "Hamlet", "The Crucible"};
    }



    //method called when user clicks submit button on form
    public IActionResult OnPost() 
    {
        // initialize sample shows array
        // so it has the same values as it did in the OnGet() method
        // so we can display the same sample shows
        SampleShows = new string[] {"A Christmas Carol", "Hamlet", "The Crucible"};

        // set the show results to true so the values the user entered
        // are displayed on web page in our GUI
        ShowResults = true;

        //return the page that is displayed (that is the IActionResult object)
        return Page();

    }   // end OnPost method
}   // end class
