using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='swig_plugin']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/swig_plugin", DoNotGenerateAcw=true)]
	public partial class Swig_plugin : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='swig_plugin']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/swig_plugin", typeof (Swig_plugin));
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

		protected Swig_plugin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='swig_plugin']/constructor[@name='swig_plugin' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Swig_plugin ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='swig_plugin']/constructor[@name='swig_plugin' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Swig_plugin (long cPtr, bool cMemoryOwn)
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
			global::FrostWire.Libtorrent.Swig.Swig_plugin __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Swig_plugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='swig_plugin']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='swig_plugin']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.swig_plugin']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/swig_plugin;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Swig_plugin obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/swig_plugin;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_on_dht_request_Lcom_frostwire_jlibtorrent_swig_string_view_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_bdecode_node_Lcom_frostwire_jlibtorrent_swig_entry_;
#pragma warning disable 0169
		static Delegate GetOn_dht_request_Lcom_frostwire_jlibtorrent_swig_string_view_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_bdecode_node_Lcom_frostwire_jlibtorrent_swig_entry_Handler ()
		{
			if (cb_on_dht_request_Lcom_frostwire_jlibtorrent_swig_string_view_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_bdecode_node_Lcom_frostwire_jlibtorrent_swig_entry_ == null)
				cb_on_dht_request_Lcom_frostwire_jlibtorrent_swig_string_view_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_bdecode_node_Lcom_frostwire_jlibtorrent_swig_entry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_On_dht_request_Lcom_frostwire_jlibtorrent_swig_string_view_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_bdecode_node_Lcom_frostwire_jlibtorrent_swig_entry_);
			return cb_on_dht_request_Lcom_frostwire_jlibtorrent_swig_string_view_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_bdecode_node_Lcom_frostwire_jlibtorrent_swig_entry_;
		}

		static bool n_On_dht_request_Lcom_frostwire_jlibtorrent_swig_string_view_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_bdecode_node_Lcom_frostwire_jlibtorrent_swig_entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_query, IntPtr native_source, IntPtr native_message, IntPtr native_response)
		{
			global::FrostWire.Libtorrent.Swig.Swig_plugin __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Swig_plugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_view query = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_view> (native_query, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Udp_endpoint source = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Udp_endpoint> (native_source, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Bdecode_node message = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (native_message, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Entry response = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (native_response, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.On_dht_request (query, source, message, response);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='swig_plugin']/method[@name='on_dht_request' and count(parameter)=4 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_view'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.udp_endpoint'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.bdecode_node'] and parameter[4][@type='com.frostwire.jlibtorrent.swig.entry']]"
		[Register ("on_dht_request", "(Lcom/frostwire/jlibtorrent/swig/string_view;Lcom/frostwire/jlibtorrent/swig/udp_endpoint;Lcom/frostwire/jlibtorrent/swig/bdecode_node;Lcom/frostwire/jlibtorrent/swig/entry;)Z", "GetOn_dht_request_Lcom_frostwire_jlibtorrent_swig_string_view_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_bdecode_node_Lcom_frostwire_jlibtorrent_swig_entry_Handler")]
		public virtual unsafe bool On_dht_request (global::FrostWire.Libtorrent.Swig.String_view query, global::FrostWire.Libtorrent.Swig.Udp_endpoint source, global::FrostWire.Libtorrent.Swig.Bdecode_node message, global::FrostWire.Libtorrent.Swig.Entry response)
		{
			const string __id = "on_dht_request.(Lcom/frostwire/jlibtorrent/swig/string_view;Lcom/frostwire/jlibtorrent/swig/udp_endpoint;Lcom/frostwire/jlibtorrent/swig/bdecode_node;Lcom/frostwire/jlibtorrent/swig/entry;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((query == null) ? IntPtr.Zero : ((global::Java.Lang.Object) query).Handle);
				__args [1] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [2] = new JniArgumentValue ((message == null) ? IntPtr.Zero : ((global::Java.Lang.Object) message).Handle);
				__args [3] = new JniArgumentValue ((response == null) ? IntPtr.Zero : ((global::Java.Lang.Object) response).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_swigDirectorDisconnect;
#pragma warning disable 0169
		static Delegate GetSwigDirectorDisconnectHandler ()
		{
			if (cb_swigDirectorDisconnect == null)
				cb_swigDirectorDisconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwigDirectorDisconnect);
			return cb_swigDirectorDisconnect;
		}

		static void n_SwigDirectorDisconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Swig_plugin __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Swig_plugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwigDirectorDisconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='swig_plugin']/method[@name='swigDirectorDisconnect' and count(parameter)=0]"
		[Register ("swigDirectorDisconnect", "()V", "GetSwigDirectorDisconnectHandler")]
		protected virtual unsafe void SwigDirectorDisconnect ()
		{
			const string __id = "swigDirectorDisconnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_swigReleaseOwnership;
#pragma warning disable 0169
		static Delegate GetSwigReleaseOwnershipHandler ()
		{
			if (cb_swigReleaseOwnership == null)
				cb_swigReleaseOwnership = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwigReleaseOwnership);
			return cb_swigReleaseOwnership;
		}

		static void n_SwigReleaseOwnership (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Swig_plugin __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Swig_plugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwigReleaseOwnership ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='swig_plugin']/method[@name='swigReleaseOwnership' and count(parameter)=0]"
		[Register ("swigReleaseOwnership", "()V", "GetSwigReleaseOwnershipHandler")]
		public virtual unsafe void SwigReleaseOwnership ()
		{
			const string __id = "swigReleaseOwnership.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_swigTakeOwnership;
#pragma warning disable 0169
		static Delegate GetSwigTakeOwnershipHandler ()
		{
			if (cb_swigTakeOwnership == null)
				cb_swigTakeOwnership = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwigTakeOwnership);
			return cb_swigTakeOwnership;
		}

		static void n_SwigTakeOwnership (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Swig_plugin __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Swig_plugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwigTakeOwnership ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='swig_plugin']/method[@name='swigTakeOwnership' and count(parameter)=0]"
		[Register ("swigTakeOwnership", "()V", "GetSwigTakeOwnershipHandler")]
		public virtual unsafe void SwigTakeOwnership ()
		{
			const string __id = "swigTakeOwnership.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
