using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace RenderingHost.Models
{
    public class ContentBlock : HeadingOnly
    {
        public RichTextField Content { get; set; } = default!;
    }
}
