using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerBlockedAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/PeerBlockedAlert", DoNotGenerateAcw=true)]
	public sealed partial class PeerBlockedAlert : global::FrostWire.Libtorrent.Alerts.TorrentAlert {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerBlockedAlert.Reason']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason", DoNotGenerateAcw=true)]
		public sealed partial class Reason : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerBlockedAlert.Reason']/field[@name='I2P_MIXED']"
			[Register ("I2P_MIXED")]
			public static global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason I2pMixed {
				get {
					const string __id = "I2P_MIXED.Lcom/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerBlockedAlert.Reason']/field[@name='INVALID_LOCAL_INTERFACE']"
			[Register ("INVALID_LOCAL_INTERFACE")]
			public static global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason InvalidLocalInterface {
				get {
					const string __id = "INVALID_LOCAL_INTERFACE.Lcom/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerBlockedAlert.Reason']/field[@name='IP_FILTER']"
			[Register ("IP_FILTER")]
			public static global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason IpFilter {
				get {
					const string __id = "IP_FILTER.Lcom/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerBlockedAlert.Reason']/field[@name='PORT_FILTER']"
			[Register ("PORT_FILTER")]
			public static global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason PortFilter {
				get {
					const string __id = "PORT_FILTER.Lcom/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerBlockedAlert.Reason']/field[@name='PRIVILEGED_PORTS']"
			[Register ("PRIVILEGED_PORTS")]
			public static global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason PrivilegedPorts {
				get {
					const string __id = "PRIVILEGED_PORTS.Lcom/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerBlockedAlert.Reason']/field[@name='TCP_DISABLED']"
			[Register ("TCP_DISABLED")]
			public static global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason TcpDisabled {
				get {
					const string __id = "TCP_DISABLED.Lcom/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerBlockedAlert.Reason']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerBlockedAlert.Reason']/field[@name='UTP_DISABLED']"
			[Register ("UTP_DISABLED")]
			public static global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason UtpDisabled {
				get {
					const string __id = "UTP_DISABLED.Lcom/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason", typeof (Reason));
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

			internal Reason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerBlockedAlert.Reason']/method[@name='fromSwig' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromSwig", "(I)Lcom/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason FromSwig (int swigValue)
			{
				const string __id = "fromSwig.(I)Lcom/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerBlockedAlert.Reason']/method[@name='swig' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerBlockedAlert.Reason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerBlockedAlert.Reason']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason[] Values ()
			{
				const string __id = "values.()[Lcom/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/PeerBlockedAlert", typeof (PeerBlockedAlert));
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

		internal PeerBlockedAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerBlockedAlert']/method[@name='reason' and count(parameter)=0]"
		[Register ("reason", "()Lcom/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason;", "")]
		public unsafe global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason InvokeReason ()
		{
			const string __id = "reason.()Lcom/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerBlockedAlert.Reason> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
