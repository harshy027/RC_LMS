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
	public class Notification_msg : Activity
	{
		public Notification_msg (){
		}

		public void ShowLoginSuccessfull()
		{
			FindViewById<TextView> (Resource.Id.loginMsg).Text = "Login Sucessfull..!!!";
			FindViewById<TextView> (Resource.Id.loginMsg).Visibility = ViewStates.Visible;
			//	FindViewById<TextView> (Resource.Id.loginMsg).SetTextColor(color: ff00c853);
		}

		public void ShowIncorrectUserID()
		{
			FindViewById<TextView> (Resource.Id.loginMsg).Text = "Invalid User ID";
			FindViewById<TextView> (Resource.Id.loginMsg).Visibility = ViewStates.Visible;
			//			FindViewById<TextView> (Resource.Id.loginMsg).SetTextColor(color: ff00c853);
		}

		public void ShowInvalidPassword()
		{
			FindViewById<TextView> (Resource.Id.loginMsg).Text = "Invalid Password";
			FindViewById<TextView> (Resource.Id.loginMsg).Visibility = ViewStates.Visible;
			//			FindViewById<TextView> (Resource.Id.loginMsg).SetTextColor(color: ff00c853);
		}
	}
}

