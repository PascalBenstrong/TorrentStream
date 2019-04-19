using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='LsdPeerAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/LsdPeerAlert", DoNotGenerateAcw=true)]
	public sealed partial class LsdPeerAlert : global::FrostWire.Libtorrent.Alerts.PeerAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/LsdPeerAlert", typeof (LsdPeerAlert));
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

		internal LsdPeerAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
