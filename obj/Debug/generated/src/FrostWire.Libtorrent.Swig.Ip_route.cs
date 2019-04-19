using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_route']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/ip_route", DoNotGenerateAcw=true)]
	public partial class Ip_route : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_route']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/ip_route", typeof (Ip_route));
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

		protected Ip_route (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_route']/constructor[@name='ip_route' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Ip_route ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_route']/constructor[@name='ip_route' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Ip_route (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getDestination;
#pragma warning disable 0169
		static Delegate GetGetDestinationHandler ()
		{
			if (cb_getDestination == null)
				cb_getDestination = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDestination);
			return cb_getDestination;
		}

		static IntPtr n_GetDestination (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Ip_route __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_route> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Destination);
		}
#pragma warning restore 0169

		static Delegate cb_setDestination_Lcom_frostwire_jlibtorrent_swig_address_;
#pragma warning disable 0169
		static Delegate GetSetDestination_Lcom_frostwire_jlibtorrent_swig_address_Handler ()
		{
			if (cb_setDestination_Lcom_frostwire_jlibtorrent_swig_address_ == null)
				cb_setDestination_Lcom_frostwire_jlibtorrent_swig_address_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDestination_Lcom_frostwire_jlibtorrent_swig_address_);
			return cb_setDestination_Lcom_frostwire_jlibtorrent_swig_address_;
		}

		static void n_SetDestination_Lcom_frostwire_jlibtorrent_swig_address_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Ip_route __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_route> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Address value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Destination = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Address Destination {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_route']/method[@name='getDestination' and count(parameter)=0]"
			[Register ("getDestination", "()Lcom/frostwire/jlibtorrent/swig/address;", "GetGetDestinationHandler")]
			get {
				const string __id = "getDestination.()Lcom/frostwire/jlibtorrent/swig/address;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_route']/method[@name='setDestination' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.address']]"
			[Register ("setDestination", "(Lcom/frostwire/jlibtorrent/swig/address;)V", "GetSetDestination_Lcom_frostwire_jlibtorrent_swig_address_Handler")]
			set {
				const string __id = "setDestination.(Lcom/frostwire/jlibtorrent/swig/address;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getGateway;
#pragma warning disable 0169
		static Delegate GetGetGatewayHandler ()
		{
			if (cb_getGateway == null)
				cb_getGateway = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGateway);
			return cb_getGateway;
		}

		static IntPtr n_GetGateway (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Ip_route __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_route> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Gateway);
		}
#pragma warning restore 0169

		static Delegate cb_setGateway_Lcom_frostwire_jlibtorrent_swig_address_;
#pragma warning disable 0169
		static Delegate GetSetGateway_Lcom_frostwire_jlibtorrent_swig_address_Handler ()
		{
			if (cb_setGateway_Lcom_frostwire_jlibtorrent_swig_address_ == null)
				cb_setGateway_Lcom_frostwire_jlibtorrent_swig_address_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGateway_Lcom_frostwire_jlibtorrent_swig_address_);
			return cb_setGateway_Lcom_frostwire_jlibtorrent_swig_address_;
		}

		static void n_SetGateway_Lcom_frostwire_jlibtorrent_swig_address_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Ip_route __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_route> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Address value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Gateway = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Address Gateway {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_route']/method[@name='getGateway' and count(parameter)=0]"
			[Register ("getGateway", "()Lcom/frostwire/jlibtorrent/swig/address;", "GetGetGatewayHandler")]
			get {
				const string __id = "getGateway.()Lcom/frostwire/jlibtorrent/swig/address;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_route']/method[@name='setGateway' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.address']]"
			[Register ("setGateway", "(Lcom/frostwire/jlibtorrent/swig/address;)V", "GetSetGateway_Lcom_frostwire_jlibtorrent_swig_address_Handler")]
			set {
				const string __id = "setGateway.(Lcom/frostwire/jlibtorrent/swig/address;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMtu;
#pragma warning disable 0169
		static Delegate GetGetMtuHandler ()
		{
			if (cb_getMtu == null)
				cb_getMtu = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMtu);
			return cb_getMtu;
		}

		static int n_GetMtu (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Ip_route __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_route> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Mtu;
		}
#pragma warning restore 0169

		static Delegate cb_setMtu_I;
#pragma warning disable 0169
		static Delegate GetSetMtu_IHandler ()
		{
			if (cb_setMtu_I == null)
				cb_setMtu_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMtu_I);
			return cb_setMtu_I;
		}

		static void n_SetMtu_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Ip_route __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_route> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Mtu = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Mtu {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_route']/method[@name='getMtu' and count(parameter)=0]"
			[Register ("getMtu", "()I", "GetGetMtuHandler")]
			get {
				const string __id = "getMtu.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_route']/method[@name='setMtu' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMtu", "(I)V", "GetSetMtu_IHandler")]
			set {
				const string __id = "setMtu.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Ip_route __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_route> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
#pragma warning disable 0169
		static Delegate GetSetName_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler ()
		{
			if (cb_setName_Lcom_frostwire_jlibtorrent_swig_byte_vector_ == null)
				cb_setName_Lcom_frostwire_jlibtorrent_swig_byte_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Lcom_frostwire_jlibtorrent_swig_byte_vector_);
			return cb_setName_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
		}

		static void n_SetName_Lcom_frostwire_jlibtorrent_swig_byte_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Ip_route __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_route> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Name = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_route']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Lcom/frostwire/jlibtorrent/swig/byte_vector;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Lcom/frostwire/jlibtorrent/swig/byte_vector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_route']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
			[Register ("setName", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V", "GetSetName_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler")]
			set {
				const string __id = "setName.(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNetmask;
#pragma warning disable 0169
		static Delegate GetGetNetmaskHandler ()
		{
			if (cb_getNetmask == null)
				cb_getNetmask = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetmask);
			return cb_getNetmask;
		}

		static IntPtr n_GetNetmask (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Ip_route __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_route> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Netmask);
		}
#pragma warning restore 0169

		static Delegate cb_setNetmask_Lcom_frostwire_jlibtorrent_swig_address_;
#pragma warning disable 0169
		static Delegate GetSetNetmask_Lcom_frostwire_jlibtorrent_swig_address_Handler ()
		{
			if (cb_setNetmask_Lcom_frostwire_jlibtorrent_swig_address_ == null)
				cb_setNetmask_Lcom_frostwire_jlibtorrent_swig_address_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNetmask_Lcom_frostwire_jlibtorrent_swig_address_);
			return cb_setNetmask_Lcom_frostwire_jlibtorrent_swig_address_;
		}

		static void n_SetNetmask_Lcom_frostwire_jlibtorrent_swig_address_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Ip_route __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_route> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Address value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Netmask = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Address Netmask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_route']/method[@name='getNetmask' and count(parameter)=0]"
			[Register ("getNetmask", "()Lcom/frostwire/jlibtorrent/swig/address;", "GetGetNetmaskHandler")]
			get {
				const string __id = "getNetmask.()Lcom/frostwire/jlibtorrent/swig/address;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_route']/method[@name='setNetmask' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.address']]"
			[Register ("setNetmask", "(Lcom/frostwire/jlibtorrent/swig/address;)V", "GetSetNetmask_Lcom_frostwire_jlibtorrent_swig_address_Handler")]
			set {
				const string __id = "setNetmask.(Lcom/frostwire/jlibtorrent/swig/address;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
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
			global::FrostWire.Libtorrent.Swig.Ip_route __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_route> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_route']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_route']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.ip_route']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/ip_route;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Ip_route obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/ip_route;)J";
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
