using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StateChangedAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/StateChangedAlert", DoNotGenerateAcw=true)]
	public sealed partial class StateChangedAlert : global::FrostWire.Libtorrent.Alerts.TorrentAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/StateChangedAlert", typeof (StateChangedAlert));
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

		internal StateChangedAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StateChangedAlert']/constructor[@name='StateChangedAlert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.state_changed_alert']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/state_changed_alert;)V", "")]
		public unsafe StateChangedAlert (global::FrostWire.Libtorrent.Swig.State_changed_alert alert)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/state_changed_alert;)V";

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

		public unsafe global::FrostWire.Libtorrent.TorrentStatus.State PrevState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StateChangedAlert']/method[@name='getPrevState' and count(parameter)=0]"
			[Register ("getPrevState", "()Lcom/frostwire/jlibtorrent/TorrentStatus$State;", "GetGetPrevStateHandler")]
			get {
				const string __id = "getPrevState.()Lcom/frostwire/jlibtorrent/TorrentStatus$State;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStatus.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::FrostWire.Libtorrent.TorrentStatus.State State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StateChangedAlert']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/frostwire/jlibtorrent/TorrentStatus$State;", "GetGetStateHandler")]
			get {
				const string __id = "getState.()Lcom/frostwire/jlibtorrent/TorrentStatus$State;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStatus.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
