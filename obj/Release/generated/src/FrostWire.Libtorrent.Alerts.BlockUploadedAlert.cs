using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='BlockUploadedAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/BlockUploadedAlert", DoNotGenerateAcw=true)]
	public sealed partial class BlockUploadedAlert : global::FrostWire.Libtorrent.Alerts.PeerAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/BlockUploadedAlert", typeof (BlockUploadedAlert));
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

		internal BlockUploadedAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='BlockUploadedAlert']/method[@name='blockIndex' and count(parameter)=0]"
		[Register ("blockIndex", "()I", "")]
		public unsafe int BlockIndex ()
		{
			const string __id = "blockIndex.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='BlockUploadedAlert']/method[@name='pieceIndex' and count(parameter)=0]"
		[Register ("pieceIndex", "()I", "")]
		public unsafe int PieceIndex ()
		{
			const string __id = "pieceIndex.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
