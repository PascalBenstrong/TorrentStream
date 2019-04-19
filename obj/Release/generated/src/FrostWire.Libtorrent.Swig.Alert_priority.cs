using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert_priority']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/alert_priority", DoNotGenerateAcw=true)]
	public sealed partial class Alert_priority : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert_priority']/field[@name='alert_priority_critical']"
		[Register ("alert_priority_critical")]
		public static global::FrostWire.Libtorrent.Swig.Alert_priority AlertPriorityCritical {
			get {
				const string __id = "alert_priority_critical.Lcom/frostwire/jlibtorrent/swig/alert_priority;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_priority> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert_priority']/field[@name='alert_priority_high']"
		[Register ("alert_priority_high")]
		public static global::FrostWire.Libtorrent.Swig.Alert_priority AlertPriorityHigh {
			get {
				const string __id = "alert_priority_high.Lcom/frostwire/jlibtorrent/swig/alert_priority;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_priority> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert_priority']/field[@name='alert_priority_normal']"
		[Register ("alert_priority_normal")]
		public static global::FrostWire.Libtorrent.Swig.Alert_priority AlertPriorityNormal {
			get {
				const string __id = "alert_priority_normal.Lcom/frostwire/jlibtorrent/swig/alert_priority;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_priority> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/alert_priority", typeof (Alert_priority));
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

		internal Alert_priority (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert_priority']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/alert_priority;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Alert_priority SwigToEnum (int swigValue)
		{
			const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/alert_priority;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (swigValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_priority> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert_priority']/method[@name='swigValue' and count(parameter)=0]"
		[Register ("swigValue", "()I", "")]
		public unsafe int SwigValue ()
		{
			const string __id = "swigValue.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
