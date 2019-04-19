using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/peer_class_type_filter", DoNotGenerateAcw=true)]
	public partial class Peer_class_type_filter : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter']/field[@name='swigCMemOwn']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter.socket_type_t']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t", DoNotGenerateAcw=true)]
		public sealed partial class Socket_type_t : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter.socket_type_t']/field[@name='i2p_socket']"
			[Register ("i2p_socket")]
			public static global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t I2pSocket {
				get {
					const string __id = "i2p_socket.Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter.socket_type_t']/field[@name='num_socket_types']"
			[Register ("num_socket_types")]
			public static global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t NumSocketTypes {
				get {
					const string __id = "num_socket_types.Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter.socket_type_t']/field[@name='ssl_tcp_socket']"
			[Register ("ssl_tcp_socket")]
			public static global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t SslTcpSocket {
				get {
					const string __id = "ssl_tcp_socket.Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter.socket_type_t']/field[@name='ssl_utp_socket']"
			[Register ("ssl_utp_socket")]
			public static global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t SslUtpSocket {
				get {
					const string __id = "ssl_utp_socket.Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter.socket_type_t']/field[@name='tcp_socket']"
			[Register ("tcp_socket")]
			public static global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t TcpSocket {
				get {
					const string __id = "tcp_socket.Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter.socket_type_t']/field[@name='utp_socket']"
			[Register ("utp_socket")]
			public static global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t UtpSocket {
				get {
					const string __id = "utp_socket.Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t", typeof (Socket_type_t));
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

			internal Socket_type_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter.socket_type_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter.socket_type_t']/method[@name='swigValue' and count(parameter)=0]"
			[Register ("swigValue", "()I", "")]
			public unsafe int SwigValue ()
			{
				const string __id = "swigValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/peer_class_type_filter", typeof (Peer_class_type_filter));
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

		protected Peer_class_type_filter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter']/constructor[@name='peer_class_type_filter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Peer_class_type_filter ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter']/constructor[@name='peer_class_type_filter' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Peer_class_type_filter (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_add_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_IHandler ()
		{
			if (cb_add_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I == null)
				cb_add_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Add_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I);
			return cb_add_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I;
		}

		static void n_Add_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I (IntPtr jnienv, IntPtr native__this, IntPtr native_st, int peer_class)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_type_filter __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t st = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t> (native_st, JniHandleOwnership.DoNotTransfer);
			__this.Add (st, peer_class);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter']/method[@name='add' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_class_type_filter.socket_type_t'] and parameter[2][@type='int']]"
		[Register ("add", "(Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t;I)V", "GetAdd_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_IHandler")]
		public virtual unsafe void Add (global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t st, int peer_class)
		{
			const string __id = "add.(Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((st == null) ? IntPtr.Zero : ((global::Java.Lang.Object) st).Handle);
				__args [1] = new JniArgumentValue (peer_class);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_allow_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I;
#pragma warning disable 0169
		static Delegate GetAllow_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_IHandler ()
		{
			if (cb_allow_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I == null)
				cb_allow_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Allow_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I);
			return cb_allow_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I;
		}

		static void n_Allow_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I (IntPtr jnienv, IntPtr native__this, IntPtr native_st, int peer_class)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_type_filter __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t st = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t> (native_st, JniHandleOwnership.DoNotTransfer);
			__this.Allow (st, peer_class);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter']/method[@name='allow' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_class_type_filter.socket_type_t'] and parameter[2][@type='int']]"
		[Register ("allow", "(Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t;I)V", "GetAllow_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_IHandler")]
		public virtual unsafe void Allow (global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t st, int peer_class)
		{
			const string __id = "allow.(Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((st == null) ? IntPtr.Zero : ((global::Java.Lang.Object) st).Handle);
				__args [1] = new JniArgumentValue (peer_class);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_apply_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_J;
#pragma warning disable 0169
		static Delegate GetApply_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_JHandler ()
		{
			if (cb_apply_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_J == null)
				cb_apply_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long>) n_Apply_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_J);
			return cb_apply_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_J;
		}

		static long n_Apply_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_J (IntPtr jnienv, IntPtr native__this, IntPtr native_st, long peer_class_mask)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_type_filter __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t st = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t> (native_st, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Apply (st, peer_class_mask);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter']/method[@name='apply' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_class_type_filter.socket_type_t'] and parameter[2][@type='long']]"
		[Register ("apply", "(Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t;J)J", "GetApply_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_JHandler")]
		public virtual unsafe long Apply (global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t st, long peer_class_mask)
		{
			const string __id = "apply.(Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t;J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((st == null) ? IntPtr.Zero : ((global::Java.Lang.Object) st).Handle);
				__args [1] = new JniArgumentValue (peer_class_mask);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
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
			global::FrostWire.Libtorrent.Swig.Peer_class_type_filter __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_disallow_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I;
#pragma warning disable 0169
		static Delegate GetDisallow_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_IHandler ()
		{
			if (cb_disallow_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I == null)
				cb_disallow_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Disallow_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I);
			return cb_disallow_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I;
		}

		static void n_Disallow_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I (IntPtr jnienv, IntPtr native__this, IntPtr native_st, int peer_class)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_type_filter __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t st = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t> (native_st, JniHandleOwnership.DoNotTransfer);
			__this.Disallow (st, peer_class);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter']/method[@name='disallow' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_class_type_filter.socket_type_t'] and parameter[2][@type='int']]"
		[Register ("disallow", "(Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t;I)V", "GetDisallow_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_IHandler")]
		public virtual unsafe void Disallow (global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t st, int peer_class)
		{
			const string __id = "disallow.(Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((st == null) ? IntPtr.Zero : ((global::Java.Lang.Object) st).Handle);
				__args [1] = new JniArgumentValue (peer_class);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_class_type_filter']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Peer_class_type_filter obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_remove_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I;
#pragma warning disable 0169
		static Delegate GetRemove_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_IHandler ()
		{
			if (cb_remove_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I == null)
				cb_remove_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Remove_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I);
			return cb_remove_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I;
		}

		static void n_Remove_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_I (IntPtr jnienv, IntPtr native__this, IntPtr native_st, int peer_class)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_type_filter __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t st = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t> (native_st, JniHandleOwnership.DoNotTransfer);
			__this.Remove (st, peer_class);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_type_filter']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_class_type_filter.socket_type_t'] and parameter[2][@type='int']]"
		[Register ("remove", "(Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t;I)V", "GetRemove_Lcom_frostwire_jlibtorrent_swig_peer_class_type_filter_socket_type_t_IHandler")]
		public virtual unsafe void Remove (global::FrostWire.Libtorrent.Swig.Peer_class_type_filter.Socket_type_t st, int peer_class)
		{
			const string __id = "remove.(Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((st == null) ? IntPtr.Zero : ((global::Java.Lang.Object) st).Handle);
				__args [1] = new JniArgumentValue (peer_class);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
