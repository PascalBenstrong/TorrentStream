using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_stats_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/dht_stats_alert", DoNotGenerateAcw=true)]
	public partial class Dht_stats_alert : global::FrostWire.Libtorrent.Swig.Alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_stats_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_stats_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_stats_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/dht_stats_alert", typeof (Dht_stats_alert));
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

		protected Dht_stats_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_stats_alert']/constructor[@name='dht_stats_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Dht_stats_alert (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getActive_requests;
#pragma warning disable 0169
		static Delegate GetGetActive_requestsHandler ()
		{
			if (cb_getActive_requests == null)
				cb_getActive_requests = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetActive_requests);
			return cb_getActive_requests;
		}

		static IntPtr n_GetActive_requests (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_stats_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_stats_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Active_requests);
		}
#pragma warning restore 0169

		static Delegate cb_setActive_requests_Lcom_frostwire_jlibtorrent_swig_dht_lookup_vector_;
#pragma warning disable 0169
		static Delegate GetSetActive_requests_Lcom_frostwire_jlibtorrent_swig_dht_lookup_vector_Handler ()
		{
			if (cb_setActive_requests_Lcom_frostwire_jlibtorrent_swig_dht_lookup_vector_ == null)
				cb_setActive_requests_Lcom_frostwire_jlibtorrent_swig_dht_lookup_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActive_requests_Lcom_frostwire_jlibtorrent_swig_dht_lookup_vector_);
			return cb_setActive_requests_Lcom_frostwire_jlibtorrent_swig_dht_lookup_vector_;
		}

		static void n_SetActive_requests_Lcom_frostwire_jlibtorrent_swig_dht_lookup_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_stats_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_stats_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Dht_lookup_vector value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup_vector> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Active_requests = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Dht_lookup_vector Active_requests {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_stats_alert']/method[@name='getActive_requests' and count(parameter)=0]"
			[Register ("getActive_requests", "()Lcom/frostwire/jlibtorrent/swig/dht_lookup_vector;", "GetGetActive_requestsHandler")]
			get {
				const string __id = "getActive_requests.()Lcom/frostwire/jlibtorrent/swig/dht_lookup_vector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_stats_alert']/method[@name='setActive_requests' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_lookup_vector']]"
			[Register ("setActive_requests", "(Lcom/frostwire/jlibtorrent/swig/dht_lookup_vector;)V", "GetSetActive_requests_Lcom_frostwire_jlibtorrent_swig_dht_lookup_vector_Handler")]
			set {
				const string __id = "setActive_requests.(Lcom/frostwire/jlibtorrent/swig/dht_lookup_vector;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRouting_table;
#pragma warning disable 0169
		static Delegate GetGetRouting_tableHandler ()
		{
			if (cb_getRouting_table == null)
				cb_getRouting_table = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRouting_table);
			return cb_getRouting_table;
		}

		static IntPtr n_GetRouting_table (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_stats_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_stats_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Routing_table);
		}
#pragma warning restore 0169

		static Delegate cb_setRouting_table_Lcom_frostwire_jlibtorrent_swig_dht_routing_bucket_vector_;
#pragma warning disable 0169
		static Delegate GetSetRouting_table_Lcom_frostwire_jlibtorrent_swig_dht_routing_bucket_vector_Handler ()
		{
			if (cb_setRouting_table_Lcom_frostwire_jlibtorrent_swig_dht_routing_bucket_vector_ == null)
				cb_setRouting_table_Lcom_frostwire_jlibtorrent_swig_dht_routing_bucket_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRouting_table_Lcom_frostwire_jlibtorrent_swig_dht_routing_bucket_vector_);
			return cb_setRouting_table_Lcom_frostwire_jlibtorrent_swig_dht_routing_bucket_vector_;
		}

		static void n_SetRouting_table_Lcom_frostwire_jlibtorrent_swig_dht_routing_bucket_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_stats_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_stats_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Dht_routing_bucket_vector value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_routing_bucket_vector> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Routing_table = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Dht_routing_bucket_vector Routing_table {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_stats_alert']/method[@name='getRouting_table' and count(parameter)=0]"
			[Register ("getRouting_table", "()Lcom/frostwire/jlibtorrent/swig/dht_routing_bucket_vector;", "GetGetRouting_tableHandler")]
			get {
				const string __id = "getRouting_table.()Lcom/frostwire/jlibtorrent/swig/dht_routing_bucket_vector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_routing_bucket_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_stats_alert']/method[@name='setRouting_table' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_routing_bucket_vector']]"
			[Register ("setRouting_table", "(Lcom/frostwire/jlibtorrent/swig/dht_routing_bucket_vector;)V", "GetSetRouting_table_Lcom_frostwire_jlibtorrent_swig_dht_routing_bucket_vector_Handler")]
			set {
				const string __id = "setRouting_table.(Lcom/frostwire/jlibtorrent/swig/dht_routing_bucket_vector;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_stats_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_stats_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/dht_stats_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Dht_stats_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/dht_stats_alert;)J";
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
