using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Entry']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/Entry", DoNotGenerateAcw=true)]
	public sealed partial class Entry : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/Entry", typeof (Entry));
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

		internal Entry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Entry']/constructor[@name='Entry' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.entry']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/entry;)V", "")]
		public unsafe Entry (global::FrostWire.Libtorrent.Swig.Entry e)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/entry;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Entry']/constructor[@name='Entry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Entry (string s)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Entry']/constructor[@name='Entry' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe Entry (long n)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (n);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Entry']/method[@name='bdecode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("bdecode", "([B)Lcom/frostwire/jlibtorrent/Entry;", "")]
		public static unsafe global::FrostWire.Libtorrent.Entry Bdecode (byte[] data)
		{
			const string __id = "bdecode.([B)Lcom/frostwire/jlibtorrent/Entry;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Entry']/method[@name='bdecode' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("bdecode", "(Ljava/io/File;)Lcom/frostwire/jlibtorrent/Entry;", "")]
		public static unsafe global::FrostWire.Libtorrent.Entry Bdecode (global::Java.IO.File file)
		{
			const string __id = "bdecode.(Ljava/io/File;)Lcom/frostwire/jlibtorrent/Entry;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Entry']/method[@name='bencode' and count(parameter)=0]"
		[Register ("bencode", "()[B", "")]
		public unsafe byte[] Bencode ()
		{
			const string __id = "bencode.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Entry']/method[@name='dictionary' and count(parameter)=0]"
		[Register ("dictionary", "()Ljava/util/Map;", "")]
		public unsafe global::System.Collections.Generic.IDictionary<string, global::FrostWire.Libtorrent.Entry> Dictionary ()
		{
			const string __id = "dictionary.()Ljava/util/Map;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaDictionary<string, global::FrostWire.Libtorrent.Entry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Entry']/method[@name='fromList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;?&gt;']]"
		[Register ("fromList", "(Ljava/util/List;)Lcom/frostwire/jlibtorrent/Entry;", "")]
		public static unsafe global::FrostWire.Libtorrent.Entry FromList (global::System.Collections.Generic.IList<object> list)
		{
			const string __id = "fromList.(Ljava/util/List;)Lcom/frostwire/jlibtorrent/Entry;";
			IntPtr native_list = global::Android.Runtime.JavaList<object>.ToLocalJniHandle (list);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_list);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_list);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Entry']/method[@name='fromMap' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, ?&gt;']]"
		[Register ("fromMap", "(Ljava/util/Map;)Lcom/frostwire/jlibtorrent/Entry;", "")]
		public static unsafe global::FrostWire.Libtorrent.Entry FromMap (global::System.Collections.Generic.IDictionary<string, object> map)
		{
			const string __id = "fromMap.(Ljava/util/Map;)Lcom/frostwire/jlibtorrent/Entry;";
			IntPtr native_map = global::Android.Runtime.JavaDictionary<string, object>.ToLocalJniHandle (map);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_map);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_map);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Entry']/method[@name='integer' and count(parameter)=0]"
		[Register ("integer", "()J", "")]
		public unsafe long Integer ()
		{
			const string __id = "integer.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Entry']/method[@name='list' and count(parameter)=0]"
		[Register ("list", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Entry> List ()
		{
			const string __id = "list.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Entry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Entry']/method[@name='string' and count(parameter)=0]"
		[Register ("string", "()Ljava/lang/String;", "")]
		public unsafe string String ()
		{
			const string __id = "string.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Entry']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/entry;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Entry Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/entry;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
