using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_interface']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/ip_interface", DoNotGenerateAcw=true)]
	public partial class Ip_interface : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_interface']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/ip_interface", typeof (Ip_interface));
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

		protected Ip_interface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_interface']/constructor[@name='ip_interface' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Ip_interface ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_interface']/constructor[@name='ip_interface' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Ip_interface (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Ip_interface __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_interface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Description);
		}
#pragma warning restore 0169

		static Delegate cb_setDescription_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
#pragma warning disable 0169
		static Delegate GetSetDescription_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler ()
		{
			if (cb_setDescription_Lcom_frostwire_jlibtorrent_swig_byte_vector_ == null)
				cb_setDescription_Lcom_frostwire_jlibtorrent_swig_byte_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDescription_Lcom_frostwire_jlibtorrent_swig_byte_vector_);
			return cb_setDescription_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
		}

		static void n_SetDescription_Lcom_frostwire_jlibtorrent_swig_byte_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Ip_interface __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_interface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Description = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_interface']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Lcom/frostwire/jlibtorrent/swig/byte_vector;", "GetGetDescriptionHandler")]
			get {
				const string __id = "getDescription.()Lcom/frostwire/jlibtorrent/swig/byte_vector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_interface']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
			[Register ("setDescription", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V", "GetSetDescription_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler")]
			set {
				const string __id = "setDescription.(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFriendly_name;
#pragma warning disable 0169
		static Delegate GetGetFriendly_nameHandler ()
		{
			if (cb_getFriendly_name == null)
				cb_getFriendly_name = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFriendly_name);
			return cb_getFriendly_name;
		}

		static IntPtr n_GetFriendly_name (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Ip_interface __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_interface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Friendly_name);
		}
#pragma warning restore 0169

		static Delegate cb_setFriendly_name_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
#pragma warning disable 0169
		static Delegate GetSetFriendly_name_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler ()
		{
			if (cb_setFriendly_name_Lcom_frostwire_jlibtorrent_swig_byte_vector_ == null)
				cb_setFriendly_name_Lcom_frostwire_jlibtorrent_swig_byte_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFriendly_name_Lcom_frostwire_jlibtorrent_swig_byte_vector_);
			return cb_setFriendly_name_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
		}

		static void n_SetFriendly_name_Lcom_frostwire_jlibtorrent_swig_byte_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Ip_interface __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_interface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Friendly_name = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Friendly_name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_interface']/method[@name='getFriendly_name' and count(parameter)=0]"
			[Register ("getFriendly_name", "()Lcom/frostwire/jlibtorrent/swig/byte_vector;", "GetGetFriendly_nameHandler")]
			get {
				const string __id = "getFriendly_name.()Lcom/frostwire/jlibtorrent/swig/byte_vector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_interface']/method[@name='setFriendly_name' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
			[Register ("setFriendly_name", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V", "GetSetFriendly_name_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler")]
			set {
				const string __id = "setFriendly_name.(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getInterface_address;
#pragma warning disable 0169
		static Delegate GetGetInterface_addressHandler ()
		{
			if (cb_getInterface_address == null)
				cb_getInterface_address = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInterface_address);
			return cb_getInterface_address;
		}

		static IntPtr n_GetInterface_address (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Ip_interface __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_interface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Interface_address);
		}
#pragma warning restore 0169

		static Delegate cb_setInterface_address_Lcom_frostwire_jlibtorrent_swig_address_;
#pragma warning disable 0169
		static Delegate GetSetInterface_address_Lcom_frostwire_jlibtorrent_swig_address_Handler ()
		{
			if (cb_setInterface_address_Lcom_frostwire_jlibtorrent_swig_address_ == null)
				cb_setInterface_address_Lcom_frostwire_jlibtorrent_swig_address_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInterface_address_Lcom_frostwire_jlibtorrent_swig_address_);
			return cb_setInterface_address_Lcom_frostwire_jlibtorrent_swig_address_;
		}

		static void n_SetInterface_address_Lcom_frostwire_jlibtorrent_swig_address_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Ip_interface __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_interface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Address value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Interface_address = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Address Interface_address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_interface']/method[@name='getInterface_address' and count(parameter)=0]"
			[Register ("getInterface_address", "()Lcom/frostwire/jlibtorrent/swig/address;", "GetGetInterface_addressHandler")]
			get {
				const string __id = "getInterface_address.()Lcom/frostwire/jlibtorrent/swig/address;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_interface']/method[@name='setInterface_address' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.address']]"
			[Register ("setInterface_address", "(Lcom/frostwire/jlibtorrent/swig/address;)V", "GetSetInterface_address_Lcom_frostwire_jlibtorrent_swig_address_Handler")]
			set {
				const string __id = "setInterface_address.(Lcom/frostwire/jlibtorrent/swig/address;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
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
			global::FrostWire.Libtorrent.Swig.Ip_interface __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_interface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::FrostWire.Libtorrent.Swig.Ip_interface __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_interface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Name = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_interface']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Lcom/frostwire/jlibtorrent/swig/byte_vector;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Lcom/frostwire/jlibtorrent/swig/byte_vector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_interface']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
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
			global::FrostWire.Libtorrent.Swig.Ip_interface __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_interface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::FrostWire.Libtorrent.Swig.Ip_interface __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_interface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Address value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Netmask = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Address Netmask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_interface']/method[@name='getNetmask' and count(parameter)=0]"
			[Register ("getNetmask", "()Lcom/frostwire/jlibtorrent/swig/address;", "GetGetNetmaskHandler")]
			get {
				const string __id = "getNetmask.()Lcom/frostwire/jlibtorrent/swig/address;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_interface']/method[@name='setNetmask' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.address']]"
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

		static Delegate cb_getPreferred;
#pragma warning disable 0169
		static Delegate GetGetPreferredHandler ()
		{
			if (cb_getPreferred == null)
				cb_getPreferred = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetPreferred);
			return cb_getPreferred;
		}

		static bool n_GetPreferred (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Ip_interface __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_interface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Preferred;
		}
#pragma warning restore 0169

		static Delegate cb_setPreferred_Z;
#pragma warning disable 0169
		static Delegate GetSetPreferred_ZHandler ()
		{
			if (cb_setPreferred_Z == null)
				cb_setPreferred_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPreferred_Z);
			return cb_setPreferred_Z;
		}

		static void n_SetPreferred_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Ip_interface __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_interface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Preferred = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Preferred {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_interface']/method[@name='getPreferred' and count(parameter)=0]"
			[Register ("getPreferred", "()Z", "GetGetPreferredHandler")]
			get {
				const string __id = "getPreferred.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_interface']/method[@name='setPreferred' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPreferred", "(Z)V", "GetSetPreferred_ZHandler")]
			set {
				const string __id = "setPreferred.(Z)V";
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
			global::FrostWire.Libtorrent.Swig.Ip_interface __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_interface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_interface']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_interface']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.ip_interface']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/ip_interface;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Ip_interface obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/ip_interface;)J";
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
