using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtDirectResponseAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/DhtDirectResponseAlert", DoNotGenerateAcw=true)]
	public sealed partial class DhtDirectResponseAlert : global::FrostWire.Libtorrent.Alerts.AbstractAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/DhtDirectResponseAlert", typeof (DhtDirectResponseAlert));
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

		internal DhtDirectResponseAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtDirectResponseAlert']/method[@name='endpoint' and count(parameter)=0]"
		[Register ("endpoint", "()Lcom/frostwire/jlibtorrent/UdpEndpoint;", "")]
		public unsafe global::FrostWire.Libtorrent.UdpEndpoint Endpoint ()
		{
			const string __id = "endpoint.()Lcom/frostwire/jlibtorrent/UdpEndpoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.UdpEndpoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtDirectResponseAlert']/method[@name='response' and count(parameter)=0]"
		[Register ("response", "()Lcom/frostwire/jlibtorrent/BDecodeNode;", "")]
		public unsafe global::FrostWire.Libtorrent.BDecodeNode Response ()
		{
			const string __id = "response.()Lcom/frostwire/jlibtorrent/BDecodeNode;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.BDecodeNode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtDirectResponseAlert']/method[@name='userdata' and count(parameter)=0]"
		[Register ("userdata", "()J", "")]
		public unsafe long Userdata ()
		{
			const string __id = "userdata.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
