// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace HowOldAmI.iOS
{
	[Register ("HowOldAmI_iOSViewController")]
	partial class HowOldAmI_iOSViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIDatePicker birthdayPicker { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnHowOldAmI { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (birthdayPicker != null) {
				birthdayPicker.Dispose ();
				birthdayPicker = null;
			}
			if (btnHowOldAmI != null) {
				btnHowOldAmI.Dispose ();
				btnHowOldAmI = null;
			}
		}
	}
}
