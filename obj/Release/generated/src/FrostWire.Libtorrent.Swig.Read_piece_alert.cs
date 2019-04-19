using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='read_piece_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/read_piece_alert", DoNotGenerateAcw=true)]
	public partial class Read_piece_alert : global::FrostWire.Libtorrent.Swig.Torrent_alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='read_piece_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='read_piece_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='read_piece_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/read_piece_alert", typeof (Read_piece_alert));
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

		protected Read_piece_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='read_piece_alert']/constructor[@name='read_piece_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Read_piece_alert (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getError;
#pragma warning disable 0169
		static Delegate GetGetErrorHandler ()
		{
			if (cb_getError == null)
				cb_getError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetError);
			return cb_getError;
		}

		static IntPtr n_GetError (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Read_piece_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Read_piece_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Error);
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Error_code Error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='read_piece_alert']/method[@name='getError' and count(parameter)=0]"
			[Register ("getError", "()Lcom/frostwire/jlibtorrent/swig/error_code;", "GetGetErrorHandler")]
			get {
				const string __id = "getError.()Lcom/frostwire/jlibtorrent/swig/error_code;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Error_code> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::FrostWire.Libtorrent.Swig.Read_piece_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Read_piece_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Piece;
		}
#pragma warning restore 0169

		public virtual unsafe int Piece {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='read_piece_alert']/method[@name='getPiece' and count(parameter)=0]"
			[Register ("getPiece", "()I", "GetGetPieceHandler")]
			get {
				const string __id = "getPiece.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSize);
			return cb_getSize;
		}

		static int n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Read_piece_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Read_piece_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		public virtual unsafe int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='read_piece_alert']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				const string __id = "getSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_buffer_ptr;
#pragma warning disable 0169
		static Delegate GetBuffer_ptrHandler ()
		{
			if (cb_buffer_ptr == null)
				cb_buffer_ptr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Buffer_ptr);
			return cb_buffer_ptr;
		}

		static long n_Buffer_ptr (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Read_piece_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Read_piece_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Buffer_ptr ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='read_piece_alert']/method[@name='buffer_ptr' and count(parameter)=0]"
		[Register ("buffer_ptr", "()J", "GetBuffer_ptrHandler")]
		public virtual unsafe long Buffer_ptr ()
		{
			const string __id = "buffer_ptr.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='read_piece_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.read_piece_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/read_piece_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Read_piece_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/read_piece_alert;)J";
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
