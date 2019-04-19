using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/TorrentStats", DoNotGenerateAcw=true)]
	public sealed partial class TorrentStats : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats.SeriesMetric']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/TorrentStats$SeriesMetric", DoNotGenerateAcw=true)]
		public sealed partial class SeriesMetric : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats.SeriesMetric']/field[@name='DOWNLOAD_RATE']"
			[Register ("DOWNLOAD_RATE")]
			public static global::FrostWire.Libtorrent.TorrentStats.SeriesMetric DownloadRate {
				get {
					const string __id = "DOWNLOAD_RATE.Lcom/frostwire/jlibtorrent/TorrentStats$SeriesMetric;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStats.SeriesMetric> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats.SeriesMetric']/field[@name='TIME']"
			[Register ("TIME")]
			public static global::FrostWire.Libtorrent.TorrentStats.SeriesMetric Time {
				get {
					const string __id = "TIME.Lcom/frostwire/jlibtorrent/TorrentStats$SeriesMetric;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStats.SeriesMetric> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats.SeriesMetric']/field[@name='UPLOAD_RATE']"
			[Register ("UPLOAD_RATE")]
			public static global::FrostWire.Libtorrent.TorrentStats.SeriesMetric UploadRate {
				get {
					const string __id = "UPLOAD_RATE.Lcom/frostwire/jlibtorrent/TorrentStats$SeriesMetric;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStats.SeriesMetric> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/TorrentStats$SeriesMetric", typeof (SeriesMetric));
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

			internal SeriesMetric (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats.SeriesMetric']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/TorrentStats$SeriesMetric;", "")]
			public static unsafe global::FrostWire.Libtorrent.TorrentStats.SeriesMetric ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/TorrentStats$SeriesMetric;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStats.SeriesMetric> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats.SeriesMetric']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/frostwire/jlibtorrent/TorrentStats$SeriesMetric;", "")]
			public static unsafe global::FrostWire.Libtorrent.TorrentStats.SeriesMetric[] Values ()
			{
				const string __id = "values.()[Lcom/frostwire/jlibtorrent/TorrentStats$SeriesMetric;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::FrostWire.Libtorrent.TorrentStats.SeriesMetric[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.TorrentStats.SeriesMetric));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/TorrentStats", typeof (TorrentStats));
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

		internal TorrentStats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/constructor[@name='TorrentStats' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.Sha1Hash'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/Sha1Hash;I)V", "")]
		public unsafe TorrentStats (global::FrostWire.Libtorrent.Sha1Hash infoHash, int maxSamples)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/Sha1Hash;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((infoHash == null) ? IntPtr.Zero : ((global::Java.Lang.Object) infoHash).Handle);
				__args [1] = new JniArgumentValue (maxSamples);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe bool IsFinished {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='isFinished' and count(parameter)=0]"
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

		public unsafe bool IsPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='isPaused' and count(parameter)=0]"
			[Register ("isPaused", "()Z", "GetIsPausedHandler")]
			get {
				const string __id = "isPaused.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsSeeding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='isSeeding' and count(parameter)=0]"
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

		public unsafe bool IsSequentialDownload {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='isSequentialDownload' and count(parameter)=0]"
			[Register ("isSequentialDownload", "()Z", "GetIsSequentialDownloadHandler")]
			get {
				const string __id = "isSequentialDownload.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='allTimeDownload' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='allTimeUpload' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='downloadPayloadRate' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='downloadRate' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='last' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.TorrentStats.SeriesMetric']]"
		[Register ("last", "(Lcom/frostwire/jlibtorrent/TorrentStats$SeriesMetric;)J", "")]
		public unsafe long Last (global::FrostWire.Libtorrent.TorrentStats.SeriesMetric metric)
		{
			const string __id = "last.(Lcom/frostwire/jlibtorrent/TorrentStats$SeriesMetric;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((metric == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metric).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='listPeers' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='listSeeds' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='maxSamples' and count(parameter)=0]"
		[Register ("maxSamples", "()I", "")]
		public unsafe int MaxSamples ()
		{
			const string __id = "maxSamples.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='needSaveResume' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='numConnections' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='numPeers' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='numPieces' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='numSeeds' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='progress' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='progressPpm' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='series' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.TorrentStats.SeriesMetric']]"
		[Register ("series", "(Lcom/frostwire/jlibtorrent/TorrentStats$SeriesMetric;)Lcom/frostwire/jlibtorrent/IntSeries;", "")]
		public unsafe global::FrostWire.Libtorrent.IntSeries Series (global::FrostWire.Libtorrent.TorrentStats.SeriesMetric metric)
		{
			const string __id = "series.(Lcom/frostwire/jlibtorrent/TorrentStats$SeriesMetric;)Lcom/frostwire/jlibtorrent/IntSeries;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((metric == null) ? IntPtr.Zero : ((global::Java.Lang.Object) metric).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.IntSeries> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='state' and count(parameter)=0]"
		[Register ("state", "()Lcom/frostwire/jlibtorrent/TorrentStatus$State;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentStatus.State State ()
		{
			const string __id = "state.()Lcom/frostwire/jlibtorrent/TorrentStatus$State;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentStatus.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='totalDone' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='totalDownload' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='totalPayloadDownload' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='totalPayloadUpload' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='totalUpload' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='totalWanted' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='totalWantedDone' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='update' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.TorrentStatus']]"
		[Register ("update", "(Lcom/frostwire/jlibtorrent/TorrentStatus;)V", "")]
		public unsafe void Update (global::FrostWire.Libtorrent.TorrentStatus status)
		{
			const string __id = "update.(Lcom/frostwire/jlibtorrent/TorrentStatus;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='uploadPayloadRate' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentStats']/method[@name='uploadRate' and count(parameter)=0]"
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

	}
}
