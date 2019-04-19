using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerDisconnectedAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/PeerDisconnectedAlert", DoNotGenerateAcw=true)]
	public sealed partial class PeerDisconnectedAlert : global::FrostWire.Libtorrent.Alerts.PeerAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/PeerDisconnectedAlert", typeof (PeerDisconnectedAlert));
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

		internal PeerDisconnectedAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerDisconnectedAlert']/method[@name='error' and count(parameter)=0]"
		[Register ("error", "()Lcom/frostwire/jlibtorrent/ErrorCode;", "")]
		public unsafe global::FrostWire.Libtorrent.ErrorCode Error ()
		{
			const string __id = "error.()Lcom/frostwire/jlibtorrent/ErrorCode;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.ErrorCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerDisconnectedAlert']/method[@name='operation' and count(parameter)=0]"
		[Register ("operation", "()Lcom/frostwire/jlibtorrent/Operation;", "")]
		public unsafe global::FrostWire.Libtorrent.Operation Operation ()
		{
			const string __id = "operation.()Lcom/frostwire/jlibtorrent/Operation;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Operation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerDisconnectedAlert']/method[@name='reason' and count(parameter)=0]"
		[Register ("reason", "()Lcom/frostwire/jlibtorrent/alerts/CloseReason;", "")]
		public unsafe global::FrostWire.Libtorrent.Alerts.CloseReason Reason ()
		{
			const string __id = "reason.()Lcom/frostwire/jlibtorrent/alerts/CloseReason;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PeerDisconnectedAlert']/method[@name='socketType' and count(parameter)=0]"
		[Register ("socketType", "()I", "")]
		public unsafe int SocketType ()
		{
			const string __id = "socketType.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
