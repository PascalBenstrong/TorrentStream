using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='ListenFailedAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/ListenFailedAlert", DoNotGenerateAcw=true)]
	public sealed partial class ListenFailedAlert : global::FrostWire.Libtorrent.Alerts.AbstractAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/ListenFailedAlert", typeof (ListenFailedAlert));
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

		internal ListenFailedAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='ListenFailedAlert']/method[@name='address' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='ListenFailedAlert']/method[@name='error' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='ListenFailedAlert']/method[@name='listenInterface' and count(parameter)=0]"
		[Register ("listenInterface", "()Ljava/lang/String;", "")]
		public unsafe string ListenInterface ()
		{
			const string __id = "listenInterface.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='ListenFailedAlert']/method[@name='operation' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='ListenFailedAlert']/method[@name='port' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='ListenFailedAlert']/method[@name='socketType' and count(parameter)=0]"
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
