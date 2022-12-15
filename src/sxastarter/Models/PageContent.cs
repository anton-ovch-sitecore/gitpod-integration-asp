using RenderingHost.Models;
using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace Sitecore.AspNet.Styleguide.Models
{
    public class PageContent
    {
        public RichTextField Content { get; set; } = default!;
    }
}
