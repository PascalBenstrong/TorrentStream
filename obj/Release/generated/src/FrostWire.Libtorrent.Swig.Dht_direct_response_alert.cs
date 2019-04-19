using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_direct_response_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/dht_direct_response_alert", DoNotGenerateAcw=true)]
	public partial class Dht_direct_response_alert : global::FrostWire.Libtorrent.Swig.Alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_direct_response_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_direct_response_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_direct_response_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/dht_direct_response_alert", typeof (Dht_direct_response_alert));
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

		protected Dht_direct_response_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_direct_response_alert']/constructor[@name='dht_direct_response_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Dht_direct_response_alert (long cPtr, bool cMemoryOwn)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_direct_response_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_direct_response_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/dht_direct_response_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Dht_direct_response_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/dht_direct_response_alert;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_endpoint;
#pragma warning disable 0169
		static Delegate GetGet_endpointHandler ()
		{
			if (cb_get_endpoint == null)
				cb_get_endpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_endpoint);
			return cb_get_endpoint;
		}

		static IntPtr n_Get_endpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_direct_response_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_direct_response_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_endpoint ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_direct_response_alert']/method[@name='get_endpoint' and count(parameter)=0]"
		[Register ("get_endpoint", "()Lcom/frostwire/jlibtorrent/swig/udp_endpoint;", "GetGet_endpointHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Udp_endpoint Get_endpoint ()
		{
			const string __id = "get_endpoint.()Lcom/frostwire/jlibtorrent/swig/udp_endpoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Udp_endpoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_userdata;
#pragma warning disable 0169
		static Delegate GetGet_userdataHandler ()
		{
			if (cb_get_userdata == null)
				cb_get_userdata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Get_userdata);
			return cb_get_userdata;
		}

		static long n_Get_userdata (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_direct_response_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_direct_response_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_userdata ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_direct_response_alert']/method[@name='get_userdata' and count(parameter)=0]"
		[Register ("get_userdata", "()J", "GetGet_userdataHandler")]
		public virtual unsafe long Get_userdata ()
		{
			const string __id = "get_userdata.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_response;
#pragma warning disable 0169
		static Delegate GetResponseHandler ()
		{
			if (cb_response == null)
				cb_response = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Response);
			return cb_response;
		}

		static IntPtr n_Response (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_direct_response_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_direct_response_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Response ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_direct_response_alert']/method[@name='response' and count(parameter)=0]"
		[Register ("response", "()Lcom/frostwire/jlibtorrent/swig/bdecode_node;", "GetResponseHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Bdecode_node Response ()
		{
			const string __id = "response.()Lcom/frostwire/jlibtorrent/swig/bdecode_node;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
