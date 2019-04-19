using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PortmapLogAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/PortmapLogAlert", DoNotGenerateAcw=true)]
	public sealed partial class PortmapLogAlert : global::FrostWire.Libtorrent.Alerts.AbstractAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/PortmapLogAlert", typeof (PortmapLogAlert));
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

		internal PortmapLogAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PortmapLogAlert']/method[@name='logMessage' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PortmapLogAlert']/method[@name='mapType' and count(parameter)=0]"
		[Register ("mapType", "()Lcom/frostwire/jlibtorrent/PortmapTransport;", "")]
		public unsafe global::FrostWire.Libtorrent.PortmapTransport MapType ()
		{
			const string __id = "mapType.()Lcom/frostwire/jlibtorrent/PortmapTransport;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PortmapTransport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
