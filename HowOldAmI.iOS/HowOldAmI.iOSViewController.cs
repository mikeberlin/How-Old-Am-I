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
			base.DidReceiveMemoryWarning ();
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
			var ageDisplay = string.Format("You're {0} years young today.", HowOldAmI());

			UIAlertView alert = new UIAlertView("Look at you!", ageDisplay, null, "Sweet!", null);
			alert.Show();
		}

		private int HowOldAmI()
		{
			var selectedBirthday = DateTime.SpecifyKind (birthdayPicker.Date, DateTimeKind.Unspecified).Date;
			var today = DateTime.Today;

			int years = (today.Year - selectedBirthday.Year);
			if (selectedBirthday > today.AddYears(-years)) years--;

			return years;
		}
	}
}