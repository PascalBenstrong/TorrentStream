using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='port_mapping_t_vector']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/port_mapping_t_vector", DoNotGenerateAcw=true)]
	public partial class Port_mapping_t_vector : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='port_mapping_t_vector']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/port_mapping_t_vector", typeof (Port_mapping_t_vector));
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

		protected Port_mapping_t_vector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='port_mapping_t_vector']/constructor[@name='port_mapping_t_vector' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Port_mapping_t_vector ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='port_mapping_t_vector']/constructor[@name='port_mapping_t_vector' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Port_mapping_t_vector (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_capacity;
#pragma warning disable 0169
		static Delegate GetCapacityHandler ()
		{
			if (cb_capacity == null)
				cb_capacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Capacity);
			return cb_capacity;
		}

		static long n_Capacity (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Capacity ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='port_mapping_t_vector']/method[@name='capacity' and count(parameter)=0]"
		[Register ("capacity", "()J", "GetCapacityHandler")]
		public virtual unsafe long Capacity ()
		{
			const string __id = "capacity.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
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
			global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='port_mapping_t_vector']/method[@name='clear' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='port_mapping_t_vector']/method[@name='delete' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Empty ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='port_mapping_t_vector']/method[@name='empty' and count(parameter)=0]"
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

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_Get_I);
			return cb_get_I;
		}

		static int n_Get_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get (i);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='port_mapping_t_vector']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)I", "GetGet_IHandler")]
		public virtual unsafe int Get (int i)
		{
			const string __id = "get.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='port_mapping_t_vector']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.port_mapping_t_vector']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/port_mapping_t_vector;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/port_mapping_t_vector;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_push_back_I;
#pragma warning disable 0169
		static Delegate GetPush_back_IHandler ()
		{
			if (cb_push_back_I == null)
				cb_push_back_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Push_back_I);
			return cb_push_back_I;
		}

		static void n_Push_back_I (IntPtr jnienv, IntPtr native__this, int x)
		{
			global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Push_back (x);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='port_mapping_t_vector']/method[@name='push_back' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("push_back", "(I)V", "GetPush_back_IHandler")]
		public virtual unsafe void Push_back (int x)
		{
			const string __id = "push_back.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (x);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reserve_J;
#pragma warning disable 0169
		static Delegate GetReserve_JHandler ()
		{
			if (cb_reserve_J == null)
				cb_reserve_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Reserve_J);
			return cb_reserve_J;
		}

		static void n_Reserve_J (IntPtr jnienv, IntPtr native__this, long n)
		{
			global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reserve (n);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='port_mapping_t_vector']/method[@name='reserve' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("reserve", "(J)V", "GetReserve_JHandler")]
		public virtual unsafe void Reserve (long n)
		{
			const string __id = "reserve.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (n);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_II;
#pragma warning disable 0169
		static Delegate GetSet_IIHandler ()
		{
			if (cb_set_II == null)
				cb_set_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_Set_II);
			return cb_set_II;
		}

		static void n_Set_II (IntPtr jnienv, IntPtr native__this, int i, int val)
		{
			global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set (i, val);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='port_mapping_t_vector']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("set", "(II)V", "GetSet_IIHandler")]
		public virtual unsafe void Set (int i, int val)
		{
			const string __id = "set.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (i);
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
			global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Port_mapping_t_vector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='port_mapping_t_vector']/method[@name='size' and count(parameter)=0]"
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

	}
}
