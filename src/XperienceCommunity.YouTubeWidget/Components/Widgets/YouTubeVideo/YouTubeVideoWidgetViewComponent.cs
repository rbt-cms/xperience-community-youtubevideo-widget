using System.Text;

using CMS;

using Kentico.PageBuilder.Web.Mvc;

using Microsoft.AspNetCore.Mvc;

using XperienceCommunity.YouTubeWidget.Components.Widgets.YouTubeVideo;

[assembly: AssemblyDiscoverable]
[assembly:
    RegisterWidget(
        identifier: YouTubeVideoWidgetViewComponent.IDENTIFIER,
        viewComponentType: typeof(YouTubeVideoWidgetViewComponent),
        name: "YouTubeVideo Widget",
        propertiesType: typeof(YouTubeVideoWidgetProperties),
        Description = "Widget Enables to insert the video from specified YouTube URL location.",
        IconClass = "icon-brand-youtube")]
namespace XperienceCommunity.YouTubeWidget.Components.Widgets.YouTubeVideo
{
    public class YouTubeVideoWidgetViewComponent : ViewComponent
    {
        public const string IDENTIFIER = "XperienceCommunity.Custom.Widget.YouTubeVideo";
        public Task<IViewComponentResult> InvokeAsync(YouTubeVideoWidgetProperties properties) => Task.FromResult<IViewComponentResult>(View("~/Components/Widgets/YouTubeVideo/_YouTubeVideoWidget.cshtml", new YouTubeVideoWidgetViewModel
        {
            IsVisible = properties.IsVisible,
            VideoTitile = properties.VideoTitle,
            VideoURL = properties.VideoURL,
            Width = properties.Width,
            Height = properties.Height,
            IsShowRelatedVideos = properties.IsShowRelatedVideos,
            IsFullScreen = properties.IsFullScreen,
            IsAutoPlay = properties.IsAutoPlay,
            ContentBefore = properties.ContentBefore,
            ContentAfter = properties.ContentAfter,
            VideoParameters = GetYouTubeVideo(properties.IsShowRelatedVideos, properties.IsAutoPlay)
        }));
        private static string GetYouTubeVideo(bool relVideos, bool autoPlay)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(autoPlay ? "&autoplay=1&mute=1" : string.Empty);
            stringBuilder.Append((!relVideos) ? "&rel=0" : "&rel=1");
            stringBuilder.Append("&enablejsapi=1&version=3");
            return stringBuilder.ToString();
        }
    }
}
