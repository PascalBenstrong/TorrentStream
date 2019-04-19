using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/libtorrent", DoNotGenerateAcw=true)]
	public partial class Libtorrent : global::Java.Lang.Object {


		public static class InterfaceConsts {

			// The following are fields from: com.frostwire.jlibtorrent.swig.libtorrentConstants


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/interface[@name='libtorrentConstants']/field[@name='LIBTORRENT_REVISION']"
			[Register ("LIBTORRENT_REVISION")]
			public static string LibtorrentRevision {
				get {
					const string __id = "LIBTORRENT_REVISION.Ljava/lang/String;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/interface[@name='libtorrentConstants']/field[@name='LIBTORRENT_VERSION']"
			[Register ("LIBTORRENT_VERSION")]
			public static string LibtorrentVersion {
				get {
					const string __id = "LIBTORRENT_VERSION.Ljava/lang/String;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/interface[@name='libtorrentConstants']/field[@name='LIBTORRENT_VERSION_MAJOR']"
			[Register ("LIBTORRENT_VERSION_MAJOR")]
			public static int LibtorrentVersionMajor {
				get {
					const string __id = "LIBTORRENT_VERSION_MAJOR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/interface[@name='libtorrentConstants']/field[@name='LIBTORRENT_VERSION_MINOR']"
			[Register ("LIBTORRENT_VERSION_MINOR")]
			public static int LibtorrentVersionMinor {
				get {
					const string __id = "LIBTORRENT_VERSION_MINOR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/interface[@name='libtorrentConstants']/field[@name='LIBTORRENT_VERSION_NUM']"
			[Register ("LIBTORRENT_VERSION_NUM")]
			public static int LibtorrentVersionNum {
				get {
					const string __id = "LIBTORRENT_VERSION_NUM.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/interface[@name='libtorrentConstants']/field[@name='LIBTORRENT_VERSION_TINY']"
			[Register ("LIBTORRENT_VERSION_TINY")]
			public static int LibtorrentVersionTiny {
				get {
					const string __id = "LIBTORRENT_VERSION_TINY.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}
		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/libtorrent", typeof (Libtorrent));
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

		protected Libtorrent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/constructor[@name='libtorrent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Libtorrent ()
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

		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t All {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getAll' and count(parameter)=0]"
			[Register ("getAll", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetGetAllHandler")]
			get {
				const string __id = "getAll.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Apply_ip_filter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getApply_ip_filter' and count(parameter)=0]"
			[Register ("getApply_ip_filter", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetGetApply_ip_filterHandler")]
			get {
				const string __id = "getApply_ip_filter.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Auto_managed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getAuto_managed' and count(parameter)=0]"
			[Register ("getAuto_managed", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetGetAuto_managedHandler")]
			get {
				const string __id = "getAuto_managed.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Default_flags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getDefault_flags' and count(parameter)=0]"
			[Register ("getDefault_flags", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetGetDefault_flagsHandler")]
			get {
				const string __id = "getDefault_flags.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Duplicate_is_error {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getDuplicate_is_error' and count(parameter)=0]"
			[Register ("getDuplicate_is_error", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetGetDuplicate_is_errorHandler")]
			get {
				const string __id = "getDuplicate_is_error.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Need_save_resume {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getNeed_save_resume' and count(parameter)=0]"
			[Register ("getNeed_save_resume", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetGetNeed_save_resumeHandler")]
			get {
				const string __id = "getNeed_save_resume.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe int Num_alert_types {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getNum_alert_types' and count(parameter)=0]"
			[Register ("getNum_alert_types", "()I", "GetGetNum_alert_typesHandler")]
			get {
				const string __id = "getNum_alert_types.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Override_trackers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getOverride_trackers' and count(parameter)=0]"
			[Register ("getOverride_trackers", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetGetOverride_trackersHandler")]
			get {
				const string __id = "getOverride_trackers.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Override_web_seeds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getOverride_web_seeds' and count(parameter)=0]"
			[Register ("getOverride_web_seeds", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetGetOverride_web_seedsHandler")]
			get {
				const string __id = "getOverride_web_seeds.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Paused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getPaused' and count(parameter)=0]"
			[Register ("getPaused", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetGetPausedHandler")]
			get {
				const string __id = "getPaused.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Pex_flags_t Pex_encryption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getPex_encryption' and count(parameter)=0]"
			[Register ("getPex_encryption", "()Lcom/frostwire/jlibtorrent/swig/pex_flags_t;", "GetGetPex_encryptionHandler")]
			get {
				const string __id = "getPex_encryption.()Lcom/frostwire/jlibtorrent/swig/pex_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Pex_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Pex_flags_t Pex_holepunch {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getPex_holepunch' and count(parameter)=0]"
			[Register ("getPex_holepunch", "()Lcom/frostwire/jlibtorrent/swig/pex_flags_t;", "GetGetPex_holepunchHandler")]
			get {
				const string __id = "getPex_holepunch.()Lcom/frostwire/jlibtorrent/swig/pex_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Pex_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Pex_flags_t Pex_seed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getPex_seed' and count(parameter)=0]"
			[Register ("getPex_seed", "()Lcom/frostwire/jlibtorrent/swig/pex_flags_t;", "GetGetPex_seedHandler")]
			get {
				const string __id = "getPex_seed.()Lcom/frostwire/jlibtorrent/swig/pex_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Pex_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Pex_flags_t Pex_utp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getPex_utp' and count(parameter)=0]"
			[Register ("getPex_utp", "()Lcom/frostwire/jlibtorrent/swig/pex_flags_t;", "GetGetPex_utpHandler")]
			get {
				const string __id = "getPex_utp.()Lcom/frostwire/jlibtorrent/swig/pex_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Pex_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Seed_mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getSeed_mode' and count(parameter)=0]"
			[Register ("getSeed_mode", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetGetSeed_modeHandler")]
			get {
				const string __id = "getSeed_mode.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Sequential_download {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getSequential_download' and count(parameter)=0]"
			[Register ("getSequential_download", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetGetSequential_downloadHandler")]
			get {
				const string __id = "getSequential_download.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Share_mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getShare_mode' and count(parameter)=0]"
			[Register ("getShare_mode", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetGetShare_modeHandler")]
			get {
				const string __id = "getShare_mode.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Stop_when_ready {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getStop_when_ready' and count(parameter)=0]"
			[Register ("getStop_when_ready", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetGetStop_when_readyHandler")]
			get {
				const string __id = "getStop_when_ready.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Super_seeding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getSuper_seeding' and count(parameter)=0]"
			[Register ("getSuper_seeding", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetGetSuper_seedingHandler")]
			get {
				const string __id = "getSuper_seeding.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Update_subscribe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getUpdate_subscribe' and count(parameter)=0]"
			[Register ("getUpdate_subscribe", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetGetUpdate_subscribeHandler")]
			get {
				const string __id = "getUpdate_subscribe.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Upload_mode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='getUpload_mode' and count(parameter)=0]"
			[Register ("getUpload_mode", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetGetUpload_modeHandler")]
			get {
				const string __id = "getUpload_mode.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='add_files' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.file_storage'] and parameter[2][@type='java.lang.String']]"
		[Register ("add_files", "(Lcom/frostwire/jlibtorrent/swig/file_storage;Ljava/lang/String;)V", "")]
		public static unsafe void Add_files (global::FrostWire.Libtorrent.Swig.File_storage fs, string file)
		{
			const string __id = "add_files.(Lcom/frostwire/jlibtorrent/swig/file_storage;Ljava/lang/String;)V";
			IntPtr native_file = JNIEnv.NewString (file);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				__args [1] = new JniArgumentValue (native_file);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_file);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='add_files' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.swig.file_storage'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.create_flags_t']]"
		[Register ("add_files", "(Lcom/frostwire/jlibtorrent/swig/file_storage;Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/create_flags_t;)V", "")]
		public static unsafe void Add_files (global::FrostWire.Libtorrent.Swig.File_storage fs, string file, global::FrostWire.Libtorrent.Swig.Create_flags_t flags)
		{
			const string __id = "add_files.(Lcom/frostwire/jlibtorrent/swig/file_storage;Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/create_flags_t;)V";
			IntPtr native_file = JNIEnv.NewString (file);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				__args [1] = new JniArgumentValue (native_file);
				__args [2] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_file);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='add_files_ex' and count(parameter)=4 and parameter[1][@type='com.frostwire.jlibtorrent.swig.file_storage'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.add_files_listener'] and parameter[4][@type='com.frostwire.jlibtorrent.swig.create_flags_t']]"
		[Register ("add_files_ex", "(Lcom/frostwire/jlibtorrent/swig/file_storage;Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/add_files_listener;Lcom/frostwire/jlibtorrent/swig/create_flags_t;)V", "")]
		public static unsafe void Add_files_ex (global::FrostWire.Libtorrent.Swig.File_storage fs, string file, global::FrostWire.Libtorrent.Swig.Add_files_listener listener, global::FrostWire.Libtorrent.Swig.Create_flags_t flags)
		{
			const string __id = "add_files_ex.(Lcom/frostwire/jlibtorrent/swig/file_storage;Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/add_files_listener;Lcom/frostwire/jlibtorrent/swig/create_flags_t;)V";
			IntPtr native_file = JNIEnv.NewString (file);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				__args [1] = new JniArgumentValue (native_file);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [3] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_file);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='alert_name' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("alert_name", "(I)Ljava/lang/String;", "")]
		public static unsafe string Alert_name (int alert_type)
		{
			const string __id = "alert_name.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (alert_type);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='arm_neon_support' and count(parameter)=0]"
		[Register ("arm_neon_support", "()Z", "")]
		public static unsafe bool Arm_neon_support ()
		{
			const string __id = "arm_neon_support.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='boost_lib_version' and count(parameter)=0]"
		[Register ("boost_lib_version", "()Ljava/lang/String;", "")]
		public static unsafe string Boost_lib_version ()
		{
			const string __id = "boost_lib_version.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='boost_version' and count(parameter)=0]"
		[Register ("boost_version", "()I", "")]
		public static unsafe int Boost_version ()
		{
			const string __id = "boost_version.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='default_settings' and count(parameter)=0]"
		[Register ("default_settings", "()Lcom/frostwire/jlibtorrent/swig/settings_pack;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Settings_pack Default_settings ()
		{
			const string __id = "default_settings.()Lcom/frostwire/jlibtorrent/swig/settings_pack;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='ed25519_add_scalar_public' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("ed25519_add_scalar_public", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;)Lcom/frostwire/jlibtorrent/swig/byte_vector;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Ed25519_add_scalar_public (global::FrostWire.Libtorrent.Swig.Byte_vector pk, global::FrostWire.Libtorrent.Swig.Byte_vector scalar)
		{
			const string __id = "ed25519_add_scalar_public.(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;)Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((pk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pk).Handle);
				__args [1] = new JniArgumentValue ((scalar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scalar).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='ed25519_add_scalar_secret' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("ed25519_add_scalar_secret", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;)Lcom/frostwire/jlibtorrent/swig/byte_vector;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Ed25519_add_scalar_secret (global::FrostWire.Libtorrent.Swig.Byte_vector sk, global::FrostWire.Libtorrent.Swig.Byte_vector scalar)
		{
			const string __id = "ed25519_add_scalar_secret.(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;)Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((sk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sk).Handle);
				__args [1] = new JniArgumentValue ((scalar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scalar).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='ed25519_create_keypair' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("ed25519_create_keypair", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)Lcom/frostwire/jlibtorrent/swig/byte_vectors_pair;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Byte_vectors_pair Ed25519_create_keypair (global::FrostWire.Libtorrent.Swig.Byte_vector seed)
		{
			const string __id = "ed25519_create_keypair.(Lcom/frostwire/jlibtorrent/swig/byte_vector;)Lcom/frostwire/jlibtorrent/swig/byte_vectors_pair;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((seed == null) ? IntPtr.Zero : ((global::Java.Lang.Object) seed).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vectors_pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='ed25519_create_seed' and count(parameter)=0]"
		[Register ("ed25519_create_seed", "()Lcom/frostwire/jlibtorrent/swig/byte_vector;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Ed25519_create_seed ()
		{
			const string __id = "ed25519_create_seed.()Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='ed25519_key_exchange' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("ed25519_key_exchange", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;)Lcom/frostwire/jlibtorrent/swig/byte_vector;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Ed25519_key_exchange (global::FrostWire.Libtorrent.Swig.Byte_vector pk, global::FrostWire.Libtorrent.Swig.Byte_vector sk)
		{
			const string __id = "ed25519_key_exchange.(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;)Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((pk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pk).Handle);
				__args [1] = new JniArgumentValue ((sk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sk).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='ed25519_sign' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.byte_vector'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("ed25519_sign", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;)Lcom/frostwire/jlibtorrent/swig/byte_vector;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Ed25519_sign (global::FrostWire.Libtorrent.Swig.Byte_vector msg, global::FrostWire.Libtorrent.Swig.Byte_vector pk, global::FrostWire.Libtorrent.Swig.Byte_vector sk)
		{
			const string __id = "ed25519_sign.(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;)Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				__args [1] = new JniArgumentValue ((pk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pk).Handle);
				__args [2] = new JniArgumentValue ((sk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sk).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='ed25519_verify' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.byte_vector'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("ed25519_verify", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;)Z", "")]
		public static unsafe bool Ed25519_verify (global::FrostWire.Libtorrent.Swig.Byte_vector sig, global::FrostWire.Libtorrent.Swig.Byte_vector msg, global::FrostWire.Libtorrent.Swig.Byte_vector pk)
		{
			const string __id = "ed25519_verify.(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((sig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sig).Handle);
				__args [1] = new JniArgumentValue ((msg == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msg).Handle);
				__args [2] = new JniArgumentValue ((pk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pk).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='enum_net_interfaces' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.session']]"
		[Register ("enum_net_interfaces", "(Lcom/frostwire/jlibtorrent/swig/session;)Lcom/frostwire/jlibtorrent/swig/ip_interface_vector;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Ip_interface_vector Enum_net_interfaces (global::FrostWire.Libtorrent.Swig.Session s)
		{
			const string __id = "enum_net_interfaces.(Lcom/frostwire/jlibtorrent/swig/session;)Lcom/frostwire/jlibtorrent/swig/ip_interface_vector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_interface_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='enum_routes' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.session']]"
		[Register ("enum_routes", "(Lcom/frostwire/jlibtorrent/swig/session;)Lcom/frostwire/jlibtorrent/swig/ip_route_vector;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Ip_route_vector Enum_routes (global::FrostWire.Libtorrent.Swig.Session s)
		{
			const string __id = "enum_routes.(Lcom/frostwire/jlibtorrent/swig/session;)Lcom/frostwire/jlibtorrent/swig/ip_route_vector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Ip_route_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='find_metric_idx_s' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("find_metric_idx_s", "(Ljava/lang/String;)I", "")]
		public static unsafe int Find_metric_idx_s (string name)
		{
			const string __id = "find_metric_idx_s.(Ljava/lang/String;)I";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='generate_fingerprint' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("generate_fingerprint", "(Ljava/lang/String;IIII)Ljava/lang/String;", "")]
		public static unsafe string Generate_fingerprint (string name, int major, int minor, int revision, int tag)
		{
			const string __id = "generate_fingerprint.(Ljava/lang/String;IIII)Ljava/lang/String;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (major);
				__args [2] = new JniArgumentValue (minor);
				__args [3] = new JniArgumentValue (revision);
				__args [4] = new JniArgumentValue (tag);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='get_default_gateway' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.swig.session'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.byte_vector'] and parameter[3][@type='boolean']]"
		[Register ("get_default_gateway", "(Lcom/frostwire/jlibtorrent/swig/session;Lcom/frostwire/jlibtorrent/swig/byte_vector;Z)Lcom/frostwire/jlibtorrent/swig/address;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Address Get_default_gateway (global::FrostWire.Libtorrent.Swig.Session s, global::FrostWire.Libtorrent.Swig.Byte_vector device, bool v6)
		{
			const string __id = "get_default_gateway.(Lcom/frostwire/jlibtorrent/swig/session;Lcom/frostwire/jlibtorrent/swig/byte_vector;Z)Lcom/frostwire/jlibtorrent/swig/address;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				__args [1] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				__args [2] = new JniArgumentValue (v6);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='high_performance_seed' and count(parameter)=0]"
		[Register ("high_performance_seed", "()Lcom/frostwire/jlibtorrent/swig/settings_pack;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Settings_pack High_performance_seed ()
		{
			const string __id = "high_performance_seed.()Lcom/frostwire/jlibtorrent/swig/settings_pack;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='make_error_code' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.errc_t']]"
		[Register ("make_error_code", "(Lcom/frostwire/jlibtorrent/swig/errc_t;)Lcom/frostwire/jlibtorrent/swig/error_code;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Error_code Make_error_code (global::FrostWire.Libtorrent.Swig.Errc_t e)
		{
			const string __id = "make_error_code.(Lcom/frostwire/jlibtorrent/swig/errc_t;)Lcom/frostwire/jlibtorrent/swig/error_code;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Error_code> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='make_magnet_uri' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_handle']]"
		[Register ("make_magnet_uri", "(Lcom/frostwire/jlibtorrent/swig/torrent_handle;)Ljava/lang/String;", "")]
		public static unsafe string Make_magnet_uri (global::FrostWire.Libtorrent.Swig.Torrent_handle handle)
		{
			const string __id = "make_magnet_uri.(Lcom/frostwire/jlibtorrent/swig/torrent_handle;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((handle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handle).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='make_magnet_uri' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_info']]"
		[Register ("make_magnet_uri", "(Lcom/frostwire/jlibtorrent/swig/torrent_info;)Ljava/lang/String;", "")]
		public static unsafe string Make_magnet_uri (global::FrostWire.Libtorrent.Swig.Torrent_info info)
		{
			const string __id = "make_magnet_uri.(Lcom/frostwire/jlibtorrent/swig/torrent_info;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) info).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='min_memory_usage' and count(parameter)=0]"
		[Register ("min_memory_usage", "()Lcom/frostwire/jlibtorrent/swig/settings_pack;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Settings_pack Min_memory_usage ()
		{
			const string __id = "min_memory_usage.()Lcom/frostwire/jlibtorrent/swig/settings_pack;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='name_for_setting' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("name_for_setting", "(I)Ljava/lang/String;", "")]
		public static unsafe string Name_for_setting (int s)
		{
			const string __id = "name_for_setting.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='op_eq' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.error_code'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.error_code']]"
		[Register ("op_eq", "(Lcom/frostwire/jlibtorrent/swig/error_code;Lcom/frostwire/jlibtorrent/swig/error_code;)Z", "")]
		public static unsafe bool Op_eq (global::FrostWire.Libtorrent.Swig.Error_code lhs, global::FrostWire.Libtorrent.Swig.Error_code rhs)
		{
			const string __id = "op_eq.(Lcom/frostwire/jlibtorrent/swig/error_code;Lcom/frostwire/jlibtorrent/swig/error_code;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((lhs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lhs).Handle);
				__args [1] = new JniArgumentValue ((rhs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rhs).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='op_eq' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_class_type_filter'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.peer_class_type_filter']]"
		[Register ("op_eq", "(Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter;Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter;)Z", "")]
		public static unsafe bool Op_eq (global::FrostWire.Libtorrent.Swig.Peer_class_type_filter lhs, global::FrostWire.Libtorrent.Swig.Peer_class_type_filter rhs)
		{
			const string __id = "op_eq.(Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter;Lcom/frostwire/jlibtorrent/swig/peer_class_type_filter;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((lhs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lhs).Handle);
				__args [1] = new JniArgumentValue ((rhs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rhs).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='op_lt' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.error_code'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.error_code']]"
		[Register ("op_lt", "(Lcom/frostwire/jlibtorrent/swig/error_code;Lcom/frostwire/jlibtorrent/swig/error_code;)Z", "")]
		public static unsafe bool Op_lt (global::FrostWire.Libtorrent.Swig.Error_code lhs, global::FrostWire.Libtorrent.Swig.Error_code rhs)
		{
			const string __id = "op_lt.(Lcom/frostwire/jlibtorrent/swig/error_code;Lcom/frostwire/jlibtorrent/swig/error_code;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((lhs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lhs).Handle);
				__args [1] = new JniArgumentValue ((rhs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rhs).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='op_lte' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.address'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.address']]"
		[Register ("op_lte", "(Lcom/frostwire/jlibtorrent/swig/address;Lcom/frostwire/jlibtorrent/swig/address;)Z", "")]
		public static unsafe bool Op_lte (global::FrostWire.Libtorrent.Swig.Address lhs, global::FrostWire.Libtorrent.Swig.Address rhs)
		{
			const string __id = "op_lte.(Lcom/frostwire/jlibtorrent/swig/address;Lcom/frostwire/jlibtorrent/swig/address;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((lhs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lhs).Handle);
				__args [1] = new JniArgumentValue ((rhs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rhs).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='op_ne' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.error_code'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.error_code']]"
		[Register ("op_ne", "(Lcom/frostwire/jlibtorrent/swig/error_code;Lcom/frostwire/jlibtorrent/swig/error_code;)Z", "")]
		public static unsafe bool Op_ne (global::FrostWire.Libtorrent.Swig.Error_code lhs, global::FrostWire.Libtorrent.Swig.Error_code rhs)
		{
			const string __id = "op_ne.(Lcom/frostwire/jlibtorrent/swig/error_code;Lcom/frostwire/jlibtorrent/swig/error_code;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((lhs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lhs).Handle);
				__args [1] = new JniArgumentValue ((rhs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rhs).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='openssl_version_number' and count(parameter)=0]"
		[Register ("openssl_version_number", "()I", "")]
		public static unsafe int Openssl_version_number ()
		{
			const string __id = "openssl_version_number.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='openssl_version_text' and count(parameter)=0]"
		[Register ("openssl_version_text", "()Ljava/lang/String;", "")]
		public static unsafe string Openssl_version_text ()
		{
			const string __id = "openssl_version_text.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='operation_name' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.operation_t']]"
		[Register ("operation_name", "(Lcom/frostwire/jlibtorrent/swig/operation_t;)Ljava/lang/String;", "")]
		public static unsafe string Operation_name (global::FrostWire.Libtorrent.Swig.Operation_t op)
		{
			const string __id = "operation_name.(Lcom/frostwire/jlibtorrent/swig/operation_t;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='read_session_params' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.bdecode_node']]"
		[Register ("read_session_params", "(Lcom/frostwire/jlibtorrent/swig/bdecode_node;)Lcom/frostwire/jlibtorrent/swig/session_params;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Session_params Read_session_params (global::FrostWire.Libtorrent.Swig.Bdecode_node e)
		{
			const string __id = "read_session_params.(Lcom/frostwire/jlibtorrent/swig/bdecode_node;)Lcom/frostwire/jlibtorrent/swig/session_params;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_params> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='read_session_params' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.bdecode_node'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.save_state_flags_t']]"
		[Register ("read_session_params", "(Lcom/frostwire/jlibtorrent/swig/bdecode_node;Lcom/frostwire/jlibtorrent/swig/save_state_flags_t;)Lcom/frostwire/jlibtorrent/swig/session_params;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Session_params Read_session_params (global::FrostWire.Libtorrent.Swig.Bdecode_node e, global::FrostWire.Libtorrent.Swig.Save_state_flags_t flags)
		{
			const string __id = "read_session_params.(Lcom/frostwire/jlibtorrent/swig/bdecode_node;Lcom/frostwire/jlibtorrent/swig/save_state_flags_t;)Lcom/frostwire/jlibtorrent/swig/session_params;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_params> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='session_stats_metrics' and count(parameter)=0]"
		[Register ("session_stats_metrics", "()Lcom/frostwire/jlibtorrent/swig/stats_metric_vector;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Stats_metric_vector Session_stats_metrics ()
		{
			const string __id = "session_stats_metrics.()Lcom/frostwire/jlibtorrent/swig/stats_metric_vector;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Stats_metric_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='set_piece_hashes' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.swig.create_torrent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.error_code']]"
		[Register ("set_piece_hashes", "(Lcom/frostwire/jlibtorrent/swig/create_torrent;Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/error_code;)V", "")]
		public static unsafe void Set_piece_hashes (global::FrostWire.Libtorrent.Swig.Create_torrent t, string p, global::FrostWire.Libtorrent.Swig.Error_code ec)
		{
			const string __id = "set_piece_hashes.(Lcom/frostwire/jlibtorrent/swig/create_torrent;Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/error_code;)V";
			IntPtr native_p = JNIEnv.NewString (p);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Object) t).Handle);
				__args [1] = new JniArgumentValue (native_p);
				__args [2] = new JniArgumentValue ((ec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ec).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='set_piece_hashes_ex' and count(parameter)=4 and parameter[1][@type='com.frostwire.jlibtorrent.swig.create_torrent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.set_piece_hashes_listener'] and parameter[4][@type='com.frostwire.jlibtorrent.swig.error_code']]"
		[Register ("set_piece_hashes_ex", "(Lcom/frostwire/jlibtorrent/swig/create_torrent;Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/set_piece_hashes_listener;Lcom/frostwire/jlibtorrent/swig/error_code;)V", "")]
		public static unsafe void Set_piece_hashes_ex (global::FrostWire.Libtorrent.Swig.Create_torrent t, string p, global::FrostWire.Libtorrent.Swig.Set_piece_hashes_listener listener, global::FrostWire.Libtorrent.Swig.Error_code ec)
		{
			const string __id = "set_piece_hashes_ex.(Lcom/frostwire/jlibtorrent/swig/create_torrent;Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/set_piece_hashes_listener;Lcom/frostwire/jlibtorrent/swig/error_code;)V";
			IntPtr native_p = JNIEnv.NewString (p);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Object) t).Handle);
				__args [1] = new JniArgumentValue (native_p);
				__args [2] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [3] = new JniArgumentValue ((ec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ec).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='set_posix_wrapper' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.posix_wrapper']]"
		[Register ("set_posix_wrapper", "(Lcom/frostwire/jlibtorrent/swig/posix_wrapper;)V", "")]
		public static unsafe void Set_posix_wrapper (global::FrostWire.Libtorrent.Swig.Posix_wrapper obj)
		{
			const string __id = "set_posix_wrapper.(Lcom/frostwire/jlibtorrent/swig/posix_wrapper;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='setting_by_name' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setting_by_name", "(Ljava/lang/String;)I", "")]
		public static unsafe int Setting_by_name (string name)
		{
			const string __id = "setting_by_name.(Ljava/lang/String;)I";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='libtorrent']/method[@name='version' and count(parameter)=0]"
		[Register ("version", "()Ljava/lang/String;", "")]
		public static unsafe string Version ()
		{
			const string __id = "version.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
