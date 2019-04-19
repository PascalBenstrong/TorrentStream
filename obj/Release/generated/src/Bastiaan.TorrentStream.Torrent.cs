using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Bastiaan.TorrentStream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']"
	[global::Android.Runtime.Register ("com/github/se_bastiaan/torrentstream/Torrent", DoNotGenerateAcw=true)]
	public partial class Torrent : global::Java.Lang.Object, global::FrostWire.Libtorrent.IAlertListener {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent.State']"
		[global::Android.Runtime.Register ("com/github/se_bastiaan/torrentstream/Torrent$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent.State']/field[@name='RETRIEVING_META']"
			[Register ("RETRIEVING_META")]
			public static global::Bastiaan.TorrentStream.Torrent.State RetrievingMeta {
				get {
					const string __id = "RETRIEVING_META.Lcom/github/se_bastiaan/torrentstream/Torrent$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent.State']/field[@name='STARTING']"
			[Register ("STARTING")]
			public static global::Bastiaan.TorrentStream.Torrent.State Starting {
				get {
					const string __id = "STARTING.Lcom/github/se_bastiaan/torrentstream/Torrent$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent.State']/field[@name='STREAMING']"
			[Register ("STREAMING")]
			public static global::Bastiaan.TorrentStream.Torrent.State Streaming {
				get {
					const string __id = "STREAMING.Lcom/github/se_bastiaan/torrentstream/Torrent$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent.State']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Bastiaan.TorrentStream.Torrent.State Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/github/se_bastiaan/torrentstream/Torrent$State;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent.State> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/se_bastiaan/torrentstream/Torrent$State", typeof (State));
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent.State']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/se_bastiaan/torrentstream/Torrent$State;", "")]
			public static unsafe global::Bastiaan.TorrentStream.Torrent.State ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/se_bastiaan/torrentstream/Torrent$State;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent.State']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/github/se_bastiaan/torrentstream/Torrent$State;", "")]
			public static unsafe global::Bastiaan.TorrentStream.Torrent.State[] Values ()
			{
				const string __id = "values.()[Lcom/github/se_bastiaan/torrentstream/Torrent$State;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Bastiaan.TorrentStream.Torrent.State[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Bastiaan.TorrentStream.Torrent.State));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/se_bastiaan/torrentstream/Torrent", typeof (Torrent));
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

		protected Torrent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/constructor[@name='Torrent' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.TorrentHandle'] and parameter[2][@type='com.github.se_bastiaan.torrentstream.listeners.TorrentListener'] and parameter[3][@type='java.lang.Long']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/TorrentHandle;Lcom/github/se_bastiaan/torrentstream/listeners/TorrentListener;Ljava/lang/Long;)V", "")]
		public unsafe Torrent (global::FrostWire.Libtorrent.TorrentHandle torrentHandle, global::Bastiaan.TorrentStream.Listeners.ITorrentListener listener, global::Java.Lang.Long prepareSize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/TorrentHandle;Lcom/github/se_bastiaan/torrentstream/listeners/TorrentListener;Ljava/lang/Long;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((torrentHandle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) torrentHandle).Handle);
				__args [1] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [2] = new JniArgumentValue ((prepareSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) prepareSize).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_hasInterestedBytes;
#pragma warning disable 0169
		static Delegate GetHasInterestedBytesHandler ()
		{
			if (cb_hasInterestedBytes == null)
				cb_hasInterestedBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasInterestedBytes);
			return cb_hasInterestedBytes;
		}

		static bool n_HasInterestedBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasInterestedBytes;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasInterestedBytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='hasInterestedBytes' and count(parameter)=0]"
			[Register ("hasInterestedBytes", "()Z", "GetHasInterestedBytesHandler")]
			get {
				const string __id = "hasInterestedBytes.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getInterestedPieceIndex;
#pragma warning disable 0169
		static Delegate GetGetInterestedPieceIndexHandler ()
		{
			if (cb_getInterestedPieceIndex == null)
				cb_getInterestedPieceIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInterestedPieceIndex);
			return cb_getInterestedPieceIndex;
		}

		static int n_GetInterestedPieceIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InterestedPieceIndex;
		}
#pragma warning restore 0169

		public virtual unsafe int InterestedPieceIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='getInterestedPieceIndex' and count(parameter)=0]"
			[Register ("getInterestedPieceIndex", "()I", "GetGetInterestedPieceIndexHandler")]
			get {
				const string __id = "getInterestedPieceIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPiecesToPrepare;
#pragma warning disable 0169
		static Delegate GetGetPiecesToPrepareHandler ()
		{
			if (cb_getPiecesToPrepare == null)
				cb_getPiecesToPrepare = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPiecesToPrepare);
			return cb_getPiecesToPrepare;
		}

		static IntPtr n_GetPiecesToPrepare (IntPtr jnienv, IntPtr native__this)
		{
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PiecesToPrepare);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Integer PiecesToPrepare {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='getPiecesToPrepare' and count(parameter)=0]"
			[Register ("getPiecesToPrepare", "()Ljava/lang/Integer;", "GetGetPiecesToPrepareHandler")]
			get {
				const string __id = "getPiecesToPrepare.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSaveLocation;
#pragma warning disable 0169
		static Delegate GetGetSaveLocationHandler ()
		{
			if (cb_getSaveLocation == null)
				cb_getSaveLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSaveLocation);
			return cb_getSaveLocation;
		}

		static IntPtr n_GetSaveLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SaveLocation);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.IO.File SaveLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='getSaveLocation' and count(parameter)=0]"
			[Register ("getSaveLocation", "()Ljava/io/File;", "GetGetSaveLocationHandler")]
			get {
				const string __id = "getSaveLocation.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTorrentHandle;
#pragma warning disable 0169
		static Delegate GetGetTorrentHandleHandler ()
		{
			if (cb_getTorrentHandle == null)
				cb_getTorrentHandle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTorrentHandle);
			return cb_getTorrentHandle;
		}

		static IntPtr n_GetTorrentHandle (IntPtr jnienv, IntPtr native__this)
		{
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TorrentHandle);
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.TorrentHandle TorrentHandle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='getTorrentHandle' and count(parameter)=0]"
			[Register ("getTorrentHandle", "()Lcom/frostwire/jlibtorrent/TorrentHandle;", "GetGetTorrentHandleHandler")]
			get {
				const string __id = "getTorrentHandle.()Lcom/frostwire/jlibtorrent/TorrentHandle;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentHandle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoFile;
#pragma warning disable 0169
		static Delegate GetGetVideoFileHandler ()
		{
			if (cb_getVideoFile == null)
				cb_getVideoFile = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoFile);
			return cb_getVideoFile;
		}

		static IntPtr n_GetVideoFile (IntPtr jnienv, IntPtr native__this)
		{
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoFile);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.IO.File VideoFile {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='getVideoFile' and count(parameter)=0]"
			[Register ("getVideoFile", "()Ljava/io/File;", "GetGetVideoFileHandler")]
			get {
				const string __id = "getVideoFile.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoStream;
#pragma warning disable 0169
		static Delegate GetGetVideoStreamHandler ()
		{
			if (cb_getVideoStream == null)
				cb_getVideoStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoStream);
			return cb_getVideoStream;
		}

		static IntPtr n_GetVideoStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.VideoStream);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.IO.Stream VideoStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='getVideoStream' and count(parameter)=0]"
			[Register ("getVideoStream", "()Ljava/io/InputStream;", "GetGetVideoStreamHandler")]
			get {
				const string __id = "getVideoStream.()Ljava/io/InputStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_alert_Lcom_frostwire_jlibtorrent_alerts_Alert_;
#pragma warning disable 0169
		static Delegate GetAlert_Lcom_frostwire_jlibtorrent_alerts_Alert_Handler ()
		{
			if (cb_alert_Lcom_frostwire_jlibtorrent_alerts_Alert_ == null)
				cb_alert_Lcom_frostwire_jlibtorrent_alerts_Alert_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Alert_Lcom_frostwire_jlibtorrent_alerts_Alert_);
			return cb_alert_Lcom_frostwire_jlibtorrent_alerts_Alert_;
		}

		static void n_Alert_Lcom_frostwire_jlibtorrent_alerts_Alert_ (IntPtr jnienv, IntPtr native__this, IntPtr native_alert)
		{
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Alerts.IAlert alert = (global::FrostWire.Libtorrent.Alerts.IAlert)global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IAlert> (native_alert, JniHandleOwnership.DoNotTransfer);
			__this.Alert (alert);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.alerts.Alert&lt;?&gt;']]"
		[Register ("alert", "(Lcom/frostwire/jlibtorrent/alerts/Alert;)V", "GetAlert_Lcom_frostwire_jlibtorrent_alerts_Alert_Handler")]
		public virtual unsafe void Alert (global::FrostWire.Libtorrent.Alerts.IAlert alert)
		{
			const string __id = "alert.(Lcom/frostwire/jlibtorrent/alerts/Alert;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((alert == null) ? IntPtr.Zero : ((global::Java.Lang.Object) alert).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getFileNames;
#pragma warning disable 0169
		static Delegate GetGetFileNamesHandler ()
		{
			if (cb_getFileNames == null)
				cb_getFileNames = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileNames);
			return cb_getFileNames;
		}

		static IntPtr n_GetFileNames (IntPtr jnienv, IntPtr native__this)
		{
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFileNames ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='getFileNames' and count(parameter)=0]"
		[Register ("getFileNames", "()[Ljava/lang/String;", "GetGetFileNamesHandler")]
		public virtual unsafe string[] GetFileNames ()
		{
			const string __id = "getFileNames.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
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
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetState ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='getState' and count(parameter)=0]"
		[Register ("getState", "()Lcom/github/se_bastiaan/torrentstream/Torrent$State;", "GetGetStateHandler")]
		public virtual unsafe global::Bastiaan.TorrentStream.Torrent.State GetState ()
		{
			const string __id = "getState.()Lcom/github/se_bastiaan/torrentstream/Torrent$State;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent.State> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hasBytes_J;
#pragma warning disable 0169
		static Delegate GetHasBytes_JHandler ()
		{
			if (cb_hasBytes_J == null)
				cb_hasBytes_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_HasBytes_J);
			return cb_hasBytes_J;
		}

		static bool n_HasBytes_J (IntPtr jnienv, IntPtr native__this, long bytes)
		{
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBytes (bytes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='hasBytes' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("hasBytes", "(J)Z", "GetHasBytes_JHandler")]
		public virtual unsafe bool HasBytes (long bytes)
		{
			const string __id = "hasBytes.(J)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bytes);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_hasInterestedBytes_I;
#pragma warning disable 0169
		static Delegate GetInvokeHasInterestedBytes_IHandler ()
		{
			if (cb_hasInterestedBytes_I == null)
				cb_hasInterestedBytes_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_InvokeHasInterestedBytes_I);
			return cb_hasInterestedBytes_I;
		}

		static bool n_InvokeHasInterestedBytes_I (IntPtr jnienv, IntPtr native__this, int nextPieces)
		{
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InvokeHasInterestedBytes (nextPieces);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='hasInterestedBytes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasInterestedBytes", "(I)Z", "GetInvokeHasInterestedBytes_IHandler")]
		public virtual unsafe bool InvokeHasInterestedBytes (int nextPieces)
		{
			const string __id = "hasInterestedBytes.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (nextPieces);
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
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			const string __id = "pause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Resume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='resume' and count(parameter)=0]"
		[Register ("resume", "()V", "GetResumeHandler")]
		public virtual unsafe void Resume ()
		{
			const string __id = "resume.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setInterestedBytes_J;
#pragma warning disable 0169
		static Delegate GetSetInterestedBytes_JHandler ()
		{
			if (cb_setInterestedBytes_J == null)
				cb_setInterestedBytes_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetInterestedBytes_J);
			return cb_setInterestedBytes_J;
		}

		static void n_SetInterestedBytes_J (IntPtr jnienv, IntPtr native__this, long bytes)
		{
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInterestedBytes (bytes);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='setInterestedBytes' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setInterestedBytes", "(J)V", "GetSetInterestedBytes_JHandler")]
		public virtual unsafe void SetInterestedBytes (long bytes)
		{
			const string __id = "setInterestedBytes.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bytes);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLargestFile;
#pragma warning disable 0169
		static Delegate GetSetLargestFileHandler ()
		{
			if (cb_setLargestFile == null)
				cb_setLargestFile = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetLargestFile);
			return cb_setLargestFile;
		}

		static void n_SetLargestFile (IntPtr jnienv, IntPtr native__this)
		{
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLargestFile ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='setLargestFile' and count(parameter)=0]"
		[Register ("setLargestFile", "()V", "GetSetLargestFileHandler")]
		public virtual unsafe void SetLargestFile ()
		{
			const string __id = "setLargestFile.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setSelectedFileIndex_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetSelectedFileIndex_Ljava_lang_Integer_Handler ()
		{
			if (cb_setSelectedFileIndex_Ljava_lang_Integer_ == null)
				cb_setSelectedFileIndex_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSelectedFileIndex_Ljava_lang_Integer_);
			return cb_setSelectedFileIndex_Ljava_lang_Integer_;
		}

		static void n_SetSelectedFileIndex_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_selectedFileIndex)
		{
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer selectedFileIndex = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_selectedFileIndex, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectedFileIndex (selectedFileIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='setSelectedFileIndex' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("setSelectedFileIndex", "(Ljava/lang/Integer;)V", "GetSetSelectedFileIndex_Ljava_lang_Integer_Handler")]
		public virtual unsafe void SetSelectedFileIndex (global::Java.Lang.Integer selectedFileIndex)
		{
			const string __id = "setSelectedFileIndex.(Ljava/lang/Integer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((selectedFileIndex == null) ? IntPtr.Zero : ((global::Java.Lang.Object) selectedFileIndex).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startDownload;
#pragma warning disable 0169
		static Delegate GetStartDownloadHandler ()
		{
			if (cb_startDownload == null)
				cb_startDownload = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartDownload);
			return cb_startDownload;
		}

		static void n_StartDownload (IntPtr jnienv, IntPtr native__this)
		{
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartDownload ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='startDownload' and count(parameter)=0]"
		[Register ("startDownload", "()V", "GetStartDownloadHandler")]
		public virtual unsafe void StartDownload ()
		{
			const string __id = "startDownload.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_types;
#pragma warning disable 0169
		static Delegate GetTypesHandler ()
		{
			if (cb_types == null)
				cb_types = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Types);
			return cb_types;
		}

		static IntPtr n_Types (IntPtr jnienv, IntPtr native__this)
		{
			global::Bastiaan.TorrentStream.Torrent __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Types ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='Torrent']/method[@name='types' and count(parameter)=0]"
		[Register ("types", "()[I", "GetTypesHandler")]
		public virtual unsafe int[] Types ()
		{
			const string __id = "types.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

	}
}
