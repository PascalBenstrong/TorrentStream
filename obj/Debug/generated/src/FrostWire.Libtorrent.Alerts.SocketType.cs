using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='SocketType']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/SocketType", DoNotGenerateAcw=true)]
	public sealed partial class SocketType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='SocketType']/field[@name='I2P']"
		[Register ("I2P")]
		public static global::FrostWire.Libtorrent.Alerts.SocketType I2p {
			get {
				const string __id = "I2P.Lcom/frostwire/jlibtorrent/alerts/SocketType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.SocketType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='SocketType']/field[@name='SOCKS5']"
		[Register ("SOCKS5")]
		public static global::FrostWire.Libtorrent.Alerts.SocketType Socks5 {
			get {
				const string __id = "SOCKS5.Lcom/frostwire/jlibtorrent/alerts/SocketType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.SocketType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='SocketType']/field[@name='TCP']"
		[Register ("TCP")]
		public static global::FrostWire.Libtorrent.Alerts.SocketType Tcp {
			get {
				const string __id = "TCP.Lcom/frostwire/jlibtorrent/alerts/SocketType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.SocketType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='SocketType']/field[@name='TCP_SSL']"
		[Register ("TCP_SSL")]
		public static global::FrostWire.Libtorrent.Alerts.SocketType TcpSsl {
			get {
				const string __id = "TCP_SSL.Lcom/frostwire/jlibtorrent/alerts/SocketType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.SocketType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='SocketType']/field[@name='UDP']"
		[Register ("UDP")]
		public static global::FrostWire.Libtorrent.Alerts.SocketType Udp {
			get {
				const string __id = "UDP.Lcom/frostwire/jlibtorrent/alerts/SocketType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.SocketType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='SocketType']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::FrostWire.Libtorrent.Alerts.SocketType Unknown {
			get {
				const string __id = "UNKNOWN.Lcom/frostwire/jlibtorrent/alerts/SocketType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.SocketType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='SocketType']/field[@name='UTP_SSL']"
		[Register ("UTP_SSL")]
		public static global::FrostWire.Libtorrent.Alerts.SocketType UtpSsl {
			get {
				const string __id = "UTP_SSL.Lcom/frostwire/jlibtorrent/alerts/SocketType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.SocketType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/SocketType", typeof (SocketType));
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

		internal SocketType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='SocketType']/method[@name='fromSwig' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromSwig", "(I)Lcom/frostwire/jlibtorrent/alerts/SocketType;", "")]
		public static unsafe global::FrostWire.Libtorrent.Alerts.SocketType FromSwig (int swigValue)
		{
			const string __id = "fromSwig.(I)Lcom/frostwire/jlibtorrent/alerts/SocketType;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (swigValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.SocketType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='SocketType']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()I", "")]
		public unsafe int Swig ()
		{
			const string __id = "swig.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='SocketType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/SocketType;", "")]
		public static unsafe global::FrostWire.Libtorrent.Alerts.SocketType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/SocketType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.SocketType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='SocketType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/frostwire/jlibtorrent/alerts/SocketType;", "")]
		public static unsafe global::FrostWire.Libtorrent.Alerts.SocketType[] Values ()
		{
			const string __id = "values.()[Lcom/frostwire/jlibtorrent/alerts/SocketType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::FrostWire.Libtorrent.Alerts.SocketType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.Alerts.SocketType));
			} finally {
			}
		}

	}
}
