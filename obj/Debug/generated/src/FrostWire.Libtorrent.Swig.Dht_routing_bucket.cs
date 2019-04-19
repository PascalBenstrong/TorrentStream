using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_routing_bucket']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/dht_routing_bucket", DoNotGenerateAcw=true)]
	public partial class Dht_routing_bucket : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_routing_bucket']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/dht_routing_bucket", typeof (Dht_routing_bucket));
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

		protected Dht_routing_bucket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_routing_bucket']/constructor[@name='dht_routing_bucket' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Dht_routing_bucket ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_routing_bucket']/constructor[@name='dht_routing_bucket' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Dht_routing_bucket (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getLast_active;
#pragma warning disable 0169
		static Delegate GetGetLast_activeHandler ()
		{
			if (cb_getLast_active == null)
				cb_getLast_active = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLast_active);
			return cb_getLast_active;
		}

		static int n_GetLast_active (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_routing_bucket __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_routing_bucket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Last_active;
		}
#pragma warning restore 0169

		static Delegate cb_setLast_active_I;
#pragma warning disable 0169
		static Delegate GetSetLast_active_IHandler ()
		{
			if (cb_setLast_active_I == null)
				cb_setLast_active_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLast_active_I);
			return cb_setLast_active_I;
		}

		static void n_SetLast_active_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_routing_bucket __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_routing_bucket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Last_active = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Last_active {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_routing_bucket']/method[@name='getLast_active' and count(parameter)=0]"
			[Register ("getLast_active", "()I", "GetGetLast_activeHandler")]
			get {
				const string __id = "getLast_active.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_routing_bucket']/method[@name='setLast_active' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLast_active", "(I)V", "GetSetLast_active_IHandler")]
			set {
				const string __id = "setLast_active.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNum_nodes;
#pragma warning disable 0169
		static Delegate GetGetNum_nodesHandler ()
		{
			if (cb_getNum_nodes == null)
				cb_getNum_nodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNum_nodes);
			return cb_getNum_nodes;
		}

		static int n_GetNum_nodes (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_routing_bucket __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_routing_bucket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_nodes;
		}
#pragma warning restore 0169

		static Delegate cb_setNum_nodes_I;
#pragma warning disable 0169
		static Delegate GetSetNum_nodes_IHandler ()
		{
			if (cb_setNum_nodes_I == null)
				cb_setNum_nodes_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNum_nodes_I);
			return cb_setNum_nodes_I;
		}

		static void n_SetNum_nodes_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_routing_bucket __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_routing_bucket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Num_nodes = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Num_nodes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_routing_bucket']/method[@name='getNum_nodes' and count(parameter)=0]"
			[Register ("getNum_nodes", "()I", "GetGetNum_nodesHandler")]
			get {
				const string __id = "getNum_nodes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_routing_bucket']/method[@name='setNum_nodes' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNum_nodes", "(I)V", "GetSetNum_nodes_IHandler")]
			set {
				const string __id = "setNum_nodes.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNum_replacements;
#pragma warning disable 0169
		static Delegate GetGetNum_replacementsHandler ()
		{
			if (cb_getNum_replacements == null)
				cb_getNum_replacements = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNum_replacements);
			return cb_getNum_replacements;
		}

		static int n_GetNum_replacements (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_routing_bucket __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_routing_bucket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_replacements;
		}
#pragma warning restore 0169

		static Delegate cb_setNum_replacements_I;
#pragma warning disable 0169
		static Delegate GetSetNum_replacements_IHandler ()
		{
			if (cb_setNum_replacements_I == null)
				cb_setNum_replacements_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNum_replacements_I);
			return cb_setNum_replacements_I;
		}

		static void n_SetNum_replacements_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_routing_bucket __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_routing_bucket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Num_replacements = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Num_replacements {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_routing_bucket']/method[@name='getNum_replacements' and count(parameter)=0]"
			[Register ("getNum_replacements", "()I", "GetGetNum_replacementsHandler")]
			get {
				const string __id = "getNum_replacements.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_routing_bucket']/method[@name='setNum_replacements' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNum_replacements", "(I)V", "GetSetNum_replacements_IHandler")]
			set {
				const string __id = "setNum_replacements.(I)V";
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
			global::FrostWire.Libtorrent.Swig.Dht_routing_bucket __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_routing_bucket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_routing_bucket']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_routing_bucket']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_routing_bucket']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/dht_routing_bucket;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Dht_routing_bucket obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/dht_routing_bucket;)J";
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
