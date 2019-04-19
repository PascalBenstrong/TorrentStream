using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/announce_endpoint", DoNotGenerateAcw=true)]
	public partial class Announce_endpoint : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/announce_endpoint", typeof (Announce_endpoint));
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

		protected Announce_endpoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/constructor[@name='announce_endpoint' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Announce_endpoint (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getFails;
#pragma warning disable 0169
		static Delegate GetGetFailsHandler ()
		{
			if (cb_getFails == null)
				cb_getFails = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetFails);
			return cb_getFails;
		}

		static short n_GetFails (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Fails;
		}
#pragma warning restore 0169

		static Delegate cb_setFails_S;
#pragma warning disable 0169
		static Delegate GetSetFails_SHandler ()
		{
			if (cb_setFails_S == null)
				cb_setFails_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetFails_S);
			return cb_setFails_S;
		}

		static void n_SetFails_S (IntPtr jnienv, IntPtr native__this, short value)
		{
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Fails = value;
		}
#pragma warning restore 0169

		public virtual unsafe short Fails {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='getFails' and count(parameter)=0]"
			[Register ("getFails", "()S", "GetGetFailsHandler")]
			get {
				const string __id = "getFails.()S";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt16Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='setFails' and count(parameter)=1 and parameter[1][@type='short']]"
			[Register ("setFails", "(S)V", "GetSetFails_SHandler")]
			set {
				const string __id = "setFails.(S)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLast_error;
#pragma warning disable 0169
		static Delegate GetGetLast_errorHandler ()
		{
			if (cb_getLast_error == null)
				cb_getLast_error = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLast_error);
			return cb_getLast_error;
		}

		static IntPtr n_GetLast_error (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Last_error);
		}
#pragma warning restore 0169

		static Delegate cb_setLast_error_Lcom_frostwire_jlibtorrent_swig_error_code_;
#pragma warning disable 0169
		static Delegate GetSetLast_error_Lcom_frostwire_jlibtorrent_swig_error_code_Handler ()
		{
			if (cb_setLast_error_Lcom_frostwire_jlibtorrent_swig_error_code_ == null)
				cb_setLast_error_Lcom_frostwire_jlibtorrent_swig_error_code_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLast_error_Lcom_frostwire_jlibtorrent_swig_error_code_);
			return cb_setLast_error_Lcom_frostwire_jlibtorrent_swig_error_code_;
		}

		static void n_SetLast_error_Lcom_frostwire_jlibtorrent_swig_error_code_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Error_code value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Error_code> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Last_error = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Error_code Last_error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='getLast_error' and count(parameter)=0]"
			[Register ("getLast_error", "()Lcom/frostwire/jlibtorrent/swig/error_code;", "GetGetLast_errorHandler")]
			get {
				const string __id = "getLast_error.()Lcom/frostwire/jlibtorrent/swig/error_code;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Error_code> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='setLast_error' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.error_code']]"
			[Register ("setLast_error", "(Lcom/frostwire/jlibtorrent/swig/error_code;)V", "GetSetLast_error_Lcom_frostwire_jlibtorrent_swig_error_code_Handler")]
			set {
				const string __id = "setLast_error.(Lcom/frostwire/jlibtorrent/swig/error_code;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLocal_endpoint;
#pragma warning disable 0169
		static Delegate GetGetLocal_endpointHandler ()
		{
			if (cb_getLocal_endpoint == null)
				cb_getLocal_endpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocal_endpoint);
			return cb_getLocal_endpoint;
		}

		static IntPtr n_GetLocal_endpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Local_endpoint);
		}
#pragma warning restore 0169

		static Delegate cb_setLocal_endpoint_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_;
#pragma warning disable 0169
		static Delegate GetSetLocal_endpoint_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Handler ()
		{
			if (cb_setLocal_endpoint_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_ == null)
				cb_setLocal_endpoint_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocal_endpoint_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_);
			return cb_setLocal_endpoint_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_;
		}

		static void n_SetLocal_endpoint_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Tcp_endpoint value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tcp_endpoint> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Local_endpoint = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Tcp_endpoint Local_endpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='getLocal_endpoint' and count(parameter)=0]"
			[Register ("getLocal_endpoint", "()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;", "GetGetLocal_endpointHandler")]
			get {
				const string __id = "getLocal_endpoint.()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tcp_endpoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='setLocal_endpoint' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.tcp_endpoint']]"
			[Register ("setLocal_endpoint", "(Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;)V", "GetSetLocal_endpoint_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Handler")]
			set {
				const string __id = "setLocal_endpoint.(Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScrape_complete;
#pragma warning disable 0169
		static Delegate GetGetScrape_completeHandler ()
		{
			if (cb_getScrape_complete == null)
				cb_getScrape_complete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScrape_complete);
			return cb_getScrape_complete;
		}

		static int n_GetScrape_complete (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Scrape_complete;
		}
#pragma warning restore 0169

		static Delegate cb_setScrape_complete_I;
#pragma warning disable 0169
		static Delegate GetSetScrape_complete_IHandler ()
		{
			if (cb_setScrape_complete_I == null)
				cb_setScrape_complete_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetScrape_complete_I);
			return cb_setScrape_complete_I;
		}

		static void n_SetScrape_complete_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Scrape_complete = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Scrape_complete {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='getScrape_complete' and count(parameter)=0]"
			[Register ("getScrape_complete", "()I", "GetGetScrape_completeHandler")]
			get {
				const string __id = "getScrape_complete.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='setScrape_complete' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setScrape_complete", "(I)V", "GetSetScrape_complete_IHandler")]
			set {
				const string __id = "setScrape_complete.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScrape_downloaded;
#pragma warning disable 0169
		static Delegate GetGetScrape_downloadedHandler ()
		{
			if (cb_getScrape_downloaded == null)
				cb_getScrape_downloaded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScrape_downloaded);
			return cb_getScrape_downloaded;
		}

		static int n_GetScrape_downloaded (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Scrape_downloaded;
		}
#pragma warning restore 0169

		static Delegate cb_setScrape_downloaded_I;
#pragma warning disable 0169
		static Delegate GetSetScrape_downloaded_IHandler ()
		{
			if (cb_setScrape_downloaded_I == null)
				cb_setScrape_downloaded_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetScrape_downloaded_I);
			return cb_setScrape_downloaded_I;
		}

		static void n_SetScrape_downloaded_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Scrape_downloaded = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Scrape_downloaded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='getScrape_downloaded' and count(parameter)=0]"
			[Register ("getScrape_downloaded", "()I", "GetGetScrape_downloadedHandler")]
			get {
				const string __id = "getScrape_downloaded.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='setScrape_downloaded' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setScrape_downloaded", "(I)V", "GetSetScrape_downloaded_IHandler")]
			set {
				const string __id = "setScrape_downloaded.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScrape_incomplete;
#pragma warning disable 0169
		static Delegate GetGetScrape_incompleteHandler ()
		{
			if (cb_getScrape_incomplete == null)
				cb_getScrape_incomplete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScrape_incomplete);
			return cb_getScrape_incomplete;
		}

		static int n_GetScrape_incomplete (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Scrape_incomplete;
		}
#pragma warning restore 0169

		static Delegate cb_setScrape_incomplete_I;
#pragma warning disable 0169
		static Delegate GetSetScrape_incomplete_IHandler ()
		{
			if (cb_setScrape_incomplete_I == null)
				cb_setScrape_incomplete_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetScrape_incomplete_I);
			return cb_setScrape_incomplete_I;
		}

		static void n_SetScrape_incomplete_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Scrape_incomplete = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Scrape_incomplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='getScrape_incomplete' and count(parameter)=0]"
			[Register ("getScrape_incomplete", "()I", "GetGetScrape_incompleteHandler")]
			get {
				const string __id = "getScrape_incomplete.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='setScrape_incomplete' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setScrape_incomplete", "(I)V", "GetSetScrape_incomplete_IHandler")]
			set {
				const string __id = "setScrape_incomplete.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUpdating;
#pragma warning disable 0169
		static Delegate GetGetUpdatingHandler ()
		{
			if (cb_getUpdating == null)
				cb_getUpdating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetUpdating);
			return cb_getUpdating;
		}

		static bool n_GetUpdating (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Updating;
		}
#pragma warning restore 0169

		static Delegate cb_setUpdating_Z;
#pragma warning disable 0169
		static Delegate GetSetUpdating_ZHandler ()
		{
			if (cb_setUpdating_Z == null)
				cb_setUpdating_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUpdating_Z);
			return cb_setUpdating_Z;
		}

		static void n_SetUpdating_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Updating = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Updating {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='getUpdating' and count(parameter)=0]"
			[Register ("getUpdating", "()Z", "GetGetUpdatingHandler")]
			get {
				const string __id = "getUpdating.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='setUpdating' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUpdating", "(Z)V", "GetSetUpdating_ZHandler")]
			set {
				const string __id = "setUpdating.(Z)V";
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
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.announce_endpoint']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/announce_endpoint;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Announce_endpoint obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/announce_endpoint;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_message;
#pragma warning disable 0169
		static Delegate GetGet_messageHandler ()
		{
			if (cb_get_message == null)
				cb_get_message = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_message);
			return cb_get_message;
		}

		static IntPtr n_Get_message (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_message ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='get_message' and count(parameter)=0]"
		[Register ("get_message", "()Lcom/frostwire/jlibtorrent/swig/byte_vector;", "GetGet_messageHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Get_message ()
		{
			const string __id = "get_message.()Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_min_announce;
#pragma warning disable 0169
		static Delegate GetGet_min_announceHandler ()
		{
			if (cb_get_min_announce == null)
				cb_get_min_announce = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Get_min_announce);
			return cb_get_min_announce;
		}

		static long n_Get_min_announce (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_min_announce ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='get_min_announce' and count(parameter)=0]"
		[Register ("get_min_announce", "()J", "GetGet_min_announceHandler")]
		public virtual unsafe long Get_min_announce ()
		{
			const string __id = "get_min_announce.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_next_announce;
#pragma warning disable 0169
		static Delegate GetGet_next_announceHandler ()
		{
			if (cb_get_next_announce == null)
				cb_get_next_announce = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Get_next_announce);
			return cb_get_next_announce;
		}

		static long n_Get_next_announce (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_next_announce ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='get_next_announce' and count(parameter)=0]"
		[Register ("get_next_announce", "()J", "GetGet_next_announceHandler")]
		public virtual unsafe long Get_next_announce ()
		{
			const string __id = "get_next_announce.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_working;
#pragma warning disable 0169
		static Delegate GetIs_workingHandler ()
		{
			if (cb_is_working == null)
				cb_is_working = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_working);
			return cb_is_working;
		}

		static bool n_Is_working (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_endpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_working ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_endpoint']/method[@name='is_working' and count(parameter)=0]"
		[Register ("is_working", "()Z", "GetIs_workingHandler")]
		public virtual unsafe bool Is_working ()
		{
			const string __id = "is_working.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
