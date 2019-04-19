using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='socket_type_t']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/socket_type_t", DoNotGenerateAcw=true)]
	public sealed partial class Socket_type_t : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='socket_type_t']/field[@name='i2p']"
		[Register ("i2p")]
		public static global::FrostWire.Libtorrent.Swig.Socket_type_t I2p {
			get {
				const string __id = "i2p.Lcom/frostwire/jlibtorrent/swig/socket_type_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Socket_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='socket_type_t']/field[@name='socks5']"
		[Register ("socks5")]
		public static global::FrostWire.Libtorrent.Swig.Socket_type_t Socks5 {
			get {
				const string __id = "socks5.Lcom/frostwire/jlibtorrent/swig/socket_type_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Socket_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='socket_type_t']/field[@name='tcp']"
		[Register ("tcp")]
		public static global::FrostWire.Libtorrent.Swig.Socket_type_t Tcp {
			get {
				const string __id = "tcp.Lcom/frostwire/jlibtorrent/swig/socket_type_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Socket_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='socket_type_t']/field[@name='tcp_ssl']"
		[Register ("tcp_ssl")]
		public static global::FrostWire.Libtorrent.Swig.Socket_type_t TcpSsl {
			get {
				const string __id = "tcp_ssl.Lcom/frostwire/jlibtorrent/swig/socket_type_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Socket_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='socket_type_t']/field[@name='udp']"
		[Register ("udp")]
		public static global::FrostWire.Libtorrent.Swig.Socket_type_t Udp {
			get {
				const string __id = "udp.Lcom/frostwire/jlibtorrent/swig/socket_type_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Socket_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='socket_type_t']/field[@name='utp_ssl']"
		[Register ("utp_ssl")]
		public static global::FrostWire.Libtorrent.Swig.Socket_type_t UtpSsl {
			get {
				const string __id = "utp_ssl.Lcom/frostwire/jlibtorrent/swig/socket_type_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Socket_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/socket_type_t", typeof (Socket_type_t));
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='socket_type_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/socket_type_t;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Socket_type_t SwigToEnum (int swigValue)
		{
			const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/socket_type_t;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (swigValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Socket_type_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='socket_type_t']/method[@name='swigValue' and count(parameter)=0]"
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
}
