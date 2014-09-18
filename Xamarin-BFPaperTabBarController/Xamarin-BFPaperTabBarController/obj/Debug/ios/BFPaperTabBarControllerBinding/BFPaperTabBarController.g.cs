//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using MonoTouch.UIKit;
using MonoTouch.GLKit;
using MonoTouch.MapKit;
using MonoTouch.Security;
using MonoTouch.CoreVideo;
using MonoTouch.CoreMedia;
using MonoTouch.QuickLook;
using MonoTouch.Foundation;
using MonoTouch.CoreMotion;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreLocation;
using MonoTouch.NewsstandKit;
using MonoTouch.AVFoundation;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreFoundation;

namespace BFPaperTabBarControllerBinding {
	[Register("BFPaperTabBarController", true)]
	public unsafe partial class BFPaperTabBarController : global::MonoTouch.UIKit.UITabBarController {
		[CompilerGenerated]
		const string selBackgroundFadeColor = "backgroundFadeColor";
		static readonly IntPtr selBackgroundFadeColorHandle = Selector.GetHandle ("backgroundFadeColor");
		[CompilerGenerated]
		const string selRippleFromTapLocation = "rippleFromTapLocation";
		static readonly IntPtr selRippleFromTapLocationHandle = Selector.GetHandle ("rippleFromTapLocation");
		[CompilerGenerated]
		const string selSelectTabAtIndexAnimated_ = "selectTabAtIndex:animated:";
		static readonly IntPtr selSelectTabAtIndexAnimated_Handle = Selector.GetHandle ("selectTabAtIndex:animated:");
		[CompilerGenerated]
		const string selSetBackgroundFadeColor_ = "setBackgroundFadeColor:";
		static readonly IntPtr selSetBackgroundFadeColor_Handle = Selector.GetHandle ("setBackgroundFadeColor:");
		[CompilerGenerated]
		const string selSetRippleFromTapLocation_ = "setRippleFromTapLocation:";
		static readonly IntPtr selSetRippleFromTapLocation_Handle = Selector.GetHandle ("setRippleFromTapLocation:");
		[CompilerGenerated]
		const string selSetShowTapCircleAndBackgroundFade_ = "setShowTapCircleAndBackgroundFade:";
		static readonly IntPtr selSetShowTapCircleAndBackgroundFade_Handle = Selector.GetHandle ("setShowTapCircleAndBackgroundFade:");
		[CompilerGenerated]
		const string selSetShowUnderline_ = "setShowUnderline:";
		static readonly IntPtr selSetShowUnderline_Handle = Selector.GetHandle ("setShowUnderline:");
		[CompilerGenerated]
		const string selSetTapCircleColor_ = "setTapCircleColor:";
		static readonly IntPtr selSetTapCircleColor_Handle = Selector.GetHandle ("setTapCircleColor:");
		[CompilerGenerated]
		const string selSetTapCircleDiameter_ = "setTapCircleDiameter:";
		static readonly IntPtr selSetTapCircleDiameter_Handle = Selector.GetHandle ("setTapCircleDiameter:");
		[CompilerGenerated]
		const string selSetUnderlineColor_ = "setUnderlineColor:";
		static readonly IntPtr selSetUnderlineColor_Handle = Selector.GetHandle ("setUnderlineColor:");
		[CompilerGenerated]
		const string selSetUnderlineThickness_ = "setUnderlineThickness:";
		static readonly IntPtr selSetUnderlineThickness_Handle = Selector.GetHandle ("setUnderlineThickness:");
		[CompilerGenerated]
		const string selSetupBFPaperTabBarController = "setupBFPaperTabBarController";
		static readonly IntPtr selSetupBFPaperTabBarControllerHandle = Selector.GetHandle ("setupBFPaperTabBarController");
		[CompilerGenerated]
		const string selSetUsesSmartColor_ = "setUsesSmartColor:";
		static readonly IntPtr selSetUsesSmartColor_Handle = Selector.GetHandle ("setUsesSmartColor:");
		[CompilerGenerated]
		const string selShowTapCircleAndBackgroundFade = "showTapCircleAndBackgroundFade";
		static readonly IntPtr selShowTapCircleAndBackgroundFadeHandle = Selector.GetHandle ("showTapCircleAndBackgroundFade");
		[CompilerGenerated]
		const string selShowUnderline = "showUnderline";
		static readonly IntPtr selShowUnderlineHandle = Selector.GetHandle ("showUnderline");
		[CompilerGenerated]
		const string selTapCircleColor = "tapCircleColor";
		static readonly IntPtr selTapCircleColorHandle = Selector.GetHandle ("tapCircleColor");
		[CompilerGenerated]
		const string selTapCircleDiameter = "tapCircleDiameter";
		static readonly IntPtr selTapCircleDiameterHandle = Selector.GetHandle ("tapCircleDiameter");
		[CompilerGenerated]
		const string selUnderlineColor = "underlineColor";
		static readonly IntPtr selUnderlineColorHandle = Selector.GetHandle ("underlineColor");
		[CompilerGenerated]
		const string selUnderlineThickness = "underlineThickness";
		static readonly IntPtr selUnderlineThicknessHandle = Selector.GetHandle ("underlineThickness");
		[CompilerGenerated]
		const string selUsesSmartColor = "usesSmartColor";
		static readonly IntPtr selUsesSmartColorHandle = Selector.GetHandle ("usesSmartColor");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("BFPaperTabBarController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public BFPaperTabBarController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::MonoTouch.ObjCRuntime.Selector.Init), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::MonoTouch.ObjCRuntime.Selector.Init), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public BFPaperTabBarController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public BFPaperTabBarController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public BFPaperTabBarController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("selectTabAtIndex:animated:")]
		[CompilerGenerated]
		public virtual void SelectTabAtIndex (int index, bool animated)
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_int_bool (this.Handle, selSelectTabAtIndexAnimated_Handle, index, animated);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_int_bool (this.SuperHandle, selSelectTabAtIndexAnimated_Handle, index, animated);
			}
		}
		
		[Export ("setupBFPaperTabBarController")]
		[CompilerGenerated]
		public virtual void SetupBFPaperTabBarController ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, selSetupBFPaperTabBarControllerHandle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, selSetupBFPaperTabBarControllerHandle);
			}
		}
		
		[CompilerGenerated]
		object __mt_BackgroundFadeColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor BackgroundFadeColor {
			[Export ("backgroundFadeColor")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selBackgroundFadeColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selBackgroundFadeColorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackgroundFadeColor_var = ret;
				return ret;
			}
			
			[Export ("setBackgroundFadeColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBackgroundFadeColor_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetBackgroundFadeColor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_BackgroundFadeColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool RippleFromTapLocation {
			[Export ("rippleFromTapLocation")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selRippleFromTapLocationHandle);
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selRippleFromTapLocationHandle);
				}
			}
			
			[Export ("setRippleFromTapLocation:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, selSetRippleFromTapLocation_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetRippleFromTapLocation_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowTapCircleAndBackgroundFade {
			[Export ("showTapCircleAndBackgroundFade")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selShowTapCircleAndBackgroundFadeHandle);
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowTapCircleAndBackgroundFadeHandle);
				}
			}
			
			[Export ("setShowTapCircleAndBackgroundFade:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowTapCircleAndBackgroundFade_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowTapCircleAndBackgroundFade_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowUnderline {
			[Export ("showUnderline")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selShowUnderlineHandle);
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShowUnderlineHandle);
				}
			}
			
			[Export ("setShowUnderline:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, selSetShowUnderline_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShowUnderline_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_TapCircleColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor TapCircleColor {
			[Export ("tapCircleColor")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selTapCircleColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTapCircleColorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TapCircleColor_var = ret;
				return ret;
			}
			
			[Export ("setTapCircleColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTapCircleColor_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTapCircleColor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_TapCircleColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float TapCircleDiameter {
			[Export ("tapCircleDiameter")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, selTapCircleDiameterHandle);
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, selTapCircleDiameterHandle);
				}
			}
			
			[Export ("setTapCircleDiameter:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, selSetTapCircleDiameter_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetTapCircleDiameter_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_UnderlineColor_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIColor UnderlineColor {
			[Export ("underlineColor")]
			get {
				global::MonoTouch.UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selUnderlineColorHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIColor> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUnderlineColorHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UnderlineColor_var = ret;
				return ret;
			}
			
			[Export ("setUnderlineColor:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUnderlineColor_Handle, value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUnderlineColor_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UnderlineColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float UnderlineThickness {
			[Export ("underlineThickness")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, selUnderlineThicknessHandle);
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, selUnderlineThicknessHandle);
				}
			}
			
			[Export ("setUnderlineThickness:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, selSetUnderlineThickness_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetUnderlineThickness_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool UsesSmartColor {
			[Export ("usesSmartColor")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selUsesSmartColorHandle);
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selUsesSmartColorHandle);
				}
			}
			
			[Export ("setUsesSmartColor:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesSmartColor_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetUsesSmartColor_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BackgroundFadeColor_var = null;
				__mt_TapCircleColor_var = null;
				__mt_UnderlineColor_var = null;
			}
		}
	} /* class BFPaperTabBarController */
}
