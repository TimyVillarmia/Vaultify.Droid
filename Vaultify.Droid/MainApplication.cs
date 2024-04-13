﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.Fragment;
using AndroidX.Fragment.App;
using AndroidX.Transitions;
using Firebase;
using Firebase.Firestore;
using Google.Android.Material.Button;
using Google.Android.Material.TextField;
using System;
using Vaultify.Droid.Activities;
using Vaultify.Droid.Common;
using Vaultify.Droid.Presenters;
using Vaultify.Droid.Resources.layout;

namespace Vaultify.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainApplication : AppCompatActivity
    {


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

           


            // TODO: Check current user signed in
            if (true)
            {
                StartActivity(new Intent(Application.Context, typeof(ActivitySignIn)));
                Finish();

            }

        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}