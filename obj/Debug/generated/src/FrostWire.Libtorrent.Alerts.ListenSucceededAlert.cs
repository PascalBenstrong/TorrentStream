using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='ListenSucceededAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/ListenSucceededAlert", DoNotGenerateAcw=true)]
	public sealed partial class ListenSucceededAlert : global::FrostWire.Libtorrent.Alerts.AbstractAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/ListenSucceededAlert", typeof (ListenSucceededAlert));
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

		internal ListenSucceededAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='ListenSucceededAlert']/method[@name='address' and count(parameter)=0]"
		[Register ("address", "()Lcom/frostwire/jlibtorrent/Address;", "")]
		public unsafe global::FrostWire.Libtorrent.Address Address ()
		{
			const string __id = "address.()Lcom/frostwire/jlibtorrent/Address;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='ListenSucceededAlert']/method[@name='port' and count(parameter)=0]"
		[Register ("port", "()I", "")]
		public unsafe int Port ()
		{
			const string __id = "port.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='ListenSucceededAlert']/method[@name='socketType' and count(parameter)=0]"
		[Register ("socketType", "()Lcom/frostwire/jlibtorrent/alerts/SocketType;", "")]
		public unsafe global::FrostWire.Libtorrent.Alerts.SocketType SocketType ()
		{
			const string __id = "socketType.()Lcom/frostwire/jlibtorrent/alerts/SocketType;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.SocketType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
