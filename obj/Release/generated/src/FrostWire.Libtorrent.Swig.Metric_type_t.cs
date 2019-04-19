using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='metric_type_t']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/metric_type_t", DoNotGenerateAcw=true)]
	public sealed partial class Metric_type_t : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='metric_type_t']/field[@name='counter']"
		[Register ("counter")]
		public static global::FrostWire.Libtorrent.Swig.Metric_type_t Counter {
			get {
				const string __id = "counter.Lcom/frostwire/jlibtorrent/swig/metric_type_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Metric_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='metric_type_t']/field[@name='gauge']"
		[Register ("gauge")]
		public static global::FrostWire.Libtorrent.Swig.Metric_type_t Gauge {
			get {
				const string __id = "gauge.Lcom/frostwire/jlibtorrent/swig/metric_type_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Metric_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/metric_type_t", typeof (Metric_type_t));
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

		internal Metric_type_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='metric_type_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/metric_type_t;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Metric_type_t SwigToEnum (int swigValue)
		{
			const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/metric_type_t;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (swigValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Metric_type_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='metric_type_t']/method[@name='swigValue' and count(parameter)=0]"
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
