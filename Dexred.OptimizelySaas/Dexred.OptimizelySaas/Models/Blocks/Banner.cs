using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dexred.OptimizelySaas.Models.Blocks
{
    [ContentType(
        DisplayName = "Banner",
        GUID = "f1aa5772-331c-4afa-ab85-f9701e19ebe7",
        Description = "")]
    public class Banner : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Description",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual string Description { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Action",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual string ActionText { get; set; }
    }
}