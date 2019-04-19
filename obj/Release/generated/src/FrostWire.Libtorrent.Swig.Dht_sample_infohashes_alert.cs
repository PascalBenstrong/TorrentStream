using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_sample_infohashes_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/dht_sample_infohashes_alert", DoNotGenerateAcw=true)]
	public partial class Dht_sample_infohashes_alert : global::FrostWire.Libtorrent.Swig.Alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_sample_infohashes_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_sample_infohashes_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_sample_infohashes_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/dht_sample_infohashes_alert", typeof (Dht_sample_infohashes_alert));
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

		protected Dht_sample_infohashes_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_sample_infohashes_alert']/constructor[@name='dht_sample_infohashes_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Dht_sample_infohashes_alert (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getNum_infohashes;
#pragma warning disable 0169
		static Delegate GetGetNum_infohashesHandler ()
		{
			if (cb_getNum_infohashes == null)
				cb_getNum_infohashes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNum_infohashes);
			return cb_getNum_infohashes;
		}

		static int n_GetNum_infohashes (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_sample_infohashes_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_sample_infohashes_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_infohashes;
		}
#pragma warning restore 0169

		public virtual unsafe int Num_infohashes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_sample_infohashes_alert']/method[@name='getNum_infohashes' and count(parameter)=0]"
			[Register ("getNum_infohashes", "()I", "GetGetNum_infohashesHandler")]
			get {
				const string __id = "getNum_infohashes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_sample_infohashes_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_sample_infohashes_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/dht_sample_infohashes_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Dht_sample_infohashes_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/dht_sample_infohashes_alert;)J";
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
			global::FrostWire.Libtorrent.Swig.Dht_sample_infohashes_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_sample_infohashes_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_endpoint ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_sample_infohashes_alert']/method[@name='get_endpoint' and count(parameter)=0]"
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

		static Delegate cb_get_interval;
#pragma warning disable 0169
		static Delegate GetGet_intervalHandler ()
		{
			if (cb_get_interval == null)
				cb_get_interval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Get_interval);
			return cb_get_interval;
		}

		static long n_Get_interval (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_sample_infohashes_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_sample_infohashes_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_interval ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_sample_infohashes_alert']/method[@name='get_interval' and count(parameter)=0]"
		[Register ("get_interval", "()J", "GetGet_intervalHandler")]
		public virtual unsafe long Get_interval ()
		{
			const string __id = "get_interval.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_nodes;
#pragma warning disable 0169
		static Delegate GetNodesHandler ()
		{
			if (cb_nodes == null)
				cb_nodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Nodes);
			return cb_nodes;
		}

		static IntPtr n_Nodes (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_sample_infohashes_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_sample_infohashes_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Nodes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_sample_infohashes_alert']/method[@name='nodes' and count(parameter)=0]"
		[Register ("nodes", "()Lcom/frostwire/jlibtorrent/swig/sha1_hash_udp_endpoint_pair_vector;", "GetNodesHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash_udp_endpoint_pair_vector Nodes ()
		{
			const string __id = "nodes.()Lcom/frostwire/jlibtorrent/swig/sha1_hash_udp_endpoint_pair_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash_udp_endpoint_pair_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_num_nodes;
#pragma warning disable 0169
		static Delegate GetNum_nodesHandler ()
		{
			if (cb_num_nodes == null)
				cb_num_nodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Num_nodes);
			return cb_num_nodes;
		}

		static int n_Num_nodes (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_sample_infohashes_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_sample_infohashes_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_nodes ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_sample_infohashes_alert']/method[@name='num_nodes' and count(parameter)=0]"
		[Register ("num_nodes", "()I", "GetNum_nodesHandler")]
		public virtual unsafe int Num_nodes ()
		{
			const string __id = "num_nodes.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_num_samples;
#pragma warning disable 0169
		static Delegate GetNum_samplesHandler ()
		{
			if (cb_num_samples == null)
				cb_num_samples = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Num_samples);
			return cb_num_samples;
		}

		static int n_Num_samples (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_sample_infohashes_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_sample_infohashes_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_samples ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_sample_infohashes_alert']/method[@name='num_samples' and count(parameter)=0]"
		[Register ("num_samples", "()I", "GetNum_samplesHandler")]
		public virtual unsafe int Num_samples ()
		{
			const string __id = "num_samples.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_samples;
#pragma warning disable 0169
		static Delegate GetSamplesHandler ()
		{
			if (cb_samples == null)
				cb_samples = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Samples);
			return cb_samples;
		}

		static IntPtr n_Samples (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_sample_infohashes_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_sample_infohashes_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Samples ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_sample_infohashes_alert']/method[@name='samples' and count(parameter)=0]"
		[Register ("samples", "()Lcom/frostwire/jlibtorrent/swig/sha1_hash_vector;", "GetSamplesHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash_vector Samples ()
		{
			const string __id = "samples.()Lcom/frostwire/jlibtorrent/swig/sha1_hash_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
