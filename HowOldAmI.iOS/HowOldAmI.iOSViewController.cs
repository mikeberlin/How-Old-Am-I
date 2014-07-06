using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HowOldAmI.iOS
{
	public partial class HowOldAmI_iOSViewController : UIViewController
	{
		public HowOldAmI_iOSViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion

		partial void btnHowOldAmI_TouchUpInside (UIButton sender)
		{
			var ageDisplay = string.Format("You're {0} years old today.", HowOldAmI());

			UIAlertView alert = new UIAlertView("Looking good!", ageDisplay, null, "Thanks!", null);
			alert.Show();
		}

		private int HowOldAmI()
		{
			var selectedBirthday = DateTime.SpecifyKind (birthdayPicker.Date, DateTimeKind.Unspecified);

			/*
			//assume 365.25 days per year for leap years
			var daysDifference = (DateTime.Now - selectedBirthday).TotalDays;
			double years = (int)Math.Floor(daysDifference / 365.25f);
			*/

			int years = (DateTime.Now.Year - selectedBirthday.Year);
			if (selectedBirthday > DateTime.Now.AddYears(-years)) years--;

			return years;
		}
	}
}