using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='invalid_request_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/invalid_request_alert", DoNotGenerateAcw=true)]
	public partial class Invalid_request_alert : global::FrostWire.Libtorrent.Swig.Peer_alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='invalid_request_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='invalid_request_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='invalid_request_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/invalid_request_alert", typeof (Invalid_request_alert));
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

		protected Invalid_request_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='invalid_request_alert']/constructor[@name='invalid_request_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Invalid_request_alert (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getPeer_interested;
#pragma warning disable 0169
		static Delegate GetGetPeer_interestedHandler ()
		{
			if (cb_getPeer_interested == null)
				cb_getPeer_interested = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetPeer_interested);
			return cb_getPeer_interested;
		}

		static bool n_GetPeer_interested (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Invalid_request_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Invalid_request_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Peer_interested;
		}
#pragma warning restore 0169

		public virtual unsafe bool Peer_interested {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='invalid_request_alert']/method[@name='getPeer_interested' and count(parameter)=0]"
			[Register ("getPeer_interested", "()Z", "GetGetPeer_interestedHandler")]
			get {
				const string __id = "getPeer_interested.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRequest;
#pragma warning disable 0169
		static Delegate GetGetRequestHandler ()
		{
			if (cb_getRequest == null)
				cb_getRequest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRequest);
			return cb_getRequest;
		}

		static IntPtr n_GetRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Invalid_request_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Invalid_request_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Request);
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Peer_request Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='invalid_request_alert']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lcom/frostwire/jlibtorrent/swig/peer_request;", "GetGetRequestHandler")]
			get {
				const string __id = "getRequest.()Lcom/frostwire/jlibtorrent/swig/peer_request;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_request> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWe_have;
#pragma warning disable 0169
		static Delegate GetGetWe_haveHandler ()
		{
			if (cb_getWe_have == null)
				cb_getWe_have = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetWe_have);
			return cb_getWe_have;
		}

		static bool n_GetWe_have (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Invalid_request_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Invalid_request_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.We_have;
		}
#pragma warning restore 0169

		public virtual unsafe bool We_have {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='invalid_request_alert']/method[@name='getWe_have' and count(parameter)=0]"
			[Register ("getWe_have", "()Z", "GetGetWe_haveHandler")]
			get {
				const string __id = "getWe_have.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getWithheld;
#pragma warning disable 0169
		static Delegate GetGetWithheldHandler ()
		{
			if (cb_getWithheld == null)
				cb_getWithheld = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetWithheld);
			return cb_getWithheld;
		}

		static bool n_GetWithheld (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Invalid_request_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Invalid_request_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Withheld;
		}
#pragma warning restore 0169

		public virtual unsafe bool Withheld {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='invalid_request_alert']/method[@name='getWithheld' and count(parameter)=0]"
			[Register ("getWithheld", "()Z", "GetGetWithheldHandler")]
			get {
				const string __id = "getWithheld.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='invalid_request_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.invalid_request_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/invalid_request_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Invalid_request_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/invalid_request_alert;)J";
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
