using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_params']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/session_params", DoNotGenerateAcw=true)]
	public partial class Session_params : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_params']/field[@name='swigCMemOwn']"
		[Register ("swigCMemOwn")]
		protected bool SwigCMemOwn {
			get {
				const string __id = "swigCMemOwn.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "swigCMemOwn.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/session_params", typeof (Session_params));
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

		protected Session_params (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_params']/constructor[@name='session_params' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Session_params ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_params']/constructor[@name='session_params' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.session_params']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/session_params;)V", "")]
		public unsafe Session_params (global::FrostWire.Libtorrent.Swig.Session_params arg0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/session_params;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((arg0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_params']/constructor[@name='session_params' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.settings_pack']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/settings_pack;)V", "")]
		public unsafe Session_params (global::FrostWire.Libtorrent.Swig.Settings_pack sp)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/settings_pack;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sp).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_params']/constructor[@name='session_params' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Session_params (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getDht_settings;
#pragma warning disable 0169
		static Delegate GetGetDht_settingsHandler ()
		{
			if (cb_getDht_settings == null)
				cb_getDht_settings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDht_settings);
			return cb_getDht_settings;
		}

		static IntPtr n_GetDht_settings (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Dht_settings);
		}
#pragma warning restore 0169

		static Delegate cb_setDht_settings_Lcom_frostwire_jlibtorrent_swig_dht_settings_;
#pragma warning disable 0169
		static Delegate GetSetDht_settings_Lcom_frostwire_jlibtorrent_swig_dht_settings_Handler ()
		{
			if (cb_setDht_settings_Lcom_frostwire_jlibtorrent_swig_dht_settings_ == null)
				cb_setDht_settings_Lcom_frostwire_jlibtorrent_swig_dht_settings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDht_settings_Lcom_frostwire_jlibtorrent_swig_dht_settings_);
			return cb_setDht_settings_Lcom_frostwire_jlibtorrent_swig_dht_settings_;
		}

		static void n_SetDht_settings_Lcom_frostwire_jlibtorrent_swig_dht_settings_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Session_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Dht_settings value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Dht_settings = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Dht_settings Dht_settings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_params']/method[@name='getDht_settings' and count(parameter)=0]"
			[Register ("getDht_settings", "()Lcom/frostwire/jlibtorrent/swig/dht_settings;", "GetGetDht_settingsHandler")]
			get {
				const string __id = "getDht_settings.()Lcom/frostwire/jlibtorrent/swig/dht_settings;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_params']/method[@name='setDht_settings' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_settings']]"
			[Register ("setDht_settings", "(Lcom/frostwire/jlibtorrent/swig/dht_settings;)V", "GetSetDht_settings_Lcom_frostwire_jlibtorrent_swig_dht_settings_Handler")]
			set {
				const string __id = "setDht_settings.(Lcom/frostwire/jlibtorrent/swig/dht_settings;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDht_state;
#pragma warning disable 0169
		static Delegate GetGetDht_stateHandler ()
		{
			if (cb_getDht_state == null)
				cb_getDht_state = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDht_state);
			return cb_getDht_state;
		}

		static IntPtr n_GetDht_state (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Dht_state);
		}
#pragma warning restore 0169

		static Delegate cb_setDht_state_Lcom_frostwire_jlibtorrent_swig_dht_state_;
#pragma warning disable 0169
		static Delegate GetSetDht_state_Lcom_frostwire_jlibtorrent_swig_dht_state_Handler ()
		{
			if (cb_setDht_state_Lcom_frostwire_jlibtorrent_swig_dht_state_ == null)
				cb_setDht_state_Lcom_frostwire_jlibtorrent_swig_dht_state_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDht_state_Lcom_frostwire_jlibtorrent_swig_dht_state_);
			return cb_setDht_state_Lcom_frostwire_jlibtorrent_swig_dht_state_;
		}

		static void n_SetDht_state_Lcom_frostwire_jlibtorrent_swig_dht_state_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Session_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Dht_state value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_state> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Dht_state = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Dht_state Dht_state {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_params']/method[@name='getDht_state' and count(parameter)=0]"
			[Register ("getDht_state", "()Lcom/frostwire/jlibtorrent/swig/dht_state;", "GetGetDht_stateHandler")]
			get {
				const string __id = "getDht_state.()Lcom/frostwire/jlibtorrent/swig/dht_state;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_state> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_params']/method[@name='setDht_state' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_state']]"
			[Register ("setDht_state", "(Lcom/frostwire/jlibtorrent/swig/dht_state;)V", "GetSetDht_state_Lcom_frostwire_jlibtorrent_swig_dht_state_Handler")]
			set {
				const string __id = "setDht_state.(Lcom/frostwire/jlibtorrent/swig/dht_state;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSettings;
#pragma warning disable 0169
		static Delegate GetGetSettingsHandler ()
		{
			if (cb_getSettings == null)
				cb_getSettings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSettings);
			return cb_getSettings;
		}

		static IntPtr n_GetSettings (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Settings);
		}
#pragma warning restore 0169

		static Delegate cb_setSettings_Lcom_frostwire_jlibtorrent_swig_settings_pack_;
#pragma warning disable 0169
		static Delegate GetSetSettings_Lcom_frostwire_jlibtorrent_swig_settings_pack_Handler ()
		{
			if (cb_setSettings_Lcom_frostwire_jlibtorrent_swig_settings_pack_ == null)
				cb_setSettings_Lcom_frostwire_jlibtorrent_swig_settings_pack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSettings_Lcom_frostwire_jlibtorrent_swig_settings_pack_);
			return cb_setSettings_Lcom_frostwire_jlibtorrent_swig_settings_pack_;
		}

		static void n_SetSettings_Lcom_frostwire_jlibtorrent_swig_settings_pack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Session_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Settings_pack value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Settings = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Settings_pack Settings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_params']/method[@name='getSettings' and count(parameter)=0]"
			[Register ("getSettings", "()Lcom/frostwire/jlibtorrent/swig/settings_pack;", "GetGetSettingsHandler")]
			get {
				const string __id = "getSettings.()Lcom/frostwire/jlibtorrent/swig/settings_pack;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_params']/method[@name='setSettings' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.settings_pack']]"
			[Register ("setSettings", "(Lcom/frostwire/jlibtorrent/swig/settings_pack;)V", "GetSetSettings_Lcom_frostwire_jlibtorrent_swig_settings_pack_Handler")]
			set {
				const string __id = "setSettings.(Lcom/frostwire/jlibtorrent/swig/settings_pack;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_delete;
#pragma warning disable 0169
		static Delegate GetDeleteHandler ()
		{
			if (cb_delete == null)
				cb_delete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Delete);
			return cb_delete;
		}

		static void n_Delete (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_params']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_params']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.session_params']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/session_params;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Session_params obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/session_params;)J";
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
