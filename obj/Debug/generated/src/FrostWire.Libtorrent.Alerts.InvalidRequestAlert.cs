using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='InvalidRequestAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/InvalidRequestAlert", DoNotGenerateAcw=true)]
	public sealed partial class InvalidRequestAlert : global::FrostWire.Libtorrent.Alerts.PeerAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/InvalidRequestAlert", typeof (InvalidRequestAlert));
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

		internal InvalidRequestAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='InvalidRequestAlert']/constructor[@name='InvalidRequestAlert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.invalid_request_alert']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/invalid_request_alert;)V", "")]
		public unsafe InvalidRequestAlert (global::FrostWire.Libtorrent.Swig.Invalid_request_alert alert)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/invalid_request_alert;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((alert == null) ? IntPtr.Zero : ((global::Java.Lang.Object) alert).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe global::FrostWire.Libtorrent.PeerRequest Request {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='InvalidRequestAlert']/method[@name='getRequest' and count(parameter)=0]"
			[Register ("getRequest", "()Lcom/frostwire/jlibtorrent/PeerRequest;", "GetGetRequestHandler")]
			get {
				const string __id = "getRequest.()Lcom/frostwire/jlibtorrent/PeerRequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
