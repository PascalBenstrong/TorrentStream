using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/bdecode_node", DoNotGenerateAcw=true)]
	public partial class Bdecode_node : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/field[@name='swigCMemOwn']"
		[Register ("swigCMemOwn")]
		protected bool SwigCMemOwn {
			get {
				const string __id = "swigCMemOwn.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "swigCMemOwn.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node.type_t']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/bdecode_node$type_t", DoNotGenerateAcw=true)]
		public sealed partial class Type_t : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node.type_t']/field[@name='dict_t']"
			[Register ("dict_t")]
			public static global::FrostWire.Libtorrent.Swig.Bdecode_node.Type_t DictT {
				get {
					const string __id = "dict_t.Lcom/frostwire/jlibtorrent/swig/bdecode_node$type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node.Type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node.type_t']/field[@name='int_t']"
			[Register ("int_t")]
			public static global::FrostWire.Libtorrent.Swig.Bdecode_node.Type_t IntT {
				get {
					const string __id = "int_t.Lcom/frostwire/jlibtorrent/swig/bdecode_node$type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node.Type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node.type_t']/field[@name='list_t']"
			[Register ("list_t")]
			public static global::FrostWire.Libtorrent.Swig.Bdecode_node.Type_t ListT {
				get {
					const string __id = "list_t.Lcom/frostwire/jlibtorrent/swig/bdecode_node$type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node.Type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node.type_t']/field[@name='none_t']"
			[Register ("none_t")]
			public static global::FrostWire.Libtorrent.Swig.Bdecode_node.Type_t NoneT {
				get {
					const string __id = "none_t.Lcom/frostwire/jlibtorrent/swig/bdecode_node$type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node.Type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node.type_t']/field[@name='string_t']"
			[Register ("string_t")]
			public static global::FrostWire.Libtorrent.Swig.Bdecode_node.Type_t StringT {
				get {
					const string __id = "string_t.Lcom/frostwire/jlibtorrent/swig/bdecode_node$type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node.Type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/bdecode_node$type_t", typeof (Type_t));
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

			internal Type_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node.type_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/bdecode_node$type_t;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Bdecode_node.Type_t SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/bdecode_node$type_t;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node.Type_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node.type_t']/method[@name='swigValue' and count(parameter)=0]"
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/bdecode_node", typeof (Bdecode_node));
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

		protected Bdecode_node (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/constructor[@name='bdecode_node' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Bdecode_node ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/constructor[@name='bdecode_node' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.bdecode_node']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/bdecode_node;)V", "")]
		public unsafe Bdecode_node (global::FrostWire.Libtorrent.Swig.Bdecode_node arg0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/bdecode_node;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((arg0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/constructor[@name='bdecode_node' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Bdecode_node (long cPtr, bool cMemoryOwn)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (cPtr);
				__args [1] = new JniArgumentValue (cMemoryOwn);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='bdecode' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.bdecode_node'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.error_code']]"
		[Register ("bdecode", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/bdecode_node;Lcom/frostwire/jlibtorrent/swig/error_code;)I", "")]
		public static unsafe int Bdecode (global::FrostWire.Libtorrent.Swig.Byte_vector buffer, global::FrostWire.Libtorrent.Swig.Bdecode_node ret, global::FrostWire.Libtorrent.Swig.Error_code ec)
		{
			const string __id = "bdecode.(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/bdecode_node;Lcom/frostwire/jlibtorrent/swig/error_code;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [1] = new JniArgumentValue ((ret == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ret).Handle);
				__args [2] = new JniArgumentValue ((ec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ec).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_delete;
#pragma warning disable 0169
		static Delegate GetDeleteHandler ()
		{
			if (cb_delete == null)
				cb_delete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Delete);
			return cb_delete;
		}

		static void n_Delete (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_dict_at_I;
#pragma warning disable 0169
		static Delegate GetDict_at_IHandler ()
		{
			if (cb_dict_at_I == null)
				cb_dict_at_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Dict_at_I);
			return cb_dict_at_I;
		}

		static IntPtr n_Dict_at_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Dict_at (i));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='dict_at' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("dict_at", "(I)Lcom/frostwire/jlibtorrent/swig/string_view_bdecode_node_pair;", "GetDict_at_IHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.String_view_bdecode_node_pair Dict_at (int i)
		{
			const string __id = "dict_at.(I)Lcom/frostwire/jlibtorrent/swig/string_view_bdecode_node_pair;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_view_bdecode_node_pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_dict_find_dict_s_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDict_find_dict_s_Ljava_lang_String_Handler ()
		{
			if (cb_dict_find_dict_s_Ljava_lang_String_ == null)
				cb_dict_find_dict_s_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Dict_find_dict_s_Ljava_lang_String_);
			return cb_dict_find_dict_s_Ljava_lang_String_;
		}

		static IntPtr n_Dict_find_dict_s_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Dict_find_dict_s (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='dict_find_dict_s' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dict_find_dict_s", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/bdecode_node;", "GetDict_find_dict_s_Ljava_lang_String_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Bdecode_node Dict_find_dict_s (string key)
		{
			const string __id = "dict_find_dict_s.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/bdecode_node;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_dict_find_int_s_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDict_find_int_s_Ljava_lang_String_Handler ()
		{
			if (cb_dict_find_int_s_Ljava_lang_String_ == null)
				cb_dict_find_int_s_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Dict_find_int_s_Ljava_lang_String_);
			return cb_dict_find_int_s_Ljava_lang_String_;
		}

		static IntPtr n_Dict_find_int_s_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Dict_find_int_s (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='dict_find_int_s' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dict_find_int_s", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/bdecode_node;", "GetDict_find_int_s_Ljava_lang_String_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Bdecode_node Dict_find_int_s (string key)
		{
			const string __id = "dict_find_int_s.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/bdecode_node;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_dict_find_int_value_s_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDict_find_int_value_s_Ljava_lang_String_Handler ()
		{
			if (cb_dict_find_int_value_s_Ljava_lang_String_ == null)
				cb_dict_find_int_value_s_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_Dict_find_int_value_s_Ljava_lang_String_);
			return cb_dict_find_int_value_s_Ljava_lang_String_;
		}

		static long n_Dict_find_int_value_s_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Dict_find_int_value_s (key);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='dict_find_int_value_s' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dict_find_int_value_s", "(Ljava/lang/String;)J", "GetDict_find_int_value_s_Ljava_lang_String_Handler")]
		public virtual unsafe long Dict_find_int_value_s (string key)
		{
			const string __id = "dict_find_int_value_s.(Ljava/lang/String;)J";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_dict_find_int_value_s_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetDict_find_int_value_s_Ljava_lang_String_JHandler ()
		{
			if (cb_dict_find_int_value_s_Ljava_lang_String_J == null)
				cb_dict_find_int_value_s_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long>) n_Dict_find_int_value_s_Ljava_lang_String_J);
			return cb_dict_find_int_value_s_Ljava_lang_String_J;
		}

		static long n_Dict_find_int_value_s_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_key, long default_val)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Dict_find_int_value_s (key, default_val);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='dict_find_int_value_s' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("dict_find_int_value_s", "(Ljava/lang/String;J)J", "GetDict_find_int_value_s_Ljava_lang_String_JHandler")]
		public virtual unsafe long Dict_find_int_value_s (string key, long default_val)
		{
			const string __id = "dict_find_int_value_s.(Ljava/lang/String;J)J";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (default_val);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_dict_find_list_s_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDict_find_list_s_Ljava_lang_String_Handler ()
		{
			if (cb_dict_find_list_s_Ljava_lang_String_ == null)
				cb_dict_find_list_s_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Dict_find_list_s_Ljava_lang_String_);
			return cb_dict_find_list_s_Ljava_lang_String_;
		}

		static IntPtr n_Dict_find_list_s_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Dict_find_list_s (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='dict_find_list_s' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dict_find_list_s", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/bdecode_node;", "GetDict_find_list_s_Ljava_lang_String_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Bdecode_node Dict_find_list_s (string key)
		{
			const string __id = "dict_find_list_s.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/bdecode_node;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_dict_find_s_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDict_find_s_Ljava_lang_String_Handler ()
		{
			if (cb_dict_find_s_Ljava_lang_String_ == null)
				cb_dict_find_s_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Dict_find_s_Ljava_lang_String_);
			return cb_dict_find_s_Ljava_lang_String_;
		}

		static IntPtr n_Dict_find_s_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Dict_find_s (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='dict_find_s' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dict_find_s", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/bdecode_node;", "GetDict_find_s_Ljava_lang_String_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Bdecode_node Dict_find_s (string key)
		{
			const string __id = "dict_find_s.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/bdecode_node;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_dict_find_string_s_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDict_find_string_s_Ljava_lang_String_Handler ()
		{
			if (cb_dict_find_string_s_Ljava_lang_String_ == null)
				cb_dict_find_string_s_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Dict_find_string_s_Ljava_lang_String_);
			return cb_dict_find_string_s_Ljava_lang_String_;
		}

		static IntPtr n_Dict_find_string_s_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Dict_find_string_s (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='dict_find_string_s' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dict_find_string_s", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/bdecode_node;", "GetDict_find_string_s_Ljava_lang_String_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Bdecode_node Dict_find_string_s (string key)
		{
			const string __id = "dict_find_string_s.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/bdecode_node;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_dict_find_string_value_s_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDict_find_string_value_s_Ljava_lang_String_Handler ()
		{
			if (cb_dict_find_string_value_s_Ljava_lang_String_ == null)
				cb_dict_find_string_value_s_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Dict_find_string_value_s_Ljava_lang_String_);
			return cb_dict_find_string_value_s_Ljava_lang_String_;
		}

		static IntPtr n_Dict_find_string_value_s_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Dict_find_string_value_s (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='dict_find_string_value_s' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("dict_find_string_value_s", "(Ljava/lang/String;)Ljava/lang/String;", "GetDict_find_string_value_s_Ljava_lang_String_Handler")]
		public virtual unsafe string Dict_find_string_value_s (string key)
		{
			const string __id = "dict_find_string_value_s.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_dict_find_string_value_s_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDict_find_string_value_s_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_dict_find_string_value_s_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_dict_find_string_value_s_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Dict_find_string_value_s_Ljava_lang_String_Ljava_lang_String_);
			return cb_dict_find_string_value_s_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Dict_find_string_value_s_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_default_value)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string default_value = JNIEnv.GetString (native_default_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Dict_find_string_value_s (key, default_value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='dict_find_string_value_s' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("dict_find_string_value_s", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetDict_find_string_value_s_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string Dict_find_string_value_s (string key, string default_value)
		{
			const string __id = "dict_find_string_value_s.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_default_value = JNIEnv.NewString (default_value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_default_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_default_value);
			}
		}

		static Delegate cb_dict_size;
#pragma warning disable 0169
		static Delegate GetDict_sizeHandler ()
		{
			if (cb_dict_size == null)
				cb_dict_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Dict_size);
			return cb_dict_size;
		}

		static int n_Dict_size (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Dict_size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='dict_size' and count(parameter)=0]"
		[Register ("dict_size", "()I", "GetDict_sizeHandler")]
		public virtual unsafe int Dict_size ()
		{
			const string __id = "dict_size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.bdecode_node']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/bdecode_node;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Bdecode_node obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/bdecode_node;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_int_value;
#pragma warning disable 0169
		static Delegate GetInt_valueHandler ()
		{
			if (cb_int_value == null)
				cb_int_value = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Int_value);
			return cb_int_value;
		}

		static long n_Int_value (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Int_value ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='int_value' and count(parameter)=0]"
		[Register ("int_value", "()J", "GetInt_valueHandler")]
		public virtual unsafe long Int_value ()
		{
			const string __id = "int_value.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_list_at_I;
#pragma warning disable 0169
		static Delegate GetList_at_IHandler ()
		{
			if (cb_list_at_I == null)
				cb_list_at_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_List_at_I);
			return cb_list_at_I;
		}

		static IntPtr n_List_at_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.List_at (i));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='list_at' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("list_at", "(I)Lcom/frostwire/jlibtorrent/swig/bdecode_node;", "GetList_at_IHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Bdecode_node List_at (int i)
		{
			const string __id = "list_at.(I)Lcom/frostwire/jlibtorrent/swig/bdecode_node;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_list_int_value_at_I;
#pragma warning disable 0169
		static Delegate GetList_int_value_at_IHandler ()
		{
			if (cb_list_int_value_at_I == null)
				cb_list_int_value_at_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_List_int_value_at_I);
			return cb_list_int_value_at_I;
		}

		static long n_List_int_value_at_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.List_int_value_at (i);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='list_int_value_at' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("list_int_value_at", "(I)J", "GetList_int_value_at_IHandler")]
		public virtual unsafe long List_int_value_at (int i)
		{
			const string __id = "list_int_value_at.(I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_list_int_value_at_IJ;
#pragma warning disable 0169
		static Delegate GetList_int_value_at_IJHandler ()
		{
			if (cb_list_int_value_at_IJ == null)
				cb_list_int_value_at_IJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long, long>) n_List_int_value_at_IJ);
			return cb_list_int_value_at_IJ;
		}

		static long n_List_int_value_at_IJ (IntPtr jnienv, IntPtr native__this, int i, long default_val)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.List_int_value_at (i, default_val);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='list_int_value_at' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("list_int_value_at", "(IJ)J", "GetList_int_value_at_IJHandler")]
		public virtual unsafe long List_int_value_at (int i, long default_val)
		{
			const string __id = "list_int_value_at.(IJ)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (i);
				__args [1] = new JniArgumentValue (default_val);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_list_size;
#pragma warning disable 0169
		static Delegate GetList_sizeHandler ()
		{
			if (cb_list_size == null)
				cb_list_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_List_size);
			return cb_list_size;
		}

		static int n_List_size (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.List_size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='list_size' and count(parameter)=0]"
		[Register ("list_size", "()I", "GetList_sizeHandler")]
		public virtual unsafe int List_size ()
		{
			const string __id = "list_size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_list_string_value_at_s_I;
#pragma warning disable 0169
		static Delegate GetList_string_value_at_s_IHandler ()
		{
			if (cb_list_string_value_at_s_I == null)
				cb_list_string_value_at_s_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_List_string_value_at_s_I);
			return cb_list_string_value_at_s_I;
		}

		static IntPtr n_List_string_value_at_s_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.List_string_value_at_s (i));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='list_string_value_at_s' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("list_string_value_at_s", "(I)Ljava/lang/String;", "GetList_string_value_at_s_IHandler")]
		public virtual unsafe string List_string_value_at_s (int i)
		{
			const string __id = "list_string_value_at_s.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_list_string_value_at_s_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetList_string_value_at_s_ILjava_lang_String_Handler ()
		{
			if (cb_list_string_value_at_s_ILjava_lang_String_ == null)
				cb_list_string_value_at_s_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_List_string_value_at_s_ILjava_lang_String_);
			return cb_list_string_value_at_s_ILjava_lang_String_;
		}

		static IntPtr n_List_string_value_at_s_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int i, IntPtr native_default_val)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string default_val = JNIEnv.GetString (native_default_val, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.List_string_value_at_s (i, default_val));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='list_string_value_at_s' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("list_string_value_at_s", "(ILjava/lang/String;)Ljava/lang/String;", "GetList_string_value_at_s_ILjava_lang_String_Handler")]
		public virtual unsafe string List_string_value_at_s (int i, string default_val)
		{
			const string __id = "list_string_value_at_s.(ILjava/lang/String;)Ljava/lang/String;";
			IntPtr native_default_val = JNIEnv.NewString (default_val);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (i);
				__args [1] = new JniArgumentValue (native_default_val);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_default_val);
			}
		}

		static Delegate cb_op_bool;
#pragma warning disable 0169
		static Delegate GetOp_boolHandler ()
		{
			if (cb_op_bool == null)
				cb_op_bool = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Op_bool);
			return cb_op_bool;
		}

		static bool n_Op_bool (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Op_bool ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='op_bool' and count(parameter)=0]"
		[Register ("op_bool", "()Z", "GetOp_boolHandler")]
		public virtual unsafe bool Op_bool ()
		{
			const string __id = "op_bool.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_string_length;
#pragma warning disable 0169
		static Delegate GetString_lengthHandler ()
		{
			if (cb_string_length == null)
				cb_string_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_String_length);
			return cb_string_length;
		}

		static int n_String_length (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.String_length ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='string_length' and count(parameter)=0]"
		[Register ("string_length", "()I", "GetString_lengthHandler")]
		public virtual unsafe int String_length ()
		{
			const string __id = "string_length.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_string_value_s;
#pragma warning disable 0169
		static Delegate GetString_value_sHandler ()
		{
			if (cb_string_value_s == null)
				cb_string_value_s = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_String_value_s);
			return cb_string_value_s;
		}

		static IntPtr n_String_value_s (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.String_value_s ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='string_value_s' and count(parameter)=0]"
		[Register ("string_value_s", "()Ljava/lang/String;", "GetString_value_sHandler")]
		public virtual unsafe string String_value_s ()
		{
			const string __id = "string_value_s.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='to_string' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.swig.bdecode_node'] and parameter[2][@type='boolean'] and parameter[3][@type='int']]"
		[Register ("to_string", "(Lcom/frostwire/jlibtorrent/swig/bdecode_node;ZI)Ljava/lang/String;", "")]
		public static unsafe string To_string (global::FrostWire.Libtorrent.Swig.Bdecode_node e, bool single_line, int indent)
		{
			const string __id = "to_string.(Lcom/frostwire/jlibtorrent/swig/bdecode_node;ZI)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue (single_line);
				__args [2] = new JniArgumentValue (indent);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_type;
#pragma warning disable 0169
		static Delegate GetTypeHandler ()
		{
			if (cb_type == null)
				cb_type = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Type);
			return cb_type;
		}

		static IntPtr n_Type (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Bdecode_node __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bdecode_node']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Lcom/frostwire/jlibtorrent/swig/bdecode_node$type_t;", "GetTypeHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Bdecode_node.Type_t Type ()
		{
			const string __id = "type.()Lcom/frostwire/jlibtorrent/swig/bdecode_node$type_t;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node.Type_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
