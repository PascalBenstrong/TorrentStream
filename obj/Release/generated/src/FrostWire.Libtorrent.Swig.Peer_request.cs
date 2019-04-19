using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_request']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/peer_request", DoNotGenerateAcw=true)]
	public partial class Peer_request : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_request']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/peer_request", typeof (Peer_request));
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

		protected Peer_request (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_request']/constructor[@name='peer_request' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Peer_request ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_request']/constructor[@name='peer_request' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Peer_request (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getLength;
#pragma warning disable 0169
		static Delegate GetGetLengthHandler ()
		{
			if (cb_getLength == null)
				cb_getLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLength);
			return cb_getLength;
		}

		static int n_GetLength (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_request __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length;
		}
#pragma warning restore 0169

		static Delegate cb_setLength_I;
#pragma warning disable 0169
		static Delegate GetSetLength_IHandler ()
		{
			if (cb_setLength_I == null)
				cb_setLength_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLength_I);
			return cb_setLength_I;
		}

		static void n_SetLength_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_request __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Length = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Length {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_request']/method[@name='getLength' and count(parameter)=0]"
			[Register ("getLength", "()I", "GetGetLengthHandler")]
			get {
				const string __id = "getLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_request']/method[@name='setLength' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLength", "(I)V", "GetSetLength_IHandler")]
			set {
				const string __id = "setLength.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPiece;
#pragma warning disable 0169
		static Delegate GetGetPieceHandler ()
		{
			if (cb_getPiece == null)
				cb_getPiece = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPiece);
			return cb_getPiece;
		}

		static int n_GetPiece (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_request __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Piece;
		}
#pragma warning restore 0169

		static Delegate cb_setPiece_I;
#pragma warning disable 0169
		static Delegate GetSetPiece_IHandler ()
		{
			if (cb_setPiece_I == null)
				cb_setPiece_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPiece_I);
			return cb_setPiece_I;
		}

		static void n_SetPiece_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_request __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Piece = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Piece {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_request']/method[@name='getPiece' and count(parameter)=0]"
			[Register ("getPiece", "()I", "GetGetPieceHandler")]
			get {
				const string __id = "getPiece.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_request']/method[@name='setPiece' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPiece", "(I)V", "GetSetPiece_IHandler")]
			set {
				const string __id = "setPiece.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStart;
#pragma warning disable 0169
		static Delegate GetGetStartHandler ()
		{
			if (cb_getStart == null)
				cb_getStart = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStart);
			return cb_getStart;
		}

		static int n_GetStart (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_request __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Start;
		}
#pragma warning restore 0169

		static Delegate cb_setStart_I;
#pragma warning disable 0169
		static Delegate GetSetStart_IHandler ()
		{
			if (cb_setStart_I == null)
				cb_setStart_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStart_I);
			return cb_setStart_I;
		}

		static void n_SetStart_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_request __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Start {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_request']/method[@name='getStart' and count(parameter)=0]"
			[Register ("getStart", "()I", "GetGetStartHandler")]
			get {
				const string __id = "getStart.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_request']/method[@name='setStart' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStart", "(I)V", "GetSetStart_IHandler")]
			set {
				const string __id = "setStart.(I)V";
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
			global::FrostWire.Libtorrent.Swig.Peer_request __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_request']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_request']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_request']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/peer_request;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Peer_request obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/peer_request;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_op_eq_Lcom_frostwire_jlibtorrent_swig_peer_request_;
#pragma warning disable 0169
		static Delegate GetOp_eq_Lcom_frostwire_jlibtorrent_swig_peer_request_Handler ()
		{
			if (cb_op_eq_Lcom_frostwire_jlibtorrent_swig_peer_request_ == null)
				cb_op_eq_Lcom_frostwire_jlibtorrent_swig_peer_request_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Op_eq_Lcom_frostwire_jlibtorrent_swig_peer_request_);
			return cb_op_eq_Lcom_frostwire_jlibtorrent_swig_peer_request_;
		}

		static bool n_Op_eq_Lcom_frostwire_jlibtorrent_swig_peer_request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_r)
		{
			global::FrostWire.Libtorrent.Swig.Peer_request __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Peer_request r = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_request> (native_r, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Op_eq (r);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_request']/method[@name='op_eq' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_request']]"
		[Register ("op_eq", "(Lcom/frostwire/jlibtorrent/swig/peer_request;)Z", "GetOp_eq_Lcom_frostwire_jlibtorrent_swig_peer_request_Handler")]
		public virtual unsafe bool Op_eq (global::FrostWire.Libtorrent.Swig.Peer_request r)
		{
			const string __id = "op_eq.(Lcom/frostwire/jlibtorrent/swig/peer_request;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
