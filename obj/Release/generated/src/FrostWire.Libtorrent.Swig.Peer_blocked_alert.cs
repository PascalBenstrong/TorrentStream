using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_blocked_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/peer_blocked_alert", DoNotGenerateAcw=true)]
	public partial class Peer_blocked_alert : global::FrostWire.Libtorrent.Swig.Peer_alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_blocked_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_blocked_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_blocked_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_blocked_alert.reason_t']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/peer_blocked_alert$reason_t", DoNotGenerateAcw=true)]
		public sealed partial class Reason_t : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_blocked_alert.reason_t']/field[@name='i2p_mixed']"
			[Register ("i2p_mixed")]
			public static global::FrostWire.Libtorrent.Swig.Peer_blocked_alert.Reason_t I2pMixed {
				get {
					const string __id = "i2p_mixed.Lcom/frostwire/jlibtorrent/swig/peer_blocked_alert$reason_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_blocked_alert.Reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_blocked_alert.reason_t']/field[@name='invalid_local_interface']"
			[Register ("invalid_local_interface")]
			public static global::FrostWire.Libtorrent.Swig.Peer_blocked_alert.Reason_t InvalidLocalInterface {
				get {
					const string __id = "invalid_local_interface.Lcom/frostwire/jlibtorrent/swig/peer_blocked_alert$reason_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_blocked_alert.Reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_blocked_alert.reason_t']/field[@name='ip_filter']"
			[Register ("ip_filter")]
			public static global::FrostWire.Libtorrent.Swig.Peer_blocked_alert.Reason_t IpFilter {
				get {
					const string __id = "ip_filter.Lcom/frostwire/jlibtorrent/swig/peer_blocked_alert$reason_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_blocked_alert.Reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_blocked_alert.reason_t']/field[@name='port_filter']"
			[Register ("port_filter")]
			public static global::FrostWire.Libtorrent.Swig.Peer_blocked_alert.Reason_t PortFilter {
				get {
					const string __id = "port_filter.Lcom/frostwire/jlibtorrent/swig/peer_blocked_alert$reason_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_blocked_alert.Reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_blocked_alert.reason_t']/field[@name='privileged_ports']"
			[Register ("privileged_ports")]
			public static global::FrostWire.Libtorrent.Swig.Peer_blocked_alert.Reason_t PrivilegedPorts {
				get {
					const string __id = "privileged_ports.Lcom/frostwire/jlibtorrent/swig/peer_blocked_alert$reason_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_blocked_alert.Reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_blocked_alert.reason_t']/field[@name='tcp_disabled']"
			[Register ("tcp_disabled")]
			public static global::FrostWire.Libtorrent.Swig.Peer_blocked_alert.Reason_t TcpDisabled {
				get {
					const string __id = "tcp_disabled.Lcom/frostwire/jlibtorrent/swig/peer_blocked_alert$reason_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_blocked_alert.Reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_blocked_alert.reason_t']/field[@name='utp_disabled']"
			[Register ("utp_disabled")]
			public static global::FrostWire.Libtorrent.Swig.Peer_blocked_alert.Reason_t UtpDisabled {
				get {
					const string __id = "utp_disabled.Lcom/frostwire/jlibtorrent/swig/peer_blocked_alert$reason_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_blocked_alert.Reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/peer_blocked_alert$reason_t", typeof (Reason_t));
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

			internal Reason_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_blocked_alert.reason_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/peer_blocked_alert$reason_t;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Peer_blocked_alert.Reason_t SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/peer_blocked_alert$reason_t;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_blocked_alert.Reason_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_blocked_alert.reason_t']/method[@name='swigValue' and count(parameter)=0]"
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/peer_blocked_alert", typeof (Peer_blocked_alert));
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

		protected Peer_blocked_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_blocked_alert']/constructor[@name='peer_blocked_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Peer_blocked_alert (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getReason;
#pragma warning disable 0169
		static Delegate GetGetReasonHandler ()
		{
			if (cb_getReason == null)
				cb_getReason = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReason);
			return cb_getReason;
		}

		static int n_GetReason (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_blocked_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_blocked_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Reason;
		}
#pragma warning restore 0169

		public virtual unsafe int Reason {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_blocked_alert']/method[@name='getReason' and count(parameter)=0]"
			[Register ("getReason", "()I", "GetGetReasonHandler")]
			get {
				const string __id = "getReason.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_blocked_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_blocked_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/peer_blocked_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Peer_blocked_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/peer_blocked_alert;)J";
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
