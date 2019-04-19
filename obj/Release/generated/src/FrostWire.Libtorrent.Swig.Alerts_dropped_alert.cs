using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alerts_dropped_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/alerts_dropped_alert", DoNotGenerateAcw=true)]
	public partial class Alerts_dropped_alert : global::FrostWire.Libtorrent.Swig.Alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alerts_dropped_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alerts_dropped_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alerts_dropped_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/alerts_dropped_alert", typeof (Alerts_dropped_alert));
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

		protected Alerts_dropped_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alerts_dropped_alert']/constructor[@name='alerts_dropped_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Alerts_dropped_alert (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getDropped_alerts;
#pragma warning disable 0169
		static Delegate GetGetDropped_alertsHandler ()
		{
			if (cb_getDropped_alerts == null)
				cb_getDropped_alerts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDropped_alerts);
			return cb_getDropped_alerts;
		}

		static IntPtr n_GetDropped_alerts (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Alerts_dropped_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alerts_dropped_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Dropped_alerts);
		}
#pragma warning restore 0169

		static Delegate cb_setDropped_alerts_Lcom_frostwire_jlibtorrent_swig_bitset_96_;
#pragma warning disable 0169
		static Delegate GetSetDropped_alerts_Lcom_frostwire_jlibtorrent_swig_bitset_96_Handler ()
		{
			if (cb_setDropped_alerts_Lcom_frostwire_jlibtorrent_swig_bitset_96_ == null)
				cb_setDropped_alerts_Lcom_frostwire_jlibtorrent_swig_bitset_96_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDropped_alerts_Lcom_frostwire_jlibtorrent_swig_bitset_96_);
			return cb_setDropped_alerts_Lcom_frostwire_jlibtorrent_swig_bitset_96_;
		}

		static void n_SetDropped_alerts_Lcom_frostwire_jlibtorrent_swig_bitset_96_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Alerts_dropped_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alerts_dropped_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Bitset_96 value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bitset_96> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Dropped_alerts = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Bitset_96 Dropped_alerts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alerts_dropped_alert']/method[@name='getDropped_alerts' and count(parameter)=0]"
			[Register ("getDropped_alerts", "()Lcom/frostwire/jlibtorrent/swig/bitset_96;", "GetGetDropped_alertsHandler")]
			get {
				const string __id = "getDropped_alerts.()Lcom/frostwire/jlibtorrent/swig/bitset_96;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bitset_96> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alerts_dropped_alert']/method[@name='setDropped_alerts' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.bitset_96']]"
			[Register ("setDropped_alerts", "(Lcom/frostwire/jlibtorrent/swig/bitset_96;)V", "GetSetDropped_alerts_Lcom_frostwire_jlibtorrent_swig_bitset_96_Handler")]
			set {
				const string __id = "setDropped_alerts.(Lcom/frostwire/jlibtorrent/swig/bitset_96;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alerts_dropped_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alerts_dropped_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/alerts_dropped_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Alerts_dropped_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/alerts_dropped_alert;)J";
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
