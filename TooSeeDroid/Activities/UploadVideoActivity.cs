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
using TooSeePCL;

namespace TooSeeDroid.Activities
{
    [Activity(Label = "UploadVideoActivity", Theme = "@android:style/Theme.Black.NoTitleBar")]
    public class UploadVideoActivity : Activity
    {
        TextView uploadVideoTV, videoNameTV, videoDescriptionTV;
        EditText videoNameET, yearET;
        Button nextBn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.UploadVideo);

            uploadVideoTV = FindViewById<TextView>(Resource.Id.uploadVideoTV);
            videoNameTV = FindViewById<TextView>(Resource.Id.videoNameTV);
            videoDescriptionTV = FindViewById<TextView>(Resource.Id.videoDescriptionTV);
            videoNameET = FindViewById<EditText>(Resource.Id.videoNameET);
            yearET = FindViewById<EditText>(Resource.Id.yearET);
            nextBn = FindViewById<Button>(Resource.Id.nextBn);

            var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();
            uploadVideoTV.Text = TranslationHelper.GetString("UploadVideo", ci);
            videoNameTV.Text = TranslationHelper.GetString("VideoName", ci);
            videoDescriptionTV.Text = TranslationHelper.GetString("Description", ci);
            nextBn.Text = TranslationHelper.GetString("Next", ci);
        }
    }
}