using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Util;
using Ontap.CustomRenderer;
using Ontap.Droid;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButton_Login))]
namespace Ontap.Droid
{
    using Android.Graphics.Drawables;
    using Xamarin.Forms;
    using Xamarin.Forms.Platform.Android;
    class CustomButton_Login : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control == null) return;
            var gradientDrawable = new GradientDrawable();
            gradientDrawable.SetShape(ShapeType.Rectangle);
            gradientDrawable.SetAlpha(240);
            gradientDrawable.SetColor(Element.BackgroundColor.ToAndroid(Color.FromRgb(109, 180, 221)));
            gradientDrawable.SetStroke(4, Element.BorderColor.ToAndroid());
            gradientDrawable.SetCornerRadius(20.0f);
            Control.SetAllCaps(false);
            Control.SetBackground(gradientDrawable);
        }
    }
}