using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_removed_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/torrent_removed_alert", DoNotGenerateAcw=true)]
	public partial class Torrent_removed_alert : global::FrostWire.Libtorrent.Swig.Torrent_alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_removed_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_removed_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_removed_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/torrent_removed_alert", typeof (Torrent_removed_alert));
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

		protected Torrent_removed_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_removed_alert']/constructor[@name='torrent_removed_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Torrent_removed_alert (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getInfo_hash;
#pragma warning disable 0169
		static Delegate GetGetInfo_hashHandler ()
		{
			if (cb_getInfo_hash == null)
				cb_getInfo_hash = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInfo_hash);
			return cb_getInfo_hash;
		}

		static IntPtr n_GetInfo_hash (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_removed_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_removed_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Info_hash);
		}
#pragma warning restore 0169

		static Delegate cb_setInfo_hash_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetSetInfo_hash_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_setInfo_hash_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_setInfo_hash_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInfo_hash_Lcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_setInfo_hash_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static void n_SetInfo_hash_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_removed_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_removed_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Info_hash = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash Info_hash {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_removed_alert']/method[@name='getInfo_hash' and count(parameter)=0]"
			[Register ("getInfo_hash", "()Lcom/frostwire/jlibtorrent/swig/sha1_hash;", "GetGetInfo_hashHandler")]
			get {
				const string __id = "getInfo_hash.()Lcom/frostwire/jlibtorrent/swig/sha1_hash;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_removed_alert']/method[@name='setInfo_hash' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
			[Register ("setInfo_hash", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V", "GetSetInfo_hash_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
			set {
				const string __id = "setInfo_hash.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_removed_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_removed_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/torrent_removed_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Torrent_removed_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/torrent_removed_alert;)J";
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
