# HyperLinkPlugin

# HyperLink Control Plugin for Xamarin.Forms

Custom control for your Xamarin.Forms project to create a label as hyperlink. With this plugin you can show a label as a hyperlink for your websites, phone numbers and mails. Available for Android and iOs

Build status: [![Build status](https://ci.appveyor.com/api/projects/status/jxgqs10kxj09vk5u?svg=true)](https://ci.appveyor.com/project/wilsonvargas/hyperlinkplugin)


#### Setup
* Available on NuGet: [![NuGet](https://img.shields.io/nuget/v/Plugins.Forms.HyperLinkControl.svg?label=NuGet)](https://www.nuget.org/packages/Plugins.Forms.HyperLinkControl/) https://www.nuget.org/packages/Plugins.Forms.HyperLinkControl/
* Install into your PCL project and Client projects.

### Android

In your Android project call:

```
HyperLink.FormsPlugin.Droid.HyperLinkRenderer.Init();
```

### iOS

In your iOS project call:

```
HyperLink.FormsPlugin.iOS.HyperLinkRenderer.Init();
```

You must do this AFTER you call Xamarin.Forms.Init();

**Platform Support**

|Platform|Supported|Version|
| ------------------- | :-----------: | :------------------: |
|Xamarin.iOS|Yes|iOS 7+|
|Xamarin.Android|Yes|API 14+|
|Windows Phone Silverlight|No|
|Windows Phone RT|No|
|Windows Store RT|Coming soon|Coming soon
|Windows 10 UWP|Coming soon|Coming soon
|Xamarin.Mac|No||

#### Usage
Instead of using an Label simply use a HyperLinkControl instead!

You **MUST** set the width & height requests to the same value. Here is a sample:
```
new HyperLinkControl
{
  Text = blog.wilsonvargas.com
}
```

**XAML:**

First add the xmlns namespace:
```xml
xmlns:hyperlink="clr-namespace:HyperLink.FormsPlugin.Abstractions;assembly=HyperLink.FormsPlugin.Abstractions"
```

Then add the xaml:

```xml
<hyperlink:HyperLinkControl>
    <hyperlink:HyperLinkControl.FormattedText>
        <FormattedString>
            <FormattedString.Spans>
                <Span Text="Click here:" FontAttributes="Bold" />
                <Span Text="blog.wilsonvargas.com" />
                <Span Text="phone number :" FontAttributes="Bold" />
                <Span Text="+65 9215 7231" />
                <Span Text="email address: " FontAttributes="Bold"/>
                <Span Text="udara.blahblah@blah.com" />
            </FormattedString.Spans>
        </FormattedString>
    </hyperlink:HyperLinkControl.FormattedText>
</hyperlink:HyperLinkControl>
```

#### License
Licensed under MIT, see license file

