using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace BFPaperTabBarControllerBinding {

	[BaseType (typeof (UITabBarController))]
	public partial interface BFPaperTabBarController {

		[Export ("usesSmartColor")]
		bool UsesSmartColor { get; set; }

		[Export ("tapCircleColor")]
		UIColor TapCircleColor { get; set; }

		[Export ("backgroundFadeColor")]
		UIColor BackgroundFadeColor { get; set; }

		[Export ("rippleFromTapLocation")]
		bool RippleFromTapLocation { get; set; }

		[Export ("tapCircleDiameter")]
		float TapCircleDiameter { get; set; }

		[Export ("underlineColor")]
		UIColor UnderlineColor { get; set; }

		[Export ("underlineThickness")]
		float UnderlineThickness { get; set; }

		[Export ("showUnderline")]
		bool ShowUnderline { get; set; }

		[Export ("showTapCircleAndBackgroundFade")]
		bool ShowTapCircleAndBackgroundFade { get; set; }

		[Export ("selectTabAtIndex:animated:")]
		void SelectTabAtIndex (int index, bool animated);
	}
}

