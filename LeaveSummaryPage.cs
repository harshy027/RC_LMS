
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

namespace RC_LMS
{
	[Activity (Label = "LeaveSummaryPage")]			
	public class LeaveSummaryPage : ListActivity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your application here
//			ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
//			SetContentView(Resource.Layout.Main);
//
//			ActionBar.Tab tab = ActionBar.NewTab();
//			tab.SetText(Resources.GetString(Resource.String.tab1_text));
//			tab.SetIcon(Resource.Drawable.tab1_icon);
//			tab.TabSelected += (sender, args) => {
//				// Do something when tab is selected
//			};
//				ActionBar.AddTab(tab);
//
//			tab = ActionBar.NewTab();
//			tab.SetText(Resources.GetString(Resource.String.tab2_text));
//			tab.SetIcon(Resource.Drawable.tab2_icon);
//			tab.TabSelected += (sender, args) => {
//				// Do something when tab is selected
//			};
//				ActionBar.AddTab(tab);
		}
	}

};

