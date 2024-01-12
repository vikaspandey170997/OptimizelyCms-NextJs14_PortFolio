using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dexred.OptimizelySaas.Models.Blocks
{
    [ContentType(
        DisplayName = "Footer",
        GUID = "1fce9b7e-3eba-4bf9-9cbf-018198030ba9",
        Description = "")]
    public class Footer : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "FooterItems",
            Description = "Add footer item here",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual ContentArea FooterItems { get; set; }

    }
}