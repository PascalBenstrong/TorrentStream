using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_uploaded_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/block_uploaded_alert", DoNotGenerateAcw=true)]
	public partial class Block_uploaded_alert : global::FrostWire.Libtorrent.Swig.Peer_alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_uploaded_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_uploaded_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_uploaded_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/block_uploaded_alert", typeof (Block_uploaded_alert));
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

		protected Block_uploaded_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_uploaded_alert']/constructor[@name='block_uploaded_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Block_uploaded_alert (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getBlock_index;
#pragma warning disable 0169
		static Delegate GetGetBlock_indexHandler ()
		{
			if (cb_getBlock_index == null)
				cb_getBlock_index = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBlock_index);
			return cb_getBlock_index;
		}

		static int n_GetBlock_index (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Block_uploaded_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_uploaded_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Block_index;
		}
#pragma warning restore 0169

		public virtual unsafe int Block_index {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_uploaded_alert']/method[@name='getBlock_index' and count(parameter)=0]"
			[Register ("getBlock_index", "()I", "GetGetBlock_indexHandler")]
			get {
				const string __id = "getBlock_index.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPiece_index;
#pragma warning disable 0169
		static Delegate GetGetPiece_indexHandler ()
		{
			if (cb_getPiece_index == null)
				cb_getPiece_index = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPiece_index);
			return cb_getPiece_index;
		}

		static int n_GetPiece_index (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Block_uploaded_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_uploaded_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Piece_index;
		}
#pragma warning restore 0169

		public virtual unsafe int Piece_index {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_uploaded_alert']/method[@name='getPiece_index' and count(parameter)=0]"
			[Register ("getPiece_index", "()I", "GetGetPiece_indexHandler")]
			get {
				const string __id = "getPiece_index.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_uploaded_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.block_uploaded_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/block_uploaded_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Block_uploaded_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/block_uploaded_alert;)J";
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
