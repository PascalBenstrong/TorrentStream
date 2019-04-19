using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_stat_t']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/posix_stat_t", DoNotGenerateAcw=true)]
	public partial class Posix_stat_t : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_stat_t']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/posix_stat_t", typeof (Posix_stat_t));
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

		protected Posix_stat_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_stat_t']/constructor[@name='posix_stat_t' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Posix_stat_t ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_stat_t']/constructor[@name='posix_stat_t' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Posix_stat_t (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getAtime;
#pragma warning disable 0169
		static Delegate GetGetAtimeHandler ()
		{
			if (cb_getAtime == null)
				cb_getAtime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAtime);
			return cb_getAtime;
		}

		static long n_GetAtime (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Posix_stat_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_stat_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Atime;
		}
#pragma warning restore 0169

		static Delegate cb_setAtime_J;
#pragma warning disable 0169
		static Delegate GetSetAtime_JHandler ()
		{
			if (cb_setAtime_J == null)
				cb_setAtime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetAtime_J);
			return cb_setAtime_J;
		}

		static void n_SetAtime_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Posix_stat_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_stat_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Atime = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Atime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_stat_t']/method[@name='getAtime' and count(parameter)=0]"
			[Register ("getAtime", "()J", "GetGetAtimeHandler")]
			get {
				const string __id = "getAtime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_stat_t']/method[@name='setAtime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setAtime", "(J)V", "GetSetAtime_JHandler")]
			set {
				const string __id = "setAtime.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCtime;
#pragma warning disable 0169
		static Delegate GetGetCtimeHandler ()
		{
			if (cb_getCtime == null)
				cb_getCtime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCtime);
			return cb_getCtime;
		}

		static long n_GetCtime (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Posix_stat_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_stat_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ctime;
		}
#pragma warning restore 0169

		static Delegate cb_setCtime_J;
#pragma warning disable 0169
		static Delegate GetSetCtime_JHandler ()
		{
			if (cb_setCtime_J == null)
				cb_setCtime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetCtime_J);
			return cb_setCtime_J;
		}

		static void n_SetCtime_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Posix_stat_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_stat_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Ctime = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Ctime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_stat_t']/method[@name='getCtime' and count(parameter)=0]"
			[Register ("getCtime", "()J", "GetGetCtimeHandler")]
			get {
				const string __id = "getCtime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_stat_t']/method[@name='setCtime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setCtime", "(J)V", "GetSetCtime_JHandler")]
			set {
				const string __id = "setCtime.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMode;
#pragma warning disable 0169
		static Delegate GetGetModeHandler ()
		{
			if (cb_getMode == null)
				cb_getMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMode);
			return cb_getMode;
		}

		static int n_GetMode (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Posix_stat_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_stat_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Mode;
		}
#pragma warning restore 0169

		static Delegate cb_setMode_I;
#pragma warning disable 0169
		static Delegate GetSetMode_IHandler ()
		{
			if (cb_setMode_I == null)
				cb_setMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMode_I);
			return cb_setMode_I;
		}

		static void n_SetMode_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Posix_stat_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_stat_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Mode = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_stat_t']/method[@name='getMode' and count(parameter)=0]"
			[Register ("getMode", "()I", "GetGetModeHandler")]
			get {
				const string __id = "getMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_stat_t']/method[@name='setMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMode", "(I)V", "GetSetMode_IHandler")]
			set {
				const string __id = "setMode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMtime;
#pragma warning disable 0169
		static Delegate GetGetMtimeHandler ()
		{
			if (cb_getMtime == null)
				cb_getMtime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMtime);
			return cb_getMtime;
		}

		static long n_GetMtime (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Posix_stat_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_stat_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Mtime;
		}
#pragma warning restore 0169

		static Delegate cb_setMtime_J;
#pragma warning disable 0169
		static Delegate GetSetMtime_JHandler ()
		{
			if (cb_setMtime_J == null)
				cb_setMtime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMtime_J);
			return cb_setMtime_J;
		}

		static void n_SetMtime_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Posix_stat_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_stat_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Mtime = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Mtime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_stat_t']/method[@name='getMtime' and count(parameter)=0]"
			[Register ("getMtime", "()J", "GetGetMtimeHandler")]
			get {
				const string __id = "getMtime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_stat_t']/method[@name='setMtime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMtime", "(J)V", "GetSetMtime_JHandler")]
			set {
				const string __id = "setMtime.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetSize);
			return cb_getSize;
		}

		static long n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Posix_stat_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_stat_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		static Delegate cb_setSize_J;
#pragma warning disable 0169
		static Delegate GetSetSize_JHandler ()
		{
			if (cb_setSize_J == null)
				cb_setSize_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetSize_J);
			return cb_setSize_J;
		}

		static void n_SetSize_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Posix_stat_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_stat_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Size = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_stat_t']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()J", "GetGetSizeHandler")]
			get {
				const string __id = "getSize.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_stat_t']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setSize", "(J)V", "GetSetSize_JHandler")]
			set {
				const string __id = "setSize.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::FrostWire.Libtorrent.Swig.Posix_stat_t __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Posix_stat_t> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_stat_t']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='posix_stat_t']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.posix_stat_t']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/posix_stat_t;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Posix_stat_t obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/posix_stat_t;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
