namespace XperienceCommunity.YouTubeWidget.Components.Widgets.YouTubeVideo
{
    public class YouTubeVideoWidgetViewModel
    {
        public bool IsVisible { get; set; }
        public string? VideoURL { get; set; }
        public string? VideoTitile { get; set; }
        public string? Width { get; set; }
        public string? Height { get; set; }
        public bool IsShowRelatedVideos { get; set; }
        public bool IsFullScreen { get; set; }
        public bool IsAutoPlay { get; set; }
        public string? VideoParameters { get; set; }
        public string? ContentBefore { get; set; }
        public string? ContentAfter { get; set; }
    }
}
