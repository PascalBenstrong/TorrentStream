using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connect_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/peer_connect_alert", DoNotGenerateAcw=true)]
	public partial class Peer_connect_alert : global::FrostWire.Libtorrent.Swig.Peer_alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connect_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connect_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connect_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/peer_connect_alert", typeof (Peer_connect_alert));
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

		protected Peer_connect_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connect_alert']/constructor[@name='peer_connect_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Peer_connect_alert (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getSocket_type;
#pragma warning disable 0169
		static Delegate GetGetSocket_typeHandler ()
		{
			if (cb_getSocket_type == null)
				cb_getSocket_type = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSocket_type);
			return cb_getSocket_type;
		}

		static int n_GetSocket_type (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_connect_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connect_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Socket_type;
		}
#pragma warning restore 0169

		public virtual unsafe int Socket_type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connect_alert']/method[@name='getSocket_type' and count(parameter)=0]"
			[Register ("getSocket_type", "()I", "GetGetSocket_typeHandler")]
			get {
				const string __id = "getSocket_type.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_connect_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_connect_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/peer_connect_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Peer_connect_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/peer_connect_alert;)J";
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
