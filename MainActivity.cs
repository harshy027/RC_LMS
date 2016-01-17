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
	[Activity (Label = "RC_LMS", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		static readonly List<string> leave_info = new List<string>();
		public static EditText user_ID;
		public static EditText password; 

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			EditText used_ID = FindViewById<EditText> (Resource.Id.userID);
			EditText password =  FindViewById<EditText> (Resource.Id.pswrd);
			// Get our button from the layout resource,
			// and attach an event to it
			Button Login_btn = FindViewById<Button> (Resource.Id.Login_button);
			Login_btn.Click +=  Login_button_Click;



			}

		void Login_button_Click (object sender, EventArgs e)
		{
//				var intent = new Intent(this, typeof(LeaveSummaryPage));
//				intent.PutStringArrayListExtra("leave_summary", leave_info);
//				StartActivity(intent);
			Notification_msg notif = new Notification_msg();

			if (user_ID.Text == "@string/user") {
				if (password.Text == "@string/user_pswrd") {
					//Display login successfull notification
					notif.ShowLoginSuccessfull();
					// Set our view from the "main" layout resource
					SetContentView (Resource.Layout.LeaveSummary);
				} else {
					//Display incorrect password notification
					notif.ShowInvalidPassword();
				}
			}
			else{
				//Display incorrect user id notification
				notif.ShowIncorrectUserID();
			}
			}
		}
		
		}
	



