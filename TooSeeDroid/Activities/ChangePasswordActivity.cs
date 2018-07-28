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
    [Activity(Label = "ChangePasswordActivity", Theme = "@android:style/Theme.Black.NoTitleBar")]
    public class ChangePasswordActivity : Activity
    {
        TextView changePasswordTV, oldPasswordTV, newPasswordTV, repeatPasswordTV;
        EditText oldPasswordET, newPasswordET, repeatPasswordET;
        Button changeBn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ChangePassword);

            changePasswordTV = FindViewById<TextView>(Resource.Id.changePasswordTV);
            oldPasswordTV = FindViewById<TextView>(Resource.Id.oldPasswordTV);
            newPasswordTV = FindViewById<TextView>(Resource.Id.newPasswordTV);
            repeatPasswordTV = FindViewById<TextView>(Resource.Id.repeatPasswordTV);
            oldPasswordET = FindViewById<EditText>(Resource.Id.oldPasswordET);
            newPasswordET = FindViewById<EditText>(Resource.Id.newPasswordET);
            repeatPasswordET = FindViewById<EditText>(Resource.Id.repeatPasswordET);
            changeBn = FindViewById<Button>(Resource.Id.changeBn);

            var ci = NativeClasses.GetCurrentCulture.GetCurrentCultureInfo();
            changePasswordTV.Text = TranslationHelper.GetString("ChangePassword", ci);
            oldPasswordTV.Text = TranslationHelper.GetString("OldPassword", ci);
            newPasswordTV.Text = TranslationHelper.GetString("NewPassword", ci);
            repeatPasswordTV.Text = TranslationHelper.GetString("RepeatPassword", ci);
            changeBn.Text = TranslationHelper.GetString("Next", ci);
        }
    }
}