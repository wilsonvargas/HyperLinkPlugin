using CoreText;
using Foundation;
using System.Collections.Generic;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using HyperLink.FormsPlugin.iOS;
using HyperLink.FormsPlugin.Abstractions;
using System.ComponentModel;
using CoreGraphics;

[assembly: ExportRenderer(typeof(HyperLinkControl), typeof(HyperLinkRenderer))]

namespace HyperLink.FormsPlugin.iOS
{
    public class HyperLinkRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            var view = (HyperLinkControl)Element;
            if (view == null) return;

            UITextView uilabelleftside = new UITextView(new CGRect(0, 0, view.Width, view.Height));
            uilabelleftside.Text = view.Text;
            uilabelleftside.Font = UIFont.SystemFontOfSize((float)view.FontSize);
            uilabelleftside.Editable = false;

            // Setting the data detector types mask to capture all types of link-able data
            uilabelleftside.DataDetectorTypes = UIDataDetectorType.All;
            uilabelleftside.BackgroundColor = UIColor.Clear;

            // overriding Xamarin Forms Label and replace with our native control
            SetNativeControl(uilabelleftside);
        }
    }
}