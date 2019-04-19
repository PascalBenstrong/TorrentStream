using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/torrent_status", DoNotGenerateAcw=true)]
	public partial class Torrent_status : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/field[@name='swigCMemOwn']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status.state_t']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/torrent_status$state_t", DoNotGenerateAcw=true)]
		public sealed partial class State_t : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status.state_t']/field[@name='allocating']"
			[Register ("allocating")]
			public static global::FrostWire.Libtorrent.Swig.Torrent_status.State_t Allocating {
				get {
					const string __id = "allocating.Lcom/frostwire/jlibtorrent/swig/torrent_status$state_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status.State_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status.state_t']/field[@name='checking_files']"
			[Register ("checking_files")]
			public static global::FrostWire.Libtorrent.Swig.Torrent_status.State_t CheckingFiles {
				get {
					const string __id = "checking_files.Lcom/frostwire/jlibtorrent/swig/torrent_status$state_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status.State_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status.state_t']/field[@name='checking_resume_data']"
			[Register ("checking_resume_data")]
			public static global::FrostWire.Libtorrent.Swig.Torrent_status.State_t CheckingResumeData {
				get {
					const string __id = "checking_resume_data.Lcom/frostwire/jlibtorrent/swig/torrent_status$state_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status.State_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status.state_t']/field[@name='downloading']"
			[Register ("downloading")]
			public static global::FrostWire.Libtorrent.Swig.Torrent_status.State_t Downloading {
				get {
					const string __id = "downloading.Lcom/frostwire/jlibtorrent/swig/torrent_status$state_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status.State_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status.state_t']/field[@name='downloading_metadata']"
			[Register ("downloading_metadata")]
			public static global::FrostWire.Libtorrent.Swig.Torrent_status.State_t DownloadingMetadata {
				get {
					const string __id = "downloading_metadata.Lcom/frostwire/jlibtorrent/swig/torrent_status$state_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status.State_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status.state_t']/field[@name='finished']"
			[Register ("finished")]
			public static global::FrostWire.Libtorrent.Swig.Torrent_status.State_t Finished {
				get {
					const string __id = "finished.Lcom/frostwire/jlibtorrent/swig/torrent_status$state_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status.State_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status.state_t']/field[@name='seeding']"
			[Register ("seeding")]
			public static global::FrostWire.Libtorrent.Swig.Torrent_status.State_t Seeding {
				get {
					const string __id = "seeding.Lcom/frostwire/jlibtorrent/swig/torrent_status$state_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status.State_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/torrent_status$state_t", typeof (State_t));
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

			internal State_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status.state_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/torrent_status$state_t;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_status.State_t SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/torrent_status$state_t;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status.State_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status.state_t']/method[@name='swigValue' and count(parameter)=0]"
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/torrent_status", typeof (Torrent_status));
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

		protected Torrent_status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/constructor[@name='torrent_status' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Torrent_status ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/constructor[@name='torrent_status' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_status']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/torrent_status;)V", "")]
		public unsafe Torrent_status (global::FrostWire.Libtorrent.Swig.Torrent_status arg0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/torrent_status;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((arg0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/constructor[@name='torrent_status' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Torrent_status (long cPtr, bool cMemoryOwn)
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Added_time = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Added_time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getAdded_time' and count(parameter)=0]"
			[Register ("getAdded_time", "()J", "GetGetAdded_timeHandler")]
			get {
				const string __id = "getAdded_time.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setAdded_time' and count(parameter)=1 and parameter[1][@type='long']]"
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

		static Delegate cb_getAll_time_download;
#pragma warning disable 0169
		static Delegate GetGetAll_time_downloadHandler ()
		{
			if (cb_getAll_time_download == null)
				cb_getAll_time_download = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAll_time_download);
			return cb_getAll_time_download;
		}

		static long n_GetAll_time_download (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.All_time_download;
		}
#pragma warning restore 0169

		static Delegate cb_setAll_time_download_J;
#pragma warning disable 0169
		static Delegate GetSetAll_time_download_JHandler ()
		{
			if (cb_setAll_time_download_J == null)
				cb_setAll_time_download_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetAll_time_download_J);
			return cb_setAll_time_download_J;
		}

		static void n_SetAll_time_download_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.All_time_download = value;
		}
#pragma warning restore 0169

		public virtual unsafe long All_time_download {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getAll_time_download' and count(parameter)=0]"
			[Register ("getAll_time_download", "()J", "GetGetAll_time_downloadHandler")]
			get {
				const string __id = "getAll_time_download.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setAll_time_download' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setAll_time_download", "(J)V", "GetSetAll_time_download_JHandler")]
			set {
				const string __id = "setAll_time_download.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAll_time_upload;
#pragma warning disable 0169
		static Delegate GetGetAll_time_uploadHandler ()
		{
			if (cb_getAll_time_upload == null)
				cb_getAll_time_upload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAll_time_upload);
			return cb_getAll_time_upload;
		}

		static long n_GetAll_time_upload (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.All_time_upload;
		}
#pragma warning restore 0169

		static Delegate cb_setAll_time_upload_J;
#pragma warning disable 0169
		static Delegate GetSetAll_time_upload_JHandler ()
		{
			if (cb_setAll_time_upload_J == null)
				cb_setAll_time_upload_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetAll_time_upload_J);
			return cb_setAll_time_upload_J;
		}

		static void n_SetAll_time_upload_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.All_time_upload = value;
		}
#pragma warning restore 0169

		public virtual unsafe long All_time_upload {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getAll_time_upload' and count(parameter)=0]"
			[Register ("getAll_time_upload", "()J", "GetGetAll_time_uploadHandler")]
			get {
				const string __id = "getAll_time_upload.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setAll_time_upload' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setAll_time_upload", "(J)V", "GetSetAll_time_upload_JHandler")]
			set {
				const string __id = "setAll_time_upload.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAnnouncing_to_dht;
#pragma warning disable 0169
		static Delegate GetGetAnnouncing_to_dhtHandler ()
		{
			if (cb_getAnnouncing_to_dht == null)
				cb_getAnnouncing_to_dht = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAnnouncing_to_dht);
			return cb_getAnnouncing_to_dht;
		}

		static bool n_GetAnnouncing_to_dht (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Announcing_to_dht;
		}
#pragma warning restore 0169

		static Delegate cb_setAnnouncing_to_dht_Z;
#pragma warning disable 0169
		static Delegate GetSetAnnouncing_to_dht_ZHandler ()
		{
			if (cb_setAnnouncing_to_dht_Z == null)
				cb_setAnnouncing_to_dht_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAnnouncing_to_dht_Z);
			return cb_setAnnouncing_to_dht_Z;
		}

		static void n_SetAnnouncing_to_dht_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Announcing_to_dht = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Announcing_to_dht {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getAnnouncing_to_dht' and count(parameter)=0]"
			[Register ("getAnnouncing_to_dht", "()Z", "GetGetAnnouncing_to_dhtHandler")]
			get {
				const string __id = "getAnnouncing_to_dht.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setAnnouncing_to_dht' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAnnouncing_to_dht", "(Z)V", "GetSetAnnouncing_to_dht_ZHandler")]
			set {
				const string __id = "setAnnouncing_to_dht.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAnnouncing_to_lsd;
#pragma warning disable 0169
		static Delegate GetGetAnnouncing_to_lsdHandler ()
		{
			if (cb_getAnnouncing_to_lsd == null)
				cb_getAnnouncing_to_lsd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAnnouncing_to_lsd);
			return cb_getAnnouncing_to_lsd;
		}

		static bool n_GetAnnouncing_to_lsd (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Announcing_to_lsd;
		}
#pragma warning restore 0169

		static Delegate cb_setAnnouncing_to_lsd_Z;
#pragma warning disable 0169
		static Delegate GetSetAnnouncing_to_lsd_ZHandler ()
		{
			if (cb_setAnnouncing_to_lsd_Z == null)
				cb_setAnnouncing_to_lsd_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAnnouncing_to_lsd_Z);
			return cb_setAnnouncing_to_lsd_Z;
		}

		static void n_SetAnnouncing_to_lsd_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Announcing_to_lsd = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Announcing_to_lsd {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getAnnouncing_to_lsd' and count(parameter)=0]"
			[Register ("getAnnouncing_to_lsd", "()Z", "GetGetAnnouncing_to_lsdHandler")]
			get {
				const string __id = "getAnnouncing_to_lsd.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setAnnouncing_to_lsd' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAnnouncing_to_lsd", "(Z)V", "GetSetAnnouncing_to_lsd_ZHandler")]
			set {
				const string __id = "setAnnouncing_to_lsd.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAnnouncing_to_trackers;
#pragma warning disable 0169
		static Delegate GetGetAnnouncing_to_trackersHandler ()
		{
			if (cb_getAnnouncing_to_trackers == null)
				cb_getAnnouncing_to_trackers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAnnouncing_to_trackers);
			return cb_getAnnouncing_to_trackers;
		}

		static bool n_GetAnnouncing_to_trackers (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Announcing_to_trackers;
		}
#pragma warning restore 0169

		static Delegate cb_setAnnouncing_to_trackers_Z;
#pragma warning disable 0169
		static Delegate GetSetAnnouncing_to_trackers_ZHandler ()
		{
			if (cb_setAnnouncing_to_trackers_Z == null)
				cb_setAnnouncing_to_trackers_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAnnouncing_to_trackers_Z);
			return cb_setAnnouncing_to_trackers_Z;
		}

		static void n_SetAnnouncing_to_trackers_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Announcing_to_trackers = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Announcing_to_trackers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getAnnouncing_to_trackers' and count(parameter)=0]"
			[Register ("getAnnouncing_to_trackers", "()Z", "GetGetAnnouncing_to_trackersHandler")]
			get {
				const string __id = "getAnnouncing_to_trackers.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setAnnouncing_to_trackers' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAnnouncing_to_trackers", "(Z)V", "GetSetAnnouncing_to_trackers_ZHandler")]
			set {
				const string __id = "setAnnouncing_to_trackers.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBlock_size;
#pragma warning disable 0169
		static Delegate GetGetBlock_sizeHandler ()
		{
			if (cb_getBlock_size == null)
				cb_getBlock_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBlock_size);
			return cb_getBlock_size;
		}

		static int n_GetBlock_size (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Block_size;
		}
#pragma warning restore 0169

		static Delegate cb_setBlock_size_I;
#pragma warning disable 0169
		static Delegate GetSetBlock_size_IHandler ()
		{
			if (cb_setBlock_size_I == null)
				cb_setBlock_size_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBlock_size_I);
			return cb_setBlock_size_I;
		}

		static void n_SetBlock_size_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Block_size = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Block_size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getBlock_size' and count(parameter)=0]"
			[Register ("getBlock_size", "()I", "GetGetBlock_sizeHandler")]
			get {
				const string __id = "getBlock_size.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setBlock_size' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBlock_size", "(I)V", "GetSetBlock_size_IHandler")]
			set {
				const string __id = "setBlock_size.(I)V";
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Completed_time = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Completed_time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getCompleted_time' and count(parameter)=0]"
			[Register ("getCompleted_time", "()J", "GetGetCompleted_timeHandler")]
			get {
				const string __id = "getCompleted_time.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setCompleted_time' and count(parameter)=1 and parameter[1][@type='long']]"
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

		static Delegate cb_getConnect_candidates;
#pragma warning disable 0169
		static Delegate GetGetConnect_candidatesHandler ()
		{
			if (cb_getConnect_candidates == null)
				cb_getConnect_candidates = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConnect_candidates);
			return cb_getConnect_candidates;
		}

		static int n_GetConnect_candidates (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Connect_candidates;
		}
#pragma warning restore 0169

		static Delegate cb_setConnect_candidates_I;
#pragma warning disable 0169
		static Delegate GetSetConnect_candidates_IHandler ()
		{
			if (cb_setConnect_candidates_I == null)
				cb_setConnect_candidates_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetConnect_candidates_I);
			return cb_setConnect_candidates_I;
		}

		static void n_SetConnect_candidates_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect_candidates = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Connect_candidates {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getConnect_candidates' and count(parameter)=0]"
			[Register ("getConnect_candidates", "()I", "GetGetConnect_candidatesHandler")]
			get {
				const string __id = "getConnect_candidates.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setConnect_candidates' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConnect_candidates", "(I)V", "GetSetConnect_candidates_IHandler")]
			set {
				const string __id = "setConnect_candidates.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getConnections_limit;
#pragma warning disable 0169
		static Delegate GetGetConnections_limitHandler ()
		{
			if (cb_getConnections_limit == null)
				cb_getConnections_limit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConnections_limit);
			return cb_getConnections_limit;
		}

		static int n_GetConnections_limit (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Connections_limit;
		}
#pragma warning restore 0169

		static Delegate cb_setConnections_limit_I;
#pragma warning disable 0169
		static Delegate GetSetConnections_limit_IHandler ()
		{
			if (cb_setConnections_limit_I == null)
				cb_setConnections_limit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetConnections_limit_I);
			return cb_setConnections_limit_I;
		}

		static void n_SetConnections_limit_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connections_limit = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Connections_limit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getConnections_limit' and count(parameter)=0]"
			[Register ("getConnections_limit", "()I", "GetGetConnections_limitHandler")]
			get {
				const string __id = "getConnections_limit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setConnections_limit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConnections_limit", "(I)V", "GetSetConnections_limit_IHandler")]
			set {
				const string __id = "setConnections_limit.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrent_tracker;
#pragma warning disable 0169
		static Delegate GetGetCurrent_trackerHandler ()
		{
			if (cb_getCurrent_tracker == null)
				cb_getCurrent_tracker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrent_tracker);
			return cb_getCurrent_tracker;
		}

		static IntPtr n_GetCurrent_tracker (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Current_tracker);
		}
#pragma warning restore 0169

		static Delegate cb_setCurrent_tracker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCurrent_tracker_Ljava_lang_String_Handler ()
		{
			if (cb_setCurrent_tracker_Ljava_lang_String_ == null)
				cb_setCurrent_tracker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCurrent_tracker_Ljava_lang_String_);
			return cb_setCurrent_tracker_Ljava_lang_String_;
		}

		static void n_SetCurrent_tracker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Current_tracker = value;
		}
#pragma warning restore 0169

		public virtual unsafe string Current_tracker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getCurrent_tracker' and count(parameter)=0]"
			[Register ("getCurrent_tracker", "()Ljava/lang/String;", "GetGetCurrent_trackerHandler")]
			get {
				const string __id = "getCurrent_tracker.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setCurrent_tracker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCurrent_tracker", "(Ljava/lang/String;)V", "GetSetCurrent_tracker_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCurrent_tracker.(Ljava/lang/String;)V";
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

		static Delegate cb_getDistributed_copies;
#pragma warning disable 0169
		static Delegate GetGetDistributed_copiesHandler ()
		{
			if (cb_getDistributed_copies == null)
				cb_getDistributed_copies = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDistributed_copies);
			return cb_getDistributed_copies;
		}

		static float n_GetDistributed_copies (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Distributed_copies;
		}
#pragma warning restore 0169

		static Delegate cb_setDistributed_copies_F;
#pragma warning disable 0169
		static Delegate GetSetDistributed_copies_FHandler ()
		{
			if (cb_setDistributed_copies_F == null)
				cb_setDistributed_copies_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetDistributed_copies_F);
			return cb_setDistributed_copies_F;
		}

		static void n_SetDistributed_copies_F (IntPtr jnienv, IntPtr native__this, float value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Distributed_copies = value;
		}
#pragma warning restore 0169

		public virtual unsafe float Distributed_copies {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getDistributed_copies' and count(parameter)=0]"
			[Register ("getDistributed_copies", "()F", "GetGetDistributed_copiesHandler")]
			get {
				const string __id = "getDistributed_copies.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setDistributed_copies' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setDistributed_copies", "(F)V", "GetSetDistributed_copies_FHandler")]
			set {
				const string __id = "setDistributed_copies.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDistributed_fraction;
#pragma warning disable 0169
		static Delegate GetGetDistributed_fractionHandler ()
		{
			if (cb_getDistributed_fraction == null)
				cb_getDistributed_fraction = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDistributed_fraction);
			return cb_getDistributed_fraction;
		}

		static int n_GetDistributed_fraction (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Distributed_fraction;
		}
#pragma warning restore 0169

		static Delegate cb_setDistributed_fraction_I;
#pragma warning disable 0169
		static Delegate GetSetDistributed_fraction_IHandler ()
		{
			if (cb_setDistributed_fraction_I == null)
				cb_setDistributed_fraction_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDistributed_fraction_I);
			return cb_setDistributed_fraction_I;
		}

		static void n_SetDistributed_fraction_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Distributed_fraction = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Distributed_fraction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getDistributed_fraction' and count(parameter)=0]"
			[Register ("getDistributed_fraction", "()I", "GetGetDistributed_fractionHandler")]
			get {
				const string __id = "getDistributed_fraction.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setDistributed_fraction' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDistributed_fraction", "(I)V", "GetSetDistributed_fraction_IHandler")]
			set {
				const string __id = "setDistributed_fraction.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDistributed_full_copies;
#pragma warning disable 0169
		static Delegate GetGetDistributed_full_copiesHandler ()
		{
			if (cb_getDistributed_full_copies == null)
				cb_getDistributed_full_copies = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDistributed_full_copies);
			return cb_getDistributed_full_copies;
		}

		static int n_GetDistributed_full_copies (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Distributed_full_copies;
		}
#pragma warning restore 0169

		static Delegate cb_setDistributed_full_copies_I;
#pragma warning disable 0169
		static Delegate GetSetDistributed_full_copies_IHandler ()
		{
			if (cb_setDistributed_full_copies_I == null)
				cb_setDistributed_full_copies_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDistributed_full_copies_I);
			return cb_setDistributed_full_copies_I;
		}

		static void n_SetDistributed_full_copies_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Distributed_full_copies = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Distributed_full_copies {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getDistributed_full_copies' and count(parameter)=0]"
			[Register ("getDistributed_full_copies", "()I", "GetGetDistributed_full_copiesHandler")]
			get {
				const string __id = "getDistributed_full_copies.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setDistributed_full_copies' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDistributed_full_copies", "(I)V", "GetSetDistributed_full_copies_IHandler")]
			set {
				const string __id = "setDistributed_full_copies.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDown_bandwidth_queue;
#pragma warning disable 0169
		static Delegate GetGetDown_bandwidth_queueHandler ()
		{
			if (cb_getDown_bandwidth_queue == null)
				cb_getDown_bandwidth_queue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDown_bandwidth_queue);
			return cb_getDown_bandwidth_queue;
		}

		static int n_GetDown_bandwidth_queue (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Down_bandwidth_queue;
		}
#pragma warning restore 0169

		static Delegate cb_setDown_bandwidth_queue_I;
#pragma warning disable 0169
		static Delegate GetSetDown_bandwidth_queue_IHandler ()
		{
			if (cb_setDown_bandwidth_queue_I == null)
				cb_setDown_bandwidth_queue_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDown_bandwidth_queue_I);
			return cb_setDown_bandwidth_queue_I;
		}

		static void n_SetDown_bandwidth_queue_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Down_bandwidth_queue = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Down_bandwidth_queue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getDown_bandwidth_queue' and count(parameter)=0]"
			[Register ("getDown_bandwidth_queue", "()I", "GetGetDown_bandwidth_queueHandler")]
			get {
				const string __id = "getDown_bandwidth_queue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setDown_bandwidth_queue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDown_bandwidth_queue", "(I)V", "GetSetDown_bandwidth_queue_IHandler")]
			set {
				const string __id = "setDown_bandwidth_queue.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDownload_payload_rate;
#pragma warning disable 0169
		static Delegate GetGetDownload_payload_rateHandler ()
		{
			if (cb_getDownload_payload_rate == null)
				cb_getDownload_payload_rate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDownload_payload_rate);
			return cb_getDownload_payload_rate;
		}

		static int n_GetDownload_payload_rate (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Download_payload_rate;
		}
#pragma warning restore 0169

		static Delegate cb_setDownload_payload_rate_I;
#pragma warning disable 0169
		static Delegate GetSetDownload_payload_rate_IHandler ()
		{
			if (cb_setDownload_payload_rate_I == null)
				cb_setDownload_payload_rate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDownload_payload_rate_I);
			return cb_setDownload_payload_rate_I;
		}

		static void n_SetDownload_payload_rate_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Download_payload_rate = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Download_payload_rate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getDownload_payload_rate' and count(parameter)=0]"
			[Register ("getDownload_payload_rate", "()I", "GetGetDownload_payload_rateHandler")]
			get {
				const string __id = "getDownload_payload_rate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setDownload_payload_rate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDownload_payload_rate", "(I)V", "GetSetDownload_payload_rate_IHandler")]
			set {
				const string __id = "setDownload_payload_rate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDownload_rate;
#pragma warning disable 0169
		static Delegate GetGetDownload_rateHandler ()
		{
			if (cb_getDownload_rate == null)
				cb_getDownload_rate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDownload_rate);
			return cb_getDownload_rate;
		}

		static int n_GetDownload_rate (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Download_rate;
		}
#pragma warning restore 0169

		static Delegate cb_setDownload_rate_I;
#pragma warning disable 0169
		static Delegate GetSetDownload_rate_IHandler ()
		{
			if (cb_setDownload_rate_I == null)
				cb_setDownload_rate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDownload_rate_I);
			return cb_setDownload_rate_I;
		}

		static void n_SetDownload_rate_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Download_rate = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Download_rate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getDownload_rate' and count(parameter)=0]"
			[Register ("getDownload_rate", "()I", "GetGetDownload_rateHandler")]
			get {
				const string __id = "getDownload_rate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setDownload_rate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDownload_rate", "(I)V", "GetSetDownload_rate_IHandler")]
			set {
				const string __id = "setDownload_rate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getErrc;
#pragma warning disable 0169
		static Delegate GetGetErrcHandler ()
		{
			if (cb_getErrc == null)
				cb_getErrc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrc);
			return cb_getErrc;
		}

		static IntPtr n_GetErrc (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Errc);
		}
#pragma warning restore 0169

		static Delegate cb_setErrc_Lcom_frostwire_jlibtorrent_swig_error_code_;
#pragma warning disable 0169
		static Delegate GetSetErrc_Lcom_frostwire_jlibtorrent_swig_error_code_Handler ()
		{
			if (cb_setErrc_Lcom_frostwire_jlibtorrent_swig_error_code_ == null)
				cb_setErrc_Lcom_frostwire_jlibtorrent_swig_error_code_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetErrc_Lcom_frostwire_jlibtorrent_swig_error_code_);
			return cb_setErrc_Lcom_frostwire_jlibtorrent_swig_error_code_;
		}

		static void n_SetErrc_Lcom_frostwire_jlibtorrent_swig_error_code_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Error_code value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Error_code> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Errc = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Error_code Errc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getErrc' and count(parameter)=0]"
			[Register ("getErrc", "()Lcom/frostwire/jlibtorrent/swig/error_code;", "GetGetErrcHandler")]
			get {
				const string __id = "getErrc.()Lcom/frostwire/jlibtorrent/swig/error_code;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Error_code> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setErrc' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.error_code']]"
			[Register ("setErrc", "(Lcom/frostwire/jlibtorrent/swig/error_code;)V", "GetSetErrc_Lcom_frostwire_jlibtorrent_swig_error_code_Handler")]
			set {
				const string __id = "setErrc.(Lcom/frostwire/jlibtorrent/swig/error_code;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getError_file;
#pragma warning disable 0169
		static Delegate GetGetError_fileHandler ()
		{
			if (cb_getError_file == null)
				cb_getError_file = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetError_file);
			return cb_getError_file;
		}

		static int n_GetError_file (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Error_file;
		}
#pragma warning restore 0169

		static Delegate cb_setError_file_I;
#pragma warning disable 0169
		static Delegate GetSetError_file_IHandler ()
		{
			if (cb_setError_file_I == null)
				cb_setError_file_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetError_file_I);
			return cb_setError_file_I;
		}

		static void n_SetError_file_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Error_file = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Error_file {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getError_file' and count(parameter)=0]"
			[Register ("getError_file", "()I", "GetGetError_fileHandler")]
			get {
				const string __id = "getError_file.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setError_file' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setError_file", "(I)V", "GetSetError_file_IHandler")]
			set {
				const string __id = "setError_file.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public static unsafe int Error_file_exception {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getError_file_exception' and count(parameter)=0]"
			[Register ("getError_file_exception", "()I", "GetGetError_file_exceptionHandler")]
			get {
				const string __id = "getError_file_exception.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int Error_file_none {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getError_file_none' and count(parameter)=0]"
			[Register ("getError_file_none", "()I", "GetGetError_file_noneHandler")]
			get {
				const string __id = "getError_file_none.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int Error_file_partfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getError_file_partfile' and count(parameter)=0]"
			[Register ("getError_file_partfile", "()I", "GetGetError_file_partfileHandler")]
			get {
				const string __id = "getError_file_partfile.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int Error_file_ssl_ctx {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getError_file_ssl_ctx' and count(parameter)=0]"
			[Register ("getError_file_ssl_ctx", "()I", "GetGetError_file_ssl_ctxHandler")]
			get {
				const string __id = "getError_file_ssl_ctx.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Torrent_flags_t value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Flags = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Flags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getFlags' and count(parameter)=0]"
			[Register ("getFlags", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetGetFlagsHandler")]
			get {
				const string __id = "getFlags.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setFlags' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_flags_t']]"
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

		static Delegate cb_getHas_incoming;
#pragma warning disable 0169
		static Delegate GetGetHas_incomingHandler ()
		{
			if (cb_getHas_incoming == null)
				cb_getHas_incoming = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetHas_incoming);
			return cb_getHas_incoming;
		}

		static bool n_GetHas_incoming (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Has_incoming;
		}
#pragma warning restore 0169

		static Delegate cb_setHas_incoming_Z;
#pragma warning disable 0169
		static Delegate GetSetHas_incoming_ZHandler ()
		{
			if (cb_setHas_incoming_Z == null)
				cb_setHas_incoming_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHas_incoming_Z);
			return cb_setHas_incoming_Z;
		}

		static void n_SetHas_incoming_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Has_incoming = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Has_incoming {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getHas_incoming' and count(parameter)=0]"
			[Register ("getHas_incoming", "()Z", "GetGetHas_incomingHandler")]
			get {
				const string __id = "getHas_incoming.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setHas_incoming' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHas_incoming", "(Z)V", "GetSetHas_incoming_ZHandler")]
			set {
				const string __id = "setHas_incoming.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHas_metadata;
#pragma warning disable 0169
		static Delegate GetGetHas_metadataHandler ()
		{
			if (cb_getHas_metadata == null)
				cb_getHas_metadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetHas_metadata);
			return cb_getHas_metadata;
		}

		static bool n_GetHas_metadata (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Has_metadata;
		}
#pragma warning restore 0169

		static Delegate cb_setHas_metadata_Z;
#pragma warning disable 0169
		static Delegate GetSetHas_metadata_ZHandler ()
		{
			if (cb_setHas_metadata_Z == null)
				cb_setHas_metadata_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHas_metadata_Z);
			return cb_setHas_metadata_Z;
		}

		static void n_SetHas_metadata_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Has_metadata = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Has_metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getHas_metadata' and count(parameter)=0]"
			[Register ("getHas_metadata", "()Z", "GetGetHas_metadataHandler")]
			get {
				const string __id = "getHas_metadata.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setHas_metadata' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHas_metadata", "(Z)V", "GetSetHas_metadata_ZHandler")]
			set {
				const string __id = "setHas_metadata.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Info_hash = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash Info_hash {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getInfo_hash' and count(parameter)=0]"
			[Register ("getInfo_hash", "()Lcom/frostwire/jlibtorrent/swig/sha1_hash;", "GetGetInfo_hashHandler")]
			get {
				const string __id = "getInfo_hash.()Lcom/frostwire/jlibtorrent/swig/sha1_hash;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setInfo_hash' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
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

		static Delegate cb_getIs_finished;
#pragma warning disable 0169
		static Delegate GetGetIs_finishedHandler ()
		{
			if (cb_getIs_finished == null)
				cb_getIs_finished = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIs_finished);
			return cb_getIs_finished;
		}

		static bool n_GetIs_finished (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_finished;
		}
#pragma warning restore 0169

		static Delegate cb_setIs_finished_Z;
#pragma warning disable 0169
		static Delegate GetSetIs_finished_ZHandler ()
		{
			if (cb_setIs_finished_Z == null)
				cb_setIs_finished_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIs_finished_Z);
			return cb_setIs_finished_Z;
		}

		static void n_SetIs_finished_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Is_finished = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Is_finished {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getIs_finished' and count(parameter)=0]"
			[Register ("getIs_finished", "()Z", "GetGetIs_finishedHandler")]
			get {
				const string __id = "getIs_finished.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setIs_finished' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIs_finished", "(Z)V", "GetSetIs_finished_ZHandler")]
			set {
				const string __id = "setIs_finished.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIs_seeding;
#pragma warning disable 0169
		static Delegate GetGetIs_seedingHandler ()
		{
			if (cb_getIs_seeding == null)
				cb_getIs_seeding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIs_seeding);
			return cb_getIs_seeding;
		}

		static bool n_GetIs_seeding (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_seeding;
		}
#pragma warning restore 0169

		static Delegate cb_setIs_seeding_Z;
#pragma warning disable 0169
		static Delegate GetSetIs_seeding_ZHandler ()
		{
			if (cb_setIs_seeding_Z == null)
				cb_setIs_seeding_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIs_seeding_Z);
			return cb_setIs_seeding_Z;
		}

		static void n_SetIs_seeding_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Is_seeding = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Is_seeding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getIs_seeding' and count(parameter)=0]"
			[Register ("getIs_seeding", "()Z", "GetGetIs_seedingHandler")]
			get {
				const string __id = "getIs_seeding.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setIs_seeding' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIs_seeding", "(Z)V", "GetSetIs_seeding_ZHandler")]
			set {
				const string __id = "setIs_seeding.(Z)V";
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Last_seen_complete = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Last_seen_complete {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getLast_seen_complete' and count(parameter)=0]"
			[Register ("getLast_seen_complete", "()J", "GetGetLast_seen_completeHandler")]
			get {
				const string __id = "getLast_seen_complete.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setLast_seen_complete' and count(parameter)=1 and parameter[1][@type='long']]"
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

		static Delegate cb_getList_peers;
#pragma warning disable 0169
		static Delegate GetGetList_peersHandler ()
		{
			if (cb_getList_peers == null)
				cb_getList_peers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetList_peers);
			return cb_getList_peers;
		}

		static int n_GetList_peers (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.List_peers;
		}
#pragma warning restore 0169

		static Delegate cb_setList_peers_I;
#pragma warning disable 0169
		static Delegate GetSetList_peers_IHandler ()
		{
			if (cb_setList_peers_I == null)
				cb_setList_peers_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetList_peers_I);
			return cb_setList_peers_I;
		}

		static void n_SetList_peers_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.List_peers = value;
		}
#pragma warning restore 0169

		public virtual unsafe int List_peers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getList_peers' and count(parameter)=0]"
			[Register ("getList_peers", "()I", "GetGetList_peersHandler")]
			get {
				const string __id = "getList_peers.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setList_peers' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setList_peers", "(I)V", "GetSetList_peers_IHandler")]
			set {
				const string __id = "setList_peers.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getList_seeds;
#pragma warning disable 0169
		static Delegate GetGetList_seedsHandler ()
		{
			if (cb_getList_seeds == null)
				cb_getList_seeds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetList_seeds);
			return cb_getList_seeds;
		}

		static int n_GetList_seeds (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.List_seeds;
		}
#pragma warning restore 0169

		static Delegate cb_setList_seeds_I;
#pragma warning disable 0169
		static Delegate GetSetList_seeds_IHandler ()
		{
			if (cb_setList_seeds_I == null)
				cb_setList_seeds_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetList_seeds_I);
			return cb_setList_seeds_I;
		}

		static void n_SetList_seeds_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.List_seeds = value;
		}
#pragma warning restore 0169

		public virtual unsafe int List_seeds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getList_seeds' and count(parameter)=0]"
			[Register ("getList_seeds", "()I", "GetGetList_seedsHandler")]
			get {
				const string __id = "getList_seeds.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setList_seeds' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setList_seeds", "(I)V", "GetSetList_seeds_IHandler")]
			set {
				const string __id = "setList_seeds.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMoving_storage;
#pragma warning disable 0169
		static Delegate GetGetMoving_storageHandler ()
		{
			if (cb_getMoving_storage == null)
				cb_getMoving_storage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetMoving_storage);
			return cb_getMoving_storage;
		}

		static bool n_GetMoving_storage (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Moving_storage;
		}
#pragma warning restore 0169

		static Delegate cb_setMoving_storage_Z;
#pragma warning disable 0169
		static Delegate GetSetMoving_storage_ZHandler ()
		{
			if (cb_setMoving_storage_Z == null)
				cb_setMoving_storage_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMoving_storage_Z);
			return cb_setMoving_storage_Z;
		}

		static void n_SetMoving_storage_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Moving_storage = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Moving_storage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getMoving_storage' and count(parameter)=0]"
			[Register ("getMoving_storage", "()Z", "GetGetMoving_storageHandler")]
			get {
				const string __id = "getMoving_storage.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setMoving_storage' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMoving_storage", "(Z)V", "GetSetMoving_storage_ZHandler")]
			set {
				const string __id = "setMoving_storage.(Z)V";
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Name = value;
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getNeed_save_resume;
#pragma warning disable 0169
		static Delegate GetGetNeed_save_resumeHandler ()
		{
			if (cb_getNeed_save_resume == null)
				cb_getNeed_save_resume = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetNeed_save_resume);
			return cb_getNeed_save_resume;
		}

		static bool n_GetNeed_save_resume (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Need_save_resume;
		}
#pragma warning restore 0169

		static Delegate cb_setNeed_save_resume_Z;
#pragma warning disable 0169
		static Delegate GetSetNeed_save_resume_ZHandler ()
		{
			if (cb_setNeed_save_resume_Z == null)
				cb_setNeed_save_resume_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetNeed_save_resume_Z);
			return cb_setNeed_save_resume_Z;
		}

		static void n_SetNeed_save_resume_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Need_save_resume = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Need_save_resume {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getNeed_save_resume' and count(parameter)=0]"
			[Register ("getNeed_save_resume", "()Z", "GetGetNeed_save_resumeHandler")]
			get {
				const string __id = "getNeed_save_resume.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setNeed_save_resume' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNeed_save_resume", "(Z)V", "GetSetNeed_save_resume_ZHandler")]
			set {
				const string __id = "setNeed_save_resume.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Num_complete = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Num_complete {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getNum_complete' and count(parameter)=0]"
			[Register ("getNum_complete", "()I", "GetGetNum_completeHandler")]
			get {
				const string __id = "getNum_complete.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setNum_complete' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getNum_connections;
#pragma warning disable 0169
		static Delegate GetGetNum_connectionsHandler ()
		{
			if (cb_getNum_connections == null)
				cb_getNum_connections = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNum_connections);
			return cb_getNum_connections;
		}

		static int n_GetNum_connections (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_connections;
		}
#pragma warning restore 0169

		static Delegate cb_setNum_connections_I;
#pragma warning disable 0169
		static Delegate GetSetNum_connections_IHandler ()
		{
			if (cb_setNum_connections_I == null)
				cb_setNum_connections_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNum_connections_I);
			return cb_setNum_connections_I;
		}

		static void n_SetNum_connections_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Num_connections = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Num_connections {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getNum_connections' and count(parameter)=0]"
			[Register ("getNum_connections", "()I", "GetGetNum_connectionsHandler")]
			get {
				const string __id = "getNum_connections.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setNum_connections' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNum_connections", "(I)V", "GetSetNum_connections_IHandler")]
			set {
				const string __id = "setNum_connections.(I)V";
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Num_incomplete = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Num_incomplete {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getNum_incomplete' and count(parameter)=0]"
			[Register ("getNum_incomplete", "()I", "GetGetNum_incompleteHandler")]
			get {
				const string __id = "getNum_incomplete.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setNum_incomplete' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getNum_peers;
#pragma warning disable 0169
		static Delegate GetGetNum_peersHandler ()
		{
			if (cb_getNum_peers == null)
				cb_getNum_peers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNum_peers);
			return cb_getNum_peers;
		}

		static int n_GetNum_peers (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_peers;
		}
#pragma warning restore 0169

		static Delegate cb_setNum_peers_I;
#pragma warning disable 0169
		static Delegate GetSetNum_peers_IHandler ()
		{
			if (cb_setNum_peers_I == null)
				cb_setNum_peers_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNum_peers_I);
			return cb_setNum_peers_I;
		}

		static void n_SetNum_peers_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Num_peers = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Num_peers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getNum_peers' and count(parameter)=0]"
			[Register ("getNum_peers", "()I", "GetGetNum_peersHandler")]
			get {
				const string __id = "getNum_peers.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setNum_peers' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNum_peers", "(I)V", "GetSetNum_peers_IHandler")]
			set {
				const string __id = "setNum_peers.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNum_pieces;
#pragma warning disable 0169
		static Delegate GetGetNum_piecesHandler ()
		{
			if (cb_getNum_pieces == null)
				cb_getNum_pieces = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNum_pieces);
			return cb_getNum_pieces;
		}

		static int n_GetNum_pieces (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_pieces;
		}
#pragma warning restore 0169

		static Delegate cb_setNum_pieces_I;
#pragma warning disable 0169
		static Delegate GetSetNum_pieces_IHandler ()
		{
			if (cb_setNum_pieces_I == null)
				cb_setNum_pieces_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNum_pieces_I);
			return cb_setNum_pieces_I;
		}

		static void n_SetNum_pieces_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Num_pieces = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Num_pieces {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getNum_pieces' and count(parameter)=0]"
			[Register ("getNum_pieces", "()I", "GetGetNum_piecesHandler")]
			get {
				const string __id = "getNum_pieces.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setNum_pieces' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNum_pieces", "(I)V", "GetSetNum_pieces_IHandler")]
			set {
				const string __id = "setNum_pieces.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNum_seeds;
#pragma warning disable 0169
		static Delegate GetGetNum_seedsHandler ()
		{
			if (cb_getNum_seeds == null)
				cb_getNum_seeds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNum_seeds);
			return cb_getNum_seeds;
		}

		static int n_GetNum_seeds (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_seeds;
		}
#pragma warning restore 0169

		static Delegate cb_setNum_seeds_I;
#pragma warning disable 0169
		static Delegate GetSetNum_seeds_IHandler ()
		{
			if (cb_setNum_seeds_I == null)
				cb_setNum_seeds_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNum_seeds_I);
			return cb_setNum_seeds_I;
		}

		static void n_SetNum_seeds_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Num_seeds = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Num_seeds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getNum_seeds' and count(parameter)=0]"
			[Register ("getNum_seeds", "()I", "GetGetNum_seedsHandler")]
			get {
				const string __id = "getNum_seeds.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setNum_seeds' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNum_seeds", "(I)V", "GetSetNum_seeds_IHandler")]
			set {
				const string __id = "setNum_seeds.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNum_uploads;
#pragma warning disable 0169
		static Delegate GetGetNum_uploadsHandler ()
		{
			if (cb_getNum_uploads == null)
				cb_getNum_uploads = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNum_uploads);
			return cb_getNum_uploads;
		}

		static int n_GetNum_uploads (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_uploads;
		}
#pragma warning restore 0169

		static Delegate cb_setNum_uploads_I;
#pragma warning disable 0169
		static Delegate GetSetNum_uploads_IHandler ()
		{
			if (cb_setNum_uploads_I == null)
				cb_setNum_uploads_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNum_uploads_I);
			return cb_setNum_uploads_I;
		}

		static void n_SetNum_uploads_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Num_uploads = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Num_uploads {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getNum_uploads' and count(parameter)=0]"
			[Register ("getNum_uploads", "()I", "GetGetNum_uploadsHandler")]
			get {
				const string __id = "getNum_uploads.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setNum_uploads' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNum_uploads", "(I)V", "GetSetNum_uploads_IHandler")]
			set {
				const string __id = "setNum_uploads.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPieces;
#pragma warning disable 0169
		static Delegate GetGetPiecesHandler ()
		{
			if (cb_getPieces == null)
				cb_getPieces = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPieces);
			return cb_getPieces;
		}

		static IntPtr n_GetPieces (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pieces);
		}
#pragma warning restore 0169

		static Delegate cb_setPieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_;
#pragma warning disable 0169
		static Delegate GetSetPieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_Handler ()
		{
			if (cb_setPieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_ == null)
				cb_setPieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_);
			return cb_setPieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_;
		}

		static void n_SetPieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Pieces = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Piece_index_bitfield Pieces {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getPieces' and count(parameter)=0]"
			[Register ("getPieces", "()Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;", "GetGetPiecesHandler")]
			get {
				const string __id = "getPieces.()Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setPieces' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.piece_index_bitfield']]"
			[Register ("setPieces", "(Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;)V", "GetSetPieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_Handler")]
			set {
				const string __id = "setPieces.(Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProgress;
#pragma warning disable 0169
		static Delegate GetGetProgressHandler ()
		{
			if (cb_getProgress == null)
				cb_getProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetProgress);
			return cb_getProgress;
		}

		static float n_GetProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Progress;
		}
#pragma warning restore 0169

		static Delegate cb_setProgress_F;
#pragma warning disable 0169
		static Delegate GetSetProgress_FHandler ()
		{
			if (cb_setProgress_F == null)
				cb_setProgress_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetProgress_F);
			return cb_setProgress_F;
		}

		static void n_SetProgress_F (IntPtr jnienv, IntPtr native__this, float value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Progress = value;
		}
#pragma warning restore 0169

		public virtual unsafe float Progress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getProgress' and count(parameter)=0]"
			[Register ("getProgress", "()F", "GetGetProgressHandler")]
			get {
				const string __id = "getProgress.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setProgress' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setProgress", "(F)V", "GetSetProgress_FHandler")]
			set {
				const string __id = "setProgress.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProgress_ppm;
#pragma warning disable 0169
		static Delegate GetGetProgress_ppmHandler ()
		{
			if (cb_getProgress_ppm == null)
				cb_getProgress_ppm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetProgress_ppm);
			return cb_getProgress_ppm;
		}

		static int n_GetProgress_ppm (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Progress_ppm;
		}
#pragma warning restore 0169

		static Delegate cb_setProgress_ppm_I;
#pragma warning disable 0169
		static Delegate GetSetProgress_ppm_IHandler ()
		{
			if (cb_setProgress_ppm_I == null)
				cb_setProgress_ppm_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetProgress_ppm_I);
			return cb_setProgress_ppm_I;
		}

		static void n_SetProgress_ppm_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Progress_ppm = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Progress_ppm {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getProgress_ppm' and count(parameter)=0]"
			[Register ("getProgress_ppm", "()I", "GetGetProgress_ppmHandler")]
			get {
				const string __id = "getProgress_ppm.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setProgress_ppm' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setProgress_ppm", "(I)V", "GetSetProgress_ppm_IHandler")]
			set {
				const string __id = "setProgress_ppm.(I)V";
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Save_path = value;
		}
#pragma warning restore 0169

		public virtual unsafe string Save_path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getSave_path' and count(parameter)=0]"
			[Register ("getSave_path", "()Ljava/lang/String;", "GetGetSave_pathHandler")]
			get {
				const string __id = "getSave_path.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setSave_path' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getSeed_rank;
#pragma warning disable 0169
		static Delegate GetGetSeed_rankHandler ()
		{
			if (cb_getSeed_rank == null)
				cb_getSeed_rank = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSeed_rank);
			return cb_getSeed_rank;
		}

		static int n_GetSeed_rank (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Seed_rank;
		}
#pragma warning restore 0169

		static Delegate cb_setSeed_rank_I;
#pragma warning disable 0169
		static Delegate GetSetSeed_rank_IHandler ()
		{
			if (cb_setSeed_rank_I == null)
				cb_setSeed_rank_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSeed_rank_I);
			return cb_setSeed_rank_I;
		}

		static void n_SetSeed_rank_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Seed_rank = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Seed_rank {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getSeed_rank' and count(parameter)=0]"
			[Register ("getSeed_rank", "()I", "GetGetSeed_rankHandler")]
			get {
				const string __id = "getSeed_rank.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setSeed_rank' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSeed_rank", "(I)V", "GetSetSeed_rank_IHandler")]
			set {
				const string __id = "setSeed_rank.(I)V";
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
				cb_getState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.State);
		}
#pragma warning restore 0169

		static Delegate cb_setState_Lcom_frostwire_jlibtorrent_swig_torrent_status_state_t_;
#pragma warning disable 0169
		static Delegate GetSetState_Lcom_frostwire_jlibtorrent_swig_torrent_status_state_t_Handler ()
		{
			if (cb_setState_Lcom_frostwire_jlibtorrent_swig_torrent_status_state_t_ == null)
				cb_setState_Lcom_frostwire_jlibtorrent_swig_torrent_status_state_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetState_Lcom_frostwire_jlibtorrent_swig_torrent_status_state_t_);
			return cb_setState_Lcom_frostwire_jlibtorrent_swig_torrent_status_state_t_;
		}

		static void n_SetState_Lcom_frostwire_jlibtorrent_swig_torrent_status_state_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Torrent_status.State_t value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status.State_t> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.State = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Torrent_status.State_t State {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lcom/frostwire/jlibtorrent/swig/torrent_status$state_t;", "GetGetStateHandler")]
			get {
				const string __id = "getState.()Lcom/frostwire/jlibtorrent/swig/torrent_status$state_t;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status.State_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setState' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_status.state_t']]"
			[Register ("setState", "(Lcom/frostwire/jlibtorrent/swig/torrent_status$state_t;)V", "GetSetState_Lcom_frostwire_jlibtorrent_swig_torrent_status_state_t_Handler")]
			set {
				const string __id = "setState.(Lcom/frostwire/jlibtorrent/swig/torrent_status$state_t;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Storage_mode_t value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Storage_mode_t> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Storage_mode = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Storage_mode_t Storage_mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getStorage_mode' and count(parameter)=0]"
			[Register ("getStorage_mode", "()Lcom/frostwire/jlibtorrent/swig/storage_mode_t;", "GetGetStorage_modeHandler")]
			get {
				const string __id = "getStorage_mode.()Lcom/frostwire/jlibtorrent/swig/storage_mode_t;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Storage_mode_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setStorage_mode' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.storage_mode_t']]"
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

		static Delegate cb_getTotal;
#pragma warning disable 0169
		static Delegate GetGetTotalHandler ()
		{
			if (cb_getTotal == null)
				cb_getTotal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTotal);
			return cb_getTotal;
		}

		static long n_GetTotal (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Total;
		}
#pragma warning restore 0169

		static Delegate cb_setTotal_J;
#pragma warning disable 0169
		static Delegate GetSetTotal_JHandler ()
		{
			if (cb_setTotal_J == null)
				cb_setTotal_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTotal_J);
			return cb_setTotal_J;
		}

		static void n_SetTotal_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Total = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Total {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getTotal' and count(parameter)=0]"
			[Register ("getTotal", "()J", "GetGetTotalHandler")]
			get {
				const string __id = "getTotal.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setTotal' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTotal", "(J)V", "GetSetTotal_JHandler")]
			set {
				const string __id = "setTotal.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotal_done;
#pragma warning disable 0169
		static Delegate GetGetTotal_doneHandler ()
		{
			if (cb_getTotal_done == null)
				cb_getTotal_done = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTotal_done);
			return cb_getTotal_done;
		}

		static long n_GetTotal_done (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Total_done;
		}
#pragma warning restore 0169

		static Delegate cb_setTotal_done_J;
#pragma warning disable 0169
		static Delegate GetSetTotal_done_JHandler ()
		{
			if (cb_setTotal_done_J == null)
				cb_setTotal_done_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTotal_done_J);
			return cb_setTotal_done_J;
		}

		static void n_SetTotal_done_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Total_done = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Total_done {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getTotal_done' and count(parameter)=0]"
			[Register ("getTotal_done", "()J", "GetGetTotal_doneHandler")]
			get {
				const string __id = "getTotal_done.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setTotal_done' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTotal_done", "(J)V", "GetSetTotal_done_JHandler")]
			set {
				const string __id = "setTotal_done.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotal_download;
#pragma warning disable 0169
		static Delegate GetGetTotal_downloadHandler ()
		{
			if (cb_getTotal_download == null)
				cb_getTotal_download = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTotal_download);
			return cb_getTotal_download;
		}

		static long n_GetTotal_download (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Total_download;
		}
#pragma warning restore 0169

		static Delegate cb_setTotal_download_J;
#pragma warning disable 0169
		static Delegate GetSetTotal_download_JHandler ()
		{
			if (cb_setTotal_download_J == null)
				cb_setTotal_download_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTotal_download_J);
			return cb_setTotal_download_J;
		}

		static void n_SetTotal_download_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Total_download = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Total_download {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getTotal_download' and count(parameter)=0]"
			[Register ("getTotal_download", "()J", "GetGetTotal_downloadHandler")]
			get {
				const string __id = "getTotal_download.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setTotal_download' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTotal_download", "(J)V", "GetSetTotal_download_JHandler")]
			set {
				const string __id = "setTotal_download.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotal_failed_bytes;
#pragma warning disable 0169
		static Delegate GetGetTotal_failed_bytesHandler ()
		{
			if (cb_getTotal_failed_bytes == null)
				cb_getTotal_failed_bytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTotal_failed_bytes);
			return cb_getTotal_failed_bytes;
		}

		static long n_GetTotal_failed_bytes (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Total_failed_bytes;
		}
#pragma warning restore 0169

		static Delegate cb_setTotal_failed_bytes_J;
#pragma warning disable 0169
		static Delegate GetSetTotal_failed_bytes_JHandler ()
		{
			if (cb_setTotal_failed_bytes_J == null)
				cb_setTotal_failed_bytes_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTotal_failed_bytes_J);
			return cb_setTotal_failed_bytes_J;
		}

		static void n_SetTotal_failed_bytes_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Total_failed_bytes = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Total_failed_bytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getTotal_failed_bytes' and count(parameter)=0]"
			[Register ("getTotal_failed_bytes", "()J", "GetGetTotal_failed_bytesHandler")]
			get {
				const string __id = "getTotal_failed_bytes.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setTotal_failed_bytes' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTotal_failed_bytes", "(J)V", "GetSetTotal_failed_bytes_JHandler")]
			set {
				const string __id = "setTotal_failed_bytes.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotal_payload_download;
#pragma warning disable 0169
		static Delegate GetGetTotal_payload_downloadHandler ()
		{
			if (cb_getTotal_payload_download == null)
				cb_getTotal_payload_download = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTotal_payload_download);
			return cb_getTotal_payload_download;
		}

		static long n_GetTotal_payload_download (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Total_payload_download;
		}
#pragma warning restore 0169

		static Delegate cb_setTotal_payload_download_J;
#pragma warning disable 0169
		static Delegate GetSetTotal_payload_download_JHandler ()
		{
			if (cb_setTotal_payload_download_J == null)
				cb_setTotal_payload_download_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTotal_payload_download_J);
			return cb_setTotal_payload_download_J;
		}

		static void n_SetTotal_payload_download_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Total_payload_download = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Total_payload_download {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getTotal_payload_download' and count(parameter)=0]"
			[Register ("getTotal_payload_download", "()J", "GetGetTotal_payload_downloadHandler")]
			get {
				const string __id = "getTotal_payload_download.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setTotal_payload_download' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTotal_payload_download", "(J)V", "GetSetTotal_payload_download_JHandler")]
			set {
				const string __id = "setTotal_payload_download.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotal_payload_upload;
#pragma warning disable 0169
		static Delegate GetGetTotal_payload_uploadHandler ()
		{
			if (cb_getTotal_payload_upload == null)
				cb_getTotal_payload_upload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTotal_payload_upload);
			return cb_getTotal_payload_upload;
		}

		static long n_GetTotal_payload_upload (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Total_payload_upload;
		}
#pragma warning restore 0169

		static Delegate cb_setTotal_payload_upload_J;
#pragma warning disable 0169
		static Delegate GetSetTotal_payload_upload_JHandler ()
		{
			if (cb_setTotal_payload_upload_J == null)
				cb_setTotal_payload_upload_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTotal_payload_upload_J);
			return cb_setTotal_payload_upload_J;
		}

		static void n_SetTotal_payload_upload_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Total_payload_upload = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Total_payload_upload {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getTotal_payload_upload' and count(parameter)=0]"
			[Register ("getTotal_payload_upload", "()J", "GetGetTotal_payload_uploadHandler")]
			get {
				const string __id = "getTotal_payload_upload.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setTotal_payload_upload' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTotal_payload_upload", "(J)V", "GetSetTotal_payload_upload_JHandler")]
			set {
				const string __id = "setTotal_payload_upload.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotal_redundant_bytes;
#pragma warning disable 0169
		static Delegate GetGetTotal_redundant_bytesHandler ()
		{
			if (cb_getTotal_redundant_bytes == null)
				cb_getTotal_redundant_bytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTotal_redundant_bytes);
			return cb_getTotal_redundant_bytes;
		}

		static long n_GetTotal_redundant_bytes (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Total_redundant_bytes;
		}
#pragma warning restore 0169

		static Delegate cb_setTotal_redundant_bytes_J;
#pragma warning disable 0169
		static Delegate GetSetTotal_redundant_bytes_JHandler ()
		{
			if (cb_setTotal_redundant_bytes_J == null)
				cb_setTotal_redundant_bytes_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTotal_redundant_bytes_J);
			return cb_setTotal_redundant_bytes_J;
		}

		static void n_SetTotal_redundant_bytes_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Total_redundant_bytes = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Total_redundant_bytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getTotal_redundant_bytes' and count(parameter)=0]"
			[Register ("getTotal_redundant_bytes", "()J", "GetGetTotal_redundant_bytesHandler")]
			get {
				const string __id = "getTotal_redundant_bytes.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setTotal_redundant_bytes' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTotal_redundant_bytes", "(J)V", "GetSetTotal_redundant_bytes_JHandler")]
			set {
				const string __id = "setTotal_redundant_bytes.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotal_upload;
#pragma warning disable 0169
		static Delegate GetGetTotal_uploadHandler ()
		{
			if (cb_getTotal_upload == null)
				cb_getTotal_upload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTotal_upload);
			return cb_getTotal_upload;
		}

		static long n_GetTotal_upload (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Total_upload;
		}
#pragma warning restore 0169

		static Delegate cb_setTotal_upload_J;
#pragma warning disable 0169
		static Delegate GetSetTotal_upload_JHandler ()
		{
			if (cb_setTotal_upload_J == null)
				cb_setTotal_upload_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTotal_upload_J);
			return cb_setTotal_upload_J;
		}

		static void n_SetTotal_upload_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Total_upload = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Total_upload {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getTotal_upload' and count(parameter)=0]"
			[Register ("getTotal_upload", "()J", "GetGetTotal_uploadHandler")]
			get {
				const string __id = "getTotal_upload.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setTotal_upload' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTotal_upload", "(J)V", "GetSetTotal_upload_JHandler")]
			set {
				const string __id = "setTotal_upload.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotal_wanted;
#pragma warning disable 0169
		static Delegate GetGetTotal_wantedHandler ()
		{
			if (cb_getTotal_wanted == null)
				cb_getTotal_wanted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTotal_wanted);
			return cb_getTotal_wanted;
		}

		static long n_GetTotal_wanted (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Total_wanted;
		}
#pragma warning restore 0169

		static Delegate cb_setTotal_wanted_J;
#pragma warning disable 0169
		static Delegate GetSetTotal_wanted_JHandler ()
		{
			if (cb_setTotal_wanted_J == null)
				cb_setTotal_wanted_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTotal_wanted_J);
			return cb_setTotal_wanted_J;
		}

		static void n_SetTotal_wanted_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Total_wanted = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Total_wanted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getTotal_wanted' and count(parameter)=0]"
			[Register ("getTotal_wanted", "()J", "GetGetTotal_wantedHandler")]
			get {
				const string __id = "getTotal_wanted.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setTotal_wanted' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTotal_wanted", "(J)V", "GetSetTotal_wanted_JHandler")]
			set {
				const string __id = "setTotal_wanted.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotal_wanted_done;
#pragma warning disable 0169
		static Delegate GetGetTotal_wanted_doneHandler ()
		{
			if (cb_getTotal_wanted_done == null)
				cb_getTotal_wanted_done = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTotal_wanted_done);
			return cb_getTotal_wanted_done;
		}

		static long n_GetTotal_wanted_done (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Total_wanted_done;
		}
#pragma warning restore 0169

		static Delegate cb_setTotal_wanted_done_J;
#pragma warning disable 0169
		static Delegate GetSetTotal_wanted_done_JHandler ()
		{
			if (cb_setTotal_wanted_done_J == null)
				cb_setTotal_wanted_done_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTotal_wanted_done_J);
			return cb_setTotal_wanted_done_J;
		}

		static void n_SetTotal_wanted_done_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Total_wanted_done = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Total_wanted_done {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getTotal_wanted_done' and count(parameter)=0]"
			[Register ("getTotal_wanted_done", "()J", "GetGetTotal_wanted_doneHandler")]
			get {
				const string __id = "getTotal_wanted_done.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setTotal_wanted_done' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTotal_wanted_done", "(J)V", "GetSetTotal_wanted_done_JHandler")]
			set {
				const string __id = "setTotal_wanted_done.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUp_bandwidth_queue;
#pragma warning disable 0169
		static Delegate GetGetUp_bandwidth_queueHandler ()
		{
			if (cb_getUp_bandwidth_queue == null)
				cb_getUp_bandwidth_queue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUp_bandwidth_queue);
			return cb_getUp_bandwidth_queue;
		}

		static int n_GetUp_bandwidth_queue (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Up_bandwidth_queue;
		}
#pragma warning restore 0169

		static Delegate cb_setUp_bandwidth_queue_I;
#pragma warning disable 0169
		static Delegate GetSetUp_bandwidth_queue_IHandler ()
		{
			if (cb_setUp_bandwidth_queue_I == null)
				cb_setUp_bandwidth_queue_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUp_bandwidth_queue_I);
			return cb_setUp_bandwidth_queue_I;
		}

		static void n_SetUp_bandwidth_queue_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Up_bandwidth_queue = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Up_bandwidth_queue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getUp_bandwidth_queue' and count(parameter)=0]"
			[Register ("getUp_bandwidth_queue", "()I", "GetGetUp_bandwidth_queueHandler")]
			get {
				const string __id = "getUp_bandwidth_queue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setUp_bandwidth_queue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUp_bandwidth_queue", "(I)V", "GetSetUp_bandwidth_queue_IHandler")]
			set {
				const string __id = "setUp_bandwidth_queue.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUpload_payload_rate;
#pragma warning disable 0169
		static Delegate GetGetUpload_payload_rateHandler ()
		{
			if (cb_getUpload_payload_rate == null)
				cb_getUpload_payload_rate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUpload_payload_rate);
			return cb_getUpload_payload_rate;
		}

		static int n_GetUpload_payload_rate (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Upload_payload_rate;
		}
#pragma warning restore 0169

		static Delegate cb_setUpload_payload_rate_I;
#pragma warning disable 0169
		static Delegate GetSetUpload_payload_rate_IHandler ()
		{
			if (cb_setUpload_payload_rate_I == null)
				cb_setUpload_payload_rate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUpload_payload_rate_I);
			return cb_setUpload_payload_rate_I;
		}

		static void n_SetUpload_payload_rate_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Upload_payload_rate = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Upload_payload_rate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getUpload_payload_rate' and count(parameter)=0]"
			[Register ("getUpload_payload_rate", "()I", "GetGetUpload_payload_rateHandler")]
			get {
				const string __id = "getUpload_payload_rate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setUpload_payload_rate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUpload_payload_rate", "(I)V", "GetSetUpload_payload_rate_IHandler")]
			set {
				const string __id = "setUpload_payload_rate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUpload_rate;
#pragma warning disable 0169
		static Delegate GetGetUpload_rateHandler ()
		{
			if (cb_getUpload_rate == null)
				cb_getUpload_rate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUpload_rate);
			return cb_getUpload_rate;
		}

		static int n_GetUpload_rate (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Upload_rate;
		}
#pragma warning restore 0169

		static Delegate cb_setUpload_rate_I;
#pragma warning disable 0169
		static Delegate GetSetUpload_rate_IHandler ()
		{
			if (cb_setUpload_rate_I == null)
				cb_setUpload_rate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUpload_rate_I);
			return cb_setUpload_rate_I;
		}

		static void n_SetUpload_rate_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Upload_rate = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Upload_rate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getUpload_rate' and count(parameter)=0]"
			[Register ("getUpload_rate", "()I", "GetGetUpload_rateHandler")]
			get {
				const string __id = "getUpload_rate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setUpload_rate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUpload_rate", "(I)V", "GetSetUpload_rate_IHandler")]
			set {
				const string __id = "setUpload_rate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUploads_limit;
#pragma warning disable 0169
		static Delegate GetGetUploads_limitHandler ()
		{
			if (cb_getUploads_limit == null)
				cb_getUploads_limit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUploads_limit);
			return cb_getUploads_limit;
		}

		static int n_GetUploads_limit (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Uploads_limit;
		}
#pragma warning restore 0169

		static Delegate cb_setUploads_limit_I;
#pragma warning disable 0169
		static Delegate GetSetUploads_limit_IHandler ()
		{
			if (cb_setUploads_limit_I == null)
				cb_setUploads_limit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUploads_limit_I);
			return cb_setUploads_limit_I;
		}

		static void n_SetUploads_limit_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Uploads_limit = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Uploads_limit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getUploads_limit' and count(parameter)=0]"
			[Register ("getUploads_limit", "()I", "GetGetUploads_limitHandler")]
			get {
				const string __id = "getUploads_limit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setUploads_limit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUploads_limit", "(I)V", "GetSetUploads_limit_IHandler")]
			set {
				const string __id = "setUploads_limit.(I)V";
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Verified_pieces = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Piece_index_bitfield Verified_pieces {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getVerified_pieces' and count(parameter)=0]"
			[Register ("getVerified_pieces", "()Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;", "GetGetVerified_piecesHandler")]
			get {
				const string __id = "getVerified_pieces.()Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setVerified_pieces' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.piece_index_bitfield']]"
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
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_status']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/torrent_status;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Torrent_status obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/torrent_status;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getHandle;
#pragma warning disable 0169
		static Delegate GetGetHandleHandler ()
		{
			if (cb_getHandle == null)
				cb_getHandle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHandle);
			return cb_getHandle;
		}

		static IntPtr n_GetHandle (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetHandle ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='getHandle' and count(parameter)=0]"
		[Register ("getHandle", "()Lcom/frostwire/jlibtorrent/swig/torrent_handle;", "GetGetHandleHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Torrent_handle GetHandle ()
		{
			const string __id = "getHandle.()Lcom/frostwire/jlibtorrent/swig/torrent_handle;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_active_duration;
#pragma warning disable 0169
		static Delegate GetGet_active_durationHandler ()
		{
			if (cb_get_active_duration == null)
				cb_get_active_duration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Get_active_duration);
			return cb_get_active_duration;
		}

		static long n_Get_active_duration (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_active_duration ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='get_active_duration' and count(parameter)=0]"
		[Register ("get_active_duration", "()J", "GetGet_active_durationHandler")]
		public virtual unsafe long Get_active_duration ()
		{
			const string __id = "get_active_duration.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_finished_duration;
#pragma warning disable 0169
		static Delegate GetGet_finished_durationHandler ()
		{
			if (cb_get_finished_duration == null)
				cb_get_finished_duration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Get_finished_duration);
			return cb_get_finished_duration;
		}

		static long n_Get_finished_duration (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_finished_duration ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='get_finished_duration' and count(parameter)=0]"
		[Register ("get_finished_duration", "()J", "GetGet_finished_durationHandler")]
		public virtual unsafe long Get_finished_duration ()
		{
			const string __id = "get_finished_duration.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_last_download;
#pragma warning disable 0169
		static Delegate GetGet_last_downloadHandler ()
		{
			if (cb_get_last_download == null)
				cb_get_last_download = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Get_last_download);
			return cb_get_last_download;
		}

		static long n_Get_last_download (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_last_download ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='get_last_download' and count(parameter)=0]"
		[Register ("get_last_download", "()J", "GetGet_last_downloadHandler")]
		public virtual unsafe long Get_last_download ()
		{
			const string __id = "get_last_download.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_last_upload;
#pragma warning disable 0169
		static Delegate GetGet_last_uploadHandler ()
		{
			if (cb_get_last_upload == null)
				cb_get_last_upload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Get_last_upload);
			return cb_get_last_upload;
		}

		static long n_Get_last_upload (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_last_upload ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='get_last_upload' and count(parameter)=0]"
		[Register ("get_last_upload", "()J", "GetGet_last_uploadHandler")]
		public virtual unsafe long Get_last_upload ()
		{
			const string __id = "get_last_upload.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_next_announce;
#pragma warning disable 0169
		static Delegate GetGet_next_announceHandler ()
		{
			if (cb_get_next_announce == null)
				cb_get_next_announce = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Get_next_announce);
			return cb_get_next_announce;
		}

		static long n_Get_next_announce (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_next_announce ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='get_next_announce' and count(parameter)=0]"
		[Register ("get_next_announce", "()J", "GetGet_next_announceHandler")]
		public virtual unsafe long Get_next_announce ()
		{
			const string __id = "get_next_announce.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_queue_position;
#pragma warning disable 0169
		static Delegate GetGet_queue_positionHandler ()
		{
			if (cb_get_queue_position == null)
				cb_get_queue_position = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Get_queue_position);
			return cb_get_queue_position;
		}

		static int n_Get_queue_position (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_queue_position ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='get_queue_position' and count(parameter)=0]"
		[Register ("get_queue_position", "()I", "GetGet_queue_positionHandler")]
		public virtual unsafe int Get_queue_position ()
		{
			const string __id = "get_queue_position.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_seeding_duration;
#pragma warning disable 0169
		static Delegate GetGet_seeding_durationHandler ()
		{
			if (cb_get_seeding_duration == null)
				cb_get_seeding_duration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Get_seeding_duration);
			return cb_get_seeding_duration;
		}

		static long n_Get_seeding_duration (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_seeding_duration ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='get_seeding_duration' and count(parameter)=0]"
		[Register ("get_seeding_duration", "()J", "GetGet_seeding_durationHandler")]
		public virtual unsafe long Get_seeding_duration ()
		{
			const string __id = "get_seeding_duration.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_op_eq_Lcom_frostwire_jlibtorrent_swig_torrent_status_;
#pragma warning disable 0169
		static Delegate GetOp_eq_Lcom_frostwire_jlibtorrent_swig_torrent_status_Handler ()
		{
			if (cb_op_eq_Lcom_frostwire_jlibtorrent_swig_torrent_status_ == null)
				cb_op_eq_Lcom_frostwire_jlibtorrent_swig_torrent_status_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Op_eq_Lcom_frostwire_jlibtorrent_swig_torrent_status_);
			return cb_op_eq_Lcom_frostwire_jlibtorrent_swig_torrent_status_;
		}

		static bool n_Op_eq_Lcom_frostwire_jlibtorrent_swig_torrent_status_ (IntPtr jnienv, IntPtr native__this, IntPtr native_st)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Torrent_status st = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (native_st, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Op_eq (st);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='op_eq' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_status']]"
		[Register ("op_eq", "(Lcom/frostwire/jlibtorrent/swig/torrent_status;)Z", "GetOp_eq_Lcom_frostwire_jlibtorrent_swig_torrent_status_Handler")]
		public virtual unsafe bool Op_eq (global::FrostWire.Libtorrent.Swig.Torrent_status st)
		{
			const string __id = "op_eq.(Lcom/frostwire/jlibtorrent/swig/torrent_status;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((st == null) ? IntPtr.Zero : ((global::Java.Lang.Object) st).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setHandle_Lcom_frostwire_jlibtorrent_swig_torrent_handle_;
#pragma warning disable 0169
		static Delegate GetSetHandle_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Handler ()
		{
			if (cb_setHandle_Lcom_frostwire_jlibtorrent_swig_torrent_handle_ == null)
				cb_setHandle_Lcom_frostwire_jlibtorrent_swig_torrent_handle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHandle_Lcom_frostwire_jlibtorrent_swig_torrent_handle_);
			return cb_setHandle_Lcom_frostwire_jlibtorrent_swig_torrent_handle_;
		}

		static void n_SetHandle_Lcom_frostwire_jlibtorrent_swig_torrent_handle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Torrent_handle value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetHandle (value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='setHandle' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_handle']]"
		[Register ("setHandle", "(Lcom/frostwire/jlibtorrent/swig/torrent_handle;)V", "GetSetHandle_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Handler")]
		public virtual unsafe void SetHandle (global::FrostWire.Libtorrent.Swig.Torrent_handle value)
		{
			const string __id = "setHandle.(Lcom/frostwire/jlibtorrent/swig/torrent_handle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_torrent_file_ptr;
#pragma warning disable 0169
		static Delegate GetTorrent_file_ptrHandler ()
		{
			if (cb_torrent_file_ptr == null)
				cb_torrent_file_ptr = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Torrent_file_ptr);
			return cb_torrent_file_ptr;
		}

		static IntPtr n_Torrent_file_ptr (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_status __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Torrent_file_ptr ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_status']/method[@name='torrent_file_ptr' and count(parameter)=0]"
		[Register ("torrent_file_ptr", "()Lcom/frostwire/jlibtorrent/swig/torrent_info;", "GetTorrent_file_ptrHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Torrent_info Torrent_file_ptr ()
		{
			const string __id = "torrent_file_ptr.()Lcom/frostwire/jlibtorrent/swig/torrent_info;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
