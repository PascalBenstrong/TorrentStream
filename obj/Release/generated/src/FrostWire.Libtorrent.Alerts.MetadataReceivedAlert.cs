using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='MetadataReceivedAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/MetadataReceivedAlert", DoNotGenerateAcw=true)]
	public sealed partial class MetadataReceivedAlert : global::FrostWire.Libtorrent.Alerts.TorrentAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/MetadataReceivedAlert", typeof (MetadataReceivedAlert));
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

		internal MetadataReceivedAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='MetadataReceivedAlert']/method[@name='metadataSize' and count(parameter)=0]"
		[Register ("metadataSize", "()I", "")]
		public unsafe int MetadataSize ()
		{
			const string __id = "metadataSize.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='MetadataReceivedAlert']/method[@name='torrentData' and count(parameter)=0]"
		[Register ("torrentData", "()[B", "")]
		public unsafe byte[] TorrentData ()
		{
			const string __id = "torrentData.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='MetadataReceivedAlert']/method[@name='torrentData' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("torrentData", "(Z)[B", "")]
		public unsafe byte[] TorrentData (bool extra)
		{
			const string __id = "torrentData.(Z)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (extra);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
