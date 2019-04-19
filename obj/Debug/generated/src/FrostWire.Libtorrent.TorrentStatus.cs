using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/TorrentStatus", DoNotGenerateAcw=true)]
	public sealed partial class TorrentStatus : global::Java.Lang.Object, global::Java.Lang.ICloneable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus.State']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/TorrentStatus$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus.State']/field[@name='ALLOCATING']"
			[Register ("ALLOCATING")]
			public static global::FrostWire.Libtorrent.TorrentStatus.State Allocating {
				get {
					const string __id = "ALLOCATING.Lcom/frostwire/jlibtorrent/TorrentStatus$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStatus.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus.State']/field[@name='CHECKING_FILES']"
			[Register ("CHECKING_FILES")]
			public static global::FrostWire.Libtorrent.TorrentStatus.State CheckingFiles {
				get {
					const string __id = "CHECKING_FILES.Lcom/frostwire/jlibtorrent/TorrentStatus$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStatus.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus.State']/field[@name='CHECKING_RESUME_DATA']"
			[Register ("CHECKING_RESUME_DATA")]
			public static global::FrostWire.Libtorrent.TorrentStatus.State CheckingResumeData {
				get {
					const string __id = "CHECKING_RESUME_DATA.Lcom/frostwire/jlibtorrent/TorrentStatus$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStatus.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus.State']/field[@name='DOWNLOADING']"
			[Register ("DOWNLOADING")]
			public static global::FrostWire.Libtorrent.TorrentStatus.State Downloading {
				get {
					const string __id = "DOWNLOADING.Lcom/frostwire/jlibtorrent/TorrentStatus$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStatus.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus.State']/field[@name='DOWNLOADING_METADATA']"
			[Register ("DOWNLOADING_METADATA")]
			public static global::FrostWire.Libtorrent.TorrentStatus.State DownloadingMetadata {
				get {
					const string __id = "DOWNLOADING_METADATA.Lcom/frostwire/jlibtorrent/TorrentStatus$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStatus.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus.State']/field[@name='FINISHED']"
			[Register ("FINISHED")]
			public static global::FrostWire.Libtorrent.TorrentStatus.State Finished {
				get {
					const string __id = "FINISHED.Lcom/frostwire/jlibtorrent/TorrentStatus$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStatus.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus.State']/field[@name='SEEDING']"
			[Register ("SEEDING")]
			public static global::FrostWire.Libtorrent.TorrentStatus.State Seeding {
				get {
					const string __id = "SEEDING.Lcom/frostwire/jlibtorrent/TorrentStatus$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStatus.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus.State']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::FrostWire.Libtorrent.TorrentStatus.State Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/frostwire/jlibtorrent/TorrentStatus$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStatus.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/TorrentStatus$State", typeof (State));
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

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus.State']/method[@name='fromSwig' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromSwig", "(I)Lcom/frostwire/jlibtorrent/TorrentStatus$State;", "")]
			public static unsafe global::FrostWire.Libtorrent.TorrentStatus.State FromSwig (int swigValue)
			{
				const string __id = "fromSwig.(I)Lcom/frostwire/jlibtorrent/TorrentStatus$State;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStatus.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus.State']/method[@name='swig' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/TorrentStatus$State;", "")]
			public static unsafe global::FrostWire.Libtorrent.TorrentStatus.State ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/TorrentStatus$State;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStatus.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/frostwire/jlibtorrent/TorrentStatus$State;", "")]
			public static unsafe global::FrostWire.Libtorrent.TorrentStatus.State[] Values ()
			{
				const string __id = "values.()[Lcom/frostwire/jlibtorrent/TorrentStatus$State;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::FrostWire.Libtorrent.TorrentStatus.State[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.TorrentStatus.State));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/TorrentStatus", typeof (TorrentStatus));
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

		internal TorrentStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/constructor[@name='TorrentStatus' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_status']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/torrent_status;)V", "")]
		public unsafe TorrentStatus (global::FrostWire.Libtorrent.Swig.Torrent_status ts)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/torrent_status;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ts == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ts).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe bool HasIncoming {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='hasIncoming' and count(parameter)=0]"
			[Register ("hasIncoming", "()Z", "GetHasIncomingHandler")]
			get {
				const string __id = "hasIncoming.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool HasMetadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='hasMetadata' and count(parameter)=0]"
			[Register ("hasMetadata", "()Z", "GetHasMetadataHandler")]
			get {
				const string __id = "hasMetadata.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsFinished {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='isFinished' and count(parameter)=0]"
			[Register ("isFinished", "()Z", "GetIsFinishedHandler")]
			get {
				const string __id = "isFinished.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsMovingStorage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='isMovingStorage' and count(parameter)=0]"
			[Register ("isMovingStorage", "()Z", "GetIsMovingStorageHandler")]
			get {
				const string __id = "isMovingStorage.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsSeeding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='isSeeding' and count(parameter)=0]"
			[Register ("isSeeding", "()Z", "GetIsSeedingHandler")]
			get {
				const string __id = "isSeeding.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='activeDuration' and count(parameter)=0]"
		[Register ("activeDuration", "()J", "")]
		public unsafe long ActiveDuration ()
		{
			const string __id = "activeDuration.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='addedTime' and count(parameter)=0]"
		[Register ("addedTime", "()J", "")]
		public unsafe long AddedTime ()
		{
			const string __id = "addedTime.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='allTimeDownload' and count(parameter)=0]"
		[Register ("allTimeDownload", "()J", "")]
		public unsafe long AllTimeDownload ()
		{
			const string __id = "allTimeDownload.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='allTimeUpload' and count(parameter)=0]"
		[Register ("allTimeUpload", "()J", "")]
		public unsafe long AllTimeUpload ()
		{
			const string __id = "allTimeUpload.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='announcingToDht' and count(parameter)=0]"
		[Register ("announcingToDht", "()Z", "")]
		public unsafe bool AnnouncingToDht ()
		{
			const string __id = "announcingToDht.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='announcingToLsd' and count(parameter)=0]"
		[Register ("announcingToLsd", "()Z", "")]
		public unsafe bool AnnouncingToLsd ()
		{
			const string __id = "announcingToLsd.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='announcingToTrackers' and count(parameter)=0]"
		[Register ("announcingToTrackers", "()Z", "")]
		public unsafe bool AnnouncingToTrackers ()
		{
			const string __id = "announcingToTrackers.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='blockSize' and count(parameter)=0]"
		[Register ("blockSize", "()I", "")]
		public unsafe int BlockSize ()
		{
			const string __id = "blockSize.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='completedTime' and count(parameter)=0]"
		[Register ("completedTime", "()J", "")]
		public unsafe long CompletedTime ()
		{
			const string __id = "completedTime.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='connectCandidates' and count(parameter)=0]"
		[Register ("connectCandidates", "()I", "")]
		public unsafe int ConnectCandidates ()
		{
			const string __id = "connectCandidates.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='connectionsLimit' and count(parameter)=0]"
		[Register ("connectionsLimit", "()I", "")]
		public unsafe int ConnectionsLimit ()
		{
			const string __id = "connectionsLimit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='currentTracker' and count(parameter)=0]"
		[Register ("currentTracker", "()Ljava/lang/String;", "")]
		public unsafe string CurrentTracker ()
		{
			const string __id = "currentTracker.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='distributedCopies' and count(parameter)=0]"
		[Register ("distributedCopies", "()F", "")]
		public unsafe float DistributedCopies ()
		{
			const string __id = "distributedCopies.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='distributedFraction' and count(parameter)=0]"
		[Register ("distributedFraction", "()I", "")]
		public unsafe int DistributedFraction ()
		{
			const string __id = "distributedFraction.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='distributedFullCopies' and count(parameter)=0]"
		[Register ("distributedFullCopies", "()I", "")]
		public unsafe int DistributedFullCopies ()
		{
			const string __id = "distributedFullCopies.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='downBandwidthQueue' and count(parameter)=0]"
		[Register ("downBandwidthQueue", "()I", "")]
		public unsafe int DownBandwidthQueue ()
		{
			const string __id = "downBandwidthQueue.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='downloadPayloadRate' and count(parameter)=0]"
		[Register ("downloadPayloadRate", "()I", "")]
		public unsafe int DownloadPayloadRate ()
		{
			const string __id = "downloadPayloadRate.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='downloadRate' and count(parameter)=0]"
		[Register ("downloadRate", "()I", "")]
		public unsafe int DownloadRate ()
		{
			const string __id = "downloadRate.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='errorCode' and count(parameter)=0]"
		[Register ("errorCode", "()Lcom/frostwire/jlibtorrent/ErrorCode;", "")]
		public unsafe global::FrostWire.Libtorrent.ErrorCode ErrorCode ()
		{
			const string __id = "errorCode.()Lcom/frostwire/jlibtorrent/ErrorCode;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.ErrorCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='finishedDuration' and count(parameter)=0]"
		[Register ("finishedDuration", "()J", "")]
		public unsafe long FinishedDuration ()
		{
			const string __id = "finishedDuration.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='flags' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='infoHash' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='lastDownload' and count(parameter)=0]"
		[Register ("lastDownload", "()J", "")]
		public unsafe long LastDownload ()
		{
			const string __id = "lastDownload.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='lastSeenComplete' and count(parameter)=0]"
		[Register ("lastSeenComplete", "()J", "")]
		public unsafe long LastSeenComplete ()
		{
			const string __id = "lastSeenComplete.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='lastUpload' and count(parameter)=0]"
		[Register ("lastUpload", "()J", "")]
		public unsafe long LastUpload ()
		{
			const string __id = "lastUpload.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='listPeers' and count(parameter)=0]"
		[Register ("listPeers", "()I", "")]
		public unsafe int ListPeers ()
		{
			const string __id = "listPeers.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='listSeeds' and count(parameter)=0]"
		[Register ("listSeeds", "()I", "")]
		public unsafe int ListSeeds ()
		{
			const string __id = "listSeeds.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='name' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='needSaveResume' and count(parameter)=0]"
		[Register ("needSaveResume", "()Z", "")]
		public unsafe bool NeedSaveResume ()
		{
			const string __id = "needSaveResume.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='nextAnnounce' and count(parameter)=0]"
		[Register ("nextAnnounce", "()J", "")]
		public unsafe long NextAnnounce ()
		{
			const string __id = "nextAnnounce.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='numComplete' and count(parameter)=0]"
		[Register ("numComplete", "()I", "")]
		public unsafe int NumComplete ()
		{
			const string __id = "numComplete.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='numConnections' and count(parameter)=0]"
		[Register ("numConnections", "()I", "")]
		public unsafe int NumConnections ()
		{
			const string __id = "numConnections.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='numIncomplete' and count(parameter)=0]"
		[Register ("numIncomplete", "()I", "")]
		public unsafe int NumIncomplete ()
		{
			const string __id = "numIncomplete.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='numPeers' and count(parameter)=0]"
		[Register ("numPeers", "()I", "")]
		public unsafe int NumPeers ()
		{
			const string __id = "numPeers.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='numPieces' and count(parameter)=0]"
		[Register ("numPieces", "()I", "")]
		public unsafe int NumPieces ()
		{
			const string __id = "numPieces.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='numSeeds' and count(parameter)=0]"
		[Register ("numSeeds", "()I", "")]
		public unsafe int NumSeeds ()
		{
			const string __id = "numSeeds.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='numUploads' and count(parameter)=0]"
		[Register ("numUploads", "()I", "")]
		public unsafe int NumUploads ()
		{
			const string __id = "numUploads.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='pieces' and count(parameter)=0]"
		[Register ("pieces", "()Lcom/frostwire/jlibtorrent/PieceIndexBitfield;", "")]
		public unsafe global::FrostWire.Libtorrent.PieceIndexBitfield Pieces ()
		{
			const string __id = "pieces.()Lcom/frostwire/jlibtorrent/PieceIndexBitfield;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PieceIndexBitfield> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='progress' and count(parameter)=0]"
		[Register ("progress", "()F", "")]
		public unsafe float Progress ()
		{
			const string __id = "progress.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='progressPpm' and count(parameter)=0]"
		[Register ("progressPpm", "()I", "")]
		public unsafe int ProgressPpm ()
		{
			const string __id = "progressPpm.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='queuePosition' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='seedRank' and count(parameter)=0]"
		[Register ("seedRank", "()I", "")]
		public unsafe int SeedRank ()
		{
			const string __id = "seedRank.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='seedingDuration' and count(parameter)=0]"
		[Register ("seedingDuration", "()J", "")]
		public unsafe long SeedingDuration ()
		{
			const string __id = "seedingDuration.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='state' and count(parameter)=0]"
		[Register ("state", "()Lcom/frostwire/jlibtorrent/TorrentStatus$State;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentStatus.State InvokeState ()
		{
			const string __id = "state.()Lcom/frostwire/jlibtorrent/TorrentStatus$State;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStatus.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='storageMode' and count(parameter)=0]"
		[Register ("storageMode", "()Lcom/frostwire/jlibtorrent/StorageMode;", "")]
		public unsafe global::FrostWire.Libtorrent.StorageMode StorageMode ()
		{
			const string __id = "storageMode.()Lcom/frostwire/jlibtorrent/StorageMode;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.StorageMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/torrent_status;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Torrent_status Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/torrent_status;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='total' and count(parameter)=0]"
		[Register ("total", "()J", "")]
		public unsafe long Total ()
		{
			const string __id = "total.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='totalDone' and count(parameter)=0]"
		[Register ("totalDone", "()J", "")]
		public unsafe long TotalDone ()
		{
			const string __id = "totalDone.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='totalDownload' and count(parameter)=0]"
		[Register ("totalDownload", "()J", "")]
		public unsafe long TotalDownload ()
		{
			const string __id = "totalDownload.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='totalFailedBytes' and count(parameter)=0]"
		[Register ("totalFailedBytes", "()J", "")]
		public unsafe long TotalFailedBytes ()
		{
			const string __id = "totalFailedBytes.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='totalPayloadDownload' and count(parameter)=0]"
		[Register ("totalPayloadDownload", "()J", "")]
		public unsafe long TotalPayloadDownload ()
		{
			const string __id = "totalPayloadDownload.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='totalPayloadUpload' and count(parameter)=0]"
		[Register ("totalPayloadUpload", "()J", "")]
		public unsafe long TotalPayloadUpload ()
		{
			const string __id = "totalPayloadUpload.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='totalRedundantBytes' and count(parameter)=0]"
		[Register ("totalRedundantBytes", "()J", "")]
		public unsafe long TotalRedundantBytes ()
		{
			const string __id = "totalRedundantBytes.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='totalUpload' and count(parameter)=0]"
		[Register ("totalUpload", "()J", "")]
		public unsafe long TotalUpload ()
		{
			const string __id = "totalUpload.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='totalWanted' and count(parameter)=0]"
		[Register ("totalWanted", "()J", "")]
		public unsafe long TotalWanted ()
		{
			const string __id = "totalWanted.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='totalWantedDone' and count(parameter)=0]"
		[Register ("totalWantedDone", "()J", "")]
		public unsafe long TotalWantedDone ()
		{
			const string __id = "totalWantedDone.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='upBandwidthQueue' and count(parameter)=0]"
		[Register ("upBandwidthQueue", "()I", "")]
		public unsafe int UpBandwidthQueue ()
		{
			const string __id = "upBandwidthQueue.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='uploadPayloadRate' and count(parameter)=0]"
		[Register ("uploadPayloadRate", "()I", "")]
		public unsafe int UploadPayloadRate ()
		{
			const string __id = "uploadPayloadRate.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='uploadRate' and count(parameter)=0]"
		[Register ("uploadRate", "()I", "")]
		public unsafe int UploadRate ()
		{
			const string __id = "uploadRate.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='uploadsLimit' and count(parameter)=0]"
		[Register ("uploadsLimit", "()I", "")]
		public unsafe int UploadsLimit ()
		{
			const string __id = "uploadsLimit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStatus']/method[@name='verifiedPieces' and count(parameter)=0]"
		[Register ("verifiedPieces", "()Lcom/frostwire/jlibtorrent/PieceIndexBitfield;", "")]
		public unsafe global::FrostWire.Libtorrent.PieceIndexBitfield VerifiedPieces ()
		{
			const string __id = "verifiedPieces.()Lcom/frostwire/jlibtorrent/PieceIndexBitfield;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PieceIndexBitfield> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
