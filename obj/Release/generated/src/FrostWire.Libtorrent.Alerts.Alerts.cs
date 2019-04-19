using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='Alerts']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/Alerts", DoNotGenerateAcw=true)]
	public sealed partial class Alerts : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='Alerts']/field[@name='NUM_ALERT_TYPES']"
		[Register ("NUM_ALERT_TYPES")]
		public static int NumAlertTypes {
			get {
				const string __id = "NUM_ALERT_TYPES.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/Alerts", typeof (Alerts));
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

		internal Alerts (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='Alerts']/method[@name='cast' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/alerts/Alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Alerts.IAlert Cast (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/alerts/Alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IAlert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
