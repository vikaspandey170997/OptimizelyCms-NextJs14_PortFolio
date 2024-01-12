using System.ComponentModel.DataAnnotations;

namespace Dexred.OptimizelySaas.Models.Pages
{
    [ContentType
        (DisplayName = "StartPage",
        GUID = "0794c2fe-bd37-49f6-8454-0855548ec9ff",
        Description = "")]
    public class StartPage : PageData
    {
        [Display(
           Name = "Components",
           Description = "Main content area of startpage",
           GroupName = SystemTabNames.Content,
           Order = 1)]
        public virtual ContentArea Components { get; set; }

    }
}
