using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='partial_piece_info']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/partial_piece_info", DoNotGenerateAcw=true)]
	public partial class Partial_piece_info : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='partial_piece_info']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/partial_piece_info", typeof (Partial_piece_info));
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

		protected Partial_piece_info (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='partial_piece_info']/constructor[@name='partial_piece_info' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Partial_piece_info ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='partial_piece_info']/constructor[@name='partial_piece_info' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Partial_piece_info (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getBlocks_in_piece;
#pragma warning disable 0169
		static Delegate GetGetBlocks_in_pieceHandler ()
		{
			if (cb_getBlocks_in_piece == null)
				cb_getBlocks_in_piece = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBlocks_in_piece);
			return cb_getBlocks_in_piece;
		}

		static int n_GetBlocks_in_piece (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Partial_piece_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Partial_piece_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Blocks_in_piece;
		}
#pragma warning restore 0169

		static Delegate cb_setBlocks_in_piece_I;
#pragma warning disable 0169
		static Delegate GetSetBlocks_in_piece_IHandler ()
		{
			if (cb_setBlocks_in_piece_I == null)
				cb_setBlocks_in_piece_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBlocks_in_piece_I);
			return cb_setBlocks_in_piece_I;
		}

		static void n_SetBlocks_in_piece_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Partial_piece_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Partial_piece_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Blocks_in_piece = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Blocks_in_piece {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='partial_piece_info']/method[@name='getBlocks_in_piece' and count(parameter)=0]"
			[Register ("getBlocks_in_piece", "()I", "GetGetBlocks_in_pieceHandler")]
			get {
				const string __id = "getBlocks_in_piece.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='partial_piece_info']/method[@name='setBlocks_in_piece' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBlocks_in_piece", "(I)V", "GetSetBlocks_in_piece_IHandler")]
			set {
				const string __id = "setBlocks_in_piece.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFinished;
#pragma warning disable 0169
		static Delegate GetGetFinishedHandler ()
		{
			if (cb_getFinished == null)
				cb_getFinished = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFinished);
			return cb_getFinished;
		}

		static int n_GetFinished (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Partial_piece_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Partial_piece_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Finished;
		}
#pragma warning restore 0169

		static Delegate cb_setFinished_I;
#pragma warning disable 0169
		static Delegate GetSetFinished_IHandler ()
		{
			if (cb_setFinished_I == null)
				cb_setFinished_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFinished_I);
			return cb_setFinished_I;
		}

		static void n_SetFinished_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Partial_piece_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Partial_piece_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finished = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Finished {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='partial_piece_info']/method[@name='getFinished' and count(parameter)=0]"
			[Register ("getFinished", "()I", "GetGetFinishedHandler")]
			get {
				const string __id = "getFinished.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='partial_piece_info']/method[@name='setFinished' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFinished", "(I)V", "GetSetFinished_IHandler")]
			set {
				const string __id = "setFinished.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::FrostWire.Libtorrent.Swig.Partial_piece_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Partial_piece_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Piece_index;
		}
#pragma warning restore 0169

		static Delegate cb_setPiece_index_I;
#pragma warning disable 0169
		static Delegate GetSetPiece_index_IHandler ()
		{
			if (cb_setPiece_index_I == null)
				cb_setPiece_index_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPiece_index_I);
			return cb_setPiece_index_I;
		}

		static void n_SetPiece_index_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Partial_piece_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Partial_piece_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Piece_index = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Piece_index {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='partial_piece_info']/method[@name='getPiece_index' and count(parameter)=0]"
			[Register ("getPiece_index", "()I", "GetGetPiece_indexHandler")]
			get {
				const string __id = "getPiece_index.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='partial_piece_info']/method[@name='setPiece_index' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPiece_index", "(I)V", "GetSetPiece_index_IHandler")]
			set {
				const string __id = "setPiece_index.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRequested;
#pragma warning disable 0169
		static Delegate GetGetRequestedHandler ()
		{
			if (cb_getRequested == null)
				cb_getRequested = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRequested);
			return cb_getRequested;
		}

		static int n_GetRequested (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Partial_piece_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Partial_piece_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Requested;
		}
#pragma warning restore 0169

		static Delegate cb_setRequested_I;
#pragma warning disable 0169
		static Delegate GetSetRequested_IHandler ()
		{
			if (cb_setRequested_I == null)
				cb_setRequested_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRequested_I);
			return cb_setRequested_I;
		}

		static void n_SetRequested_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Partial_piece_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Partial_piece_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Requested = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Requested {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='partial_piece_info']/method[@name='getRequested' and count(parameter)=0]"
			[Register ("getRequested", "()I", "GetGetRequestedHandler")]
			get {
				const string __id = "getRequested.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='partial_piece_info']/method[@name='setRequested' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRequested", "(I)V", "GetSetRequested_IHandler")]
			set {
				const string __id = "setRequested.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWriting;
#pragma warning disable 0169
		static Delegate GetGetWritingHandler ()
		{
			if (cb_getWriting == null)
				cb_getWriting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWriting);
			return cb_getWriting;
		}

		static int n_GetWriting (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Partial_piece_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Partial_piece_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Writing;
		}
#pragma warning restore 0169

		static Delegate cb_setWriting_I;
#pragma warning disable 0169
		static Delegate GetSetWriting_IHandler ()
		{
			if (cb_setWriting_I == null)
				cb_setWriting_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWriting_I);
			return cb_setWriting_I;
		}

		static void n_SetWriting_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Partial_piece_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Partial_piece_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Writing = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Writing {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='partial_piece_info']/method[@name='getWriting' and count(parameter)=0]"
			[Register ("getWriting", "()I", "GetGetWritingHandler")]
			get {
				const string __id = "getWriting.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='partial_piece_info']/method[@name='setWriting' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWriting", "(I)V", "GetSetWriting_IHandler")]
			set {
				const string __id = "setWriting.(I)V";
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
			global::FrostWire.Libtorrent.Swig.Partial_piece_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Partial_piece_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='partial_piece_info']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='partial_piece_info']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.partial_piece_info']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/partial_piece_info;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Partial_piece_info obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/partial_piece_info;)J";
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
