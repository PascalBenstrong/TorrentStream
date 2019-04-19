using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtPktAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/DhtPktAlert", DoNotGenerateAcw=true)]
	public sealed partial class DhtPktAlert : global::FrostWire.Libtorrent.Alerts.AbstractAlert {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtPktAlert.Direction']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/DhtPktAlert$Direction", DoNotGenerateAcw=true)]
		public sealed partial class Direction : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtPktAlert.Direction']/field[@name='INCOMING']"
			[Register ("INCOMING")]
			public static global::FrostWire.Libtorrent.Alerts.DhtPktAlert.Direction Incoming {
				get {
					const string __id = "INCOMING.Lcom/frostwire/jlibtorrent/alerts/DhtPktAlert$Direction;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.DhtPktAlert.Direction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtPktAlert.Direction']/field[@name='OUTGOING']"
			[Register ("OUTGOING")]
			public static global::FrostWire.Libtorrent.Alerts.DhtPktAlert.Direction Outgoing {
				get {
					const string __id = "OUTGOING.Lcom/frostwire/jlibtorrent/alerts/DhtPktAlert$Direction;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.DhtPktAlert.Direction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtPktAlert.Direction']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::FrostWire.Libtorrent.Alerts.DhtPktAlert.Direction Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/frostwire/jlibtorrent/alerts/DhtPktAlert$Direction;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.DhtPktAlert.Direction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/DhtPktAlert$Direction", typeof (Direction));
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

			internal Direction (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtPktAlert.Direction']/method[@name='fromSwig' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromSwig", "(I)Lcom/frostwire/jlibtorrent/alerts/DhtPktAlert$Direction;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.DhtPktAlert.Direction FromSwig (int swigValue)
			{
				const string __id = "fromSwig.(I)Lcom/frostwire/jlibtorrent/alerts/DhtPktAlert$Direction;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.DhtPktAlert.Direction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtPktAlert.Direction']/method[@name='swig' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtPktAlert.Direction']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/DhtPktAlert$Direction;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.DhtPktAlert.Direction ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/DhtPktAlert$Direction;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.DhtPktAlert.Direction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtPktAlert.Direction']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/frostwire/jlibtorrent/alerts/DhtPktAlert$Direction;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.DhtPktAlert.Direction[] Values ()
			{
				const string __id = "values.()[Lcom/frostwire/jlibtorrent/alerts/DhtPktAlert$Direction;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::FrostWire.Libtorrent.Alerts.DhtPktAlert.Direction[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.Alerts.DhtPktAlert.Direction));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/DhtPktAlert", typeof (DhtPktAlert));
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

		internal DhtPktAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtPktAlert']/method[@name='direction' and count(parameter)=0]"
		[Register ("direction", "()Lcom/frostwire/jlibtorrent/alerts/DhtPktAlert$Direction;", "")]
		public unsafe global::FrostWire.Libtorrent.Alerts.DhtPktAlert.Direction InvokeDirection ()
		{
			const string __id = "direction.()Lcom/frostwire/jlibtorrent/alerts/DhtPktAlert$Direction;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.DhtPktAlert.Direction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtPktAlert']/method[@name='node' and count(parameter)=0]"
		[Register ("node", "()Lcom/frostwire/jlibtorrent/UdpEndpoint;", "")]
		public unsafe global::FrostWire.Libtorrent.UdpEndpoint Node ()
		{
			const string __id = "node.()Lcom/frostwire/jlibtorrent/UdpEndpoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.UdpEndpoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtPktAlert']/method[@name='pktBuf' and count(parameter)=0]"
		[Register ("pktBuf", "()[B", "")]
		public unsafe byte[] PktBuf ()
		{
			const string __id = "pktBuf.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
