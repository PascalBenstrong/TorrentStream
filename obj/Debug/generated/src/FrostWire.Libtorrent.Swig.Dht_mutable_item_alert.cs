using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_mutable_item_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/dht_mutable_item_alert", DoNotGenerateAcw=true)]
	public partial class Dht_mutable_item_alert : global::FrostWire.Libtorrent.Swig.Alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_mutable_item_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_mutable_item_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_mutable_item_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/dht_mutable_item_alert", typeof (Dht_mutable_item_alert));
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

		protected Dht_mutable_item_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_mutable_item_alert']/constructor[@name='dht_mutable_item_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Dht_mutable_item_alert (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getAuthoritative;
#pragma warning disable 0169
		static Delegate GetGetAuthoritativeHandler ()
		{
			if (cb_getAuthoritative == null)
				cb_getAuthoritative = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAuthoritative);
			return cb_getAuthoritative;
		}

		static bool n_GetAuthoritative (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Authoritative;
		}
#pragma warning restore 0169

		static Delegate cb_setAuthoritative_Z;
#pragma warning disable 0169
		static Delegate GetSetAuthoritative_ZHandler ()
		{
			if (cb_setAuthoritative_Z == null)
				cb_setAuthoritative_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAuthoritative_Z);
			return cb_setAuthoritative_Z;
		}

		static void n_SetAuthoritative_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Authoritative = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Authoritative {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_mutable_item_alert']/method[@name='getAuthoritative' and count(parameter)=0]"
			[Register ("getAuthoritative", "()Z", "GetGetAuthoritativeHandler")]
			get {
				const string __id = "getAuthoritative.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_mutable_item_alert']/method[@name='setAuthoritative' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAuthoritative", "(Z)V", "GetSetAuthoritative_ZHandler")]
			set {
				const string __id = "setAuthoritative.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getItem;
#pragma warning disable 0169
		static Delegate GetGetItemHandler ()
		{
			if (cb_getItem == null)
				cb_getItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetItem);
			return cb_getItem;
		}

		static IntPtr n_GetItem (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Item);
		}
#pragma warning restore 0169

		static Delegate cb_setItem_Lcom_frostwire_jlibtorrent_swig_entry_;
#pragma warning disable 0169
		static Delegate GetSetItem_Lcom_frostwire_jlibtorrent_swig_entry_Handler ()
		{
			if (cb_setItem_Lcom_frostwire_jlibtorrent_swig_entry_ == null)
				cb_setItem_Lcom_frostwire_jlibtorrent_swig_entry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetItem_Lcom_frostwire_jlibtorrent_swig_entry_);
			return cb_setItem_Lcom_frostwire_jlibtorrent_swig_entry_;
		}

		static void n_SetItem_Lcom_frostwire_jlibtorrent_swig_entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Entry value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Item = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Entry Item {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_mutable_item_alert']/method[@name='getItem' and count(parameter)=0]"
			[Register ("getItem", "()Lcom/frostwire/jlibtorrent/swig/entry;", "GetGetItemHandler")]
			get {
				const string __id = "getItem.()Lcom/frostwire/jlibtorrent/swig/entry;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_mutable_item_alert']/method[@name='setItem' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.entry']]"
			[Register ("setItem", "(Lcom/frostwire/jlibtorrent/swig/entry;)V", "GetSetItem_Lcom_frostwire_jlibtorrent_swig_entry_Handler")]
			set {
				const string __id = "setItem.(Lcom/frostwire/jlibtorrent/swig/entry;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_mutable_item_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_mutable_item_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/dht_mutable_item_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/dht_mutable_item_alert;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_key;
#pragma warning disable 0169
		static Delegate GetGet_keyHandler ()
		{
			if (cb_get_key == null)
				cb_get_key = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_key);
			return cb_get_key;
		}

		static IntPtr n_Get_key (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_key ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_mutable_item_alert']/method[@name='get_key' and count(parameter)=0]"
		[Register ("get_key", "()Lcom/frostwire/jlibtorrent/swig/byte_vector;", "GetGet_keyHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Get_key ()
		{
			const string __id = "get_key.()Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_salt;
#pragma warning disable 0169
		static Delegate GetGet_saltHandler ()
		{
			if (cb_get_salt == null)
				cb_get_salt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_salt);
			return cb_get_salt;
		}

		static IntPtr n_Get_salt (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_salt ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_mutable_item_alert']/method[@name='get_salt' and count(parameter)=0]"
		[Register ("get_salt", "()Lcom/frostwire/jlibtorrent/swig/byte_vector;", "GetGet_saltHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Get_salt ()
		{
			const string __id = "get_salt.()Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_seq;
#pragma warning disable 0169
		static Delegate GetGet_seqHandler ()
		{
			if (cb_get_seq == null)
				cb_get_seq = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Get_seq);
			return cb_get_seq;
		}

		static long n_Get_seq (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_seq ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_mutable_item_alert']/method[@name='get_seq' and count(parameter)=0]"
		[Register ("get_seq", "()J", "GetGet_seqHandler")]
		public virtual unsafe long Get_seq ()
		{
			const string __id = "get_seq.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_signature;
#pragma warning disable 0169
		static Delegate GetGet_signatureHandler ()
		{
			if (cb_get_signature == null)
				cb_get_signature = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_signature);
			return cb_get_signature;
		}

		static IntPtr n_Get_signature (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_signature ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_mutable_item_alert']/method[@name='get_signature' and count(parameter)=0]"
		[Register ("get_signature", "()Lcom/frostwire/jlibtorrent/swig/byte_vector;", "GetGet_signatureHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Get_signature ()
		{
			const string __id = "get_signature.()Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
