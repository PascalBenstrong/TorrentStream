using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Bastiaan.TorrentStream.Listeners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/interface[@name='TorrentListener']"
	[Register ("com/github/se_bastiaan/torrentstream/listeners/TorrentListener", "", "Bastiaan.TorrentStream.Listeners.ITorrentListenerInvoker")]
	public partial interface ITorrentListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/interface[@name='TorrentListener']/method[@name='onStreamError' and count(parameter)=2 and parameter[1][@type='com.github.se_bastiaan.torrentstream.Torrent'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onStreamError", "(Lcom/github/se_bastiaan/torrentstream/Torrent;Ljava/lang/Exception;)V", "GetOnStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_Handler:Bastiaan.TorrentStream.Listeners.ITorrentListenerInvoker, TorrentStream")]
		void OnStreamError (global::Bastiaan.TorrentStream.Torrent p0, global::Java.Lang.Exception p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/interface[@name='TorrentListener']/method[@name='onStreamPrepared' and count(parameter)=1 and parameter[1][@type='com.github.se_bastiaan.torrentstream.Torrent']]"
		[Register ("onStreamPrepared", "(Lcom/github/se_bastiaan/torrentstream/Torrent;)V", "GetOnStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_Handler:Bastiaan.TorrentStream.Listeners.ITorrentListenerInvoker, TorrentStream")]
		void OnStreamPrepared (global::Bastiaan.TorrentStream.Torrent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/interface[@name='TorrentListener']/method[@name='onStreamProgress' and count(parameter)=2 and parameter[1][@type='com.github.se_bastiaan.torrentstream.Torrent'] and parameter[2][@type='com.github.se_bastiaan.torrentstream.StreamStatus']]"
		[Register ("onStreamProgress", "(Lcom/github/se_bastiaan/torrentstream/Torrent;Lcom/github/se_bastiaan/torrentstream/StreamStatus;)V", "GetOnStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_Handler:Bastiaan.TorrentStream.Listeners.ITorrentListenerInvoker, TorrentStream")]
		void OnStreamProgress (global::Bastiaan.TorrentStream.Torrent p0, global::Bastiaan.TorrentStream.StreamStatus p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/interface[@name='TorrentListener']/method[@name='onStreamReady' and count(parameter)=1 and parameter[1][@type='com.github.se_bastiaan.torrentstream.Torrent']]"
		[Register ("onStreamReady", "(Lcom/github/se_bastiaan/torrentstream/Torrent;)V", "GetOnStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_Handler:Bastiaan.TorrentStream.Listeners.ITorrentListenerInvoker, TorrentStream")]
		void OnStreamReady (global::Bastiaan.TorrentStream.Torrent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/interface[@name='TorrentListener']/method[@name='onStreamStarted' and count(parameter)=1 and parameter[1][@type='com.github.se_bastiaan.torrentstream.Torrent']]"
		[Register ("onStreamStarted", "(Lcom/github/se_bastiaan/torrentstream/Torrent;)V", "GetOnStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_Handler:Bastiaan.TorrentStream.Listeners.ITorrentListenerInvoker, TorrentStream")]
		void OnStreamStarted (global::Bastiaan.TorrentStream.Torrent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/interface[@name='TorrentListener']/method[@name='onStreamStopped' and count(parameter)=0]"
		[Register ("onStreamStopped", "()V", "GetOnStreamStoppedHandler:Bastiaan.TorrentStream.Listeners.ITorrentListenerInvoker, TorrentStream")]
		void OnStreamStopped ();

	}

	[global::Android.Runtime.Register ("com/github/se_bastiaan/torrentstream/listeners/TorrentListener", DoNotGenerateAcw=true)]
	internal class ITorrentListenerInvoker : global::Java.Lang.Object, ITorrentListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/se_bastiaan/torrentstream/listeners/TorrentListener", typeof (ITorrentListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ITorrentListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITorrentListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.github.se_bastiaan.torrentstream.listeners.TorrentListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITorrentListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_Handler ()
		{
			if (cb_onStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_ == null)
				cb_onStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_);
			return cb_onStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_;
		}

		static void n_OnStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Bastiaan.TorrentStream.Listeners.ITorrentListener __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Listeners.ITorrentListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Bastiaan.TorrentStream.Torrent p0 = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnStreamError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_;
		public unsafe void OnStreamError (global::Bastiaan.TorrentStream.Torrent p0, global::Java.Lang.Exception p1)
		{
			if (id_onStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onStreamError", "(Lcom/github/se_bastiaan/torrentstream/Torrent;Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStreamError_Lcom_github_se_bastiaan_torrentstream_Torrent_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_;
#pragma warning disable 0169
		static Delegate GetOnStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_Handler ()
		{
			if (cb_onStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_ == null)
				cb_onStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_);
			return cb_onStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_;
		}

		static void n_OnStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Bastiaan.TorrentStream.Listeners.ITorrentListener __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Listeners.ITorrentListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Bastiaan.TorrentStream.Torrent p0 = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStreamPrepared (p0);
		}
#pragma warning restore 0169

		IntPtr id_onStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_;
		public unsafe void OnStreamPrepared (global::Bastiaan.TorrentStream.Torrent p0)
		{
			if (id_onStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_ == IntPtr.Zero)
				id_onStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_ = JNIEnv.GetMethodID (class_ref, "onStreamPrepared", "(Lcom/github/se_bastiaan/torrentstream/Torrent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStreamPrepared_Lcom_github_se_bastiaan_torrentstream_Torrent_, __args);
		}

		static Delegate cb_onStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_;
#pragma warning disable 0169
		static Delegate GetOnStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_Handler ()
		{
			if (cb_onStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_ == null)
				cb_onStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_);
			return cb_onStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_;
		}

		static void n_OnStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Bastiaan.TorrentStream.Listeners.ITorrentListener __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Listeners.ITorrentListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Bastiaan.TorrentStream.Torrent p0 = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Bastiaan.TorrentStream.StreamStatus p1 = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.StreamStatus> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnStreamProgress (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_;
		public unsafe void OnStreamProgress (global::Bastiaan.TorrentStream.Torrent p0, global::Bastiaan.TorrentStream.StreamStatus p1)
		{
			if (id_onStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_ == IntPtr.Zero)
				id_onStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_ = JNIEnv.GetMethodID (class_ref, "onStreamProgress", "(Lcom/github/se_bastiaan/torrentstream/Torrent;Lcom/github/se_bastiaan/torrentstream/StreamStatus;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStreamProgress_Lcom_github_se_bastiaan_torrentstream_Torrent_Lcom_github_se_bastiaan_torrentstream_StreamStatus_, __args);
		}

		static Delegate cb_onStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_;
#pragma warning disable 0169
		static Delegate GetOnStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_Handler ()
		{
			if (cb_onStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_ == null)
				cb_onStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_);
			return cb_onStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_;
		}

		static void n_OnStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Bastiaan.TorrentStream.Listeners.ITorrentListener __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Listeners.ITorrentListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Bastiaan.TorrentStream.Torrent p0 = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStreamReady (p0);
		}
#pragma warning restore 0169

		IntPtr id_onStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_;
		public unsafe void OnStreamReady (global::Bastiaan.TorrentStream.Torrent p0)
		{
			if (id_onStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_ == IntPtr.Zero)
				id_onStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_ = JNIEnv.GetMethodID (class_ref, "onStreamReady", "(Lcom/github/se_bastiaan/torrentstream/Torrent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStreamReady_Lcom_github_se_bastiaan_torrentstream_Torrent_, __args);
		}

		static Delegate cb_onStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_;
#pragma warning disable 0169
		static Delegate GetOnStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_Handler ()
		{
			if (cb_onStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_ == null)
				cb_onStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_);
			return cb_onStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_;
		}

		static void n_OnStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Bastiaan.TorrentStream.Listeners.ITorrentListener __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Listeners.ITorrentListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Bastiaan.TorrentStream.Torrent p0 = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Torrent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnStreamStarted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_;
		public unsafe void OnStreamStarted (global::Bastiaan.TorrentStream.Torrent p0)
		{
			if (id_onStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_ == IntPtr.Zero)
				id_onStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_ = JNIEnv.GetMethodID (class_ref, "onStreamStarted", "(Lcom/github/se_bastiaan/torrentstream/Torrent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStreamStarted_Lcom_github_se_bastiaan_torrentstream_Torrent_, __args);
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
			global::Bastiaan.TorrentStream.Listeners.ITorrentListener __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Listeners.ITorrentListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStreamStopped ();
		}
#pragma warning restore 0169

		IntPtr id_onStreamStopped;
		public unsafe void OnStreamStopped ()
		{
			if (id_onStreamStopped == IntPtr.Zero)
				id_onStreamStopped = JNIEnv.GetMethodID (class_ref, "onStreamStopped", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStreamStopped);
		}

	}

	// event args for com.github.se_bastiaan.torrentstream.listeners.TorrentListener.onStreamError
	public partial class StreamErrorEventArgs : global::System.EventArgs {

		public StreamErrorEventArgs (global::Bastiaan.TorrentStream.Torrent p0, global::Java.Lang.Exception p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Bastiaan.TorrentStream.Torrent p0;
		public global::Bastiaan.TorrentStream.Torrent P0 {
			get { return p0; }
		}

		global::Java.Lang.Exception p1;
		public global::Java.Lang.Exception P1 {
			get { return p1; }
		}
	}

	// event args for com.github.se_bastiaan.torrentstream.listeners.TorrentListener.onStreamPrepared
	public partial class StreamPreparedEventArgs : global::System.EventArgs {

		public StreamPreparedEventArgs (global::Bastiaan.TorrentStream.Torrent p0)
		{
			this.p0 = p0;
		}

		global::Bastiaan.TorrentStream.Torrent p0;
		public global::Bastiaan.TorrentStream.Torrent P0 {
			get { return p0; }
		}
	}

	// event args for com.github.se_bastiaan.torrentstream.listeners.TorrentListener.onStreamProgress
	public partial class StreamProgressEventArgs : global::System.EventArgs {

		public StreamProgressEventArgs (global::Bastiaan.TorrentStream.Torrent p0, global::Bastiaan.TorrentStream.StreamStatus p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Bastiaan.TorrentStream.Torrent p0;
		public global::Bastiaan.TorrentStream.Torrent P0 {
			get { return p0; }
		}

		global::Bastiaan.TorrentStream.StreamStatus p1;
		public global::Bastiaan.TorrentStream.StreamStatus P1 {
			get { return p1; }
		}
	}

	// event args for com.github.se_bastiaan.torrentstream.listeners.TorrentListener.onStreamReady
	public partial class StreamReadyEventArgs : global::System.EventArgs {

		public StreamReadyEventArgs (global::Bastiaan.TorrentStream.Torrent p0)
		{
			this.p0 = p0;
		}

		global::Bastiaan.TorrentStream.Torrent p0;
		public global::Bastiaan.TorrentStream.Torrent P0 {
			get { return p0; }
		}
	}

	// event args for com.github.se_bastiaan.torrentstream.listeners.TorrentListener.onStreamStarted
	public partial class StreamStartedEventArgs : global::System.EventArgs {

		public StreamStartedEventArgs (global::Bastiaan.TorrentStream.Torrent p0)
		{
			this.p0 = p0;
		}

		global::Bastiaan.TorrentStream.Torrent p0;
		public global::Bastiaan.TorrentStream.Torrent P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/github/se_bastiaan/torrentstream/listeners/TorrentListenerImplementor")]
	internal sealed partial class ITorrentListenerImplementor : global::Java.Lang.Object, ITorrentListener {

		object sender;

		public ITorrentListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/github/se_bastiaan/torrentstream/listeners/TorrentListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<StreamErrorEventArgs> OnStreamErrorHandler;
#pragma warning restore 0649

		public void OnStreamError (global::Bastiaan.TorrentStream.Torrent p0, global::Java.Lang.Exception p1)
		{
			var __h = OnStreamErrorHandler;
			if (__h != null)
				__h (sender, new StreamErrorEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<StreamPreparedEventArgs> OnStreamPreparedHandler;
#pragma warning restore 0649

		public void OnStreamPrepared (global::Bastiaan.TorrentStream.Torrent p0)
		{
			var __h = OnStreamPreparedHandler;
			if (__h != null)
				__h (sender, new StreamPreparedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<StreamProgressEventArgs> OnStreamProgressHandler;
#pragma warning restore 0649

		public void OnStreamProgress (global::Bastiaan.TorrentStream.Torrent p0, global::Bastiaan.TorrentStream.StreamStatus p1)
		{
			var __h = OnStreamProgressHandler;
			if (__h != null)
				__h (sender, new StreamProgressEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<StreamReadyEventArgs> OnStreamReadyHandler;
#pragma warning restore 0649

		public void OnStreamReady (global::Bastiaan.TorrentStream.Torrent p0)
		{
			var __h = OnStreamReadyHandler;
			if (__h != null)
				__h (sender, new StreamReadyEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<StreamStartedEventArgs> OnStreamStartedHandler;
#pragma warning restore 0649

		public void OnStreamStarted (global::Bastiaan.TorrentStream.Torrent p0)
		{
			var __h = OnStreamStartedHandler;
			if (__h != null)
				__h (sender, new StreamStartedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler OnStreamStoppedHandler;
#pragma warning restore 0649

		public void OnStreamStopped ()
		{
			var __h = OnStreamStoppedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (ITorrentListenerImplementor value)
		{
			return value.OnStreamErrorHandler == null && value.OnStreamPreparedHandler == null && value.OnStreamProgressHandler == null && value.OnStreamReadyHandler == null && value.OnStreamStartedHandler == null && value.OnStreamStoppedHandler == null;
		}
	}

}
