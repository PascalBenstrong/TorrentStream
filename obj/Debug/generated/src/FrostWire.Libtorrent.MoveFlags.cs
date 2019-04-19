using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='MoveFlags']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/MoveFlags", DoNotGenerateAcw=true)]
	public sealed partial class MoveFlags : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='MoveFlags']/field[@name='ALWAYS_REPLACE_FILES']"
		[Register ("ALWAYS_REPLACE_FILES")]
		public static global::FrostWire.Libtorrent.MoveFlags AlwaysReplaceFiles {
			get {
				const string __id = "ALWAYS_REPLACE_FILES.Lcom/frostwire/jlibtorrent/MoveFlags;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.MoveFlags> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='MoveFlags']/field[@name='DONT_REPLACE']"
		[Register ("DONT_REPLACE")]
		public static global::FrostWire.Libtorrent.MoveFlags DontReplace {
			get {
				const string __id = "DONT_REPLACE.Lcom/frostwire/jlibtorrent/MoveFlags;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.MoveFlags> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='MoveFlags']/field[@name='FAIL_IF_EXIST']"
		[Register ("FAIL_IF_EXIST")]
		public static global::FrostWire.Libtorrent.MoveFlags FailIfExist {
			get {
				const string __id = "FAIL_IF_EXIST.Lcom/frostwire/jlibtorrent/MoveFlags;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.MoveFlags> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/MoveFlags", typeof (MoveFlags));
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

		internal MoveFlags (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='MoveFlags']/method[@name='fromSwig' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.move_flags_t']]"
		[Register ("fromSwig", "(Lcom/frostwire/jlibtorrent/swig/move_flags_t;)Lcom/frostwire/jlibtorrent/MoveFlags;", "")]
		public static unsafe global::FrostWire.Libtorrent.MoveFlags FromSwig (global::FrostWire.Libtorrent.Swig.Move_flags_t swigValue)
		{
			const string __id = "fromSwig.(Lcom/frostwire/jlibtorrent/swig/move_flags_t;)Lcom/frostwire/jlibtorrent/MoveFlags;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((swigValue == null) ? IntPtr.Zero : ((global::Java.Lang.Object) swigValue).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.MoveFlags> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='MoveFlags']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/move_flags_t;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Move_flags_t Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/move_flags_t;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Move_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='MoveFlags']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/MoveFlags;", "")]
		public static unsafe global::FrostWire.Libtorrent.MoveFlags ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/MoveFlags;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.MoveFlags> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='MoveFlags']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/frostwire/jlibtorrent/MoveFlags;", "")]
		public static unsafe global::FrostWire.Libtorrent.MoveFlags[] Values ()
		{
			const string __id = "values.()[Lcom/frostwire/jlibtorrent/MoveFlags;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::FrostWire.Libtorrent.MoveFlags[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.MoveFlags));
			} finally {
			}
		}

	}
}
