using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_files_listener']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/add_files_listener", DoNotGenerateAcw=true)]
	public partial class Add_files_listener : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_files_listener']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/add_files_listener", typeof (Add_files_listener));
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

		protected Add_files_listener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_files_listener']/constructor[@name='add_files_listener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Add_files_listener ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_files_listener']/constructor[@name='add_files_listener' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Add_files_listener (long cPtr, bool cMemoryOwn)
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
			global::FrostWire.Libtorrent.Swig.Add_files_listener __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_files_listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_files_listener']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_files_listener']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.add_files_listener']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/add_files_listener;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Add_files_listener obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/add_files_listener;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_pred_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPred_Ljava_lang_String_Handler ()
		{
			if (cb_pred_Ljava_lang_String_ == null)
				cb_pred_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Pred_Ljava_lang_String_);
			return cb_pred_Ljava_lang_String_;
		}

		static bool n_Pred_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			global::FrostWire.Libtorrent.Swig.Add_files_listener __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_files_listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p = JNIEnv.GetString (native_p, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Pred (p);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_files_listener']/method[@name='pred' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("pred", "(Ljava/lang/String;)Z", "GetPred_Ljava_lang_String_Handler")]
		public virtual unsafe bool Pred (string p)
		{
			const string __id = "pred.(Ljava/lang/String;)Z";
			IntPtr native_p = JNIEnv.NewString (p);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p);
			}
		}

		static Delegate cb_swigDirectorDisconnect;
#pragma warning disable 0169
		static Delegate GetSwigDirectorDisconnectHandler ()
		{
			if (cb_swigDirectorDisconnect == null)
				cb_swigDirectorDisconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwigDirectorDisconnect);
			return cb_swigDirectorDisconnect;
		}

		static void n_SwigDirectorDisconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_files_listener __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_files_listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwigDirectorDisconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_files_listener']/method[@name='swigDirectorDisconnect' and count(parameter)=0]"
		[Register ("swigDirectorDisconnect", "()V", "GetSwigDirectorDisconnectHandler")]
		protected virtual unsafe void SwigDirectorDisconnect ()
		{
			const string __id = "swigDirectorDisconnect.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_swigReleaseOwnership;
#pragma warning disable 0169
		static Delegate GetSwigReleaseOwnershipHandler ()
		{
			if (cb_swigReleaseOwnership == null)
				cb_swigReleaseOwnership = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwigReleaseOwnership);
			return cb_swigReleaseOwnership;
		}

		static void n_SwigReleaseOwnership (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_files_listener __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_files_listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwigReleaseOwnership ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_files_listener']/method[@name='swigReleaseOwnership' and count(parameter)=0]"
		[Register ("swigReleaseOwnership", "()V", "GetSwigReleaseOwnershipHandler")]
		public virtual unsafe void SwigReleaseOwnership ()
		{
			const string __id = "swigReleaseOwnership.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_swigTakeOwnership;
#pragma warning disable 0169
		static Delegate GetSwigTakeOwnershipHandler ()
		{
			if (cb_swigTakeOwnership == null)
				cb_swigTakeOwnership = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SwigTakeOwnership);
			return cb_swigTakeOwnership;
		}

		static void n_SwigTakeOwnership (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_files_listener __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_files_listener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwigTakeOwnership ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_files_listener']/method[@name='swigTakeOwnership' and count(parameter)=0]"
		[Register ("swigTakeOwnership", "()V", "GetSwigTakeOwnershipHandler")]
		public virtual unsafe void SwigTakeOwnership ()
		{
			const string __id = "swigTakeOwnership.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
