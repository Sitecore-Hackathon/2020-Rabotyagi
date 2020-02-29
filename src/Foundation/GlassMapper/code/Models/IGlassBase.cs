using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Globalization;

namespace Hackathon.Foundation.GlassMapper.Models
{
    public interface IGlassBase
    {
        [SitecoreId]
        Guid Id { get; set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        Language Language { get; set; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; set; }

        [SitecoreInfo(SitecoreInfoType.BaseTemplateIds)]
        IEnumerable<Guid> BaseTemplateIds { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        string TemplateName { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        Guid TemplateId { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        string ItemName { get; set; }
    }
}