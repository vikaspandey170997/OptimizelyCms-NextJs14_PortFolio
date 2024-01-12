using System.ComponentModel.DataAnnotations;

namespace Dexred.OptimizelySaas.Models.Pages
{
    [ContentType
        (DisplayName = "About",
        GUID = "4e017da2-e029-4960-9ac5-687d91a997a8",
        Description = "")]
    public class About : PageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "this a mainbody of about page",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}
