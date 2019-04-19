using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_transport']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/portmap_transport", DoNotGenerateAcw=true)]
	public sealed partial class Portmap_transport : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_transport']/field[@name='natpmp']"
		[Register ("natpmp")]
		public static global::FrostWire.Libtorrent.Swig.Portmap_transport Natpmp {
			get {
				const string __id = "natpmp.Lcom/frostwire/jlibtorrent/swig/portmap_transport;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_transport> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_transport']/field[@name='upnp']"
		[Register ("upnp")]
		public static global::FrostWire.Libtorrent.Swig.Portmap_transport Upnp {
			get {
				const string __id = "upnp.Lcom/frostwire/jlibtorrent/swig/portmap_transport;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_transport> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/portmap_transport", typeof (Portmap_transport));
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

		internal Portmap_transport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_transport']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/portmap_transport;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Portmap_transport SwigToEnum (int swigValue)
		{
			const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/portmap_transport;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (swigValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_transport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_transport']/method[@name='swigValue' and count(parameter)=0]"
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
