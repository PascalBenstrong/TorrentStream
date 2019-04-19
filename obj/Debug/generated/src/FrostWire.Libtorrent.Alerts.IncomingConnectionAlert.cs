using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/IncomingConnectionAlert", DoNotGenerateAcw=true)]
	public sealed partial class IncomingConnectionAlert : global::FrostWire.Libtorrent.Alerts.AbstractAlert {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert.SocketType']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType", DoNotGenerateAcw=true)]
		public sealed partial class SocketType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert.SocketType']/field[@name='HTTP']"
			[Register ("HTTP")]
			public static global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType Http {
				get {
					const string __id = "HTTP.Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert.SocketType']/field[@name='HTTPS']"
			[Register ("HTTPS")]
			public static global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType Https {
				get {
					const string __id = "HTTPS.Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert.SocketType']/field[@name='I2P']"
			[Register ("I2P")]
			public static global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType I2p {
				get {
					const string __id = "I2P.Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert.SocketType']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType None {
				get {
					const string __id = "NONE.Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert.SocketType']/field[@name='SOCKS5']"
			[Register ("SOCKS5")]
			public static global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType Socks5 {
				get {
					const string __id = "SOCKS5.Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert.SocketType']/field[@name='SSL_SOCKS5']"
			[Register ("SSL_SOCKS5")]
			public static global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType SslSocks5 {
				get {
					const string __id = "SSL_SOCKS5.Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert.SocketType']/field[@name='SSL_TCP']"
			[Register ("SSL_TCP")]
			public static global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType SslTcp {
				get {
					const string __id = "SSL_TCP.Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert.SocketType']/field[@name='SSL_UTP']"
			[Register ("SSL_UTP")]
			public static global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType SslUtp {
				get {
					const string __id = "SSL_UTP.Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert.SocketType']/field[@name='TCP']"
			[Register ("TCP")]
			public static global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType Tcp {
				get {
					const string __id = "TCP.Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert.SocketType']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert.SocketType']/field[@name='UTP']"
			[Register ("UTP")]
			public static global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType Utp {
				get {
					const string __id = "UTP.Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType", typeof (SocketType));
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert.SocketType']/method[@name='fromSwig' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromSwig", "(I)Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType FromSwig (int swigValue)
			{
				const string __id = "fromSwig.(I)Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert.SocketType']/method[@name='swig' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert.SocketType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert.SocketType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType[] Values ()
			{
				const string __id = "values.()[Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/IncomingConnectionAlert", typeof (IncomingConnectionAlert));
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

		internal IncomingConnectionAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert']/method[@name='endpoint' and count(parameter)=0]"
		[Register ("endpoint", "()Lcom/frostwire/jlibtorrent/TcpEndpoint;", "")]
		public unsafe global::FrostWire.Libtorrent.TcpEndpoint Endpoint ()
		{
			const string __id = "endpoint.()Lcom/frostwire/jlibtorrent/TcpEndpoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TcpEndpoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='IncomingConnectionAlert']/method[@name='socketType' and count(parameter)=0]"
		[Register ("socketType", "()Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;", "")]
		public unsafe global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType InvokeSocketType ()
		{
			const string __id = "socketType.()Lcom/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IncomingConnectionAlert.SocketType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
