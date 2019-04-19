using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PortmapTransport']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/PortmapTransport", DoNotGenerateAcw=true)]
	public sealed partial class PortmapTransport : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PortmapTransport']/field[@name='NAT_PMP']"
		[Register ("NAT_PMP")]
		public static global::FrostWire.Libtorrent.PortmapTransport NatPmp {
			get {
				const string __id = "NAT_PMP.Lcom/frostwire/jlibtorrent/PortmapTransport;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PortmapTransport> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PortmapTransport']/field[@name='UPNP']"
		[Register ("UPNP")]
		public static global::FrostWire.Libtorrent.PortmapTransport Upnp {
			get {
				const string __id = "UPNP.Lcom/frostwire/jlibtorrent/PortmapTransport;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PortmapTransport> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/PortmapTransport", typeof (PortmapTransport));
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

		internal PortmapTransport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PortmapTransport']/method[@name='fromSwig' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromSwig", "(I)Lcom/frostwire/jlibtorrent/PortmapTransport;", "")]
		public static unsafe global::FrostWire.Libtorrent.PortmapTransport FromSwig (int swigValue)
		{
			const string __id = "fromSwig.(I)Lcom/frostwire/jlibtorrent/PortmapTransport;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (swigValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PortmapTransport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PortmapTransport']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()I", "")]
		public unsafe int Swig ()
		{
			const string __id = "swig.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PortmapTransport']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/PortmapTransport;", "")]
		public static unsafe global::FrostWire.Libtorrent.PortmapTransport ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/PortmapTransport;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PortmapTransport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PortmapTransport']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/frostwire/jlibtorrent/PortmapTransport;", "")]
		public static unsafe global::FrostWire.Libtorrent.PortmapTransport[] Values ()
		{
			const string __id = "values.()[Lcom/frostwire/jlibtorrent/PortmapTransport;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::FrostWire.Libtorrent.PortmapTransport[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.PortmapTransport));
			} finally {
			}
		}

	}
}
