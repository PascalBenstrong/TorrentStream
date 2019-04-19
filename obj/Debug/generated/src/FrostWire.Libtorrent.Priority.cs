using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Priority']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/Priority", DoNotGenerateAcw=true)]
	public sealed partial class Priority : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Priority']/field[@name='FIVE']"
		[Register ("FIVE")]
		public static global::FrostWire.Libtorrent.Priority Five {
			get {
				const string __id = "FIVE.Lcom/frostwire/jlibtorrent/Priority;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Priority> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Priority']/field[@name='FOUR']"
		[Register ("FOUR")]
		public static global::FrostWire.Libtorrent.Priority Four {
			get {
				const string __id = "FOUR.Lcom/frostwire/jlibtorrent/Priority;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Priority> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Priority']/field[@name='IGNORE']"
		[Register ("IGNORE")]
		public static global::FrostWire.Libtorrent.Priority Ignore {
			get {
				const string __id = "IGNORE.Lcom/frostwire/jlibtorrent/Priority;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Priority> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Priority']/field[@name='NORMAL']"
		[Register ("NORMAL")]
		public static global::FrostWire.Libtorrent.Priority Normal {
			get {
				const string __id = "NORMAL.Lcom/frostwire/jlibtorrent/Priority;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Priority> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Priority']/field[@name='SEVEN']"
		[Register ("SEVEN")]
		public static global::FrostWire.Libtorrent.Priority Seven {
			get {
				const string __id = "SEVEN.Lcom/frostwire/jlibtorrent/Priority;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Priority> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Priority']/field[@name='SIX']"
		[Register ("SIX")]
		public static global::FrostWire.Libtorrent.Priority Six {
			get {
				const string __id = "SIX.Lcom/frostwire/jlibtorrent/Priority;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Priority> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Priority']/field[@name='THREE']"
		[Register ("THREE")]
		public static global::FrostWire.Libtorrent.Priority Three {
			get {
				const string __id = "THREE.Lcom/frostwire/jlibtorrent/Priority;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Priority> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Priority']/field[@name='TWO']"
		[Register ("TWO")]
		public static global::FrostWire.Libtorrent.Priority Two {
			get {
				const string __id = "TWO.Lcom/frostwire/jlibtorrent/Priority;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Priority> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/Priority", typeof (Priority));
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

		internal Priority (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Priority']/method[@name='array' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.Priority'] and parameter[2][@type='int']]"
		[Register ("array", "(Lcom/frostwire/jlibtorrent/Priority;I)[Lcom/frostwire/jlibtorrent/Priority;", "")]
		public static unsafe global::FrostWire.Libtorrent.Priority[] Array (global::FrostWire.Libtorrent.Priority value, int size)
		{
			const string __id = "array.(Lcom/frostwire/jlibtorrent/Priority;I)[Lcom/frostwire/jlibtorrent/Priority;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				__args [1] = new JniArgumentValue (size);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::FrostWire.Libtorrent.Priority[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.Priority));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Priority']/method[@name='fromSwig' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromSwig", "(I)Lcom/frostwire/jlibtorrent/Priority;", "")]
		public static unsafe global::FrostWire.Libtorrent.Priority FromSwig (int swigValue)
		{
			const string __id = "fromSwig.(I)Lcom/frostwire/jlibtorrent/Priority;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (swigValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Priority> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Priority']/method[@name='swig' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Priority']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/Priority;", "")]
		public static unsafe global::FrostWire.Libtorrent.Priority ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/Priority;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Priority> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Priority']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/frostwire/jlibtorrent/Priority;", "")]
		public static unsafe global::FrostWire.Libtorrent.Priority[] Values ()
		{
			const string __id = "values.()[Lcom/frostwire/jlibtorrent/Priority;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::FrostWire.Libtorrent.Priority[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.Priority));
			} finally {
			}
		}

	}
}
