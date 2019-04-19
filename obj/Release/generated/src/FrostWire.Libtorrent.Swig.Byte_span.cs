using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='byte_span']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/byte_span", DoNotGenerateAcw=true)]
	public partial class Byte_span : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='byte_span']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/byte_span", typeof (Byte_span));
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

		protected Byte_span (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='byte_span']/constructor[@name='byte_span' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Byte_span ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='byte_span']/constructor[@name='byte_span' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Byte_span (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_back;
#pragma warning disable 0169
		static Delegate GetBackHandler ()
		{
			if (cb_back == null)
				cb_back = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_Back);
			return cb_back;
		}

		static sbyte n_Back (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Byte_span __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_span> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Back ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='byte_span']/method[@name='back' and count(parameter)=0]"
		[Register ("back", "()B", "GetBackHandler")]
		public virtual unsafe sbyte Back ()
		{
			const string __id = "back.()B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, null);
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
			global::FrostWire.Libtorrent.Swig.Byte_span __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_span> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='byte_span']/method[@name='delete' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.Swig.Byte_span __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_span> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Empty ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='byte_span']/method[@name='empty' and count(parameter)=0]"
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

		static Delegate cb_first_J;
#pragma warning disable 0169
		static Delegate GetFirst_JHandler ()
		{
			if (cb_first_J == null)
				cb_first_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_First_J);
			return cb_first_J;
		}

		static IntPtr n_First_J (IntPtr jnienv, IntPtr native__this, long n)
		{
			global::FrostWire.Libtorrent.Swig.Byte_span __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_span> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.First (n));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='byte_span']/method[@name='first' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("first", "(J)Lcom/frostwire/jlibtorrent/swig/byte_span;", "GetFirst_JHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_span First (long n)
		{
			const string __id = "first.(J)Lcom/frostwire/jlibtorrent/swig/byte_span;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (n);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_span> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_front;
#pragma warning disable 0169
		static Delegate GetFrontHandler ()
		{
			if (cb_front == null)
				cb_front = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_Front);
			return cb_front;
		}

		static sbyte n_Front (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Byte_span __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_span> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Front ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='byte_span']/method[@name='front' and count(parameter)=0]"
		[Register ("front", "()B", "GetFrontHandler")]
		public virtual unsafe sbyte Front ()
		{
			const string __id = "front.()B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_J;
#pragma warning disable 0169
		static Delegate GetGet_JHandler ()
		{
			if (cb_get_J == null)
				cb_get_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, sbyte>) n_Get_J);
			return cb_get_J;
		}

		static sbyte n_Get_J (IntPtr jnienv, IntPtr native__this, long idx)
		{
			global::FrostWire.Libtorrent.Swig.Byte_span __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_span> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get (idx);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='byte_span']/method[@name='get' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("get", "(J)B", "GetGet_JHandler")]
		public virtual unsafe sbyte Get (long idx)
		{
			const string __id = "get.(J)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (idx);
				var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='byte_span']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_span']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/byte_span;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Byte_span obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/byte_span;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_last_J;
#pragma warning disable 0169
		static Delegate GetLast_JHandler ()
		{
			if (cb_last_J == null)
				cb_last_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Last_J);
			return cb_last_J;
		}

		static IntPtr n_Last_J (IntPtr jnienv, IntPtr native__this, long n)
		{
			global::FrostWire.Libtorrent.Swig.Byte_span __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_span> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Last (n));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='byte_span']/method[@name='last' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("last", "(J)Lcom/frostwire/jlibtorrent/swig/byte_span;", "GetLast_JHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_span Last (long n)
		{
			const string __id = "last.(J)Lcom/frostwire/jlibtorrent/swig/byte_span;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (n);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_span> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_set_JB;
#pragma warning disable 0169
		static Delegate GetSet_JBHandler ()
		{
			if (cb_set_JB == null)
				cb_set_JB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, sbyte>) n_Set_JB);
			return cb_set_JB;
		}

		static void n_Set_JB (IntPtr jnienv, IntPtr native__this, long idx, sbyte val)
		{
			global::FrostWire.Libtorrent.Swig.Byte_span __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_span> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set (idx, val);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='byte_span']/method[@name='set' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='byte']]"
		[Register ("set", "(JB)V", "GetSet_JBHandler")]
		public virtual unsafe void Set (long idx, sbyte val)
		{
			const string __id = "set.(JB)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (idx);
				__args [1] = new JniArgumentValue (val);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Size);
			return cb_size;
		}

		static long n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Byte_span __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_span> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='byte_span']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()J", "GetSizeHandler")]
		public virtual unsafe long Size ()
		{
			const string __id = "size.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_subspan_J;
#pragma warning disable 0169
		static Delegate GetSubspan_JHandler ()
		{
			if (cb_subspan_J == null)
				cb_subspan_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Subspan_J);
			return cb_subspan_J;
		}

		static IntPtr n_Subspan_J (IntPtr jnienv, IntPtr native__this, long offset)
		{
			global::FrostWire.Libtorrent.Swig.Byte_span __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_span> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Subspan (offset));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='byte_span']/method[@name='subspan' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("subspan", "(J)Lcom/frostwire/jlibtorrent/swig/byte_span;", "GetSubspan_JHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_span Subspan (long offset)
		{
			const string __id = "subspan.(J)Lcom/frostwire/jlibtorrent/swig/byte_span;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_span> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_subspan_JJ;
#pragma warning disable 0169
		static Delegate GetSubspan_JJHandler ()
		{
			if (cb_subspan_JJ == null)
				cb_subspan_JJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, IntPtr>) n_Subspan_JJ);
			return cb_subspan_JJ;
		}

		static IntPtr n_Subspan_JJ (IntPtr jnienv, IntPtr native__this, long offset, long count)
		{
			global::FrostWire.Libtorrent.Swig.Byte_span __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_span> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Subspan (offset, count));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='byte_span']/method[@name='subspan' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("subspan", "(JJ)Lcom/frostwire/jlibtorrent/swig/byte_span;", "GetSubspan_JJHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_span Subspan (long offset, long count)
		{
			const string __id = "subspan.(JJ)Lcom/frostwire/jlibtorrent/swig/byte_span;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (offset);
				__args [1] = new JniArgumentValue (count);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_span> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
