using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/piece_index_bitfield", DoNotGenerateAcw=true)]
	public partial class Piece_index_bitfield : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/piece_index_bitfield", typeof (Piece_index_bitfield));
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

		protected Piece_index_bitfield (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/constructor[@name='piece_index_bitfield' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Piece_index_bitfield ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/constructor[@name='piece_index_bitfield' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.piece_index_bitfield']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;)V", "")]
		public unsafe Piece_index_bitfield (global::FrostWire.Libtorrent.Swig.Piece_index_bitfield rhs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((rhs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rhs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/constructor[@name='piece_index_bitfield' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe Piece_index_bitfield (int bits)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bits);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/constructor[@name='piece_index_bitfield' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(IZ)V", "")]
		public unsafe Piece_index_bitfield (int bits, bool val)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (bits);
				__args [1] = new JniArgumentValue (val);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/constructor[@name='piece_index_bitfield' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Piece_index_bitfield (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_all_set;
#pragma warning disable 0169
		static Delegate GetAll_setHandler ()
		{
			if (cb_all_set == null)
				cb_all_set = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_All_set);
			return cb_all_set;
		}

		static bool n_All_set (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.All_set ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='all_set' and count(parameter)=0]"
		[Register ("all_set", "()Z", "GetAll_setHandler")]
		public virtual unsafe bool All_set ()
		{
			const string __id = "all_set.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
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
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clear_all;
#pragma warning disable 0169
		static Delegate GetClear_allHandler ()
		{
			if (cb_clear_all == null)
				cb_clear_all = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear_all);
			return cb_clear_all;
		}

		static void n_Clear_all (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear_all ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='clear_all' and count(parameter)=0]"
		[Register ("clear_all", "()V", "GetClear_allHandler")]
		public virtual unsafe void Clear_all ()
		{
			const string __id = "clear_all.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clear_bit_I;
#pragma warning disable 0169
		static Delegate GetClear_bit_IHandler ()
		{
			if (cb_clear_bit_I == null)
				cb_clear_bit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Clear_bit_I);
			return cb_clear_bit_I;
		}

		static void n_Clear_bit_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear_bit (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='clear_bit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("clear_bit", "(I)V", "GetClear_bit_IHandler")]
		public virtual unsafe void Clear_bit (int index)
		{
			const string __id = "clear_bit.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_count;
#pragma warning disable 0169
		static Delegate GetCountHandler ()
		{
			if (cb_count == null)
				cb_count = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Count);
			return cb_count;
		}

		static int n_Count (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='count' and count(parameter)=0]"
		[Register ("count", "()I", "GetCountHandler")]
		public virtual unsafe int Count ()
		{
			const string __id = "count.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
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
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_empty;
#pragma warning disable 0169
		static Delegate GetEmptyHandler ()
		{
			if (cb_empty == null)
				cb_empty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Empty);
			return cb_empty;
		}

		static bool n_Empty (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Empty ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='empty' and count(parameter)=0]"
		[Register ("empty", "()Z", "GetEmptyHandler")]
		public virtual unsafe bool Empty ()
		{
			const string __id = "empty.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_end_index;
#pragma warning disable 0169
		static Delegate GetEnd_indexHandler ()
		{
			if (cb_end_index == null)
				cb_end_index = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_End_index);
			return cb_end_index;
		}

		static int n_End_index (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.End_index ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='end_index' and count(parameter)=0]"
		[Register ("end_index", "()I", "GetEnd_indexHandler")]
		public virtual unsafe int End_index ()
		{
			const string __id = "end_index.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_find_first_set;
#pragma warning disable 0169
		static Delegate GetFind_first_setHandler ()
		{
			if (cb_find_first_set == null)
				cb_find_first_set = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Find_first_set);
			return cb_find_first_set;
		}

		static int n_Find_first_set (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Find_first_set ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='find_first_set' and count(parameter)=0]"
		[Register ("find_first_set", "()I", "GetFind_first_setHandler")]
		public virtual unsafe int Find_first_set ()
		{
			const string __id = "find_first_set.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_find_last_clear;
#pragma warning disable 0169
		static Delegate GetFind_last_clearHandler ()
		{
			if (cb_find_last_clear == null)
				cb_find_last_clear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Find_last_clear);
			return cb_find_last_clear;
		}

		static int n_Find_last_clear (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Find_last_clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='find_last_clear' and count(parameter)=0]"
		[Register ("find_last_clear", "()I", "GetFind_last_clearHandler")]
		public virtual unsafe int Find_last_clear ()
		{
			const string __id = "find_last_clear.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.piece_index_bitfield']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Piece_index_bitfield obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_bit_I;
#pragma warning disable 0169
		static Delegate GetGet_bit_IHandler ()
		{
			if (cb_get_bit_I == null)
				cb_get_bit_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Get_bit_I);
			return cb_get_bit_I;
		}

		static bool n_Get_bit_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_bit (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='get_bit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get_bit", "(I)Z", "GetGet_bit_IHandler")]
		public virtual unsafe bool Get_bit (int index)
		{
			const string __id = "get_bit.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_none_set;
#pragma warning disable 0169
		static Delegate GetNone_setHandler ()
		{
			if (cb_none_set == null)
				cb_none_set = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_None_set);
			return cb_none_set;
		}

		static bool n_None_set (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.None_set ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='none_set' and count(parameter)=0]"
		[Register ("none_set", "()Z", "GetNone_setHandler")]
		public virtual unsafe bool None_set ()
		{
			const string __id = "none_set.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_num_words;
#pragma warning disable 0169
		static Delegate GetNum_wordsHandler ()
		{
			if (cb_num_words == null)
				cb_num_words = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Num_words);
			return cb_num_words;
		}

		static int n_Num_words (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_words ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='num_words' and count(parameter)=0]"
		[Register ("num_words", "()I", "GetNum_wordsHandler")]
		public virtual unsafe int Num_words ()
		{
			const string __id = "num_words.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_resize_I;
#pragma warning disable 0169
		static Delegate GetResize_IHandler ()
		{
			if (cb_resize_I == null)
				cb_resize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Resize_I);
			return cb_resize_I;
		}

		static void n_Resize_I (IntPtr jnienv, IntPtr native__this, int bits)
		{
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resize (bits);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='resize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("resize", "(I)V", "GetResize_IHandler")]
		public virtual unsafe void Resize (int bits)
		{
			const string __id = "resize.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bits);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_resize_IZ;
#pragma warning disable 0169
		static Delegate GetResize_IZHandler ()
		{
			if (cb_resize_IZ == null)
				cb_resize_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_Resize_IZ);
			return cb_resize_IZ;
		}

		static void n_Resize_IZ (IntPtr jnienv, IntPtr native__this, int bits, bool val)
		{
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resize (bits, val);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='resize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("resize", "(IZ)V", "GetResize_IZHandler")]
		public virtual unsafe void Resize (int bits, bool val)
		{
			const string __id = "resize.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (bits);
				__args [1] = new JniArgumentValue (val);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_all;
#pragma warning disable 0169
		static Delegate GetSet_allHandler ()
		{
			if (cb_set_all == null)
				cb_set_all = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Set_all);
			return cb_set_all;
		}

		static void n_Set_all (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_all ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='set_all' and count(parameter)=0]"
		[Register ("set_all", "()V", "GetSet_allHandler")]
		public virtual unsafe void Set_all ()
		{
			const string __id = "set_all.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_set_bit_I;
#pragma warning disable 0169
		static Delegate GetSet_bit_IHandler ()
		{
			if (cb_set_bit_I == null)
				cb_set_bit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Set_bit_I);
			return cb_set_bit_I;
		}

		static void n_Set_bit_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_bit (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='set_bit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("set_bit", "(I)V", "GetSet_bit_IHandler")]
		public virtual unsafe void Set_bit (int index)
		{
			const string __id = "set_bit.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='piece_index_bitfield']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
