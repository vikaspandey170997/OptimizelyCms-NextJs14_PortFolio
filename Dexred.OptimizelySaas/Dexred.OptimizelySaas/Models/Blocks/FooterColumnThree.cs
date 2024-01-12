using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dexred.OptimizelySaas.Models.Blocks
{
    [ContentType(
        DisplayName = "FooterColumnThree",
        GUID = "5924c010-8d71-413d-ab4b-b4d59bcc26de",
        Description = "")]
    public class FooterColumnThree : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Add text here",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Title { get; set; }

        [Display(
            Name = "Logos",
            Description = "Add images here",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual IList<ContentReference> Logos { get; set; }
    }
}