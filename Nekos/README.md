# Nekos
[![Deploy to Server](https://github.com/MarkenJaden/Nekos/actions/workflows/deploy.yml/badge.svg)](https://github.com/MarkenJaden/Nekos/actions/workflows/deploy.yml)
[![CodeFactor](https://www.codefactor.io/repository/github/markenjaden/nekos.lol/badge)](https://www.codefactor.io/repository/github/markenjaden/nekos.lol)
[![wakatime](https://wakatime.com/badge/user/17f322c9-222a-48b4-9e15-983c41f7aed4/project/d3a3b200-4514-4fa7-a958-9f5914af1406.svg)](https://wakatime.com/badge/user/17f322c9-222a-48b4-9e15-983c41f7aed4/project/d3a3b200-4514-4fa7-a958-9f5914af1406)

#### https://nekos.lol/
Website providing you with random lewd nsfw neko pics using [NekosAPI.NET](https://github.com/MarkenJaden/NekosAPI.NET)

## Developement

#### I appreciate any contribution to the website! If you have an idea, implement it or ask me to do it! ^^

This website was created using [Blazor Server](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor) in [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).

### Libraries used
* [NekosAPI.NET](https://github.com/MarkenJaden/NekosAPI.NET)
* [Blazored.LocalStorage](https://github.com/Blazored/LocalStorage)
* [CurrieTechnologies.Razor.Clipboard](https://github.com/Basaingeal/Razor.Clipboard)
* [AntDesign](https://github.com/ant-design-blazor/ant-design-blazor)

### For the development you need
* [.NET IDE](https://dotnet.microsoft.com/en-us/platform/tools)
* [.NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)

Clone the repo into your IDE. Make sure that all libraries are downloaded. Now you should already be able to start the website locally.

All the logic is done in [Index.razor](https://github.com/MarkenJaden/Nekos/blob/master/Nekos/Pages/Index.razor) and is not very complicated.

The rest of the application you don't really need to pay attention to, unless you want to add a bigger feature, but with such ambition I assume you have the necessary knowledge.

Once you're happy with your change you can just open a pull request, I'll take a quick look over it, and thanks to GitHub Actions your changes are live on the website just a few minutes later, it's really not hard :)

**If there are any questions you can always reach me via Discord (MarkenJaden#7787) ^^**

## Using the Tag Filtering Feature

The website now includes a feature that allows users to filter images by tags. This feature is accessible through a menu where users can select multiple tags to refine the images displayed. The tags available for selection are fetched using the `TagsAsync()` method from `NekosAPI.NET`, ensuring that users have access to a comprehensive list of tags to choose from.

To use the tag filtering feature, simply click on the tag menu, browse through the list of available tags, and select the ones you wish to apply. You can select multiple tags by clicking on more than one tag. The images displayed on the page will automatically update to only show those that match the selected tags. To clear the selection and view all images again, simply deselect the tags from the menu.

This feature enhances the user experience by providing a more tailored browsing experience, allowing users to easily find images that match their specific interests.

## Legal

I **do not** own or save any of the images displayed. All images are retrieved and displayed using the [Nekos.Fun API](https://nekos.fun/).
