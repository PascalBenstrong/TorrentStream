using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/peer_class_info", DoNotGenerateAcw=true)]
	public partial class Peer_class_info : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/peer_class_info", typeof (Peer_class_info));
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

		protected Peer_class_info (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/constructor[@name='peer_class_info' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Peer_class_info ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/constructor[@name='peer_class_info' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Peer_class_info (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getConnection_limit_factor;
#pragma warning disable 0169
		static Delegate GetGetConnection_limit_factorHandler ()
		{
			if (cb_getConnection_limit_factor == null)
				cb_getConnection_limit_factor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConnection_limit_factor);
			return cb_getConnection_limit_factor;
		}

		static int n_GetConnection_limit_factor (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Connection_limit_factor;
		}
#pragma warning restore 0169

		static Delegate cb_setConnection_limit_factor_I;
#pragma warning disable 0169
		static Delegate GetSetConnection_limit_factor_IHandler ()
		{
			if (cb_setConnection_limit_factor_I == null)
				cb_setConnection_limit_factor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetConnection_limit_factor_I);
			return cb_setConnection_limit_factor_I;
		}

		static void n_SetConnection_limit_factor_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connection_limit_factor = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Connection_limit_factor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/method[@name='getConnection_limit_factor' and count(parameter)=0]"
			[Register ("getConnection_limit_factor", "()I", "GetGetConnection_limit_factorHandler")]
			get {
				const string __id = "getConnection_limit_factor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/method[@name='setConnection_limit_factor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConnection_limit_factor", "(I)V", "GetSetConnection_limit_factor_IHandler")]
			set {
				const string __id = "setConnection_limit_factor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDownload_limit;
#pragma warning disable 0169
		static Delegate GetGetDownload_limitHandler ()
		{
			if (cb_getDownload_limit == null)
				cb_getDownload_limit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDownload_limit);
			return cb_getDownload_limit;
		}

		static int n_GetDownload_limit (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Download_limit;
		}
#pragma warning restore 0169

		static Delegate cb_setDownload_limit_I;
#pragma warning disable 0169
		static Delegate GetSetDownload_limit_IHandler ()
		{
			if (cb_setDownload_limit_I == null)
				cb_setDownload_limit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDownload_limit_I);
			return cb_setDownload_limit_I;
		}

		static void n_SetDownload_limit_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Download_limit = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Download_limit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/method[@name='getDownload_limit' and count(parameter)=0]"
			[Register ("getDownload_limit", "()I", "GetGetDownload_limitHandler")]
			get {
				const string __id = "getDownload_limit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/method[@name='setDownload_limit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDownload_limit", "(I)V", "GetSetDownload_limit_IHandler")]
			set {
				const string __id = "setDownload_limit.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDownload_priority;
#pragma warning disable 0169
		static Delegate GetGetDownload_priorityHandler ()
		{
			if (cb_getDownload_priority == null)
				cb_getDownload_priority = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDownload_priority);
			return cb_getDownload_priority;
		}

		static int n_GetDownload_priority (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Download_priority;
		}
#pragma warning restore 0169

		static Delegate cb_setDownload_priority_I;
#pragma warning disable 0169
		static Delegate GetSetDownload_priority_IHandler ()
		{
			if (cb_setDownload_priority_I == null)
				cb_setDownload_priority_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDownload_priority_I);
			return cb_setDownload_priority_I;
		}

		static void n_SetDownload_priority_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Download_priority = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Download_priority {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/method[@name='getDownload_priority' and count(parameter)=0]"
			[Register ("getDownload_priority", "()I", "GetGetDownload_priorityHandler")]
			get {
				const string __id = "getDownload_priority.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/method[@name='setDownload_priority' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDownload_priority", "(I)V", "GetSetDownload_priority_IHandler")]
			set {
				const string __id = "setDownload_priority.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIgnore_unchoke_slots;
#pragma warning disable 0169
		static Delegate GetGetIgnore_unchoke_slotsHandler ()
		{
			if (cb_getIgnore_unchoke_slots == null)
				cb_getIgnore_unchoke_slots = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIgnore_unchoke_slots);
			return cb_getIgnore_unchoke_slots;
		}

		static bool n_GetIgnore_unchoke_slots (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ignore_unchoke_slots;
		}
#pragma warning restore 0169

		static Delegate cb_setIgnore_unchoke_slots_Z;
#pragma warning disable 0169
		static Delegate GetSetIgnore_unchoke_slots_ZHandler ()
		{
			if (cb_setIgnore_unchoke_slots_Z == null)
				cb_setIgnore_unchoke_slots_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIgnore_unchoke_slots_Z);
			return cb_setIgnore_unchoke_slots_Z;
		}

		static void n_SetIgnore_unchoke_slots_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Ignore_unchoke_slots = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Ignore_unchoke_slots {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/method[@name='getIgnore_unchoke_slots' and count(parameter)=0]"
			[Register ("getIgnore_unchoke_slots", "()Z", "GetGetIgnore_unchoke_slotsHandler")]
			get {
				const string __id = "getIgnore_unchoke_slots.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/method[@name='setIgnore_unchoke_slots' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIgnore_unchoke_slots", "(Z)V", "GetSetIgnore_unchoke_slots_ZHandler")]
			set {
				const string __id = "setIgnore_unchoke_slots.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLabel;
#pragma warning disable 0169
		static Delegate GetGetLabelHandler ()
		{
			if (cb_getLabel == null)
				cb_getLabel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLabel);
			return cb_getLabel;
		}

		static IntPtr n_GetLabel (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Label);
		}
#pragma warning restore 0169

		static Delegate cb_setLabel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLabel_Ljava_lang_String_Handler ()
		{
			if (cb_setLabel_Ljava_lang_String_ == null)
				cb_setLabel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLabel_Ljava_lang_String_);
			return cb_setLabel_Ljava_lang_String_;
		}

		static void n_SetLabel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Label = value;
		}
#pragma warning restore 0169

		public virtual unsafe string Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/method[@name='getLabel' and count(parameter)=0]"
			[Register ("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler")]
			get {
				const string __id = "getLabel.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/method[@name='setLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLabel", "(Ljava/lang/String;)V", "GetSetLabel_Ljava_lang_String_Handler")]
			set {
				const string __id = "setLabel.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUpload_limit;
#pragma warning disable 0169
		static Delegate GetGetUpload_limitHandler ()
		{
			if (cb_getUpload_limit == null)
				cb_getUpload_limit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUpload_limit);
			return cb_getUpload_limit;
		}

		static int n_GetUpload_limit (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Upload_limit;
		}
#pragma warning restore 0169

		static Delegate cb_setUpload_limit_I;
#pragma warning disable 0169
		static Delegate GetSetUpload_limit_IHandler ()
		{
			if (cb_setUpload_limit_I == null)
				cb_setUpload_limit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUpload_limit_I);
			return cb_setUpload_limit_I;
		}

		static void n_SetUpload_limit_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Upload_limit = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Upload_limit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/method[@name='getUpload_limit' and count(parameter)=0]"
			[Register ("getUpload_limit", "()I", "GetGetUpload_limitHandler")]
			get {
				const string __id = "getUpload_limit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/method[@name='setUpload_limit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUpload_limit", "(I)V", "GetSetUpload_limit_IHandler")]
			set {
				const string __id = "setUpload_limit.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUpload_priority;
#pragma warning disable 0169
		static Delegate GetGetUpload_priorityHandler ()
		{
			if (cb_getUpload_priority == null)
				cb_getUpload_priority = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUpload_priority);
			return cb_getUpload_priority;
		}

		static int n_GetUpload_priority (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Upload_priority;
		}
#pragma warning restore 0169

		static Delegate cb_setUpload_priority_I;
#pragma warning disable 0169
		static Delegate GetSetUpload_priority_IHandler ()
		{
			if (cb_setUpload_priority_I == null)
				cb_setUpload_priority_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUpload_priority_I);
			return cb_setUpload_priority_I;
		}

		static void n_SetUpload_priority_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_class_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Upload_priority = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Upload_priority {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/method[@name='getUpload_priority' and count(parameter)=0]"
			[Register ("getUpload_priority", "()I", "GetGetUpload_priorityHandler")]
			get {
				const string __id = "getUpload_priority.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/method[@name='setUpload_priority' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUpload_priority", "(I)V", "GetSetUpload_priority_IHandler")]
			set {
				const string __id = "setUpload_priority.(I)V";
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
			global::FrostWire.Libtorrent.Swig.Peer_class_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_class_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_class_info']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_class_info']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/peer_class_info;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Peer_class_info obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/peer_class_info;)J";
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
