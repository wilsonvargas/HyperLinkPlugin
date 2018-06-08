using HyperLink.FormsPlugin.Abstractions;
using System;
using Xamarin.Forms;
using HyperLink.FormsPlugin.UWP;
using Xamarin.Forms.Platform.UWP;

//[assembly: ExportRenderer(typeof(HyperLinkControl), typeof(HyperLinkRenderer))]
namespace HyperLink.FormsPlugin.UWP
{
    /// <summary>
    /// HyperLink Renderer
    /// </summary>
    public class HyperLinkRenderer : ViewRenderer
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init() { }
    }
}
