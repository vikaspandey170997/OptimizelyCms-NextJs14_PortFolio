using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dexred.OptimizelySaas.Models.Blocks
{
    [ContentType(
        DisplayName = "FooterColumnOne",
        GUID = "7a698252-696a-435e-bb23-a6e007554033", 
        Description = "")]
    public class FooterColumnOne : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Address",
            Description = "Add address here",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Address { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Contact",
            Description = "Add address here",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual LinkItem Contact { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Email",
            Description = "Add email here",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual LinkItem Email { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Title",
           Description = "Add title here",
           GroupName = SystemTabNames.Content,
           Order = 40)]
        public virtual string Title { get; set; }

    }
}