using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/session_handle", DoNotGenerateAcw=true)]
	public partial class Session_handle : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/field[@name='add_default_plugins']"
		[Register ("add_default_plugins")]
		public static global::FrostWire.Libtorrent.Swig.Session_flags_t AddDefaultPlugins {
			get {
				const string __id = "add_default_plugins.Lcom/frostwire/jlibtorrent/swig/session_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/field[@name='delete_files']"
		[Register ("delete_files")]
		public static global::FrostWire.Libtorrent.Swig.Remove_flags_t DeleteFiles {
			get {
				const string __id = "delete_files.Lcom/frostwire/jlibtorrent/swig/remove_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/field[@name='delete_partfile']"
		[Register ("delete_partfile")]
		public static global::FrostWire.Libtorrent.Swig.Remove_flags_t DeletePartfile {
			get {
				const string __id = "delete_partfile.Lcom/frostwire/jlibtorrent/swig/remove_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/field[@name='disk_cache_no_pieces']"
		[Register ("disk_cache_no_pieces")]
		public static int DiskCacheNoPieces {
			get {
				const string __id = "disk_cache_no_pieces.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/field[@name='reopen_map_ports']"
		[Register ("reopen_map_ports")]
		public static global::FrostWire.Libtorrent.Swig.Reopen_network_flags_t ReopenMapPorts {
			get {
				const string __id = "reopen_map_ports.Lcom/frostwire/jlibtorrent/swig/reopen_network_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Reopen_network_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/field[@name='save_dht_settings']"
		[Register ("save_dht_settings")]
		public static global::FrostWire.Libtorrent.Swig.Save_state_flags_t SaveDhtSettings {
			get {
				const string __id = "save_dht_settings.Lcom/frostwire/jlibtorrent/swig/save_state_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Save_state_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/field[@name='save_dht_state']"
		[Register ("save_dht_state")]
		public static global::FrostWire.Libtorrent.Swig.Save_state_flags_t SaveDhtState {
			get {
				const string __id = "save_dht_state.Lcom/frostwire/jlibtorrent/swig/save_state_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Save_state_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/field[@name='save_settings']"
		[Register ("save_settings")]
		public static global::FrostWire.Libtorrent.Swig.Save_state_flags_t SaveSettings {
			get {
				const string __id = "save_settings.Lcom/frostwire/jlibtorrent/swig/save_state_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Save_state_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/field[@name='start_default_features']"
		[Register ("start_default_features")]
		public static global::FrostWire.Libtorrent.Swig.Session_flags_t StartDefaultFeatures {
			get {
				const string __id = "start_default_features.Lcom/frostwire/jlibtorrent/swig/session_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/field[@name='swigCMemOwn']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/field[@name='tcp']"
		[Register ("tcp")]
		public static global::FrostWire.Libtorrent.Swig.Portmap_protocol Tcp {
			get {
				const string __id = "tcp.Lcom/frostwire/jlibtorrent/swig/portmap_protocol;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_protocol> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/field[@name='udp']"
		[Register ("udp")]
		public static global::FrostWire.Libtorrent.Swig.Portmap_protocol Udp {
			get {
				const string __id = "udp.Lcom/frostwire/jlibtorrent/swig/portmap_protocol;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_protocol> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/session_handle", typeof (Session_handle));
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

		protected Session_handle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/constructor[@name='session_handle' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Session_handle ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/constructor[@name='session_handle' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.session_handle']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/session_handle;)V", "")]
		public unsafe Session_handle (global::FrostWire.Libtorrent.Swig.Session_handle t)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/session_handle;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Object) t).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/constructor[@name='session_handle' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Session_handle (long cPtr, bool cMemoryOwn)
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

		public static unsafe int Global_peer_class_id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='getGlobal_peer_class_id' and count(parameter)=0]"
			[Register ("getGlobal_peer_class_id", "()I", "GetGetGlobal_peer_class_idHandler")]
			get {
				const string __id = "getGlobal_peer_class_id.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int Local_peer_class_id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='getLocal_peer_class_id' and count(parameter)=0]"
			[Register ("getLocal_peer_class_id", "()I", "GetGetLocal_peer_class_idHandler")]
			get {
				const string __id = "getLocal_peer_class_id.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int Tcp_peer_class_id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='getTcp_peer_class_id' and count(parameter)=0]"
			[Register ("getTcp_peer_class_id", "()I", "GetGetTcp_peer_class_idHandler")]
			get {
				const string __id = "getTcp_peer_class_id.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_add_dht_node_Lcom_frostwire_jlibtorrent_swig_string_int_pair_;
#pragma warning disable 0169
		static Delegate GetAdd_dht_node_Lcom_frostwire_jlibtorrent_swig_string_int_pair_Handler ()
		{
			if (cb_add_dht_node_Lcom_frostwire_jlibtorrent_swig_string_int_pair_ == null)
				cb_add_dht_node_Lcom_frostwire_jlibtorrent_swig_string_int_pair_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_dht_node_Lcom_frostwire_jlibtorrent_swig_string_int_pair_);
			return cb_add_dht_node_Lcom_frostwire_jlibtorrent_swig_string_int_pair_;
		}

		static void n_Add_dht_node_Lcom_frostwire_jlibtorrent_swig_string_int_pair_ (IntPtr jnienv, IntPtr native__this, IntPtr native_node)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_int_pair node = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_int_pair> (native_node, JniHandleOwnership.DoNotTransfer);
			__this.Add_dht_node (node);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='add_dht_node' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_int_pair']]"
		[Register ("add_dht_node", "(Lcom/frostwire/jlibtorrent/swig/string_int_pair;)V", "GetAdd_dht_node_Lcom_frostwire_jlibtorrent_swig_string_int_pair_Handler")]
		public virtual unsafe void Add_dht_node (global::FrostWire.Libtorrent.Swig.String_int_pair node)
		{
			const string __id = "add_dht_node.(Lcom/frostwire/jlibtorrent/swig/string_int_pair;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((node == null) ? IntPtr.Zero : ((global::Java.Lang.Object) node).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_add_extension_Lcom_frostwire_jlibtorrent_swig_swig_plugin_;
#pragma warning disable 0169
		static Delegate GetAdd_extension_Lcom_frostwire_jlibtorrent_swig_swig_plugin_Handler ()
		{
			if (cb_add_extension_Lcom_frostwire_jlibtorrent_swig_swig_plugin_ == null)
				cb_add_extension_Lcom_frostwire_jlibtorrent_swig_swig_plugin_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_extension_Lcom_frostwire_jlibtorrent_swig_swig_plugin_);
			return cb_add_extension_Lcom_frostwire_jlibtorrent_swig_swig_plugin_;
		}

		static void n_Add_extension_Lcom_frostwire_jlibtorrent_swig_swig_plugin_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ext)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Swig_plugin ext = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Swig_plugin> (native_ext, JniHandleOwnership.DoNotTransfer);
			__this.Add_extension (ext);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='add_extension' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.swig_plugin']]"
		[Register ("add_extension", "(Lcom/frostwire/jlibtorrent/swig/swig_plugin;)V", "GetAdd_extension_Lcom_frostwire_jlibtorrent_swig_swig_plugin_Handler")]
		public virtual unsafe void Add_extension (global::FrostWire.Libtorrent.Swig.Swig_plugin ext)
		{
			const string __id = "add_extension.(Lcom/frostwire/jlibtorrent/swig/swig_plugin;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ext).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_add_port_mapping_Lcom_frostwire_jlibtorrent_swig_portmap_protocol_II;
#pragma warning disable 0169
		static Delegate GetAdd_port_mapping_Lcom_frostwire_jlibtorrent_swig_portmap_protocol_IIHandler ()
		{
			if (cb_add_port_mapping_Lcom_frostwire_jlibtorrent_swig_portmap_protocol_II == null)
				cb_add_port_mapping_Lcom_frostwire_jlibtorrent_swig_portmap_protocol_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_Add_port_mapping_Lcom_frostwire_jlibtorrent_swig_portmap_protocol_II);
			return cb_add_port_mapping_Lcom_frostwire_jlibtorrent_swig_portmap_protocol_II;
		}

		static IntPtr n_Add_port_mapping_Lcom_frostwire_jlibtorrent_swig_portmap_protocol_II (IntPtr jnienv, IntPtr native__this, IntPtr native_t, int external_port, int local_port)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Portmap_protocol t = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_protocol> (native_t, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add_port_mapping (t, external_port, local_port));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='add_port_mapping' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.swig.portmap_protocol'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("add_port_mapping", "(Lcom/frostwire/jlibtorrent/swig/portmap_protocol;II)Lcom/frostwire/jlibtorrent/swig/port_mapping_t_vector;", "GetAdd_port_mapping_Lcom_frostwire_jlibtorrent_swig_portmap_protocol_IIHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector Add_port_mapping (global::FrostWire.Libtorrent.Swig.Portmap_protocol t, int external_port, int local_port)
		{
			const string __id = "add_port_mapping.(Lcom/frostwire/jlibtorrent/swig/portmap_protocol;II)Lcom/frostwire/jlibtorrent/swig/port_mapping_t_vector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Object) t).Handle);
				__args [1] = new JniArgumentValue (external_port);
				__args [2] = new JniArgumentValue (local_port);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_add_torrent_Lcom_frostwire_jlibtorrent_swig_add_torrent_params_Lcom_frostwire_jlibtorrent_swig_error_code_;
#pragma warning disable 0169
		static Delegate GetAdd_torrent_Lcom_frostwire_jlibtorrent_swig_add_torrent_params_Lcom_frostwire_jlibtorrent_swig_error_code_Handler ()
		{
			if (cb_add_torrent_Lcom_frostwire_jlibtorrent_swig_add_torrent_params_Lcom_frostwire_jlibtorrent_swig_error_code_ == null)
				cb_add_torrent_Lcom_frostwire_jlibtorrent_swig_add_torrent_params_Lcom_frostwire_jlibtorrent_swig_error_code_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_torrent_Lcom_frostwire_jlibtorrent_swig_add_torrent_params_Lcom_frostwire_jlibtorrent_swig_error_code_);
			return cb_add_torrent_Lcom_frostwire_jlibtorrent_swig_add_torrent_params_Lcom_frostwire_jlibtorrent_swig_error_code_;
		}

		static IntPtr n_Add_torrent_Lcom_frostwire_jlibtorrent_swig_add_torrent_params_Lcom_frostwire_jlibtorrent_swig_error_code_ (IntPtr jnienv, IntPtr native__this, IntPtr native__params, IntPtr native_ec)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Add_torrent_params @params = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (native__params, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Error_code ec = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Error_code> (native_ec, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add_torrent (@params, ec));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='add_torrent' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.add_torrent_params'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.error_code']]"
		[Register ("add_torrent", "(Lcom/frostwire/jlibtorrent/swig/add_torrent_params;Lcom/frostwire/jlibtorrent/swig/error_code;)Lcom/frostwire/jlibtorrent/swig/torrent_handle;", "GetAdd_torrent_Lcom_frostwire_jlibtorrent_swig_add_torrent_params_Lcom_frostwire_jlibtorrent_swig_error_code_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Torrent_handle Add_torrent (global::FrostWire.Libtorrent.Swig.Add_torrent_params @params, global::FrostWire.Libtorrent.Swig.Error_code ec)
		{
			const string __id = "add_torrent.(Lcom/frostwire/jlibtorrent/swig/add_torrent_params;Lcom/frostwire/jlibtorrent/swig/error_code;)Lcom/frostwire/jlibtorrent/swig/torrent_handle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				__args [1] = new JniArgumentValue ((ec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ec).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_apply_settings_Lcom_frostwire_jlibtorrent_swig_settings_pack_;
#pragma warning disable 0169
		static Delegate GetApply_settings_Lcom_frostwire_jlibtorrent_swig_settings_pack_Handler ()
		{
			if (cb_apply_settings_Lcom_frostwire_jlibtorrent_swig_settings_pack_ == null)
				cb_apply_settings_Lcom_frostwire_jlibtorrent_swig_settings_pack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Apply_settings_Lcom_frostwire_jlibtorrent_swig_settings_pack_);
			return cb_apply_settings_Lcom_frostwire_jlibtorrent_swig_settings_pack_;
		}

		static void n_Apply_settings_Lcom_frostwire_jlibtorrent_swig_settings_pack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Settings_pack s = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack> (native_s, JniHandleOwnership.DoNotTransfer);
			__this.Apply_settings (s);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='apply_settings' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.settings_pack']]"
		[Register ("apply_settings", "(Lcom/frostwire/jlibtorrent/swig/settings_pack;)V", "GetApply_settings_Lcom_frostwire_jlibtorrent_swig_settings_pack_Handler")]
		public virtual unsafe void Apply_settings (global::FrostWire.Libtorrent.Swig.Settings_pack s)
		{
			const string __id = "apply_settings.(Lcom/frostwire/jlibtorrent/swig/settings_pack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_async_add_torrent_Lcom_frostwire_jlibtorrent_swig_add_torrent_params_;
#pragma warning disable 0169
		static Delegate GetAsync_add_torrent_Lcom_frostwire_jlibtorrent_swig_add_torrent_params_Handler ()
		{
			if (cb_async_add_torrent_Lcom_frostwire_jlibtorrent_swig_add_torrent_params_ == null)
				cb_async_add_torrent_Lcom_frostwire_jlibtorrent_swig_add_torrent_params_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Async_add_torrent_Lcom_frostwire_jlibtorrent_swig_add_torrent_params_);
			return cb_async_add_torrent_Lcom_frostwire_jlibtorrent_swig_add_torrent_params_;
		}

		static void n_Async_add_torrent_Lcom_frostwire_jlibtorrent_swig_add_torrent_params_ (IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Add_torrent_params @params = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (native__params, JniHandleOwnership.DoNotTransfer);
			__this.Async_add_torrent (@params);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='async_add_torrent' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.add_torrent_params']]"
		[Register ("async_add_torrent", "(Lcom/frostwire/jlibtorrent/swig/add_torrent_params;)V", "GetAsync_add_torrent_Lcom_frostwire_jlibtorrent_swig_add_torrent_params_Handler")]
		public virtual unsafe void Async_add_torrent (global::FrostWire.Libtorrent.Swig.Add_torrent_params @params)
		{
			const string __id = "async_add_torrent.(Lcom/frostwire/jlibtorrent/swig/add_torrent_params;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_create_peer_class_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreate_peer_class_Ljava_lang_String_Handler ()
		{
			if (cb_create_peer_class_Ljava_lang_String_ == null)
				cb_create_peer_class_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Create_peer_class_Ljava_lang_String_);
			return cb_create_peer_class_Ljava_lang_String_;
		}

		static int n_Create_peer_class_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Create_peer_class (name);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='create_peer_class' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("create_peer_class", "(Ljava/lang/String;)I", "GetCreate_peer_class_Ljava_lang_String_Handler")]
		public virtual unsafe int Create_peer_class (string name)
		{
			const string __id = "create_peer_class.(Ljava/lang/String;)I";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
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
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_delete_peer_class_I;
#pragma warning disable 0169
		static Delegate GetDelete_peer_class_IHandler ()
		{
			if (cb_delete_peer_class_I == null)
				cb_delete_peer_class_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Delete_peer_class_I);
			return cb_delete_peer_class_I;
		}

		static void n_Delete_peer_class_I (IntPtr jnienv, IntPtr native__this, int cid)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete_peer_class (cid);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='delete_peer_class' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("delete_peer_class", "(I)V", "GetDelete_peer_class_IHandler")]
		public virtual unsafe void Delete_peer_class (int cid)
		{
			const string __id = "delete_peer_class.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (cid);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_delete_port_mapping_I;
#pragma warning disable 0169
		static Delegate GetDelete_port_mapping_IHandler ()
		{
			if (cb_delete_port_mapping_I == null)
				cb_delete_port_mapping_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Delete_port_mapping_I);
			return cb_delete_port_mapping_I;
		}

		static void n_Delete_port_mapping_I (IntPtr jnienv, IntPtr native__this, int handle)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete_port_mapping (handle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='delete_port_mapping' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("delete_port_mapping", "(I)V", "GetDelete_port_mapping_IHandler")]
		public virtual unsafe void Delete_port_mapping (int handle)
		{
			const string __id = "delete_port_mapping.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetDht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_dht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_dht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Dht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_dht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static void n_Dht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_info_hash)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash info_hash = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_info_hash, JniHandleOwnership.DoNotTransfer);
			__this.Dht_announce (info_hash);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='dht_announce' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register ("dht_announce", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V", "GetDht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
		public virtual unsafe void Dht_announce (global::FrostWire.Libtorrent.Swig.Sha1_hash info_hash)
		{
			const string __id = "dht_announce.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((info_hash == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info_hash).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_I;
#pragma warning disable 0169
		static Delegate GetDht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_IHandler ()
		{
			if (cb_dht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_I == null)
				cb_dht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Dht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_I);
			return cb_dht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_I;
		}

		static void n_Dht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_I (IntPtr jnienv, IntPtr native__this, IntPtr native_info_hash, int port)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash info_hash = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_info_hash, JniHandleOwnership.DoNotTransfer);
			__this.Dht_announce (info_hash, port);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='dht_announce' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash'] and parameter[2][@type='int']]"
		[Register ("dht_announce", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;I)V", "GetDht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_IHandler")]
		public virtual unsafe void Dht_announce (global::FrostWire.Libtorrent.Swig.Sha1_hash info_hash, int port)
		{
			const string __id = "dht_announce.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((info_hash == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info_hash).Handle);
				__args [1] = new JniArgumentValue (port);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_II;
#pragma warning disable 0169
		static Delegate GetDht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_IIHandler ()
		{
			if (cb_dht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_II == null)
				cb_dht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_Dht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_II);
			return cb_dht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_II;
		}

		static void n_Dht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_II (IntPtr jnienv, IntPtr native__this, IntPtr native_info_hash, int port, int flags)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash info_hash = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_info_hash, JniHandleOwnership.DoNotTransfer);
			__this.Dht_announce (info_hash, port, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='dht_announce' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("dht_announce", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;II)V", "GetDht_announce_Lcom_frostwire_jlibtorrent_swig_sha1_hash_IIHandler")]
		public virtual unsafe void Dht_announce (global::FrostWire.Libtorrent.Swig.Sha1_hash info_hash, int port, int flags)
		{
			const string __id = "dht_announce.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((info_hash == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info_hash).Handle);
				__args [1] = new JniArgumentValue (port);
				__args [2] = new JniArgumentValue (flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dht_direct_request_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_entry_;
#pragma warning disable 0169
		static Delegate GetDht_direct_request_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_entry_Handler ()
		{
			if (cb_dht_direct_request_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_entry_ == null)
				cb_dht_direct_request_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_entry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Dht_direct_request_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_entry_);
			return cb_dht_direct_request_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_entry_;
		}

		static void n_Dht_direct_request_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ep, IntPtr native_e)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Udp_endpoint ep = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Udp_endpoint> (native_ep, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Entry e = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.Dht_direct_request (ep, e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='dht_direct_request' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.udp_endpoint'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.entry']]"
		[Register ("dht_direct_request", "(Lcom/frostwire/jlibtorrent/swig/udp_endpoint;Lcom/frostwire/jlibtorrent/swig/entry;)V", "GetDht_direct_request_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_entry_Handler")]
		public virtual unsafe void Dht_direct_request (global::FrostWire.Libtorrent.Swig.Udp_endpoint ep, global::FrostWire.Libtorrent.Swig.Entry e)
		{
			const string __id = "dht_direct_request.(Lcom/frostwire/jlibtorrent/swig/udp_endpoint;Lcom/frostwire/jlibtorrent/swig/entry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((ep == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ep).Handle);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dht_direct_request_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_entry_J;
#pragma warning disable 0169
		static Delegate GetDht_direct_request_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_entry_JHandler ()
		{
			if (cb_dht_direct_request_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_entry_J == null)
				cb_dht_direct_request_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_entry_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_Dht_direct_request_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_entry_J);
			return cb_dht_direct_request_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_entry_J;
		}

		static void n_Dht_direct_request_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_entry_J (IntPtr jnienv, IntPtr native__this, IntPtr native_ep, IntPtr native_e, long userdata)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Udp_endpoint ep = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Udp_endpoint> (native_ep, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Entry e = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.Dht_direct_request (ep, e, userdata);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='dht_direct_request' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.swig.udp_endpoint'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.entry'] and parameter[3][@type='long']]"
		[Register ("dht_direct_request", "(Lcom/frostwire/jlibtorrent/swig/udp_endpoint;Lcom/frostwire/jlibtorrent/swig/entry;J)V", "GetDht_direct_request_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_entry_JHandler")]
		public virtual unsafe void Dht_direct_request (global::FrostWire.Libtorrent.Swig.Udp_endpoint ep, global::FrostWire.Libtorrent.Swig.Entry e, long userdata)
		{
			const string __id = "dht_direct_request.(Lcom/frostwire/jlibtorrent/swig/udp_endpoint;Lcom/frostwire/jlibtorrent/swig/entry;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((ep == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ep).Handle);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [2] = new JniArgumentValue (userdata);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dht_get_item_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
#pragma warning disable 0169
		static Delegate GetDht_get_item_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler ()
		{
			if (cb_dht_get_item_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_ == null)
				cb_dht_get_item_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Dht_get_item_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_);
			return cb_dht_get_item_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
		}

		static void n_Dht_get_item_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_salt)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector key = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_key, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector salt = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_salt, JniHandleOwnership.DoNotTransfer);
			__this.Dht_get_item (key, salt);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='dht_get_item' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("dht_get_item", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;)V", "GetDht_get_item_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler")]
		public virtual unsafe void Dht_get_item (global::FrostWire.Libtorrent.Swig.Byte_vector key, global::FrostWire.Libtorrent.Swig.Byte_vector salt)
		{
			const string __id = "dht_get_item.(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				__args [1] = new JniArgumentValue ((salt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) salt).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dht_get_item_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetDht_get_item_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_dht_get_item_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_dht_get_item_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Dht_get_item_Lcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_dht_get_item_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static void n_Dht_get_item_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash target = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_target, JniHandleOwnership.DoNotTransfer);
			__this.Dht_get_item (target);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='dht_get_item' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register ("dht_get_item", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V", "GetDht_get_item_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
		public virtual unsafe void Dht_get_item (global::FrostWire.Libtorrent.Swig.Sha1_hash target)
		{
			const string __id = "dht_get_item.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dht_get_peers_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetDht_get_peers_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_dht_get_peers_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_dht_get_peers_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Dht_get_peers_Lcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_dht_get_peers_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static void n_Dht_get_peers_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_info_hash)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash info_hash = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_info_hash, JniHandleOwnership.DoNotTransfer);
			__this.Dht_get_peers (info_hash);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='dht_get_peers' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register ("dht_get_peers", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V", "GetDht_get_peers_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
		public virtual unsafe void Dht_get_peers (global::FrostWire.Libtorrent.Swig.Sha1_hash info_hash)
		{
			const string __id = "dht_get_peers.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((info_hash == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info_hash).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dht_live_nodes_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetDht_live_nodes_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_dht_live_nodes_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_dht_live_nodes_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Dht_live_nodes_Lcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_dht_live_nodes_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static void n_Dht_live_nodes_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nid)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash nid = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_nid, JniHandleOwnership.DoNotTransfer);
			__this.Dht_live_nodes (nid);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='dht_live_nodes' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register ("dht_live_nodes", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V", "GetDht_live_nodes_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
		public virtual unsafe void Dht_live_nodes (global::FrostWire.Libtorrent.Swig.Sha1_hash nid)
		{
			const string __id = "dht_live_nodes.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((nid == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nid).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dht_put_item_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_entry_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
#pragma warning disable 0169
		static Delegate GetDht_put_item_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_entry_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler ()
		{
			if (cb_dht_put_item_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_entry_Lcom_frostwire_jlibtorrent_swig_byte_vector_ == null)
				cb_dht_put_item_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_entry_Lcom_frostwire_jlibtorrent_swig_byte_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Dht_put_item_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_entry_Lcom_frostwire_jlibtorrent_swig_byte_vector_);
			return cb_dht_put_item_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_entry_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
		}

		static void n_Dht_put_item_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_entry_Lcom_frostwire_jlibtorrent_swig_byte_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_sk, IntPtr native_data, IntPtr native_salt)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector key = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_key, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector sk = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_sk, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Entry data = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (native_data, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector salt = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_salt, JniHandleOwnership.DoNotTransfer);
			__this.Dht_put_item (key, sk, data, salt);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='dht_put_item' and count(parameter)=4 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.byte_vector'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.entry'] and parameter[4][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("dht_put_item", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/entry;Lcom/frostwire/jlibtorrent/swig/byte_vector;)V", "GetDht_put_item_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_entry_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler")]
		public virtual unsafe void Dht_put_item (global::FrostWire.Libtorrent.Swig.Byte_vector key, global::FrostWire.Libtorrent.Swig.Byte_vector sk, global::FrostWire.Libtorrent.Swig.Entry data, global::FrostWire.Libtorrent.Swig.Byte_vector salt)
		{
			const string __id = "dht_put_item.(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/entry;Lcom/frostwire/jlibtorrent/swig/byte_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				__args [1] = new JniArgumentValue ((sk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sk).Handle);
				__args [2] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [3] = new JniArgumentValue ((salt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) salt).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dht_put_item_Lcom_frostwire_jlibtorrent_swig_entry_;
#pragma warning disable 0169
		static Delegate GetDht_put_item_Lcom_frostwire_jlibtorrent_swig_entry_Handler ()
		{
			if (cb_dht_put_item_Lcom_frostwire_jlibtorrent_swig_entry_ == null)
				cb_dht_put_item_Lcom_frostwire_jlibtorrent_swig_entry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Dht_put_item_Lcom_frostwire_jlibtorrent_swig_entry_);
			return cb_dht_put_item_Lcom_frostwire_jlibtorrent_swig_entry_;
		}

		static IntPtr n_Dht_put_item_Lcom_frostwire_jlibtorrent_swig_entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Entry data = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (native_data, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Dht_put_item (data));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='dht_put_item' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.entry']]"
		[Register ("dht_put_item", "(Lcom/frostwire/jlibtorrent/swig/entry;)Lcom/frostwire/jlibtorrent/swig/sha1_hash;", "GetDht_put_item_Lcom_frostwire_jlibtorrent_swig_entry_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash Dht_put_item (global::FrostWire.Libtorrent.Swig.Entry data)
		{
			const string __id = "dht_put_item.(Lcom/frostwire/jlibtorrent/swig/entry;)Lcom/frostwire/jlibtorrent/swig/sha1_hash;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_dht_sample_infohashes_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetDht_sample_infohashes_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_dht_sample_infohashes_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_dht_sample_infohashes_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Dht_sample_infohashes_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_dht_sample_infohashes_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static void n_Dht_sample_infohashes_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ep, IntPtr native_target)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Udp_endpoint ep = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Udp_endpoint> (native_ep, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash target = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_target, JniHandleOwnership.DoNotTransfer);
			__this.Dht_sample_infohashes (ep, target);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='dht_sample_infohashes' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.udp_endpoint'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register ("dht_sample_infohashes", "(Lcom/frostwire/jlibtorrent/swig/udp_endpoint;Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V", "GetDht_sample_infohashes_Lcom_frostwire_jlibtorrent_swig_udp_endpoint_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
		public virtual unsafe void Dht_sample_infohashes (global::FrostWire.Libtorrent.Swig.Udp_endpoint ep, global::FrostWire.Libtorrent.Swig.Sha1_hash target)
		{
			const string __id = "dht_sample_infohashes.(Lcom/frostwire/jlibtorrent/swig/udp_endpoint;Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((ep == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ep).Handle);
				__args [1] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_find_torrent_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetFind_torrent_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_find_torrent_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_find_torrent_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Find_torrent_Lcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_find_torrent_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static IntPtr n_Find_torrent_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_info_hash)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash info_hash = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_info_hash, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Find_torrent (info_hash));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='find_torrent' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register ("find_torrent", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)Lcom/frostwire/jlibtorrent/swig/torrent_handle;", "GetFind_torrent_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Torrent_handle Find_torrent (global::FrostWire.Libtorrent.Swig.Sha1_hash info_hash)
		{
			const string __id = "find_torrent.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)Lcom/frostwire/jlibtorrent/swig/torrent_handle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((info_hash == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info_hash).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.session_handle']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/session_handle;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Session_handle obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/session_handle;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_dht_settings;
#pragma warning disable 0169
		static Delegate GetGet_dht_settingsHandler ()
		{
			if (cb_get_dht_settings == null)
				cb_get_dht_settings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_dht_settings);
			return cb_get_dht_settings;
		}

		static IntPtr n_Get_dht_settings (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_dht_settings ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='get_dht_settings' and count(parameter)=0]"
		[Register ("get_dht_settings", "()Lcom/frostwire/jlibtorrent/swig/dht_settings;", "GetGet_dht_settingsHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Dht_settings Get_dht_settings ()
		{
			const string __id = "get_dht_settings.()Lcom/frostwire/jlibtorrent/swig/dht_settings;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_ip_filter;
#pragma warning disable 0169
		static Delegate GetGet_ip_filterHandler ()
		{
			if (cb_get_ip_filter == null)
				cb_get_ip_filter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_ip_filter);
			return cb_get_ip_filter;
		}

		static IntPtr n_Get_ip_filter (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_ip_filter ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='get_ip_filter' and count(parameter)=0]"
		[Register ("get_ip_filter", "()Lcom/frostwire/jlibtorrent/swig/ip_filter;", "GetGet_ip_filterHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Ip_filter Get_ip_filter ()
		{
			const string __id = "get_ip_filter.()Lcom/frostwire/jlibtorrent/swig/ip_filter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_filter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_peer_class_I;
#pragma warning disable 0169
		static Delegate GetGet_peer_class_IHandler ()
		{
			if (cb_get_peer_class_I == null)
				cb_get_peer_class_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Get_peer_class_I);
			return cb_get_peer_class_I;
		}

		static IntPtr n_Get_peer_class_I (IntPtr jnienv, IntPtr native__this, int cid)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_peer_class (cid));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='get_peer_class' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get_peer_class", "(I)Lcom/frostwire/jlibtorrent/swig/peer_class_info;", "GetGet_peer_class_IHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Peer_class_info Get_peer_class (int cid)
		{
			const string __id = "get_peer_class.(I)Lcom/frostwire/jlibtorrent/swig/peer_class_info;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (cid);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_info> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_peer_class_filter;
#pragma warning disable 0169
		static Delegate GetGet_peer_class_filterHandler ()
		{
			if (cb_get_peer_class_filter == null)
				cb_get_peer_class_filter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_peer_class_filter);
			return cb_get_peer_class_filter;
		}

		static IntPtr n_Get_peer_class_filter (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_peer_class_filter ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='get_peer_class_filter' and count(parameter)=0]"
		[Register ("get_peer_class_filter", "()Lcom/frostwire/jlibtorrent/swig/ip_filter;", "GetGet_peer_class_filterHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Ip_filter Get_peer_class_filter ()
		{
			const string __id = "get_peer_class_filter.()Lcom/frostwire/jlibtorrent/swig/ip_filter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_filter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_peer_class_type_filter;
#pragma warning disable 0169
		static Delegate GetGet_peer_class_type_filterHandler ()
		{
			if (cb_get_peer_class_type_filter == null)
				cb_get_peer_class_type_filter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_peer_class_type_filter);
			return cb_get_peer_class_type_filter;
		}

		static IntPtr n_Get_peer_class_type_filter (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_peer_class_type_filter ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='get_peer_class_type_filter' and count(parameter)=0]"
		[Register ("get_peer_class_type_filter", "()Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter;", "GetGet_peer_class_type_filterHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Peer_class_type_filter Get_peer_class_type_filter ()
		{
			const string __id = "get_peer_class_type_filter.()Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_settings;
#pragma warning disable 0169
		static Delegate GetGet_settingsHandler ()
		{
			if (cb_get_settings == null)
				cb_get_settings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_settings);
			return cb_get_settings;
		}

		static IntPtr n_Get_settings (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_settings ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='get_settings' and count(parameter)=0]"
		[Register ("get_settings", "()Lcom/frostwire/jlibtorrent/swig/settings_pack;", "GetGet_settingsHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Settings_pack Get_settings ()
		{
			const string __id = "get_settings.()Lcom/frostwire/jlibtorrent/swig/settings_pack;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_torrents;
#pragma warning disable 0169
		static Delegate GetGet_torrentsHandler ()
		{
			if (cb_get_torrents == null)
				cb_get_torrents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_torrents);
			return cb_get_torrents;
		}

		static IntPtr n_Get_torrents (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_torrents ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='get_torrents' and count(parameter)=0]"
		[Register ("get_torrents", "()Lcom/frostwire/jlibtorrent/swig/torrent_handle_vector;", "GetGet_torrentsHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Torrent_handle_vector Get_torrents ()
		{
			const string __id = "get_torrents.()Lcom/frostwire/jlibtorrent/swig/torrent_handle_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_is_dht_running;
#pragma warning disable 0169
		static Delegate GetIs_dht_runningHandler ()
		{
			if (cb_is_dht_running == null)
				cb_is_dht_running = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_dht_running);
			return cb_is_dht_running;
		}

		static bool n_Is_dht_running (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_dht_running ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='is_dht_running' and count(parameter)=0]"
		[Register ("is_dht_running", "()Z", "GetIs_dht_runningHandler")]
		public virtual unsafe bool Is_dht_running ()
		{
			const string __id = "is_dht_running.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_listening;
#pragma warning disable 0169
		static Delegate GetIs_listeningHandler ()
		{
			if (cb_is_listening == null)
				cb_is_listening = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_listening);
			return cb_is_listening;
		}

		static bool n_Is_listening (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_listening ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='is_listening' and count(parameter)=0]"
		[Register ("is_listening", "()Z", "GetIs_listeningHandler")]
		public virtual unsafe bool Is_listening ()
		{
			const string __id = "is_listening.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_paused;
#pragma warning disable 0169
		static Delegate GetIs_pausedHandler ()
		{
			if (cb_is_paused == null)
				cb_is_paused = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_paused);
			return cb_is_paused;
		}

		static bool n_Is_paused (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_paused ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='is_paused' and count(parameter)=0]"
		[Register ("is_paused", "()Z", "GetIs_pausedHandler")]
		public virtual unsafe bool Is_paused ()
		{
			const string __id = "is_paused.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_valid;
#pragma warning disable 0169
		static Delegate GetIs_validHandler ()
		{
			if (cb_is_valid == null)
				cb_is_valid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_valid);
			return cb_is_valid;
		}

		static bool n_Is_valid (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_valid ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='is_valid' and count(parameter)=0]"
		[Register ("is_valid", "()Z", "GetIs_validHandler")]
		public virtual unsafe bool Is_valid ()
		{
			const string __id = "is_valid.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_listen_port;
#pragma warning disable 0169
		static Delegate GetListen_portHandler ()
		{
			if (cb_listen_port == null)
				cb_listen_port = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Listen_port);
			return cb_listen_port;
		}

		static int n_Listen_port (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Listen_port ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='listen_port' and count(parameter)=0]"
		[Register ("listen_port", "()I", "GetListen_portHandler")]
		public virtual unsafe int Listen_port ()
		{
			const string __id = "listen_port.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_load_state_Lcom_frostwire_jlibtorrent_swig_bdecode_node_;
#pragma warning disable 0169
		static Delegate GetLoad_state_Lcom_frostwire_jlibtorrent_swig_bdecode_node_Handler ()
		{
			if (cb_load_state_Lcom_frostwire_jlibtorrent_swig_bdecode_node_ == null)
				cb_load_state_Lcom_frostwire_jlibtorrent_swig_bdecode_node_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Load_state_Lcom_frostwire_jlibtorrent_swig_bdecode_node_);
			return cb_load_state_Lcom_frostwire_jlibtorrent_swig_bdecode_node_;
		}

		static void n_Load_state_Lcom_frostwire_jlibtorrent_swig_bdecode_node_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Bdecode_node e = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.Load_state (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='load_state' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.bdecode_node']]"
		[Register ("load_state", "(Lcom/frostwire/jlibtorrent/swig/bdecode_node;)V", "GetLoad_state_Lcom_frostwire_jlibtorrent_swig_bdecode_node_Handler")]
		public virtual unsafe void Load_state (global::FrostWire.Libtorrent.Swig.Bdecode_node e)
		{
			const string __id = "load_state.(Lcom/frostwire/jlibtorrent/swig/bdecode_node;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_load_state_Lcom_frostwire_jlibtorrent_swig_bdecode_node_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_;
#pragma warning disable 0169
		static Delegate GetLoad_state_Lcom_frostwire_jlibtorrent_swig_bdecode_node_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_Handler ()
		{
			if (cb_load_state_Lcom_frostwire_jlibtorrent_swig_bdecode_node_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_ == null)
				cb_load_state_Lcom_frostwire_jlibtorrent_swig_bdecode_node_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Load_state_Lcom_frostwire_jlibtorrent_swig_bdecode_node_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_);
			return cb_load_state_Lcom_frostwire_jlibtorrent_swig_bdecode_node_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_;
		}

		static void n_Load_state_Lcom_frostwire_jlibtorrent_swig_bdecode_node_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_flags)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Bdecode_node e = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (native_e, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Save_state_flags_t flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Save_state_flags_t> (native_flags, JniHandleOwnership.DoNotTransfer);
			__this.Load_state (e, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='load_state' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.bdecode_node'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.save_state_flags_t']]"
		[Register ("load_state", "(Lcom/frostwire/jlibtorrent/swig/bdecode_node;Lcom/frostwire/jlibtorrent/swig/save_state_flags_t;)V", "GetLoad_state_Lcom_frostwire_jlibtorrent_swig_bdecode_node_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_Handler")]
		public virtual unsafe void Load_state (global::FrostWire.Libtorrent.Swig.Bdecode_node e, global::FrostWire.Libtorrent.Swig.Save_state_flags_t flags)
		{
			const string __id = "load_state.(Lcom/frostwire/jlibtorrent/swig/bdecode_node;Lcom/frostwire/jlibtorrent/swig/save_state_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			const string __id = "pause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_pop_alerts_Lcom_frostwire_jlibtorrent_swig_alert_ptr_vector_;
#pragma warning disable 0169
		static Delegate GetPop_alerts_Lcom_frostwire_jlibtorrent_swig_alert_ptr_vector_Handler ()
		{
			if (cb_pop_alerts_Lcom_frostwire_jlibtorrent_swig_alert_ptr_vector_ == null)
				cb_pop_alerts_Lcom_frostwire_jlibtorrent_swig_alert_ptr_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Pop_alerts_Lcom_frostwire_jlibtorrent_swig_alert_ptr_vector_);
			return cb_pop_alerts_Lcom_frostwire_jlibtorrent_swig_alert_ptr_vector_;
		}

		static void n_Pop_alerts_Lcom_frostwire_jlibtorrent_swig_alert_ptr_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_alerts)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Alert_ptr_vector alerts = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_ptr_vector> (native_alerts, JniHandleOwnership.DoNotTransfer);
			__this.Pop_alerts (alerts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='pop_alerts' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert_ptr_vector']]"
		[Register ("pop_alerts", "(Lcom/frostwire/jlibtorrent/swig/alert_ptr_vector;)V", "GetPop_alerts_Lcom_frostwire_jlibtorrent_swig_alert_ptr_vector_Handler")]
		public virtual unsafe void Pop_alerts (global::FrostWire.Libtorrent.Swig.Alert_ptr_vector alerts)
		{
			const string __id = "pop_alerts.(Lcom/frostwire/jlibtorrent/swig/alert_ptr_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((alerts == null) ? IntPtr.Zero : ((global::Java.Lang.Object) alerts).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_post_dht_stats;
#pragma warning disable 0169
		static Delegate GetPost_dht_statsHandler ()
		{
			if (cb_post_dht_stats == null)
				cb_post_dht_stats = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Post_dht_stats);
			return cb_post_dht_stats;
		}

		static void n_Post_dht_stats (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Post_dht_stats ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='post_dht_stats' and count(parameter)=0]"
		[Register ("post_dht_stats", "()V", "GetPost_dht_statsHandler")]
		public virtual unsafe void Post_dht_stats ()
		{
			const string __id = "post_dht_stats.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_post_session_stats;
#pragma warning disable 0169
		static Delegate GetPost_session_statsHandler ()
		{
			if (cb_post_session_stats == null)
				cb_post_session_stats = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Post_session_stats);
			return cb_post_session_stats;
		}

		static void n_Post_session_stats (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Post_session_stats ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='post_session_stats' and count(parameter)=0]"
		[Register ("post_session_stats", "()V", "GetPost_session_statsHandler")]
		public virtual unsafe void Post_session_stats ()
		{
			const string __id = "post_session_stats.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_post_torrent_updates;
#pragma warning disable 0169
		static Delegate GetPost_torrent_updatesHandler ()
		{
			if (cb_post_torrent_updates == null)
				cb_post_torrent_updates = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Post_torrent_updates);
			return cb_post_torrent_updates;
		}

		static void n_Post_torrent_updates (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Post_torrent_updates ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='post_torrent_updates' and count(parameter)=0]"
		[Register ("post_torrent_updates", "()V", "GetPost_torrent_updatesHandler")]
		public virtual unsafe void Post_torrent_updates ()
		{
			const string __id = "post_torrent_updates.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_post_torrent_updates_Lcom_frostwire_jlibtorrent_swig_status_flags_t_;
#pragma warning disable 0169
		static Delegate GetPost_torrent_updates_Lcom_frostwire_jlibtorrent_swig_status_flags_t_Handler ()
		{
			if (cb_post_torrent_updates_Lcom_frostwire_jlibtorrent_swig_status_flags_t_ == null)
				cb_post_torrent_updates_Lcom_frostwire_jlibtorrent_swig_status_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Post_torrent_updates_Lcom_frostwire_jlibtorrent_swig_status_flags_t_);
			return cb_post_torrent_updates_Lcom_frostwire_jlibtorrent_swig_status_flags_t_;
		}

		static void n_Post_torrent_updates_Lcom_frostwire_jlibtorrent_swig_status_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_flags)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Status_flags_t flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (native_flags, JniHandleOwnership.DoNotTransfer);
			__this.Post_torrent_updates (flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='post_torrent_updates' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.status_flags_t']]"
		[Register ("post_torrent_updates", "(Lcom/frostwire/jlibtorrent/swig/status_flags_t;)V", "GetPost_torrent_updates_Lcom_frostwire_jlibtorrent_swig_status_flags_t_Handler")]
		public virtual unsafe void Post_torrent_updates (global::FrostWire.Libtorrent.Swig.Status_flags_t flags)
		{
			const string __id = "post_torrent_updates.(Lcom/frostwire/jlibtorrent/swig/status_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_refresh_torrent_status_Lcom_frostwire_jlibtorrent_swig_torrent_status_vector_;
#pragma warning disable 0169
		static Delegate GetRefresh_torrent_status_Lcom_frostwire_jlibtorrent_swig_torrent_status_vector_Handler ()
		{
			if (cb_refresh_torrent_status_Lcom_frostwire_jlibtorrent_swig_torrent_status_vector_ == null)
				cb_refresh_torrent_status_Lcom_frostwire_jlibtorrent_swig_torrent_status_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Refresh_torrent_status_Lcom_frostwire_jlibtorrent_swig_torrent_status_vector_);
			return cb_refresh_torrent_status_Lcom_frostwire_jlibtorrent_swig_torrent_status_vector_;
		}

		static void n_Refresh_torrent_status_Lcom_frostwire_jlibtorrent_swig_torrent_status_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ret)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Torrent_status_vector ret = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status_vector> (native_ret, JniHandleOwnership.DoNotTransfer);
			__this.Refresh_torrent_status (ret);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='refresh_torrent_status' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_status_vector']]"
		[Register ("refresh_torrent_status", "(Lcom/frostwire/jlibtorrent/swig/torrent_status_vector;)V", "GetRefresh_torrent_status_Lcom_frostwire_jlibtorrent_swig_torrent_status_vector_Handler")]
		public virtual unsafe void Refresh_torrent_status (global::FrostWire.Libtorrent.Swig.Torrent_status_vector ret)
		{
			const string __id = "refresh_torrent_status.(Lcom/frostwire/jlibtorrent/swig/torrent_status_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ret == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ret).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_refresh_torrent_status_Lcom_frostwire_jlibtorrent_swig_torrent_status_vector_Lcom_frostwire_jlibtorrent_swig_status_flags_t_;
#pragma warning disable 0169
		static Delegate GetRefresh_torrent_status_Lcom_frostwire_jlibtorrent_swig_torrent_status_vector_Lcom_frostwire_jlibtorrent_swig_status_flags_t_Handler ()
		{
			if (cb_refresh_torrent_status_Lcom_frostwire_jlibtorrent_swig_torrent_status_vector_Lcom_frostwire_jlibtorrent_swig_status_flags_t_ == null)
				cb_refresh_torrent_status_Lcom_frostwire_jlibtorrent_swig_torrent_status_vector_Lcom_frostwire_jlibtorrent_swig_status_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Refresh_torrent_status_Lcom_frostwire_jlibtorrent_swig_torrent_status_vector_Lcom_frostwire_jlibtorrent_swig_status_flags_t_);
			return cb_refresh_torrent_status_Lcom_frostwire_jlibtorrent_swig_torrent_status_vector_Lcom_frostwire_jlibtorrent_swig_status_flags_t_;
		}

		static void n_Refresh_torrent_status_Lcom_frostwire_jlibtorrent_swig_torrent_status_vector_Lcom_frostwire_jlibtorrent_swig_status_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ret, IntPtr native_flags)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Torrent_status_vector ret = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status_vector> (native_ret, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Status_flags_t flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (native_flags, JniHandleOwnership.DoNotTransfer);
			__this.Refresh_torrent_status (ret, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='refresh_torrent_status' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_status_vector'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.status_flags_t']]"
		[Register ("refresh_torrent_status", "(Lcom/frostwire/jlibtorrent/swig/torrent_status_vector;Lcom/frostwire/jlibtorrent/swig/status_flags_t;)V", "GetRefresh_torrent_status_Lcom_frostwire_jlibtorrent_swig_torrent_status_vector_Lcom_frostwire_jlibtorrent_swig_status_flags_t_Handler")]
		public virtual unsafe void Refresh_torrent_status (global::FrostWire.Libtorrent.Swig.Torrent_status_vector ret, global::FrostWire.Libtorrent.Swig.Status_flags_t flags)
		{
			const string __id = "refresh_torrent_status.(Lcom/frostwire/jlibtorrent/swig/torrent_status_vector;Lcom/frostwire/jlibtorrent/swig/status_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((ret == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ret).Handle);
				__args [1] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_remove_torrent_Lcom_frostwire_jlibtorrent_swig_torrent_handle_;
#pragma warning disable 0169
		static Delegate GetRemove_torrent_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Handler ()
		{
			if (cb_remove_torrent_Lcom_frostwire_jlibtorrent_swig_torrent_handle_ == null)
				cb_remove_torrent_Lcom_frostwire_jlibtorrent_swig_torrent_handle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_torrent_Lcom_frostwire_jlibtorrent_swig_torrent_handle_);
			return cb_remove_torrent_Lcom_frostwire_jlibtorrent_swig_torrent_handle_;
		}

		static void n_Remove_torrent_Lcom_frostwire_jlibtorrent_swig_torrent_handle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_h)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Torrent_handle h = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (native_h, JniHandleOwnership.DoNotTransfer);
			__this.Remove_torrent (h);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='remove_torrent' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_handle']]"
		[Register ("remove_torrent", "(Lcom/frostwire/jlibtorrent/swig/torrent_handle;)V", "GetRemove_torrent_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Handler")]
		public virtual unsafe void Remove_torrent (global::FrostWire.Libtorrent.Swig.Torrent_handle h)
		{
			const string __id = "remove_torrent.(Lcom/frostwire/jlibtorrent/swig/torrent_handle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((h == null) ? IntPtr.Zero : ((global::Java.Lang.Object) h).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_remove_torrent_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_;
#pragma warning disable 0169
		static Delegate GetRemove_torrent_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_Handler ()
		{
			if (cb_remove_torrent_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ == null)
				cb_remove_torrent_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Remove_torrent_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_);
			return cb_remove_torrent_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_;
		}

		static void n_Remove_torrent_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_h, IntPtr native_options)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Torrent_handle h = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (native_h, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Remove_flags_t options = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.Remove_torrent (h, options);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='remove_torrent' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_handle'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.remove_flags_t']]"
		[Register ("remove_torrent", "(Lcom/frostwire/jlibtorrent/swig/torrent_handle;Lcom/frostwire/jlibtorrent/swig/remove_flags_t;)V", "GetRemove_torrent_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_Handler")]
		public virtual unsafe void Remove_torrent (global::FrostWire.Libtorrent.Swig.Torrent_handle h, global::FrostWire.Libtorrent.Swig.Remove_flags_t options)
		{
			const string __id = "remove_torrent.(Lcom/frostwire/jlibtorrent/swig/torrent_handle;Lcom/frostwire/jlibtorrent/swig/remove_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((h == null) ? IntPtr.Zero : ((global::Java.Lang.Object) h).Handle);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reopen_network_sockets;
#pragma warning disable 0169
		static Delegate GetReopen_network_socketsHandler ()
		{
			if (cb_reopen_network_sockets == null)
				cb_reopen_network_sockets = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reopen_network_sockets);
			return cb_reopen_network_sockets;
		}

		static void n_Reopen_network_sockets (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reopen_network_sockets ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='reopen_network_sockets' and count(parameter)=0]"
		[Register ("reopen_network_sockets", "()V", "GetReopen_network_socketsHandler")]
		public virtual unsafe void Reopen_network_sockets ()
		{
			const string __id = "reopen_network_sockets.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reopen_network_sockets_Lcom_frostwire_jlibtorrent_swig_reopen_network_flags_t_;
#pragma warning disable 0169
		static Delegate GetReopen_network_sockets_Lcom_frostwire_jlibtorrent_swig_reopen_network_flags_t_Handler ()
		{
			if (cb_reopen_network_sockets_Lcom_frostwire_jlibtorrent_swig_reopen_network_flags_t_ == null)
				cb_reopen_network_sockets_Lcom_frostwire_jlibtorrent_swig_reopen_network_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Reopen_network_sockets_Lcom_frostwire_jlibtorrent_swig_reopen_network_flags_t_);
			return cb_reopen_network_sockets_Lcom_frostwire_jlibtorrent_swig_reopen_network_flags_t_;
		}

		static void n_Reopen_network_sockets_Lcom_frostwire_jlibtorrent_swig_reopen_network_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Reopen_network_flags_t options = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Reopen_network_flags_t> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.Reopen_network_sockets (options);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='reopen_network_sockets' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.reopen_network_flags_t']]"
		[Register ("reopen_network_sockets", "(Lcom/frostwire/jlibtorrent/swig/reopen_network_flags_t;)V", "GetReopen_network_sockets_Lcom_frostwire_jlibtorrent_swig_reopen_network_flags_t_Handler")]
		public virtual unsafe void Reopen_network_sockets (global::FrostWire.Libtorrent.Swig.Reopen_network_flags_t options)
		{
			const string __id = "reopen_network_sockets.(Lcom/frostwire/jlibtorrent/swig/reopen_network_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			const string __id = "resume.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_save_state_Lcom_frostwire_jlibtorrent_swig_entry_;
#pragma warning disable 0169
		static Delegate GetSave_state_Lcom_frostwire_jlibtorrent_swig_entry_Handler ()
		{
			if (cb_save_state_Lcom_frostwire_jlibtorrent_swig_entry_ == null)
				cb_save_state_Lcom_frostwire_jlibtorrent_swig_entry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Save_state_Lcom_frostwire_jlibtorrent_swig_entry_);
			return cb_save_state_Lcom_frostwire_jlibtorrent_swig_entry_;
		}

		static void n_Save_state_Lcom_frostwire_jlibtorrent_swig_entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Entry e = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.Save_state (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='save_state' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.entry']]"
		[Register ("save_state", "(Lcom/frostwire/jlibtorrent/swig/entry;)V", "GetSave_state_Lcom_frostwire_jlibtorrent_swig_entry_Handler")]
		public virtual unsafe void Save_state (global::FrostWire.Libtorrent.Swig.Entry e)
		{
			const string __id = "save_state.(Lcom/frostwire/jlibtorrent/swig/entry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_save_state_Lcom_frostwire_jlibtorrent_swig_entry_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_;
#pragma warning disable 0169
		static Delegate GetSave_state_Lcom_frostwire_jlibtorrent_swig_entry_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_Handler ()
		{
			if (cb_save_state_Lcom_frostwire_jlibtorrent_swig_entry_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_ == null)
				cb_save_state_Lcom_frostwire_jlibtorrent_swig_entry_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Save_state_Lcom_frostwire_jlibtorrent_swig_entry_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_);
			return cb_save_state_Lcom_frostwire_jlibtorrent_swig_entry_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_;
		}

		static void n_Save_state_Lcom_frostwire_jlibtorrent_swig_entry_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_flags)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Entry e = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (native_e, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Save_state_flags_t flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Save_state_flags_t> (native_flags, JniHandleOwnership.DoNotTransfer);
			__this.Save_state (e, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='save_state' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.entry'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.save_state_flags_t']]"
		[Register ("save_state", "(Lcom/frostwire/jlibtorrent/swig/entry;Lcom/frostwire/jlibtorrent/swig/save_state_flags_t;)V", "GetSave_state_Lcom_frostwire_jlibtorrent_swig_entry_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_Handler")]
		public virtual unsafe void Save_state (global::FrostWire.Libtorrent.Swig.Entry e, global::FrostWire.Libtorrent.Swig.Save_state_flags_t flags)
		{
			const string __id = "save_state.(Lcom/frostwire/jlibtorrent/swig/entry;Lcom/frostwire/jlibtorrent/swig/save_state_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_alert_notify_callback_Lcom_frostwire_jlibtorrent_swig_alert_notify_callback_;
#pragma warning disable 0169
		static Delegate GetSet_alert_notify_callback_Lcom_frostwire_jlibtorrent_swig_alert_notify_callback_Handler ()
		{
			if (cb_set_alert_notify_callback_Lcom_frostwire_jlibtorrent_swig_alert_notify_callback_ == null)
				cb_set_alert_notify_callback_Lcom_frostwire_jlibtorrent_swig_alert_notify_callback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_alert_notify_callback_Lcom_frostwire_jlibtorrent_swig_alert_notify_callback_);
			return cb_set_alert_notify_callback_Lcom_frostwire_jlibtorrent_swig_alert_notify_callback_;
		}

		static void n_Set_alert_notify_callback_Lcom_frostwire_jlibtorrent_swig_alert_notify_callback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cb)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Alert_notify_callback cb = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_notify_callback> (native_cb, JniHandleOwnership.DoNotTransfer);
			__this.Set_alert_notify_callback (cb);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='set_alert_notify_callback' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert_notify_callback']]"
		[Register ("set_alert_notify_callback", "(Lcom/frostwire/jlibtorrent/swig/alert_notify_callback;)V", "GetSet_alert_notify_callback_Lcom_frostwire_jlibtorrent_swig_alert_notify_callback_Handler")]
		public virtual unsafe void Set_alert_notify_callback (global::FrostWire.Libtorrent.Swig.Alert_notify_callback cb)
		{
			const string __id = "set_alert_notify_callback.(Lcom/frostwire/jlibtorrent/swig/alert_notify_callback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cb == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cb).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_dht_settings_Lcom_frostwire_jlibtorrent_swig_dht_settings_;
#pragma warning disable 0169
		static Delegate GetSet_dht_settings_Lcom_frostwire_jlibtorrent_swig_dht_settings_Handler ()
		{
			if (cb_set_dht_settings_Lcom_frostwire_jlibtorrent_swig_dht_settings_ == null)
				cb_set_dht_settings_Lcom_frostwire_jlibtorrent_swig_dht_settings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_dht_settings_Lcom_frostwire_jlibtorrent_swig_dht_settings_);
			return cb_set_dht_settings_Lcom_frostwire_jlibtorrent_swig_dht_settings_;
		}

		static void n_Set_dht_settings_Lcom_frostwire_jlibtorrent_swig_dht_settings_ (IntPtr jnienv, IntPtr native__this, IntPtr native_settings)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Dht_settings settings = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (native_settings, JniHandleOwnership.DoNotTransfer);
			__this.Set_dht_settings (settings);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='set_dht_settings' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_settings']]"
		[Register ("set_dht_settings", "(Lcom/frostwire/jlibtorrent/swig/dht_settings;)V", "GetSet_dht_settings_Lcom_frostwire_jlibtorrent_swig_dht_settings_Handler")]
		public virtual unsafe void Set_dht_settings (global::FrostWire.Libtorrent.Swig.Dht_settings settings)
		{
			const string __id = "set_dht_settings.(Lcom/frostwire/jlibtorrent/swig/dht_settings;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((settings == null) ? IntPtr.Zero : ((global::Java.Lang.Object) settings).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_ip_filter_Lcom_frostwire_jlibtorrent_swig_ip_filter_;
#pragma warning disable 0169
		static Delegate GetSet_ip_filter_Lcom_frostwire_jlibtorrent_swig_ip_filter_Handler ()
		{
			if (cb_set_ip_filter_Lcom_frostwire_jlibtorrent_swig_ip_filter_ == null)
				cb_set_ip_filter_Lcom_frostwire_jlibtorrent_swig_ip_filter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_ip_filter_Lcom_frostwire_jlibtorrent_swig_ip_filter_);
			return cb_set_ip_filter_Lcom_frostwire_jlibtorrent_swig_ip_filter_;
		}

		static void n_Set_ip_filter_Lcom_frostwire_jlibtorrent_swig_ip_filter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Ip_filter f = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_filter> (native_f, JniHandleOwnership.DoNotTransfer);
			__this.Set_ip_filter (f);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='set_ip_filter' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.ip_filter']]"
		[Register ("set_ip_filter", "(Lcom/frostwire/jlibtorrent/swig/ip_filter;)V", "GetSet_ip_filter_Lcom_frostwire_jlibtorrent_swig_ip_filter_Handler")]
		public virtual unsafe void Set_ip_filter (global::FrostWire.Libtorrent.Swig.Ip_filter f)
		{
			const string __id = "set_ip_filter.(Lcom/frostwire/jlibtorrent/swig/ip_filter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_peer_class_ILcom_frostwire_jlibtorrent_swig_peer_class_info_;
#pragma warning disable 0169
		static Delegate GetSet_peer_class_ILcom_frostwire_jlibtorrent_swig_peer_class_info_Handler ()
		{
			if (cb_set_peer_class_ILcom_frostwire_jlibtorrent_swig_peer_class_info_ == null)
				cb_set_peer_class_ILcom_frostwire_jlibtorrent_swig_peer_class_info_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Set_peer_class_ILcom_frostwire_jlibtorrent_swig_peer_class_info_);
			return cb_set_peer_class_ILcom_frostwire_jlibtorrent_swig_peer_class_info_;
		}

		static void n_Set_peer_class_ILcom_frostwire_jlibtorrent_swig_peer_class_info_ (IntPtr jnienv, IntPtr native__this, int cid, IntPtr native_pci)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Peer_class_info pci = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_info> (native_pci, JniHandleOwnership.DoNotTransfer);
			__this.Set_peer_class (cid, pci);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='set_peer_class' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.peer_class_info']]"
		[Register ("set_peer_class", "(ILcom/frostwire/jlibtorrent/swig/peer_class_info;)V", "GetSet_peer_class_ILcom_frostwire_jlibtorrent_swig_peer_class_info_Handler")]
		public virtual unsafe void Set_peer_class (int cid, global::FrostWire.Libtorrent.Swig.Peer_class_info pci)
		{
			const string __id = "set_peer_class.(ILcom/frostwire/jlibtorrent/swig/peer_class_info;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (cid);
				__args [1] = new JniArgumentValue ((pci == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pci).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_peer_class_filter_Lcom_frostwire_jlibtorrent_swig_ip_filter_;
#pragma warning disable 0169
		static Delegate GetSet_peer_class_filter_Lcom_frostwire_jlibtorrent_swig_ip_filter_Handler ()
		{
			if (cb_set_peer_class_filter_Lcom_frostwire_jlibtorrent_swig_ip_filter_ == null)
				cb_set_peer_class_filter_Lcom_frostwire_jlibtorrent_swig_ip_filter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_peer_class_filter_Lcom_frostwire_jlibtorrent_swig_ip_filter_);
			return cb_set_peer_class_filter_Lcom_frostwire_jlibtorrent_swig_ip_filter_;
		}

		static void n_Set_peer_class_filter_Lcom_frostwire_jlibtorrent_swig_ip_filter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Ip_filter f = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_filter> (native_f, JniHandleOwnership.DoNotTransfer);
			__this.Set_peer_class_filter (f);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='set_peer_class_filter' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.ip_filter']]"
		[Register ("set_peer_class_filter", "(Lcom/frostwire/jlibtorrent/swig/ip_filter;)V", "GetSet_peer_class_filter_Lcom_frostwire_jlibtorrent_swig_ip_filter_Handler")]
		public virtual unsafe void Set_peer_class_filter (global::FrostWire.Libtorrent.Swig.Ip_filter f)
		{
			const string __id = "set_peer_class_filter.(Lcom/frostwire/jlibtorrent/swig/ip_filter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_peer_class_type_filter_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_;
#pragma warning disable 0169
		static Delegate GetSet_peer_class_type_filter_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_Handler ()
		{
			if (cb_set_peer_class_type_filter_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_ == null)
				cb_set_peer_class_type_filter_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_peer_class_type_filter_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_);
			return cb_set_peer_class_type_filter_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_;
		}

		static void n_Set_peer_class_type_filter_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Peer_class_type_filter f = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter> (native_f, JniHandleOwnership.DoNotTransfer);
			__this.Set_peer_class_type_filter (f);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='set_peer_class_type_filter' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_class_type_filter']]"
		[Register ("set_peer_class_type_filter", "(Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter;)V", "GetSet_peer_class_type_filter_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_Handler")]
		public virtual unsafe void Set_peer_class_type_filter (global::FrostWire.Libtorrent.Swig.Peer_class_type_filter f)
		{
			const string __id = "set_peer_class_type_filter.(Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_port_filter_Lcom_frostwire_jlibtorrent_swig_port_filter_;
#pragma warning disable 0169
		static Delegate GetSet_port_filter_Lcom_frostwire_jlibtorrent_swig_port_filter_Handler ()
		{
			if (cb_set_port_filter_Lcom_frostwire_jlibtorrent_swig_port_filter_ == null)
				cb_set_port_filter_Lcom_frostwire_jlibtorrent_swig_port_filter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_port_filter_Lcom_frostwire_jlibtorrent_swig_port_filter_);
			return cb_set_port_filter_Lcom_frostwire_jlibtorrent_swig_port_filter_;
		}

		static void n_Set_port_filter_Lcom_frostwire_jlibtorrent_swig_port_filter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Port_filter f = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Port_filter> (native_f, JniHandleOwnership.DoNotTransfer);
			__this.Set_port_filter (f);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='set_port_filter' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.port_filter']]"
		[Register ("set_port_filter", "(Lcom/frostwire/jlibtorrent/swig/port_filter;)V", "GetSet_port_filter_Lcom_frostwire_jlibtorrent_swig_port_filter_Handler")]
		public virtual unsafe void Set_port_filter (global::FrostWire.Libtorrent.Swig.Port_filter f)
		{
			const string __id = "set_port_filter.(Lcom/frostwire/jlibtorrent/swig/port_filter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_ssl_listen_port;
#pragma warning disable 0169
		static Delegate GetSsl_listen_portHandler ()
		{
			if (cb_ssl_listen_port == null)
				cb_ssl_listen_port = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Ssl_listen_port);
			return cb_ssl_listen_port;
		}

		static int n_Ssl_listen_port (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ssl_listen_port ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='ssl_listen_port' and count(parameter)=0]"
		[Register ("ssl_listen_port", "()I", "GetSsl_listen_portHandler")]
		public virtual unsafe int Ssl_listen_port ()
		{
			const string __id = "ssl_listen_port.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_wait_for_alert_ms_J;
#pragma warning disable 0169
		static Delegate GetWait_for_alert_ms_JHandler ()
		{
			if (cb_wait_for_alert_ms_J == null)
				cb_wait_for_alert_ms_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Wait_for_alert_ms_J);
			return cb_wait_for_alert_ms_J;
		}

		static IntPtr n_Wait_for_alert_ms_J (IntPtr jnienv, IntPtr native__this, long max_wait)
		{
			global::FrostWire.Libtorrent.Swig.Session_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Wait_for_alert_ms (max_wait));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='session_handle']/method[@name='wait_for_alert_ms' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("wait_for_alert_ms", "(J)Lcom/frostwire/jlibtorrent/swig/alert;", "GetWait_for_alert_ms_JHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Alert Wait_for_alert_ms (long max_wait)
		{
			const string __id = "wait_for_alert_ms.(J)Lcom/frostwire/jlibtorrent/swig/alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (max_wait);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
