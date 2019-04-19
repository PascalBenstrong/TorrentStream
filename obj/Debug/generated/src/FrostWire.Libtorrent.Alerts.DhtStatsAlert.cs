using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtStatsAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/DhtStatsAlert", DoNotGenerateAcw=true)]
	public sealed partial class DhtStatsAlert : global::FrostWire.Libtorrent.Alerts.AbstractAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/DhtStatsAlert", typeof (DhtStatsAlert));
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

		internal DhtStatsAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtStatsAlert']/method[@name='activeRequests' and count(parameter)=0]"
		[Register ("activeRequests", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.DhtLookup> ActiveRequests ()
		{
			const string __id = "activeRequests.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.DhtLookup>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtStatsAlert']/method[@name='routingTable' and count(parameter)=0]"
		[Register ("routingTable", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.DhtRoutingBucket> RoutingTable ()
		{
			const string __id = "routingTable.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.DhtRoutingBucket>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
