using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_slice']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/file_slice", DoNotGenerateAcw=true)]
	public partial class File_slice : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_slice']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/file_slice", typeof (File_slice));
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

		protected File_slice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_slice']/constructor[@name='file_slice' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe File_slice ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_slice']/constructor[@name='file_slice' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe File_slice (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getFile_index;
#pragma warning disable 0169
		static Delegate GetGetFile_indexHandler ()
		{
			if (cb_getFile_index == null)
				cb_getFile_index = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFile_index);
			return cb_getFile_index;
		}

		static int n_GetFile_index (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.File_slice __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_slice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.File_index;
		}
#pragma warning restore 0169

		static Delegate cb_setFile_index_I;
#pragma warning disable 0169
		static Delegate GetSetFile_index_IHandler ()
		{
			if (cb_setFile_index_I == null)
				cb_setFile_index_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFile_index_I);
			return cb_setFile_index_I;
		}

		static void n_SetFile_index_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.File_slice __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_slice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.File_index = value;
		}
#pragma warning restore 0169

		public virtual unsafe int File_index {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_slice']/method[@name='getFile_index' and count(parameter)=0]"
			[Register ("getFile_index", "()I", "GetGetFile_indexHandler")]
			get {
				const string __id = "getFile_index.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_slice']/method[@name='setFile_index' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFile_index", "(I)V", "GetSetFile_index_IHandler")]
			set {
				const string __id = "setFile_index.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOffset;
#pragma warning disable 0169
		static Delegate GetGetOffsetHandler ()
		{
			if (cb_getOffset == null)
				cb_getOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetOffset);
			return cb_getOffset;
		}

		static long n_GetOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.File_slice __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_slice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Offset;
		}
#pragma warning restore 0169

		static Delegate cb_setOffset_J;
#pragma warning disable 0169
		static Delegate GetSetOffset_JHandler ()
		{
			if (cb_setOffset_J == null)
				cb_setOffset_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetOffset_J);
			return cb_setOffset_J;
		}

		static void n_SetOffset_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.File_slice __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_slice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Offset = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_slice']/method[@name='getOffset' and count(parameter)=0]"
			[Register ("getOffset", "()J", "GetGetOffsetHandler")]
			get {
				const string __id = "getOffset.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_slice']/method[@name='setOffset' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setOffset", "(J)V", "GetSetOffset_JHandler")]
			set {
				const string __id = "setOffset.(J)V";
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
			global::FrostWire.Libtorrent.Swig.File_slice __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_slice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::FrostWire.Libtorrent.Swig.File_slice __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_slice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Size = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_slice']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()J", "GetGetSizeHandler")]
			get {
				const string __id = "getSize.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_slice']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='long']]"
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
			global::FrostWire.Libtorrent.Swig.File_slice __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_slice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_slice']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='file_slice']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.file_slice']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/file_slice;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.File_slice obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/file_slice;)J";
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
