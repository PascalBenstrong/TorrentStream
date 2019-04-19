using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerLogAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/PeerLogAlert", DoNotGenerateAcw=true)]
	public sealed partial class PeerLogAlert : global::FrostWire.Libtorrent.Alerts.PeerAlert {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerLogAlert.Direction']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/PeerLogAlert$Direction", DoNotGenerateAcw=true)]
		public sealed partial class Direction : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerLogAlert.Direction']/field[@name='INCOMING']"
			[Register ("INCOMING")]
			public static global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction Incoming {
				get {
					const string __id = "INCOMING.Lcom/frostwire/jlibtorrent/alerts/PeerLogAlert$Direction;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerLogAlert.Direction']/field[@name='INCOMING_MESSAGE']"
			[Register ("INCOMING_MESSAGE")]
			public static global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction IncomingMessage {
				get {
					const string __id = "INCOMING_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/PeerLogAlert$Direction;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerLogAlert.Direction']/field[@name='INFO']"
			[Register ("INFO")]
			public static global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction Info {
				get {
					const string __id = "INFO.Lcom/frostwire/jlibtorrent/alerts/PeerLogAlert$Direction;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerLogAlert.Direction']/field[@name='OUTGOING']"
			[Register ("OUTGOING")]
			public static global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction Outgoing {
				get {
					const string __id = "OUTGOING.Lcom/frostwire/jlibtorrent/alerts/PeerLogAlert$Direction;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerLogAlert.Direction']/field[@name='OUTGOING_MESSAGE']"
			[Register ("OUTGOING_MESSAGE")]
			public static global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction OutgoingMessage {
				get {
					const string __id = "OUTGOING_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/PeerLogAlert$Direction;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerLogAlert.Direction']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/frostwire/jlibtorrent/alerts/PeerLogAlert$Direction;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/PeerLogAlert$Direction", typeof (Direction));
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerLogAlert.Direction']/method[@name='fromSwig' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromSwig", "(I)Lcom/frostwire/jlibtorrent/alerts/PeerLogAlert$Direction;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction FromSwig (int swigValue)
			{
				const string __id = "fromSwig.(I)Lcom/frostwire/jlibtorrent/alerts/PeerLogAlert$Direction;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerLogAlert.Direction']/method[@name='swig' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerLogAlert.Direction']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/PeerLogAlert$Direction;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/PeerLogAlert$Direction;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerLogAlert.Direction']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/frostwire/jlibtorrent/alerts/PeerLogAlert$Direction;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction[] Values ()
			{
				const string __id = "values.()[Lcom/frostwire/jlibtorrent/alerts/PeerLogAlert$Direction;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/PeerLogAlert", typeof (PeerLogAlert));
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

		internal PeerLogAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerLogAlert']/method[@name='direction' and count(parameter)=0]"
		[Register ("direction", "()Lcom/frostwire/jlibtorrent/alerts/PeerLogAlert$Direction;", "")]
		public unsafe global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction InvokeDirection ()
		{
			const string __id = "direction.()Lcom/frostwire/jlibtorrent/alerts/PeerLogAlert$Direction;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PeerLogAlert.Direction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerLogAlert']/method[@name='eventType' and count(parameter)=0]"
		[Register ("eventType", "()Ljava/lang/String;", "")]
		public unsafe string EventType ()
		{
			const string __id = "eventType.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerLogAlert']/method[@name='logMessage' and count(parameter)=0]"
		[Register ("logMessage", "()Ljava/lang/String;", "")]
		public unsafe string LogMessage ()
		{
			const string __id = "logMessage.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
