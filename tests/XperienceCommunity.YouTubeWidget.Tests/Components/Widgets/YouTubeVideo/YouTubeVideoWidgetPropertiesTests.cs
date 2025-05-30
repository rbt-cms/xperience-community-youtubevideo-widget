using XperienceCommunity.YouTubeWidget.Components.Widgets.YouTubeVideo;


namespace XperienceCommunity.YouTubeWidget.Tests.Components.Widgets.YouTubeVideo
{
    [TestFixture]
    public class YouTubeVideoWidgetPropertiesTests
    {
        private YouTubeVideoWidgetProperties properties;

        [SetUp]
        public void Setup() => properties = new YouTubeVideoWidgetProperties();

        [Test]
        public void IsVisible_DefaultValue_ShouldBeFalse() =>
            // Assert
            Assert.That(properties.IsVisible, Is.False);

        [Test]
        public void VideoTitle_WhenSet_ShouldStoreValue()
        {
            // Arrange
            string expectedTitle = "Test Video Title";

            // Act
            properties.VideoTitle = expectedTitle;

            // Assert
            Assert.That(properties.VideoTitle, Is.EqualTo(expectedTitle));
        }

        [Test]
        public void VideoURL_WhenSet_ShouldStoreValue()
        {
            // Arrange
            string expectedUrl = "https://www.youtube.com/watch?v=test123";

            // Act
            properties.VideoURL = expectedUrl;

            // Assert
            Assert.That(properties.VideoURL, Is.EqualTo(expectedUrl));
        }

        [Test]
        public void Width_WhenSet_ShouldStoreValue()
        {
            // Arrange
            string expectedWidth = "640";

            // Act
            properties.Width = expectedWidth;

            // Assert
            Assert.That(properties.Width, Is.EqualTo(expectedWidth));
        }

        [Test]
        public void Height_WhenSet_ShouldStoreValue()
        {
            // Arrange
            string expectedHeight = "360";

            // Act
            properties.Height = expectedHeight;

            // Assert
            Assert.That(properties.Height, Is.EqualTo(expectedHeight));
        }

        [Test]
        public void IsShowRelatedVideos_DefaultValue_ShouldBeFalse() =>
            // Assert
            Assert.That(properties.IsShowRelatedVideos, Is.False);

        [Test]
        public void IsFullScreen_DefaultValue_ShouldBeFalse() =>
            // Assert
            Assert.That(properties.IsFullScreen, Is.False);

        [Test]
        public void IsAutoPlay_DefaultValue_ShouldBeFalse() =>
            // Assert
            Assert.That(properties.IsAutoPlay, Is.False);

        [Test]
        public void ContentBefore_WhenSet_ShouldStoreValue()
        {
            // Arrange
            string expectedContent = "<div class='before-content'>";

            // Act
            properties.ContentBefore = expectedContent;

            // Assert
            Assert.That(properties.ContentBefore, Is.EqualTo(expectedContent));
        }

        [Test]
        public void ContentAfter_WhenSet_ShouldStoreValue()
        {
            // Arrange
            string expectedContent = "</div>";

            // Act
            properties.ContentAfter = expectedContent;

            // Assert
            Assert.That(properties.ContentAfter, Is.EqualTo(expectedContent));
        }

        [Test]
        public void VideoURL_RequiredValidation_ShouldAllowNull()
        {
            // Arrange & Act
            properties.VideoURL = null;

            // Assert
            Assert.That(properties.VideoURL, Is.Null);
        }

        [Test]
        public void Width_RequiredValidation_ShouldAllowNull()
        {
            // Arrange & Act
            properties.Width = null;

            // Assert
            Assert.That(properties.Width, Is.Null);
        }

        [Test]
        public void Height_RequiredValidation_ShouldAllowNull()
        {
            // Arrange & Act
            properties.Height = null;

            // Assert
            Assert.That(properties.Height, Is.Null);
        }
    }
}
