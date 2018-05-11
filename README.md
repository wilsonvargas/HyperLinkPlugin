# HyperLinkPlugin

# HyperLink Control Plugin for Xamarin.Forms

Custom control for your Xamarin.Forms project to create a label as hyperlink. With this plugin you can show a label as a hyperlink for your websites, phone numbers and mails. Available for Android and iOs

[![Build status](https://ci.appveyor.com/api/projects/status/jxgqs10kxj09vk5u?svg=true)](https://ci.appveyor.com/project/wilsonvargas/hyperlinkplugin) [![NuGet](https://img.shields.io/nuget/v/Plugins.Forms.HyperLinkControl.svg?label=NuGet)](https://www.nuget.org/packages/Plugins.Forms.HyperLinkControl/) [![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.me/wilsondonations/5)

![image](https://github.com/wilsonvargas/HyperLinkPlugin/blob/master/images/images/image.png)


#### Setup
* Available on NuGet: [Plugins.Forms.HyperLinkControl](https://www.nuget.org/packages/Plugins.Forms.HyperLinkControl/)
* Install into your PCL project and Client projects.

### Android

In your Android project call:

```
HyperLink.FormsPlugin.Droid.HyperLinkRenderer.Init();
```

<img src="https://raw.githubusercontent.com/wilsonvargas/HyperLinkPlugin/master/images/images/android.png" 
data-canonical-src="https://raw.githubusercontent.com/wilsonvargas/HyperLinkPlugin/master/images/images/android.png"
 width="480" height="480" />

### iOS

In your iOS project call:

```
HyperLink.FormsPlugin.iOS.HyperLinkRenderer.Init();
```

<img src="https://raw.githubusercontent.com/wilsonvargas/HyperLinkPlugin/master/images/images/ios.png" 
data-canonical-src="https://raw.githubusercontent.com/wilsonvargas/HyperLinkPlugin/master/images/images/ios.png"
 width="480" height="480" />

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
  Text = "blog.wilsonvargas.com"
}
```

**XAML:**

First add the xmlns namespace:
```xml
xmlns:hyperlink="clr-namespace:HyperLink.FormsPlugin.Abstractions;assembly=HyperLink.FormsPlugin.Abstractions"
```

Then add the xaml:

```xml
<hyperlink:HyperLinkControl TextColor="Gray" Text="Click here: blog.wilsonvargas.com&#x0a;Phone number: +65 9215 7231&#x0a;Email address: wilsonvargas_6@outlook.com"/>
```

#### License
Licensed under MIT, see license file

