using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dexred.OptimizelySaas.Models.Blocks
{
    [ContentType(
        DisplayName = "FooterColumnTwo",
        GUID = "07c73b21-bf40-4ec8-90da-eab95657b49f",
        Description = "")]
    public class FooterColumnTwo : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Add title text here",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Description",
            Description = "Add description text",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string Description { get; set; }

    }
}