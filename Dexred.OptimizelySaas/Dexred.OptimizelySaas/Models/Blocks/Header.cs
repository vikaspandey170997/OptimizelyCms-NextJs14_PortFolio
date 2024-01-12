using EPiServer.SpecializedProperties;
using System.ComponentModel.DataAnnotations;

namespace Dexred.OptimizelySaas.Models.Blocks
{
    [ContentType
        (DisplayName = "Header",
        GUID = "972e1953-1edf-48d3-a191-476304adc80d",
        Description = "")]
    public class Header : BlockData
    {
        [Display(
        Name = "SpanText",
        Description = "Add text here",
        GroupName = SystemTabNames.Content,
        Order = 1)]
        public virtual string SpanText { get; set; }

        [Display(
        Name = "Icon",
        Description = "Name field's description",
        GroupName = SystemTabNames.Content,
        Order = 1)]
        public virtual ContentReference Icon { get; set; }

        [CultureSpecific]
        [Display(
        Name = "MenuItems",
        Description = "Name field's description",
        GroupName = SystemTabNames.Content,
        Order = 1)]
        public virtual LinkItemCollection MenuItems { get; set; }

    }
}