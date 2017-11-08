using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Ontap.CustomRenderer;
using Ontap.Droid;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomEntryUsername), typeof(CustomEntry_Username))]
namespace Ontap.Droid
{
    using Android.Graphics.Drawables;
    using Xamarin.Forms;
    using Xamarin.Forms.Platform.Android;
    class CustomEntry_Username : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control == null) return;
            var gradientDrawable = new GradientDrawable();
            gradientDrawable.SetShape(ShapeType.Rectangle);
            gradientDrawable.SetAlpha(240);
            gradientDrawable.SetColor(Element.PlaceholderColor.ToAndroid(Color.FromRgb(204, 204, 204)));
            gradientDrawable.SetStroke(4, (ColorStateList) Element.Placeholder);
            gradientDrawable.SetCornerRadius(20.0f);
            Control.SetBackground(gradientDrawable);
            Control.Hint = "Username";
        }
    }
}