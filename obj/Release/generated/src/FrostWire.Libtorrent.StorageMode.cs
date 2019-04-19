using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StorageMode']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/StorageMode", DoNotGenerateAcw=true)]
	public sealed partial class StorageMode : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StorageMode']/field[@name='STORAGE_MODE_ALLOCATE']"
		[Register ("STORAGE_MODE_ALLOCATE")]
		public static global::FrostWire.Libtorrent.StorageMode StorageModeAllocate {
			get {
				const string __id = "STORAGE_MODE_ALLOCATE.Lcom/frostwire/jlibtorrent/StorageMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.StorageMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StorageMode']/field[@name='STORAGE_MODE_SPARSE']"
		[Register ("STORAGE_MODE_SPARSE")]
		public static global::FrostWire.Libtorrent.StorageMode StorageModeSparse {
			get {
				const string __id = "STORAGE_MODE_SPARSE.Lcom/frostwire/jlibtorrent/StorageMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.StorageMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StorageMode']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::FrostWire.Libtorrent.StorageMode Unknown {
			get {
				const string __id = "UNKNOWN.Lcom/frostwire/jlibtorrent/StorageMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.StorageMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/StorageMode", typeof (StorageMode));
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

		internal StorageMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StorageMode']/method[@name='fromSwig' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromSwig", "(I)Lcom/frostwire/jlibtorrent/StorageMode;", "")]
		public static unsafe global::FrostWire.Libtorrent.StorageMode FromSwig (int swigValue)
		{
			const string __id = "fromSwig.(I)Lcom/frostwire/jlibtorrent/StorageMode;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (swigValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.StorageMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StorageMode']/method[@name='swig' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StorageMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/StorageMode;", "")]
		public static unsafe global::FrostWire.Libtorrent.StorageMode ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/StorageMode;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.StorageMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StorageMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/frostwire/jlibtorrent/StorageMode;", "")]
		public static unsafe global::FrostWire.Libtorrent.StorageMode[] Values ()
		{
			const string __id = "values.()[Lcom/frostwire/jlibtorrent/StorageMode;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::FrostWire.Libtorrent.StorageMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.StorageMode));
			} finally {
			}
		}

	}
}
