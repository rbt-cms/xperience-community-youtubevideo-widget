using XperienceCommunity.YouTubeWidget.Components.Widgets.YouTubeVideo;

namespace XperienceCommunity.YouTubeWidget.Tests.Components.Widgets.YouTubeVideo
{
    [TestFixture]
    public class YouTubeVideoWidgetViewModelTests
    {
        private YouTubeVideoWidgetViewModel viewModel;

        [SetUp]
        public void Setup() => viewModel = new YouTubeVideoWidgetViewModel();

        [Test]
        public void DefaultValues_ShouldBeSetCorrectly()
        {
            // Assert
            Assert.That(viewModel.IsVisible, Is.False);
            Assert.That(viewModel.VideoURL, Is.Null);
            Assert.That(viewModel.VideoTitile, Is.Null);
            Assert.That(viewModel.Width, Is.Null);
            Assert.That(viewModel.Height, Is.Null);
            Assert.That(viewModel.IsShowRelatedVideos, Is.False);
            Assert.That(viewModel.IsFullScreen, Is.False);
            Assert.That(viewModel.IsAutoPlay, Is.False);
            Assert.That(viewModel.VideoParameters, Is.Null);
            Assert.That(viewModel.ContentBefore, Is.Null);
            Assert.That(viewModel.ContentAfter, Is.Null);
        }

        [Test]
        public void Properties_ShouldSetAndGetCorrectly()
        {
            // Arrange
            const string videoUrl = "https://www.youtube.com/watch?v=test123";
            const string videoTitle = "Test Video";
            const string width = "640";
            const string height = "360";
            const string videoParameters = "autoplay=1";
            const string contentBefore = "Before content";
            const string contentAfter = "After content";

            // Act
            viewModel.IsVisible = true;
            viewModel.VideoURL = videoUrl;
            viewModel.VideoTitile = videoTitle;
            viewModel.Width = width;
            viewModel.Height = height;
            viewModel.IsShowRelatedVideos = true;
            viewModel.IsFullScreen = true;
            viewModel.IsAutoPlay = true;
            viewModel.VideoParameters = videoParameters;
            viewModel.ContentBefore = contentBefore;
            viewModel.ContentAfter = contentAfter;

            // Assert
            Assert.That(viewModel.IsVisible, Is.True);
            Assert.That(viewModel.VideoURL, Is.EqualTo(videoUrl));
            Assert.That(viewModel.VideoTitile, Is.EqualTo(videoTitle));
            Assert.That(viewModel.Width, Is.EqualTo(width));
            Assert.That(viewModel.Height, Is.EqualTo(height));
            Assert.That(viewModel.IsShowRelatedVideos, Is.True);
            Assert.That(viewModel.IsFullScreen, Is.True);
            Assert.That(viewModel.IsAutoPlay, Is.True);
            Assert.That(viewModel.VideoParameters, Is.EqualTo(videoParameters));
            Assert.That(viewModel.ContentBefore, Is.EqualTo(contentBefore));
            Assert.That(viewModel.ContentAfter, Is.EqualTo(contentAfter));
        }

        [Test]
        public void Properties_ShouldHandleInvalidValuesCorrectly()
        {
            // Arrange
            const string emptyString = "";
            const string whitespaceString = "   ";
            const string invalidUrl = "not-a-valid-url";
            const string negativeWidth = "-100";
            const string negativeHeight = "-50";
            const string zeroWidth = "0";
            const string zeroHeight = "0";

            // Act
            viewModel.VideoURL = invalidUrl;
            viewModel.VideoTitile = emptyString;
            viewModel.Width = negativeWidth;
            viewModel.Height = negativeHeight;
            viewModel.VideoParameters = whitespaceString;
            viewModel.ContentBefore = emptyString;
            viewModel.ContentAfter = whitespaceString;

            // Assert
            Assert.That(viewModel.VideoURL, Is.EqualTo(invalidUrl), "Should accept invalid URL");
            Assert.That(viewModel.VideoTitile, Is.EqualTo(emptyString), "Should accept empty string");
            Assert.That(viewModel.Width, Is.EqualTo(negativeWidth), "Should accept negative width");
            Assert.That(viewModel.Height, Is.EqualTo(negativeHeight), "Should accept negative height");
            Assert.That(viewModel.VideoParameters, Is.EqualTo(whitespaceString), "Should accept whitespace string");
            Assert.That(viewModel.ContentBefore, Is.EqualTo(emptyString), "Should accept empty string");
            Assert.That(viewModel.ContentAfter, Is.EqualTo(whitespaceString), "Should accept whitespace string");

            // Test with zero dimensions
            viewModel.Width = zeroWidth;
            viewModel.Height = zeroHeight;
            Assert.That(viewModel.Width, Is.EqualTo(zeroWidth), "Should accept zero width");
            Assert.That(viewModel.Height, Is.EqualTo(zeroHeight), "Should accept zero height");
        }
    }
}
