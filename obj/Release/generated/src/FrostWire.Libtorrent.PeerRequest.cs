using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerRequest']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/PeerRequest", DoNotGenerateAcw=true)]
	public sealed partial class PeerRequest : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/PeerRequest", typeof (PeerRequest));
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

		internal PeerRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerRequest']/constructor[@name='PeerRequest' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_request']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/peer_request;)V", "")]
		public unsafe PeerRequest (global::FrostWire.Libtorrent.Swig.Peer_request r)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/peer_request;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerRequest']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()I", "")]
		public unsafe int Length ()
		{
			const string __id = "length.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerRequest']/method[@name='piece' and count(parameter)=0]"
		[Register ("piece", "()I", "")]
		public unsafe int Piece ()
		{
			const string __id = "piece.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerRequest']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()I", "")]
		public unsafe int Start ()
		{
			const string __id = "start.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerRequest']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/peer_request;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Peer_request Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/peer_request;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_request> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
