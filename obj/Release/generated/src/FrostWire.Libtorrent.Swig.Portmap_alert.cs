using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/portmap_alert", DoNotGenerateAcw=true)]
	public partial class Portmap_alert : global::FrostWire.Libtorrent.Swig.Alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/portmap_alert", typeof (Portmap_alert));
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

		protected Portmap_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_alert']/constructor[@name='portmap_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Portmap_alert (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getExternal_port;
#pragma warning disable 0169
		static Delegate GetGetExternal_portHandler ()
		{
			if (cb_getExternal_port == null)
				cb_getExternal_port = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetExternal_port);
			return cb_getExternal_port;
		}

		static int n_GetExternal_port (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Portmap_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.External_port;
		}
#pragma warning restore 0169

		public virtual unsafe int External_port {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_alert']/method[@name='getExternal_port' and count(parameter)=0]"
			[Register ("getExternal_port", "()I", "GetGetExternal_portHandler")]
			get {
				const string __id = "getExternal_port.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMap_protocol;
#pragma warning disable 0169
		static Delegate GetGetMap_protocolHandler ()
		{
			if (cb_getMap_protocol == null)
				cb_getMap_protocol = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMap_protocol);
			return cb_getMap_protocol;
		}

		static IntPtr n_GetMap_protocol (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Portmap_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Map_protocol);
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Portmap_protocol Map_protocol {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_alert']/method[@name='getMap_protocol' and count(parameter)=0]"
			[Register ("getMap_protocol", "()Lcom/frostwire/jlibtorrent/swig/portmap_protocol;", "GetGetMap_protocolHandler")]
			get {
				const string __id = "getMap_protocol.()Lcom/frostwire/jlibtorrent/swig/portmap_protocol;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_protocol> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::FrostWire.Libtorrent.Swig.Portmap_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Map_transport);
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Portmap_transport Map_transport {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_alert']/method[@name='getMap_transport' and count(parameter)=0]"
			[Register ("getMap_transport", "()Lcom/frostwire/jlibtorrent/swig/portmap_transport;", "GetGetMap_transportHandler")]
			get {
				const string __id = "getMap_transport.()Lcom/frostwire/jlibtorrent/swig/portmap_transport;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_transport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::FrostWire.Libtorrent.Swig.Portmap_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Mapping;
		}
#pragma warning restore 0169

		public virtual unsafe int Mapping {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_alert']/method[@name='getMapping' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='portmap_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.portmap_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/portmap_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Portmap_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/portmap_alert;)J";
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
