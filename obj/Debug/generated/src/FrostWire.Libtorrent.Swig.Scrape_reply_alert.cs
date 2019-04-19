using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='scrape_reply_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/scrape_reply_alert", DoNotGenerateAcw=true)]
	public partial class Scrape_reply_alert : global::FrostWire.Libtorrent.Swig.Tracker_alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='scrape_reply_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='scrape_reply_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='scrape_reply_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/scrape_reply_alert", typeof (Scrape_reply_alert));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected Scrape_reply_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='scrape_reply_alert']/constructor[@name='scrape_reply_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Scrape_reply_alert (long cPtr, bool cMemoryOwn)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (cPtr);
				__args [1] = new JniArgumentValue (cMemoryOwn);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getComplete;
#pragma warning disable 0169
		static Delegate GetGetCompleteHandler ()
		{
			if (cb_getComplete == null)
				cb_getComplete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetComplete);
			return cb_getComplete;
		}

		static int n_GetComplete (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Scrape_reply_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Scrape_reply_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Complete;
		}
#pragma warning restore 0169

		public virtual unsafe int Complete {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='scrape_reply_alert']/method[@name='getComplete' and count(parameter)=0]"
			[Register ("getComplete", "()I", "GetGetCompleteHandler")]
			get {
				const string __id = "getComplete.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIncomplete;
#pragma warning disable 0169
		static Delegate GetGetIncompleteHandler ()
		{
			if (cb_getIncomplete == null)
				cb_getIncomplete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIncomplete);
			return cb_getIncomplete;
		}

		static int n_GetIncomplete (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Scrape_reply_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Scrape_reply_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Incomplete;
		}
#pragma warning restore 0169

		public virtual unsafe int Incomplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='scrape_reply_alert']/method[@name='getIncomplete' and count(parameter)=0]"
			[Register ("getIncomplete", "()I", "GetGetIncompleteHandler")]
			get {
				const string __id = "getIncomplete.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='scrape_reply_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.scrape_reply_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/scrape_reply_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Scrape_reply_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/scrape_reply_alert;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
