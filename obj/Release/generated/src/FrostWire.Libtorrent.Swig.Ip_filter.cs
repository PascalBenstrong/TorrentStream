using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_filter']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/ip_filter", DoNotGenerateAcw=true)]
	public partial class Ip_filter : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_filter']/field[@name='swigCMemOwn']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_filter.access_flags']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/ip_filter$access_flags", DoNotGenerateAcw=true)]
		public sealed partial class Access_flags : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_filter.access_flags']/field[@name='blocked']"
			[Register ("blocked")]
			public static global::FrostWire.Libtorrent.Swig.Ip_filter.Access_flags Blocked {
				get {
					const string __id = "blocked.Lcom/frostwire/jlibtorrent/swig/ip_filter$access_flags;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_filter.Access_flags> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/ip_filter$access_flags", typeof (Access_flags));
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

			internal Access_flags (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_filter.access_flags']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/ip_filter$access_flags;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Ip_filter.Access_flags SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/ip_filter$access_flags;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_filter.Access_flags> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_filter.access_flags']/method[@name='swigValue' and count(parameter)=0]"
			[Register ("swigValue", "()I", "")]
			public unsafe int SwigValue ()
			{
				const string __id = "swigValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/ip_filter", typeof (Ip_filter));
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

		protected Ip_filter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_filter']/constructor[@name='ip_filter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Ip_filter ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_filter']/constructor[@name='ip_filter' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Ip_filter (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_access_Lcom_frostwire_jlibtorrent_swig_address_;
#pragma warning disable 0169
		static Delegate GetAccess_Lcom_frostwire_jlibtorrent_swig_address_Handler ()
		{
			if (cb_access_Lcom_frostwire_jlibtorrent_swig_address_ == null)
				cb_access_Lcom_frostwire_jlibtorrent_swig_address_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_Access_Lcom_frostwire_jlibtorrent_swig_address_);
			return cb_access_Lcom_frostwire_jlibtorrent_swig_address_;
		}

		static long n_Access_Lcom_frostwire_jlibtorrent_swig_address_ (IntPtr jnienv, IntPtr native__this, IntPtr native_addr)
		{
			global::FrostWire.Libtorrent.Swig.Ip_filter __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_filter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Address addr = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (native_addr, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.Access (addr);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_filter']/method[@name='access' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.address']]"
		[Register ("access", "(Lcom/frostwire/jlibtorrent/swig/address;)J", "GetAccess_Lcom_frostwire_jlibtorrent_swig_address_Handler")]
		public virtual unsafe long Access (global::FrostWire.Libtorrent.Swig.Address addr)
		{
			const string __id = "access.(Lcom/frostwire/jlibtorrent/swig/address;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((addr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) addr).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_add_rule_Lcom_frostwire_jlibtorrent_swig_address_Lcom_frostwire_jlibtorrent_swig_address_J;
#pragma warning disable 0169
		static Delegate GetAdd_rule_Lcom_frostwire_jlibtorrent_swig_address_Lcom_frostwire_jlibtorrent_swig_address_JHandler ()
		{
			if (cb_add_rule_Lcom_frostwire_jlibtorrent_swig_address_Lcom_frostwire_jlibtorrent_swig_address_J == null)
				cb_add_rule_Lcom_frostwire_jlibtorrent_swig_address_Lcom_frostwire_jlibtorrent_swig_address_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long>) n_Add_rule_Lcom_frostwire_jlibtorrent_swig_address_Lcom_frostwire_jlibtorrent_swig_address_J);
			return cb_add_rule_Lcom_frostwire_jlibtorrent_swig_address_Lcom_frostwire_jlibtorrent_swig_address_J;
		}

		static void n_Add_rule_Lcom_frostwire_jlibtorrent_swig_address_Lcom_frostwire_jlibtorrent_swig_address_J (IntPtr jnienv, IntPtr native__this, IntPtr native_first, IntPtr native_last, long flags)
		{
			global::FrostWire.Libtorrent.Swig.Ip_filter __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_filter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Address first = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (native_first, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Address last = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (native_last, JniHandleOwnership.DoNotTransfer);
			__this.Add_rule (first, last, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_filter']/method[@name='add_rule' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.swig.address'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.address'] and parameter[3][@type='long']]"
		[Register ("add_rule", "(Lcom/frostwire/jlibtorrent/swig/address;Lcom/frostwire/jlibtorrent/swig/address;J)V", "GetAdd_rule_Lcom_frostwire_jlibtorrent_swig_address_Lcom_frostwire_jlibtorrent_swig_address_JHandler")]
		public virtual unsafe void Add_rule (global::FrostWire.Libtorrent.Swig.Address first, global::FrostWire.Libtorrent.Swig.Address last, long flags)
		{
			const string __id = "add_rule.(Lcom/frostwire/jlibtorrent/swig/address;Lcom/frostwire/jlibtorrent/swig/address;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((first == null) ? IntPtr.Zero : ((global::Java.Lang.Object) first).Handle);
				__args [1] = new JniArgumentValue ((last == null) ? IntPtr.Zero : ((global::Java.Lang.Object) last).Handle);
				__args [2] = new JniArgumentValue (flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::FrostWire.Libtorrent.Swig.Ip_filter __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_filter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_filter']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='ip_filter']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.ip_filter']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/ip_filter;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Ip_filter obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/ip_filter;)J";
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
