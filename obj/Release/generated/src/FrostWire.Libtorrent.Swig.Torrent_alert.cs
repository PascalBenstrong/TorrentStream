using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/torrent_alert", DoNotGenerateAcw=true)]
	public partial class Torrent_alert : global::FrostWire.Libtorrent.Swig.Alert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/torrent_alert", typeof (Torrent_alert));
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

		protected Torrent_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_alert']/constructor[@name='torrent_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Torrent_alert (long cPtr, bool cMemoryOwn)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/torrent_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Torrent_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/torrent_alert;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getHandle;
#pragma warning disable 0169
		static Delegate GetGetHandleHandler ()
		{
			if (cb_getHandle == null)
				cb_getHandle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHandle);
			return cb_getHandle;
		}

		static IntPtr n_GetHandle (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetHandle ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_alert']/method[@name='getHandle' and count(parameter)=0]"
		[Register ("getHandle", "()Lcom/frostwire/jlibtorrent/swig/torrent_handle;", "GetGetHandleHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Torrent_handle GetHandle ()
		{
			const string __id = "getHandle.()Lcom/frostwire/jlibtorrent/swig/torrent_handle;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHandle_Lcom_frostwire_jlibtorrent_swig_torrent_handle_;
#pragma warning disable 0169
		static Delegate GetSetHandle_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Handler ()
		{
			if (cb_setHandle_Lcom_frostwire_jlibtorrent_swig_torrent_handle_ == null)
				cb_setHandle_Lcom_frostwire_jlibtorrent_swig_torrent_handle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHandle_Lcom_frostwire_jlibtorrent_swig_torrent_handle_);
			return cb_setHandle_Lcom_frostwire_jlibtorrent_swig_torrent_handle_;
		}

		static void n_SetHandle_Lcom_frostwire_jlibtorrent_swig_torrent_handle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Torrent_handle value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetHandle (value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_alert']/method[@name='setHandle' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_handle']]"
		[Register ("setHandle", "(Lcom/frostwire/jlibtorrent/swig/torrent_handle;)V", "GetSetHandle_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Handler")]
		public virtual unsafe void SetHandle (global::FrostWire.Libtorrent.Swig.Torrent_handle value)
		{
			const string __id = "setHandle.(Lcom/frostwire/jlibtorrent/swig/torrent_handle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_torrent_name;
#pragma warning disable 0169
		static Delegate GetTorrent_nameHandler ()
		{
			if (cb_torrent_name == null)
				cb_torrent_name = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Torrent_name);
			return cb_torrent_name;
		}

		static IntPtr n_Torrent_name (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Torrent_name ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_alert']/method[@name='torrent_name' and count(parameter)=0]"
		[Register ("torrent_name", "()Ljava/lang/String;", "GetTorrent_nameHandler")]
		public virtual unsafe string Torrent_name ()
		{
			const string __id = "torrent_name.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
