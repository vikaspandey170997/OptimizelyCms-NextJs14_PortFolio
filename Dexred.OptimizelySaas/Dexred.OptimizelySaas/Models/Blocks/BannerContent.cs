using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dexred.OptimizelySaas.Models.Blocks
{
    [ContentType(
        DisplayName = "BannerContent",
        GUID = "7f7a91e9-5756-4cdd-8b70-41982afd3bfd",
        Description = "")]
    public class BannerContent : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Content",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual ContentArea Content { get; set; }

    }
}