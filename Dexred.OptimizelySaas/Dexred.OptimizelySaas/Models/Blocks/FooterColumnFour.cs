using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dexred.OptimizelySaas.Models.Blocks
{
    [ContentType(
        DisplayName = "FooterColumnFour",
        GUID = "5b698f78-7e50-4a58-b483-d83a3d63a5aa",
        Description = "")]
    public class FooterColumnFour : BlockData
    {

        [CultureSpecific]
        [Display(
        Name = "Title",
        Description = "add title text here",
        GroupName = SystemTabNames.Content,
        Order = 10)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
        Name = "ButtonText",
        Description = "add text here",
        GroupName = SystemTabNames.Content,
        Order = 20)]
        public virtual string ButtonText { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Logos",
        Description = "add text here",
        GroupName = SystemTabNames.Content,
        Order = 30)]
        public virtual IList<ContentReference> Logos { get; set; }

        [CultureSpecific]
        [Display(
        Name = "ActionText",
        Description = "add text here",
        GroupName = SystemTabNames.Content,
        Order = 40)]
        public virtual string ActionText { get; set; }
    }
}