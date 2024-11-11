# .NET MAUI Application Analysis - DevsPark

## 📱 Overview
1. **Main Page**:

![Screenshot 2024-11-09 at 3 17 25 PM](https://github.com/user-attachments/assets/b8256438-e713-4798-8afc-12c2e15bc8e4)

2. **Slide Menu**:

![Screenshot 2024-11-09 at 3 17 41 PM](https://github.com/user-attachments/assets/e08a74f3-72e9-4af4-850d-3c395059ffd9)

3. **Another Option**:

![Screenshot 2024-11-09 at 3 18 04 PM](https://github.com/user-attachments/assets/a00986a5-f895-4885-adf5-4dd731b18b0a)

4. **Offer**:

![Screenshot 2024-11-09 at 3 18 12 PM](https://github.com/user-attachments/assets/466880fc-9381-469e-88bb-afccaa77ad1f)

5. **Search Bar**:

![Screenshot 2024-11-09 at 3 18 43 PM](https://github.com/user-attachments/assets/1f314ce7-94e9-4170-8e4b-12cd43afd583)

6. **Search Function**:

![Screenshot 2024-11-09 at 3 23 11 PM](https://github.com/user-attachments/assets/f38917ee-3587-43e3-bd09-0c9de3288e2b)

---

## 📂 Core Components - Project Structure
```markdown
- DevsPark/
  ├── MauiProgram.cs
  ├── App.xaml/.cs
  ├── MainPage.xaml/.cs
  ├── MVVM/
  │   ├── Models/
  │   │   ├── FeaturedPromotion.cs
  │   │   ├── Offer.cs
  │   │   └── Place.cs
  │   ├── Pages/
  │   │   ├── DesertMirage/
  │   │   │   ├── NightAdventures/
  │   │   │   │   ├── NightDuneBuggy.xaml
  │   │   │   │   └── StarGazing.xaml
  │   │   │   ├── OasisFun/
  │   │   │   │   ├── CamelRides.xaml
  │   │   │   │   └── OasisPools.xaml
  │   │   ├── Frozen/
  │   │   │   ├── IcyTreats/
  │   │   │   │   ├── FrozenDrinksBar.xaml
  │   │   │   │   └── IceCreamWorld.xaml
  │   │   │   ├── SnowActivities/
  │   │   │   │   ├── IceSculptures.xaml
  │   │   │   │   └── Snowboarding.xaml
  │   │   ├── TropicalParadise/
  │   │   │   ├── BeachAttractions/
  │   │   │   │   ├── SurfLessons.xaml
  │   │   │   │   └── WavePool.xaml
  │   │   │   ├── JungleAdventures/
  │   │   │   │   ├── AnimalShows.xaml
  │   │   │   │   └── ZipLines.xaml
  │   │   ├── AppShell.xaml
  │   │   ├── AppShellTabs.xaml
  │   │   ├── FeaturedView.xaml
  │   │   ├── OffersView.xaml
  │   │   ├── SearchView.xaml
  │   │   └── TemplateView.xaml
  │   ├── ViewModels/
  │   │   ├── FeaturedViewModel.cs
  │   │   ├── OffersViewModel.cs
  │   │   └── PlacesViewModel.cs
  ├── Platforms/
  ├── Resources/
  ├── Search/
  │   └── OffersSearchHandler.cs
  ├── Utilities/
  │   ├── IconFont.cs
  │   └── Utils.cs
  └── Services/
      └── OffersService.cs

```
---

## 🛠 Development Environment Setup

```markdown
Required Tools:
- Visual Studio 2022
- JetBrains Rider
- .NET 7.0 or later
- MAUI Workload
- Android/iOS SDKs (for mobile development)
```
---

## 📝 Nuget Package
```markdown
- CommunityToolkit.Mvvm
```
---

# ⭐️ Analysis of .NET MAUI: Shell.xaml, App.xaml, and MainPage.xaml

In a .NET MAUI (Multi-platform App UI) application, Shell.xaml, App.xaml, and MainPage.xaml play distinct roles that help define the structure and behavior of the application. These files have different responsibilities within a MAUI project, and understanding their roles will enable you to effectively build multi-platform apps. Below is an in-depth analysis of each, including examples, usage scenarios, and key features.

## Overview of Files in .NET MAUI

| File              | Role in the Application                  | Key Features                                   |
|-------------------|-----------------------------------------|------------------------------------------------|
| Shell.xaml        | Main navigation structure               | Declarative navigation, flyout menus, tabs     |
| App.xaml          | Global resources and app lifecycle      | App-wide styles, themes, and entry point       |
| MainPage.xaml     | Default main page content               | Specific content of the default user interface |

Let’s now go into more detail about each of these components.

### Shell.xaml
**Shell.xaml** is used to define the overall navigation structure of a .NET MAUI application. It provides a simplified and consistent way to manage complex navigation requirements like flyout menus, tabs, and deep linking. Shell streamlines the creation of large-scale applications by abstracting the navigation structure into a central place.

**Key Features**:
- **Simplified Navigation**: Shell provides an easy way to navigate between pages with URL-like routes.
- **Flyout and Tab Management**: With Shell, creating navigation menus, flyouts, and tabs is much more straightforward.
- **Global Navigation State**: Shell can handle the entire navigation stack, making it easier to manage navigation across different devices.

**Example**:
```xml
<?xml version="1.0" encoding="utf-8" ?>
<Shell xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
       xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
       x:Class="MyApp.MainShell">
    <FlyoutItem Title="Home" Icon="home.png">
        <Tab>
            <ShellContent Title="Home" ContentTemplate="{DataTemplate local:MainPage}" />
        </Tab>
    </FlyoutItem>
    <FlyoutItem Title="Settings" Icon="settings.png">
        <ShellContent Title="Settings" ContentTemplate="{DataTemplate local:SettingsPage}" />
    </FlyoutItem>
</Shell>
```
**Usage Scenario**: Use Shell.xaml when you want to build an application that requires a structured and scalable navigation model. It is especially helpful when developing applications with multiple pages and navigation pathways, like e-commerce or social media apps.

### App.xaml
**App.xaml** is the entry point of a .NET MAUI application and is responsible for managing global application resources, including styles, themes, and application-level settings. It is similar to the `App.xaml` in a WPF or Xamarin.Forms application.

**Key Features**:
- **Global Resources**: It allows you to define resources that are accessible throughout the application, such as styles, colors, and templates.
- **Lifecycle Events**: You can handle application lifecycle events, such as `OnStart`, `OnSleep`, and `OnResume`.

**Example**:
```xml
<?xml version="1.0" encoding="utf-8" ?>
<Application xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="MyApp.App">
    <Application.Resources>
        <ResourceDictionary>
            <Style TargetType="Label">
                <Setter Property="TextColor" Value="Blue" />
                <Setter Property="FontSize" Value="20" />
            </Style>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```
**Usage Scenario**: Use App.xaml for defining global resources or themes that are shared across multiple pages of the application. For instance, if you have a consistent visual style, colors, or fonts that need to be applied across the entire application, App.xaml is the right place to manage it.

### MainPage.xaml
**MainPage.xaml** defines the main page of the application, typically representing the UI that the user will see when the application starts. This page contains specific content and controls, such as labels, buttons, and layout definitions.

**Key Features**:
- **Direct User Interaction**: MainPage is usually the first page the user interacts with, containing the main functionality or the welcome interface.
- **Content and Controls**: This is where you define elements that directly interact with the user, like buttons, text fields, and images.

**Example**:
```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="MyApp.MainPage">
    <StackLayout>
        <Label Text="Welcome to .NET MAUI!"
               VerticalOptions="CenterAndExpand"
               HorizontalOptions="CenterAndExpand" />
        <Button Text="Click Me" />
    </StackLayout>
</ContentPage>
```
**Usage Scenario**: Use MainPage.xaml when you need to define the core content or landing page of your application. This is usually the first interaction point for users and contains a combination of UI controls that guide the user into further parts of the application.

## Summary Table
| File              | Description                             | When to Use                                          |
|-------------------|-----------------------------------------|------------------------------------------------------|
| **Shell.xaml**    | Navigation container, defines the app’s structure | Use when you need structured navigation, tabs, or flyouts |
| **App.xaml**      | Entry point, manages global resources   | Use for app-wide styles, global settings, and resources  |
| **MainPage.xaml** | Main content page                       | Use for defining the first screen users see           |

## Reference Links
To learn more about each of these files in detail, consider visiting the following resources:
- [.NET MAUI Shell Documentation](https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/?view=net-maui-8.0): Microsoft’s official documentation for understanding Shell in .NET MAUI.
- [.NET MAUI Application Fundamentals](https://learn.microsoft.com/en-us/dotnet/maui/xaml/fundamentals/get-started?view=net-maui-8.0): An overview of core concepts, including App.xaml and global resources.
- [.NET MAUI ContentPage Documentation](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pages/contentpage): Official guide to ContentPage, which includes MainPage.xaml.

---
# ⭐️ Analysis of AppShell.xaml Analysis and Detailed Explanation

This XAML file (`AppShell.xaml`) represents a foundational component of a .NET MAUI (Multi-platform App UI) application. It defines the visual structure and navigation of the application's Shell, which is used to organize and manage different pages effectively. Here is a detailed analysis of the features, properties, and overall structure used in this XAML file, followed by an explanation of each individual property in a table format.

### Overview of Shell

The `<Shell>` element is part of the .NET MAUI application and is a powerful navigation container that allows the user to create multi-page applications with common UI patterns like tabs and flyouts. Shell greatly simplifies the task of managing navigation and reduces the amount of code typically required to implement complex navigation hierarchies.

The Shell in this file (`AppShell`) has several key features, such as:

- **Flyout Menu**: The `Flyout` is a side navigation panel that slides out from the left side of the screen, containing links to different sections of the application.
- **Tabs Navigation**: Tabs are used for quick access to different content areas of the application.
- **Custom Header and Icon Management**: The Shell supports custom header views and icons for specific pages or tabs.

Below is a breakdown of the various attributes and properties used in this XAML file:

### Properties and Customization in `AppShell.xaml`

| Property Name                  | Description                                                                                                                                      |
|--------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------|
| `FlyoutBackgroundImage`        | Specifies a background image for the flyout menu. In this case, `park_background.png` is used to enhance the visual appeal of the side panel.    |
| `FlyoutBackgroundImageAspect`  | Controls how the background image should be displayed within the flyout. `AspectFill` ensures that the image covers the entire background area.  |
| `FlyoutHeaderBehavior`         | Defines the behavior of the header, with possible values like `Scroll`, `CollapseOnScroll`, etc. In this file, it's set to `Scroll`.              |
| `FlyoutIsPresented`            | A Boolean property that determines if the flyout is presented. It is bound to `IsFlyoutOpen` from the ViewModel, giving dynamic control.         |
| `FlyoutItemIsVisible`          | Controls the visibility of specific flyout items. For example, the "Search" flyout item has its visibility set to `False`.                      |

### Shell Content and Flyout Items

The Shell contains several types of items to organize the content:

- **Flyout Items and Tabs**: Flyout items and tabs are used to navigate different sections of the application.
- **ShellContent**: Represents the content for each individual section. It can reference a specific `ContentPage` defined in the XAML or through a data template.
- **Menu Items**: Additional items in the flyout, such as "Help" and "Offers", are defined using the `<MenuItem>` element.

### Example Explanation

The following example is from the `AppShell.xaml`:

```xml
<Shell
    x:Class="DevsPark.MVVM.Pages.AppShell"
    xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    FlyoutBackgroundImage="park_background.png"
    FlyoutBackgroundImageAspect="AspectFill"
    FlyoutHeaderBehavior="Scroll"
    FlyoutIsPresented="{Binding IsFlyoutOpen}">
    <Shell.TitleView>
        <Grid ColumnDefinitions=".8*,.2*">
            <Image
                HorizontalOptions="Center"
                Source="logo.png"
                VerticalOptions="Center" />
            <Label
                Grid.Column="1"
                FontFamily="Icons"
                FontSize="20"
                HorizontalOptions="Center"
                Text="{x:Static utilities:IconFont.Search}"
                TextColor="#929292"
                VerticalOptions="Center">
                <Label.GestureRecognizers>
                    <TapGestureRecognizer Command="{Binding SearchCommand}" />
                </Label.GestureRecognizers>
            </Label>
        </Grid>
    </Shell.TitleView>
</Shell>
```

In this example:
- **`Shell.TitleView`**: A custom title view is defined using a `Grid` layout. It contains an `Image` and a `Label` to create a header with a logo and search icon.
- **`FlyoutBackgroundImage`**: Sets the image for the flyout background.
- **`FlyoutHeaderBehavior`**: Determines how the flyout header behaves when scrolling.
- **Gesture Recognizers**: The search icon (`Label`) has a `TapGestureRecognizer` attached, which triggers the `SearchCommand` when the icon is tapped.

### Properties Explanation Table

| Property Name                   | Example Value                  | Description                                                                                                               |
|---------------------------------|--------------------------------|---------------------------------------------------------------------------------------------------------------------------|
| `FlyoutBackgroundImage`         | `park_background.png`          | Specifies the image used in the background of the flyout.                                                                 |
| `FlyoutBackgroundImageAspect`   | `AspectFill`                   | Defines how the background image should fill the space, ensuring that the image fills while maintaining its aspect ratio. |
| `FlyoutHeaderBehavior`          | `Scroll`                       | Controls how the flyout header appears when scrolling (can scroll, collapse, or be fixed).                                |
| `FlyoutIsPresented`             | `{Binding IsFlyoutOpen}`       | Boolean property bound to a ViewModel property that decides if the flyout is open.                                        |
| `ShellContent.Route`            | `"search"`                    | Defines the route used for navigation to uniquely identify a page.                                                        |
| `MenuItem.Command`              | `{Binding HelpCommand}`        | Command binding to handle user interactions such as navigating to help pages.                                             |
| `ShellContent.Icon`             | `<FontImageSource ... />`      | Custom icons for shell content using a specific `FontFamily` and `Glyph`.                                                 |

### Additional Resources
To gain more insight into using Shell in .NET MAUI, you can check the following references:

1. [Microsoft .NET MAUI Shell Documentation](https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/) - Detailed overview of using Shell, properties, and customization.
2. [XAML Documentation](https://learn.microsoft.com/en-us/dotnet/desktop/wpf/xaml/?view=netdesktop-9.0) - Understanding XAML structure and syntax.
3. [Shell Navigation in MAUI](https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/navigation) - Best practices for managing navigation using Shell.
---
# ⭐️ Analysis of AppShellTabs.xaml Analysis and Detailed Explanation

The `AppShellTabs.xaml` file defines the visual structure of a .NET MAUI application using tabs to organize and navigate different sections of the application. This file uses the `<Shell>` element to create a tab-based interface, providing users an intuitive way to access different features or views. Below, we'll analyze the structure, properties, and features used in this XAML file, and explain their functionality in detail.

### Overview of the Shell Component

The `<Shell>` element is used to create a unified navigation structure for a multi-page application in .NET MAUI. Shell helps to simplify navigation hierarchies and enables an organized structure for handling different user journeys, such as tabbed navigation and flyout menus.

In this file, `AppShellTabs` specifically employs the **TabBar** element to create a tabbed layout. Tabs are an essential navigation pattern in mobile and desktop applications, offering users an easy way to navigate between different categories of content.

### Structure of the `AppShellTabs.xaml` File

The core of the file can be broken down into several key parts:

1. **Shell Resources**: Defined global styles for elements such as the `TabBar`, which allows customization of tab-related properties like colors.
2. **TabBar and Tabs**: Organizes tabs to categorize different sections within the application.
3. **ShellContent**: Contains specific content for each tab, allowing for individual customization of icons and views.

### Example Breakdown

The following example from `AppShellTabs.xaml` demonstrates the use of `<Shell>`, `<TabBar>`, `<Tab>`, and `<ShellContent>`:

```xml
<Shell xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:utilities="clr-namespace:DevsPark.Utilities"
             x:Class="DevsPark.MVVM.Pages.AppShellTabs">
    
    <Shell.Resources>
        <Style TargetType="TabBar">
            <Setter Property="Shell.TabBarBackgroundColor" Value="#1D1F24" />
            <Setter Property="Shell.TabBarDisabledColor" Value="#1D1F24" />
            <Setter Property="Shell.TabBarForegroundColor" Value="Yellow" />
            <Setter Property="Shell.TabBarTitleColor" Value="#9E86FF" />
            <Setter Property="Shell.TabBarUnselectedColor" Value="#555A62" />
        </Style>
    </Shell.Resources>

    <TabBar Title="Desert Mirage">
        <Tab Title="Night Adventures">
            <Tab.Icon>
                <FontImageSource
                    FontFamily="Icons"
                    Glyph="{x:Static utilities:IconFont.Night_adventures}"
                    Color="{StaticResource IconColor}" />
            </Tab.Icon>
            <ShellContent Title="Night Dune Buggy" ContentTemplate="{DataTemplate nightAdventures:NightDuneBuggy}">
                <ShellContent.Icon>
                    <FontImageSource
                        FontFamily="Icons"
                        Glyph="{x:Static utilities:IconFont.Night_dune_buggy}"
                        Color="{StaticResource IconColor}" />
                </ShellContent.Icon>
            </ShellContent>
        </Tab>
        
        <Tab Title="Beach Attractions">
            <Tab.Icon>
                <FontImageSource
                    FontFamily="Icons"
                    Glyph="{x:Static utilities:IconFont.Beach_attractions}"
                    Color="{StaticResource IconColor}" />
            </Tab.Icon>
            <ShellContent Title="Surf Lessons" ContentTemplate="{DataTemplate beachAttractions:SurfLessons}">
                <ShellContent.Icon>
                    <FontImageSource
                        FontFamily="Icons"
                        Glyph="{x:Static utilities:IconFont.Surf_lessons}"
                        Color="{StaticResource IconColor}" />
                </ShellContent.Icon>
            </ShellContent>
        </Tab>
    </TabBar>
</Shell>
```

### Properties Explained in Detail

The following table explains each property used in the `AppShellTabs.xaml` file:

| Property Name                   | Example Value                    | Description                                                                                                                  |
|---------------------------------|----------------------------------|------------------------------------------------------------------------------------------------------------------------------|
| `Shell.Resources`               | `<Style TargetType="TabBar">`   | Defines global styles and resources for customizing elements like `TabBar`.                                                  |
| `Shell.TabBarBackgroundColor`   | `#1D1F24`                        | Sets the background color of the tab bar to enhance the visual appearance.                                                   |
| `Shell.TabBarDisabledColor`     | `#1D1F24`                        | Specifies the color used when a tab is disabled.                                                                             |
| `Shell.TabBarForegroundColor`   | `Yellow`                         | Sets the color of the text or foreground elements in the tab bar.                                                            |
| `Shell.TabBarTitleColor`        | `#9E86FF`                        | Defines the color of the tab bar title when selected.                                                                        |
| `Shell.TabBarUnselectedColor`   | `#555A62`                        | Sets the color of unselected tab items, making them visually distinct from active tabs.                                      |
| `TabBar`                        | `Title="Desert Mirage"`         | Defines a collection of tabs within the shell, which users can navigate through.                                             |
| `Tab.Title`                     | `"Night Adventures"`            | Sets the title for each tab that appears below the corresponding icon.                                                       |
| `Tab.Icon`                      | `<FontImageSource...>`           | Defines the icon used for each tab, allowing users to easily identify different sections visually.                           |
| `ShellContent.Title`            | `"Surf Lessons"`                | Provides a title for the shell content displayed within each tab.                                                            |
| `ContentTemplate`               | `{DataTemplate ...}`             | Refers to the content displayed when a specific tab is selected.                                                             |
| `FontImageSource.Glyph`         | `{x:Static utilities:IconFont}`  | Specifies the glyph to be used for the tab or content icon, using custom icons from a specified font family.                 |

### Tabs and Their Functionalities

- **TabBar**: The `<TabBar>` element defines a collection of tabs, allowing the user to navigate between different sections like "Desert Mirage".
- **Tabs**: Each `<Tab>` element represents a specific navigation category, such as "Night Adventures" or "Beach Attractions".
- **ShellContent**: Each tab contains `<ShellContent>` elements that define the individual pages or views that are accessible from within the tab.
- **Icons and Styling**: The icons are defined using `<FontImageSource>` and customized using attributes like `Color` and `FontFamily`. The consistent use of color and icons helps provide a cohesive visual experience for users.

### Additional Resources
To learn more about Shell, TabBar, and XAML in .NET MAUI, you can refer to the following resources:

1. [Microsoft .NET MAUI Shell Documentation](https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/shell/?view=net-maui-8.0) - Comprehensive information on using Shell in .NET MAUI.
2. [XAML Tabbed Navigation in MAUI](https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.platformconfiguration.macosspecific.tabbedpage?view=net-maui-8.0) - Guide to creating and using tabbed navigation within MAUI.
3. [XAML Overview](https://learn.microsoft.com/en-us/visualstudio/xaml-tools/xaml-overview?view=vs-2022) - To understand the syntax and features of XAML used in UI development.
---
# ⭐️ Analysis of FeaturedView.xaml, SearchView.xaml, and TemplateView.xaml

The three XAML files define different parts of a .NET MAUI application: `FeaturedView.xaml`, `SearchView.xaml`, and `TemplateView.xaml`. Each of these files plays an important role in presenting content and enhancing user experience in the application. Below, I will provide a comprehensive analysis of each file, including the properties, features, and example usage.

## 1. FeaturedView.xaml Analysis

### Overview
The `FeaturedView.xaml` file defines a `ContentPage` that showcases promotions from partners, making use of elements like `Grid`, `Label`, and `CollectionView` to create a visually appealing promotional area. The page uses data binding to dynamically populate a `CollectionView` with items.

### Key Components
- **ContentPage**: The base of the view, with `Title` set as "FeaturedView" and `BackgroundColor` specified as a static resource.
- **Grid**: A two-row grid is used to separate the label heading and the `CollectionView`.
- **CollectionView**: Displays promotions. It is bound to `Promos` data, allowing users to browse through various items.
- **DataTemplate**: Defines the layout for each item in the `CollectionView`, consisting of `Image`, `Label`, and decorative elements like `Border`.

### Example
```xml
<CollectionView ItemsSource="{Binding Promos}">
    <CollectionView.ItemsLayout>
        <GridItemsLayout Orientation="Vertical" Span="2" VerticalItemSpacing="50" />
    </CollectionView.ItemsLayout>
    <CollectionView.ItemTemplate>
        <DataTemplate>
            <Border Padding="16,8" Background="#381F8D">
                <Grid RowDefinitions="*,*">
                    <Image Source="{Binding Image}" VerticalOptions="Center" />
                    <Label Grid.Row="1" Text="{Binding BusinessName}" TextColor="White" />
                </Grid>
            </Border>
        </DataTemplate>
    </CollectionView.ItemTemplate>
</CollectionView>
```

### Property Table
| Property Name                 | Example Value                   | Description                                                                                   |
|-------------------------------|---------------------------------|-----------------------------------------------------------------------------------------------|
| `BackgroundColor`             | `{StaticResource BGColor}`      | Sets the background color of the page, making use of a resource for easy customization.       |
| `ItemsSource`                 | `{Binding Promos}`              | Binds the collection view to a list of promotional items.                                     |
| `SelectionChangedCommand`     | `{Binding SelectionChangedCommand}` | Triggers an action whenever a selection is changed.                                          |
| `VerticalItemSpacing`         | `50`                            | Specifies the space between items in the vertical direction.                                  |
| `StrokeShape`                 | `RoundRectangle 10,10,10,10`    | Defines the shape and corner radius for the `Border` around each promotional item.            |

### Purpose
The page is designed to display partner promotions in a visually appealing and organized way, making use of `CollectionView` to enable easy scrolling through promotional content.

## 2. SearchView.xaml Analysis

### Overview
`SearchView.xaml` defines a `ContentPage` dedicated to implementing search functionality. It contains UI components like a `SearchHandler` to filter and display search results effectively.

### Key Components
- **SearchHandler**: A crucial component allowing the user to input text and search for offers.
- **Shell.SearchHandler**: Configured to filter offers through bindings to `OffersSearchHandler`.

### Example
```xml
<Shell.SearchHandler>
    <search:OffersSearchHandler Placeholder="Search for offers"
                                 ShowsResults="True"
                                 ItemsSource="{Binding SearchResults}" />
</Shell.SearchHandler>
```

### Property Table
| Property Name            | Example Value             | Description                                                                                 |
|--------------------------|---------------------------|---------------------------------------------------------------------------------------------|
| `Placeholder`            | "Search for offers"      | Placeholder text for the search box, guiding users on what to search for.                   |
| `ItemsSource`            | `{Binding SearchResults}` | Binds the search handler to the results collection, dynamically updating the search results.|
| `ShowsResults`           | `True`                    | Indicates whether search results should be shown while typing.                              |

### Purpose
This file provides the core UI for searching through offers. It simplifies finding specific content and allows users to directly interact with the search results.

## 3. TemplateView.xaml Analysis

### Overview
`TemplateView.xaml` defines a `ContentView` that focuses on the representation of places, making use of visual components like `Grid`, `Rectangle`, and `Label` to present information in an appealing way.

### Key Components
- **ContentView**: A flexible layout container that serves as a reusable template for displaying place-related information.
- **Grid Layout**: Organizes the content into multiple parts, with an image overlaid with a semi-transparent rectangle for better contrast.
- **VerticalStackLayout**: Displays details like name and description of the place.

### Example
```xml
<Grid>
    <Image Aspect="AspectFill" Source="{Binding CurrentPlace.ImagePath}" />
    <Rectangle Fill="Black" Opacity=".4" />
</Grid>
<VerticalStackLayout Margin="0,-100,0,0">
    <Label FontAttributes="Bold" FontSize="40" Text="{Binding CurrentPlace.Name}" TextColor="White" />
    <Border Background="White" Stroke="#D6D6D6" StrokeShape="RoundRectangle 5,5,20,20">
        <VerticalStackLayout Padding="20,50">
            <Label FontSize="20" Text="{Binding CurrentPlace.Name, StringFormat='About {0}'}" />
            <Label FontSize="16" Text="{Binding CurrentPlace.Description}" TextColor="#6D6D6D" />
        </VerticalStackLayout>
    </Border>
</VerticalStackLayout>
```

### Property Table
| Property Name             | Example Value               | Description                                                                                 |
|---------------------------|-----------------------------|---------------------------------------------------------------------------------------------|
| `Aspect`                  | `AspectFill`                | Defines how the image should fill the allocated space while maintaining aspect ratio.       |
| `Opacity`                 | `0.4`                       | Sets the opacity of the rectangle overlay to create a darkened effect over the image.       |
| `FontAttributes`          | `Bold`                      | Sets the font style of the text to bold, highlighting important information.                |
| `StrokeShape`             | `RoundRectangle 5,5,20,20`  | Defines the shape and rounded corners for the `Border` around descriptive information.      |
| `Padding`                 | `20,50`                     | Adds padding to the inner content of the `VerticalStackLayout` to ensure proper spacing.    |

### Purpose
The `TemplateView.xaml` serves as a visual template for displaying specific information about places, including an image and related descriptions. It makes use of layering and layout techniques to create a visually pleasing display.

## Summary and Resources
These three XAML views are essential components of a multi-faceted .NET MAUI application, each fulfilling different UI needs. `FeaturedView` offers a structured way to present promotions, `SearchView` facilitates user searches, and `TemplateView` provides detailed information with a stylish layout.

For more information and deeper learning, you can refer to the following resources:

1. [Microsoft .NET MAUI XAML Overview](https://learn.microsoft.com/en-us/dotnet/maui/xaml/?view=net-maui-8.0) - To understand the basics and advanced uses of XAML in .NET MAUI.
2. [CollectionView Documentation](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/collectionview) - Covers details about creating list-based UIs with `CollectionView`.
3. [SearchHandler in MAUI](https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/searchbar?view=net-maui-8.0) - Provides an overview of using `SearchHandler` for search functionality.

