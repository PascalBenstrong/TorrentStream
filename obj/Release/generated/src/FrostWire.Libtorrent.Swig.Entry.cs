using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/entry", DoNotGenerateAcw=true)]
	public partial class Entry : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/field[@name='swigCMemOwn']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry.data_type']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/entry$data_type", DoNotGenerateAcw=true)]
		public sealed partial class Data_type : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry.data_type']/field[@name='dictionary_t']"
			[Register ("dictionary_t")]
			public static global::FrostWire.Libtorrent.Swig.Entry.Data_type DictionaryT {
				get {
					const string __id = "dictionary_t.Lcom/frostwire/jlibtorrent/swig/entry$data_type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry.Data_type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry.data_type']/field[@name='int_t']"
			[Register ("int_t")]
			public static global::FrostWire.Libtorrent.Swig.Entry.Data_type IntT {
				get {
					const string __id = "int_t.Lcom/frostwire/jlibtorrent/swig/entry$data_type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry.Data_type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry.data_type']/field[@name='list_t']"
			[Register ("list_t")]
			public static global::FrostWire.Libtorrent.Swig.Entry.Data_type ListT {
				get {
					const string __id = "list_t.Lcom/frostwire/jlibtorrent/swig/entry$data_type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry.Data_type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry.data_type']/field[@name='preformatted_t']"
			[Register ("preformatted_t")]
			public static global::FrostWire.Libtorrent.Swig.Entry.Data_type PreformattedT {
				get {
					const string __id = "preformatted_t.Lcom/frostwire/jlibtorrent/swig/entry$data_type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry.Data_type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry.data_type']/field[@name='string_t']"
			[Register ("string_t")]
			public static global::FrostWire.Libtorrent.Swig.Entry.Data_type StringT {
				get {
					const string __id = "string_t.Lcom/frostwire/jlibtorrent/swig/entry$data_type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry.Data_type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry.data_type']/field[@name='undefined_t']"
			[Register ("undefined_t")]
			public static global::FrostWire.Libtorrent.Swig.Entry.Data_type UndefinedT {
				get {
					const string __id = "undefined_t.Lcom/frostwire/jlibtorrent/swig/entry$data_type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry.Data_type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/entry$data_type", typeof (Data_type));
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

			internal Data_type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry.data_type']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/entry$data_type;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Entry.Data_type SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/entry$data_type;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry.Data_type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry.data_type']/method[@name='swigValue' and count(parameter)=0]"
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/entry", typeof (Entry));
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

		protected Entry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/constructor[@name='entry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Entry ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/constructor[@name='entry' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_const_span']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/byte_const_span;)V", "")]
		public unsafe Entry (global::FrostWire.Libtorrent.Swig.Byte_const_span arg0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/byte_const_span;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/constructor[@name='entry' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.entry']]"
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/constructor[@name='entry' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.entry.data_type']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/entry$data_type;)V", "")]
		public unsafe Entry (global::FrostWire.Libtorrent.Swig.Entry.Data_type t)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/entry$data_type;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Object) t).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/constructor[@name='entry' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.entry_vector']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/entry_vector;)V", "")]
		public unsafe Entry (global::FrostWire.Libtorrent.Swig.Entry_vector arg0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/entry_vector;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/constructor[@name='entry' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_entry_map']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/string_entry_map;)V", "")]
		public unsafe Entry (global::FrostWire.Libtorrent.Swig.String_entry_map arg0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/string_entry_map;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/constructor[@name='entry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Entry (string arg0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_arg0 = JNIEnv.NewString (arg0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_arg0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_arg0);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/constructor[@name='entry' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe Entry (long arg0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (arg0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/constructor[@name='entry' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Entry (long cPtr, bool cMemoryOwn)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='bdecode' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("bdecode", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)Lcom/frostwire/jlibtorrent/swig/entry;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Entry Bdecode (global::FrostWire.Libtorrent.Swig.Byte_vector buffer)
		{
			const string __id = "bdecode.(Lcom/frostwire/jlibtorrent/swig/byte_vector;)Lcom/frostwire/jlibtorrent/swig/entry;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_bencode;
#pragma warning disable 0169
		static Delegate GetBencodeHandler ()
		{
			if (cb_bencode == null)
				cb_bencode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Bencode);
			return cb_bencode;
		}

		static IntPtr n_Bencode (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bencode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='bencode' and count(parameter)=0]"
		[Register ("bencode", "()Lcom/frostwire/jlibtorrent/swig/byte_vector;", "GetBencodeHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Bencode ()
		{
			const string __id = "bencode.()Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::FrostWire.Libtorrent.Swig.Entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_dict;
#pragma warning disable 0169
		static Delegate GetDictHandler ()
		{
			if (cb_dict == null)
				cb_dict = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Dict);
			return cb_dict;
		}

		static IntPtr n_Dict (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Dict ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='dict' and count(parameter)=0]"
		[Register ("dict", "()Lcom/frostwire/jlibtorrent/swig/string_entry_map;", "GetDictHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.String_entry_map Dict ()
		{
			const string __id = "dict.()Lcom/frostwire/jlibtorrent/swig/string_entry_map;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_entry_map> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_find_key_Lcom_frostwire_jlibtorrent_swig_string_view_;
#pragma warning disable 0169
		static Delegate GetFind_key_Lcom_frostwire_jlibtorrent_swig_string_view_Handler ()
		{
			if (cb_find_key_Lcom_frostwire_jlibtorrent_swig_string_view_ == null)
				cb_find_key_Lcom_frostwire_jlibtorrent_swig_string_view_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Find_key_Lcom_frostwire_jlibtorrent_swig_string_view_);
			return cb_find_key_Lcom_frostwire_jlibtorrent_swig_string_view_;
		}

		static IntPtr n_Find_key_Lcom_frostwire_jlibtorrent_swig_string_view_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::FrostWire.Libtorrent.Swig.Entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_view key = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_view> (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Find_key (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='find_key' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_view']]"
		[Register ("find_key", "(Lcom/frostwire/jlibtorrent/swig/string_view;)Lcom/frostwire/jlibtorrent/swig/entry;", "GetFind_key_Lcom_frostwire_jlibtorrent_swig_string_view_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Entry Find_key (global::FrostWire.Libtorrent.Swig.String_view key)
		{
			const string __id = "find_key.(Lcom/frostwire/jlibtorrent/swig/string_view;)Lcom/frostwire/jlibtorrent/swig/entry;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='from_preformatted_bytes' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("from_preformatted_bytes", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)Lcom/frostwire/jlibtorrent/swig/entry;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Entry From_preformatted_bytes (global::FrostWire.Libtorrent.Swig.Byte_vector preformatted_bytes)
		{
			const string __id = "from_preformatted_bytes.(Lcom/frostwire/jlibtorrent/swig/byte_vector;)Lcom/frostwire/jlibtorrent/swig/entry;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((preformatted_bytes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) preformatted_bytes).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='from_string_bytes' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("from_string_bytes", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)Lcom/frostwire/jlibtorrent/swig/entry;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Entry From_string_bytes (global::FrostWire.Libtorrent.Swig.Byte_vector string_bytes)
		{
			const string __id = "from_string_bytes.(Lcom/frostwire/jlibtorrent/swig/byte_vector;)Lcom/frostwire/jlibtorrent/swig/entry;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((string_bytes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) string_bytes).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::FrostWire.Libtorrent.Swig.Entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/entry;", "GetGet_Ljava_lang_String_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Entry Get (string key)
		{
			const string __id = "get.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/entry;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.entry']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/entry;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Entry obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/entry;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_integer;
#pragma warning disable 0169
		static Delegate GetIntegerHandler ()
		{
			if (cb_integer == null)
				cb_integer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Integer);
			return cb_integer;
		}

		static long n_Integer (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Integer ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='integer' and count(parameter)=0]"
		[Register ("integer", "()J", "GetIntegerHandler")]
		public virtual unsafe long Integer ()
		{
			const string __id = "integer.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_list;
#pragma warning disable 0169
		static Delegate GetListHandler ()
		{
			if (cb_list == null)
				cb_list = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_List);
			return cb_list;
		}

		static IntPtr n_List (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.List ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='list' and count(parameter)=0]"
		[Register ("list", "()Lcom/frostwire/jlibtorrent/swig/entry_vector;", "GetListHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Entry_vector List ()
		{
			const string __id = "list.()Lcom/frostwire/jlibtorrent/swig/entry_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_preformatted_bytes;
#pragma warning disable 0169
		static Delegate GetPreformatted_bytesHandler ()
		{
			if (cb_preformatted_bytes == null)
				cb_preformatted_bytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Preformatted_bytes);
			return cb_preformatted_bytes;
		}

		static IntPtr n_Preformatted_bytes (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Preformatted_bytes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='preformatted_bytes' and count(parameter)=0]"
		[Register ("preformatted_bytes", "()Lcom/frostwire/jlibtorrent/swig/byte_vector;", "GetPreformatted_bytesHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Preformatted_bytes ()
		{
			const string __id = "preformatted_bytes.()Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_set_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler ()
		{
			if (cb_set_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_byte_vector_ == null)
				cb_set_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_byte_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_byte_vector_);
			return cb_set_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
		}

		static void n_Set_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_byte_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Set (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("set", "(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/byte_vector;)V", "GetSet_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler")]
		public virtual unsafe void Set (string key, global::FrostWire.Libtorrent.Swig.Byte_vector value)
		{
			const string __id = "set.(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/byte_vector;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_set_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_entry_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_entry_Handler ()
		{
			if (cb_set_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_entry_ == null)
				cb_set_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_entry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_entry_);
			return cb_set_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_entry_;
		}

		static void n_Set_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Entry value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Set (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.entry']]"
		[Register ("set", "(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/entry;)V", "GetSet_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_entry_Handler")]
		public virtual unsafe void Set (string key, global::FrostWire.Libtorrent.Swig.Entry value)
		{
			const string __id = "set.(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/entry;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_set_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_set_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_set_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_String_Ljava_lang_String_);
			return cb_set_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Set_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Set (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("set", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSet_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Set (string key, string value)
		{
			const string __id = "set.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_set_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_String_JHandler ()
		{
			if (cb_set_Ljava_lang_String_J == null)
				cb_set_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_Set_Ljava_lang_String_J);
			return cb_set_Ljava_lang_String_J;
		}

		static void n_Set_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_key, long value)
		{
			global::FrostWire.Libtorrent.Swig.Entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.Set (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("set", "(Ljava/lang/String;J)V", "GetSet_Ljava_lang_String_JHandler")]
		public virtual unsafe void Set (string key, long value)
		{
			const string __id = "set.(Ljava/lang/String;J)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_string;
#pragma warning disable 0169
		static Delegate GetStringHandler ()
		{
			if (cb_string == null)
				cb_string = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_String);
			return cb_string;
		}

		static IntPtr n_String (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.String ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='string' and count(parameter)=0]"
		[Register ("string", "()Ljava/lang/String;", "GetStringHandler")]
		public virtual unsafe string String ()
		{
			const string __id = "string.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_string_bytes;
#pragma warning disable 0169
		static Delegate GetString_bytesHandler ()
		{
			if (cb_string_bytes == null)
				cb_string_bytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_String_bytes);
			return cb_string_bytes;
		}

		static IntPtr n_String_bytes (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.String_bytes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='string_bytes' and count(parameter)=0]"
		[Register ("string_bytes", "()Lcom/frostwire/jlibtorrent/swig/byte_vector;", "GetString_bytesHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_vector String_bytes ()
		{
			const string __id = "string_bytes.()Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_to_string;
#pragma warning disable 0169
		static Delegate GetTo_stringHandler ()
		{
			if (cb_to_string == null)
				cb_to_string = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_To_string);
			return cb_to_string;
		}

		static IntPtr n_To_string (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.To_string ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='to_string' and count(parameter)=0]"
		[Register ("to_string", "()Ljava/lang/String;", "GetTo_stringHandler")]
		public virtual unsafe string To_string ()
		{
			const string __id = "to_string.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
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
			global::FrostWire.Libtorrent.Swig.Entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='entry']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Lcom/frostwire/jlibtorrent/swig/entry$data_type;", "GetTypeHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Entry.Data_type Type ()
		{
			const string __id = "type.()Lcom/frostwire/jlibtorrent/swig/entry$data_type;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry.Data_type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
