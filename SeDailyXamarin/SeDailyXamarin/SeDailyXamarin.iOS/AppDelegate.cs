﻿
using Foundation;
using UIKit;

namespace SeDailyXamarin.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			LoadApplication(new App());
            System.Diagnostics.Debug.WriteLine("Testing");
			return base.FinishedLaunching(app, options);
		}
	}
}
