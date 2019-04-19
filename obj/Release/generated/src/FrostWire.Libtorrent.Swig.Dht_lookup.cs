using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/dht_lookup", DoNotGenerateAcw=true)]
	public partial class Dht_lookup : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/dht_lookup", typeof (Dht_lookup));
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

		protected Dht_lookup (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/constructor[@name='dht_lookup' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Dht_lookup ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/constructor[@name='dht_lookup' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Dht_lookup (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getBranch_factor;
#pragma warning disable 0169
		static Delegate GetGetBranch_factorHandler ()
		{
			if (cb_getBranch_factor == null)
				cb_getBranch_factor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBranch_factor);
			return cb_getBranch_factor;
		}

		static int n_GetBranch_factor (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_lookup __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Branch_factor;
		}
#pragma warning restore 0169

		static Delegate cb_setBranch_factor_I;
#pragma warning disable 0169
		static Delegate GetSetBranch_factor_IHandler ()
		{
			if (cb_setBranch_factor_I == null)
				cb_setBranch_factor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBranch_factor_I);
			return cb_setBranch_factor_I;
		}

		static void n_SetBranch_factor_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_lookup __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Branch_factor = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Branch_factor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='getBranch_factor' and count(parameter)=0]"
			[Register ("getBranch_factor", "()I", "GetGetBranch_factorHandler")]
			get {
				const string __id = "getBranch_factor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='setBranch_factor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBranch_factor", "(I)V", "GetSetBranch_factor_IHandler")]
			set {
				const string __id = "setBranch_factor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFirst_timeout;
#pragma warning disable 0169
		static Delegate GetGetFirst_timeoutHandler ()
		{
			if (cb_getFirst_timeout == null)
				cb_getFirst_timeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFirst_timeout);
			return cb_getFirst_timeout;
		}

		static int n_GetFirst_timeout (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_lookup __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.First_timeout;
		}
#pragma warning restore 0169

		static Delegate cb_setFirst_timeout_I;
#pragma warning disable 0169
		static Delegate GetSetFirst_timeout_IHandler ()
		{
			if (cb_setFirst_timeout_I == null)
				cb_setFirst_timeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFirst_timeout_I);
			return cb_setFirst_timeout_I;
		}

		static void n_SetFirst_timeout_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_lookup __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.First_timeout = value;
		}
#pragma warning restore 0169

		public virtual unsafe int First_timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='getFirst_timeout' and count(parameter)=0]"
			[Register ("getFirst_timeout", "()I", "GetGetFirst_timeoutHandler")]
			get {
				const string __id = "getFirst_timeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='setFirst_timeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFirst_timeout", "(I)V", "GetSetFirst_timeout_IHandler")]
			set {
				const string __id = "setFirst_timeout.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLast_sent;
#pragma warning disable 0169
		static Delegate GetGetLast_sentHandler ()
		{
			if (cb_getLast_sent == null)
				cb_getLast_sent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLast_sent);
			return cb_getLast_sent;
		}

		static int n_GetLast_sent (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_lookup __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Last_sent;
		}
#pragma warning restore 0169

		static Delegate cb_setLast_sent_I;
#pragma warning disable 0169
		static Delegate GetSetLast_sent_IHandler ()
		{
			if (cb_setLast_sent_I == null)
				cb_setLast_sent_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLast_sent_I);
			return cb_setLast_sent_I;
		}

		static void n_SetLast_sent_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_lookup __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Last_sent = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Last_sent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='getLast_sent' and count(parameter)=0]"
			[Register ("getLast_sent", "()I", "GetGetLast_sentHandler")]
			get {
				const string __id = "getLast_sent.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='setLast_sent' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLast_sent", "(I)V", "GetSetLast_sent_IHandler")]
			set {
				const string __id = "setLast_sent.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNodes_left;
#pragma warning disable 0169
		static Delegate GetGetNodes_leftHandler ()
		{
			if (cb_getNodes_left == null)
				cb_getNodes_left = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNodes_left);
			return cb_getNodes_left;
		}

		static int n_GetNodes_left (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_lookup __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Nodes_left;
		}
#pragma warning restore 0169

		static Delegate cb_setNodes_left_I;
#pragma warning disable 0169
		static Delegate GetSetNodes_left_IHandler ()
		{
			if (cb_setNodes_left_I == null)
				cb_setNodes_left_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNodes_left_I);
			return cb_setNodes_left_I;
		}

		static void n_SetNodes_left_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_lookup __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Nodes_left = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Nodes_left {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='getNodes_left' and count(parameter)=0]"
			[Register ("getNodes_left", "()I", "GetGetNodes_leftHandler")]
			get {
				const string __id = "getNodes_left.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='setNodes_left' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNodes_left", "(I)V", "GetSetNodes_left_IHandler")]
			set {
				const string __id = "setNodes_left.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOutstanding_requests;
#pragma warning disable 0169
		static Delegate GetGetOutstanding_requestsHandler ()
		{
			if (cb_getOutstanding_requests == null)
				cb_getOutstanding_requests = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOutstanding_requests);
			return cb_getOutstanding_requests;
		}

		static int n_GetOutstanding_requests (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_lookup __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Outstanding_requests;
		}
#pragma warning restore 0169

		static Delegate cb_setOutstanding_requests_I;
#pragma warning disable 0169
		static Delegate GetSetOutstanding_requests_IHandler ()
		{
			if (cb_setOutstanding_requests_I == null)
				cb_setOutstanding_requests_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetOutstanding_requests_I);
			return cb_setOutstanding_requests_I;
		}

		static void n_SetOutstanding_requests_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_lookup __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Outstanding_requests = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Outstanding_requests {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='getOutstanding_requests' and count(parameter)=0]"
			[Register ("getOutstanding_requests", "()I", "GetGetOutstanding_requestsHandler")]
			get {
				const string __id = "getOutstanding_requests.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='setOutstanding_requests' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setOutstanding_requests", "(I)V", "GetSetOutstanding_requests_IHandler")]
			set {
				const string __id = "setOutstanding_requests.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getResponses;
#pragma warning disable 0169
		static Delegate GetGetResponsesHandler ()
		{
			if (cb_getResponses == null)
				cb_getResponses = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetResponses);
			return cb_getResponses;
		}

		static int n_GetResponses (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_lookup __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Responses;
		}
#pragma warning restore 0169

		static Delegate cb_setResponses_I;
#pragma warning disable 0169
		static Delegate GetSetResponses_IHandler ()
		{
			if (cb_setResponses_I == null)
				cb_setResponses_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetResponses_I);
			return cb_setResponses_I;
		}

		static void n_SetResponses_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_lookup __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Responses = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Responses {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='getResponses' and count(parameter)=0]"
			[Register ("getResponses", "()I", "GetGetResponsesHandler")]
			get {
				const string __id = "getResponses.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='setResponses' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setResponses", "(I)V", "GetSetResponses_IHandler")]
			set {
				const string __id = "setResponses.(I)V";
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
			global::FrostWire.Libtorrent.Swig.Dht_lookup __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::FrostWire.Libtorrent.Swig.Dht_lookup __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Target = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash Target {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='getTarget' and count(parameter)=0]"
			[Register ("getTarget", "()Lcom/frostwire/jlibtorrent/swig/sha1_hash;", "GetGetTargetHandler")]
			get {
				const string __id = "getTarget.()Lcom/frostwire/jlibtorrent/swig/sha1_hash;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='setTarget' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
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

		static Delegate cb_getTimeouts;
#pragma warning disable 0169
		static Delegate GetGetTimeoutsHandler ()
		{
			if (cb_getTimeouts == null)
				cb_getTimeouts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTimeouts);
			return cb_getTimeouts;
		}

		static int n_GetTimeouts (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_lookup __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timeouts;
		}
#pragma warning restore 0169

		static Delegate cb_setTimeouts_I;
#pragma warning disable 0169
		static Delegate GetSetTimeouts_IHandler ()
		{
			if (cb_setTimeouts_I == null)
				cb_setTimeouts_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTimeouts_I);
			return cb_setTimeouts_I;
		}

		static void n_SetTimeouts_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_lookup __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Timeouts = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Timeouts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='getTimeouts' and count(parameter)=0]"
			[Register ("getTimeouts", "()I", "GetGetTimeoutsHandler")]
			get {
				const string __id = "getTimeouts.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='setTimeouts' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTimeouts", "(I)V", "GetSetTimeouts_IHandler")]
			set {
				const string __id = "setTimeouts.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
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
			global::FrostWire.Libtorrent.Swig.Dht_lookup __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_lookup']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/dht_lookup;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Dht_lookup obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/dht_lookup;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_type;
#pragma warning disable 0169
		static Delegate GetGet_typeHandler ()
		{
			if (cb_get_type == null)
				cb_get_type = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_type);
			return cb_get_type;
		}

		static IntPtr n_Get_type (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_lookup __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Get_type ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_lookup']/method[@name='get_type' and count(parameter)=0]"
		[Register ("get_type", "()Ljava/lang/String;", "GetGet_typeHandler")]
		public virtual unsafe string Get_type ()
		{
			const string __id = "get_type.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
