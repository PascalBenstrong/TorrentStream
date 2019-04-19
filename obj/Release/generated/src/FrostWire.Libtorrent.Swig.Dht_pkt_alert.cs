using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_pkt_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/dht_pkt_alert", DoNotGenerateAcw=true)]
	public partial class Dht_pkt_alert : global::FrostWire.Libtorrent.Swig.Alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_pkt_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_pkt_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_pkt_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_pkt_alert.direction_t']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/dht_pkt_alert$direction_t", DoNotGenerateAcw=true)]
		public sealed partial class Direction_t : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_pkt_alert.direction_t']/field[@name='incoming']"
			[Register ("incoming")]
			public static global::FrostWire.Libtorrent.Swig.Dht_pkt_alert.Direction_t Incoming {
				get {
					const string __id = "incoming.Lcom/frostwire/jlibtorrent/swig/dht_pkt_alert$direction_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_pkt_alert.Direction_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_pkt_alert.direction_t']/field[@name='outgoing']"
			[Register ("outgoing")]
			public static global::FrostWire.Libtorrent.Swig.Dht_pkt_alert.Direction_t Outgoing {
				get {
					const string __id = "outgoing.Lcom/frostwire/jlibtorrent/swig/dht_pkt_alert$direction_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_pkt_alert.Direction_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/dht_pkt_alert$direction_t", typeof (Direction_t));
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

			internal Direction_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_pkt_alert.direction_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/dht_pkt_alert$direction_t;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Dht_pkt_alert.Direction_t SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/dht_pkt_alert$direction_t;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_pkt_alert.Direction_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_pkt_alert.direction_t']/method[@name='swigValue' and count(parameter)=0]"
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/dht_pkt_alert", typeof (Dht_pkt_alert));
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

		protected Dht_pkt_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_pkt_alert']/constructor[@name='dht_pkt_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Dht_pkt_alert (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getDirection;
#pragma warning disable 0169
		static Delegate GetGetDirectionHandler ()
		{
			if (cb_getDirection == null)
				cb_getDirection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDirection);
			return cb_getDirection;
		}

		static IntPtr n_GetDirection (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_pkt_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_pkt_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Direction);
		}
#pragma warning restore 0169

		static Delegate cb_setDirection_Lcom_frostwire_jlibtorrent_swig_dht_pkt_alert_direction_t_;
#pragma warning disable 0169
		static Delegate GetSetDirection_Lcom_frostwire_jlibtorrent_swig_dht_pkt_alert_direction_t_Handler ()
		{
			if (cb_setDirection_Lcom_frostwire_jlibtorrent_swig_dht_pkt_alert_direction_t_ == null)
				cb_setDirection_Lcom_frostwire_jlibtorrent_swig_dht_pkt_alert_direction_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDirection_Lcom_frostwire_jlibtorrent_swig_dht_pkt_alert_direction_t_);
			return cb_setDirection_Lcom_frostwire_jlibtorrent_swig_dht_pkt_alert_direction_t_;
		}

		static void n_SetDirection_Lcom_frostwire_jlibtorrent_swig_dht_pkt_alert_direction_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_pkt_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_pkt_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Dht_pkt_alert.Direction_t value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_pkt_alert.Direction_t> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Direction = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Dht_pkt_alert.Direction_t Direction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_pkt_alert']/method[@name='getDirection' and count(parameter)=0]"
			[Register ("getDirection", "()Lcom/frostwire/jlibtorrent/swig/dht_pkt_alert$direction_t;", "GetGetDirectionHandler")]
			get {
				const string __id = "getDirection.()Lcom/frostwire/jlibtorrent/swig/dht_pkt_alert$direction_t;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_pkt_alert.Direction_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_pkt_alert']/method[@name='setDirection' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_pkt_alert.direction_t']]"
			[Register ("setDirection", "(Lcom/frostwire/jlibtorrent/swig/dht_pkt_alert$direction_t;)V", "GetSetDirection_Lcom_frostwire_jlibtorrent_swig_dht_pkt_alert_direction_t_Handler")]
			set {
				const string __id = "setDirection.(Lcom/frostwire/jlibtorrent/swig/dht_pkt_alert$direction_t;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_pkt_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_pkt_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/dht_pkt_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Dht_pkt_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/dht_pkt_alert;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_node;
#pragma warning disable 0169
		static Delegate GetGet_nodeHandler ()
		{
			if (cb_get_node == null)
				cb_get_node = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_node);
			return cb_get_node;
		}

		static IntPtr n_Get_node (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_pkt_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_pkt_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_node ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_pkt_alert']/method[@name='get_node' and count(parameter)=0]"
		[Register ("get_node", "()Lcom/frostwire/jlibtorrent/swig/udp_endpoint;", "GetGet_nodeHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Udp_endpoint Get_node ()
		{
			const string __id = "get_node.()Lcom/frostwire/jlibtorrent/swig/udp_endpoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Udp_endpoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_pkt_buf;
#pragma warning disable 0169
		static Delegate GetPkt_bufHandler ()
		{
			if (cb_pkt_buf == null)
				cb_pkt_buf = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Pkt_buf);
			return cb_pkt_buf;
		}

		static IntPtr n_Pkt_buf (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_pkt_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_pkt_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pkt_buf ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_pkt_alert']/method[@name='pkt_buf' and count(parameter)=0]"
		[Register ("pkt_buf", "()Lcom/frostwire/jlibtorrent/swig/byte_const_span;", "GetPkt_bufHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_const_span Pkt_buf ()
		{
			const string __id = "pkt_buf.()Lcom/frostwire/jlibtorrent/swig/byte_const_span;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_const_span> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
