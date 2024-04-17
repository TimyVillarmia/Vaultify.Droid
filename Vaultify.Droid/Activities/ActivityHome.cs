﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using AndroidX.AppCompat.Widget;
using AndroidX.DrawerLayout.Widget;
using Google.Android.Material.AppBar;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Snackbar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vaultify.Droid.Activities
{
    [Activity(Label = "ActivityHome")]
    public class ActivityHome : AppCompatActivity   
    {

        DrawerLayout drawerLayout;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.home);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.floating_action_button);
            drawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawerLayout);
            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);


            SetSupportActionBar(toolbar);

            toolbar.NavigationClick += Toolbar_NavigationClick;
            fab.Click += FabOnClick;

        }

        private void Toolbar_NavigationClick(object sender, Toolbar.NavigationClickEventArgs e)
        {
            drawerLayout.Open();
            //test
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.top_app_bar, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }


        private void FabOnClick(object sender, EventArgs e)
        {
            View view = (View)sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (View.IOnClickListener)null).Show();
        }
    }
}