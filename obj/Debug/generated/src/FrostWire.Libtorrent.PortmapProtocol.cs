using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PortmapProtocol']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/PortmapProtocol", DoNotGenerateAcw=true)]
	public sealed partial class PortmapProtocol : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PortmapProtocol']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::FrostWire.Libtorrent.PortmapProtocol None {
			get {
				const string __id = "NONE.Lcom/frostwire/jlibtorrent/PortmapProtocol;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PortmapProtocol> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PortmapProtocol']/field[@name='TCP']"
		[Register ("TCP")]
		public static global::FrostWire.Libtorrent.PortmapProtocol Tcp {
			get {
				const string __id = "TCP.Lcom/frostwire/jlibtorrent/PortmapProtocol;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PortmapProtocol> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PortmapProtocol']/field[@name='UDP']"
		[Register ("UDP")]
		public static global::FrostWire.Libtorrent.PortmapProtocol Udp {
			get {
				const string __id = "UDP.Lcom/frostwire/jlibtorrent/PortmapProtocol;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PortmapProtocol> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/PortmapProtocol", typeof (PortmapProtocol));
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

		internal PortmapProtocol (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PortmapProtocol']/method[@name='fromSwig' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromSwig", "(I)Lcom/frostwire/jlibtorrent/PortmapProtocol;", "")]
		public static unsafe global::FrostWire.Libtorrent.PortmapProtocol FromSwig (int swigValue)
		{
			const string __id = "fromSwig.(I)Lcom/frostwire/jlibtorrent/PortmapProtocol;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (swigValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PortmapProtocol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PortmapProtocol']/method[@name='swig' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PortmapProtocol']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/PortmapProtocol;", "")]
		public static unsafe global::FrostWire.Libtorrent.PortmapProtocol ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/PortmapProtocol;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PortmapProtocol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PortmapProtocol']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/frostwire/jlibtorrent/PortmapProtocol;", "")]
		public static unsafe global::FrostWire.Libtorrent.PortmapProtocol[] Values ()
		{
			const string __id = "values.()[Lcom/frostwire/jlibtorrent/PortmapProtocol;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::FrostWire.Libtorrent.PortmapProtocol[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.PortmapProtocol));
			} finally {
			}
		}

	}
}
