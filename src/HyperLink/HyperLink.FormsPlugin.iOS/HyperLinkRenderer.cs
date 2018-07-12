using CoreGraphics;
using Foundation;
using HyperLink.FormsPlugin.Abstractions;
using HyperLink.FormsPlugin.iOS;
using System;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(HyperLinkControl), typeof(HyperLinkRenderer))]

namespace HyperLink.FormsPlugin.iOS
{
    public class HyperLinkRenderer : ViewRenderer<Label, UITextView>
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public async static void Init()
        {
            var temp = DateTime.Now;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="e"></param>
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            var view = (HyperLinkControl)Element;
            if (view == null) return;

            UITextView textView = new UITextView(new CGRect(0, 0, view.Width, view.Height));
            textView.Text = view.Text;
            textView.Font = UIFont.SystemFontOfSize((float)view.FontSize);
            textView.Editable = false;
            textView.Bounces = false;

            // Setting the data detector types mask to capture all types of link-able data
            textView.DataDetectorTypes = UIDataDetectorType.All;
            textView.BackgroundColor = UIColor.Clear;

            // overriding Xamarin Forms Label and replace with our native control
            SetNativeControl(textView);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            var view = (HyperLinkControl)Element;
            if (view == null) return;

            UITextView textView;

            if (Control == null)
            {
                textView = new UITextView();
                SetNativeControl(textView);
            }
            else if (e.PropertyName == Label.TextProperty.PropertyName)
            {
                if (Element != null && !string.IsNullOrWhiteSpace(Element.Text))
                {
                    var attr = new NSAttributedStringDocumentAttributes();
                    var nsError = new NSError();
                    attr.DocumentType = NSDocumentType.HTML;

                    var myHtmlData = NSData.FromString(view.Text, NSStringEncoding.Unicode);
                    Control.AttributedText = new NSAttributedString(myHtmlData, attr, ref nsError);
                }
            }
        }
    }
}
