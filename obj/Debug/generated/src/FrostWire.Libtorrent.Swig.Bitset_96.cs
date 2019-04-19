using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bitset_96']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/bitset_96", DoNotGenerateAcw=true)]
	public partial class Bitset_96 : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bitset_96']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/bitset_96", typeof (Bitset_96));
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

		protected Bitset_96 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bitset_96']/constructor[@name='bitset_96' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Bitset_96 ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bitset_96']/constructor[@name='bitset_96' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Bitset_96 (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_all;
#pragma warning disable 0169
		static Delegate GetAllHandler ()
		{
			if (cb_all == null)
				cb_all = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_All);
			return cb_all;
		}

		static bool n_All (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Bitset_96 __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bitset_96> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.All ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bitset_96']/method[@name='all' and count(parameter)=0]"
		[Register ("all", "()Z", "GetAllHandler")]
		public virtual unsafe bool All ()
		{
			const string __id = "all.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_any;
#pragma warning disable 0169
		static Delegate GetAnyHandler ()
		{
			if (cb_any == null)
				cb_any = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Any);
			return cb_any;
		}

		static bool n_Any (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Bitset_96 __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bitset_96> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Any ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bitset_96']/method[@name='any' and count(parameter)=0]"
		[Register ("any", "()Z", "GetAnyHandler")]
		public virtual unsafe bool Any ()
		{
			const string __id = "any.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_count;
#pragma warning disable 0169
		static Delegate GetCountHandler ()
		{
			if (cb_count == null)
				cb_count = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Count);
			return cb_count;
		}

		static long n_Count (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Bitset_96 __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bitset_96> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bitset_96']/method[@name='count' and count(parameter)=0]"
		[Register ("count", "()J", "GetCountHandler")]
		public virtual unsafe long Count ()
		{
			const string __id = "count.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
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
			global::FrostWire.Libtorrent.Swig.Bitset_96 __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bitset_96> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bitset_96']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_get_J;
#pragma warning disable 0169
		static Delegate GetGet_JHandler ()
		{
			if (cb_get_J == null)
				cb_get_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_Get_J);
			return cb_get_J;
		}

		static bool n_Get_J (IntPtr jnienv, IntPtr native__this, long pos)
		{
			global::FrostWire.Libtorrent.Swig.Bitset_96 __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bitset_96> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get (pos);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bitset_96']/method[@name='get' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("get", "(J)Z", "GetGet_JHandler")]
		public virtual unsafe bool Get (long pos)
		{
			const string __id = "get.(J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pos);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bitset_96']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.bitset_96']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/bitset_96;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Bitset_96 obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/bitset_96;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_none;
#pragma warning disable 0169
		static Delegate GetNoneHandler ()
		{
			if (cb_none == null)
				cb_none = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_None);
			return cb_none;
		}

		static bool n_None (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Bitset_96 __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bitset_96> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.None ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bitset_96']/method[@name='none' and count(parameter)=0]"
		[Register ("none", "()Z", "GetNoneHandler")]
		public virtual unsafe bool None ()
		{
			const string __id = "none.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
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
			global::FrostWire.Libtorrent.Swig.Bitset_96 __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bitset_96> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bitset_96']/method[@name='size' and count(parameter)=0]"
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

		static Delegate cb_test_J;
#pragma warning disable 0169
		static Delegate GetTest_JHandler ()
		{
			if (cb_test_J == null)
				cb_test_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_Test_J);
			return cb_test_J;
		}

		static bool n_Test_J (IntPtr jnienv, IntPtr native__this, long pos)
		{
			global::FrostWire.Libtorrent.Swig.Bitset_96 __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bitset_96> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Test (pos);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='bitset_96']/method[@name='test' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("test", "(J)Z", "GetTest_JHandler")]
		public virtual unsafe bool Test (long pos)
		{
			const string __id = "test.(J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pos);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
