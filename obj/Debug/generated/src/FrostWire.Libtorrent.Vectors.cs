using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Vectors']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/Vectors", DoNotGenerateAcw=true)]
	public sealed partial class Vectors : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/Vectors", typeof (Vectors));
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

		internal Vectors (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Vectors']/method[@name='ascii2byte_vector' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ascii2byte_vector", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/byte_vector;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Ascii2byte_vector (string s)
		{
			const string __id = "ascii2byte_vector.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Vectors']/method[@name='byte_span2bytes' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_const_span']]"
		[Register ("byte_span2bytes", "(Lcom/frostwire/jlibtorrent/swig/byte_const_span;)[B", "")]
		public static unsafe byte[] Byte_span2bytes (global::FrostWire.Libtorrent.Swig.Byte_const_span v)
		{
			const string __id = "byte_span2bytes.(Lcom/frostwire/jlibtorrent/swig/byte_const_span;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Vectors']/method[@name='byte_vector2ascii' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("byte_vector2ascii", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)Ljava/lang/String;", "")]
		public static unsafe string Byte_vector2ascii (global::FrostWire.Libtorrent.Swig.Byte_vector v)
		{
			const string __id = "byte_vector2ascii.(Lcom/frostwire/jlibtorrent/swig/byte_vector;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Vectors']/method[@name='byte_vector2bytes' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("byte_vector2bytes", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)[B", "")]
		public static unsafe byte[] Byte_vector2bytes (global::FrostWire.Libtorrent.Swig.Byte_vector v)
		{
			const string __id = "byte_vector2bytes.(Lcom/frostwire/jlibtorrent/swig/byte_vector;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Vectors']/method[@name='byte_vector2bytes' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector'] and parameter[2][@type='byte[]']]"
		[Register ("byte_vector2bytes", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;[B)V", "")]
		public static unsafe void Byte_vector2bytes (global::FrostWire.Libtorrent.Swig.Byte_vector v, byte[] arr)
		{
			const string __id = "byte_vector2bytes.(Lcom/frostwire/jlibtorrent/swig/byte_vector;[B)V";
			IntPtr native_arr = JNIEnv.NewArray (arr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				__args [1] = new JniArgumentValue (native_arr);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (arr != null) {
					JNIEnv.CopyArray (native_arr, arr);
					JNIEnv.DeleteLocalRef (native_arr);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Vectors']/method[@name='byte_vector2string' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector'] and parameter[2][@type='java.lang.String']]"
		[Register ("byte_vector2string", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Byte_vector2string (global::FrostWire.Libtorrent.Swig.Byte_vector v, string encoding)
		{
			const string __id = "byte_vector2string.(Lcom/frostwire/jlibtorrent/swig/byte_vector;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_encoding = JNIEnv.NewString (encoding);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				__args [1] = new JniArgumentValue (native_encoding);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_encoding);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Vectors']/method[@name='byte_vector2utf8' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("byte_vector2utf8", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)Ljava/lang/String;", "")]
		public static unsafe string Byte_vector2utf8 (global::FrostWire.Libtorrent.Swig.Byte_vector v)
		{
			const string __id = "byte_vector2utf8.(Lcom/frostwire/jlibtorrent/swig/byte_vector;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Vectors']/method[@name='bytes2byte_vector' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("bytes2byte_vector", "([B)Lcom/frostwire/jlibtorrent/swig/byte_vector;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Bytes2byte_vector (byte[] arr)
		{
			const string __id = "bytes2byte_vector.([B)Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			IntPtr native_arr = JNIEnv.NewArray (arr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_arr);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (arr != null) {
					JNIEnv.CopyArray (native_arr, arr);
					JNIEnv.DeleteLocalRef (native_arr);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Vectors']/method[@name='bytes2byte_vector' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("bytes2byte_vector", "([BLcom/frostwire/jlibtorrent/swig/byte_vector;)V", "")]
		public static unsafe void Bytes2byte_vector (byte[] arr, global::FrostWire.Libtorrent.Swig.Byte_vector v)
		{
			const string __id = "bytes2byte_vector.([BLcom/frostwire/jlibtorrent/swig/byte_vector;)V";
			IntPtr native_arr = JNIEnv.NewArray (arr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_arr);
				__args [1] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (arr != null) {
					JNIEnv.CopyArray (native_arr, arr);
					JNIEnv.DeleteLocalRef (native_arr);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Vectors']/method[@name='int64_vector2longs' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.int64_vector']]"
		[Register ("int64_vector2longs", "(Lcom/frostwire/jlibtorrent/swig/int64_vector;)[J", "")]
		public static unsafe long[] Int64_vector2longs (global::FrostWire.Libtorrent.Swig.Int64_vector v)
		{
			const string __id = "int64_vector2longs.(Lcom/frostwire/jlibtorrent/swig/int64_vector;)[J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (long[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (long));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Vectors']/method[@name='int_vector2ints' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.int_vector']]"
		[Register ("int_vector2ints", "(Lcom/frostwire/jlibtorrent/swig/int_vector;)[I", "")]
		public static unsafe int[] Int_vector2ints (global::FrostWire.Libtorrent.Swig.Int_vector v)
		{
			const string __id = "int_vector2ints.(Lcom/frostwire/jlibtorrent/swig/int_vector;)[I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Vectors']/method[@name='new_byte_vector' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("new_byte_vector", "(I)Lcom/frostwire/jlibtorrent/swig/byte_vector;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Byte_vector New_byte_vector (int size)
		{
			const string __id = "new_byte_vector.(I)Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (size);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Vectors']/method[@name='string2byte_vector' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("string2byte_vector", "(Ljava/lang/String;Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/byte_vector;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Byte_vector String2byte_vector (string s, string encoding)
		{
			const string __id = "string2byte_vector.(Ljava/lang/String;Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			IntPtr native_s = JNIEnv.NewString (s);
			IntPtr native_encoding = JNIEnv.NewString (encoding);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_s);
				__args [1] = new JniArgumentValue (native_encoding);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
				JNIEnv.DeleteLocalRef (native_encoding);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Vectors']/method[@name='string_vector2list' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_vector']]"
		[Register ("string_vector2list", "(Lcom/frostwire/jlibtorrent/swig/string_vector;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> String_vector2list (global::FrostWire.Libtorrent.Swig.String_vector v)
		{
			const string __id = "string_vector2list.(Lcom/frostwire/jlibtorrent/swig/string_vector;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
