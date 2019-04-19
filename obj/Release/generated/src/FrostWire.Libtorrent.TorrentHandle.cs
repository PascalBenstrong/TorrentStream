using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/TorrentHandle", DoNotGenerateAcw=true)]
	public sealed partial class TorrentHandle : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/field[@name='ALERT_WHEN_AVAILABLE']"
		[Register ("ALERT_WHEN_AVAILABLE")]
		public static global::FrostWire.Libtorrent.Swig.Deadline_flags_t AlertWhenAvailable {
			get {
				const string __id = "ALERT_WHEN_AVAILABLE.Lcom/frostwire/jlibtorrent/swig/deadline_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Deadline_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/field[@name='FLUSH_DISK_CACHE']"
		[Register ("FLUSH_DISK_CACHE")]
		public static global::FrostWire.Libtorrent.Swig.Resume_data_flags_t FlushDiskCache {
			get {
				const string __id = "FLUSH_DISK_CACHE.Lcom/frostwire/jlibtorrent/swig/resume_data_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Resume_data_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/field[@name='IGNORE_MIN_INTERVAL']"
		[Register ("IGNORE_MIN_INTERVAL")]
		public static global::FrostWire.Libtorrent.Swig.Reannounce_flags_t IgnoreMinInterval {
			get {
				const string __id = "IGNORE_MIN_INTERVAL.Lcom/frostwire/jlibtorrent/swig/reannounce_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Reannounce_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/field[@name='ONLY_IF_MODIFIED']"
		[Register ("ONLY_IF_MODIFIED")]
		public static global::FrostWire.Libtorrent.Swig.Resume_data_flags_t OnlyIfModified {
			get {
				const string __id = "ONLY_IF_MODIFIED.Lcom/frostwire/jlibtorrent/swig/resume_data_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Resume_data_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/field[@name='OVERWRITE_EXISTING']"
		[Register ("OVERWRITE_EXISTING")]
		public static global::FrostWire.Libtorrent.Swig.Add_piece_flags_t OverwriteExisting {
			get {
				const string __id = "OVERWRITE_EXISTING.Lcom/frostwire/jlibtorrent/swig/add_piece_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_piece_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/field[@name='QUERY_ACCURATE_DOWNLOAD_COUNTERS']"
		[Register ("QUERY_ACCURATE_DOWNLOAD_COUNTERS")]
		public static global::FrostWire.Libtorrent.Swig.Status_flags_t QueryAccurateDownloadCounters {
			get {
				const string __id = "QUERY_ACCURATE_DOWNLOAD_COUNTERS.Lcom/frostwire/jlibtorrent/swig/status_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/field[@name='QUERY_DISTRIBUTED_COPIES']"
		[Register ("QUERY_DISTRIBUTED_COPIES")]
		public static global::FrostWire.Libtorrent.Swig.Status_flags_t QueryDistributedCopies {
			get {
				const string __id = "QUERY_DISTRIBUTED_COPIES.Lcom/frostwire/jlibtorrent/swig/status_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/field[@name='QUERY_LAST_SEEN_COMPLETE']"
		[Register ("QUERY_LAST_SEEN_COMPLETE")]
		public static global::FrostWire.Libtorrent.Swig.Status_flags_t QueryLastSeenComplete {
			get {
				const string __id = "QUERY_LAST_SEEN_COMPLETE.Lcom/frostwire/jlibtorrent/swig/status_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/field[@name='QUERY_NAME']"
		[Register ("QUERY_NAME")]
		public static global::FrostWire.Libtorrent.Swig.Status_flags_t QueryName {
			get {
				const string __id = "QUERY_NAME.Lcom/frostwire/jlibtorrent/swig/status_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/field[@name='QUERY_PIECES']"
		[Register ("QUERY_PIECES")]
		public static global::FrostWire.Libtorrent.Swig.Status_flags_t QueryPieces {
			get {
				const string __id = "QUERY_PIECES.Lcom/frostwire/jlibtorrent/swig/status_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/field[@name='QUERY_SAVE_PATH']"
		[Register ("QUERY_SAVE_PATH")]
		public static global::FrostWire.Libtorrent.Swig.Status_flags_t QuerySavePath {
			get {
				const string __id = "QUERY_SAVE_PATH.Lcom/frostwire/jlibtorrent/swig/status_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/field[@name='QUERY_TORRENT_FILE']"
		[Register ("QUERY_TORRENT_FILE")]
		public static global::FrostWire.Libtorrent.Swig.Status_flags_t QueryTorrentFile {
			get {
				const string __id = "QUERY_TORRENT_FILE.Lcom/frostwire/jlibtorrent/swig/status_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/field[@name='QUERY_VERIFIED_PIECES']"
		[Register ("QUERY_VERIFIED_PIECES")]
		public static global::FrostWire.Libtorrent.Swig.Status_flags_t QueryVerifiedPieces {
			get {
				const string __id = "QUERY_VERIFIED_PIECES.Lcom/frostwire/jlibtorrent/swig/status_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/field[@name='SAVE_INFO_DICT']"
		[Register ("SAVE_INFO_DICT")]
		public static global::FrostWire.Libtorrent.Swig.Resume_data_flags_t SaveInfoDict {
			get {
				const string __id = "SAVE_INFO_DICT.Lcom/frostwire/jlibtorrent/swig/resume_data_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Resume_data_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle.FileProgressFlags']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/TorrentHandle$FileProgressFlags", DoNotGenerateAcw=true)]
		public sealed partial class FileProgressFlags : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle.FileProgressFlags']/field[@name='PIECE_GRANULARITY']"
			[Register ("PIECE_GRANULARITY")]
			public static global::FrostWire.Libtorrent.TorrentHandle.FileProgressFlags PieceGranularity {
				get {
					const string __id = "PIECE_GRANULARITY.Lcom/frostwire/jlibtorrent/TorrentHandle$FileProgressFlags;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentHandle.FileProgressFlags> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/TorrentHandle$FileProgressFlags", typeof (FileProgressFlags));
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

			internal FileProgressFlags (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle.FileProgressFlags']/method[@name='swig' and count(parameter)=0]"
			[Register ("swig", "()I", "")]
			public unsafe int Swig ()
			{
				const string __id = "swig.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle.FileProgressFlags']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/TorrentHandle$FileProgressFlags;", "")]
			public static unsafe global::FrostWire.Libtorrent.TorrentHandle.FileProgressFlags ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/TorrentHandle$FileProgressFlags;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentHandle.FileProgressFlags> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle.FileProgressFlags']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/frostwire/jlibtorrent/TorrentHandle$FileProgressFlags;", "")]
			public static unsafe global::FrostWire.Libtorrent.TorrentHandle.FileProgressFlags[] Values ()
			{
				const string __id = "values.()[Lcom/frostwire/jlibtorrent/TorrentHandle$FileProgressFlags;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::FrostWire.Libtorrent.TorrentHandle.FileProgressFlags[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.TorrentHandle.FileProgressFlags));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/TorrentHandle", typeof (TorrentHandle));
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

		internal TorrentHandle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/constructor[@name='TorrentHandle' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_handle']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/torrent_handle;)V", "")]
		public unsafe TorrentHandle (global::FrostWire.Libtorrent.Swig.Torrent_handle th)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/torrent_handle;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((th == null) ? IntPtr.Zero : ((global::Java.Lang.Object) th).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe int DownloadLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='getDownloadLimit' and count(parameter)=0]"
			[Register ("getDownloadLimit", "()I", "GetGetDownloadLimitHandler")]
			get {
				const string __id = "getDownloadLimit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='setDownloadLimit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDownloadLimit", "(I)V", "GetSetDownloadLimit_IHandler")]
			set {
				const string __id = "setDownloadLimit.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.PartialPieceInfo> DownloadQueue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='getDownloadQueue' and count(parameter)=0]"
			[Register ("getDownloadQueue", "()Ljava/util/ArrayList;", "GetGetDownloadQueueHandler")]
			get {
				const string __id = "getDownloadQueue.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.PartialPieceInfo>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				const string __id = "isValid.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int UploadLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='getUploadLimit' and count(parameter)=0]"
			[Register ("getUploadLimit", "()I", "GetGetUploadLimitHandler")]
			get {
				const string __id = "getUploadLimit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='setUploadLimit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUploadLimit", "(I)V", "GetSetUploadLimit_IHandler")]
			set {
				const string __id = "setUploadLimit.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='addHttpSeed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addHttpSeed", "(Ljava/lang/String;)V", "")]
		public unsafe void AddHttpSeed (string url)
		{
			const string __id = "addHttpSeed.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='addPiece' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("addPiece", "(I[B)V", "")]
		public unsafe void AddPiece (int piece, byte[] data)
		{
			const string __id = "addPiece.(I[B)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (piece);
				__args [1] = new JniArgumentValue (native_data);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='addPiece' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.add_piece_flags_t']]"
		[Register ("addPiece", "(I[BLcom/frostwire/jlibtorrent/swig/add_piece_flags_t;)V", "")]
		public unsafe void AddPiece (int piece, byte[] data, global::FrostWire.Libtorrent.Swig.Add_piece_flags_t flags)
		{
			const string __id = "addPiece.(I[BLcom/frostwire/jlibtorrent/swig/add_piece_flags_t;)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (piece);
				__args [1] = new JniArgumentValue (native_data);
				__args [2] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='addTracker' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.AnnounceEntry']]"
		[Register ("addTracker", "(Lcom/frostwire/jlibtorrent/AnnounceEntry;)V", "")]
		public unsafe void AddTracker (global::FrostWire.Libtorrent.AnnounceEntry tracker)
		{
			const string __id = "addTracker.(Lcom/frostwire/jlibtorrent/AnnounceEntry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tracker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tracker).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='addUrlSeed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addUrlSeed", "(Ljava/lang/String;)V", "")]
		public unsafe void AddUrlSeed (string url)
		{
			const string __id = "addUrlSeed.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='clearPieceDeadlines' and count(parameter)=0]"
		[Register ("clearPieceDeadlines", "()V", "")]
		public unsafe void ClearPieceDeadlines ()
		{
			const string __id = "clearPieceDeadlines.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='filePriorities' and count(parameter)=0]"
		[Register ("filePriorities", "()[Lcom/frostwire/jlibtorrent/Priority;", "")]
		public unsafe global::FrostWire.Libtorrent.Priority[] FilePriorities ()
		{
			const string __id = "filePriorities.()[Lcom/frostwire/jlibtorrent/Priority;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (global::FrostWire.Libtorrent.Priority[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.Priority));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='filePriority' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("filePriority", "(I)Lcom/frostwire/jlibtorrent/Priority;", "")]
		public unsafe global::FrostWire.Libtorrent.Priority FilePriority (int index)
		{
			const string __id = "filePriority.(I)Lcom/frostwire/jlibtorrent/Priority;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Priority> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='filePriority' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.frostwire.jlibtorrent.Priority']]"
		[Register ("filePriority", "(ILcom/frostwire/jlibtorrent/Priority;)V", "")]
		public unsafe void FilePriority (int index, global::FrostWire.Libtorrent.Priority priority)
		{
			const string __id = "filePriority.(ILcom/frostwire/jlibtorrent/Priority;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((priority == null) ? IntPtr.Zero : ((global::Java.Lang.Object) priority).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='fileProgress' and count(parameter)=0]"
		[Register ("fileProgress", "()[J", "")]
		public unsafe long[] FileProgress ()
		{
			const string __id = "fileProgress.()[J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (long[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (long));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='fileProgress' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.TorrentHandle.FileProgressFlags']]"
		[Register ("fileProgress", "(Lcom/frostwire/jlibtorrent/TorrentHandle$FileProgressFlags;)[J", "")]
		public unsafe long[] FileProgress (global::FrostWire.Libtorrent.TorrentHandle.FileProgressFlags flags)
		{
			const string __id = "fileProgress.(Lcom/frostwire/jlibtorrent/TorrentHandle$FileProgressFlags;)[J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (long[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (long));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='flags' and count(parameter)=0]"
		[Register ("flags", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Flags ()
		{
			const string __id = "flags.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='flushCache' and count(parameter)=0]"
		[Register ("flushCache", "()V", "")]
		public unsafe void FlushCache ()
		{
			const string __id = "flushCache.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='forceDHTAnnounce' and count(parameter)=0]"
		[Register ("forceDHTAnnounce", "()V", "")]
		public unsafe void ForceDHTAnnounce ()
		{
			const string __id = "forceDHTAnnounce.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='forceReannounce' and count(parameter)=0]"
		[Register ("forceReannounce", "()V", "")]
		public unsafe void ForceReannounce ()
		{
			const string __id = "forceReannounce.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='forceReannounce' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("forceReannounce", "(I)V", "")]
		public unsafe void ForceReannounce (int seconds)
		{
			const string __id = "forceReannounce.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (seconds);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='forceReannounce' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("forceReannounce", "(II)V", "")]
		public unsafe void ForceReannounce (int seconds, int tracker_index)
		{
			const string __id = "forceReannounce.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (seconds);
				__args [1] = new JniArgumentValue (tracker_index);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='forceReannounce' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.reannounce_flags_t']]"
		[Register ("forceReannounce", "(IILcom/frostwire/jlibtorrent/swig/reannounce_flags_t;)V", "")]
		public unsafe void ForceReannounce (int seconds, int tracker_index, global::FrostWire.Libtorrent.Swig.Reannounce_flags_t flags)
		{
			const string __id = "forceReannounce.(IILcom/frostwire/jlibtorrent/swig/reannounce_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (seconds);
				__args [1] = new JniArgumentValue (tracker_index);
				__args [2] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='forceRecheck' and count(parameter)=0]"
		[Register ("forceRecheck", "()V", "")]
		public unsafe void ForceRecheck ()
		{
			const string __id = "forceRecheck.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='havePiece' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("havePiece", "(I)Z", "")]
		public unsafe bool HavePiece (int piece)
		{
			const string __id = "havePiece.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (piece);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='httpSeeds' and count(parameter)=0]"
		[Register ("httpSeeds", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> HttpSeeds ()
		{
			const string __id = "httpSeeds.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='infoHash' and count(parameter)=0]"
		[Register ("infoHash", "()Lcom/frostwire/jlibtorrent/Sha1Hash;", "")]
		public unsafe global::FrostWire.Libtorrent.Sha1Hash InfoHash ()
		{
			const string __id = "infoHash.()Lcom/frostwire/jlibtorrent/Sha1Hash;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='makeMagnetUri' and count(parameter)=0]"
		[Register ("makeMagnetUri", "()Ljava/lang/String;", "")]
		public unsafe string MakeMagnetUri ()
		{
			const string __id = "makeMagnetUri.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='moveStorage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("moveStorage", "(Ljava/lang/String;)V", "")]
		public unsafe void MoveStorage (string savePath)
		{
			const string __id = "moveStorage.(Ljava/lang/String;)V";
			IntPtr native_savePath = JNIEnv.NewString (savePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_savePath);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_savePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='moveStorage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.frostwire.jlibtorrent.MoveFlags']]"
		[Register ("moveStorage", "(Ljava/lang/String;Lcom/frostwire/jlibtorrent/MoveFlags;)V", "")]
		public unsafe void MoveStorage (string savePath, global::FrostWire.Libtorrent.MoveFlags flags)
		{
			const string __id = "moveStorage.(Ljava/lang/String;Lcom/frostwire/jlibtorrent/MoveFlags;)V";
			IntPtr native_savePath = JNIEnv.NewString (savePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_savePath);
				__args [1] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_savePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='name' and count(parameter)=0]"
		[Register ("name", "()Ljava/lang/String;", "")]
		public unsafe string Name ()
		{
			const string __id = "name.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='needSaveResumeData' and count(parameter)=0]"
		[Register ("needSaveResumeData", "()Z", "")]
		public unsafe bool NeedSaveResumeData ()
		{
			const string __id = "needSaveResumeData.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "")]
		public unsafe void Pause ()
		{
			const string __id = "pause.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='peerInfo' and count(parameter)=0]"
		[Register ("peerInfo", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.PeerInfo> PeerInfo ()
		{
			const string __id = "peerInfo.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.PeerInfo>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='pieceAvailability' and count(parameter)=0]"
		[Register ("pieceAvailability", "()[I", "")]
		public unsafe int[] PieceAvailability ()
		{
			const string __id = "pieceAvailability.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='piecePriorities' and count(parameter)=0]"
		[Register ("piecePriorities", "()[Lcom/frostwire/jlibtorrent/Priority;", "")]
		public unsafe global::FrostWire.Libtorrent.Priority[] PiecePriorities ()
		{
			const string __id = "piecePriorities.()[Lcom/frostwire/jlibtorrent/Priority;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (global::FrostWire.Libtorrent.Priority[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.Priority));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='piecePriority' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("piecePriority", "(I)Lcom/frostwire/jlibtorrent/Priority;", "")]
		public unsafe global::FrostWire.Libtorrent.Priority PiecePriority (int index)
		{
			const string __id = "piecePriority.(I)Lcom/frostwire/jlibtorrent/Priority;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Priority> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='piecePriority' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.frostwire.jlibtorrent.Priority']]"
		[Register ("piecePriority", "(ILcom/frostwire/jlibtorrent/Priority;)V", "")]
		public unsafe void PiecePriority (int index, global::FrostWire.Libtorrent.Priority priority)
		{
			const string __id = "piecePriority.(ILcom/frostwire/jlibtorrent/Priority;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((priority == null) ? IntPtr.Zero : ((global::Java.Lang.Object) priority).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='prioritizeFiles' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Priority[]']]"
		[Register ("prioritizeFiles", "([Lcom/frostwire/jlibtorrent/Priority;)V", "")]
		public unsafe void PrioritizeFiles (global::FrostWire.Libtorrent.Priority[] priorities)
		{
			const string __id = "prioritizeFiles.([Lcom/frostwire/jlibtorrent/Priority;)V";
			IntPtr native_priorities = JNIEnv.NewArray (priorities);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_priorities);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (priorities != null) {
					JNIEnv.CopyArray (native_priorities, priorities);
					JNIEnv.DeleteLocalRef (native_priorities);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='prioritizePieces' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Priority[]']]"
		[Register ("prioritizePieces", "([Lcom/frostwire/jlibtorrent/Priority;)V", "")]
		public unsafe void PrioritizePieces (global::FrostWire.Libtorrent.Priority[] priorities)
		{
			const string __id = "prioritizePieces.([Lcom/frostwire/jlibtorrent/Priority;)V";
			IntPtr native_priorities = JNIEnv.NewArray (priorities);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_priorities);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (priorities != null) {
					JNIEnv.CopyArray (native_priorities, priorities);
					JNIEnv.DeleteLocalRef (native_priorities);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='queuePosition' and count(parameter)=0]"
		[Register ("queuePosition", "()I", "")]
		public unsafe int QueuePosition ()
		{
			const string __id = "queuePosition.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='queuePositionBottom' and count(parameter)=0]"
		[Register ("queuePositionBottom", "()V", "")]
		public unsafe void QueuePositionBottom ()
		{
			const string __id = "queuePositionBottom.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='queuePositionDown' and count(parameter)=0]"
		[Register ("queuePositionDown", "()V", "")]
		public unsafe void QueuePositionDown ()
		{
			const string __id = "queuePositionDown.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='queuePositionSet' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("queuePositionSet", "(I)V", "")]
		public unsafe void QueuePositionSet (int position)
		{
			const string __id = "queuePositionSet.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (position);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='queuePositionTop' and count(parameter)=0]"
		[Register ("queuePositionTop", "()V", "")]
		public unsafe void QueuePositionTop ()
		{
			const string __id = "queuePositionTop.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='queuePositionUp' and count(parameter)=0]"
		[Register ("queuePositionUp", "()V", "")]
		public unsafe void QueuePositionUp ()
		{
			const string __id = "queuePositionUp.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='readPiece' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("readPiece", "(I)V", "")]
		public unsafe void ReadPiece (int piece)
		{
			const string __id = "readPiece.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (piece);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='removeHttpSeed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeHttpSeed", "(Ljava/lang/String;)V", "")]
		public unsafe void RemoveHttpSeed (string url)
		{
			const string __id = "removeHttpSeed.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='removeUrlSeed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeUrlSeed", "(Ljava/lang/String;)V", "")]
		public unsafe void RemoveUrlSeed (string url)
		{
			const string __id = "removeUrlSeed.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='renameFile' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("renameFile", "(ILjava/lang/String;)V", "")]
		public unsafe void RenameFile (int index, string newName)
		{
			const string __id = "renameFile.(ILjava/lang/String;)V";
			IntPtr native_newName = JNIEnv.NewString (newName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (native_newName);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_newName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='replaceTrackers' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.frostwire.jlibtorrent.AnnounceEntry&gt;']]"
		[Register ("replaceTrackers", "(Ljava/util/List;)V", "")]
		public unsafe void ReplaceTrackers (global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.AnnounceEntry> trackers)
		{
			const string __id = "replaceTrackers.(Ljava/util/List;)V";
			IntPtr native_trackers = global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.AnnounceEntry>.ToLocalJniHandle (trackers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_trackers);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_trackers);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='resetPieceDeadline' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("resetPieceDeadline", "(I)V", "")]
		public unsafe void ResetPieceDeadline (int index)
		{
			const string __id = "resetPieceDeadline.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "")]
		public unsafe void Resume ()
		{
			const string __id = "resume.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='savePath' and count(parameter)=0]"
		[Register ("savePath", "()Ljava/lang/String;", "")]
		public unsafe string SavePath ()
		{
			const string __id = "savePath.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='saveResumeData' and count(parameter)=0]"
		[Register ("saveResumeData", "()V", "")]
		public unsafe void SaveResumeData ()
		{
			const string __id = "saveResumeData.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='saveResumeData' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.resume_data_flags_t']]"
		[Register ("saveResumeData", "(Lcom/frostwire/jlibtorrent/swig/resume_data_flags_t;)V", "")]
		public unsafe void SaveResumeData (global::FrostWire.Libtorrent.Swig.Resume_data_flags_t flags)
		{
			const string __id = "saveResumeData.(Lcom/frostwire/jlibtorrent/swig/resume_data_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='scrapeTracker' and count(parameter)=0]"
		[Register ("scrapeTracker", "()V", "")]
		public unsafe void ScrapeTracker ()
		{
			const string __id = "scrapeTracker.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='setFlags' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_flags_t']]"
		[Register ("setFlags", "(Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;)V", "")]
		public unsafe void SetFlags (global::FrostWire.Libtorrent.Swig.Torrent_flags_t flags)
		{
			const string __id = "setFlags.(Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='setFlags' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_flags_t'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.torrent_flags_t']]"
		[Register ("setFlags", "(Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;)V", "")]
		public unsafe void SetFlags (global::FrostWire.Libtorrent.Swig.Torrent_flags_t flags, global::FrostWire.Libtorrent.Swig.Torrent_flags_t mask)
		{
			const string __id = "setFlags.(Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				__args [1] = new JniArgumentValue ((mask == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mask).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='setPieceDeadline' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setPieceDeadline", "(II)V", "")]
		public unsafe void SetPieceDeadline (int index, int deadline)
		{
			const string __id = "setPieceDeadline.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (deadline);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='setPieceDeadline' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.deadline_flags_t']]"
		[Register ("setPieceDeadline", "(IILcom/frostwire/jlibtorrent/swig/deadline_flags_t;)V", "")]
		public unsafe void SetPieceDeadline (int index, int deadline, global::FrostWire.Libtorrent.Swig.Deadline_flags_t flags)
		{
			const string __id = "setPieceDeadline.(IILcom/frostwire/jlibtorrent/swig/deadline_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (deadline);
				__args [2] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='setSslCertificate' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setSslCertificate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void SetSslCertificate (string certificate, string privateKey, string dhParams)
		{
			const string __id = "setSslCertificate.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_certificate = JNIEnv.NewString (certificate);
			IntPtr native_privateKey = JNIEnv.NewString (privateKey);
			IntPtr native_dhParams = JNIEnv.NewString (dhParams);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_certificate);
				__args [1] = new JniArgumentValue (native_privateKey);
				__args [2] = new JniArgumentValue (native_dhParams);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_certificate);
				JNIEnv.DeleteLocalRef (native_privateKey);
				JNIEnv.DeleteLocalRef (native_dhParams);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='setSslCertificate' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("setSslCertificate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void SetSslCertificate (string certificate, string privateKey, string dhParams, string passphrase)
		{
			const string __id = "setSslCertificate.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_certificate = JNIEnv.NewString (certificate);
			IntPtr native_privateKey = JNIEnv.NewString (privateKey);
			IntPtr native_dhParams = JNIEnv.NewString (dhParams);
			IntPtr native_passphrase = JNIEnv.NewString (passphrase);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_certificate);
				__args [1] = new JniArgumentValue (native_privateKey);
				__args [2] = new JniArgumentValue (native_dhParams);
				__args [3] = new JniArgumentValue (native_passphrase);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_certificate);
				JNIEnv.DeleteLocalRef (native_privateKey);
				JNIEnv.DeleteLocalRef (native_dhParams);
				JNIEnv.DeleteLocalRef (native_passphrase);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='status' and count(parameter)=0]"
		[Register ("status", "()Lcom/frostwire/jlibtorrent/TorrentStatus;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentStatus Status ()
		{
			const string __id = "status.()Lcom/frostwire/jlibtorrent/TorrentStatus;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='status' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("status", "(Z)Lcom/frostwire/jlibtorrent/TorrentStatus;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentStatus Status (bool force)
		{
			const string __id = "status.(Z)Lcom/frostwire/jlibtorrent/TorrentStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (force);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='status' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.status_flags_t']]"
		[Register ("status", "(Lcom/frostwire/jlibtorrent/swig/status_flags_t;)Lcom/frostwire/jlibtorrent/TorrentStatus;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentStatus Status (global::FrostWire.Libtorrent.Swig.Status_flags_t flags)
		{
			const string __id = "status.(Lcom/frostwire/jlibtorrent/swig/status_flags_t;)Lcom/frostwire/jlibtorrent/TorrentStatus;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/torrent_handle;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Torrent_handle Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/torrent_handle;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='torrentFile' and count(parameter)=0]"
		[Register ("torrentFile", "()Lcom/frostwire/jlibtorrent/TorrentInfo;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentInfo TorrentFile ()
		{
			const string __id = "torrentFile.()Lcom/frostwire/jlibtorrent/TorrentInfo;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='trackers' and count(parameter)=0]"
		[Register ("trackers", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.AnnounceEntry> Trackers ()
		{
			const string __id = "trackers.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.AnnounceEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='unsetFlags' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_flags_t']]"
		[Register ("unsetFlags", "(Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;)V", "")]
		public unsafe void UnsetFlags (global::FrostWire.Libtorrent.Swig.Torrent_flags_t flags)
		{
			const string __id = "unsetFlags.(Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentHandle']/method[@name='urlSeeds' and count(parameter)=0]"
		[Register ("urlSeeds", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> UrlSeeds ()
		{
			const string __id = "urlSeeds.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
