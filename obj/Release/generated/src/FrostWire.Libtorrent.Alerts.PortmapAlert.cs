using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PortmapAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/PortmapAlert", DoNotGenerateAcw=true)]
	public sealed partial class PortmapAlert : global::FrostWire.Libtorrent.Alerts.AbstractAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/PortmapAlert", typeof (PortmapAlert));
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

		internal PortmapAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PortmapAlert']/method[@name='externalPort' and count(parameter)=0]"
		[Register ("externalPort", "()I", "")]
		public unsafe int ExternalPort ()
		{
			const string __id = "externalPort.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PortmapAlert']/method[@name='mapProtocol' and count(parameter)=0]"
		[Register ("mapProtocol", "()Lcom/frostwire/jlibtorrent/PortmapProtocol;", "")]
		public unsafe global::FrostWire.Libtorrent.PortmapProtocol MapProtocol ()
		{
			const string __id = "mapProtocol.()Lcom/frostwire/jlibtorrent/PortmapProtocol;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PortmapProtocol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PortmapAlert']/method[@name='mapTransport' and count(parameter)=0]"
		[Register ("mapTransport", "()Lcom/frostwire/jlibtorrent/PortmapTransport;", "")]
		public unsafe global::FrostWire.Libtorrent.PortmapTransport MapTransport ()
		{
			const string __id = "mapTransport.()Lcom/frostwire/jlibtorrent/PortmapTransport;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PortmapTransport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PortmapAlert']/method[@name='mapping' and count(parameter)=0]"
		[Register ("mapping", "()I", "")]
		public unsafe int Mapping ()
		{
			const string __id = "mapping.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
