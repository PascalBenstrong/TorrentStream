using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/torrent_handle", DoNotGenerateAcw=true)]
	public partial class Torrent_handle : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/field[@name='alert_when_available']"
		[Register ("alert_when_available")]
		public static global::FrostWire.Libtorrent.Swig.Deadline_flags_t AlertWhenAvailable {
			get {
				const string __id = "alert_when_available.Lcom/frostwire/jlibtorrent/swig/deadline_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Deadline_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/field[@name='clear_disk_cache']"
		[Register ("clear_disk_cache")]
		public static global::FrostWire.Libtorrent.Swig.Pause_flags_t ClearDiskCache {
			get {
				const string __id = "clear_disk_cache.Lcom/frostwire/jlibtorrent/swig/pause_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Pause_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/field[@name='flush_disk_cache']"
		[Register ("flush_disk_cache")]
		public static global::FrostWire.Libtorrent.Swig.Resume_data_flags_t FlushDiskCache {
			get {
				const string __id = "flush_disk_cache.Lcom/frostwire/jlibtorrent/swig/resume_data_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Resume_data_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/field[@name='graceful_pause']"
		[Register ("graceful_pause")]
		public static global::FrostWire.Libtorrent.Swig.Pause_flags_t GracefulPause {
			get {
				const string __id = "graceful_pause.Lcom/frostwire/jlibtorrent/swig/pause_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Pause_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/field[@name='ignore_min_interval']"
		[Register ("ignore_min_interval")]
		public static global::FrostWire.Libtorrent.Swig.Reannounce_flags_t IgnoreMinInterval {
			get {
				const string __id = "ignore_min_interval.Lcom/frostwire/jlibtorrent/swig/reannounce_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Reannounce_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/field[@name='only_if_modified']"
		[Register ("only_if_modified")]
		public static global::FrostWire.Libtorrent.Swig.Resume_data_flags_t OnlyIfModified {
			get {
				const string __id = "only_if_modified.Lcom/frostwire/jlibtorrent/swig/resume_data_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Resume_data_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/field[@name='overwrite_existing']"
		[Register ("overwrite_existing")]
		public static global::FrostWire.Libtorrent.Swig.Add_piece_flags_t OverwriteExisting {
			get {
				const string __id = "overwrite_existing.Lcom/frostwire/jlibtorrent/swig/add_piece_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_piece_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/field[@name='query_accurate_download_counters']"
		[Register ("query_accurate_download_counters")]
		public static global::FrostWire.Libtorrent.Swig.Status_flags_t QueryAccurateDownloadCounters {
			get {
				const string __id = "query_accurate_download_counters.Lcom/frostwire/jlibtorrent/swig/status_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/field[@name='query_distributed_copies']"
		[Register ("query_distributed_copies")]
		public static global::FrostWire.Libtorrent.Swig.Status_flags_t QueryDistributedCopies {
			get {
				const string __id = "query_distributed_copies.Lcom/frostwire/jlibtorrent/swig/status_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/field[@name='query_last_seen_complete']"
		[Register ("query_last_seen_complete")]
		public static global::FrostWire.Libtorrent.Swig.Status_flags_t QueryLastSeenComplete {
			get {
				const string __id = "query_last_seen_complete.Lcom/frostwire/jlibtorrent/swig/status_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/field[@name='query_name']"
		[Register ("query_name")]
		public static global::FrostWire.Libtorrent.Swig.Status_flags_t QueryName {
			get {
				const string __id = "query_name.Lcom/frostwire/jlibtorrent/swig/status_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/field[@name='query_pieces']"
		[Register ("query_pieces")]
		public static global::FrostWire.Libtorrent.Swig.Status_flags_t QueryPieces {
			get {
				const string __id = "query_pieces.Lcom/frostwire/jlibtorrent/swig/status_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/field[@name='query_save_path']"
		[Register ("query_save_path")]
		public static global::FrostWire.Libtorrent.Swig.Status_flags_t QuerySavePath {
			get {
				const string __id = "query_save_path.Lcom/frostwire/jlibtorrent/swig/status_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/field[@name='query_torrent_file']"
		[Register ("query_torrent_file")]
		public static global::FrostWire.Libtorrent.Swig.Status_flags_t QueryTorrentFile {
			get {
				const string __id = "query_torrent_file.Lcom/frostwire/jlibtorrent/swig/status_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/field[@name='query_verified_pieces']"
		[Register ("query_verified_pieces")]
		public static global::FrostWire.Libtorrent.Swig.Status_flags_t QueryVerifiedPieces {
			get {
				const string __id = "query_verified_pieces.Lcom/frostwire/jlibtorrent/swig/status_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/field[@name='save_info_dict']"
		[Register ("save_info_dict")]
		public static global::FrostWire.Libtorrent.Swig.Resume_data_flags_t SaveInfoDict {
			get {
				const string __id = "save_info_dict.Lcom/frostwire/jlibtorrent/swig/resume_data_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Resume_data_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/field[@name='swigCMemOwn']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle.file_progress_flags_t']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/torrent_handle$file_progress_flags_t", DoNotGenerateAcw=true)]
		public sealed partial class File_progress_flags_t : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle.file_progress_flags_t']/field[@name='piece_granularity']"
			[Register ("piece_granularity")]
			public static global::FrostWire.Libtorrent.Swig.Torrent_handle.File_progress_flags_t PieceGranularity {
				get {
					const string __id = "piece_granularity.Lcom/frostwire/jlibtorrent/swig/torrent_handle$file_progress_flags_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle.File_progress_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/torrent_handle$file_progress_flags_t", typeof (File_progress_flags_t));
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

			internal File_progress_flags_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle.file_progress_flags_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/torrent_handle$file_progress_flags_t;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_handle.File_progress_flags_t SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/torrent_handle$file_progress_flags_t;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle.File_progress_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle.file_progress_flags_t']/method[@name='swigValue' and count(parameter)=0]"
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/torrent_handle", typeof (Torrent_handle));
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

		protected Torrent_handle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/constructor[@name='torrent_handle' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Torrent_handle (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_add_http_seed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_http_seed_Ljava_lang_String_Handler ()
		{
			if (cb_add_http_seed_Ljava_lang_String_ == null)
				cb_add_http_seed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_http_seed_Ljava_lang_String_);
			return cb_add_http_seed_Ljava_lang_String_;
		}

		static void n_Add_http_seed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.Add_http_seed (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='add_http_seed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("add_http_seed", "(Ljava/lang/String;)V", "GetAdd_http_seed_Ljava_lang_String_Handler")]
		public virtual unsafe void Add_http_seed (string url)
		{
			const string __id = "add_http_seed.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_add_piece_bytes_ILcom_frostwire_jlibtorrent_swig_byte_vector_;
#pragma warning disable 0169
		static Delegate GetAdd_piece_bytes_ILcom_frostwire_jlibtorrent_swig_byte_vector_Handler ()
		{
			if (cb_add_piece_bytes_ILcom_frostwire_jlibtorrent_swig_byte_vector_ == null)
				cb_add_piece_bytes_ILcom_frostwire_jlibtorrent_swig_byte_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Add_piece_bytes_ILcom_frostwire_jlibtorrent_swig_byte_vector_);
			return cb_add_piece_bytes_ILcom_frostwire_jlibtorrent_swig_byte_vector_;
		}

		static void n_Add_piece_bytes_ILcom_frostwire_jlibtorrent_swig_byte_vector_ (IntPtr jnienv, IntPtr native__this, int piece, IntPtr native_data)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector data = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.Add_piece_bytes (piece, data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='add_piece_bytes' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("add_piece_bytes", "(ILcom/frostwire/jlibtorrent/swig/byte_vector;)V", "GetAdd_piece_bytes_ILcom_frostwire_jlibtorrent_swig_byte_vector_Handler")]
		public virtual unsafe void Add_piece_bytes (int piece, global::FrostWire.Libtorrent.Swig.Byte_vector data)
		{
			const string __id = "add_piece_bytes.(ILcom/frostwire/jlibtorrent/swig/byte_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (piece);
				__args [1] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_add_piece_bytes_ILcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_add_piece_flags_t_;
#pragma warning disable 0169
		static Delegate GetAdd_piece_bytes_ILcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_add_piece_flags_t_Handler ()
		{
			if (cb_add_piece_bytes_ILcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_add_piece_flags_t_ == null)
				cb_add_piece_bytes_ILcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_add_piece_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Add_piece_bytes_ILcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_add_piece_flags_t_);
			return cb_add_piece_bytes_ILcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_add_piece_flags_t_;
		}

		static void n_Add_piece_bytes_ILcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_add_piece_flags_t_ (IntPtr jnienv, IntPtr native__this, int piece, IntPtr native_data, IntPtr native_flags)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector data = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_data, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Add_piece_flags_t flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_piece_flags_t> (native_flags, JniHandleOwnership.DoNotTransfer);
			__this.Add_piece_bytes (piece, data, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='add_piece_bytes' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.byte_vector'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.add_piece_flags_t']]"
		[Register ("add_piece_bytes", "(ILcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/add_piece_flags_t;)V", "GetAdd_piece_bytes_ILcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_add_piece_flags_t_Handler")]
		public virtual unsafe void Add_piece_bytes (int piece, global::FrostWire.Libtorrent.Swig.Byte_vector data, global::FrostWire.Libtorrent.Swig.Add_piece_flags_t flags)
		{
			const string __id = "add_piece_bytes.(ILcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/add_piece_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (piece);
				__args [1] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [2] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_add_tracker_Lcom_frostwire_jlibtorrent_swig_announce_entry_;
#pragma warning disable 0169
		static Delegate GetAdd_tracker_Lcom_frostwire_jlibtorrent_swig_announce_entry_Handler ()
		{
			if (cb_add_tracker_Lcom_frostwire_jlibtorrent_swig_announce_entry_ == null)
				cb_add_tracker_Lcom_frostwire_jlibtorrent_swig_announce_entry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_tracker_Lcom_frostwire_jlibtorrent_swig_announce_entry_);
			return cb_add_tracker_Lcom_frostwire_jlibtorrent_swig_announce_entry_;
		}

		static void n_Add_tracker_Lcom_frostwire_jlibtorrent_swig_announce_entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_arg0)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Announce_entry arg0 = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry> (native_arg0, JniHandleOwnership.DoNotTransfer);
			__this.Add_tracker (arg0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='add_tracker' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.announce_entry']]"
		[Register ("add_tracker", "(Lcom/frostwire/jlibtorrent/swig/announce_entry;)V", "GetAdd_tracker_Lcom_frostwire_jlibtorrent_swig_announce_entry_Handler")]
		public virtual unsafe void Add_tracker (global::FrostWire.Libtorrent.Swig.Announce_entry arg0)
		{
			const string __id = "add_tracker.(Lcom/frostwire/jlibtorrent/swig/announce_entry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((arg0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_add_url_seed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAdd_url_seed_Ljava_lang_String_Handler ()
		{
			if (cb_add_url_seed_Ljava_lang_String_ == null)
				cb_add_url_seed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_url_seed_Ljava_lang_String_);
			return cb_add_url_seed_Ljava_lang_String_;
		}

		static void n_Add_url_seed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.Add_url_seed (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='add_url_seed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("add_url_seed", "(Ljava/lang/String;)V", "GetAdd_url_seed_Ljava_lang_String_Handler")]
		public virtual unsafe void Add_url_seed (string url)
		{
			const string __id = "add_url_seed.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_clear_error;
#pragma warning disable 0169
		static Delegate GetClear_errorHandler ()
		{
			if (cb_clear_error == null)
				cb_clear_error = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear_error);
			return cb_clear_error;
		}

		static void n_Clear_error (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear_error ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='clear_error' and count(parameter)=0]"
		[Register ("clear_error", "()V", "GetClear_errorHandler")]
		public virtual unsafe void Clear_error ()
		{
			const string __id = "clear_error.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clear_piece_deadlines;
#pragma warning disable 0169
		static Delegate GetClear_piece_deadlinesHandler ()
		{
			if (cb_clear_piece_deadlines == null)
				cb_clear_piece_deadlines = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear_piece_deadlines);
			return cb_clear_piece_deadlines;
		}

		static void n_Clear_piece_deadlines (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear_piece_deadlines ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='clear_piece_deadlines' and count(parameter)=0]"
		[Register ("clear_piece_deadlines", "()V", "GetClear_piece_deadlinesHandler")]
		public virtual unsafe void Clear_piece_deadlines ()
		{
			const string __id = "clear_piece_deadlines.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_connect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_;
#pragma warning disable 0169
		static Delegate GetConnect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Handler ()
		{
			if (cb_connect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_ == null)
				cb_connect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Connect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_);
			return cb_connect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_;
		}

		static void n_Connect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adr)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Tcp_endpoint adr = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tcp_endpoint> (native_adr, JniHandleOwnership.DoNotTransfer);
			__this.Connect_peer (adr);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='connect_peer' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.tcp_endpoint']]"
		[Register ("connect_peer", "(Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;)V", "GetConnect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Handler")]
		public virtual unsafe void Connect_peer (global::FrostWire.Libtorrent.Swig.Tcp_endpoint adr)
		{
			const string __id = "connect_peer.(Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((adr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adr).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_connect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_;
#pragma warning disable 0169
		static Delegate GetConnect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_Handler ()
		{
			if (cb_connect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_ == null)
				cb_connect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_);
			return cb_connect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_;
		}

		static void n_Connect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adr, IntPtr native_source)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Tcp_endpoint adr = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tcp_endpoint> (native_adr, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Peer_source_flags_t source = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_source_flags_t> (native_source, JniHandleOwnership.DoNotTransfer);
			__this.Connect_peer (adr, source);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='connect_peer' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.tcp_endpoint'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.peer_source_flags_t']]"
		[Register ("connect_peer", "(Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;Lcom/frostwire/jlibtorrent/swig/peer_source_flags_t;)V", "GetConnect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_Handler")]
		public virtual unsafe void Connect_peer (global::FrostWire.Libtorrent.Swig.Tcp_endpoint adr, global::FrostWire.Libtorrent.Swig.Peer_source_flags_t source)
		{
			const string __id = "connect_peer.(Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;Lcom/frostwire/jlibtorrent/swig/peer_source_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((adr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adr).Handle);
				__args [1] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_connect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_Lcom_frostwire_jlibtorrent_swig_pex_flags_t_;
#pragma warning disable 0169
		static Delegate GetConnect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_Lcom_frostwire_jlibtorrent_swig_pex_flags_t_Handler ()
		{
			if (cb_connect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_Lcom_frostwire_jlibtorrent_swig_pex_flags_t_ == null)
				cb_connect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_Lcom_frostwire_jlibtorrent_swig_pex_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_Lcom_frostwire_jlibtorrent_swig_pex_flags_t_);
			return cb_connect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_Lcom_frostwire_jlibtorrent_swig_pex_flags_t_;
		}

		static void n_Connect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_Lcom_frostwire_jlibtorrent_swig_pex_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_adr, IntPtr native_source, IntPtr native_flags)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Tcp_endpoint adr = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tcp_endpoint> (native_adr, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Peer_source_flags_t source = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_source_flags_t> (native_source, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Pex_flags_t flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Pex_flags_t> (native_flags, JniHandleOwnership.DoNotTransfer);
			__this.Connect_peer (adr, source, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='connect_peer' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.swig.tcp_endpoint'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.peer_source_flags_t'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.pex_flags_t']]"
		[Register ("connect_peer", "(Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;Lcom/frostwire/jlibtorrent/swig/peer_source_flags_t;Lcom/frostwire/jlibtorrent/swig/pex_flags_t;)V", "GetConnect_peer_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_Lcom_frostwire_jlibtorrent_swig_pex_flags_t_Handler")]
		public virtual unsafe void Connect_peer (global::FrostWire.Libtorrent.Swig.Tcp_endpoint adr, global::FrostWire.Libtorrent.Swig.Peer_source_flags_t source, global::FrostWire.Libtorrent.Swig.Pex_flags_t flags)
		{
			const string __id = "connect_peer.(Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;Lcom/frostwire/jlibtorrent/swig/peer_source_flags_t;Lcom/frostwire/jlibtorrent/swig/pex_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((adr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adr).Handle);
				__args [1] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [2] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_download_limit;
#pragma warning disable 0169
		static Delegate GetDownload_limitHandler ()
		{
			if (cb_download_limit == null)
				cb_download_limit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Download_limit);
			return cb_download_limit;
		}

		static int n_Download_limit (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Download_limit ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='download_limit' and count(parameter)=0]"
		[Register ("download_limit", "()I", "GetDownload_limitHandler")]
		public virtual unsafe int Download_limit ()
		{
			const string __id = "download_limit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_file_priority2_I;
#pragma warning disable 0169
		static Delegate GetFile_priority2_IHandler ()
		{
			if (cb_file_priority2_I == null)
				cb_file_priority2_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_File_priority2_I);
			return cb_file_priority2_I;
		}

		static int n_File_priority2_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.File_priority2 (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='file_priority2' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("file_priority2", "(I)I", "GetFile_priority2_IHandler")]
		public virtual unsafe int File_priority2 (int index)
		{
			const string __id = "file_priority2.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_file_priority2_II;
#pragma warning disable 0169
		static Delegate GetFile_priority2_IIHandler ()
		{
			if (cb_file_priority2_II == null)
				cb_file_priority2_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_File_priority2_II);
			return cb_file_priority2_II;
		}

		static void n_File_priority2_II (IntPtr jnienv, IntPtr native__this, int index, int priority)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.File_priority2 (index, priority);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='file_priority2' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("file_priority2", "(II)V", "GetFile_priority2_IIHandler")]
		public virtual unsafe void File_priority2 (int index, int priority)
		{
			const string __id = "file_priority2.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (priority);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_file_progress_Lcom_frostwire_jlibtorrent_swig_int64_vector_;
#pragma warning disable 0169
		static Delegate GetFile_progress_Lcom_frostwire_jlibtorrent_swig_int64_vector_Handler ()
		{
			if (cb_file_progress_Lcom_frostwire_jlibtorrent_swig_int64_vector_ == null)
				cb_file_progress_Lcom_frostwire_jlibtorrent_swig_int64_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_File_progress_Lcom_frostwire_jlibtorrent_swig_int64_vector_);
			return cb_file_progress_Lcom_frostwire_jlibtorrent_swig_int64_vector_;
		}

		static void n_File_progress_Lcom_frostwire_jlibtorrent_swig_int64_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_progress)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Int64_vector progress = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Int64_vector> (native_progress, JniHandleOwnership.DoNotTransfer);
			__this.File_progress (progress);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='file_progress' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.int64_vector']]"
		[Register ("file_progress", "(Lcom/frostwire/jlibtorrent/swig/int64_vector;)V", "GetFile_progress_Lcom_frostwire_jlibtorrent_swig_int64_vector_Handler")]
		public virtual unsafe void File_progress (global::FrostWire.Libtorrent.Swig.Int64_vector progress)
		{
			const string __id = "file_progress.(Lcom/frostwire/jlibtorrent/swig/int64_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((progress == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progress).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_file_progress_Lcom_frostwire_jlibtorrent_swig_int64_vector_I;
#pragma warning disable 0169
		static Delegate GetFile_progress_Lcom_frostwire_jlibtorrent_swig_int64_vector_IHandler ()
		{
			if (cb_file_progress_Lcom_frostwire_jlibtorrent_swig_int64_vector_I == null)
				cb_file_progress_Lcom_frostwire_jlibtorrent_swig_int64_vector_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_File_progress_Lcom_frostwire_jlibtorrent_swig_int64_vector_I);
			return cb_file_progress_Lcom_frostwire_jlibtorrent_swig_int64_vector_I;
		}

		static void n_File_progress_Lcom_frostwire_jlibtorrent_swig_int64_vector_I (IntPtr jnienv, IntPtr native__this, IntPtr native_progress, int flags)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Int64_vector progress = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Int64_vector> (native_progress, JniHandleOwnership.DoNotTransfer);
			__this.File_progress (progress, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='file_progress' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.int64_vector'] and parameter[2][@type='int']]"
		[Register ("file_progress", "(Lcom/frostwire/jlibtorrent/swig/int64_vector;I)V", "GetFile_progress_Lcom_frostwire_jlibtorrent_swig_int64_vector_IHandler")]
		public virtual unsafe void File_progress (global::FrostWire.Libtorrent.Swig.Int64_vector progress, int flags)
		{
			const string __id = "file_progress.(Lcom/frostwire/jlibtorrent/swig/int64_vector;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((progress == null) ? IntPtr.Zero : ((global::Java.Lang.Object) progress).Handle);
				__args [1] = new JniArgumentValue (flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_flags;
#pragma warning disable 0169
		static Delegate GetFlagsHandler ()
		{
			if (cb_flags == null)
				cb_flags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Flags);
			return cb_flags;
		}

		static IntPtr n_Flags (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Flags ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='flags' and count(parameter)=0]"
		[Register ("flags", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "GetFlagsHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Flags ()
		{
			const string __id = "flags.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_flush_cache;
#pragma warning disable 0169
		static Delegate GetFlush_cacheHandler ()
		{
			if (cb_flush_cache == null)
				cb_flush_cache = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Flush_cache);
			return cb_flush_cache;
		}

		static void n_Flush_cache (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush_cache ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='flush_cache' and count(parameter)=0]"
		[Register ("flush_cache", "()V", "GetFlush_cacheHandler")]
		public virtual unsafe void Flush_cache ()
		{
			const string __id = "flush_cache.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_force_dht_announce;
#pragma warning disable 0169
		static Delegate GetForce_dht_announceHandler ()
		{
			if (cb_force_dht_announce == null)
				cb_force_dht_announce = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Force_dht_announce);
			return cb_force_dht_announce;
		}

		static void n_Force_dht_announce (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Force_dht_announce ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='force_dht_announce' and count(parameter)=0]"
		[Register ("force_dht_announce", "()V", "GetForce_dht_announceHandler")]
		public virtual unsafe void Force_dht_announce ()
		{
			const string __id = "force_dht_announce.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_force_reannounce;
#pragma warning disable 0169
		static Delegate GetForce_reannounceHandler ()
		{
			if (cb_force_reannounce == null)
				cb_force_reannounce = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Force_reannounce);
			return cb_force_reannounce;
		}

		static void n_Force_reannounce (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Force_reannounce ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='force_reannounce' and count(parameter)=0]"
		[Register ("force_reannounce", "()V", "GetForce_reannounceHandler")]
		public virtual unsafe void Force_reannounce ()
		{
			const string __id = "force_reannounce.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_force_reannounce_I;
#pragma warning disable 0169
		static Delegate GetForce_reannounce_IHandler ()
		{
			if (cb_force_reannounce_I == null)
				cb_force_reannounce_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Force_reannounce_I);
			return cb_force_reannounce_I;
		}

		static void n_Force_reannounce_I (IntPtr jnienv, IntPtr native__this, int seconds)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Force_reannounce (seconds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='force_reannounce' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("force_reannounce", "(I)V", "GetForce_reannounce_IHandler")]
		public virtual unsafe void Force_reannounce (int seconds)
		{
			const string __id = "force_reannounce.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (seconds);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_force_reannounce_II;
#pragma warning disable 0169
		static Delegate GetForce_reannounce_IIHandler ()
		{
			if (cb_force_reannounce_II == null)
				cb_force_reannounce_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_Force_reannounce_II);
			return cb_force_reannounce_II;
		}

		static void n_Force_reannounce_II (IntPtr jnienv, IntPtr native__this, int seconds, int tracker_index)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Force_reannounce (seconds, tracker_index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='force_reannounce' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("force_reannounce", "(II)V", "GetForce_reannounce_IIHandler")]
		public virtual unsafe void Force_reannounce (int seconds, int tracker_index)
		{
			const string __id = "force_reannounce.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (seconds);
				__args [1] = new JniArgumentValue (tracker_index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_force_reannounce_IILcom_frostwire_jlibtorrent_swig_reannounce_flags_t_;
#pragma warning disable 0169
		static Delegate GetForce_reannounce_IILcom_frostwire_jlibtorrent_swig_reannounce_flags_t_Handler ()
		{
			if (cb_force_reannounce_IILcom_frostwire_jlibtorrent_swig_reannounce_flags_t_ == null)
				cb_force_reannounce_IILcom_frostwire_jlibtorrent_swig_reannounce_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_Force_reannounce_IILcom_frostwire_jlibtorrent_swig_reannounce_flags_t_);
			return cb_force_reannounce_IILcom_frostwire_jlibtorrent_swig_reannounce_flags_t_;
		}

		static void n_Force_reannounce_IILcom_frostwire_jlibtorrent_swig_reannounce_flags_t_ (IntPtr jnienv, IntPtr native__this, int seconds, int tracker_index, IntPtr native_arg2)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Reannounce_flags_t arg2 = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Reannounce_flags_t> (native_arg2, JniHandleOwnership.DoNotTransfer);
			__this.Force_reannounce (seconds, tracker_index, arg2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='force_reannounce' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.reannounce_flags_t']]"
		[Register ("force_reannounce", "(IILcom/frostwire/jlibtorrent/swig/reannounce_flags_t;)V", "GetForce_reannounce_IILcom_frostwire_jlibtorrent_swig_reannounce_flags_t_Handler")]
		public virtual unsafe void Force_reannounce (int seconds, int tracker_index, global::FrostWire.Libtorrent.Swig.Reannounce_flags_t arg2)
		{
			const string __id = "force_reannounce.(IILcom/frostwire/jlibtorrent/swig/reannounce_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (seconds);
				__args [1] = new JniArgumentValue (tracker_index);
				__args [2] = new JniArgumentValue ((arg2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_force_recheck;
#pragma warning disable 0169
		static Delegate GetForce_recheckHandler ()
		{
			if (cb_force_recheck == null)
				cb_force_recheck = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Force_recheck);
			return cb_force_recheck;
		}

		static void n_Force_recheck (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Force_recheck ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='force_recheck' and count(parameter)=0]"
		[Register ("force_recheck", "()V", "GetForce_recheckHandler")]
		public virtual unsafe void Force_recheck ()
		{
			const string __id = "force_recheck.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_handle']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/torrent_handle;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Torrent_handle obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/torrent_handle;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_download_queue_Lcom_frostwire_jlibtorrent_swig_partial_piece_info_vector_;
#pragma warning disable 0169
		static Delegate GetGet_download_queue_Lcom_frostwire_jlibtorrent_swig_partial_piece_info_vector_Handler ()
		{
			if (cb_get_download_queue_Lcom_frostwire_jlibtorrent_swig_partial_piece_info_vector_ == null)
				cb_get_download_queue_Lcom_frostwire_jlibtorrent_swig_partial_piece_info_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Get_download_queue_Lcom_frostwire_jlibtorrent_swig_partial_piece_info_vector_);
			return cb_get_download_queue_Lcom_frostwire_jlibtorrent_swig_partial_piece_info_vector_;
		}

		static void n_Get_download_queue_Lcom_frostwire_jlibtorrent_swig_partial_piece_info_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_queue)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Partial_piece_info_vector queue = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Partial_piece_info_vector> (native_queue, JniHandleOwnership.DoNotTransfer);
			__this.Get_download_queue (queue);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='get_download_queue' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.partial_piece_info_vector']]"
		[Register ("get_download_queue", "(Lcom/frostwire/jlibtorrent/swig/partial_piece_info_vector;)V", "GetGet_download_queue_Lcom_frostwire_jlibtorrent_swig_partial_piece_info_vector_Handler")]
		public virtual unsafe void Get_download_queue (global::FrostWire.Libtorrent.Swig.Partial_piece_info_vector queue)
		{
			const string __id = "get_download_queue.(Lcom/frostwire/jlibtorrent/swig/partial_piece_info_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((queue == null) ? IntPtr.Zero : ((global::Java.Lang.Object) queue).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_get_file_priorities2;
#pragma warning disable 0169
		static Delegate GetGet_file_priorities2Handler ()
		{
			if (cb_get_file_priorities2 == null)
				cb_get_file_priorities2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_file_priorities2);
			return cb_get_file_priorities2;
		}

		static IntPtr n_Get_file_priorities2 (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_file_priorities2 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='get_file_priorities2' and count(parameter)=0]"
		[Register ("get_file_priorities2", "()Lcom/frostwire/jlibtorrent/swig/int_vector;", "GetGet_file_priorities2Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Int_vector Get_file_priorities2 ()
		{
			const string __id = "get_file_priorities2.()Lcom/frostwire/jlibtorrent/swig/int_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Int_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_http_seeds;
#pragma warning disable 0169
		static Delegate GetGet_http_seedsHandler ()
		{
			if (cb_get_http_seeds == null)
				cb_get_http_seeds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_http_seeds);
			return cb_get_http_seeds;
		}

		static IntPtr n_Get_http_seeds (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_http_seeds ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='get_http_seeds' and count(parameter)=0]"
		[Register ("get_http_seeds", "()Lcom/frostwire/jlibtorrent/swig/string_vector;", "GetGet_http_seedsHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.String_vector Get_http_seeds ()
		{
			const string __id = "get_http_seeds.()Lcom/frostwire/jlibtorrent/swig/string_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_peer_info_Lcom_frostwire_jlibtorrent_swig_peer_info_vector_;
#pragma warning disable 0169
		static Delegate GetGet_peer_info_Lcom_frostwire_jlibtorrent_swig_peer_info_vector_Handler ()
		{
			if (cb_get_peer_info_Lcom_frostwire_jlibtorrent_swig_peer_info_vector_ == null)
				cb_get_peer_info_Lcom_frostwire_jlibtorrent_swig_peer_info_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Get_peer_info_Lcom_frostwire_jlibtorrent_swig_peer_info_vector_);
			return cb_get_peer_info_Lcom_frostwire_jlibtorrent_swig_peer_info_vector_;
		}

		static void n_Get_peer_info_Lcom_frostwire_jlibtorrent_swig_peer_info_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_v)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Peer_info_vector v = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info_vector> (native_v, JniHandleOwnership.DoNotTransfer);
			__this.Get_peer_info (v);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='get_peer_info' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_info_vector']]"
		[Register ("get_peer_info", "(Lcom/frostwire/jlibtorrent/swig/peer_info_vector;)V", "GetGet_peer_info_Lcom_frostwire_jlibtorrent_swig_peer_info_vector_Handler")]
		public virtual unsafe void Get_peer_info (global::FrostWire.Libtorrent.Swig.Peer_info_vector v)
		{
			const string __id = "get_peer_info.(Lcom/frostwire/jlibtorrent/swig/peer_info_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_get_piece_priorities2;
#pragma warning disable 0169
		static Delegate GetGet_piece_priorities2Handler ()
		{
			if (cb_get_piece_priorities2 == null)
				cb_get_piece_priorities2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_piece_priorities2);
			return cb_get_piece_priorities2;
		}

		static IntPtr n_Get_piece_priorities2 (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_piece_priorities2 ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='get_piece_priorities2' and count(parameter)=0]"
		[Register ("get_piece_priorities2", "()Lcom/frostwire/jlibtorrent/swig/int_vector;", "GetGet_piece_priorities2Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Int_vector Get_piece_priorities2 ()
		{
			const string __id = "get_piece_priorities2.()Lcom/frostwire/jlibtorrent/swig/int_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Int_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_url_seeds ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='get_url_seeds' and count(parameter)=0]"
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

		static Delegate cb_have_piece_I;
#pragma warning disable 0169
		static Delegate GetHave_piece_IHandler ()
		{
			if (cb_have_piece_I == null)
				cb_have_piece_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Have_piece_I);
			return cb_have_piece_I;
		}

		static bool n_Have_piece_I (IntPtr jnienv, IntPtr native__this, int piece)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Have_piece (piece);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='have_piece' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("have_piece", "(I)Z", "GetHave_piece_IHandler")]
		public virtual unsafe bool Have_piece (int piece)
		{
			const string __id = "have_piece.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (piece);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_id;
#pragma warning disable 0169
		static Delegate GetIdHandler ()
		{
			if (cb_id == null)
				cb_id = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Id);
			return cb_id;
		}

		static long n_Id (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='id' and count(parameter)=0]"
		[Register ("id", "()J", "GetIdHandler")]
		public virtual unsafe long Id ()
		{
			const string __id = "id.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_info_hash;
#pragma warning disable 0169
		static Delegate GetInfo_hashHandler ()
		{
			if (cb_info_hash == null)
				cb_info_hash = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Info_hash);
			return cb_info_hash;
		}

		static IntPtr n_Info_hash (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Info_hash ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='info_hash' and count(parameter)=0]"
		[Register ("info_hash", "()Lcom/frostwire/jlibtorrent/swig/sha1_hash;", "GetInfo_hashHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash Info_hash ()
		{
			const string __id = "info_hash.()Lcom/frostwire/jlibtorrent/swig/sha1_hash;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_is_valid;
#pragma warning disable 0169
		static Delegate GetIs_validHandler ()
		{
			if (cb_is_valid == null)
				cb_is_valid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Is_valid);
			return cb_is_valid;
		}

		static bool n_Is_valid (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_valid ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='is_valid' and count(parameter)=0]"
		[Register ("is_valid", "()Z", "GetIs_validHandler")]
		public virtual unsafe bool Is_valid ()
		{
			const string __id = "is_valid.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_max_connections;
#pragma warning disable 0169
		static Delegate GetMax_connectionsHandler ()
		{
			if (cb_max_connections == null)
				cb_max_connections = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Max_connections);
			return cb_max_connections;
		}

		static int n_Max_connections (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Max_connections ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='max_connections' and count(parameter)=0]"
		[Register ("max_connections", "()I", "GetMax_connectionsHandler")]
		public virtual unsafe int Max_connections ()
		{
			const string __id = "max_connections.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_max_uploads;
#pragma warning disable 0169
		static Delegate GetMax_uploadsHandler ()
		{
			if (cb_max_uploads == null)
				cb_max_uploads = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Max_uploads);
			return cb_max_uploads;
		}

		static int n_Max_uploads (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Max_uploads ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='max_uploads' and count(parameter)=0]"
		[Register ("max_uploads", "()I", "GetMax_uploadsHandler")]
		public virtual unsafe int Max_uploads ()
		{
			const string __id = "max_uploads.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_move_storage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetMove_storage_Ljava_lang_String_Handler ()
		{
			if (cb_move_storage_Ljava_lang_String_ == null)
				cb_move_storage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Move_storage_Ljava_lang_String_);
			return cb_move_storage_Ljava_lang_String_;
		}

		static void n_Move_storage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_save_path)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string save_path = JNIEnv.GetString (native_save_path, JniHandleOwnership.DoNotTransfer);
			__this.Move_storage (save_path);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='move_storage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("move_storage", "(Ljava/lang/String;)V", "GetMove_storage_Ljava_lang_String_Handler")]
		public virtual unsafe void Move_storage (string save_path)
		{
			const string __id = "move_storage.(Ljava/lang/String;)V";
			IntPtr native_save_path = JNIEnv.NewString (save_path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_save_path);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_save_path);
			}
		}

		static Delegate cb_move_storage_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_move_flags_t_;
#pragma warning disable 0169
		static Delegate GetMove_storage_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_move_flags_t_Handler ()
		{
			if (cb_move_storage_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_move_flags_t_ == null)
				cb_move_storage_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_move_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Move_storage_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_move_flags_t_);
			return cb_move_storage_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_move_flags_t_;
		}

		static void n_Move_storage_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_move_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_save_path, IntPtr native_flags)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string save_path = JNIEnv.GetString (native_save_path, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Move_flags_t flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Move_flags_t> (native_flags, JniHandleOwnership.DoNotTransfer);
			__this.Move_storage (save_path, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='move_storage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.move_flags_t']]"
		[Register ("move_storage", "(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/move_flags_t;)V", "GetMove_storage_Ljava_lang_String_Lcom_frostwire_jlibtorrent_swig_move_flags_t_Handler")]
		public virtual unsafe void Move_storage (string save_path, global::FrostWire.Libtorrent.Swig.Move_flags_t flags)
		{
			const string __id = "move_storage.(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/move_flags_t;)V";
			IntPtr native_save_path = JNIEnv.NewString (save_path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_save_path);
				__args [1] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_save_path);
			}
		}

		static Delegate cb_need_save_resume_data;
#pragma warning disable 0169
		static Delegate GetNeed_save_resume_dataHandler ()
		{
			if (cb_need_save_resume_data == null)
				cb_need_save_resume_data = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Need_save_resume_data);
			return cb_need_save_resume_data;
		}

		static bool n_Need_save_resume_data (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Need_save_resume_data ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='need_save_resume_data' and count(parameter)=0]"
		[Register ("need_save_resume_data", "()Z", "GetNeed_save_resume_dataHandler")]
		public virtual unsafe bool Need_save_resume_data ()
		{
			const string __id = "need_save_resume_data.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_op_eq_Lcom_frostwire_jlibtorrent_swig_torrent_handle_;
#pragma warning disable 0169
		static Delegate GetOp_eq_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Handler ()
		{
			if (cb_op_eq_Lcom_frostwire_jlibtorrent_swig_torrent_handle_ == null)
				cb_op_eq_Lcom_frostwire_jlibtorrent_swig_torrent_handle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Op_eq_Lcom_frostwire_jlibtorrent_swig_torrent_handle_);
			return cb_op_eq_Lcom_frostwire_jlibtorrent_swig_torrent_handle_;
		}

		static bool n_Op_eq_Lcom_frostwire_jlibtorrent_swig_torrent_handle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_h)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Torrent_handle h = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (native_h, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Op_eq (h);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='op_eq' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_handle']]"
		[Register ("op_eq", "(Lcom/frostwire/jlibtorrent/swig/torrent_handle;)Z", "GetOp_eq_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Handler")]
		public virtual unsafe bool Op_eq (global::FrostWire.Libtorrent.Swig.Torrent_handle h)
		{
			const string __id = "op_eq.(Lcom/frostwire/jlibtorrent/swig/torrent_handle;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((h == null) ? IntPtr.Zero : ((global::Java.Lang.Object) h).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_op_lt_Lcom_frostwire_jlibtorrent_swig_torrent_handle_;
#pragma warning disable 0169
		static Delegate GetOp_lt_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Handler ()
		{
			if (cb_op_lt_Lcom_frostwire_jlibtorrent_swig_torrent_handle_ == null)
				cb_op_lt_Lcom_frostwire_jlibtorrent_swig_torrent_handle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Op_lt_Lcom_frostwire_jlibtorrent_swig_torrent_handle_);
			return cb_op_lt_Lcom_frostwire_jlibtorrent_swig_torrent_handle_;
		}

		static bool n_Op_lt_Lcom_frostwire_jlibtorrent_swig_torrent_handle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_h)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Torrent_handle h = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (native_h, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Op_lt (h);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='op_lt' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_handle']]"
		[Register ("op_lt", "(Lcom/frostwire/jlibtorrent/swig/torrent_handle;)Z", "GetOp_lt_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Handler")]
		public virtual unsafe bool Op_lt (global::FrostWire.Libtorrent.Swig.Torrent_handle h)
		{
			const string __id = "op_lt.(Lcom/frostwire/jlibtorrent/swig/torrent_handle;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((h == null) ? IntPtr.Zero : ((global::Java.Lang.Object) h).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_op_ne_Lcom_frostwire_jlibtorrent_swig_torrent_handle_;
#pragma warning disable 0169
		static Delegate GetOp_ne_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Handler ()
		{
			if (cb_op_ne_Lcom_frostwire_jlibtorrent_swig_torrent_handle_ == null)
				cb_op_ne_Lcom_frostwire_jlibtorrent_swig_torrent_handle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Op_ne_Lcom_frostwire_jlibtorrent_swig_torrent_handle_);
			return cb_op_ne_Lcom_frostwire_jlibtorrent_swig_torrent_handle_;
		}

		static bool n_Op_ne_Lcom_frostwire_jlibtorrent_swig_torrent_handle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_h)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Torrent_handle h = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (native_h, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Op_ne (h);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='op_ne' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_handle']]"
		[Register ("op_ne", "(Lcom/frostwire/jlibtorrent/swig/torrent_handle;)Z", "GetOp_ne_Lcom_frostwire_jlibtorrent_swig_torrent_handle_Handler")]
		public virtual unsafe bool Op_ne (global::FrostWire.Libtorrent.Swig.Torrent_handle h)
		{
			const string __id = "op_ne.(Lcom/frostwire/jlibtorrent/swig/torrent_handle;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((h == null) ? IntPtr.Zero : ((global::Java.Lang.Object) h).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			const string __id = "pause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_pause_Lcom_frostwire_jlibtorrent_swig_pause_flags_t_;
#pragma warning disable 0169
		static Delegate GetPause_Lcom_frostwire_jlibtorrent_swig_pause_flags_t_Handler ()
		{
			if (cb_pause_Lcom_frostwire_jlibtorrent_swig_pause_flags_t_ == null)
				cb_pause_Lcom_frostwire_jlibtorrent_swig_pause_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Pause_Lcom_frostwire_jlibtorrent_swig_pause_flags_t_);
			return cb_pause_Lcom_frostwire_jlibtorrent_swig_pause_flags_t_;
		}

		static void n_Pause_Lcom_frostwire_jlibtorrent_swig_pause_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_flags)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Pause_flags_t flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Pause_flags_t> (native_flags, JniHandleOwnership.DoNotTransfer);
			__this.Pause (flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='pause' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.pause_flags_t']]"
		[Register ("pause", "(Lcom/frostwire/jlibtorrent/swig/pause_flags_t;)V", "GetPause_Lcom_frostwire_jlibtorrent_swig_pause_flags_t_Handler")]
		public virtual unsafe void Pause (global::FrostWire.Libtorrent.Swig.Pause_flags_t flags)
		{
			const string __id = "pause.(Lcom/frostwire/jlibtorrent/swig/pause_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_piece_availability_Lcom_frostwire_jlibtorrent_swig_int_vector_;
#pragma warning disable 0169
		static Delegate GetPiece_availability_Lcom_frostwire_jlibtorrent_swig_int_vector_Handler ()
		{
			if (cb_piece_availability_Lcom_frostwire_jlibtorrent_swig_int_vector_ == null)
				cb_piece_availability_Lcom_frostwire_jlibtorrent_swig_int_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Piece_availability_Lcom_frostwire_jlibtorrent_swig_int_vector_);
			return cb_piece_availability_Lcom_frostwire_jlibtorrent_swig_int_vector_;
		}

		static void n_Piece_availability_Lcom_frostwire_jlibtorrent_swig_int_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_avail)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Int_vector avail = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Int_vector> (native_avail, JniHandleOwnership.DoNotTransfer);
			__this.Piece_availability (avail);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='piece_availability' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.int_vector']]"
		[Register ("piece_availability", "(Lcom/frostwire/jlibtorrent/swig/int_vector;)V", "GetPiece_availability_Lcom_frostwire_jlibtorrent_swig_int_vector_Handler")]
		public virtual unsafe void Piece_availability (global::FrostWire.Libtorrent.Swig.Int_vector avail)
		{
			const string __id = "piece_availability.(Lcom/frostwire/jlibtorrent/swig/int_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((avail == null) ? IntPtr.Zero : ((global::Java.Lang.Object) avail).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_piece_priority2_I;
#pragma warning disable 0169
		static Delegate GetPiece_priority2_IHandler ()
		{
			if (cb_piece_priority2_I == null)
				cb_piece_priority2_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_Piece_priority2_I);
			return cb_piece_priority2_I;
		}

		static int n_Piece_priority2_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Piece_priority2 (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='piece_priority2' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("piece_priority2", "(I)I", "GetPiece_priority2_IHandler")]
		public virtual unsafe int Piece_priority2 (int index)
		{
			const string __id = "piece_priority2.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_piece_priority2_II;
#pragma warning disable 0169
		static Delegate GetPiece_priority2_IIHandler ()
		{
			if (cb_piece_priority2_II == null)
				cb_piece_priority2_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_Piece_priority2_II);
			return cb_piece_priority2_II;
		}

		static void n_Piece_priority2_II (IntPtr jnienv, IntPtr native__this, int index, int priority)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Piece_priority2 (index, priority);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='piece_priority2' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("piece_priority2", "(II)V", "GetPiece_priority2_IIHandler")]
		public virtual unsafe void Piece_priority2 (int index, int priority)
		{
			const string __id = "piece_priority2.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (priority);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_prioritize_files2_Lcom_frostwire_jlibtorrent_swig_int_vector_;
#pragma warning disable 0169
		static Delegate GetPrioritize_files2_Lcom_frostwire_jlibtorrent_swig_int_vector_Handler ()
		{
			if (cb_prioritize_files2_Lcom_frostwire_jlibtorrent_swig_int_vector_ == null)
				cb_prioritize_files2_Lcom_frostwire_jlibtorrent_swig_int_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Prioritize_files2_Lcom_frostwire_jlibtorrent_swig_int_vector_);
			return cb_prioritize_files2_Lcom_frostwire_jlibtorrent_swig_int_vector_;
		}

		static void n_Prioritize_files2_Lcom_frostwire_jlibtorrent_swig_int_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_files)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Int_vector files = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Int_vector> (native_files, JniHandleOwnership.DoNotTransfer);
			__this.Prioritize_files2 (files);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='prioritize_files2' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.int_vector']]"
		[Register ("prioritize_files2", "(Lcom/frostwire/jlibtorrent/swig/int_vector;)V", "GetPrioritize_files2_Lcom_frostwire_jlibtorrent_swig_int_vector_Handler")]
		public virtual unsafe void Prioritize_files2 (global::FrostWire.Libtorrent.Swig.Int_vector files)
		{
			const string __id = "prioritize_files2.(Lcom/frostwire/jlibtorrent/swig/int_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((files == null) ? IntPtr.Zero : ((global::Java.Lang.Object) files).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_prioritize_pieces2_Lcom_frostwire_jlibtorrent_swig_int_vector_;
#pragma warning disable 0169
		static Delegate GetPrioritize_pieces2_Lcom_frostwire_jlibtorrent_swig_int_vector_Handler ()
		{
			if (cb_prioritize_pieces2_Lcom_frostwire_jlibtorrent_swig_int_vector_ == null)
				cb_prioritize_pieces2_Lcom_frostwire_jlibtorrent_swig_int_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Prioritize_pieces2_Lcom_frostwire_jlibtorrent_swig_int_vector_);
			return cb_prioritize_pieces2_Lcom_frostwire_jlibtorrent_swig_int_vector_;
		}

		static void n_Prioritize_pieces2_Lcom_frostwire_jlibtorrent_swig_int_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pieces)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Int_vector pieces = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Int_vector> (native_pieces, JniHandleOwnership.DoNotTransfer);
			__this.Prioritize_pieces2 (pieces);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='prioritize_pieces2' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.int_vector']]"
		[Register ("prioritize_pieces2", "(Lcom/frostwire/jlibtorrent/swig/int_vector;)V", "GetPrioritize_pieces2_Lcom_frostwire_jlibtorrent_swig_int_vector_Handler")]
		public virtual unsafe void Prioritize_pieces2 (global::FrostWire.Libtorrent.Swig.Int_vector pieces)
		{
			const string __id = "prioritize_pieces2.(Lcom/frostwire/jlibtorrent/swig/int_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pieces == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pieces).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_prioritize_pieces2_Lcom_frostwire_jlibtorrent_swig_piece_index_int_pair_vector_;
#pragma warning disable 0169
		static Delegate GetPrioritize_pieces2_Lcom_frostwire_jlibtorrent_swig_piece_index_int_pair_vector_Handler ()
		{
			if (cb_prioritize_pieces2_Lcom_frostwire_jlibtorrent_swig_piece_index_int_pair_vector_ == null)
				cb_prioritize_pieces2_Lcom_frostwire_jlibtorrent_swig_piece_index_int_pair_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Prioritize_pieces2_Lcom_frostwire_jlibtorrent_swig_piece_index_int_pair_vector_);
			return cb_prioritize_pieces2_Lcom_frostwire_jlibtorrent_swig_piece_index_int_pair_vector_;
		}

		static void n_Prioritize_pieces2_Lcom_frostwire_jlibtorrent_swig_piece_index_int_pair_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pieces)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Piece_index_int_pair_vector pieces = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_int_pair_vector> (native_pieces, JniHandleOwnership.DoNotTransfer);
			__this.Prioritize_pieces2 (pieces);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='prioritize_pieces2' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.piece_index_int_pair_vector']]"
		[Register ("prioritize_pieces2", "(Lcom/frostwire/jlibtorrent/swig/piece_index_int_pair_vector;)V", "GetPrioritize_pieces2_Lcom_frostwire_jlibtorrent_swig_piece_index_int_pair_vector_Handler")]
		public virtual unsafe void Prioritize_pieces2 (global::FrostWire.Libtorrent.Swig.Piece_index_int_pair_vector pieces)
		{
			const string __id = "prioritize_pieces2.(Lcom/frostwire/jlibtorrent/swig/piece_index_int_pair_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pieces == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pieces).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_queue_position2;
#pragma warning disable 0169
		static Delegate GetQueue_position2Handler ()
		{
			if (cb_queue_position2 == null)
				cb_queue_position2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Queue_position2);
			return cb_queue_position2;
		}

		static int n_Queue_position2 (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Queue_position2 ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='queue_position2' and count(parameter)=0]"
		[Register ("queue_position2", "()I", "GetQueue_position2Handler")]
		public virtual unsafe int Queue_position2 ()
		{
			const string __id = "queue_position2.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_queue_position_bottom;
#pragma warning disable 0169
		static Delegate GetQueue_position_bottomHandler ()
		{
			if (cb_queue_position_bottom == null)
				cb_queue_position_bottom = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Queue_position_bottom);
			return cb_queue_position_bottom;
		}

		static void n_Queue_position_bottom (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Queue_position_bottom ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='queue_position_bottom' and count(parameter)=0]"
		[Register ("queue_position_bottom", "()V", "GetQueue_position_bottomHandler")]
		public virtual unsafe void Queue_position_bottom ()
		{
			const string __id = "queue_position_bottom.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_queue_position_down;
#pragma warning disable 0169
		static Delegate GetQueue_position_downHandler ()
		{
			if (cb_queue_position_down == null)
				cb_queue_position_down = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Queue_position_down);
			return cb_queue_position_down;
		}

		static void n_Queue_position_down (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Queue_position_down ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='queue_position_down' and count(parameter)=0]"
		[Register ("queue_position_down", "()V", "GetQueue_position_downHandler")]
		public virtual unsafe void Queue_position_down ()
		{
			const string __id = "queue_position_down.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_queue_position_set2_I;
#pragma warning disable 0169
		static Delegate GetQueue_position_set2_IHandler ()
		{
			if (cb_queue_position_set2_I == null)
				cb_queue_position_set2_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Queue_position_set2_I);
			return cb_queue_position_set2_I;
		}

		static void n_Queue_position_set2_I (IntPtr jnienv, IntPtr native__this, int p)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Queue_position_set2 (p);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='queue_position_set2' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("queue_position_set2", "(I)V", "GetQueue_position_set2_IHandler")]
		public virtual unsafe void Queue_position_set2 (int p)
		{
			const string __id = "queue_position_set2.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_queue_position_top;
#pragma warning disable 0169
		static Delegate GetQueue_position_topHandler ()
		{
			if (cb_queue_position_top == null)
				cb_queue_position_top = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Queue_position_top);
			return cb_queue_position_top;
		}

		static void n_Queue_position_top (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Queue_position_top ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='queue_position_top' and count(parameter)=0]"
		[Register ("queue_position_top", "()V", "GetQueue_position_topHandler")]
		public virtual unsafe void Queue_position_top ()
		{
			const string __id = "queue_position_top.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_queue_position_up;
#pragma warning disable 0169
		static Delegate GetQueue_position_upHandler ()
		{
			if (cb_queue_position_up == null)
				cb_queue_position_up = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Queue_position_up);
			return cb_queue_position_up;
		}

		static void n_Queue_position_up (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Queue_position_up ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='queue_position_up' and count(parameter)=0]"
		[Register ("queue_position_up", "()V", "GetQueue_position_upHandler")]
		public virtual unsafe void Queue_position_up ()
		{
			const string __id = "queue_position_up.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_read_piece_I;
#pragma warning disable 0169
		static Delegate GetRead_piece_IHandler ()
		{
			if (cb_read_piece_I == null)
				cb_read_piece_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Read_piece_I);
			return cb_read_piece_I;
		}

		static void n_Read_piece_I (IntPtr jnienv, IntPtr native__this, int piece)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Read_piece (piece);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='read_piece' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("read_piece", "(I)V", "GetRead_piece_IHandler")]
		public virtual unsafe void Read_piece (int piece)
		{
			const string __id = "read_piece.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (piece);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_remove_http_seed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_http_seed_Ljava_lang_String_Handler ()
		{
			if (cb_remove_http_seed_Ljava_lang_String_ == null)
				cb_remove_http_seed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_http_seed_Ljava_lang_String_);
			return cb_remove_http_seed_Ljava_lang_String_;
		}

		static void n_Remove_http_seed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.Remove_http_seed (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='remove_http_seed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove_http_seed", "(Ljava/lang/String;)V", "GetRemove_http_seed_Ljava_lang_String_Handler")]
		public virtual unsafe void Remove_http_seed (string url)
		{
			const string __id = "remove_http_seed.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_remove_url_seed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_url_seed_Ljava_lang_String_Handler ()
		{
			if (cb_remove_url_seed_Ljava_lang_String_ == null)
				cb_remove_url_seed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_url_seed_Ljava_lang_String_);
			return cb_remove_url_seed_Ljava_lang_String_;
		}

		static void n_Remove_url_seed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.Remove_url_seed (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='remove_url_seed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove_url_seed", "(Ljava/lang/String;)V", "GetRemove_url_seed_Ljava_lang_String_Handler")]
		public virtual unsafe void Remove_url_seed (string url)
		{
			const string __id = "remove_url_seed.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_rename_file_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRename_file_ILjava_lang_String_Handler ()
		{
			if (cb_rename_file_ILjava_lang_String_ == null)
				cb_rename_file_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Rename_file_ILjava_lang_String_);
			return cb_rename_file_ILjava_lang_String_;
		}

		static void n_Rename_file_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_new_name)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string new_name = JNIEnv.GetString (native_new_name, JniHandleOwnership.DoNotTransfer);
			__this.Rename_file (index, new_name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='rename_file' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("rename_file", "(ILjava/lang/String;)V", "GetRename_file_ILjava_lang_String_Handler")]
		public virtual unsafe void Rename_file (int index, string new_name)
		{
			const string __id = "rename_file.(ILjava/lang/String;)V";
			IntPtr native_new_name = JNIEnv.NewString (new_name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (native_new_name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_new_name);
			}
		}

		static Delegate cb_replace_trackers_Lcom_frostwire_jlibtorrent_swig_announce_entry_vector_;
#pragma warning disable 0169
		static Delegate GetReplace_trackers_Lcom_frostwire_jlibtorrent_swig_announce_entry_vector_Handler ()
		{
			if (cb_replace_trackers_Lcom_frostwire_jlibtorrent_swig_announce_entry_vector_ == null)
				cb_replace_trackers_Lcom_frostwire_jlibtorrent_swig_announce_entry_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Replace_trackers_Lcom_frostwire_jlibtorrent_swig_announce_entry_vector_);
			return cb_replace_trackers_Lcom_frostwire_jlibtorrent_swig_announce_entry_vector_;
		}

		static void n_Replace_trackers_Lcom_frostwire_jlibtorrent_swig_announce_entry_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_arg0)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Announce_entry_vector arg0 = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry_vector> (native_arg0, JniHandleOwnership.DoNotTransfer);
			__this.Replace_trackers (arg0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='replace_trackers' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.announce_entry_vector']]"
		[Register ("replace_trackers", "(Lcom/frostwire/jlibtorrent/swig/announce_entry_vector;)V", "GetReplace_trackers_Lcom_frostwire_jlibtorrent_swig_announce_entry_vector_Handler")]
		public virtual unsafe void Replace_trackers (global::FrostWire.Libtorrent.Swig.Announce_entry_vector arg0)
		{
			const string __id = "replace_trackers.(Lcom/frostwire/jlibtorrent/swig/announce_entry_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((arg0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reset_piece_deadline_I;
#pragma warning disable 0169
		static Delegate GetReset_piece_deadline_IHandler ()
		{
			if (cb_reset_piece_deadline_I == null)
				cb_reset_piece_deadline_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Reset_piece_deadline_I);
			return cb_reset_piece_deadline_I;
		}

		static void n_Reset_piece_deadline_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset_piece_deadline (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='reset_piece_deadline' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reset_piece_deadline", "(I)V", "GetReset_piece_deadline_IHandler")]
		public virtual unsafe void Reset_piece_deadline (int index)
		{
			const string __id = "reset_piece_deadline.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_resume;
#pragma warning disable 0169
		static Delegate GetResumeHandler ()
		{
			if (cb_resume == null)
				cb_resume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Resume);
			return cb_resume;
		}

		static void n_Resume (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			const string __id = "resume.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_save_resume_data;
#pragma warning disable 0169
		static Delegate GetSave_resume_dataHandler ()
		{
			if (cb_save_resume_data == null)
				cb_save_resume_data = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Save_resume_data);
			return cb_save_resume_data;
		}

		static void n_Save_resume_data (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Save_resume_data ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='save_resume_data' and count(parameter)=0]"
		[Register ("save_resume_data", "()V", "GetSave_resume_dataHandler")]
		public virtual unsafe void Save_resume_data ()
		{
			const string __id = "save_resume_data.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_save_resume_data_Lcom_frostwire_jlibtorrent_swig_resume_data_flags_t_;
#pragma warning disable 0169
		static Delegate GetSave_resume_data_Lcom_frostwire_jlibtorrent_swig_resume_data_flags_t_Handler ()
		{
			if (cb_save_resume_data_Lcom_frostwire_jlibtorrent_swig_resume_data_flags_t_ == null)
				cb_save_resume_data_Lcom_frostwire_jlibtorrent_swig_resume_data_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Save_resume_data_Lcom_frostwire_jlibtorrent_swig_resume_data_flags_t_);
			return cb_save_resume_data_Lcom_frostwire_jlibtorrent_swig_resume_data_flags_t_;
		}

		static void n_Save_resume_data_Lcom_frostwire_jlibtorrent_swig_resume_data_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_flags)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Resume_data_flags_t flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Resume_data_flags_t> (native_flags, JniHandleOwnership.DoNotTransfer);
			__this.Save_resume_data (flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='save_resume_data' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.resume_data_flags_t']]"
		[Register ("save_resume_data", "(Lcom/frostwire/jlibtorrent/swig/resume_data_flags_t;)V", "GetSave_resume_data_Lcom_frostwire_jlibtorrent_swig_resume_data_flags_t_Handler")]
		public virtual unsafe void Save_resume_data (global::FrostWire.Libtorrent.Swig.Resume_data_flags_t flags)
		{
			const string __id = "save_resume_data.(Lcom/frostwire/jlibtorrent/swig/resume_data_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_scrape_tracker;
#pragma warning disable 0169
		static Delegate GetScrape_trackerHandler ()
		{
			if (cb_scrape_tracker == null)
				cb_scrape_tracker = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Scrape_tracker);
			return cb_scrape_tracker;
		}

		static void n_Scrape_tracker (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Scrape_tracker ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='scrape_tracker' and count(parameter)=0]"
		[Register ("scrape_tracker", "()V", "GetScrape_trackerHandler")]
		public virtual unsafe void Scrape_tracker ()
		{
			const string __id = "scrape_tracker.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_scrape_tracker_I;
#pragma warning disable 0169
		static Delegate GetScrape_tracker_IHandler ()
		{
			if (cb_scrape_tracker_I == null)
				cb_scrape_tracker_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Scrape_tracker_I);
			return cb_scrape_tracker_I;
		}

		static void n_Scrape_tracker_I (IntPtr jnienv, IntPtr native__this, int idx)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Scrape_tracker (idx);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='scrape_tracker' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("scrape_tracker", "(I)V", "GetScrape_tracker_IHandler")]
		public virtual unsafe void Scrape_tracker (int idx)
		{
			const string __id = "scrape_tracker.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (idx);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_download_limit_I;
#pragma warning disable 0169
		static Delegate GetSet_download_limit_IHandler ()
		{
			if (cb_set_download_limit_I == null)
				cb_set_download_limit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Set_download_limit_I);
			return cb_set_download_limit_I;
		}

		static void n_Set_download_limit_I (IntPtr jnienv, IntPtr native__this, int limit)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_download_limit (limit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='set_download_limit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("set_download_limit", "(I)V", "GetSet_download_limit_IHandler")]
		public virtual unsafe void Set_download_limit (int limit)
		{
			const string __id = "set_download_limit.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_;
#pragma warning disable 0169
		static Delegate GetSet_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_Handler ()
		{
			if (cb_set_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_ == null)
				cb_set_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_);
			return cb_set_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_;
		}

		static void n_Set_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_flags)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Torrent_flags_t flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (native_flags, JniHandleOwnership.DoNotTransfer);
			__this.Set_flags (flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='set_flags' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_flags_t']]"
		[Register ("set_flags", "(Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;)V", "GetSet_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_Handler")]
		public virtual unsafe void Set_flags (global::FrostWire.Libtorrent.Swig.Torrent_flags_t flags)
		{
			const string __id = "set_flags.(Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_;
#pragma warning disable 0169
		static Delegate GetSet_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_Handler ()
		{
			if (cb_set_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_ == null)
				cb_set_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_);
			return cb_set_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_;
		}

		static void n_Set_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_flags, IntPtr native_mask)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Torrent_flags_t flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (native_flags, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Torrent_flags_t mask = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (native_mask, JniHandleOwnership.DoNotTransfer);
			__this.Set_flags (flags, mask);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='set_flags' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_flags_t'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.torrent_flags_t']]"
		[Register ("set_flags", "(Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;)V", "GetSet_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_Handler")]
		public virtual unsafe void Set_flags (global::FrostWire.Libtorrent.Swig.Torrent_flags_t flags, global::FrostWire.Libtorrent.Swig.Torrent_flags_t mask)
		{
			const string __id = "set_flags.(Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				__args [1] = new JniArgumentValue ((mask == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mask).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_max_connections_I;
#pragma warning disable 0169
		static Delegate GetSet_max_connections_IHandler ()
		{
			if (cb_set_max_connections_I == null)
				cb_set_max_connections_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Set_max_connections_I);
			return cb_set_max_connections_I;
		}

		static void n_Set_max_connections_I (IntPtr jnienv, IntPtr native__this, int max_connections)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_max_connections (max_connections);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='set_max_connections' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("set_max_connections", "(I)V", "GetSet_max_connections_IHandler")]
		public virtual unsafe void Set_max_connections (int max_connections)
		{
			const string __id = "set_max_connections.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (max_connections);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_max_uploads_I;
#pragma warning disable 0169
		static Delegate GetSet_max_uploads_IHandler ()
		{
			if (cb_set_max_uploads_I == null)
				cb_set_max_uploads_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Set_max_uploads_I);
			return cb_set_max_uploads_I;
		}

		static void n_Set_max_uploads_I (IntPtr jnienv, IntPtr native__this, int max_uploads)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_max_uploads (max_uploads);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='set_max_uploads' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("set_max_uploads", "(I)V", "GetSet_max_uploads_IHandler")]
		public virtual unsafe void Set_max_uploads (int max_uploads)
		{
			const string __id = "set_max_uploads.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (max_uploads);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_piece_deadline_II;
#pragma warning disable 0169
		static Delegate GetSet_piece_deadline_IIHandler ()
		{
			if (cb_set_piece_deadline_II == null)
				cb_set_piece_deadline_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_Set_piece_deadline_II);
			return cb_set_piece_deadline_II;
		}

		static void n_Set_piece_deadline_II (IntPtr jnienv, IntPtr native__this, int index, int deadline)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_piece_deadline (index, deadline);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='set_piece_deadline' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("set_piece_deadline", "(II)V", "GetSet_piece_deadline_IIHandler")]
		public virtual unsafe void Set_piece_deadline (int index, int deadline)
		{
			const string __id = "set_piece_deadline.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (deadline);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_piece_deadline_IILcom_frostwire_jlibtorrent_swig_deadline_flags_t_;
#pragma warning disable 0169
		static Delegate GetSet_piece_deadline_IILcom_frostwire_jlibtorrent_swig_deadline_flags_t_Handler ()
		{
			if (cb_set_piece_deadline_IILcom_frostwire_jlibtorrent_swig_deadline_flags_t_ == null)
				cb_set_piece_deadline_IILcom_frostwire_jlibtorrent_swig_deadline_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_Set_piece_deadline_IILcom_frostwire_jlibtorrent_swig_deadline_flags_t_);
			return cb_set_piece_deadline_IILcom_frostwire_jlibtorrent_swig_deadline_flags_t_;
		}

		static void n_Set_piece_deadline_IILcom_frostwire_jlibtorrent_swig_deadline_flags_t_ (IntPtr jnienv, IntPtr native__this, int index, int deadline, IntPtr native_flags)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Deadline_flags_t flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Deadline_flags_t> (native_flags, JniHandleOwnership.DoNotTransfer);
			__this.Set_piece_deadline (index, deadline, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='set_piece_deadline' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.deadline_flags_t']]"
		[Register ("set_piece_deadline", "(IILcom/frostwire/jlibtorrent/swig/deadline_flags_t;)V", "GetSet_piece_deadline_IILcom_frostwire_jlibtorrent_swig_deadline_flags_t_Handler")]
		public virtual unsafe void Set_piece_deadline (int index, int deadline, global::FrostWire.Libtorrent.Swig.Deadline_flags_t flags)
		{
			const string __id = "set_piece_deadline.(IILcom/frostwire/jlibtorrent/swig/deadline_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (deadline);
				__args [2] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_ssl_certificate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSet_ssl_certificate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_set_ssl_certificate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_set_ssl_certificate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_ssl_certificate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_set_ssl_certificate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Set_ssl_certificate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_certificate, IntPtr native_private_key, IntPtr native_dh_params)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string certificate = JNIEnv.GetString (native_certificate, JniHandleOwnership.DoNotTransfer);
			string private_key = JNIEnv.GetString (native_private_key, JniHandleOwnership.DoNotTransfer);
			string dh_params = JNIEnv.GetString (native_dh_params, JniHandleOwnership.DoNotTransfer);
			__this.Set_ssl_certificate (certificate, private_key, dh_params);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='set_ssl_certificate' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("set_ssl_certificate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSet_ssl_certificate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Set_ssl_certificate (string certificate, string private_key, string dh_params)
		{
			const string __id = "set_ssl_certificate.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_certificate = JNIEnv.NewString (certificate);
			IntPtr native_private_key = JNIEnv.NewString (private_key);
			IntPtr native_dh_params = JNIEnv.NewString (dh_params);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_certificate);
				__args [1] = new JniArgumentValue (native_private_key);
				__args [2] = new JniArgumentValue (native_dh_params);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_certificate);
				JNIEnv.DeleteLocalRef (native_private_key);
				JNIEnv.DeleteLocalRef (native_dh_params);
			}
		}

		static Delegate cb_set_ssl_certificate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSet_ssl_certificate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_set_ssl_certificate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_set_ssl_certificate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_ssl_certificate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_set_ssl_certificate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Set_ssl_certificate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_certificate, IntPtr native_private_key, IntPtr native_dh_params, IntPtr native_passphrase)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string certificate = JNIEnv.GetString (native_certificate, JniHandleOwnership.DoNotTransfer);
			string private_key = JNIEnv.GetString (native_private_key, JniHandleOwnership.DoNotTransfer);
			string dh_params = JNIEnv.GetString (native_dh_params, JniHandleOwnership.DoNotTransfer);
			string passphrase = JNIEnv.GetString (native_passphrase, JniHandleOwnership.DoNotTransfer);
			__this.Set_ssl_certificate (certificate, private_key, dh_params, passphrase);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='set_ssl_certificate' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("set_ssl_certificate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSet_ssl_certificate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Set_ssl_certificate (string certificate, string private_key, string dh_params, string passphrase)
		{
			const string __id = "set_ssl_certificate.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_certificate = JNIEnv.NewString (certificate);
			IntPtr native_private_key = JNIEnv.NewString (private_key);
			IntPtr native_dh_params = JNIEnv.NewString (dh_params);
			IntPtr native_passphrase = JNIEnv.NewString (passphrase);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_certificate);
				__args [1] = new JniArgumentValue (native_private_key);
				__args [2] = new JniArgumentValue (native_dh_params);
				__args [3] = new JniArgumentValue (native_passphrase);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_certificate);
				JNIEnv.DeleteLocalRef (native_private_key);
				JNIEnv.DeleteLocalRef (native_dh_params);
				JNIEnv.DeleteLocalRef (native_passphrase);
			}
		}

		static Delegate cb_set_ssl_certificate_buffer2_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
#pragma warning disable 0169
		static Delegate GetSet_ssl_certificate_buffer2_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler ()
		{
			if (cb_set_ssl_certificate_buffer2_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_ == null)
				cb_set_ssl_certificate_buffer2_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_ssl_certificate_buffer2_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_);
			return cb_set_ssl_certificate_buffer2_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
		}

		static void n_Set_ssl_certificate_buffer2_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_certificate, IntPtr native_private_key, IntPtr native_dh_params)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector certificate = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_certificate, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector private_key = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_private_key, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector dh_params = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_dh_params, JniHandleOwnership.DoNotTransfer);
			__this.Set_ssl_certificate_buffer2 (certificate, private_key, dh_params);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='set_ssl_certificate_buffer2' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.byte_vector'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("set_ssl_certificate_buffer2", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;)V", "GetSet_ssl_certificate_buffer2_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler")]
		public virtual unsafe void Set_ssl_certificate_buffer2 (global::FrostWire.Libtorrent.Swig.Byte_vector certificate, global::FrostWire.Libtorrent.Swig.Byte_vector private_key, global::FrostWire.Libtorrent.Swig.Byte_vector dh_params)
		{
			const string __id = "set_ssl_certificate_buffer2.(Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;Lcom/frostwire/jlibtorrent/swig/byte_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((certificate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) certificate).Handle);
				__args [1] = new JniArgumentValue ((private_key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) private_key).Handle);
				__args [2] = new JniArgumentValue ((dh_params == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dh_params).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_upload_limit_I;
#pragma warning disable 0169
		static Delegate GetSet_upload_limit_IHandler ()
		{
			if (cb_set_upload_limit_I == null)
				cb_set_upload_limit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Set_upload_limit_I);
			return cb_set_upload_limit_I;
		}

		static void n_Set_upload_limit_I (IntPtr jnienv, IntPtr native__this, int limit)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_upload_limit (limit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='set_upload_limit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("set_upload_limit", "(I)V", "GetSet_upload_limit_IHandler")]
		public virtual unsafe void Set_upload_limit (int limit)
		{
			const string __id = "set_upload_limit.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_status;
#pragma warning disable 0169
		static Delegate GetStatusHandler ()
		{
			if (cb_status == null)
				cb_status = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Status);
			return cb_status;
		}

		static IntPtr n_Status (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Status ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='status' and count(parameter)=0]"
		[Register ("status", "()Lcom/frostwire/jlibtorrent/swig/torrent_status;", "GetStatusHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Torrent_status Status ()
		{
			const string __id = "status.()Lcom/frostwire/jlibtorrent/swig/torrent_status;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_status_Lcom_frostwire_jlibtorrent_swig_status_flags_t_;
#pragma warning disable 0169
		static Delegate GetStatus_Lcom_frostwire_jlibtorrent_swig_status_flags_t_Handler ()
		{
			if (cb_status_Lcom_frostwire_jlibtorrent_swig_status_flags_t_ == null)
				cb_status_Lcom_frostwire_jlibtorrent_swig_status_flags_t_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Status_Lcom_frostwire_jlibtorrent_swig_status_flags_t_);
			return cb_status_Lcom_frostwire_jlibtorrent_swig_status_flags_t_;
		}

		static IntPtr n_Status_Lcom_frostwire_jlibtorrent_swig_status_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_flags)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Status_flags_t flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Status_flags_t> (native_flags, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Status (flags));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='status' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.status_flags_t']]"
		[Register ("status", "(Lcom/frostwire/jlibtorrent/swig/status_flags_t;)Lcom/frostwire/jlibtorrent/swig/torrent_status;", "GetStatus_Lcom_frostwire_jlibtorrent_swig_status_flags_t_Handler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Torrent_status Status (global::FrostWire.Libtorrent.Swig.Status_flags_t flags)
		{
			const string __id = "status.(Lcom/frostwire/jlibtorrent/swig/status_flags_t;)Lcom/frostwire/jlibtorrent/swig/torrent_status;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Torrent_file_ptr ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='torrent_file_ptr' and count(parameter)=0]"
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

		static Delegate cb_trackers;
#pragma warning disable 0169
		static Delegate GetTrackersHandler ()
		{
			if (cb_trackers == null)
				cb_trackers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Trackers);
			return cb_trackers;
		}

		static IntPtr n_Trackers (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Trackers ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='trackers' and count(parameter)=0]"
		[Register ("trackers", "()Lcom/frostwire/jlibtorrent/swig/announce_entry_vector;", "GetTrackersHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Announce_entry_vector Trackers ()
		{
			const string __id = "trackers.()Lcom/frostwire/jlibtorrent/swig/announce_entry_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_unset_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_;
#pragma warning disable 0169
		static Delegate GetUnset_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_Handler ()
		{
			if (cb_unset_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_ == null)
				cb_unset_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Unset_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_);
			return cb_unset_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_;
		}

		static void n_Unset_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_flags)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Torrent_flags_t flags = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (native_flags, JniHandleOwnership.DoNotTransfer);
			__this.Unset_flags (flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='unset_flags' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_flags_t']]"
		[Register ("unset_flags", "(Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;)V", "GetUnset_flags_Lcom_frostwire_jlibtorrent_swig_torrent_flags_t_Handler")]
		public virtual unsafe void Unset_flags (global::FrostWire.Libtorrent.Swig.Torrent_flags_t flags)
		{
			const string __id = "unset_flags.(Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_upload_limit;
#pragma warning disable 0169
		static Delegate GetUpload_limitHandler ()
		{
			if (cb_upload_limit == null)
				cb_upload_limit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Upload_limit);
			return cb_upload_limit;
		}

		static int n_Upload_limit (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Torrent_handle __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_handle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Upload_limit ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='torrent_handle']/method[@name='upload_limit' and count(parameter)=0]"
		[Register ("upload_limit", "()I", "GetUpload_limitHandler")]
		public virtual unsafe int Upload_limit ()
		{
			const string __id = "upload_limit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
