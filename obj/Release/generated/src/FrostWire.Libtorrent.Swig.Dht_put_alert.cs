using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_put_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/dht_put_alert", DoNotGenerateAcw=true)]
	public partial class Dht_put_alert : global::FrostWire.Libtorrent.Swig.Alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_put_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_put_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_put_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/dht_put_alert", typeof (Dht_put_alert));
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

		protected Dht_put_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_put_alert']/constructor[@name='dht_put_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Dht_put_alert (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getNum_success;
#pragma warning disable 0169
		static Delegate GetGetNum_successHandler ()
		{
			if (cb_getNum_success == null)
				cb_getNum_success = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNum_success);
			return cb_getNum_success;
		}

		static int n_GetNum_success (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_put_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_put_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_success;
		}
#pragma warning restore 0169

		static Delegate cb_setNum_success_I;
#pragma warning disable 0169
		static Delegate GetSetNum_success_IHandler ()
		{
			if (cb_setNum_success_I == null)
				cb_setNum_success_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNum_success_I);
			return cb_setNum_success_I;
		}

		static void n_SetNum_success_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_put_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_put_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Num_success = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Num_success {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_put_alert']/method[@name='getNum_success' and count(parameter)=0]"
			[Register ("getNum_success", "()I", "GetGetNum_successHandler")]
			get {
				const string __id = "getNum_success.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_put_alert']/method[@name='setNum_success' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNum_success", "(I)V", "GetSetNum_success_IHandler")]
			set {
				const string __id = "setNum_success.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTarget;
#pragma warning disable 0169
		static Delegate GetGetTargetHandler ()
		{
			if (cb_getTarget == null)
				cb_getTarget = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTarget);
			return cb_getTarget;
		}

		static IntPtr n_GetTarget (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_put_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_put_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Target);
		}
#pragma warning restore 0169

		static Delegate cb_setTarget_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetSetTarget_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_setTarget_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_setTarget_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTarget_Lcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_setTarget_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static void n_SetTarget_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_put_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_put_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Target = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash Target {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_put_alert']/method[@name='getTarget' and count(parameter)=0]"
			[Register ("getTarget", "()Lcom/frostwire/jlibtorrent/swig/sha1_hash;", "GetGetTargetHandler")]
			get {
				const string __id = "getTarget.()Lcom/frostwire/jlibtorrent/swig/sha1_hash;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_put_alert']/method[@name='setTarget' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
			[Register ("setTarget", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V", "GetSetTarget_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
			set {
				const string __id = "setTarget.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_put_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_put_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/dht_put_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Dht_put_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/dht_put_alert;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_public_key;
#pragma warning disable 0169
		static Delegate GetGet_public_keyHandler ()
		{
			if (cb_get_public_key == null)
				cb_get_public_key = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_public_key);
			return cb_get_public_key;
		}

		static IntPtr n_Get_public_key (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_put_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_put_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_public_key ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_put_alert']/method[@name='get_public_key' and count(parameter)=0]"
		[Register ("get_public_key", "()Lcom/frostwire/jlibtorrent/swig/byte_vector;", "GetGet_public_keyHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Get_public_key ()
		{
			const string __id = "get_public_key.()Lcom/frostwire/jlibtorrent/swig/byte_vector;";
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
			global::FrostWire.Libtorrent.Swig.Dht_put_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_put_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_salt ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_put_alert']/method[@name='get_salt' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.Swig.Dht_put_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_put_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_seq ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_put_alert']/method[@name='get_seq' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.Swig.Dht_put_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_put_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_signature ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_put_alert']/method[@name='get_signature' and count(parameter)=0]"
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
