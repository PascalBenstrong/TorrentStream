using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtGetPeersReplyAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/DhtGetPeersReplyAlert", DoNotGenerateAcw=true)]
	public sealed partial class DhtGetPeersReplyAlert : global::FrostWire.Libtorrent.Alerts.AbstractAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/DhtGetPeersReplyAlert", typeof (DhtGetPeersReplyAlert));
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

		internal DhtGetPeersReplyAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtGetPeersReplyAlert']/method[@name='infoHash' and count(parameter)=0]"
		[Register ("infoHash", "()Lcom/frostwire/jlibtorrent/Sha1Hash;", "")]
		public unsafe global::FrostWire.Libtorrent.Sha1Hash InfoHash ()
		{
			const string __id = "infoHash.()Lcom/frostwire/jlibtorrent/Sha1Hash;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtGetPeersReplyAlert']/method[@name='numPeers' and count(parameter)=0]"
		[Register ("numPeers", "()I", "")]
		public unsafe int NumPeers ()
		{
			const string __id = "numPeers.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtGetPeersReplyAlert']/method[@name='peers' and count(parameter)=0]"
		[Register ("peers", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.TcpEndpoint> Peers ()
		{
			const string __id = "peers.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.TcpEndpoint>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
