using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentFlags']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/TorrentFlags", DoNotGenerateAcw=true)]
	public sealed partial class TorrentFlags : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentFlags']/field[@name='ALL']"
		[Register ("ALL")]
		public static global::FrostWire.Libtorrent.Swig.Torrent_flags_t All {
			get {
				const string __id = "ALL.Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentFlags']/field[@name='APPLY_IP_FILTER']"
		[Register ("APPLY_IP_FILTER")]
		public static global::FrostWire.Libtorrent.Swig.Torrent_flags_t ApplyIpFilter {
			get {
				const string __id = "APPLY_IP_FILTER.Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentFlags']/field[@name='AUTO_MANAGED']"
		[Register ("AUTO_MANAGED")]
		public static global::FrostWire.Libtorrent.Swig.Torrent_flags_t AutoManaged {
			get {
				const string __id = "AUTO_MANAGED.Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentFlags']/field[@name='DUPLICATE_IS_ERROR']"
		[Register ("DUPLICATE_IS_ERROR")]
		public static global::FrostWire.Libtorrent.Swig.Torrent_flags_t DuplicateIsError {
			get {
				const string __id = "DUPLICATE_IS_ERROR.Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentFlags']/field[@name='NEED_SAVE_RESUME']"
		[Register ("NEED_SAVE_RESUME")]
		public static global::FrostWire.Libtorrent.Swig.Torrent_flags_t NeedSaveResume {
			get {
				const string __id = "NEED_SAVE_RESUME.Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentFlags']/field[@name='OVERRIDE_TRACKERS']"
		[Register ("OVERRIDE_TRACKERS")]
		public static global::FrostWire.Libtorrent.Swig.Torrent_flags_t OverrideTrackers {
			get {
				const string __id = "OVERRIDE_TRACKERS.Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentFlags']/field[@name='OVERRIDE_WEB_SEEDS']"
		[Register ("OVERRIDE_WEB_SEEDS")]
		public static global::FrostWire.Libtorrent.Swig.Torrent_flags_t OverrideWebSeeds {
			get {
				const string __id = "OVERRIDE_WEB_SEEDS.Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentFlags']/field[@name='PAUSED']"
		[Register ("PAUSED")]
		public static global::FrostWire.Libtorrent.Swig.Torrent_flags_t Paused {
			get {
				const string __id = "PAUSED.Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentFlags']/field[@name='SEED_MODE']"
		[Register ("SEED_MODE")]
		public static global::FrostWire.Libtorrent.Swig.Torrent_flags_t SeedMode {
			get {
				const string __id = "SEED_MODE.Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentFlags']/field[@name='SEQUENTIAL_DOWNLOAD']"
		[Register ("SEQUENTIAL_DOWNLOAD")]
		public static global::FrostWire.Libtorrent.Swig.Torrent_flags_t SequentialDownload {
			get {
				const string __id = "SEQUENTIAL_DOWNLOAD.Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentFlags']/field[@name='SHARE_MODE']"
		[Register ("SHARE_MODE")]
		public static global::FrostWire.Libtorrent.Swig.Torrent_flags_t ShareMode {
			get {
				const string __id = "SHARE_MODE.Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentFlags']/field[@name='STOP_WHEN_READY']"
		[Register ("STOP_WHEN_READY")]
		public static global::FrostWire.Libtorrent.Swig.Torrent_flags_t StopWhenReady {
			get {
				const string __id = "STOP_WHEN_READY.Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentFlags']/field[@name='SUPER_SEEDING']"
		[Register ("SUPER_SEEDING")]
		public static global::FrostWire.Libtorrent.Swig.Torrent_flags_t SuperSeeding {
			get {
				const string __id = "SUPER_SEEDING.Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentFlags']/field[@name='UPDATE_SUBSCRIBE']"
		[Register ("UPDATE_SUBSCRIBE")]
		public static global::FrostWire.Libtorrent.Swig.Torrent_flags_t UpdateSubscribe {
			get {
				const string __id = "UPDATE_SUBSCRIBE.Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentFlags']/field[@name='UPLOAD_MODE']"
		[Register ("UPLOAD_MODE")]
		public static global::FrostWire.Libtorrent.Swig.Torrent_flags_t UploadMode {
			get {
				const string __id = "UPLOAD_MODE.Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/TorrentFlags", typeof (TorrentFlags));
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

		internal TorrentFlags (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
