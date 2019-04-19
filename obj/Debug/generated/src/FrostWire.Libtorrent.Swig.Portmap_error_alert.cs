using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_error_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/portmap_error_alert", DoNotGenerateAcw=true)]
	public partial class Portmap_error_alert : global::FrostWire.Libtorrent.Swig.Alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_error_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_error_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_error_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/portmap_error_alert", typeof (Portmap_error_alert));
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

		protected Portmap_error_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_error_alert']/constructor[@name='portmap_error_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Portmap_error_alert (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getError;
#pragma warning disable 0169
		static Delegate GetGetErrorHandler ()
		{
			if (cb_getError == null)
				cb_getError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetError);
			return cb_getError;
		}

		static IntPtr n_GetError (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Portmap_error_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_error_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Error);
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Error_code Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_error_alert']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Lcom/frostwire/jlibtorrent/swig/error_code;", "GetGetErrorHandler")]
			get {
				const string __id = "getError.()Lcom/frostwire/jlibtorrent/swig/error_code;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Error_code> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMap_transport;
#pragma warning disable 0169
		static Delegate GetGetMap_transportHandler ()
		{
			if (cb_getMap_transport == null)
				cb_getMap_transport = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMap_transport);
			return cb_getMap_transport;
		}

		static IntPtr n_GetMap_transport (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Portmap_error_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_error_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Map_transport);
		}
#pragma warning restore 0169

		static Delegate cb_setMap_transport_Lcom_frostwire_jlibtorrent_swig_portmap_transport_;
#pragma warning disable 0169
		static Delegate GetSetMap_transport_Lcom_frostwire_jlibtorrent_swig_portmap_transport_Handler ()
		{
			if (cb_setMap_transport_Lcom_frostwire_jlibtorrent_swig_portmap_transport_ == null)
				cb_setMap_transport_Lcom_frostwire_jlibtorrent_swig_portmap_transport_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMap_transport_Lcom_frostwire_jlibtorrent_swig_portmap_transport_);
			return cb_setMap_transport_Lcom_frostwire_jlibtorrent_swig_portmap_transport_;
		}

		static void n_SetMap_transport_Lcom_frostwire_jlibtorrent_swig_portmap_transport_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Portmap_error_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_error_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Portmap_transport value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_transport> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Map_transport = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Portmap_transport Map_transport {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_error_alert']/method[@name='getMap_transport' and count(parameter)=0]"
			[Register ("getMap_transport", "()Lcom/frostwire/jlibtorrent/swig/portmap_transport;", "GetGetMap_transportHandler")]
			get {
				const string __id = "getMap_transport.()Lcom/frostwire/jlibtorrent/swig/portmap_transport;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_transport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_error_alert']/method[@name='setMap_transport' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.portmap_transport']]"
			[Register ("setMap_transport", "(Lcom/frostwire/jlibtorrent/swig/portmap_transport;)V", "GetSetMap_transport_Lcom_frostwire_jlibtorrent_swig_portmap_transport_Handler")]
			set {
				const string __id = "setMap_transport.(Lcom/frostwire/jlibtorrent/swig/portmap_transport;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMapping;
#pragma warning disable 0169
		static Delegate GetGetMappingHandler ()
		{
			if (cb_getMapping == null)
				cb_getMapping = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMapping);
			return cb_getMapping;
		}

		static int n_GetMapping (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Portmap_error_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_error_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Mapping;
		}
#pragma warning restore 0169

		public virtual unsafe int Mapping {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_error_alert']/method[@name='getMapping' and count(parameter)=0]"
			[Register ("getMapping", "()I", "GetGetMappingHandler")]
			get {
				const string __id = "getMapping.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_error_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.portmap_error_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/portmap_error_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Portmap_error_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/portmap_error_alert;)J";
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
