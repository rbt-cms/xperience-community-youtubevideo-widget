using Microsoft.AspNetCore.Mvc.ViewComponents;

using XperienceCommunity.YouTubeWidget.Components.Widgets.YouTubeVideo;

namespace XperienceCommunity.YouTubeWidget.Tests.Components.Widgets.YouTubeVideo
{
    [TestFixture]
    public class YouTubeVideoWidgetViewComponentTests
    {
        private YouTubeVideoWidgetViewComponent component;

        [SetUp]
        public void Setup() => component = new YouTubeVideoWidgetViewComponent();

        [Test]
        public void InvokeAsync_WithValidProperties_ReturnsViewResult()
        {
            // Arrange
            var properties = new YouTubeVideoWidgetProperties
            {
                IsVisible = true,
                VideoTitle = "Test Video",
                VideoURL = "https://www.youtube.com/watch?v=test123",
                Width = "640",
                Height = "360",
                IsShowRelatedVideos = true,
                IsFullScreen = true,
                IsAutoPlay = false,
                ContentBefore = "Before content",
                ContentAfter = "After content"
            };

            // Act
            var result = component.InvokeAsync(properties).Result;

            // Assert
            Assert.That(result, Is.InstanceOf<ViewViewComponentResult>());
            var viewResult = (ViewViewComponentResult)result;

            Assert.That(viewResult.ViewName, Is.EqualTo("~/Components/Widgets/YouTubeVideo/_YouTubeVideoWidget.cshtml"));
        }

        [Test]
        public void GetYouTubeVideo_WithAutoPlayAndRelatedVideos_ReturnsCorrectParameters()
        {
            // Arrange
            bool relVideos = true;
            bool autoPlay = true;

            // Act
            string result = YouTubeVideoWidgetViewComponent.GetYouTubeVideo(relVideos, autoPlay);

            // Assert
            Assert.That(result, Is.EqualTo("&autoplay=1&mute=1&rel=1&enablejsapi=1&version=3"));
        }

        [Test]
        public void GetYouTubeVideo_WithoutAutoPlayAndRelatedVideos_ReturnsCorrectParameters()
        {
            // Arrange
            bool relVideos = false;
            bool autoPlay = false;

            // Act
            string result = YouTubeVideoWidgetViewComponent.GetYouTubeVideo(relVideos, autoPlay);

            // Assert
            Assert.That(result, Is.EqualTo("&rel=0&enablejsapi=1&version=3"));
        }

        [Test]
        public void GetYouTubeVideo_WithAutoPlayWithoutRelatedVideos_ReturnsCorrectParameters()
        {
            // Arrange
            bool relVideos = false;
            bool autoPlay = true;

            // Act
            string result = YouTubeVideoWidgetViewComponent.GetYouTubeVideo(relVideos, autoPlay);

            // Assert
            Assert.That(result, Is.EqualTo("&autoplay=1&mute=1&rel=0&enablejsapi=1&version=3"));
        }

        [Test]
        public void GetYouTubeVideo_WithoutAutoPlayWithRelatedVideos_ReturnsCorrectParameters()
        {
            // Arrange
            bool relVideos = true;
            bool autoPlay = false;

            // Act
            string result = YouTubeVideoWidgetViewComponent.GetYouTubeVideo(relVideos, autoPlay);

            // Assert
            Assert.That(result, Is.EqualTo("&rel=1&enablejsapi=1&version=3"));
        }
    }
}
