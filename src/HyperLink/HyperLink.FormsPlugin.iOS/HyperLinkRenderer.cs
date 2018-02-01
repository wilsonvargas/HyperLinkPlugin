using CoreText;
using Foundation;
using System.Collections.Generic;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using HyperLink.FormsPlugin.iOS;
using HyperLink.FormsPlugin.iOS.Controls;
using HyperLink.FormsPlugin.Abstractions;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(HyperLinkControl), typeof(HyperLinkRenderer))]

namespace HyperLink.FormsPlugin.iOS
{
    public class HyperLinkRenderer : ViewRenderer<HyperLinkControl, HyperlinkUIView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<HyperLinkControl> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != e.OldElement)
            {
                if (e.OldElement != null)
                    e.OldElement.PropertyChanged -= Element_PropertyChanged;

                if (e.NewElement != null)
                    e.NewElement.PropertyChanged += Element_PropertyChanged;
            }

            var textView = new HyperlinkUIView();

            SetNativeControl(textView);

            SetText();
        }

        private void Element_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == HyperLinkControl.RawTextProperty.PropertyName)
                SetText();
        }

        private void SetText()
        {
            CTStringAttributes attrs = new CTStringAttributes();
            string text = Element.GetText(out List<HyperControlLink> links);
            if (text != null)
            {
                var str = new NSMutableAttributedString(text);
                str.AddAttribute(UIStringAttributeKey.Font, Element.Font.ToUIFont(), new NSRange(0, str.Length));
                var textColor = (Color)Element.GetValue(Label.TextColorProperty);
                str.AddAttribute(UIStringAttributeKey.ForegroundColor, textColor.ToUIColor(Color.Black),
                    new NSRange(0, str.Length));

                foreach (var item in links)
                {
                    str.AddAttribute(UIStringAttributeKey.Link, new NSUrl(item.Link), new NSRange(item.Start, item.Text.Length));
                }
                Control.AttributedText = str;
            }
        }
    }
}