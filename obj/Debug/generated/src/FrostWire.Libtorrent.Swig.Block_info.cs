using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/block_info", DoNotGenerateAcw=true)]
	public partial class Block_info : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info']/field[@name='swigCMemOwn']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info.block_state_t']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/block_info$block_state_t", DoNotGenerateAcw=true)]
		public sealed partial class Block_state_t : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info.block_state_t']/field[@name='finished']"
			[Register ("finished")]
			public static global::FrostWire.Libtorrent.Swig.Block_info.Block_state_t Finished {
				get {
					const string __id = "finished.Lcom/frostwire/jlibtorrent/swig/block_info$block_state_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_info.Block_state_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info.block_state_t']/field[@name='none']"
			[Register ("none")]
			public static global::FrostWire.Libtorrent.Swig.Block_info.Block_state_t None {
				get {
					const string __id = "none.Lcom/frostwire/jlibtorrent/swig/block_info$block_state_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_info.Block_state_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info.block_state_t']/field[@name='requested']"
			[Register ("requested")]
			public static global::FrostWire.Libtorrent.Swig.Block_info.Block_state_t Requested {
				get {
					const string __id = "requested.Lcom/frostwire/jlibtorrent/swig/block_info$block_state_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_info.Block_state_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info.block_state_t']/field[@name='writing']"
			[Register ("writing")]
			public static global::FrostWire.Libtorrent.Swig.Block_info.Block_state_t Writing {
				get {
					const string __id = "writing.Lcom/frostwire/jlibtorrent/swig/block_info$block_state_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_info.Block_state_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/block_info$block_state_t", typeof (Block_state_t));
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

			internal Block_state_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info.block_state_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/block_info$block_state_t;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Block_info.Block_state_t SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/block_info$block_state_t;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_info.Block_state_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info.block_state_t']/method[@name='swigValue' and count(parameter)=0]"
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/block_info", typeof (Block_info));
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

		protected Block_info (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info']/constructor[@name='block_info' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Block_info ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info']/constructor[@name='block_info' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Block_info (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getBlock_size;
#pragma warning disable 0169
		static Delegate GetGetBlock_sizeHandler ()
		{
			if (cb_getBlock_size == null)
				cb_getBlock_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetBlock_size);
			return cb_getBlock_size;
		}

		static long n_GetBlock_size (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Block_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Block_size;
		}
#pragma warning restore 0169

		static Delegate cb_setBlock_size_J;
#pragma warning disable 0169
		static Delegate GetSetBlock_size_JHandler ()
		{
			if (cb_setBlock_size_J == null)
				cb_setBlock_size_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetBlock_size_J);
			return cb_setBlock_size_J;
		}

		static void n_SetBlock_size_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Block_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Block_size = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Block_size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info']/method[@name='getBlock_size' and count(parameter)=0]"
			[Register ("getBlock_size", "()J", "GetGetBlock_sizeHandler")]
			get {
				const string __id = "getBlock_size.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info']/method[@name='setBlock_size' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setBlock_size", "(J)V", "GetSetBlock_size_JHandler")]
			set {
				const string __id = "setBlock_size.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBytes_progress;
#pragma warning disable 0169
		static Delegate GetGetBytes_progressHandler ()
		{
			if (cb_getBytes_progress == null)
				cb_getBytes_progress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetBytes_progress);
			return cb_getBytes_progress;
		}

		static long n_GetBytes_progress (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Block_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Bytes_progress;
		}
#pragma warning restore 0169

		static Delegate cb_setBytes_progress_J;
#pragma warning disable 0169
		static Delegate GetSetBytes_progress_JHandler ()
		{
			if (cb_setBytes_progress_J == null)
				cb_setBytes_progress_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetBytes_progress_J);
			return cb_setBytes_progress_J;
		}

		static void n_SetBytes_progress_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Block_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Bytes_progress = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Bytes_progress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info']/method[@name='getBytes_progress' and count(parameter)=0]"
			[Register ("getBytes_progress", "()J", "GetGetBytes_progressHandler")]
			get {
				const string __id = "getBytes_progress.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info']/method[@name='setBytes_progress' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setBytes_progress", "(J)V", "GetSetBytes_progress_JHandler")]
			set {
				const string __id = "setBytes_progress.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNum_peers;
#pragma warning disable 0169
		static Delegate GetGetNum_peersHandler ()
		{
			if (cb_getNum_peers == null)
				cb_getNum_peers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNum_peers);
			return cb_getNum_peers;
		}

		static long n_GetNum_peers (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Block_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_peers;
		}
#pragma warning restore 0169

		static Delegate cb_setNum_peers_J;
#pragma warning disable 0169
		static Delegate GetSetNum_peers_JHandler ()
		{
			if (cb_setNum_peers_J == null)
				cb_setNum_peers_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetNum_peers_J);
			return cb_setNum_peers_J;
		}

		static void n_SetNum_peers_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Block_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Num_peers = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Num_peers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info']/method[@name='getNum_peers' and count(parameter)=0]"
			[Register ("getNum_peers", "()J", "GetGetNum_peersHandler")]
			get {
				const string __id = "getNum_peers.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info']/method[@name='setNum_peers' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setNum_peers", "(J)V", "GetSetNum_peers_JHandler")]
			set {
				const string __id = "setNum_peers.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetState);
			return cb_getState;
		}

		static long n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Block_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.State;
		}
#pragma warning restore 0169

		static Delegate cb_setState_J;
#pragma warning disable 0169
		static Delegate GetSetState_JHandler ()
		{
			if (cb_setState_J == null)
				cb_setState_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetState_J);
			return cb_setState_J;
		}

		static void n_SetState_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Block_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.State = value;
		}
#pragma warning restore 0169

		public virtual unsafe long State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()J", "GetGetStateHandler")]
			get {
				const string __id = "getState.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info']/method[@name='setState' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setState", "(J)V", "GetSetState_JHandler")]
			set {
				const string __id = "setState.(J)V";
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
			global::FrostWire.Libtorrent.Swig.Block_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.block_info']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/block_info;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Block_info obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/block_info;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_peer;
#pragma warning disable 0169
		static Delegate GetPeerHandler ()
		{
			if (cb_peer == null)
				cb_peer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Peer);
			return cb_peer;
		}

		static IntPtr n_Peer (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Block_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Peer ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='block_info']/method[@name='peer' and count(parameter)=0]"
		[Register ("peer", "()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;", "GetPeerHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Tcp_endpoint Peer ()
		{
			const string __id = "peer.()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tcp_endpoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
