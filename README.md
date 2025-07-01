# Xperience Community Youtube Widget

[![CI: Build and Test](https://github.com/rbt-cms/xperience-community-youtubevideo-widget/actions/workflows/ci.yml/badge.svg)](https://github.com/rbt-cms/xperience-community-youtubevideo-widget/actions/workflows/ci.yml) [![NuGet Package](https://img.shields.io/nuget/v/XperienceCommunity.YouTubeWidget.svg)](https://www.nuget.org/packages/XperienceCommunity.YouTubeWidget)

# Description
Widget Enables to insert the video from specified embed YouTube URL location

## Requirements

### Library Version Matrix

| Xperience Version | Library Version |
| ----------------- | --------------- |
| >= 29.6.0         | 1.0.0           |

### Dependencies


- [ASP.NET Core 8.0](https://dotnet.microsoft.com/en-us/download)
- [Xperience by Kentico](https://docs.kentico.com)


## Package Installation

Add the package to your application using the .NET CLI

```powershell
dotnet add package XperienceCommunity.YouTubeWidget.1.0.0
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

### Screenshots
#1. 
![Widget screen1](https://github.com/rbt-cms/xperience-community-youtubevideo-widget/blob/main/images/1.png)

#2. 
![Widget Screen2](https://github.com/rbt-cms/xperience-community-youtubevideo-widget/blob/main/images/2.png)

#3. 
![Widget Screen3](https://github.com/rbt-cms/xperience-community-youtubevideo-widget/blob/main/images/3.png)

#4.
![Widgte Screen4](https://github.com/rbt-cms/xperience-community-youtubevideo-widget/blob/main/images/4.png)

## Use DancingGoat sample

You can restore database with configured samples. View [DancingGoat Sample Database](https://github.com/rbt-cms/xperience-community-youtubevideo-widget/blob/main/db/xpDancingGoat_2960.bak).

Dashboard User Name: Administrator

Password: XbyK1234$

# License

This widget is provided under MIT license.

# Uninstall

Uninstall this from the NuGet Package Manager and rebuild the project.

# Reporting issues

Please report any issues seen, in the issue list. We will address at the earliest possibility.

# Compatibility

This widget has been tested on Xperience by Kentico version (29.6.0) and can be used on >=29.6.0 with .Net 8.0. 

