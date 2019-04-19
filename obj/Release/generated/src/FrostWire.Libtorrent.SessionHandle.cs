using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/SessionHandle", DoNotGenerateAcw=true)]
	public partial class SessionHandle : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/field[@name='DELETE_FILES']"
		[Register ("DELETE_FILES")]
		public static global::FrostWire.Libtorrent.Swig.Remove_flags_t DeleteFiles {
			get {
				const string __id = "DELETE_FILES.Lcom/frostwire/jlibtorrent/swig/remove_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/field[@name='DELETE_PARTFILE']"
		[Register ("DELETE_PARTFILE")]
		public static global::FrostWire.Libtorrent.Swig.Remove_flags_t DeletePartfile {
			get {
				const string __id = "DELETE_PARTFILE.Lcom/frostwire/jlibtorrent/swig/remove_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/field[@name='DHT_ANNOUNCE_IMPLIED_PORT']"
		[Register ("DHT_ANNOUNCE_IMPLIED_PORT")]
		public const int DhtAnnounceImpliedPort = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/field[@name='DHT_ANNOUNCE_SEED']"
		[Register ("DHT_ANNOUNCE_SEED")]
		public const int DhtAnnounceSeed = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/field[@name='DHT_ANNOUNCE_SSL_TORRENT']"
		[Register ("DHT_ANNOUNCE_SSL_TORRENT")]
		public const int DhtAnnounceSslTorrent = (int) 4;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/field[@name='REOPEN_MAP_PORTS']"
		[Register ("REOPEN_MAP_PORTS")]
		public static global::FrostWire.Libtorrent.Swig.Reopen_network_flags_t ReopenMapPorts {
			get {
				const string __id = "REOPEN_MAP_PORTS.Lcom/frostwire/jlibtorrent/swig/reopen_network_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Reopen_network_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/field[@name='SAVE_DHT_SETTINGS']"
		[Register ("SAVE_DHT_SETTINGS")]
		public static global::FrostWire.Libtorrent.Swig.Save_state_flags_t SaveDhtSettings {
			get {
				const string __id = "SAVE_DHT_SETTINGS.Lcom/frostwire/jlibtorrent/swig/save_state_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Save_state_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/field[@name='SAVE_DHT_STATE']"
		[Register ("SAVE_DHT_STATE")]
		public static global::FrostWire.Libtorrent.Swig.Save_state_flags_t SaveDhtState {
			get {
				const string __id = "SAVE_DHT_STATE.Lcom/frostwire/jlibtorrent/swig/save_state_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Save_state_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/field[@name='SAVE_SETTINGS']"
		[Register ("SAVE_SETTINGS")]
		public static global::FrostWire.Libtorrent.Swig.Save_state_flags_t SaveSettings {
			get {
				const string __id = "SAVE_SETTINGS.Lcom/frostwire/jlibtorrent/swig/save_state_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Save_state_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/field[@name='s']"
		[Register ("s")]
		protected global::FrostWire.Libtorrent.Swig.Session_handle S {
			get {
				const string __id = "s.Lcom/frostwire/jlibtorrent/swig/session_handle;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "s.Lcom/frostwire/jlibtorrent/swig/session_handle;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/SessionHandle", typeof (SessionHandle));
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

		protected SessionHandle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/constructor[@name='SessionHandle' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.session_handle']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/session_handle;)V", "")]
		public unsafe SessionHandle (global::FrostWire.Libtorrent.Swig.Session_handle s)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/session_handle;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
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
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDhtRunning;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDhtRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='isDhtRunning' and count(parameter)=0]"
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

		static Delegate cb_isListening;
#pragma warning disable 0169
		static Delegate GetIsListeningHandler ()
		{
			if (cb_isListening == null)
				cb_isListening = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsListening);
			return cb_isListening;
		}

		static bool n_IsListening (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsListening;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsListening {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='isListening' and count(parameter)=0]"
			[Register ("isListening", "()Z", "GetIsListeningHandler")]
			get {
				const string __id = "isListening.()Z";
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
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPaused;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='isPaused' and count(parameter)=0]"
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

		static Delegate cb_isValid;
#pragma warning disable 0169
		static Delegate GetIsValidHandler ()
		{
			if (cb_isValid == null)
				cb_isValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsValid);
			return cb_isValid;
		}

		static bool n_IsValid (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				const string __id = "isValid.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getListenPort;
#pragma warning disable 0169
		static Delegate GetGetListenPortHandler ()
		{
			if (cb_getListenPort == null)
				cb_getListenPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetListenPort);
			return cb_getListenPort;
		}

		static int n_GetListenPort (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ListenPort;
		}
#pragma warning restore 0169

		public virtual unsafe int ListenPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='getListenPort' and count(parameter)=0]"
			[Register ("getListenPort", "()I", "GetGetListenPortHandler")]
			get {
				const string __id = "getListenPort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSslListenPort;
#pragma warning disable 0169
		static Delegate GetGetSslListenPortHandler ()
		{
			if (cb_getSslListenPort == null)
				cb_getSslListenPort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSslListenPort);
			return cb_getSslListenPort;
		}

		static int n_GetSslListenPort (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SslListenPort;
		}
#pragma warning restore 0169

		public virtual unsafe int SslListenPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='getSslListenPort' and count(parameter)=0]"
			[Register ("getSslListenPort", "()I", "GetGetSslListenPortHandler")]
			get {
				const string __id = "getSslListenPort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_addDhtNode_Lcom_frostwire_jlibtorrent_Pair_;
#pragma warning disable 0169
		static Delegate GetAddDhtNode_Lcom_frostwire_jlibtorrent_Pair_Handler ()
		{
			if (cb_addDhtNode_Lcom_frostwire_jlibtorrent_Pair_ == null)
				cb_addDhtNode_Lcom_frostwire_jlibtorrent_Pair_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddDhtNode_Lcom_frostwire_jlibtorrent_Pair_);
			return cb_addDhtNode_Lcom_frostwire_jlibtorrent_Pair_;
		}

		static void n_AddDhtNode_Lcom_frostwire_jlibtorrent_Pair_ (IntPtr jnienv, IntPtr native__this, IntPtr native_node)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Pair node = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Pair> (native_node, JniHandleOwnership.DoNotTransfer);
			__this.AddDhtNode (node);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='addDhtNode' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Pair&lt;java.lang.String, java.lang.Integer&gt;']]"
		[Register ("addDhtNode", "(Lcom/frostwire/jlibtorrent/Pair;)V", "GetAddDhtNode_Lcom_frostwire_jlibtorrent_Pair_Handler")]
		public virtual unsafe void AddDhtNode (global::FrostWire.Libtorrent.Pair node)
		{
			const string __id = "addDhtNode.(Lcom/frostwire/jlibtorrent/Pair;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((node == null) ? IntPtr.Zero : ((global::Java.Lang.Object) node).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addExtension_Lcom_frostwire_jlibtorrent_Plugin_;
#pragma warning disable 0169
		static Delegate GetAddExtension_Lcom_frostwire_jlibtorrent_Plugin_Handler ()
		{
			if (cb_addExtension_Lcom_frostwire_jlibtorrent_Plugin_ == null)
				cb_addExtension_Lcom_frostwire_jlibtorrent_Plugin_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddExtension_Lcom_frostwire_jlibtorrent_Plugin_);
			return cb_addExtension_Lcom_frostwire_jlibtorrent_Plugin_;
		}

		static void n_AddExtension_Lcom_frostwire_jlibtorrent_Plugin_ (IntPtr jnienv, IntPtr native__this, IntPtr native_plugin)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.IPlugin plugin = (global::FrostWire.Libtorrent.IPlugin)global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.IPlugin> (native_plugin, JniHandleOwnership.DoNotTransfer);
			__this.AddExtension (plugin);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='addExtension' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Plugin']]"
		[Register ("addExtension", "(Lcom/frostwire/jlibtorrent/Plugin;)V", "GetAddExtension_Lcom_frostwire_jlibtorrent_Plugin_Handler")]
		public virtual unsafe void AddExtension (global::FrostWire.Libtorrent.IPlugin plugin)
		{
			const string __id = "addExtension.(Lcom/frostwire/jlibtorrent/Plugin;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((plugin == null) ? IntPtr.Zero : ((global::Java.Lang.Object) plugin).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addPortMapping_Lcom_frostwire_jlibtorrent_PortmapProtocol_II;
#pragma warning disable 0169
		static Delegate GetAddPortMapping_Lcom_frostwire_jlibtorrent_PortmapProtocol_IIHandler ()
		{
			if (cb_addPortMapping_Lcom_frostwire_jlibtorrent_PortmapProtocol_II == null)
				cb_addPortMapping_Lcom_frostwire_jlibtorrent_PortmapProtocol_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_AddPortMapping_Lcom_frostwire_jlibtorrent_PortmapProtocol_II);
			return cb_addPortMapping_Lcom_frostwire_jlibtorrent_PortmapProtocol_II;
		}

		static IntPtr n_AddPortMapping_Lcom_frostwire_jlibtorrent_PortmapProtocol_II (IntPtr jnienv, IntPtr native__this, IntPtr native_t, int externalPort, int localPort)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.PortmapProtocol t = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PortmapProtocol> (native_t, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.AddPortMapping (t, externalPort, localPort));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='addPortMapping' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.PortmapProtocol'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("addPortMapping", "(Lcom/frostwire/jlibtorrent/PortmapProtocol;II)[I", "GetAddPortMapping_Lcom_frostwire_jlibtorrent_PortmapProtocol_IIHandler")]
		public virtual unsafe int[] AddPortMapping (global::FrostWire.Libtorrent.PortmapProtocol t, int externalPort, int localPort)
		{
			const string __id = "addPortMapping.(Lcom/frostwire/jlibtorrent/PortmapProtocol;II)[I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Object) t).Handle);
				__args [1] = new JniArgumentValue (externalPort);
				__args [2] = new JniArgumentValue (localPort);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_addTorrent_Lcom_frostwire_jlibtorrent_AddTorrentParams_Lcom_frostwire_jlibtorrent_ErrorCode_;
#pragma warning disable 0169
		static Delegate GetAddTorrent_Lcom_frostwire_jlibtorrent_AddTorrentParams_Lcom_frostwire_jlibtorrent_ErrorCode_Handler ()
		{
			if (cb_addTorrent_Lcom_frostwire_jlibtorrent_AddTorrentParams_Lcom_frostwire_jlibtorrent_ErrorCode_ == null)
				cb_addTorrent_Lcom_frostwire_jlibtorrent_AddTorrentParams_Lcom_frostwire_jlibtorrent_ErrorCode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddTorrent_Lcom_frostwire_jlibtorrent_AddTorrentParams_Lcom_frostwire_jlibtorrent_ErrorCode_);
			return cb_addTorrent_Lcom_frostwire_jlibtorrent_AddTorrentParams_Lcom_frostwire_jlibtorrent_ErrorCode_;
		}

		static IntPtr n_AddTorrent_Lcom_frostwire_jlibtorrent_AddTorrentParams_Lcom_frostwire_jlibtorrent_ErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native__params, IntPtr native_ec)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.AddTorrentParams @params = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.AddTorrentParams> (native__params, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.ErrorCode ec = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.ErrorCode> (native_ec, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddTorrent (@params, ec));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='addTorrent' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.AddTorrentParams'] and parameter[2][@type='com.frostwire.jlibtorrent.ErrorCode']]"
		[Register ("addTorrent", "(Lcom/frostwire/jlibtorrent/AddTorrentParams;Lcom/frostwire/jlibtorrent/ErrorCode;)Lcom/frostwire/jlibtorrent/TorrentHandle;", "GetAddTorrent_Lcom_frostwire_jlibtorrent_AddTorrentParams_Lcom_frostwire_jlibtorrent_ErrorCode_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.TorrentHandle AddTorrent (global::FrostWire.Libtorrent.AddTorrentParams @params, global::FrostWire.Libtorrent.ErrorCode ec)
		{
			const string __id = "addTorrent.(Lcom/frostwire/jlibtorrent/AddTorrentParams;Lcom/frostwire/jlibtorrent/ErrorCode;)Lcom/frostwire/jlibtorrent/TorrentHandle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				__args [1] = new JniArgumentValue ((ec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ec).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentHandle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.SettingsPack sp = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (native_sp, JniHandleOwnership.DoNotTransfer);
			__this.ApplySettings (sp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='applySettings' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.SettingsPack']]"
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

		static Delegate cb_asyncAddTorrent_Lcom_frostwire_jlibtorrent_AddTorrentParams_;
#pragma warning disable 0169
		static Delegate GetAsyncAddTorrent_Lcom_frostwire_jlibtorrent_AddTorrentParams_Handler ()
		{
			if (cb_asyncAddTorrent_Lcom_frostwire_jlibtorrent_AddTorrentParams_ == null)
				cb_asyncAddTorrent_Lcom_frostwire_jlibtorrent_AddTorrentParams_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AsyncAddTorrent_Lcom_frostwire_jlibtorrent_AddTorrentParams_);
			return cb_asyncAddTorrent_Lcom_frostwire_jlibtorrent_AddTorrentParams_;
		}

		static void n_AsyncAddTorrent_Lcom_frostwire_jlibtorrent_AddTorrentParams_ (IntPtr jnienv, IntPtr native__this, IntPtr native__params)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.AddTorrentParams @params = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.AddTorrentParams> (native__params, JniHandleOwnership.DoNotTransfer);
			__this.AsyncAddTorrent (@params);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='asyncAddTorrent' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.AddTorrentParams']]"
		[Register ("asyncAddTorrent", "(Lcom/frostwire/jlibtorrent/AddTorrentParams;)V", "GetAsyncAddTorrent_Lcom_frostwire_jlibtorrent_AddTorrentParams_Handler")]
		public virtual unsafe void AsyncAddTorrent (global::FrostWire.Libtorrent.AddTorrentParams @params)
		{
			const string __id = "asyncAddTorrent.(Lcom/frostwire/jlibtorrent/AddTorrentParams;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @params).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_deletePortMapping_I;
#pragma warning disable 0169
		static Delegate GetDeletePortMapping_IHandler ()
		{
			if (cb_deletePortMapping_I == null)
				cb_deletePortMapping_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_DeletePortMapping_I);
			return cb_deletePortMapping_I;
		}

		static void n_DeletePortMapping_I (IntPtr jnienv, IntPtr native__this, int handle)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeletePortMapping (handle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='deletePortMapping' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("deletePortMapping", "(I)V", "GetDeletePortMapping_IHandler")]
		public virtual unsafe void DeletePortMapping (int handle)
		{
			const string __id = "deletePortMapping.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (handle);
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

		static void n_DhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_infoHash)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Sha1Hash infoHash = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (native_infoHash, JniHandleOwnership.DoNotTransfer);
			__this.DhtAnnounce (infoHash);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='dhtAnnounce' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Sha1Hash']]"
		[Register ("dhtAnnounce", "(Lcom/frostwire/jlibtorrent/Sha1Hash;)V", "GetDhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_Handler")]
		public virtual unsafe void DhtAnnounce (global::FrostWire.Libtorrent.Sha1Hash infoHash)
		{
			const string __id = "dhtAnnounce.(Lcom/frostwire/jlibtorrent/Sha1Hash;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((infoHash == null) ? IntPtr.Zero : ((global::Java.Lang.Object) infoHash).Handle);
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

		static void n_DhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_II (IntPtr jnienv, IntPtr native__this, IntPtr native_infoHash, int port, int flags)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Sha1Hash infoHash = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (native_infoHash, JniHandleOwnership.DoNotTransfer);
			__this.DhtAnnounce (infoHash, port, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='dhtAnnounce' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.Sha1Hash'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("dhtAnnounce", "(Lcom/frostwire/jlibtorrent/Sha1Hash;II)V", "GetDhtAnnounce_Lcom_frostwire_jlibtorrent_Sha1Hash_IIHandler")]
		public virtual unsafe void DhtAnnounce (global::FrostWire.Libtorrent.Sha1Hash infoHash, int port, int flags)
		{
			const string __id = "dhtAnnounce.(Lcom/frostwire/jlibtorrent/Sha1Hash;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((infoHash == null) ? IntPtr.Zero : ((global::Java.Lang.Object) infoHash).Handle);
				__args [1] = new JniArgumentValue (port);
				__args [2] = new JniArgumentValue (flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dhtDirectRequest_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_Entry_;
#pragma warning disable 0169
		static Delegate GetDhtDirectRequest_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_Entry_Handler ()
		{
			if (cb_dhtDirectRequest_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_Entry_ == null)
				cb_dhtDirectRequest_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_Entry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DhtDirectRequest_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_Entry_);
			return cb_dhtDirectRequest_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_Entry_;
		}

		static void n_DhtDirectRequest_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_endp, IntPtr native_entry)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.UdpEndpoint endp = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.UdpEndpoint> (native_endp, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Entry entry = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Entry> (native_entry, JniHandleOwnership.DoNotTransfer);
			__this.DhtDirectRequest (endp, entry);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='dhtDirectRequest' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.UdpEndpoint'] and parameter[2][@type='com.frostwire.jlibtorrent.Entry']]"
		[Register ("dhtDirectRequest", "(Lcom/frostwire/jlibtorrent/UdpEndpoint;Lcom/frostwire/jlibtorrent/Entry;)V", "GetDhtDirectRequest_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_Entry_Handler")]
		public virtual unsafe void DhtDirectRequest (global::FrostWire.Libtorrent.UdpEndpoint endp, global::FrostWire.Libtorrent.Entry entry)
		{
			const string __id = "dhtDirectRequest.(Lcom/frostwire/jlibtorrent/UdpEndpoint;Lcom/frostwire/jlibtorrent/Entry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((endp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) endp).Handle);
				__args [1] = new JniArgumentValue ((entry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entry).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dhtDirectRequest_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_Entry_J;
#pragma warning disable 0169
		static Delegate GetDhtDirectRequest_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_Entry_JHandler ()
		{
			if (cb_dhtDirectRequest_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_Entry_J == null)
				cb_dhtDirectRequest_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_Entry_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_DhtDirectRequest_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_Entry_J);
			return cb_dhtDirectRequest_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_Entry_J;
		}

		static void n_DhtDirectRequest_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_Entry_J (IntPtr jnienv, IntPtr native__this, IntPtr native_endp, IntPtr native_entry, long userdata)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.UdpEndpoint endp = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.UdpEndpoint> (native_endp, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Entry entry = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Entry> (native_entry, JniHandleOwnership.DoNotTransfer);
			__this.DhtDirectRequest (endp, entry, userdata);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='dhtDirectRequest' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.UdpEndpoint'] and parameter[2][@type='com.frostwire.jlibtorrent.Entry'] and parameter[3][@type='long']]"
		[Register ("dhtDirectRequest", "(Lcom/frostwire/jlibtorrent/UdpEndpoint;Lcom/frostwire/jlibtorrent/Entry;J)V", "GetDhtDirectRequest_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_Entry_JHandler")]
		public virtual unsafe void DhtDirectRequest (global::FrostWire.Libtorrent.UdpEndpoint endp, global::FrostWire.Libtorrent.Entry entry, long userdata)
		{
			const string __id = "dhtDirectRequest.(Lcom/frostwire/jlibtorrent/UdpEndpoint;Lcom/frostwire/jlibtorrent/Entry;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((endp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) endp).Handle);
				__args [1] = new JniArgumentValue ((entry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entry).Handle);
				__args [2] = new JniArgumentValue (userdata);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dhtGetItem_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetDhtGetItem_arrayBarrayBHandler ()
		{
			if (cb_dhtGetItem_arrayBarrayB == null)
				cb_dhtGetItem_arrayBarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DhtGetItem_arrayBarrayB);
			return cb_dhtGetItem_arrayBarrayB;
		}

		static void n_DhtGetItem_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_salt)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] key = (byte[]) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] salt = (byte[]) JNIEnv.GetArray (native_salt, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.DhtGetItem (key, salt);
			if (key != null)
				JNIEnv.CopyArray (key, native_key);
			if (salt != null)
				JNIEnv.CopyArray (salt, native_salt);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='dhtGetItem' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("dhtGetItem", "([B[B)V", "GetDhtGetItem_arrayBarrayBHandler")]
		public virtual unsafe void DhtGetItem (byte[] key, byte[] salt)
		{
			const string __id = "dhtGetItem.([B[B)V";
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_salt = JNIEnv.NewArray (salt);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_salt);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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

		static Delegate cb_dhtGetItem_Lcom_frostwire_jlibtorrent_Sha1Hash_;
#pragma warning disable 0169
		static Delegate GetDhtGetItem_Lcom_frostwire_jlibtorrent_Sha1Hash_Handler ()
		{
			if (cb_dhtGetItem_Lcom_frostwire_jlibtorrent_Sha1Hash_ == null)
				cb_dhtGetItem_Lcom_frostwire_jlibtorrent_Sha1Hash_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DhtGetItem_Lcom_frostwire_jlibtorrent_Sha1Hash_);
			return cb_dhtGetItem_Lcom_frostwire_jlibtorrent_Sha1Hash_;
		}

		static void n_DhtGetItem_Lcom_frostwire_jlibtorrent_Sha1Hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_target)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Sha1Hash target = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (native_target, JniHandleOwnership.DoNotTransfer);
			__this.DhtGetItem (target);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='dhtGetItem' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Sha1Hash']]"
		[Register ("dhtGetItem", "(Lcom/frostwire/jlibtorrent/Sha1Hash;)V", "GetDhtGetItem_Lcom_frostwire_jlibtorrent_Sha1Hash_Handler")]
		public virtual unsafe void DhtGetItem (global::FrostWire.Libtorrent.Sha1Hash target)
		{
			const string __id = "dhtGetItem.(Lcom/frostwire/jlibtorrent/Sha1Hash;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((target == null) ? IntPtr.Zero : ((global::Java.Lang.Object) target).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_dhtGetPeers_Lcom_frostwire_jlibtorrent_Sha1Hash_;
#pragma warning disable 0169
		static Delegate GetDhtGetPeers_Lcom_frostwire_jlibtorrent_Sha1Hash_Handler ()
		{
			if (cb_dhtGetPeers_Lcom_frostwire_jlibtorrent_Sha1Hash_ == null)
				cb_dhtGetPeers_Lcom_frostwire_jlibtorrent_Sha1Hash_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DhtGetPeers_Lcom_frostwire_jlibtorrent_Sha1Hash_);
			return cb_dhtGetPeers_Lcom_frostwire_jlibtorrent_Sha1Hash_;
		}

		static void n_DhtGetPeers_Lcom_frostwire_jlibtorrent_Sha1Hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_infoHash)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Sha1Hash infoHash = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (native_infoHash, JniHandleOwnership.DoNotTransfer);
			__this.DhtGetPeers (infoHash);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='dhtGetPeers' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Sha1Hash']]"
		[Register ("dhtGetPeers", "(Lcom/frostwire/jlibtorrent/Sha1Hash;)V", "GetDhtGetPeers_Lcom_frostwire_jlibtorrent_Sha1Hash_Handler")]
		public virtual unsafe void DhtGetPeers (global::FrostWire.Libtorrent.Sha1Hash infoHash)
		{
			const string __id = "dhtGetPeers.(Lcom/frostwire/jlibtorrent/Sha1Hash;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((infoHash == null) ? IntPtr.Zero : ((global::Java.Lang.Object) infoHash).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='dhtPutItem' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.frostwire.jlibtorrent.Entry'] and parameter[4][@type='byte[]']]"
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
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Entry entry = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Entry> (native_entry, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DhtPutItem (entry));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='dhtPutItem' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Entry']]"
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

		static Delegate cb_findTorrent_Lcom_frostwire_jlibtorrent_Sha1Hash_;
#pragma warning disable 0169
		static Delegate GetFindTorrent_Lcom_frostwire_jlibtorrent_Sha1Hash_Handler ()
		{
			if (cb_findTorrent_Lcom_frostwire_jlibtorrent_Sha1Hash_ == null)
				cb_findTorrent_Lcom_frostwire_jlibtorrent_Sha1Hash_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FindTorrent_Lcom_frostwire_jlibtorrent_Sha1Hash_);
			return cb_findTorrent_Lcom_frostwire_jlibtorrent_Sha1Hash_;
		}

		static IntPtr n_FindTorrent_Lcom_frostwire_jlibtorrent_Sha1Hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_infoHash)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Sha1Hash infoHash = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (native_infoHash, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindTorrent (infoHash));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='findTorrent' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Sha1Hash']]"
		[Register ("findTorrent", "(Lcom/frostwire/jlibtorrent/Sha1Hash;)Lcom/frostwire/jlibtorrent/TorrentHandle;", "GetFindTorrent_Lcom_frostwire_jlibtorrent_Sha1Hash_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.TorrentHandle FindTorrent (global::FrostWire.Libtorrent.Sha1Hash infoHash)
		{
			const string __id = "findTorrent.(Lcom/frostwire/jlibtorrent/Sha1Hash;)Lcom/frostwire/jlibtorrent/TorrentHandle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((infoHash == null) ? IntPtr.Zero : ((global::Java.Lang.Object) infoHash).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentHandle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.LoadState (data);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='loadState' and count(parameter)=1 and parameter[1][@type='byte[]']]"
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

		static Delegate cb_loadState_arrayBLcom_frostwire_jlibtorrent_swig_save_state_flags_t_;
#pragma warning disable 0169
		static Delegate GetLoadState_arrayBLcom_frostwire_jlibtorrent_swig_save_state_flags_t_Handler ()
		{
			if (cb_loadState_arrayBLcom_frostwire_jlibtorrent_swig_save_state_flags_t_ == null)
				cb_loadState_arrayBLcom_frostwire_jlibtorrent_swig_save_state_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadState_arrayBLcom_frostwire_jlibtorrent_swig_save_state_flags_t_);
			return cb_loadState_arrayBLcom_frostwire_jlibtorrent_swig_save_state_flags_t_;
		}

		static void n_LoadState_arrayBLcom_frostwire_jlibtorrent_swig_save_state_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native_flags)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::FrostWire.Libtorrent.Swig.Save_state_flags_t flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Save_state_flags_t> (native_flags, JniHandleOwnership.DoNotTransfer);
			__this.LoadState (data, flags);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='loadState' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.save_state_flags_t']]"
		[Register ("loadState", "([BLcom/frostwire/jlibtorrent/swig/save_state_flags_t;)V", "GetLoadState_arrayBLcom_frostwire_jlibtorrent_swig_save_state_flags_t_Handler")]
		public virtual unsafe void LoadState (byte[] data, global::FrostWire.Libtorrent.Swig.Save_state_flags_t flags)
		{
			const string __id = "loadState.([BLcom/frostwire/jlibtorrent/swig/save_state_flags_t;)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
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
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='pause' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostDhtStats ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='postDhtStats' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostSessionStats ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='postSessionStats' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostTorrentUpdates ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='postTorrentUpdates' and count(parameter)=0]"
		[Register ("postTorrentUpdates", "()V", "GetPostTorrentUpdatesHandler")]
		public virtual unsafe void PostTorrentUpdates ()
		{
			const string __id = "postTorrentUpdates.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_postTorrentUpdates_Lcom_frostwire_jlibtorrent_swig_status_flags_t_;
#pragma warning disable 0169
		static Delegate GetPostTorrentUpdates_Lcom_frostwire_jlibtorrent_swig_status_flags_t_Handler ()
		{
			if (cb_postTorrentUpdates_Lcom_frostwire_jlibtorrent_swig_status_flags_t_ == null)
				cb_postTorrentUpdates_Lcom_frostwire_jlibtorrent_swig_status_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PostTorrentUpdates_Lcom_frostwire_jlibtorrent_swig_status_flags_t_);
			return cb_postTorrentUpdates_Lcom_frostwire_jlibtorrent_swig_status_flags_t_;
		}

		static void n_PostTorrentUpdates_Lcom_frostwire_jlibtorrent_swig_status_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_flags)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Status_flags_t flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (native_flags, JniHandleOwnership.DoNotTransfer);
			__this.PostTorrentUpdates (flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='postTorrentUpdates' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.status_flags_t']]"
		[Register ("postTorrentUpdates", "(Lcom/frostwire/jlibtorrent/swig/status_flags_t;)V", "GetPostTorrentUpdates_Lcom_frostwire_jlibtorrent_swig_status_flags_t_Handler")]
		public virtual unsafe void PostTorrentUpdates (global::FrostWire.Libtorrent.Swig.Status_flags_t flags)
		{
			const string __id = "postTorrentUpdates.(Lcom/frostwire/jlibtorrent/swig/status_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeTorrent_Lcom_frostwire_jlibtorrent_TorrentHandle_;
#pragma warning disable 0169
		static Delegate GetRemoveTorrent_Lcom_frostwire_jlibtorrent_TorrentHandle_Handler ()
		{
			if (cb_removeTorrent_Lcom_frostwire_jlibtorrent_TorrentHandle_ == null)
				cb_removeTorrent_Lcom_frostwire_jlibtorrent_TorrentHandle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveTorrent_Lcom_frostwire_jlibtorrent_TorrentHandle_);
			return cb_removeTorrent_Lcom_frostwire_jlibtorrent_TorrentHandle_;
		}

		static void n_RemoveTorrent_Lcom_frostwire_jlibtorrent_TorrentHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_th)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.TorrentHandle th = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentHandle> (native_th, JniHandleOwnership.DoNotTransfer);
			__this.RemoveTorrent (th);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='removeTorrent' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.TorrentHandle']]"
		[Register ("removeTorrent", "(Lcom/frostwire/jlibtorrent/TorrentHandle;)V", "GetRemoveTorrent_Lcom_frostwire_jlibtorrent_TorrentHandle_Handler")]
		public virtual unsafe void RemoveTorrent (global::FrostWire.Libtorrent.TorrentHandle th)
		{
			const string __id = "removeTorrent.(Lcom/frostwire/jlibtorrent/TorrentHandle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((th == null) ? IntPtr.Zero : ((global::Java.Lang.Object) th).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeTorrent_Lcom_frostwire_jlibtorrent_TorrentHandle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_;
#pragma warning disable 0169
		static Delegate GetRemoveTorrent_Lcom_frostwire_jlibtorrent_TorrentHandle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_Handler ()
		{
			if (cb_removeTorrent_Lcom_frostwire_jlibtorrent_TorrentHandle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ == null)
				cb_removeTorrent_Lcom_frostwire_jlibtorrent_TorrentHandle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveTorrent_Lcom_frostwire_jlibtorrent_TorrentHandle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_);
			return cb_removeTorrent_Lcom_frostwire_jlibtorrent_TorrentHandle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_;
		}

		static void n_RemoveTorrent_Lcom_frostwire_jlibtorrent_TorrentHandle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_th, IntPtr native_options)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.TorrentHandle th = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentHandle> (native_th, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Remove_flags_t options = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Remove_flags_t> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.RemoveTorrent (th, options);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='removeTorrent' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.TorrentHandle'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.remove_flags_t']]"
		[Register ("removeTorrent", "(Lcom/frostwire/jlibtorrent/TorrentHandle;Lcom/frostwire/jlibtorrent/swig/remove_flags_t;)V", "GetRemoveTorrent_Lcom_frostwire_jlibtorrent_TorrentHandle_Lcom_frostwire_jlibtorrent_swig_remove_flags_t_Handler")]
		public virtual unsafe void RemoveTorrent (global::FrostWire.Libtorrent.TorrentHandle th, global::FrostWire.Libtorrent.Swig.Remove_flags_t options)
		{
			const string __id = "removeTorrent.(Lcom/frostwire/jlibtorrent/TorrentHandle;Lcom/frostwire/jlibtorrent/swig/remove_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((th == null) ? IntPtr.Zero : ((global::Java.Lang.Object) th).Handle);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
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
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReopenNetworkSockets ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='reopenNetworkSockets' and count(parameter)=0]"
		[Register ("reopenNetworkSockets", "()V", "GetReopenNetworkSocketsHandler")]
		public virtual unsafe void ReopenNetworkSockets ()
		{
			const string __id = "reopenNetworkSockets.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_reopenNetworkSockets_Lcom_frostwire_jlibtorrent_swig_reopen_network_flags_t_;
#pragma warning disable 0169
		static Delegate GetReopenNetworkSockets_Lcom_frostwire_jlibtorrent_swig_reopen_network_flags_t_Handler ()
		{
			if (cb_reopenNetworkSockets_Lcom_frostwire_jlibtorrent_swig_reopen_network_flags_t_ == null)
				cb_reopenNetworkSockets_Lcom_frostwire_jlibtorrent_swig_reopen_network_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReopenNetworkSockets_Lcom_frostwire_jlibtorrent_swig_reopen_network_flags_t_);
			return cb_reopenNetworkSockets_Lcom_frostwire_jlibtorrent_swig_reopen_network_flags_t_;
		}

		static void n_ReopenNetworkSockets_Lcom_frostwire_jlibtorrent_swig_reopen_network_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Reopen_network_flags_t options = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Reopen_network_flags_t> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.ReopenNetworkSockets (options);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='reopenNetworkSockets' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.reopen_network_flags_t']]"
		[Register ("reopenNetworkSockets", "(Lcom/frostwire/jlibtorrent/swig/reopen_network_flags_t;)V", "GetReopenNetworkSockets_Lcom_frostwire_jlibtorrent_swig_reopen_network_flags_t_Handler")]
		public virtual unsafe void ReopenNetworkSockets (global::FrostWire.Libtorrent.Swig.Reopen_network_flags_t options)
		{
			const string __id = "reopenNetworkSockets.(Lcom/frostwire/jlibtorrent/swig/reopen_network_flags_t;)V";
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
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='resume' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.SaveState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='saveState' and count(parameter)=0]"
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

		static Delegate cb_saveState_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_;
#pragma warning disable 0169
		static Delegate GetSaveState_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_Handler ()
		{
			if (cb_saveState_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_ == null)
				cb_saveState_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveState_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_);
			return cb_saveState_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_;
		}

		static IntPtr n_SaveState_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_flags)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Save_state_flags_t flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Save_state_flags_t> (native_flags, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.SaveState (flags));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='saveState' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.save_state_flags_t']]"
		[Register ("saveState", "(Lcom/frostwire/jlibtorrent/swig/save_state_flags_t;)[B", "GetSaveState_Lcom_frostwire_jlibtorrent_swig_save_state_flags_t_Handler")]
		public virtual unsafe byte[] SaveState (global::FrostWire.Libtorrent.Swig.Save_state_flags_t flags)
		{
			const string __id = "saveState.(Lcom/frostwire/jlibtorrent/swig/save_state_flags_t;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
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
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Settings ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='settings' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Swig ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/session_handle;", "GetSwigHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Session_handle Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/session_handle;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_handle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_torrents;
#pragma warning disable 0169
		static Delegate GetTorrentsHandler ()
		{
			if (cb_torrents == null)
				cb_torrents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Torrents);
			return cb_torrents;
		}

		static IntPtr n_Torrents (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.SessionHandle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SessionHandle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.TorrentHandle>.ToLocalJniHandle (__this.Torrents ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionHandle']/method[@name='torrents' and count(parameter)=0]"
		[Register ("torrents", "()Ljava/util/List;", "GetTorrentsHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.TorrentHandle> Torrents ()
		{
			const string __id = "torrents.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.TorrentHandle>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
