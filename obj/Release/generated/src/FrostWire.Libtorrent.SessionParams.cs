using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionParams']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/SessionParams", DoNotGenerateAcw=true)]
	public partial class SessionParams : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/SessionParams", typeof (SessionParams));
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

		protected SessionParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionParams']/constructor[@name='SessionParams' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SessionParams ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionParams']/constructor[@name='SessionParams' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.SettingsPack']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/SettingsPack;)V", "")]
		public unsafe SessionParams (global::FrostWire.Libtorrent.SettingsPack settings)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/SettingsPack;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((settings == null) ? IntPtr.Zero : ((global::Java.Lang.Object) settings).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionParams']/constructor[@name='SessionParams' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.session_params']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/session_params;)V", "")]
		public unsafe SessionParams (global::FrostWire.Libtorrent.Swig.Session_params p)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/session_params;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_settings;
#pragma warning disable 0169
		static Delegate GetSettingsHandler ()
		{
			if (cb_settings == null)
				cb_settings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Settings);
			return cb_settings;
		}

		static IntPtr n_Settings (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionParams __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Settings ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionParams']/method[@name='settings' and count(parameter)=0]"
		[Register ("settings", "()Lcom/frostwire/jlibtorrent/SettingsPack;", "GetSettingsHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.SettingsPack Settings ()
		{
			const string __id = "settings.()Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_swig;
#pragma warning disable 0169
		static Delegate GetSwigHandler ()
		{
			if (cb_swig == null)
				cb_swig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Swig);
			return cb_swig;
		}

		static IntPtr n_Swig (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionParams __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Swig ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionParams']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/session_params;", "GetSwigHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Session_params Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/session_params;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_params> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
