using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtImmutableItemAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/DhtImmutableItemAlert", DoNotGenerateAcw=true)]
	public sealed partial class DhtImmutableItemAlert : global::FrostWire.Libtorrent.Alerts.AbstractAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/DhtImmutableItemAlert", typeof (DhtImmutableItemAlert));
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

		internal DhtImmutableItemAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtImmutableItemAlert']/method[@name='item' and count(parameter)=0]"
		[Register ("item", "()Lcom/frostwire/jlibtorrent/Entry;", "")]
		public unsafe global::FrostWire.Libtorrent.Entry Item ()
		{
			const string __id = "item.()Lcom/frostwire/jlibtorrent/Entry;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtImmutableItemAlert']/method[@name='target' and count(parameter)=0]"
		[Register ("target", "()Lcom/frostwire/jlibtorrent/Sha1Hash;", "")]
		public unsafe global::FrostWire.Libtorrent.Sha1Hash Target ()
		{
			const string __id = "target.()Lcom/frostwire/jlibtorrent/Sha1Hash;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
