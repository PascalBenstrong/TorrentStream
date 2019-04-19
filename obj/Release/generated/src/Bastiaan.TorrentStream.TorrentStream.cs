using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Bastiaan.TorrentStream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream']"
	[global::Android.Runtime.Register ("com/github/se_bastiaan/torrentstream/TorrentStream", DoNotGenerateAcw=true)]
	public sealed partial class TorrentStream : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream.InternalTorrentListener']"
		[global::Android.Runtime.Register ("com/github/se_bastiaan/torrentstream/TorrentStream$InternalTorrentListener", DoNotGenerateAcw=true)]
		protected internal partial class InternalTorrentListener : global::Java.Lang.Object, global::Bastiaan.TorrentStream.Listeners.ITorrentListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/se_bastiaan/torrentstream/TorrentStream$InternalTorrentListener", typeof (InternalTorrentListener));
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

			protected InternalTorrentListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream.InternalTorrentListener']/constructor[@name='TorrentStream.InternalTorrentListener' and count(parameter)=1 and parameter[1][@type='com.github.se_bastiaan.torrentstream.TorrentStream']]"
			[Register (".ctor", "(Lcom/github/se_bastiaan/torrentstream/TorrentStream;)V", "")]
			protected unsafe InternalTorrentListener (global::Bastiaan.TorrentStream.TorrentStream __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_;
#pragma warning disable 0169
			static Delegate GetOnStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_Handler ()
			{
				if (cb_onStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_ == null)
					cb_onStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_);
				return cb_onStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_;
			}

			static void n_OnStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_torrent, IntPtr native_e)
			{
				global::Bastiaan.TorrentStream.TorrentStream.InternalTorrentListener __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentStream.InternalTorrentListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Bastiaan.TorrentStream.Torrent torrent = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (native_torrent, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Exception e = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_e, JniHandleOwnership.DoNotTransfer);
				__this.OnStreamError (torrent, e);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream.InternalTorrentListener']/method[@name='onStreamError' and count(parameter)=2 and parameter[1][@type='com.github.se_bastiaan.torrentstream.Torrent'] and parameter[2][@type='java.lang.Exception']]"
			[Register ("onStreamError", "(Lcom/github/se_bastiaan/torrentstream/Torrent;Ljava/lang/Exception;)V", "GetOnStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_Handler")]
			public virtual unsafe void OnStreamError (global::Bastiaan.TorrentStream.Torrent torrent, global::Java.Lang.Exception e)
			{
				const string __id = "onStreamError.(Lcom/github/se_bastiaan/torrentstream/Torrent;Ljava/lang/Exception;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((torrent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) torrent).Handle);
					__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) e).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_;
#pragma warning disable 0169
			static Delegate GetOnStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_Handler ()
			{
				if (cb_onStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_ == null)
					cb_onStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_);
				return cb_onStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_;
			}

			static void n_OnStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_torrent)
			{
				global::Bastiaan.TorrentStream.TorrentStream.InternalTorrentListener __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentStream.InternalTorrentListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Bastiaan.TorrentStream.Torrent torrent = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (native_torrent, JniHandleOwnership.DoNotTransfer);
				__this.OnStreamPrepared (torrent);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream.InternalTorrentListener']/method[@name='onStreamPrepared' and count(parameter)=1 and parameter[1][@type='com.github.se_bastiaan.torrentstream.Torrent']]"
			[Register ("onStreamPrepared", "(Lcom/github/se_bastiaan/torrentstream/Torrent;)V", "GetOnStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_Handler")]
			public virtual unsafe void OnStreamPrepared (global::Bastiaan.TorrentStream.Torrent torrent)
			{
				const string __id = "onStreamPrepared.(Lcom/github/se_bastiaan/torrentstream/Torrent;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((torrent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) torrent).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_;
#pragma warning disable 0169
			static Delegate GetOnStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_Handler ()
			{
				if (cb_onStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_ == null)
					cb_onStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_);
				return cb_onStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_;
			}

			static void n_OnStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_torrent, IntPtr native_status)
			{
				global::Bastiaan.TorrentStream.TorrentStream.InternalTorrentListener __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentStream.InternalTorrentListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Bastiaan.TorrentStream.Torrent torrent = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (native_torrent, JniHandleOwnership.DoNotTransfer);
				global::Bastiaan.TorrentStream.StreamStatus status = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.StreamStatus> (native_status, JniHandleOwnership.DoNotTransfer);
				__this.OnStreamProgress (torrent, status);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream.InternalTorrentListener']/method[@name='onStreamProgress' and count(parameter)=2 and parameter[1][@type='com.github.se_bastiaan.torrentstream.Torrent'] and parameter[2][@type='com.github.se_bastiaan.torrentstream.StreamStatus']]"
			[Register ("onStreamProgress", "(Lcom/github/se_bastiaan/torrentstream/Torrent;Lcom/github/se_bastiaan/torrentstream/StreamStatus;)V", "GetOnStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_Handler")]
			public virtual unsafe void OnStreamProgress (global::Bastiaan.TorrentStream.Torrent torrent, global::Bastiaan.TorrentStream.StreamStatus status)
			{
				const string __id = "onStreamProgress.(Lcom/github/se_bastiaan/torrentstream/Torrent;Lcom/github/se_bastiaan/torrentstream/StreamStatus;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((torrent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) torrent).Handle);
					__args [1] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_;
#pragma warning disable 0169
			static Delegate GetOnStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_Handler ()
			{
				if (cb_onStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_ == null)
					cb_onStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_);
				return cb_onStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_;
			}

			static void n_OnStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_torrent)
			{
				global::Bastiaan.TorrentStream.TorrentStream.InternalTorrentListener __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentStream.InternalTorrentListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Bastiaan.TorrentStream.Torrent torrent = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (native_torrent, JniHandleOwnership.DoNotTransfer);
				__this.OnStreamReady (torrent);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream.InternalTorrentListener']/method[@name='onStreamReady' and count(parameter)=1 and parameter[1][@type='com.github.se_bastiaan.torrentstream.Torrent']]"
			[Register ("onStreamReady", "(Lcom/github/se_bastiaan/torrentstream/Torrent;)V", "GetOnStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_Handler")]
			public virtual unsafe void OnStreamReady (global::Bastiaan.TorrentStream.Torrent torrent)
			{
				const string __id = "onStreamReady.(Lcom/github/se_bastiaan/torrentstream/Torrent;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((torrent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) torrent).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_;
#pragma warning disable 0169
			static Delegate GetOnStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_Handler ()
			{
				if (cb_onStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_ == null)
					cb_onStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_);
				return cb_onStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_;
			}

			static void n_OnStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_torrent)
			{
				global::Bastiaan.TorrentStream.TorrentStream.InternalTorrentListener __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentStream.InternalTorrentListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Bastiaan.TorrentStream.Torrent torrent = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (native_torrent, JniHandleOwnership.DoNotTransfer);
				__this.OnStreamStarted (torrent);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream.InternalTorrentListener']/method[@name='onStreamStarted' and count(parameter)=1 and parameter[1][@type='com.github.se_bastiaan.torrentstream.Torrent']]"
			[Register ("onStreamStarted", "(Lcom/github/se_bastiaan/torrentstream/Torrent;)V", "GetOnStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_Handler")]
			public virtual unsafe void OnStreamStarted (global::Bastiaan.TorrentStream.Torrent torrent)
			{
				const string __id = "onStreamStarted.(Lcom/github/se_bastiaan/torrentstream/Torrent;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((torrent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) torrent).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onStreamStopped;
#pragma warning disable 0169
			static Delegate GetOnStreamStoppedHandler ()
			{
				if (cb_onStreamStopped == null)
					cb_onStreamStopped = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStreamStopped);
				return cb_onStreamStopped;
			}

			static void n_OnStreamStopped (IntPtr jnienv, IntPtr native__this)
			{
				global::Bastiaan.TorrentStream.TorrentStream.InternalTorrentListener __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentStream.InternalTorrentListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnStreamStopped ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream.InternalTorrentListener']/method[@name='onStreamStopped' and count(parameter)=0]"
			[Register ("onStreamStopped", "()V", "GetOnStreamStoppedHandler")]
			public virtual unsafe void OnStreamStopped ()
			{
				const string __id = "onStreamStopped.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/se_bastiaan/torrentstream/TorrentStream", typeof (TorrentStream));
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

		internal TorrentStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Bastiaan.TorrentStream.Torrent CurrentTorrent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream']/method[@name='getCurrentTorrent' and count(parameter)=0]"
			[Register ("getCurrentTorrent", "()Lcom/github/se_bastiaan/torrentstream/Torrent;", "GetGetCurrentTorrentHandler")]
			get {
				const string __id = "getCurrentTorrent.()Lcom/github/se_bastiaan/torrentstream/Torrent;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string CurrentTorrentUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream']/method[@name='getCurrentTorrentUrl' and count(parameter)=0]"
			[Register ("getCurrentTorrentUrl", "()Ljava/lang/String;", "GetGetCurrentTorrentUrlHandler")]
			get {
				const string __id = "getCurrentTorrentUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::Bastiaan.TorrentStream.TorrentStream Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/github/se_bastiaan/torrentstream/TorrentStream;", "GetGetInstanceHandler")]
			get {
				const string __id = "getInstance.()Lcom/github/se_bastiaan/torrentstream/TorrentStream;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsStreaming {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream']/method[@name='isStreaming' and count(parameter)=0]"
			[Register ("isStreaming", "()Z", "GetIsStreamingHandler")]
			get {
				const string __id = "isStreaming.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Bastiaan.TorrentStream.TorrentOptions Options {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream']/method[@name='getOptions' and count(parameter)=0]"
			[Register ("getOptions", "()Lcom/github/se_bastiaan/torrentstream/TorrentOptions;", "GetGetOptionsHandler")]
			get {
				const string __id = "getOptions.()Lcom/github/se_bastiaan/torrentstream/TorrentOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='com.github.se_bastiaan.torrentstream.TorrentOptions']]"
			[Register ("setOptions", "(Lcom/github/se_bastiaan/torrentstream/TorrentOptions;)V", "GetSetOptions_Lcom_github_se_bastiaan_torrentstream_TorrentOptions_Handler")]
			set {
				const string __id = "setOptions.(Lcom/github/se_bastiaan/torrentstream/TorrentOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Integer TotalDhtNodes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream']/method[@name='getTotalDhtNodes' and count(parameter)=0]"
			[Register ("getTotalDhtNodes", "()Ljava/lang/Integer;", "GetGetTotalDhtNodesHandler")]
			get {
				const string __id = "getTotalDhtNodes.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream']/method[@name='addListener' and count(parameter)=1 and parameter[1][@type='com.github.se_bastiaan.torrentstream.listeners.TorrentListener']]"
		[Register ("addListener", "(Lcom/github/se_bastiaan/torrentstream/listeners/TorrentListener;)V", "")]
		public unsafe void AddListener (global::Bastiaan.TorrentStream.Listeners.ITorrentListener listener)
		{
			const string __id = "addListener.(Lcom/github/se_bastiaan/torrentstream/listeners/TorrentListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.github.se_bastiaan.torrentstream.TorrentOptions']]"
		[Register ("init", "(Lcom/github/se_bastiaan/torrentstream/TorrentOptions;)Lcom/github/se_bastiaan/torrentstream/TorrentStream;", "")]
		public static unsafe global::Bastiaan.TorrentStream.TorrentStream Init (global::Bastiaan.TorrentStream.TorrentOptions options)
		{
			const string __id = "init.(Lcom/github/se_bastiaan/torrentstream/TorrentOptions;)Lcom/github/se_bastiaan/torrentstream/TorrentStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream']/method[@name='pauseSession' and count(parameter)=0]"
		[Register ("pauseSession", "()V", "")]
		public unsafe void PauseSession ()
		{
			const string __id = "pauseSession.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream']/method[@name='removeListener' and count(parameter)=1 and parameter[1][@type='com.github.se_bastiaan.torrentstream.listeners.TorrentListener']]"
		[Register ("removeListener", "(Lcom/github/se_bastiaan/torrentstream/listeners/TorrentListener;)V", "")]
		public unsafe void RemoveListener (global::Bastiaan.TorrentStream.Listeners.ITorrentListener listener)
		{
			const string __id = "removeListener.(Lcom/github/se_bastiaan/torrentstream/listeners/TorrentListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream']/method[@name='resumeSession' and count(parameter)=0]"
		[Register ("resumeSession", "()V", "")]
		public unsafe void ResumeSession ()
		{
			const string __id = "resumeSession.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream']/method[@name='startStream' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("startStream", "(Ljava/lang/String;)V", "")]
		public unsafe void StartStream (string torrentUrl)
		{
			const string __id = "startStream.(Ljava/lang/String;)V";
			IntPtr native_torrentUrl = JNIEnv.NewString (torrentUrl);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_torrentUrl);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_torrentUrl);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentStream']/method[@name='stopStream' and count(parameter)=0]"
		[Register ("stopStream", "()V", "")]
		public unsafe void StopStream ()
		{
			const string __id = "stopStream.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

#region "Event implementation for Bastiaan.TorrentStream.Listeners.ITorrentListener"

		global::Bastiaan.TorrentStream.Listeners.ITorrentListenerImplementor __CreateITorrentListenerImplementor ()
		{
			return new global::Bastiaan.TorrentStream.Listeners.ITorrentListenerImplementor (this);
		}
#endregion
	}
}
