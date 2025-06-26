# Xperience Community Youtube Widget

[![CI: Build and Test](https://github.com/rbt-cms/xperience-community-youtubevideo-widget/actions/workflows/ci.yml/badge.svg)](https://github.com/rbt-cms/xperience-community-youtubevideo-widget/actions/workflows/ci.yml)

# Description
Widget Enables to insert the video from specified embed YouTube URL location

## Requirements

### Library Version Matrix

| Xperience Version | Library Version |
| ----------------- | --------------- |
| >= 29.4.0         | 1.0.0           |

### Dependencies


- [ASP.NET Core 8.0](https://dotnet.microsoft.com/en-us/download)
- [Xperience by Kentico](https://docs.kentico.com)


## Package Installation

Add the package to your application using the .NET CLI

```powershell
dotnet add package <library nuget package name>
```

## Quick Start

### Widget
Thisis a widget which allows you to add a YouTubeVideo to your page with certain attributes that can be configured while adding. The properties that can be configured are:

- IsVisible: Select IsVisible option
- VideoTitle*: Enter desired video title
- Video URL*: Enter your desired YouTube video URL. Example for URL:https://www.youtube.com/embed/wlv9vWwCbKI
- Width*: Enter desired video width
- Height*: Enter desired video height
- Auto Play: Select option to enable Auto Play
- Related videos: Select option to enable related videos
- Full Screen: Select option to enable FullScreen view
- Content Before: HTML content placed before the widget content. Can be used to display a header or add encapsulating code such as div tag
- Content After: HTML content placed after the widget content. Can be used to display a header or add encapsulating code such as div tag
*Required fields

# License

This widget is provided under MIT license.

# Uninstall

Uninstall this from the NuGet Package Manager and rebuild the project.

# Reporting issues

Please report any issues seen, in the issue list. We will address at the earliest possibility.

# Compatibility

This widget has been tested on Xperience by Kentico version (29.5.2) and can be used on >=29.4.0 with .Net 8.0. 

