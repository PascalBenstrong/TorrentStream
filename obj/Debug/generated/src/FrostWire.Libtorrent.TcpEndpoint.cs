using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TcpEndpoint']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/TcpEndpoint", DoNotGenerateAcw=true)]
	public sealed partial class TcpEndpoint : global::Java.Lang.Object, global::Java.Lang.ICloneable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/TcpEndpoint", typeof (TcpEndpoint));
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

		internal TcpEndpoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TcpEndpoint']/constructor[@name='TcpEndpoint' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TcpEndpoint ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TcpEndpoint']/constructor[@name='TcpEndpoint' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.Address'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/Address;I)V", "")]
		public unsafe TcpEndpoint (global::FrostWire.Libtorrent.Address address, int port)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/Address;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((address == null) ? IntPtr.Zero : ((global::Java.Lang.Object) address).Handle);
				__args [1] = new JniArgumentValue (port);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TcpEndpoint']/constructor[@name='TcpEndpoint' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.tcp_endpoint']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;)V", "")]
		public unsafe TcpEndpoint (global::FrostWire.Libtorrent.Swig.Tcp_endpoint endp)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((endp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) endp).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TcpEndpoint']/constructor[@name='TcpEndpoint' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe TcpEndpoint (string ip, int port)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_ip = JNIEnv.NewString (ip);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_ip);
				__args [1] = new JniArgumentValue (port);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_ip);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TcpEndpoint']/method[@name='address' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TcpEndpoint']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/frostwire/jlibtorrent/TcpEndpoint;", "")]
		public unsafe global::FrostWire.Libtorrent.TcpEndpoint Clone ()
		{
			const string __id = "clone.()Lcom/frostwire/jlibtorrent/TcpEndpoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TcpEndpoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TcpEndpoint']/method[@name='port' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TcpEndpoint']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Tcp_endpoint Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tcp_endpoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
