using Kentico.PageBuilder.Web.Mvc;
using Kentico.Xperience.Admin.Base.FormAnnotations;

namespace XperienceCommunity.YouTubeWidget.Components.Widgets.YouTubeVideo
{
    public class YouTubeVideoWidgetProperties : IWidgetProperties
    {
        /// <summary>
        /// Declaring the widget will visible or not
        /// </summary>
        [CheckBoxComponent(Order = 0, Label = "IsVisible", Tooltip = "Select IsVisible option")]
        public bool IsVisible { get; set; }
        [TextInputComponent(Label = "Video Title", Order = 1, Tooltip = "Enter desired video title")]
        [RequiredValidationRule(ErrorMessage = "Please Enter Video Title,Required", FieldName = nameof(VideoTitle))]
        public required string VideoTitle { get; set; }

        [TextInputComponent(Label = "Video URL", Order = 2, Tooltip = "Enter desired YouTube video URL")]
        [RequiredValidationRule(ErrorMessage = "Please Enter Video Url,Required", FieldName = nameof(VideoURL))]

        public string? VideoURL { get; set; }
        [TextInputComponent(Label = "Width", Order = 3, Tooltip = "Enter desired video width")]
        [RequiredValidationRule(ErrorMessage = "Please Enter Width,Required", FieldName = nameof(Width))]

        public string? Width { get; set; }

        [TextInputComponent(Label = "Height", Order = 4, Tooltip = "Enter desired video height")]
        [RequiredValidationRule(ErrorMessage = "Please Enter Height,Required", FieldName = nameof(Height))]

        public string? Height { get; set; }


        [CheckBoxComponent(Label = "Related Video", Order = 5, Tooltip = "Select option to enable related videos")]
        public bool IsShowRelatedVideos { get; set; }

        [CheckBoxComponent(Label = "FullScreen", Order = 6, Tooltip = "Select option to enable FullScreen view")]
        public bool IsFullScreen { get; set; }

        [CheckBoxComponent(Label = "Auto Play", Order = 7, Tooltip = "Select option to enable Auto Play")]
        public bool IsAutoPlay { get; set; }
        [TextAreaComponent(Order = 8, Label = "Content Before", Tooltip = "HTML content placed before the widget content. Can be used to display a header or add some encapsualting code such as <div>")]
        public string? ContentBefore { get; set; }
        [TextAreaComponent(Order = 9, Label = "Content After", Tooltip = "HTML content placed after the widget content. Can be used to display a header or add some encapsualting code such as <div>")]
        public string? ContentAfter { get; set; }
    }
}
