using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='RequestDroppedAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/RequestDroppedAlert", DoNotGenerateAcw=true)]
	public sealed partial class RequestDroppedAlert : global::FrostWire.Libtorrent.Alerts.PeerAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/RequestDroppedAlert", typeof (RequestDroppedAlert));
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

		internal RequestDroppedAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='RequestDroppedAlert']/constructor[@name='RequestDroppedAlert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.request_dropped_alert']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/request_dropped_alert;)V", "")]
		public unsafe RequestDroppedAlert (global::FrostWire.Libtorrent.Swig.Request_dropped_alert alert)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/request_dropped_alert;)V";

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

		public unsafe int BlockIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='RequestDroppedAlert']/method[@name='getBlockIndex' and count(parameter)=0]"
			[Register ("getBlockIndex", "()I", "GetGetBlockIndexHandler")]
			get {
				const string __id = "getBlockIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int PieceIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='RequestDroppedAlert']/method[@name='getPieceIndex' and count(parameter)=0]"
			[Register ("getPieceIndex", "()I", "GetGetPieceIndexHandler")]
			get {
				const string __id = "getPieceIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
