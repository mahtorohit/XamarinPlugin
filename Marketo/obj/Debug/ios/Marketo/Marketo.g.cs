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
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace Marketo {
	[Register("Marketo", true)]
	public unsafe partial class Marketo : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Marketo");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected Marketo (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Marketo (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("application:openURL:sourceApplication:annotation:")]
		[CompilerGenerated]
		public virtual bool Application (global::UIKit.UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
		{
			if (application == null)
				throw new ArgumentNullException ("application");
			if (url == null)
				throw new ArgumentNullException ("url");
			if (sourceApplication == null)
				throw new ArgumentNullException ("sourceApplication");
			if (annotation == null)
				throw new ArgumentNullException ("annotation");
			var nssourceApplication = NSString.CreateNative (sourceApplication);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("application:openURL:sourceApplication:annotation:"), application.Handle, url.Handle, nssourceApplication, annotation.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("application:openURL:sourceApplication:annotation:"), application.Handle, url.Handle, nssourceApplication, annotation.Handle);
			}
			NSString.ReleaseNative (nssourceApplication);
			
			return ret;
		}
		
		[Export ("application:didReceiveLocalNotification:")]
		[CompilerGenerated]
		public virtual void Application (global::UIKit.UIApplication application, global::UIKit.UILocalNotification notification)
		{
			if (application == null)
				throw new ArgumentNullException ("application");
			if (notification == null)
				throw new ArgumentNullException ("notification");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("application:didReceiveLocalNotification:"), application.Handle, notification.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("application:didReceiveLocalNotification:"), application.Handle, notification.Handle);
			}
		}
		
		[Export ("associateLead:")]
		[CompilerGenerated]
		public virtual void AssociateLead (NSObject lead)
		{
			if (lead == null)
				throw new ArgumentNullException ("lead");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("associateLead:"), lead.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("associateLead:"), lead.Handle);
			}
		}
		
		[Export ("getDeviceId")]
		[CompilerGenerated]
		public virtual string DeviceId ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getDeviceId")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDeviceId")));
			}
		}
		
		[Export ("handlePushNotification:")]
		[CompilerGenerated]
		public virtual void HandlePushNotification (NSDictionary userInfo)
		{
			if (userInfo == null)
				throw new ArgumentNullException ("userInfo");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("handlePushNotification:"), userInfo.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("handlePushNotification:"), userInfo.Handle);
			}
		}
		
		[Export ("initializeWithMunchkinID:appSecret:launchOptions:")]
		[CompilerGenerated]
		public virtual void InitializeWithMunchkinID (string munchkinID, string appSecret, NSDictionary launchOptions)
		{
			if (munchkinID == null)
				throw new ArgumentNullException ("munchkinID");
			if (appSecret == null)
				throw new ArgumentNullException ("appSecret");
			if (launchOptions == null)
				throw new ArgumentNullException ("launchOptions");
			var nsmunchkinID = NSString.CreateNative (munchkinID);
			var nsappSecret = NSString.CreateNative (appSecret);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initializeWithMunchkinID:appSecret:launchOptions:"), nsmunchkinID, nsappSecret, launchOptions.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initializeWithMunchkinID:appSecret:launchOptions:"), nsmunchkinID, nsappSecret, launchOptions.Handle);
			}
			NSString.ReleaseNative (nsmunchkinID);
			NSString.ReleaseNative (nsappSecret);
			
		}
		
		[Export ("registerPushDeviceToken:")]
		[CompilerGenerated]
		public virtual void RegisterPushDeviceToken (NSData deviceToken)
		{
			if (deviceToken == null)
				throw new ArgumentNullException ("deviceToken");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("registerPushDeviceToken:"), deviceToken.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("registerPushDeviceToken:"), deviceToken.Handle);
			}
		}
		
		[Export ("removeSecureSignature")]
		[CompilerGenerated]
		public virtual void RemoveSecureSignature ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeSecureSignature"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("removeSecureSignature"));
			}
		}
		
		[Export ("reportAction:withMetaData:")]
		[CompilerGenerated]
		public virtual void ReportAction (string actionName, NSObject metaData)
		{
			if (actionName == null)
				throw new ArgumentNullException ("actionName");
			if (metaData == null)
				throw new ArgumentNullException ("metaData");
			var nsactionName = NSString.CreateNative (actionName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("reportAction:withMetaData:"), nsactionName, metaData.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("reportAction:withMetaData:"), nsactionName, metaData.Handle);
			}
			NSString.ReleaseNative (nsactionName);
			
		}
		
		[Export ("setSecureSignature:")]
		[CompilerGenerated]
		public virtual void SetSecureSignature (NSObject conf)
		{
			if (conf == null)
				throw new ArgumentNullException ("conf");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSecureSignature:"), conf.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSecureSignature:"), conf.Handle);
			}
		}
		
		[Export ("setTimeoutInterval:")]
		[CompilerGenerated]
		public virtual void SetTimeoutInterval (global::System.nint seconds)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setTimeoutInterval:"), seconds);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setTimeoutInterval:"), seconds);
			}
		}
		
		[Export ("sharedInstance")]
		[CompilerGenerated]
		public static Marketo sharedInstance ()
		{
			return  Runtime.GetNSObject<Marketo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")));
		}
		
		[Export ("trackPushNotification:")]
		[CompilerGenerated]
		public virtual void TrackPushNotification (NSDictionary userInfo)
		{
			if (userInfo == null)
				throw new ArgumentNullException ("userInfo");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("trackPushNotification:"), userInfo.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("trackPushNotification:"), userInfo.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual string AppSecret {
			[Export ("appSecret")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("appSecret")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("appSecret")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsPushRegistered {
			[Export ("isPushRegistered")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPushRegistered"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isPushRegistered"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsSecureModeEnabled {
			[Export ("isSecureModeEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSecureModeEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSecureModeEnabled"));
				}
			}
			
		}
		
	} /* class Marketo */
}