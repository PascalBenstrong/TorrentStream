using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/SessionManager", DoNotGenerateAcw=true)]
	public partial class SessionManager : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager.MutableItem']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/SessionManager$MutableItem", DoNotGenerateAcw=true)]
		public sealed partial class MutableItem : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager.MutableItem']/field[@name='item']"
			[Register ("item")]
			public global::FrostWire.Libtorrent.Entry Item {
				get {
					const string __id = "item.Lcom/frostwire/jlibtorrent/Entry;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Entry> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "item.Lcom/frostwire/jlibtorrent/Entry;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager.MutableItem']/field[@name='seq']"
			[Register ("seq")]
			public long Seq {
				get {
					const string __id = "seq.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "seq.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager.MutableItem']/field[@name='signature']"
			[Register ("signature")]
			public IList<byte> Signature {
				get {
					const string __id = "signature.[B";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "signature.[B";

					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/SessionManager$MutableItem", typeof (MutableItem));
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

			internal MutableItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/SessionManager", typeof (SessionManager));
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

		protected SessionManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/constructor[@name='SessionManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SessionManager ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/constructor[@name='SessionManager' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe SessionManager (bool logging)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (logging);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isDhtRunning;
#pragma warning disable 0169
		static Delegate GetIsDhtRunningHandler ()
		{
			if (cb_isDhtRunning == null)
				cb_isDhtRunning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDhtRunning);
			return cb_isDhtRunning;
		}

		static bool n_IsDhtRunning (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDhtRunning;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDhtRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='isDhtRunning' and count(parameter)=0]"
			[Register ("isDhtRunning", "()Z", "GetIsDhtRunningHandler")]
			get {
				const string __id = "isDhtRunning.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isFirewalled;
#pragma warning disable 0169
		static Delegate GetIsFirewalledHandler ()
		{
			if (cb_isFirewalled == null)
				cb_isFirewalled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFirewalled);
			return cb_isFirewalled;
		}

		static bool n_IsFirewalled (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFirewalled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsFirewalled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='isFirewalled' and count(parameter)=0]"
			[Register ("isFirewalled", "()Z", "GetIsFirewalledHandler")]
			get {
				const string __id = "isFirewalled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isPaused;
#pragma warning disable 0169
		static Delegate GetIsPausedHandler ()
		{
			if (cb_isPaused == null)
				cb_isPaused = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPaused);
			return cb_isPaused;
		}

		static bool n_IsPaused (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='isPaused' and count(parameter)=0]"
			[Register ("isPaused", "()Z", "GetIsPausedHandler")]
			get {
				const string __id = "isPaused.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRunning);
			return cb_isRunning;
		}

		static bool n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				const string __id = "isRunning.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_addListener_Lcom_frostwire_jlibtorrent_AlertListener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Lcom_frostwire_jlibtorrent_AlertListener_Handler ()
		{
			if (cb_addListener_Lcom_frostwire_jlibtorrent_AlertListener_ == null)
				cb_addListener_Lcom_frostwire_jlibtorrent_AlertListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddListener_Lcom_frostwire_jlibtorrent_AlertListener_);
			return cb_addListener_Lcom_frostwire_jlibtorrent_AlertListener_;
		}

		static void n_AddListener_Lcom_frostwire_jlibtorrent_AlertListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.IAlertListener listener = (global::FrostWire.Libtorrent.IAlertListener)global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.IAlertListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.AddListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='addListener' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.AlertListener']]"
		[Register ("addListener", "(Lcom/frostwire/jlibtorrent/AlertListener;)V", "GetAddListener_Lcom_frostwire_jlibtorrent_AlertListener_Handler")]
		public virtual unsafe void AddListener (global::FrostWire.Libtorrent.IAlertListener listener)
		{
			const string __id = "addListener.(Lcom/frostwire/jlibtorrent/AlertListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_applySettings_Lcom_frostwire_jlibtorrent_SettingsPack_;
#pragma warning disable 0169
		static Delegate GetApplySettings_Lcom_frostwire_jlibtorrent_SettingsPack_Handler ()
		{
			if (cb_applySettings_Lcom_frostwire_jlibtorrent_SettingsPack_ == null)
				cb_applySettings_Lcom_frostwire_jlibtorrent_SettingsPack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ApplySettings_Lcom_frostwire_jlibtorrent_SettingsPack_);
			return cb_applySettings_Lcom_frostwire_jlibtorrent_SettingsPack_;
		}

		static void n_ApplySettings_Lcom_frostwire_jlibtorrent_SettingsPack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sp)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.SettingsPack sp = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (native_sp, JniHandleOwnership.DoNotTransfer);
			__this.ApplySettings (sp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='applySettings' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.SettingsPack']]"
		[Register ("applySettings", "(Lcom/frostwire/jlibtorrent/SettingsPack;)V", "GetApplySettings_Lcom_frostwire_jlibtorrent_SettingsPack_Handler")]
		public virtual unsafe void ApplySettings (global::FrostWire.Libtorrent.SettingsPack sp)
		{
			const string __id = "applySettings.(Lcom/frostwire/jlibtorrent/SettingsPack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sp).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_;
#pragma warning disable 0169
		static Delegate GetDhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_Handler ()
		{
			if (cb_dhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_ == null)
				cb_dhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_);
			return cb_dhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_;
		}

		static void n_DhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sha1)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Sha1Hash sha1 = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (native_sha1, JniHandleOwnership.DoNotTransfer);
			__this.DhtAnnounce (sha1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='dhtAnnounce' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Sha1Hash']]"
		[Register ("dhtAnnounce", "(Lcom/frostwire/jlibtorrent/Sha1Hash;)V", "GetDhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_Handler")]
		public virtual unsafe void DhtAnnounce (global::FrostWire.Libtorrent.Sha1Hash sha1)
		{
			const string __id = "dhtAnnounce.(Lcom/frostwire/jlibtorrent/Sha1Hash;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sha1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sha1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_II;
#pragma warning disable 0169
		static Delegate GetDhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_IIHandler ()
		{
			if (cb_dhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_II == null)
				cb_dhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_DhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_II);
			return cb_dhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_II;
		}

		static void n_DhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_II (IntPtr jnienv, IntPtr native__this, IntPtr native_sha1, int port, int flags)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Sha1Hash sha1 = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (native_sha1, JniHandleOwnership.DoNotTransfer);
			__this.DhtAnnounce (sha1, port, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='dhtAnnounce' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.Sha1Hash'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("dhtAnnounce", "(Lcom/frostwire/jlibtorrent/Sha1Hash;II)V", "GetDhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_IIHandler")]
		public virtual unsafe void DhtAnnounce (global::FrostWire.Libtorrent.Sha1Hash sha1, int port, int flags)
		{
			const string __id = "dhtAnnounce.(Lcom/frostwire/jlibtorrent/Sha1Hash;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((sha1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sha1).Handle);
				__args [1] = new JniArgumentValue (port);
				__args [2] = new JniArgumentValue (flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dhtGetItem_arrayBarrayBI;
#pragma warning disable 0169
		static Delegate GetDhtGetItem_arrayBarrayBIHandler ()
		{
			if (cb_dhtGetItem_arrayBarrayBI == null)
				cb_dhtGetItem_arrayBarrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_DhtGetItem_arrayBarrayBI);
			return cb_dhtGetItem_arrayBarrayBI;
		}

		static IntPtr n_DhtGetItem_arrayBarrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_salt, int timeout)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] key = (byte[]) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] salt = (byte[]) JNIEnv.GetArray (native_salt, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DhtGetItem (key, salt, timeout));
			if (key != null)
				JNIEnv.CopyArray (key, native_key);
			if (salt != null)
				JNIEnv.CopyArray (salt, native_salt);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='dhtGetItem' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register ("dhtGetItem", "([B[BI)Lcom/frostwire/jlibtorrent/SessionManager$MutableItem;", "GetDhtGetItem_arrayBarrayBIHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.SessionManager.MutableItem DhtGetItem (byte[] key, byte[] salt, int timeout)
		{
			const string __id = "dhtGetItem.([B[BI)Lcom/frostwire/jlibtorrent/SessionManager$MutableItem;";
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_salt = JNIEnv.NewArray (salt);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_salt);
				__args [2] = new JniArgumentValue (timeout);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager.MutableItem> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (salt != null) {
					JNIEnv.CopyArray (native_salt, salt);
					JNIEnv.DeleteLocalRef (native_salt);
				}
			}
		}

		static Delegate cb_dhtGetItem_Lcom_frostwire_jlibtorrent_Sha1Hash_I;
#pragma warning disable 0169
		static Delegate GetDhtGetItem_Lcom_frostwire_jlibtorrent_Sha1Hash_IHandler ()
		{
			if (cb_dhtGetItem_Lcom_frostwire_jlibtorrent_Sha1Hash_I == null)
				cb_dhtGetItem_Lcom_frostwire_jlibtorrent_Sha1Hash_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_DhtGetItem_Lcom_frostwire_jlibtorrent_Sha1Hash_I);
			return cb_dhtGetItem_Lcom_frostwire_jlibtorrent_Sha1Hash_I;
		}

		static IntPtr n_DhtGetItem_Lcom_frostwire_jlibtorrent_Sha1Hash_I (IntPtr jnienv, IntPtr native__this, IntPtr native_sha1, int timeout)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Sha1Hash sha1 = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (native_sha1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DhtGetItem (sha1, timeout));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='dhtGetItem' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.Sha1Hash'] and parameter[2][@type='int']]"
		[Register ("dhtGetItem", "(Lcom/frostwire/jlibtorrent/Sha1Hash;I)Lcom/frostwire/jlibtorrent/Entry;", "GetDhtGetItem_Lcom_frostwire_jlibtorrent_Sha1Hash_IHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Entry DhtGetItem (global::FrostWire.Libtorrent.Sha1Hash sha1, int timeout)
		{
			const string __id = "dhtGetItem.(Lcom/frostwire/jlibtorrent/Sha1Hash;I)Lcom/frostwire/jlibtorrent/Entry;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sha1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sha1).Handle);
				__args [1] = new JniArgumentValue (timeout);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_dhtGetPeers_Lcom_frostwire_jlibtorrent_Sha1Hash_I;
#pragma warning disable 0169
		static Delegate GetDhtGetPeers_Lcom_frostwire_jlibtorrent_Sha1Hash_IHandler ()
		{
			if (cb_dhtGetPeers_Lcom_frostwire_jlibtorrent_Sha1Hash_I == null)
				cb_dhtGetPeers_Lcom_frostwire_jlibtorrent_Sha1Hash_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_DhtGetPeers_Lcom_frostwire_jlibtorrent_Sha1Hash_I);
			return cb_dhtGetPeers_Lcom_frostwire_jlibtorrent_Sha1Hash_I;
		}

		static IntPtr n_DhtGetPeers_Lcom_frostwire_jlibtorrent_Sha1Hash_I (IntPtr jnienv, IntPtr native__this, IntPtr native_sha1, int timeout)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Sha1Hash sha1 = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (native_sha1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.TcpEndpoint>.ToLocalJniHandle (__this.DhtGetPeers (sha1, timeout));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='dhtGetPeers' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.Sha1Hash'] and parameter[2][@type='int']]"
		[Register ("dhtGetPeers", "(Lcom/frostwire/jlibtorrent/Sha1Hash;I)Ljava/util/ArrayList;", "GetDhtGetPeers_Lcom_frostwire_jlibtorrent_Sha1Hash_IHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.TcpEndpoint> DhtGetPeers (global::FrostWire.Libtorrent.Sha1Hash sha1, int timeout)
		{
			const string __id = "dhtGetPeers.(Lcom/frostwire/jlibtorrent/Sha1Hash;I)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sha1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sha1).Handle);
				__args [1] = new JniArgumentValue (timeout);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.TcpEndpoint>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_dhtNodes;
#pragma warning disable 0169
		static Delegate GetDhtNodesHandler ()
		{
			if (cb_dhtNodes == null)
				cb_dhtNodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_DhtNodes);
			return cb_dhtNodes;
		}

		static long n_DhtNodes (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DhtNodes ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='dhtNodes' and count(parameter)=0]"
		[Register ("dhtNodes", "()J", "GetDhtNodesHandler")]
		public virtual unsafe long DhtNodes ()
		{
			const string __id = "dhtNodes.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_dhtPutItem_arrayBarrayBLcom_frostwire_jlibtorrent_Entry_arrayB;
#pragma warning disable 0169
		static Delegate GetDhtPutItem_arrayBarrayBLcom_frostwire_jlibtorrent_Entry_arrayBHandler ()
		{
			if (cb_dhtPutItem_arrayBarrayBLcom_frostwire_jlibtorrent_Entry_arrayB == null)
				cb_dhtPutItem_arrayBarrayBLcom_frostwire_jlibtorrent_Entry_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DhtPutItem_arrayBarrayBLcom_frostwire_jlibtorrent_Entry_arrayB);
			return cb_dhtPutItem_arrayBarrayBLcom_frostwire_jlibtorrent_Entry_arrayB;
		}

		static void n_DhtPutItem_arrayBarrayBLcom_frostwire_jlibtorrent_Entry_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_publicKey, IntPtr native_privateKey, IntPtr native_entry, IntPtr native_salt)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] publicKey = (byte[]) JNIEnv.GetArray (native_publicKey, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] privateKey = (byte[]) JNIEnv.GetArray (native_privateKey, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::FrostWire.Libtorrent.Entry entry = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Entry> (native_entry, JniHandleOwnership.DoNotTransfer);
			byte[] salt = (byte[]) JNIEnv.GetArray (native_salt, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.DhtPutItem (publicKey, privateKey, entry, salt);
			if (publicKey != null)
				JNIEnv.CopyArray (publicKey, native_publicKey);
			if (privateKey != null)
				JNIEnv.CopyArray (privateKey, native_privateKey);
			if (salt != null)
				JNIEnv.CopyArray (salt, native_salt);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='dhtPutItem' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.frostwire.jlibtorrent.Entry'] and parameter[4][@type='byte[]']]"
		[Register ("dhtPutItem", "([B[BLcom/frostwire/jlibtorrent/Entry;[B)V", "GetDhtPutItem_arrayBarrayBLcom_frostwire_jlibtorrent_Entry_arrayBHandler")]
		public virtual unsafe void DhtPutItem (byte[] publicKey, byte[] privateKey, global::FrostWire.Libtorrent.Entry entry, byte[] salt)
		{
			const string __id = "dhtPutItem.([B[BLcom/frostwire/jlibtorrent/Entry;[B)V";
			IntPtr native_publicKey = JNIEnv.NewArray (publicKey);
			IntPtr native_privateKey = JNIEnv.NewArray (privateKey);
			IntPtr native_salt = JNIEnv.NewArray (salt);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_publicKey);
				__args [1] = new JniArgumentValue (native_privateKey);
				__args [2] = new JniArgumentValue ((entry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entry).Handle);
				__args [3] = new JniArgumentValue (native_salt);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (publicKey != null) {
					JNIEnv.CopyArray (native_publicKey, publicKey);
					JNIEnv.DeleteLocalRef (native_publicKey);
				}
				if (privateKey != null) {
					JNIEnv.CopyArray (native_privateKey, privateKey);
					JNIEnv.DeleteLocalRef (native_privateKey);
				}
				if (salt != null) {
					JNIEnv.CopyArray (native_salt, salt);
					JNIEnv.DeleteLocalRef (native_salt);
				}
			}
		}

		static Delegate cb_dhtPutItem_Lcom_frostwire_jlibtorrent_Entry_;
#pragma warning disable 0169
		static Delegate GetDhtPutItem_Lcom_frostwire_jlibtorrent_Entry_Handler ()
		{
			if (cb_dhtPutItem_Lcom_frostwire_jlibtorrent_Entry_ == null)
				cb_dhtPutItem_Lcom_frostwire_jlibtorrent_Entry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DhtPutItem_Lcom_frostwire_jlibtorrent_Entry_);
			return cb_dhtPutItem_Lcom_frostwire_jlibtorrent_Entry_;
		}

		static IntPtr n_DhtPutItem_Lcom_frostwire_jlibtorrent_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_entry)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Entry entry = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Entry> (native_entry, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DhtPutItem (entry));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='dhtPutItem' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Entry']]"
		[Register ("dhtPutItem", "(Lcom/frostwire/jlibtorrent/Entry;)Lcom/frostwire/jlibtorrent/Sha1Hash;", "GetDhtPutItem_Lcom_frostwire_jlibtorrent_Entry_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.Sha1Hash DhtPutItem (global::FrostWire.Libtorrent.Entry entry)
		{
			const string __id = "dhtPutItem.(Lcom/frostwire/jlibtorrent/Entry;)Lcom/frostwire/jlibtorrent/Sha1Hash;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((entry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entry).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_download_Lcom_frostwire_jlibtorrent_TorrentInfo_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetDownload_Lcom_frostwire_jlibtorrent_TorrentInfo_Ljava_io_File_Handler ()
		{
			if (cb_download_Lcom_frostwire_jlibtorrent_TorrentInfo_Ljava_io_File_ == null)
				cb_download_Lcom_frostwire_jlibtorrent_TorrentInfo_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Download_Lcom_frostwire_jlibtorrent_TorrentInfo_Ljava_io_File_);
			return cb_download_Lcom_frostwire_jlibtorrent_TorrentInfo_Ljava_io_File_;
		}

		static void n_Download_Lcom_frostwire_jlibtorrent_TorrentInfo_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ti, IntPtr native_saveDir)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.TorrentInfo ti = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentInfo> (native_ti, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File saveDir = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_saveDir, JniHandleOwnership.DoNotTransfer);
			__this.Download (ti, saveDir);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='download' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.TorrentInfo'] and parameter[2][@type='java.io.File']]"
		[Register ("download", "(Lcom/frostwire/jlibtorrent/TorrentInfo;Ljava/io/File;)V", "GetDownload_Lcom_frostwire_jlibtorrent_TorrentInfo_Ljava_io_File_Handler")]
		public virtual unsafe void Download (global::FrostWire.Libtorrent.TorrentInfo ti, global::Java.IO.File saveDir)
		{
			const string __id = "download.(Lcom/frostwire/jlibtorrent/TorrentInfo;Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((ti == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ti).Handle);
				__args [1] = new JniArgumentValue ((saveDir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) saveDir).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_download_Lcom_frostwire_jlibtorrent_TorrentInfo_Ljava_io_File_Ljava_io_File_arrayLcom_frostwire_jlibtorrent_Priority_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDownload_Lcom_frostwire_jlibtorrent_TorrentInfo_Ljava_io_File_Ljava_io_File_arrayLcom_frostwire_jlibtorrent_Priority_Ljava_util_List_Handler ()
		{
			if (cb_download_Lcom_frostwire_jlibtorrent_TorrentInfo_Ljava_io_File_Ljava_io_File_arrayLcom_frostwire_jlibtorrent_Priority_Ljava_util_List_ == null)
				cb_download_Lcom_frostwire_jlibtorrent_TorrentInfo_Ljava_io_File_Ljava_io_File_arrayLcom_frostwire_jlibtorrent_Priority_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Download_Lcom_frostwire_jlibtorrent_TorrentInfo_Ljava_io_File_Ljava_io_File_arrayLcom_frostwire_jlibtorrent_Priority_Ljava_util_List_);
			return cb_download_Lcom_frostwire_jlibtorrent_TorrentInfo_Ljava_io_File_Ljava_io_File_arrayLcom_frostwire_jlibtorrent_Priority_Ljava_util_List_;
		}

		static void n_Download_Lcom_frostwire_jlibtorrent_TorrentInfo_Ljava_io_File_Ljava_io_File_arrayLcom_frostwire_jlibtorrent_Priority_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ti, IntPtr native_saveDir, IntPtr native_resumeFile, IntPtr native_priorities, IntPtr native_peers)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.TorrentInfo ti = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentInfo> (native_ti, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File saveDir = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_saveDir, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File resumeFile = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_resumeFile, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Priority[] priorities = (global::FrostWire.Libtorrent.Priority[]) JNIEnv.GetArray (native_priorities, JniHandleOwnership.DoNotTransfer, typeof (global::FrostWire.Libtorrent.Priority));
			var peers = global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.TcpEndpoint>.FromJniHandle (native_peers, JniHandleOwnership.DoNotTransfer);
			__this.Download (ti, saveDir, resumeFile, priorities, peers);
			if (priorities != null)
				JNIEnv.CopyArray (priorities, native_priorities);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='download' and count(parameter)=5 and parameter[1][@type='com.frostwire.jlibtorrent.TorrentInfo'] and parameter[2][@type='java.io.File'] and parameter[3][@type='java.io.File'] and parameter[4][@type='com.frostwire.jlibtorrent.Priority[]'] and parameter[5][@type='java.util.List&lt;com.frostwire.jlibtorrent.TcpEndpoint&gt;']]"
		[Register ("download", "(Lcom/frostwire/jlibtorrent/TorrentInfo;Ljava/io/File;Ljava/io/File;[Lcom/frostwire/jlibtorrent/Priority;Ljava/util/List;)V", "GetDownload_Lcom_frostwire_jlibtorrent_TorrentInfo_Ljava_io_File_Ljava_io_File_arrayLcom_frostwire_jlibtorrent_Priority_Ljava_util_List_Handler")]
		public virtual unsafe void Download (global::FrostWire.Libtorrent.TorrentInfo ti, global::Java.IO.File saveDir, global::Java.IO.File resumeFile, global::FrostWire.Libtorrent.Priority[] priorities, global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.TcpEndpoint> peers)
		{
			const string __id = "download.(Lcom/frostwire/jlibtorrent/TorrentInfo;Ljava/io/File;Ljava/io/File;[Lcom/frostwire/jlibtorrent/Priority;Ljava/util/List;)V";
			IntPtr native_priorities = JNIEnv.NewArray (priorities);
			IntPtr native_peers = global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.TcpEndpoint>.ToLocalJniHandle (peers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((ti == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ti).Handle);
				__args [1] = new JniArgumentValue ((saveDir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) saveDir).Handle);
				__args [2] = new JniArgumentValue ((resumeFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resumeFile).Handle);
				__args [3] = new JniArgumentValue (native_priorities);
				__args [4] = new JniArgumentValue (native_peers);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (priorities != null) {
					JNIEnv.CopyArray (native_priorities, priorities);
					JNIEnv.DeleteLocalRef (native_priorities);
				}
				JNIEnv.DeleteLocalRef (native_peers);
			}
		}

		static Delegate cb_download_Ljava_lang_String_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetDownload_Ljava_lang_String_Ljava_io_File_Handler ()
		{
			if (cb_download_Ljava_lang_String_Ljava_io_File_ == null)
				cb_download_Ljava_lang_String_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Download_Ljava_lang_String_Ljava_io_File_);
			return cb_download_Ljava_lang_String_Ljava_io_File_;
		}

		static void n_Download_Ljava_lang_String_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_magnetUri, IntPtr native_saveDir)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string magnetUri = JNIEnv.GetString (native_magnetUri, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File saveDir = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_saveDir, JniHandleOwnership.DoNotTransfer);
			__this.Download (magnetUri, saveDir);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='download' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.File']]"
		[Register ("download", "(Ljava/lang/String;Ljava/io/File;)V", "GetDownload_Ljava_lang_String_Ljava_io_File_Handler")]
		public virtual unsafe void Download (string magnetUri, global::Java.IO.File saveDir)
		{
			const string __id = "download.(Ljava/lang/String;Ljava/io/File;)V";
			IntPtr native_magnetUri = JNIEnv.NewString (magnetUri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_magnetUri);
				__args [1] = new JniArgumentValue ((saveDir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) saveDir).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_magnetUri);
			}
		}

		static Delegate cb_downloadRate;
#pragma warning disable 0169
		static Delegate GetDownloadRateHandler ()
		{
			if (cb_downloadRate == null)
				cb_downloadRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_DownloadRate);
			return cb_downloadRate;
		}

		static long n_DownloadRate (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DownloadRate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='downloadRate' and count(parameter)=0]"
		[Register ("downloadRate", "()J", "GetDownloadRateHandler")]
		public virtual unsafe long DownloadRate ()
		{
			const string __id = "downloadRate.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_downloadRateLimit;
#pragma warning disable 0169
		static Delegate GetDownloadRateLimitHandler ()
		{
			if (cb_downloadRateLimit == null)
				cb_downloadRateLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DownloadRateLimit);
			return cb_downloadRateLimit;
		}

		static int n_DownloadRateLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DownloadRateLimit ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='downloadRateLimit' and count(parameter)=0]"
		[Register ("downloadRateLimit", "()I", "GetDownloadRateLimitHandler")]
		public virtual unsafe int DownloadRateLimit ()
		{
			const string __id = "downloadRateLimit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_downloadRateLimit_I;
#pragma warning disable 0169
		static Delegate GetDownloadRateLimit_IHandler ()
		{
			if (cb_downloadRateLimit_I == null)
				cb_downloadRateLimit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_DownloadRateLimit_I);
			return cb_downloadRateLimit_I;
		}

		static void n_DownloadRateLimit_I (IntPtr jnienv, IntPtr native__this, int limit)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DownloadRateLimit (limit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='downloadRateLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("downloadRateLimit", "(I)V", "GetDownloadRateLimit_IHandler")]
		public virtual unsafe void DownloadRateLimit (int limit)
		{
			const string __id = "downloadRateLimit.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_externalAddress;
#pragma warning disable 0169
		static Delegate GetExternalAddressHandler ()
		{
			if (cb_externalAddress == null)
				cb_externalAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ExternalAddress);
			return cb_externalAddress;
		}

		static IntPtr n_ExternalAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExternalAddress ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='externalAddress' and count(parameter)=0]"
		[Register ("externalAddress", "()Ljava/lang/String;", "GetExternalAddressHandler")]
		public virtual unsafe string ExternalAddress ()
		{
			const string __id = "externalAddress.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_fetchMagnet_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetFetchMagnet_Ljava_lang_String_IHandler ()
		{
			if (cb_fetchMagnet_Ljava_lang_String_I == null)
				cb_fetchMagnet_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_FetchMagnet_Ljava_lang_String_I);
			return cb_fetchMagnet_Ljava_lang_String_I;
		}

		static IntPtr n_FetchMagnet_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, int timeout)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.FetchMagnet (uri, timeout));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='fetchMagnet' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("fetchMagnet", "(Ljava/lang/String;I)[B", "GetFetchMagnet_Ljava_lang_String_IHandler")]
		public virtual unsafe byte[] FetchMagnet (string uri, int timeout)
		{
			const string __id = "fetchMagnet.(Ljava/lang/String;I)[B";
			IntPtr native_uri = JNIEnv.NewString (uri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_uri);
				__args [1] = new JniArgumentValue (timeout);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
			}
		}

		static Delegate cb_fetchMagnet_Ljava_lang_String_IZ;
#pragma warning disable 0169
		static Delegate GetFetchMagnet_Ljava_lang_String_IZHandler ()
		{
			if (cb_fetchMagnet_Ljava_lang_String_IZ == null)
				cb_fetchMagnet_Ljava_lang_String_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool, IntPtr>) n_FetchMagnet_Ljava_lang_String_IZ);
			return cb_fetchMagnet_Ljava_lang_String_IZ;
		}

		static IntPtr n_FetchMagnet_Ljava_lang_String_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, int timeout, bool extra)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.FetchMagnet (uri, timeout, extra));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='fetchMagnet' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("fetchMagnet", "(Ljava/lang/String;IZ)[B", "GetFetchMagnet_Ljava_lang_String_IZHandler")]
		public virtual unsafe byte[] FetchMagnet (string uri, int timeout, bool extra)
		{
			const string __id = "fetchMagnet.(Ljava/lang/String;IZ)[B";
			IntPtr native_uri = JNIEnv.NewString (uri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_uri);
				__args [1] = new JniArgumentValue (timeout);
				__args [2] = new JniArgumentValue (extra);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
			}
		}

		static Delegate cb_fetchMagnet_Ljava_lang_String_IZI;
#pragma warning disable 0169
		static Delegate GetFetchMagnet_Ljava_lang_String_IZIHandler ()
		{
			if (cb_fetchMagnet_Ljava_lang_String_IZI == null)
				cb_fetchMagnet_Ljava_lang_String_IZI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool, int, IntPtr>) n_FetchMagnet_Ljava_lang_String_IZI);
			return cb_fetchMagnet_Ljava_lang_String_IZI;
		}

		static IntPtr n_FetchMagnet_Ljava_lang_String_IZI (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, int timeout, bool extra, int maxSize)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uri = JNIEnv.GetString (native_uri, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.FetchMagnet (uri, timeout, extra, maxSize));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='fetchMagnet' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='int']]"
		[Register ("fetchMagnet", "(Ljava/lang/String;IZI)[B", "GetFetchMagnet_Ljava_lang_String_IZIHandler")]
		public virtual unsafe byte[] FetchMagnet (string uri, int timeout, bool extra, int maxSize)
		{
			const string __id = "fetchMagnet.(Ljava/lang/String;IZI)[B";
			IntPtr native_uri = JNIEnv.NewString (uri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_uri);
				__args [1] = new JniArgumentValue (timeout);
				__args [2] = new JniArgumentValue (extra);
				__args [3] = new JniArgumentValue (maxSize);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
			}
		}

		static Delegate cb_find_Lcom_frostwire_jlibtorrent_Sha1Hash_;
#pragma warning disable 0169
		static Delegate GetFind_Lcom_frostwire_jlibtorrent_Sha1Hash_Handler ()
		{
			if (cb_find_Lcom_frostwire_jlibtorrent_Sha1Hash_ == null)
				cb_find_Lcom_frostwire_jlibtorrent_Sha1Hash_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Find_Lcom_frostwire_jlibtorrent_Sha1Hash_);
			return cb_find_Lcom_frostwire_jlibtorrent_Sha1Hash_;
		}

		static IntPtr n_Find_Lcom_frostwire_jlibtorrent_Sha1Hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sha1)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Sha1Hash sha1 = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (native_sha1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Find (sha1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='find' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Sha1Hash']]"
		[Register ("find", "(Lcom/frostwire/jlibtorrent/Sha1Hash;)Lcom/frostwire/jlibtorrent/TorrentHandle;", "GetFind_Lcom_frostwire_jlibtorrent_Sha1Hash_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.TorrentHandle Find (global::FrostWire.Libtorrent.Sha1Hash sha1)
		{
			const string __id = "find.(Lcom/frostwire/jlibtorrent/Sha1Hash;)Lcom/frostwire/jlibtorrent/TorrentHandle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sha1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sha1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentHandle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_lastAlertError;
#pragma warning disable 0169
		static Delegate GetLastAlertErrorHandler ()
		{
			if (cb_lastAlertError == null)
				cb_lastAlertError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_LastAlertError);
			return cb_lastAlertError;
		}

		static IntPtr n_LastAlertError (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastAlertError ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='lastAlertError' and count(parameter)=0]"
		[Register ("lastAlertError", "()Ljava/lang/Throwable;", "GetLastAlertErrorHandler")]
		public virtual unsafe global::Java.Lang.Throwable LastAlertError ()
		{
			const string __id = "lastAlertError.()Ljava/lang/Throwable;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_listenEndpoints;
#pragma warning disable 0169
		static Delegate GetListenEndpointsHandler ()
		{
			if (cb_listenEndpoints == null)
				cb_listenEndpoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ListenEndpoints);
			return cb_listenEndpoints;
		}

		static IntPtr n_ListenEndpoints (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ListenEndpoints ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='listenEndpoints' and count(parameter)=0]"
		[Register ("listenEndpoints", "()Ljava/util/List;", "GetListenEndpointsHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<string> ListenEndpoints ()
		{
			const string __id = "listenEndpoints.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_listenInterfaces;
#pragma warning disable 0169
		static Delegate GetListenInterfacesHandler ()
		{
			if (cb_listenInterfaces == null)
				cb_listenInterfaces = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ListenInterfaces);
			return cb_listenInterfaces;
		}

		static IntPtr n_ListenInterfaces (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ListenInterfaces ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='listenInterfaces' and count(parameter)=0]"
		[Register ("listenInterfaces", "()Ljava/lang/String;", "GetListenInterfacesHandler")]
		public virtual unsafe string ListenInterfaces ()
		{
			const string __id = "listenInterfaces.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_listenInterfaces_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetListenInterfaces_Ljava_lang_String_Handler ()
		{
			if (cb_listenInterfaces_Ljava_lang_String_ == null)
				cb_listenInterfaces_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ListenInterfaces_Ljava_lang_String_);
			return cb_listenInterfaces_Ljava_lang_String_;
		}

		static void n_ListenInterfaces_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.ListenInterfaces (value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='listenInterfaces' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("listenInterfaces", "(Ljava/lang/String;)V", "GetListenInterfaces_Ljava_lang_String_Handler")]
		public virtual unsafe void ListenInterfaces (string value)
		{
			const string __id = "listenInterfaces.(Ljava/lang/String;)V";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_loadState_arrayB;
#pragma warning disable 0169
		static Delegate GetLoadState_arrayBHandler ()
		{
			if (cb_loadState_arrayB == null)
				cb_loadState_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadState_arrayB);
			return cb_loadState_arrayB;
		}

		static void n_LoadState_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.LoadState (data);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='loadState' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("loadState", "([B)V", "GetLoadState_arrayBHandler")]
		public virtual unsafe void LoadState (byte[] data)
		{
			const string __id = "loadState.([B)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static Delegate cb_magnetPeers;
#pragma warning disable 0169
		static Delegate GetMagnetPeersHandler ()
		{
			if (cb_magnetPeers == null)
				cb_magnetPeers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_MagnetPeers);
			return cb_magnetPeers;
		}

		static IntPtr n_MagnetPeers (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MagnetPeers ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='magnetPeers' and count(parameter)=0]"
		[Register ("magnetPeers", "()Ljava/lang/String;", "GetMagnetPeersHandler")]
		public virtual unsafe string MagnetPeers ()
		{
			const string __id = "magnetPeers.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_maxActiveDownloads;
#pragma warning disable 0169
		static Delegate GetMaxActiveDownloadsHandler ()
		{
			if (cb_maxActiveDownloads == null)
				cb_maxActiveDownloads = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_MaxActiveDownloads);
			return cb_maxActiveDownloads;
		}

		static int n_MaxActiveDownloads (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxActiveDownloads ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='maxActiveDownloads' and count(parameter)=0]"
		[Register ("maxActiveDownloads", "()I", "GetMaxActiveDownloadsHandler")]
		public virtual unsafe int MaxActiveDownloads ()
		{
			const string __id = "maxActiveDownloads.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_maxActiveDownloads_I;
#pragma warning disable 0169
		static Delegate GetMaxActiveDownloads_IHandler ()
		{
			if (cb_maxActiveDownloads_I == null)
				cb_maxActiveDownloads_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_MaxActiveDownloads_I);
			return cb_maxActiveDownloads_I;
		}

		static void n_MaxActiveDownloads_I (IntPtr jnienv, IntPtr native__this, int limit)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxActiveDownloads (limit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='maxActiveDownloads' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("maxActiveDownloads", "(I)V", "GetMaxActiveDownloads_IHandler")]
		public virtual unsafe void MaxActiveDownloads (int limit)
		{
			const string __id = "maxActiveDownloads.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_maxActiveSeeds;
#pragma warning disable 0169
		static Delegate GetMaxActiveSeedsHandler ()
		{
			if (cb_maxActiveSeeds == null)
				cb_maxActiveSeeds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_MaxActiveSeeds);
			return cb_maxActiveSeeds;
		}

		static int n_MaxActiveSeeds (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxActiveSeeds ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='maxActiveSeeds' and count(parameter)=0]"
		[Register ("maxActiveSeeds", "()I", "GetMaxActiveSeedsHandler")]
		public virtual unsafe int MaxActiveSeeds ()
		{
			const string __id = "maxActiveSeeds.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_maxActiveSeeds_I;
#pragma warning disable 0169
		static Delegate GetMaxActiveSeeds_IHandler ()
		{
			if (cb_maxActiveSeeds_I == null)
				cb_maxActiveSeeds_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_MaxActiveSeeds_I);
			return cb_maxActiveSeeds_I;
		}

		static void n_MaxActiveSeeds_I (IntPtr jnienv, IntPtr native__this, int limit)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxActiveSeeds (limit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='maxActiveSeeds' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("maxActiveSeeds", "(I)V", "GetMaxActiveSeeds_IHandler")]
		public virtual unsafe void MaxActiveSeeds (int limit)
		{
			const string __id = "maxActiveSeeds.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_maxConnections;
#pragma warning disable 0169
		static Delegate GetMaxConnectionsHandler ()
		{
			if (cb_maxConnections == null)
				cb_maxConnections = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_MaxConnections);
			return cb_maxConnections;
		}

		static int n_MaxConnections (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxConnections ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='maxConnections' and count(parameter)=0]"
		[Register ("maxConnections", "()I", "GetMaxConnectionsHandler")]
		public virtual unsafe int MaxConnections ()
		{
			const string __id = "maxConnections.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_maxConnections_I;
#pragma warning disable 0169
		static Delegate GetMaxConnections_IHandler ()
		{
			if (cb_maxConnections_I == null)
				cb_maxConnections_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_MaxConnections_I);
			return cb_maxConnections_I;
		}

		static void n_MaxConnections_I (IntPtr jnienv, IntPtr native__this, int limit)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxConnections (limit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='maxConnections' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("maxConnections", "(I)V", "GetMaxConnections_IHandler")]
		public virtual unsafe void MaxConnections (int limit)
		{
			const string __id = "maxConnections.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_maxPeers;
#pragma warning disable 0169
		static Delegate GetMaxPeersHandler ()
		{
			if (cb_maxPeers == null)
				cb_maxPeers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_MaxPeers);
			return cb_maxPeers;
		}

		static int n_MaxPeers (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxPeers ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='maxPeers' and count(parameter)=0]"
		[Register ("maxPeers", "()I", "GetMaxPeersHandler")]
		public virtual unsafe int MaxPeers ()
		{
			const string __id = "maxPeers.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_maxPeers_I;
#pragma warning disable 0169
		static Delegate GetMaxPeers_IHandler ()
		{
			if (cb_maxPeers_I == null)
				cb_maxPeers_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_MaxPeers_I);
			return cb_maxPeers_I;
		}

		static void n_MaxPeers_I (IntPtr jnienv, IntPtr native__this, int limit)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxPeers (limit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='maxPeers' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("maxPeers", "(I)V", "GetMaxPeers_IHandler")]
		public virtual unsafe void MaxPeers (int limit)
		{
			const string __id = "maxPeers.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_moveStorage_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetMoveStorage_Ljava_io_File_Handler ()
		{
			if (cb_moveStorage_Ljava_io_File_ == null)
				cb_moveStorage_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MoveStorage_Ljava_io_File_);
			return cb_moveStorage_Ljava_io_File_;
		}

		static void n_MoveStorage_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dir)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File dir = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_dir, JniHandleOwnership.DoNotTransfer);
			__this.MoveStorage (dir);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='moveStorage' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("moveStorage", "(Ljava/io/File;)V", "GetMoveStorage_Ljava_io_File_Handler")]
		public virtual unsafe void MoveStorage (global::Java.IO.File dir)
		{
			const string __id = "moveStorage.(Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dir == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dir).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onAfterStart;
#pragma warning disable 0169
		static Delegate GetOnAfterStartHandler ()
		{
			if (cb_onAfterStart == null)
				cb_onAfterStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAfterStart);
			return cb_onAfterStart;
		}

		static void n_OnAfterStart (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAfterStart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='onAfterStart' and count(parameter)=0]"
		[Register ("onAfterStart", "()V", "GetOnAfterStartHandler")]
		protected virtual unsafe void OnAfterStart ()
		{
			const string __id = "onAfterStart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onAfterStop;
#pragma warning disable 0169
		static Delegate GetOnAfterStopHandler ()
		{
			if (cb_onAfterStop == null)
				cb_onAfterStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAfterStop);
			return cb_onAfterStop;
		}

		static void n_OnAfterStop (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAfterStop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='onAfterStop' and count(parameter)=0]"
		[Register ("onAfterStop", "()V", "GetOnAfterStopHandler")]
		protected virtual unsafe void OnAfterStop ()
		{
			const string __id = "onAfterStop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onApplySettings_Lcom_frostwire_jlibtorrent_SettingsPack_;
#pragma warning disable 0169
		static Delegate GetOnApplySettings_Lcom_frostwire_jlibtorrent_SettingsPack_Handler ()
		{
			if (cb_onApplySettings_Lcom_frostwire_jlibtorrent_SettingsPack_ == null)
				cb_onApplySettings_Lcom_frostwire_jlibtorrent_SettingsPack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnApplySettings_Lcom_frostwire_jlibtorrent_SettingsPack_);
			return cb_onApplySettings_Lcom_frostwire_jlibtorrent_SettingsPack_;
		}

		static void n_OnApplySettings_Lcom_frostwire_jlibtorrent_SettingsPack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sp)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.SettingsPack sp = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (native_sp, JniHandleOwnership.DoNotTransfer);
			__this.OnApplySettings (sp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='onApplySettings' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.SettingsPack']]"
		[Register ("onApplySettings", "(Lcom/frostwire/jlibtorrent/SettingsPack;)V", "GetOnApplySettings_Lcom_frostwire_jlibtorrent_SettingsPack_Handler")]
		protected virtual unsafe void OnApplySettings (global::FrostWire.Libtorrent.SettingsPack sp)
		{
			const string __id = "onApplySettings.(Lcom/frostwire/jlibtorrent/SettingsPack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sp).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onBeforeStart;
#pragma warning disable 0169
		static Delegate GetOnBeforeStartHandler ()
		{
			if (cb_onBeforeStart == null)
				cb_onBeforeStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBeforeStart);
			return cb_onBeforeStart;
		}

		static void n_OnBeforeStart (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBeforeStart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='onBeforeStart' and count(parameter)=0]"
		[Register ("onBeforeStart", "()V", "GetOnBeforeStartHandler")]
		protected virtual unsafe void OnBeforeStart ()
		{
			const string __id = "onBeforeStart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onBeforeStop;
#pragma warning disable 0169
		static Delegate GetOnBeforeStopHandler ()
		{
			if (cb_onBeforeStop == null)
				cb_onBeforeStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBeforeStop);
			return cb_onBeforeStop;
		}

		static void n_OnBeforeStop (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBeforeStop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='onBeforeStop' and count(parameter)=0]"
		[Register ("onBeforeStop", "()V", "GetOnBeforeStopHandler")]
		protected virtual unsafe void OnBeforeStop ()
		{
			const string __id = "onBeforeStop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			const string __id = "pause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_postDhtStats;
#pragma warning disable 0169
		static Delegate GetPostDhtStatsHandler ()
		{
			if (cb_postDhtStats == null)
				cb_postDhtStats = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PostDhtStats);
			return cb_postDhtStats;
		}

		static void n_PostDhtStats (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostDhtStats ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='postDhtStats' and count(parameter)=0]"
		[Register ("postDhtStats", "()V", "GetPostDhtStatsHandler")]
		public virtual unsafe void PostDhtStats ()
		{
			const string __id = "postDhtStats.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_postSessionStats;
#pragma warning disable 0169
		static Delegate GetPostSessionStatsHandler ()
		{
			if (cb_postSessionStats == null)
				cb_postSessionStats = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PostSessionStats);
			return cb_postSessionStats;
		}

		static void n_PostSessionStats (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostSessionStats ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='postSessionStats' and count(parameter)=0]"
		[Register ("postSessionStats", "()V", "GetPostSessionStatsHandler")]
		public virtual unsafe void PostSessionStats ()
		{
			const string __id = "postSessionStats.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_postTorrentUpdates;
#pragma warning disable 0169
		static Delegate GetPostTorrentUpdatesHandler ()
		{
			if (cb_postTorrentUpdates == null)
				cb_postTorrentUpdates = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PostTorrentUpdates);
			return cb_postTorrentUpdates;
		}

		static void n_PostTorrentUpdates (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostTorrentUpdates ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='postTorrentUpdates' and count(parameter)=0]"
		[Register ("postTorrentUpdates", "()V", "GetPostTorrentUpdatesHandler")]
		public virtual unsafe void PostTorrentUpdates ()
		{
			const string __id = "postTorrentUpdates.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_remove_Lcom_frostwire_jlibtorrent_TorrentHandle_;
#pragma warning disable 0169
		static Delegate GetRemove_Lcom_frostwire_jlibtorrent_TorrentHandle_Handler ()
		{
			if (cb_remove_Lcom_frostwire_jlibtorrent_TorrentHandle_ == null)
				cb_remove_Lcom_frostwire_jlibtorrent_TorrentHandle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Lcom_frostwire_jlibtorrent_TorrentHandle_);
			return cb_remove_Lcom_frostwire_jlibtorrent_TorrentHandle_;
		}

		static void n_Remove_Lcom_frostwire_jlibtorrent_TorrentHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_th)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.TorrentHandle th = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentHandle> (native_th, JniHandleOwnership.DoNotTransfer);
			__this.Remove (th);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.TorrentHandle']]"
		[Register ("remove", "(Lcom/frostwire/jlibtorrent/TorrentHandle;)V", "GetRemove_Lcom_frostwire_jlibtorrent_TorrentHandle_Handler")]
		public virtual unsafe void Remove (global::FrostWire.Libtorrent.TorrentHandle th)
		{
			const string __id = "remove.(Lcom/frostwire/jlibtorrent/TorrentHandle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((th == null) ? IntPtr.Zero : ((global::Java.Lang.Object) th).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_remove_Lcom_frostwire_jlibtorrent_TorrentHandle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_;
#pragma warning disable 0169
		static Delegate GetRemove_Lcom_frostwire_jlibtorrent_TorrentHandle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_Handler ()
		{
			if (cb_remove_Lcom_frostwire_jlibtorrent_TorrentHandle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ == null)
				cb_remove_Lcom_frostwire_jlibtorrent_TorrentHandle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Remove_Lcom_frostwire_jlibtorrent_TorrentHandle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_);
			return cb_remove_Lcom_frostwire_jlibtorrent_TorrentHandle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_;
		}

		static void n_Remove_Lcom_frostwire_jlibtorrent_TorrentHandle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_th, IntPtr native_options)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.TorrentHandle th = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentHandle> (native_th, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Remove_flags_t options = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.Remove (th, options);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.TorrentHandle'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.remove_flags_t']]"
		[Register ("remove", "(Lcom/frostwire/jlibtorrent/TorrentHandle;Lcom/frostwire/jlibtorrent/swig/remove_flags_t;)V", "GetRemove_Lcom_frostwire_jlibtorrent_TorrentHandle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_Handler")]
		public virtual unsafe void Remove (global::FrostWire.Libtorrent.TorrentHandle th, global::FrostWire.Libtorrent.Swig.Remove_flags_t options)
		{
			const string __id = "remove.(Lcom/frostwire/jlibtorrent/TorrentHandle;Lcom/frostwire/jlibtorrent/swig/remove_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((th == null) ? IntPtr.Zero : ((global::Java.Lang.Object) th).Handle);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeListener_Lcom_frostwire_jlibtorrent_AlertListener_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Lcom_frostwire_jlibtorrent_AlertListener_Handler ()
		{
			if (cb_removeListener_Lcom_frostwire_jlibtorrent_AlertListener_ == null)
				cb_removeListener_Lcom_frostwire_jlibtorrent_AlertListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveListener_Lcom_frostwire_jlibtorrent_AlertListener_);
			return cb_removeListener_Lcom_frostwire_jlibtorrent_AlertListener_;
		}

		static void n_RemoveListener_Lcom_frostwire_jlibtorrent_AlertListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.IAlertListener listener = (global::FrostWire.Libtorrent.IAlertListener)global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.IAlertListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.AlertListener']]"
		[Register ("removeListener", "(Lcom/frostwire/jlibtorrent/AlertListener;)V", "GetRemoveListener_Lcom_frostwire_jlibtorrent_AlertListener_Handler")]
		public virtual unsafe void RemoveListener (global::FrostWire.Libtorrent.IAlertListener listener)
		{
			const string __id = "removeListener.(Lcom/frostwire/jlibtorrent/AlertListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reopenNetworkSockets;
#pragma warning disable 0169
		static Delegate GetReopenNetworkSocketsHandler ()
		{
			if (cb_reopenNetworkSockets == null)
				cb_reopenNetworkSockets = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReopenNetworkSockets);
			return cb_reopenNetworkSockets;
		}

		static void n_ReopenNetworkSockets (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReopenNetworkSockets ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='reopenNetworkSockets' and count(parameter)=0]"
		[Register ("reopenNetworkSockets", "()V", "GetReopenNetworkSocketsHandler")]
		public virtual unsafe void ReopenNetworkSockets ()
		{
			const string __id = "reopenNetworkSockets.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_restart;
#pragma warning disable 0169
		static Delegate GetRestartHandler ()
		{
			if (cb_restart == null)
				cb_restart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Restart);
			return cb_restart;
		}

		static void n_Restart (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Restart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='restart' and count(parameter)=0]"
		[Register ("restart", "()V", "GetRestartHandler")]
		public virtual unsafe void Restart ()
		{
			const string __id = "restart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Resume);
			return cb_resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			const string __id = "resume.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_saveState;
#pragma warning disable 0169
		static Delegate GetSaveStateHandler ()
		{
			if (cb_saveState == null)
				cb_saveState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_SaveState);
			return cb_saveState;
		}

		static IntPtr n_SaveState (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.SaveState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='saveState' and count(parameter)=0]"
		[Register ("saveState", "()[B", "GetSaveStateHandler")]
		public virtual unsafe byte[] SaveState ()
		{
			const string __id = "saveState.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Settings ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='settings' and count(parameter)=0]"
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

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_start_Lcom_frostwire_jlibtorrent_SessionParams_;
#pragma warning disable 0169
		static Delegate GetStart_Lcom_frostwire_jlibtorrent_SessionParams_Handler ()
		{
			if (cb_start_Lcom_frostwire_jlibtorrent_SessionParams_ == null)
				cb_start_Lcom_frostwire_jlibtorrent_SessionParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Start_Lcom_frostwire_jlibtorrent_SessionParams_);
			return cb_start_Lcom_frostwire_jlibtorrent_SessionParams_;
		}

		static void n_Start_Lcom_frostwire_jlibtorrent_SessionParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.SessionParams @params = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionParams> (native__params, JniHandleOwnership.DoNotTransfer);
			__this.Start (@params);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='start' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.SessionParams']]"
		[Register ("start", "(Lcom/frostwire/jlibtorrent/SessionParams;)V", "GetStart_Lcom_frostwire_jlibtorrent_SessionParams_Handler")]
		public virtual unsafe void Start (global::FrostWire.Libtorrent.SessionParams @params)
		{
			const string __id = "start.(Lcom/frostwire/jlibtorrent/SessionParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startDht;
#pragma warning disable 0169
		static Delegate GetStartDhtHandler ()
		{
			if (cb_startDht == null)
				cb_startDht = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartDht);
			return cb_startDht;
		}

		static void n_StartDht (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDht ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='startDht' and count(parameter)=0]"
		[Register ("startDht", "()V", "GetStartDhtHandler")]
		public virtual unsafe void StartDht ()
		{
			const string __id = "startDht.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stats;
#pragma warning disable 0169
		static Delegate GetStatsHandler ()
		{
			if (cb_stats == null)
				cb_stats = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Stats);
			return cb_stats;
		}

		static IntPtr n_Stats (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Stats ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='stats' and count(parameter)=0]"
		[Register ("stats", "()Lcom/frostwire/jlibtorrent/SessionStats;", "GetStatsHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.SessionStats Stats ()
		{
			const string __id = "stats.()Lcom/frostwire/jlibtorrent/SessionStats;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionStats> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stopDht;
#pragma warning disable 0169
		static Delegate GetStopDhtHandler ()
		{
			if (cb_stopDht == null)
				cb_stopDht = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopDht);
			return cb_stopDht;
		}

		static void n_StopDht (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopDht ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='stopDht' and count(parameter)=0]"
		[Register ("stopDht", "()V", "GetStopDhtHandler")]
		public virtual unsafe void StopDht ()
		{
			const string __id = "stopDht.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Swig ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/session;", "GetSwigHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Session Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/session;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_totalDownload;
#pragma warning disable 0169
		static Delegate GetTotalDownloadHandler ()
		{
			if (cb_totalDownload == null)
				cb_totalDownload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_TotalDownload);
			return cb_totalDownload;
		}

		static long n_TotalDownload (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalDownload ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='totalDownload' and count(parameter)=0]"
		[Register ("totalDownload", "()J", "GetTotalDownloadHandler")]
		public virtual unsafe long TotalDownload ()
		{
			const string __id = "totalDownload.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_totalUpload;
#pragma warning disable 0169
		static Delegate GetTotalUploadHandler ()
		{
			if (cb_totalUpload == null)
				cb_totalUpload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_TotalUpload);
			return cb_totalUpload;
		}

		static long n_TotalUpload (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalUpload ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='totalUpload' and count(parameter)=0]"
		[Register ("totalUpload", "()J", "GetTotalUploadHandler")]
		public virtual unsafe long TotalUpload ()
		{
			const string __id = "totalUpload.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_uploadRate;
#pragma warning disable 0169
		static Delegate GetUploadRateHandler ()
		{
			if (cb_uploadRate == null)
				cb_uploadRate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_UploadRate);
			return cb_uploadRate;
		}

		static long n_UploadRate (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UploadRate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='uploadRate' and count(parameter)=0]"
		[Register ("uploadRate", "()J", "GetUploadRateHandler")]
		public virtual unsafe long UploadRate ()
		{
			const string __id = "uploadRate.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_uploadRateLimit;
#pragma warning disable 0169
		static Delegate GetUploadRateLimitHandler ()
		{
			if (cb_uploadRateLimit == null)
				cb_uploadRateLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_UploadRateLimit);
			return cb_uploadRateLimit;
		}

		static int n_UploadRateLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UploadRateLimit ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='uploadRateLimit' and count(parameter)=0]"
		[Register ("uploadRateLimit", "()I", "GetUploadRateLimitHandler")]
		public virtual unsafe int UploadRateLimit ()
		{
			const string __id = "uploadRateLimit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_uploadRateLimit_I;
#pragma warning disable 0169
		static Delegate GetUploadRateLimit_IHandler ()
		{
			if (cb_uploadRateLimit_I == null)
				cb_uploadRateLimit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_UploadRateLimit_I);
			return cb_uploadRateLimit_I;
		}

		static void n_UploadRateLimit_I (IntPtr jnienv, IntPtr native__this, int limit)
		{
			global::FrostWire.Libtorrent.SessionManager __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UploadRateLimit (limit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionManager']/method[@name='uploadRateLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("uploadRateLimit", "(I)V", "GetUploadRateLimit_IHandler")]
		public virtual unsafe void UploadRateLimit (int limit)
		{
			const string __id = "uploadRateLimit.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for FrostWire.Libtorrent.IAlertListener"

		global::FrostWire.Libtorrent.IAlertListenerImplementor __CreateIAlertListenerImplementor ()
		{
			return new global::FrostWire.Libtorrent.IAlertListenerImplementor (this);
		}
#endregion
	}
}
