using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/add_torrent_params", DoNotGenerateAcw=true)]
	public partial class Add_torrent_params : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/add_torrent_params", typeof (Add_torrent_params));
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

		protected Add_torrent_params (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/constructor[@name='add_torrent_params' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Add_torrent_params (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getActive_time;
#pragma warning disable 0169
		static Delegate GetGetActive_timeHandler ()
		{
			if (cb_getActive_time == null)
				cb_getActive_time = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetActive_time);
			return cb_getActive_time;
		}

		static int n_GetActive_time (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Active_time;
		}
#pragma warning restore 0169

		static Delegate cb_setActive_time_I;
#pragma warning disable 0169
		static Delegate GetSetActive_time_IHandler ()
		{
			if (cb_setActive_time_I == null)
				cb_setActive_time_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetActive_time_I);
			return cb_setActive_time_I;
		}

		static void n_SetActive_time_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Active_time = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Active_time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getActive_time' and count(parameter)=0]"
			[Register ("getActive_time", "()I", "GetGetActive_timeHandler")]
			get {
				const string __id = "getActive_time.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setActive_time' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setActive_time", "(I)V", "GetSetActive_time_IHandler")]
			set {
				const string __id = "setActive_time.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAdded_time;
#pragma warning disable 0169
		static Delegate GetGetAdded_timeHandler ()
		{
			if (cb_getAdded_time == null)
				cb_getAdded_time = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAdded_time);
			return cb_getAdded_time;
		}

		static long n_GetAdded_time (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Added_time;
		}
#pragma warning restore 0169

		static Delegate cb_setAdded_time_J;
#pragma warning disable 0169
		static Delegate GetSetAdded_time_JHandler ()
		{
			if (cb_setAdded_time_J == null)
				cb_setAdded_time_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetAdded_time_J);
			return cb_setAdded_time_J;
		}

		static void n_SetAdded_time_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Added_time = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Added_time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getAdded_time' and count(parameter)=0]"
			[Register ("getAdded_time", "()J", "GetGetAdded_timeHandler")]
			get {
				const string __id = "getAdded_time.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setAdded_time' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setAdded_time", "(J)V", "GetSetAdded_time_JHandler")]
			set {
				const string __id = "setAdded_time.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCompleted_time;
#pragma warning disable 0169
		static Delegate GetGetCompleted_timeHandler ()
		{
			if (cb_getCompleted_time == null)
				cb_getCompleted_time = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCompleted_time);
			return cb_getCompleted_time;
		}

		static long n_GetCompleted_time (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Completed_time;
		}
#pragma warning restore 0169

		static Delegate cb_setCompleted_time_J;
#pragma warning disable 0169
		static Delegate GetSetCompleted_time_JHandler ()
		{
			if (cb_setCompleted_time_J == null)
				cb_setCompleted_time_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetCompleted_time_J);
			return cb_setCompleted_time_J;
		}

		static void n_SetCompleted_time_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Completed_time = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Completed_time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getCompleted_time' and count(parameter)=0]"
			[Register ("getCompleted_time", "()J", "GetGetCompleted_timeHandler")]
			get {
				const string __id = "getCompleted_time.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setCompleted_time' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setCompleted_time", "(J)V", "GetSetCompleted_time_JHandler")]
			set {
				const string __id = "setCompleted_time.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDownload_limit;
#pragma warning disable 0169
		static Delegate GetGetDownload_limitHandler ()
		{
			if (cb_getDownload_limit == null)
				cb_getDownload_limit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDownload_limit);
			return cb_getDownload_limit;
		}

		static int n_GetDownload_limit (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Download_limit;
		}
#pragma warning restore 0169

		static Delegate cb_setDownload_limit_I;
#pragma warning disable 0169
		static Delegate GetSetDownload_limit_IHandler ()
		{
			if (cb_setDownload_limit_I == null)
				cb_setDownload_limit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDownload_limit_I);
			return cb_setDownload_limit_I;
		}

		static void n_SetDownload_limit_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Download_limit = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Download_limit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getDownload_limit' and count(parameter)=0]"
			[Register ("getDownload_limit", "()I", "GetGetDownload_limitHandler")]
			get {
				const string __id = "getDownload_limit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setDownload_limit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDownload_limit", "(I)V", "GetSetDownload_limit_IHandler")]
			set {
				const string __id = "setDownload_limit.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFinished_time;
#pragma warning disable 0169
		static Delegate GetGetFinished_timeHandler ()
		{
			if (cb_getFinished_time == null)
				cb_getFinished_time = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFinished_time);
			return cb_getFinished_time;
		}

		static int n_GetFinished_time (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Finished_time;
		}
#pragma warning restore 0169

		static Delegate cb_setFinished_time_I;
#pragma warning disable 0169
		static Delegate GetSetFinished_time_IHandler ()
		{
			if (cb_setFinished_time_I == null)
				cb_setFinished_time_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFinished_time_I);
			return cb_setFinished_time_I;
		}

		static void n_SetFinished_time_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Finished_time = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Finished_time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getFinished_time' and count(parameter)=0]"
			[Register ("getFinished_time", "()I", "GetGetFinished_timeHandler")]
			get {
				const string __id = "getFinished_time.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setFinished_time' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFinished_time", "(I)V", "GetSetFinished_time_IHandler")]
			set {
				const string __id = "setFinished_time.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFlags;
#pragma warning disable 0169
		static Delegate GetGetFlagsHandler ()
		{
			if (cb_getFlags == null)
				cb_getFlags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFlags);
			return cb_getFlags;
		}

		static IntPtr n_GetFlags (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Flags);
		}
#pragma warning restore 0169

		static Delegate cb_setFlags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_;
#pragma warning disable 0169
		static Delegate GetSetFlags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_Handler ()
		{
			if (cb_setFlags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_ == null)
				cb_setFlags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFlags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_);
			return cb_setFlags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_;
		}

		static void n_SetFlags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Torrent_flags_t value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Flags = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Flags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getFlags' and count(parameter)=0]"
			[Register ("getFlags", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetGetFlagsHandler")]
			get {
				const string __id = "getFlags.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setFlags' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_flags_t']]"
			[Register ("setFlags", "(Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;)V", "GetSetFlags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_Handler")]
			set {
				const string __id = "setFlags.(Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHave_pieces;
#pragma warning disable 0169
		static Delegate GetGetHave_piecesHandler ()
		{
			if (cb_getHave_pieces == null)
				cb_getHave_pieces = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHave_pieces);
			return cb_getHave_pieces;
		}

		static IntPtr n_GetHave_pieces (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Have_pieces);
		}
#pragma warning restore 0169

		static Delegate cb_setHave_pieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_;
#pragma warning disable 0169
		static Delegate GetSetHave_pieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_Handler ()
		{
			if (cb_setHave_pieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_ == null)
				cb_setHave_pieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHave_pieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_);
			return cb_setHave_pieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_;
		}

		static void n_SetHave_pieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Have_pieces = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Piece_index_bitfield Have_pieces {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getHave_pieces' and count(parameter)=0]"
			[Register ("getHave_pieces", "()Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;", "GetGetHave_piecesHandler")]
			get {
				const string __id = "getHave_pieces.()Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setHave_pieces' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.piece_index_bitfield']]"
			[Register ("setHave_pieces", "(Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;)V", "GetSetHave_pieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_Handler")]
			set {
				const string __id = "setHave_pieces.(Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getInfo_hash;
#pragma warning disable 0169
		static Delegate GetGetInfo_hashHandler ()
		{
			if (cb_getInfo_hash == null)
				cb_getInfo_hash = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInfo_hash);
			return cb_getInfo_hash;
		}

		static IntPtr n_GetInfo_hash (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Info_hash);
		}
#pragma warning restore 0169

		static Delegate cb_setInfo_hash_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetSetInfo_hash_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_setInfo_hash_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_setInfo_hash_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInfo_hash_Lcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_setInfo_hash_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static void n_SetInfo_hash_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Info_hash = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash Info_hash {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getInfo_hash' and count(parameter)=0]"
			[Register ("getInfo_hash", "()Lcom/frostwire/jlibtorrent/swig/sha1_hash;", "GetGetInfo_hashHandler")]
			get {
				const string __id = "getInfo_hash.()Lcom/frostwire/jlibtorrent/swig/sha1_hash;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setInfo_hash' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
			[Register ("setInfo_hash", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V", "GetSetInfo_hash_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
			set {
				const string __id = "setInfo_hash.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLast_download;
#pragma warning disable 0169
		static Delegate GetGetLast_downloadHandler ()
		{
			if (cb_getLast_download == null)
				cb_getLast_download = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLast_download);
			return cb_getLast_download;
		}

		static long n_GetLast_download (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Last_download;
		}
#pragma warning restore 0169

		static Delegate cb_setLast_download_J;
#pragma warning disable 0169
		static Delegate GetSetLast_download_JHandler ()
		{
			if (cb_setLast_download_J == null)
				cb_setLast_download_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLast_download_J);
			return cb_setLast_download_J;
		}

		static void n_SetLast_download_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Last_download = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Last_download {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getLast_download' and count(parameter)=0]"
			[Register ("getLast_download", "()J", "GetGetLast_downloadHandler")]
			get {
				const string __id = "getLast_download.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setLast_download' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLast_download", "(J)V", "GetSetLast_download_JHandler")]
			set {
				const string __id = "setLast_download.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLast_seen_complete;
#pragma warning disable 0169
		static Delegate GetGetLast_seen_completeHandler ()
		{
			if (cb_getLast_seen_complete == null)
				cb_getLast_seen_complete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLast_seen_complete);
			return cb_getLast_seen_complete;
		}

		static long n_GetLast_seen_complete (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Last_seen_complete;
		}
#pragma warning restore 0169

		static Delegate cb_setLast_seen_complete_J;
#pragma warning disable 0169
		static Delegate GetSetLast_seen_complete_JHandler ()
		{
			if (cb_setLast_seen_complete_J == null)
				cb_setLast_seen_complete_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLast_seen_complete_J);
			return cb_setLast_seen_complete_J;
		}

		static void n_SetLast_seen_complete_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Last_seen_complete = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Last_seen_complete {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getLast_seen_complete' and count(parameter)=0]"
			[Register ("getLast_seen_complete", "()J", "GetGetLast_seen_completeHandler")]
			get {
				const string __id = "getLast_seen_complete.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setLast_seen_complete' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLast_seen_complete", "(J)V", "GetSetLast_seen_complete_JHandler")]
			set {
				const string __id = "setLast_seen_complete.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLast_upload;
#pragma warning disable 0169
		static Delegate GetGetLast_uploadHandler ()
		{
			if (cb_getLast_upload == null)
				cb_getLast_upload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLast_upload);
			return cb_getLast_upload;
		}

		static long n_GetLast_upload (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Last_upload;
		}
#pragma warning restore 0169

		static Delegate cb_setLast_upload_J;
#pragma warning disable 0169
		static Delegate GetSetLast_upload_JHandler ()
		{
			if (cb_setLast_upload_J == null)
				cb_setLast_upload_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLast_upload_J);
			return cb_setLast_upload_J;
		}

		static void n_SetLast_upload_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Last_upload = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Last_upload {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getLast_upload' and count(parameter)=0]"
			[Register ("getLast_upload", "()J", "GetGetLast_uploadHandler")]
			get {
				const string __id = "getLast_upload.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setLast_upload' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLast_upload", "(J)V", "GetSetLast_upload_JHandler")]
			set {
				const string __id = "setLast_upload.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMax_connections;
#pragma warning disable 0169
		static Delegate GetGetMax_connectionsHandler ()
		{
			if (cb_getMax_connections == null)
				cb_getMax_connections = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMax_connections);
			return cb_getMax_connections;
		}

		static int n_GetMax_connections (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Max_connections;
		}
#pragma warning restore 0169

		static Delegate cb_setMax_connections_I;
#pragma warning disable 0169
		static Delegate GetSetMax_connections_IHandler ()
		{
			if (cb_setMax_connections_I == null)
				cb_setMax_connections_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMax_connections_I);
			return cb_setMax_connections_I;
		}

		static void n_SetMax_connections_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Max_connections = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Max_connections {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getMax_connections' and count(parameter)=0]"
			[Register ("getMax_connections", "()I", "GetGetMax_connectionsHandler")]
			get {
				const string __id = "getMax_connections.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setMax_connections' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMax_connections", "(I)V", "GetSetMax_connections_IHandler")]
			set {
				const string __id = "setMax_connections.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMax_uploads;
#pragma warning disable 0169
		static Delegate GetGetMax_uploadsHandler ()
		{
			if (cb_getMax_uploads == null)
				cb_getMax_uploads = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMax_uploads);
			return cb_getMax_uploads;
		}

		static int n_GetMax_uploads (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Max_uploads;
		}
#pragma warning restore 0169

		static Delegate cb_setMax_uploads_I;
#pragma warning disable 0169
		static Delegate GetSetMax_uploads_IHandler ()
		{
			if (cb_setMax_uploads_I == null)
				cb_setMax_uploads_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMax_uploads_I);
			return cb_setMax_uploads_I;
		}

		static void n_SetMax_uploads_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Max_uploads = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Max_uploads {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getMax_uploads' and count(parameter)=0]"
			[Register ("getMax_uploads", "()I", "GetGetMax_uploadsHandler")]
			get {
				const string __id = "getMax_uploads.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setMax_uploads' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMax_uploads", "(I)V", "GetSetMax_uploads_IHandler")]
			set {
				const string __id = "setMax_uploads.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Name = value;
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNum_complete;
#pragma warning disable 0169
		static Delegate GetGetNum_completeHandler ()
		{
			if (cb_getNum_complete == null)
				cb_getNum_complete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNum_complete);
			return cb_getNum_complete;
		}

		static int n_GetNum_complete (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_complete;
		}
#pragma warning restore 0169

		static Delegate cb_setNum_complete_I;
#pragma warning disable 0169
		static Delegate GetSetNum_complete_IHandler ()
		{
			if (cb_setNum_complete_I == null)
				cb_setNum_complete_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNum_complete_I);
			return cb_setNum_complete_I;
		}

		static void n_SetNum_complete_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Num_complete = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Num_complete {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getNum_complete' and count(parameter)=0]"
			[Register ("getNum_complete", "()I", "GetGetNum_completeHandler")]
			get {
				const string __id = "getNum_complete.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setNum_complete' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNum_complete", "(I)V", "GetSetNum_complete_IHandler")]
			set {
				const string __id = "setNum_complete.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNum_downloaded;
#pragma warning disable 0169
		static Delegate GetGetNum_downloadedHandler ()
		{
			if (cb_getNum_downloaded == null)
				cb_getNum_downloaded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNum_downloaded);
			return cb_getNum_downloaded;
		}

		static int n_GetNum_downloaded (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_downloaded;
		}
#pragma warning restore 0169

		static Delegate cb_setNum_downloaded_I;
#pragma warning disable 0169
		static Delegate GetSetNum_downloaded_IHandler ()
		{
			if (cb_setNum_downloaded_I == null)
				cb_setNum_downloaded_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNum_downloaded_I);
			return cb_setNum_downloaded_I;
		}

		static void n_SetNum_downloaded_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Num_downloaded = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Num_downloaded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getNum_downloaded' and count(parameter)=0]"
			[Register ("getNum_downloaded", "()I", "GetGetNum_downloadedHandler")]
			get {
				const string __id = "getNum_downloaded.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setNum_downloaded' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNum_downloaded", "(I)V", "GetSetNum_downloaded_IHandler")]
			set {
				const string __id = "setNum_downloaded.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNum_incomplete;
#pragma warning disable 0169
		static Delegate GetGetNum_incompleteHandler ()
		{
			if (cb_getNum_incomplete == null)
				cb_getNum_incomplete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNum_incomplete);
			return cb_getNum_incomplete;
		}

		static int n_GetNum_incomplete (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_incomplete;
		}
#pragma warning restore 0169

		static Delegate cb_setNum_incomplete_I;
#pragma warning disable 0169
		static Delegate GetSetNum_incomplete_IHandler ()
		{
			if (cb_setNum_incomplete_I == null)
				cb_setNum_incomplete_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNum_incomplete_I);
			return cb_setNum_incomplete_I;
		}

		static void n_SetNum_incomplete_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Num_incomplete = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Num_incomplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getNum_incomplete' and count(parameter)=0]"
			[Register ("getNum_incomplete", "()I", "GetGetNum_incompleteHandler")]
			get {
				const string __id = "getNum_incomplete.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setNum_incomplete' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNum_incomplete", "(I)V", "GetSetNum_incomplete_IHandler")]
			set {
				const string __id = "setNum_incomplete.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSave_path;
#pragma warning disable 0169
		static Delegate GetGetSave_pathHandler ()
		{
			if (cb_getSave_path == null)
				cb_getSave_path = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSave_path);
			return cb_getSave_path;
		}

		static IntPtr n_GetSave_path (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Save_path);
		}
#pragma warning restore 0169

		static Delegate cb_setSave_path_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSave_path_Ljava_lang_String_Handler ()
		{
			if (cb_setSave_path_Ljava_lang_String_ == null)
				cb_setSave_path_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSave_path_Ljava_lang_String_);
			return cb_setSave_path_Ljava_lang_String_;
		}

		static void n_SetSave_path_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Save_path = value;
		}
#pragma warning restore 0169

		public virtual unsafe string Save_path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getSave_path' and count(parameter)=0]"
			[Register ("getSave_path", "()Ljava/lang/String;", "GetGetSave_pathHandler")]
			get {
				const string __id = "getSave_path.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setSave_path' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSave_path", "(Ljava/lang/String;)V", "GetSetSave_path_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSave_path.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSeeding_time;
#pragma warning disable 0169
		static Delegate GetGetSeeding_timeHandler ()
		{
			if (cb_getSeeding_time == null)
				cb_getSeeding_time = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSeeding_time);
			return cb_getSeeding_time;
		}

		static int n_GetSeeding_time (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Seeding_time;
		}
#pragma warning restore 0169

		static Delegate cb_setSeeding_time_I;
#pragma warning disable 0169
		static Delegate GetSetSeeding_time_IHandler ()
		{
			if (cb_setSeeding_time_I == null)
				cb_setSeeding_time_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSeeding_time_I);
			return cb_setSeeding_time_I;
		}

		static void n_SetSeeding_time_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Seeding_time = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Seeding_time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getSeeding_time' and count(parameter)=0]"
			[Register ("getSeeding_time", "()I", "GetGetSeeding_timeHandler")]
			get {
				const string __id = "getSeeding_time.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setSeeding_time' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSeeding_time", "(I)V", "GetSetSeeding_time_IHandler")]
			set {
				const string __id = "setSeeding_time.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStorage_mode;
#pragma warning disable 0169
		static Delegate GetGetStorage_modeHandler ()
		{
			if (cb_getStorage_mode == null)
				cb_getStorage_mode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStorage_mode);
			return cb_getStorage_mode;
		}

		static IntPtr n_GetStorage_mode (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Storage_mode);
		}
#pragma warning restore 0169

		static Delegate cb_setStorage_mode_Lcom_frostwire_jlibtorrent_swig_storage_mode_t_;
#pragma warning disable 0169
		static Delegate GetSetStorage_mode_Lcom_frostwire_jlibtorrent_swig_storage_mode_t_Handler ()
		{
			if (cb_setStorage_mode_Lcom_frostwire_jlibtorrent_swig_storage_mode_t_ == null)
				cb_setStorage_mode_Lcom_frostwire_jlibtorrent_swig_storage_mode_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStorage_mode_Lcom_frostwire_jlibtorrent_swig_storage_mode_t_);
			return cb_setStorage_mode_Lcom_frostwire_jlibtorrent_swig_storage_mode_t_;
		}

		static void n_SetStorage_mode_Lcom_frostwire_jlibtorrent_swig_storage_mode_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Storage_mode_t value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Storage_mode_t> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Storage_mode = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Storage_mode_t Storage_mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getStorage_mode' and count(parameter)=0]"
			[Register ("getStorage_mode", "()Lcom/frostwire/jlibtorrent/swig/storage_mode_t;", "GetGetStorage_modeHandler")]
			get {
				const string __id = "getStorage_mode.()Lcom/frostwire/jlibtorrent/swig/storage_mode_t;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Storage_mode_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setStorage_mode' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.storage_mode_t']]"
			[Register ("setStorage_mode", "(Lcom/frostwire/jlibtorrent/swig/storage_mode_t;)V", "GetSetStorage_mode_Lcom_frostwire_jlibtorrent_swig_storage_mode_t_Handler")]
			set {
				const string __id = "setStorage_mode.(Lcom/frostwire/jlibtorrent/swig/storage_mode_t;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotal_downloaded;
#pragma warning disable 0169
		static Delegate GetGetTotal_downloadedHandler ()
		{
			if (cb_getTotal_downloaded == null)
				cb_getTotal_downloaded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTotal_downloaded);
			return cb_getTotal_downloaded;
		}

		static long n_GetTotal_downloaded (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Total_downloaded;
		}
#pragma warning restore 0169

		static Delegate cb_setTotal_downloaded_J;
#pragma warning disable 0169
		static Delegate GetSetTotal_downloaded_JHandler ()
		{
			if (cb_setTotal_downloaded_J == null)
				cb_setTotal_downloaded_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTotal_downloaded_J);
			return cb_setTotal_downloaded_J;
		}

		static void n_SetTotal_downloaded_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Total_downloaded = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Total_downloaded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getTotal_downloaded' and count(parameter)=0]"
			[Register ("getTotal_downloaded", "()J", "GetGetTotal_downloadedHandler")]
			get {
				const string __id = "getTotal_downloaded.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setTotal_downloaded' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTotal_downloaded", "(J)V", "GetSetTotal_downloaded_JHandler")]
			set {
				const string __id = "setTotal_downloaded.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotal_uploaded;
#pragma warning disable 0169
		static Delegate GetGetTotal_uploadedHandler ()
		{
			if (cb_getTotal_uploaded == null)
				cb_getTotal_uploaded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTotal_uploaded);
			return cb_getTotal_uploaded;
		}

		static long n_GetTotal_uploaded (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Total_uploaded;
		}
#pragma warning restore 0169

		static Delegate cb_setTotal_uploaded_J;
#pragma warning disable 0169
		static Delegate GetSetTotal_uploaded_JHandler ()
		{
			if (cb_setTotal_uploaded_J == null)
				cb_setTotal_uploaded_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTotal_uploaded_J);
			return cb_setTotal_uploaded_J;
		}

		static void n_SetTotal_uploaded_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Total_uploaded = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Total_uploaded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getTotal_uploaded' and count(parameter)=0]"
			[Register ("getTotal_uploaded", "()J", "GetGetTotal_uploadedHandler")]
			get {
				const string __id = "getTotal_uploaded.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setTotal_uploaded' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTotal_uploaded", "(J)V", "GetSetTotal_uploaded_JHandler")]
			set {
				const string __id = "setTotal_uploaded.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackerid;
#pragma warning disable 0169
		static Delegate GetGetTrackeridHandler ()
		{
			if (cb_getTrackerid == null)
				cb_getTrackerid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackerid);
			return cb_getTrackerid;
		}

		static IntPtr n_GetTrackerid (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Trackerid);
		}
#pragma warning restore 0169

		static Delegate cb_setTrackerid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTrackerid_Ljava_lang_String_Handler ()
		{
			if (cb_setTrackerid_Ljava_lang_String_ == null)
				cb_setTrackerid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrackerid_Ljava_lang_String_);
			return cb_setTrackerid_Ljava_lang_String_;
		}

		static void n_SetTrackerid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Trackerid = value;
		}
#pragma warning restore 0169

		public virtual unsafe string Trackerid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getTrackerid' and count(parameter)=0]"
			[Register ("getTrackerid", "()Ljava/lang/String;", "GetGetTrackeridHandler")]
			get {
				const string __id = "getTrackerid.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setTrackerid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTrackerid", "(Ljava/lang/String;)V", "GetSetTrackerid_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTrackerid.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUpload_limit;
#pragma warning disable 0169
		static Delegate GetGetUpload_limitHandler ()
		{
			if (cb_getUpload_limit == null)
				cb_getUpload_limit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUpload_limit);
			return cb_getUpload_limit;
		}

		static int n_GetUpload_limit (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Upload_limit;
		}
#pragma warning restore 0169

		static Delegate cb_setUpload_limit_I;
#pragma warning disable 0169
		static Delegate GetSetUpload_limit_IHandler ()
		{
			if (cb_setUpload_limit_I == null)
				cb_setUpload_limit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUpload_limit_I);
			return cb_setUpload_limit_I;
		}

		static void n_SetUpload_limit_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Upload_limit = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Upload_limit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getUpload_limit' and count(parameter)=0]"
			[Register ("getUpload_limit", "()I", "GetGetUpload_limitHandler")]
			get {
				const string __id = "getUpload_limit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setUpload_limit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUpload_limit", "(I)V", "GetSetUpload_limit_IHandler")]
			set {
				const string __id = "setUpload_limit.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVerified_pieces;
#pragma warning disable 0169
		static Delegate GetGetVerified_piecesHandler ()
		{
			if (cb_getVerified_pieces == null)
				cb_getVerified_pieces = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVerified_pieces);
			return cb_getVerified_pieces;
		}

		static IntPtr n_GetVerified_pieces (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Verified_pieces);
		}
#pragma warning restore 0169

		static Delegate cb_setVerified_pieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_;
#pragma warning disable 0169
		static Delegate GetSetVerified_pieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_Handler ()
		{
			if (cb_setVerified_pieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_ == null)
				cb_setVerified_pieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVerified_pieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_);
			return cb_setVerified_pieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_;
		}

		static void n_SetVerified_pieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Verified_pieces = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Piece_index_bitfield Verified_pieces {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getVerified_pieces' and count(parameter)=0]"
			[Register ("getVerified_pieces", "()Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;", "GetGetVerified_piecesHandler")]
			get {
				const string __id = "getVerified_pieces.()Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setVerified_pieces' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.piece_index_bitfield']]"
			[Register ("setVerified_pieces", "(Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;)V", "GetSetVerified_pieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_Handler")]
			set {
				const string __id = "setVerified_pieces.(Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVersion);
			return cb_getVersion;
		}

		static int n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		static Delegate cb_setVersion_I;
#pragma warning disable 0169
		static Delegate GetSetVersion_IHandler ()
		{
			if (cb_setVersion_I == null)
				cb_setVersion_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetVersion_I);
			return cb_setVersion_I;
		}

		static void n_SetVersion_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Version = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()I", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVersion", "(I)V", "GetSetVersion_IHandler")]
			set {
				const string __id = "setVersion.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='create_instance' and count(parameter)=0]"
		[Register ("create_instance", "()Lcom/frostwire/jlibtorrent/swig/add_torrent_params;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Add_torrent_params Create_instance ()
		{
			const string __id = "create_instance.()Lcom/frostwire/jlibtorrent/swig/add_torrent_params;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='create_instance_disabled_storage' and count(parameter)=0]"
		[Register ("create_instance_disabled_storage", "()Lcom/frostwire/jlibtorrent/swig/add_torrent_params;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Add_torrent_params Create_instance_disabled_storage ()
		{
			const string __id = "create_instance_disabled_storage.()Lcom/frostwire/jlibtorrent/swig/add_torrent_params;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='create_instance_zero_storage' and count(parameter)=0]"
		[Register ("create_instance_zero_storage", "()Lcom/frostwire/jlibtorrent/swig/add_torrent_params;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Add_torrent_params Create_instance_zero_storage ()
		{
			const string __id = "create_instance_zero_storage.()Lcom/frostwire/jlibtorrent/swig/add_torrent_params;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.add_torrent_params']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/add_torrent_params;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Add_torrent_params obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/add_torrent_params;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_banned_peers;
#pragma warning disable 0169
		static Delegate GetGet_banned_peersHandler ()
		{
			if (cb_get_banned_peers == null)
				cb_get_banned_peers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_banned_peers);
			return cb_get_banned_peers;
		}

		static IntPtr n_Get_banned_peers (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_banned_peers ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='get_banned_peers' and count(parameter)=0]"
		[Register ("get_banned_peers", "()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint_vector;", "GetGet_banned_peersHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Tcp_endpoint_vector Get_banned_peers ()
		{
			const string __id = "get_banned_peers.()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tcp_endpoint_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_dht_nodes;
#pragma warning disable 0169
		static Delegate GetGet_dht_nodesHandler ()
		{
			if (cb_get_dht_nodes == null)
				cb_get_dht_nodes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_dht_nodes);
			return cb_get_dht_nodes;
		}

		static IntPtr n_Get_dht_nodes (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_dht_nodes ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='get_dht_nodes' and count(parameter)=0]"
		[Register ("get_dht_nodes", "()Lcom/frostwire/jlibtorrent/swig/string_int_pair_vector;", "GetGet_dht_nodesHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.String_int_pair_vector Get_dht_nodes ()
		{
			const string __id = "get_dht_nodes.()Lcom/frostwire/jlibtorrent/swig/string_int_pair_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_int_pair_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_peers;
#pragma warning disable 0169
		static Delegate GetGet_peersHandler ()
		{
			if (cb_get_peers == null)
				cb_get_peers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_peers);
			return cb_get_peers;
		}

		static IntPtr n_Get_peers (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_peers ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='get_peers' and count(parameter)=0]"
		[Register ("get_peers", "()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint_vector;", "GetGet_peersHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Tcp_endpoint_vector Get_peers ()
		{
			const string __id = "get_peers.()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tcp_endpoint_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_tracker_tiers;
#pragma warning disable 0169
		static Delegate GetGet_tracker_tiersHandler ()
		{
			if (cb_get_tracker_tiers == null)
				cb_get_tracker_tiers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_tracker_tiers);
			return cb_get_tracker_tiers;
		}

		static IntPtr n_Get_tracker_tiers (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_tracker_tiers ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='get_tracker_tiers' and count(parameter)=0]"
		[Register ("get_tracker_tiers", "()Lcom/frostwire/jlibtorrent/swig/int_vector;", "GetGet_tracker_tiersHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Int_vector Get_tracker_tiers ()
		{
			const string __id = "get_tracker_tiers.()Lcom/frostwire/jlibtorrent/swig/int_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Int_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_trackers;
#pragma warning disable 0169
		static Delegate GetGet_trackersHandler ()
		{
			if (cb_get_trackers == null)
				cb_get_trackers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_trackers);
			return cb_get_trackers;
		}

		static IntPtr n_Get_trackers (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_trackers ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='get_trackers' and count(parameter)=0]"
		[Register ("get_trackers", "()Lcom/frostwire/jlibtorrent/swig/string_vector;", "GetGet_trackersHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.String_vector Get_trackers ()
		{
			const string __id = "get_trackers.()Lcom/frostwire/jlibtorrent/swig/string_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_url_seeds;
#pragma warning disable 0169
		static Delegate GetGet_url_seedsHandler ()
		{
			if (cb_get_url_seeds == null)
				cb_get_url_seeds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_url_seeds);
			return cb_get_url_seeds;
		}

		static IntPtr n_Get_url_seeds (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_url_seeds ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='get_url_seeds' and count(parameter)=0]"
		[Register ("get_url_seeds", "()Lcom/frostwire/jlibtorrent/swig/string_vector;", "GetGet_url_seedsHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.String_vector Get_url_seeds ()
		{
			const string __id = "get_url_seeds.()Lcom/frostwire/jlibtorrent/swig/string_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='parse_magnet_uri' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.error_code']]"
		[Register ("parse_magnet_uri", "(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/error_code;)Lcom/frostwire/jlibtorrent/swig/add_torrent_params;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Add_torrent_params Parse_magnet_uri (string uri, global::FrostWire.Libtorrent.Swig.Error_code ec)
		{
			const string __id = "parse_magnet_uri.(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/error_code;)Lcom/frostwire/jlibtorrent/swig/add_torrent_params;";
			IntPtr native_uri = JNIEnv.NewString (uri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_uri);
				__args [1] = new JniArgumentValue ((ec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ec).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='read_resume_data' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.bdecode_node'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.error_code']]"
		[Register ("read_resume_data", "(Lcom/frostwire/jlibtorrent/swig/bdecode_node;Lcom/frostwire/jlibtorrent/swig/error_code;)Lcom/frostwire/jlibtorrent/swig/add_torrent_params;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Add_torrent_params Read_resume_data (global::FrostWire.Libtorrent.Swig.Bdecode_node rd, global::FrostWire.Libtorrent.Swig.Error_code ec)
		{
			const string __id = "read_resume_data.(Lcom/frostwire/jlibtorrent/swig/bdecode_node;Lcom/frostwire/jlibtorrent/swig/error_code;)Lcom/frostwire/jlibtorrent/swig/add_torrent_params;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((rd == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rd).Handle);
				__args [1] = new JniArgumentValue ((ec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ec).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='read_resume_data' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.error_code']]"
		[Register ("read_resume_data", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/error_code;)Lcom/frostwire/jlibtorrent/swig/add_torrent_params;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Add_torrent_params Read_resume_data (global::FrostWire.Libtorrent.Swig.Byte_vector buffer, global::FrostWire.Libtorrent.Swig.Error_code ec)
		{
			const string __id = "read_resume_data.(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/error_code;)Lcom/frostwire/jlibtorrent/swig/add_torrent_params;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [1] = new JniArgumentValue ((ec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ec).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_set_banned_peers_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_vector_;
#pragma warning disable 0169
		static Delegate GetSet_banned_peers_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_vector_Handler ()
		{
			if (cb_set_banned_peers_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_vector_ == null)
				cb_set_banned_peers_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_banned_peers_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_vector_);
			return cb_set_banned_peers_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_vector_;
		}

		static void n_Set_banned_peers_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_banned_peers)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Tcp_endpoint_vector banned_peers = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tcp_endpoint_vector> (native_banned_peers, JniHandleOwnership.DoNotTransfer);
			__this.Set_banned_peers (banned_peers);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='set_banned_peers' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.tcp_endpoint_vector']]"
		[Register ("set_banned_peers", "(Lcom/frostwire/jlibtorrent/swig/tcp_endpoint_vector;)V", "GetSet_banned_peers_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_vector_Handler")]
		public virtual unsafe void Set_banned_peers (global::FrostWire.Libtorrent.Swig.Tcp_endpoint_vector banned_peers)
		{
			const string __id = "set_banned_peers.(Lcom/frostwire/jlibtorrent/swig/tcp_endpoint_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((banned_peers == null) ? IntPtr.Zero : ((global::Java.Lang.Object) banned_peers).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_default_storage;
#pragma warning disable 0169
		static Delegate GetSet_default_storageHandler ()
		{
			if (cb_set_default_storage == null)
				cb_set_default_storage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Set_default_storage);
			return cb_set_default_storage;
		}

		static void n_Set_default_storage (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_default_storage ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='set_default_storage' and count(parameter)=0]"
		[Register ("set_default_storage", "()V", "GetSet_default_storageHandler")]
		public virtual unsafe void Set_default_storage ()
		{
			const string __id = "set_default_storage.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_set_dht_nodes_Lcom_frostwire_jlibtorrent_swig_string_int_pair_vector_;
#pragma warning disable 0169
		static Delegate GetSet_dht_nodes_Lcom_frostwire_jlibtorrent_swig_string_int_pair_vector_Handler ()
		{
			if (cb_set_dht_nodes_Lcom_frostwire_jlibtorrent_swig_string_int_pair_vector_ == null)
				cb_set_dht_nodes_Lcom_frostwire_jlibtorrent_swig_string_int_pair_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_dht_nodes_Lcom_frostwire_jlibtorrent_swig_string_int_pair_vector_);
			return cb_set_dht_nodes_Lcom_frostwire_jlibtorrent_swig_string_int_pair_vector_;
		}

		static void n_Set_dht_nodes_Lcom_frostwire_jlibtorrent_swig_string_int_pair_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dht_nodes)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_int_pair_vector dht_nodes = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_int_pair_vector> (native_dht_nodes, JniHandleOwnership.DoNotTransfer);
			__this.Set_dht_nodes (dht_nodes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='set_dht_nodes' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_int_pair_vector']]"
		[Register ("set_dht_nodes", "(Lcom/frostwire/jlibtorrent/swig/string_int_pair_vector;)V", "GetSet_dht_nodes_Lcom_frostwire_jlibtorrent_swig_string_int_pair_vector_Handler")]
		public virtual unsafe void Set_dht_nodes (global::FrostWire.Libtorrent.Swig.String_int_pair_vector dht_nodes)
		{
			const string __id = "set_dht_nodes.(Lcom/frostwire/jlibtorrent/swig/string_int_pair_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dht_nodes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dht_nodes).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_disabled_storage;
#pragma warning disable 0169
		static Delegate GetSet_disabled_storageHandler ()
		{
			if (cb_set_disabled_storage == null)
				cb_set_disabled_storage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Set_disabled_storage);
			return cb_set_disabled_storage;
		}

		static void n_Set_disabled_storage (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_disabled_storage ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='set_disabled_storage' and count(parameter)=0]"
		[Register ("set_disabled_storage", "()V", "GetSet_disabled_storageHandler")]
		public virtual unsafe void Set_disabled_storage ()
		{
			const string __id = "set_disabled_storage.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_set_file_priorities2_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
#pragma warning disable 0169
		static Delegate GetSet_file_priorities2_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler ()
		{
			if (cb_set_file_priorities2_Lcom_frostwire_jlibtorrent_swig_byte_vector_ == null)
				cb_set_file_priorities2_Lcom_frostwire_jlibtorrent_swig_byte_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_file_priorities2_Lcom_frostwire_jlibtorrent_swig_byte_vector_);
			return cb_set_file_priorities2_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
		}

		static void n_Set_file_priorities2_Lcom_frostwire_jlibtorrent_swig_byte_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_file_priorities)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector file_priorities = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_file_priorities, JniHandleOwnership.DoNotTransfer);
			__this.Set_file_priorities2 (file_priorities);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='set_file_priorities2' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("set_file_priorities2", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V", "GetSet_file_priorities2_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler")]
		public virtual unsafe void Set_file_priorities2 (global::FrostWire.Libtorrent.Swig.Byte_vector file_priorities)
		{
			const string __id = "set_file_priorities2.(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file_priorities == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file_priorities).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_http_seeds_Lcom_frostwire_jlibtorrent_swig_string_vector_;
#pragma warning disable 0169
		static Delegate GetSet_http_seeds_Lcom_frostwire_jlibtorrent_swig_string_vector_Handler ()
		{
			if (cb_set_http_seeds_Lcom_frostwire_jlibtorrent_swig_string_vector_ == null)
				cb_set_http_seeds_Lcom_frostwire_jlibtorrent_swig_string_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_http_seeds_Lcom_frostwire_jlibtorrent_swig_string_vector_);
			return cb_set_http_seeds_Lcom_frostwire_jlibtorrent_swig_string_vector_;
		}

		static void n_Set_http_seeds_Lcom_frostwire_jlibtorrent_swig_string_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_http_seeds)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_vector http_seeds = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_vector> (native_http_seeds, JniHandleOwnership.DoNotTransfer);
			__this.Set_http_seeds (http_seeds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='set_http_seeds' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_vector']]"
		[Register ("set_http_seeds", "(Lcom/frostwire/jlibtorrent/swig/string_vector;)V", "GetSet_http_seeds_Lcom_frostwire_jlibtorrent_swig_string_vector_Handler")]
		public virtual unsafe void Set_http_seeds (global::FrostWire.Libtorrent.Swig.String_vector http_seeds)
		{
			const string __id = "set_http_seeds.(Lcom/frostwire/jlibtorrent/swig/string_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((http_seeds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) http_seeds).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_merkle_tree_Lcom_frostwire_jlibtorrent_swig_sha1_hash_vector_;
#pragma warning disable 0169
		static Delegate GetSet_merkle_tree_Lcom_frostwire_jlibtorrent_swig_sha1_hash_vector_Handler ()
		{
			if (cb_set_merkle_tree_Lcom_frostwire_jlibtorrent_swig_sha1_hash_vector_ == null)
				cb_set_merkle_tree_Lcom_frostwire_jlibtorrent_swig_sha1_hash_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_merkle_tree_Lcom_frostwire_jlibtorrent_swig_sha1_hash_vector_);
			return cb_set_merkle_tree_Lcom_frostwire_jlibtorrent_swig_sha1_hash_vector_;
		}

		static void n_Set_merkle_tree_Lcom_frostwire_jlibtorrent_swig_sha1_hash_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_merkle_tree)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash_vector merkle_tree = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash_vector> (native_merkle_tree, JniHandleOwnership.DoNotTransfer);
			__this.Set_merkle_tree (merkle_tree);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='set_merkle_tree' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash_vector']]"
		[Register ("set_merkle_tree", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash_vector;)V", "GetSet_merkle_tree_Lcom_frostwire_jlibtorrent_swig_sha1_hash_vector_Handler")]
		public virtual unsafe void Set_merkle_tree (global::FrostWire.Libtorrent.Swig.Sha1_hash_vector merkle_tree)
		{
			const string __id = "set_merkle_tree.(Lcom/frostwire/jlibtorrent/swig/sha1_hash_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((merkle_tree == null) ? IntPtr.Zero : ((global::Java.Lang.Object) merkle_tree).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_peers_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_vector_;
#pragma warning disable 0169
		static Delegate GetSet_peers_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_vector_Handler ()
		{
			if (cb_set_peers_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_vector_ == null)
				cb_set_peers_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_peers_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_vector_);
			return cb_set_peers_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_vector_;
		}

		static void n_Set_peers_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_peers)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Tcp_endpoint_vector peers = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tcp_endpoint_vector> (native_peers, JniHandleOwnership.DoNotTransfer);
			__this.Set_peers (peers);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='set_peers' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.tcp_endpoint_vector']]"
		[Register ("set_peers", "(Lcom/frostwire/jlibtorrent/swig/tcp_endpoint_vector;)V", "GetSet_peers_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_vector_Handler")]
		public virtual unsafe void Set_peers (global::FrostWire.Libtorrent.Swig.Tcp_endpoint_vector peers)
		{
			const string __id = "set_peers.(Lcom/frostwire/jlibtorrent/swig/tcp_endpoint_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((peers == null) ? IntPtr.Zero : ((global::Java.Lang.Object) peers).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_piece_priorities2_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
#pragma warning disable 0169
		static Delegate GetSet_piece_priorities2_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler ()
		{
			if (cb_set_piece_priorities2_Lcom_frostwire_jlibtorrent_swig_byte_vector_ == null)
				cb_set_piece_priorities2_Lcom_frostwire_jlibtorrent_swig_byte_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_piece_priorities2_Lcom_frostwire_jlibtorrent_swig_byte_vector_);
			return cb_set_piece_priorities2_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
		}

		static void n_Set_piece_priorities2_Lcom_frostwire_jlibtorrent_swig_byte_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_piece_priorities)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector piece_priorities = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_piece_priorities, JniHandleOwnership.DoNotTransfer);
			__this.Set_piece_priorities2 (piece_priorities);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='set_piece_priorities2' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("set_piece_priorities2", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V", "GetSet_piece_priorities2_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler")]
		public virtual unsafe void Set_piece_priorities2 (global::FrostWire.Libtorrent.Swig.Byte_vector piece_priorities)
		{
			const string __id = "set_piece_priorities2.(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((piece_priorities == null) ? IntPtr.Zero : ((global::Java.Lang.Object) piece_priorities).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_renamed_files_Lcom_frostwire_jlibtorrent_swig_file_index_string_map_;
#pragma warning disable 0169
		static Delegate GetSet_renamed_files_Lcom_frostwire_jlibtorrent_swig_file_index_string_map_Handler ()
		{
			if (cb_set_renamed_files_Lcom_frostwire_jlibtorrent_swig_file_index_string_map_ == null)
				cb_set_renamed_files_Lcom_frostwire_jlibtorrent_swig_file_index_string_map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_renamed_files_Lcom_frostwire_jlibtorrent_swig_file_index_string_map_);
			return cb_set_renamed_files_Lcom_frostwire_jlibtorrent_swig_file_index_string_map_;
		}

		static void n_Set_renamed_files_Lcom_frostwire_jlibtorrent_swig_file_index_string_map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_renamed_files)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.File_index_string_map renamed_files = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_index_string_map> (native_renamed_files, JniHandleOwnership.DoNotTransfer);
			__this.Set_renamed_files (renamed_files);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='set_renamed_files' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.file_index_string_map']]"
		[Register ("set_renamed_files", "(Lcom/frostwire/jlibtorrent/swig/file_index_string_map;)V", "GetSet_renamed_files_Lcom_frostwire_jlibtorrent_swig_file_index_string_map_Handler")]
		public virtual unsafe void Set_renamed_files (global::FrostWire.Libtorrent.Swig.File_index_string_map renamed_files)
		{
			const string __id = "set_renamed_files.(Lcom/frostwire/jlibtorrent/swig/file_index_string_map;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((renamed_files == null) ? IntPtr.Zero : ((global::Java.Lang.Object) renamed_files).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_ti_Lcom_frostwire_jlibtorrent_swig_torrent_info_;
#pragma warning disable 0169
		static Delegate GetSet_ti_Lcom_frostwire_jlibtorrent_swig_torrent_info_Handler ()
		{
			if (cb_set_ti_Lcom_frostwire_jlibtorrent_swig_torrent_info_ == null)
				cb_set_ti_Lcom_frostwire_jlibtorrent_swig_torrent_info_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_ti_Lcom_frostwire_jlibtorrent_swig_torrent_info_);
			return cb_set_ti_Lcom_frostwire_jlibtorrent_swig_torrent_info_;
		}

		static void n_Set_ti_Lcom_frostwire_jlibtorrent_swig_torrent_info_ (IntPtr jnienv, IntPtr native__this, IntPtr native_ti)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Torrent_info ti = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (native_ti, JniHandleOwnership.DoNotTransfer);
			__this.Set_ti (ti);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='set_ti' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_info']]"
		[Register ("set_ti", "(Lcom/frostwire/jlibtorrent/swig/torrent_info;)V", "GetSet_ti_Lcom_frostwire_jlibtorrent_swig_torrent_info_Handler")]
		public virtual unsafe void Set_ti (global::FrostWire.Libtorrent.Swig.Torrent_info ti)
		{
			const string __id = "set_ti.(Lcom/frostwire/jlibtorrent/swig/torrent_info;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ti == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ti).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_tracker_tiers_Lcom_frostwire_jlibtorrent_swig_int_vector_;
#pragma warning disable 0169
		static Delegate GetSet_tracker_tiers_Lcom_frostwire_jlibtorrent_swig_int_vector_Handler ()
		{
			if (cb_set_tracker_tiers_Lcom_frostwire_jlibtorrent_swig_int_vector_ == null)
				cb_set_tracker_tiers_Lcom_frostwire_jlibtorrent_swig_int_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_tracker_tiers_Lcom_frostwire_jlibtorrent_swig_int_vector_);
			return cb_set_tracker_tiers_Lcom_frostwire_jlibtorrent_swig_int_vector_;
		}

		static void n_Set_tracker_tiers_Lcom_frostwire_jlibtorrent_swig_int_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tracker_tiers)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Int_vector tracker_tiers = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Int_vector> (native_tracker_tiers, JniHandleOwnership.DoNotTransfer);
			__this.Set_tracker_tiers (tracker_tiers);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='set_tracker_tiers' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.int_vector']]"
		[Register ("set_tracker_tiers", "(Lcom/frostwire/jlibtorrent/swig/int_vector;)V", "GetSet_tracker_tiers_Lcom_frostwire_jlibtorrent_swig_int_vector_Handler")]
		public virtual unsafe void Set_tracker_tiers (global::FrostWire.Libtorrent.Swig.Int_vector tracker_tiers)
		{
			const string __id = "set_tracker_tiers.(Lcom/frostwire/jlibtorrent/swig/int_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tracker_tiers == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tracker_tiers).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_trackers_Lcom_frostwire_jlibtorrent_swig_string_vector_;
#pragma warning disable 0169
		static Delegate GetSet_trackers_Lcom_frostwire_jlibtorrent_swig_string_vector_Handler ()
		{
			if (cb_set_trackers_Lcom_frostwire_jlibtorrent_swig_string_vector_ == null)
				cb_set_trackers_Lcom_frostwire_jlibtorrent_swig_string_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_trackers_Lcom_frostwire_jlibtorrent_swig_string_vector_);
			return cb_set_trackers_Lcom_frostwire_jlibtorrent_swig_string_vector_;
		}

		static void n_Set_trackers_Lcom_frostwire_jlibtorrent_swig_string_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_trackers)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_vector trackers = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_vector> (native_trackers, JniHandleOwnership.DoNotTransfer);
			__this.Set_trackers (trackers);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='set_trackers' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_vector']]"
		[Register ("set_trackers", "(Lcom/frostwire/jlibtorrent/swig/string_vector;)V", "GetSet_trackers_Lcom_frostwire_jlibtorrent_swig_string_vector_Handler")]
		public virtual unsafe void Set_trackers (global::FrostWire.Libtorrent.Swig.String_vector trackers)
		{
			const string __id = "set_trackers.(Lcom/frostwire/jlibtorrent/swig/string_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((trackers == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackers).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_url_seeds_Lcom_frostwire_jlibtorrent_swig_string_vector_;
#pragma warning disable 0169
		static Delegate GetSet_url_seeds_Lcom_frostwire_jlibtorrent_swig_string_vector_Handler ()
		{
			if (cb_set_url_seeds_Lcom_frostwire_jlibtorrent_swig_string_vector_ == null)
				cb_set_url_seeds_Lcom_frostwire_jlibtorrent_swig_string_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_url_seeds_Lcom_frostwire_jlibtorrent_swig_string_vector_);
			return cb_set_url_seeds_Lcom_frostwire_jlibtorrent_swig_string_vector_;
		}

		static void n_Set_url_seeds_Lcom_frostwire_jlibtorrent_swig_string_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url_seeds)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_vector url_seeds = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_vector> (native_url_seeds, JniHandleOwnership.DoNotTransfer);
			__this.Set_url_seeds (url_seeds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='set_url_seeds' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_vector']]"
		[Register ("set_url_seeds", "(Lcom/frostwire/jlibtorrent/swig/string_vector;)V", "GetSet_url_seeds_Lcom_frostwire_jlibtorrent_swig_string_vector_Handler")]
		public virtual unsafe void Set_url_seeds (global::FrostWire.Libtorrent.Swig.String_vector url_seeds)
		{
			const string __id = "set_url_seeds.(Lcom/frostwire/jlibtorrent/swig/string_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((url_seeds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) url_seeds).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_zero_storage;
#pragma warning disable 0169
		static Delegate GetSet_zero_storageHandler ()
		{
			if (cb_set_zero_storage == null)
				cb_set_zero_storage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Set_zero_storage);
			return cb_set_zero_storage;
		}

		static void n_Set_zero_storage (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_zero_storage ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='set_zero_storage' and count(parameter)=0]"
		[Register ("set_zero_storage", "()V", "GetSet_zero_storageHandler")]
		public virtual unsafe void Set_zero_storage ()
		{
			const string __id = "set_zero_storage.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_ti_ptr;
#pragma warning disable 0169
		static Delegate GetTi_ptrHandler ()
		{
			if (cb_ti_ptr == null)
				cb_ti_ptr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Ti_ptr);
			return cb_ti_ptr;
		}

		static IntPtr n_Ti_ptr (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Add_torrent_params __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Ti_ptr ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='ti_ptr' and count(parameter)=0]"
		[Register ("ti_ptr", "()Lcom/frostwire/jlibtorrent/swig/torrent_info;", "GetTi_ptrHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Torrent_info Ti_ptr ()
		{
			const string __id = "ti_ptr.()Lcom/frostwire/jlibtorrent/swig/torrent_info;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='write_resume_data' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.add_torrent_params']]"
		[Register ("write_resume_data", "(Lcom/frostwire/jlibtorrent/swig/add_torrent_params;)Lcom/frostwire/jlibtorrent/swig/entry;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Entry Write_resume_data (global::FrostWire.Libtorrent.Swig.Add_torrent_params atp)
		{
			const string __id = "write_resume_data.(Lcom/frostwire/jlibtorrent/swig/add_torrent_params;)Lcom/frostwire/jlibtorrent/swig/entry;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((atp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) atp).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='add_torrent_params']/method[@name='write_resume_data_buf' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.add_torrent_params']]"
		[Register ("write_resume_data_buf", "(Lcom/frostwire/jlibtorrent/swig/add_torrent_params;)Lcom/frostwire/jlibtorrent/swig/byte_vector;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Write_resume_data_buf (global::FrostWire.Libtorrent.Swig.Add_torrent_params atp)
		{
			const string __id = "write_resume_data_buf.(Lcom/frostwire/jlibtorrent/swig/add_torrent_params;)Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((atp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) atp).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
