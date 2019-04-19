using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_metric']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/stats_metric", DoNotGenerateAcw=true)]
	public partial class Stats_metric : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_metric']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/stats_metric", typeof (Stats_metric));
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

		protected Stats_metric (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_metric']/constructor[@name='stats_metric' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Stats_metric ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_metric']/constructor[@name='stats_metric' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Stats_metric (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Stats_metric __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Stats_metric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		static Delegate cb_setType_Lcom_frostwire_jlibtorrent_swig_metric_type_t_;
#pragma warning disable 0169
		static Delegate GetSetType_Lcom_frostwire_jlibtorrent_swig_metric_type_t_Handler ()
		{
			if (cb_setType_Lcom_frostwire_jlibtorrent_swig_metric_type_t_ == null)
				cb_setType_Lcom_frostwire_jlibtorrent_swig_metric_type_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Lcom_frostwire_jlibtorrent_swig_metric_type_t_);
			return cb_setType_Lcom_frostwire_jlibtorrent_swig_metric_type_t_;
		}

		static void n_SetType_Lcom_frostwire_jlibtorrent_swig_metric_type_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Stats_metric __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Stats_metric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Metric_type_t value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Metric_type_t> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Type = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Metric_type_t Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_metric']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/frostwire/jlibtorrent/swig/metric_type_t;", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()Lcom/frostwire/jlibtorrent/swig/metric_type_t;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Metric_type_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_metric']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.metric_type_t']]"
			[Register ("setType", "(Lcom/frostwire/jlibtorrent/swig/metric_type_t;)V", "GetSetType_Lcom_frostwire_jlibtorrent_swig_metric_type_t_Handler")]
			set {
				const string __id = "setType.(Lcom/frostwire/jlibtorrent/swig/metric_type_t;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getValue_index;
#pragma warning disable 0169
		static Delegate GetGetValue_indexHandler ()
		{
			if (cb_getValue_index == null)
				cb_getValue_index = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetValue_index);
			return cb_getValue_index;
		}

		static int n_GetValue_index (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Stats_metric __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Stats_metric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Value_index;
		}
#pragma warning restore 0169

		static Delegate cb_setValue_index_I;
#pragma warning disable 0169
		static Delegate GetSetValue_index_IHandler ()
		{
			if (cb_setValue_index_I == null)
				cb_setValue_index_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetValue_index_I);
			return cb_setValue_index_I;
		}

		static void n_SetValue_index_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Stats_metric __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Stats_metric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Value_index = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Value_index {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_metric']/method[@name='getValue_index' and count(parameter)=0]"
			[Register ("getValue_index", "()I", "GetGetValue_indexHandler")]
			get {
				const string __id = "getValue_index.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_metric']/method[@name='setValue_index' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setValue_index", "(I)V", "GetSetValue_index_IHandler")]
			set {
				const string __id = "setValue_index.(I)V";
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
			global::FrostWire.Libtorrent.Swig.Stats_metric __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Stats_metric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_metric']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_metric']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.stats_metric']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/stats_metric;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Stats_metric obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/stats_metric;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_name;
#pragma warning disable 0169
		static Delegate GetGet_nameHandler ()
		{
			if (cb_get_name == null)
				cb_get_name = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_name);
			return cb_get_name;
		}

		static IntPtr n_Get_name (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Stats_metric __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Stats_metric> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Get_name ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_metric']/method[@name='get_name' and count(parameter)=0]"
		[Register ("get_name", "()Ljava/lang/String;", "GetGet_nameHandler")]
		public virtual unsafe string Get_name ()
		{
			const string __id = "get_name.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
