using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtLogAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/DhtLogAlert", DoNotGenerateAcw=true)]
	public sealed partial class DhtLogAlert : global::FrostWire.Libtorrent.Alerts.AbstractAlert {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtLogAlert.DhtModule']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/DhtLogAlert$DhtModule", DoNotGenerateAcw=true)]
		public sealed partial class DhtModule : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtLogAlert.DhtModule']/field[@name='NODE']"
			[Register ("NODE")]
			public static global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule Node {
				get {
					const string __id = "NODE.Lcom/frostwire/jlibtorrent/alerts/DhtLogAlert$DhtModule;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtLogAlert.DhtModule']/field[@name='ROUTING_TABLE']"
			[Register ("ROUTING_TABLE")]
			public static global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule RoutingTable {
				get {
					const string __id = "ROUTING_TABLE.Lcom/frostwire/jlibtorrent/alerts/DhtLogAlert$DhtModule;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtLogAlert.DhtModule']/field[@name='RPC_MANAGER']"
			[Register ("RPC_MANAGER")]
			public static global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule RpcManager {
				get {
					const string __id = "RPC_MANAGER.Lcom/frostwire/jlibtorrent/alerts/DhtLogAlert$DhtModule;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtLogAlert.DhtModule']/field[@name='TRACKER']"
			[Register ("TRACKER")]
			public static global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule Tracker {
				get {
					const string __id = "TRACKER.Lcom/frostwire/jlibtorrent/alerts/DhtLogAlert$DhtModule;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtLogAlert.DhtModule']/field[@name='TRAVERSAL']"
			[Register ("TRAVERSAL")]
			public static global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule Traversal {
				get {
					const string __id = "TRAVERSAL.Lcom/frostwire/jlibtorrent/alerts/DhtLogAlert$DhtModule;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtLogAlert.DhtModule']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/frostwire/jlibtorrent/alerts/DhtLogAlert$DhtModule;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/DhtLogAlert$DhtModule", typeof (DhtModule));
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

			internal DhtModule (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtLogAlert.DhtModule']/method[@name='fromSwig' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromSwig", "(I)Lcom/frostwire/jlibtorrent/alerts/DhtLogAlert$DhtModule;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule FromSwig (int swigValue)
			{
				const string __id = "fromSwig.(I)Lcom/frostwire/jlibtorrent/alerts/DhtLogAlert$DhtModule;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtLogAlert.DhtModule']/method[@name='swig' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtLogAlert.DhtModule']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/DhtLogAlert$DhtModule;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/DhtLogAlert$DhtModule;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtLogAlert.DhtModule']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/frostwire/jlibtorrent/alerts/DhtLogAlert$DhtModule;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule[] Values ()
			{
				const string __id = "values.()[Lcom/frostwire/jlibtorrent/alerts/DhtLogAlert$DhtModule;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/DhtLogAlert", typeof (DhtLogAlert));
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

		internal DhtLogAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtLogAlert']/method[@name='logMessage' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtLogAlert']/method[@name='module' and count(parameter)=0]"
		[Register ("module", "()Lcom/frostwire/jlibtorrent/alerts/DhtLogAlert$DhtModule;", "")]
		public unsafe global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule Module ()
		{
			const string __id = "module.()Lcom/frostwire/jlibtorrent/alerts/DhtLogAlert$DhtModule;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.DhtLogAlert.DhtModule> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
