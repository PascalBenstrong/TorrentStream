using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Bastiaan.TorrentStream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentOptions']"
	[global::Android.Runtime.Register ("com/github/se_bastiaan/torrentstream/TorrentOptions", DoNotGenerateAcw=true)]
	public sealed partial class TorrentOptions : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentOptions.Builder']"
		[global::Android.Runtime.Register ("com/github/se_bastiaan/torrentstream/TorrentOptions$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/se_bastiaan/torrentstream/TorrentOptions$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentOptions.Builder']/constructor[@name='TorrentOptions.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			static Delegate cb_anonymousMode_Ljava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetAnonymousMode_Ljava_lang_Boolean_Handler ()
			{
				if (cb_anonymousMode_Ljava_lang_Boolean_ == null)
					cb_anonymousMode_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AnonymousMode_Ljava_lang_Boolean_);
				return cb_anonymousMode_Ljava_lang_Boolean_;
			}

			static IntPtr n_AnonymousMode_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_enable)
			{
				global::Bastiaan.TorrentStream.TorrentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Boolean enable = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_enable, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AnonymousMode (enable));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentOptions.Builder']/method[@name='anonymousMode' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("anonymousMode", "(Ljava/lang/Boolean;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;", "GetAnonymousMode_Ljava_lang_Boolean_Handler")]
			public virtual unsafe global::Bastiaan.TorrentStream.TorrentOptions.Builder AnonymousMode (global::Java.Lang.Boolean enable)
			{
				const string __id = "anonymousMode.(Ljava/lang/Boolean;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((enable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) enable).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_autoDownload_Ljava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetAutoDownload_Ljava_lang_Boolean_Handler ()
			{
				if (cb_autoDownload_Ljava_lang_Boolean_ == null)
					cb_autoDownload_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AutoDownload_Ljava_lang_Boolean_);
				return cb_autoDownload_Ljava_lang_Boolean_;
			}

			static IntPtr n_AutoDownload_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_enable)
			{
				global::Bastiaan.TorrentStream.TorrentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Boolean enable = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_enable, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AutoDownload (enable));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentOptions.Builder']/method[@name='autoDownload' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("autoDownload", "(Ljava/lang/Boolean;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;", "GetAutoDownload_Ljava_lang_Boolean_Handler")]
			public virtual unsafe global::Bastiaan.TorrentStream.TorrentOptions.Builder AutoDownload (global::Java.Lang.Boolean enable)
			{
				const string __id = "autoDownload.(Ljava/lang/Boolean;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((enable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) enable).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Bastiaan.TorrentStream.TorrentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentOptions.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/github/se_bastiaan/torrentstream/TorrentOptions;", "GetBuildHandler")]
			public virtual unsafe global::Bastiaan.TorrentStream.TorrentOptions Build ()
			{
				const string __id = "build.()Lcom/github/se_bastiaan/torrentstream/TorrentOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_listeningPort_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetListeningPort_Ljava_lang_Integer_Handler ()
			{
				if (cb_listeningPort_Ljava_lang_Integer_ == null)
					cb_listeningPort_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ListeningPort_Ljava_lang_Integer_);
				return cb_listeningPort_Ljava_lang_Integer_;
			}

			static IntPtr n_ListeningPort_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_port)
			{
				global::Bastiaan.TorrentStream.TorrentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer port = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_port, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ListeningPort (port));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentOptions.Builder']/method[@name='listeningPort' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("listeningPort", "(Ljava/lang/Integer;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;", "GetListeningPort_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::Bastiaan.TorrentStream.TorrentOptions.Builder ListeningPort (global::Java.Lang.Integer port)
			{
				const string __id = "listeningPort.(Ljava/lang/Integer;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((port == null) ? IntPtr.Zero : ((global::Java.Lang.Object) port).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_maxActiveDHT_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetMaxActiveDHT_Ljava_lang_Integer_Handler ()
			{
				if (cb_maxActiveDHT_Ljava_lang_Integer_ == null)
					cb_maxActiveDHT_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MaxActiveDHT_Ljava_lang_Integer_);
				return cb_maxActiveDHT_Ljava_lang_Integer_;
			}

			static IntPtr n_MaxActiveDHT_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_maxActiveDHT)
			{
				global::Bastiaan.TorrentStream.TorrentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer maxActiveDHT = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_maxActiveDHT, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MaxActiveDHT (maxActiveDHT));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentOptions.Builder']/method[@name='maxActiveDHT' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("maxActiveDHT", "(Ljava/lang/Integer;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;", "GetMaxActiveDHT_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::Bastiaan.TorrentStream.TorrentOptions.Builder MaxActiveDHT (global::Java.Lang.Integer maxActiveDHT)
			{
				const string __id = "maxActiveDHT.(Ljava/lang/Integer;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((maxActiveDHT == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxActiveDHT).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_maxConnections_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetMaxConnections_Ljava_lang_Integer_Handler ()
			{
				if (cb_maxConnections_Ljava_lang_Integer_ == null)
					cb_maxConnections_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MaxConnections_Ljava_lang_Integer_);
				return cb_maxConnections_Ljava_lang_Integer_;
			}

			static IntPtr n_MaxConnections_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_maxConnections)
			{
				global::Bastiaan.TorrentStream.TorrentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer maxConnections = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_maxConnections, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MaxConnections (maxConnections));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentOptions.Builder']/method[@name='maxConnections' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("maxConnections", "(Ljava/lang/Integer;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;", "GetMaxConnections_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::Bastiaan.TorrentStream.TorrentOptions.Builder MaxConnections (global::Java.Lang.Integer maxConnections)
			{
				const string __id = "maxConnections.(Ljava/lang/Integer;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((maxConnections == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxConnections).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_maxDownloadSpeed_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetMaxDownloadSpeed_Ljava_lang_Integer_Handler ()
			{
				if (cb_maxDownloadSpeed_Ljava_lang_Integer_ == null)
					cb_maxDownloadSpeed_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MaxDownloadSpeed_Ljava_lang_Integer_);
				return cb_maxDownloadSpeed_Ljava_lang_Integer_;
			}

			static IntPtr n_MaxDownloadSpeed_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_maxDownloadSpeed)
			{
				global::Bastiaan.TorrentStream.TorrentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer maxDownloadSpeed = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_maxDownloadSpeed, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MaxDownloadSpeed (maxDownloadSpeed));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentOptions.Builder']/method[@name='maxDownloadSpeed' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("maxDownloadSpeed", "(Ljava/lang/Integer;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;", "GetMaxDownloadSpeed_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::Bastiaan.TorrentStream.TorrentOptions.Builder MaxDownloadSpeed (global::Java.Lang.Integer maxDownloadSpeed)
			{
				const string __id = "maxDownloadSpeed.(Ljava/lang/Integer;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((maxDownloadSpeed == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxDownloadSpeed).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_maxUploadSpeed_Ljava_lang_Integer_;
#pragma warning disable 0169
			static Delegate GetMaxUploadSpeed_Ljava_lang_Integer_Handler ()
			{
				if (cb_maxUploadSpeed_Ljava_lang_Integer_ == null)
					cb_maxUploadSpeed_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MaxUploadSpeed_Ljava_lang_Integer_);
				return cb_maxUploadSpeed_Ljava_lang_Integer_;
			}

			static IntPtr n_MaxUploadSpeed_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_maxUploadSpeed)
			{
				global::Bastiaan.TorrentStream.TorrentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Integer maxUploadSpeed = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_maxUploadSpeed, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MaxUploadSpeed (maxUploadSpeed));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentOptions.Builder']/method[@name='maxUploadSpeed' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("maxUploadSpeed", "(Ljava/lang/Integer;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;", "GetMaxUploadSpeed_Ljava_lang_Integer_Handler")]
			public virtual unsafe global::Bastiaan.TorrentStream.TorrentOptions.Builder MaxUploadSpeed (global::Java.Lang.Integer maxUploadSpeed)
			{
				const string __id = "maxUploadSpeed.(Ljava/lang/Integer;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((maxUploadSpeed == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxUploadSpeed).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_peerFingerprint_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetPeerFingerprint_Ljava_lang_String_Handler ()
			{
				if (cb_peerFingerprint_Ljava_lang_String_ == null)
					cb_peerFingerprint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PeerFingerprint_Ljava_lang_String_);
				return cb_peerFingerprint_Ljava_lang_String_;
			}

			static IntPtr n_PeerFingerprint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_peerId)
			{
				global::Bastiaan.TorrentStream.TorrentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string peerId = JNIEnv.GetString (native_peerId, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PeerFingerprint (peerId));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentOptions.Builder']/method[@name='peerFingerprint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("peerFingerprint", "(Ljava/lang/String;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;", "GetPeerFingerprint_Ljava_lang_String_Handler")]
			public virtual unsafe global::Bastiaan.TorrentStream.TorrentOptions.Builder PeerFingerprint (string peerId)
			{
				const string __id = "peerFingerprint.(Ljava/lang/String;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;";
				IntPtr native_peerId = JNIEnv.NewString (peerId);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_peerId);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_peerId);
				}
			}

			static Delegate cb_prepareSize_Ljava_lang_Long_;
#pragma warning disable 0169
			static Delegate GetPrepareSize_Ljava_lang_Long_Handler ()
			{
				if (cb_prepareSize_Ljava_lang_Long_ == null)
					cb_prepareSize_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PrepareSize_Ljava_lang_Long_);
				return cb_prepareSize_Ljava_lang_Long_;
			}

			static IntPtr n_PrepareSize_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prepareSize)
			{
				global::Bastiaan.TorrentStream.TorrentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Long prepareSize = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_prepareSize, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PrepareSize (prepareSize));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentOptions.Builder']/method[@name='prepareSize' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("prepareSize", "(Ljava/lang/Long;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;", "GetPrepareSize_Ljava_lang_Long_Handler")]
			public virtual unsafe global::Bastiaan.TorrentStream.TorrentOptions.Builder PrepareSize (global::Java.Lang.Long prepareSize)
			{
				const string __id = "prepareSize.(Ljava/lang/Long;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((prepareSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) prepareSize).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_proxy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetProxy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_proxy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
					cb_proxy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Proxy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
				return cb_proxy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
			}

			static IntPtr n_Proxy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_host, IntPtr native_username, IntPtr native_password)
			{
				global::Bastiaan.TorrentStream.TorrentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string host = JNIEnv.GetString (native_host, JniHandleOwnership.DoNotTransfer);
				string username = JNIEnv.GetString (native_username, JniHandleOwnership.DoNotTransfer);
				string password = JNIEnv.GetString (native_password, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Proxy (host, username, password));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentOptions.Builder']/method[@name='proxy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("proxy", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;", "GetProxy_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe global::Bastiaan.TorrentStream.TorrentOptions.Builder Proxy (string host, string username, string password)
			{
				const string __id = "proxy.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;";
				IntPtr native_host = JNIEnv.NewString (host);
				IntPtr native_username = JNIEnv.NewString (username);
				IntPtr native_password = JNIEnv.NewString (password);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (native_host);
					__args [1] = new JniArgumentValue (native_username);
					__args [2] = new JniArgumentValue (native_password);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_host);
					JNIEnv.DeleteLocalRef (native_username);
					JNIEnv.DeleteLocalRef (native_password);
				}
			}

			static Delegate cb_removeFilesAfterStop_Ljava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetRemoveFilesAfterStop_Ljava_lang_Boolean_Handler ()
			{
				if (cb_removeFilesAfterStop_Ljava_lang_Boolean_ == null)
					cb_removeFilesAfterStop_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveFilesAfterStop_Ljava_lang_Boolean_);
				return cb_removeFilesAfterStop_Ljava_lang_Boolean_;
			}

			static IntPtr n_RemoveFilesAfterStop_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_b)
			{
				global::Bastiaan.TorrentStream.TorrentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Boolean b = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_b, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveFilesAfterStop (b));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentOptions.Builder']/method[@name='removeFilesAfterStop' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("removeFilesAfterStop", "(Ljava/lang/Boolean;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;", "GetRemoveFilesAfterStop_Ljava_lang_Boolean_Handler")]
			public virtual unsafe global::Bastiaan.TorrentStream.TorrentOptions.Builder RemoveFilesAfterStop (global::Java.Lang.Boolean b)
			{
				const string __id = "removeFilesAfterStop.(Ljava/lang/Boolean;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_saveLocation_Ljava_io_File_;
#pragma warning disable 0169
			static Delegate GetSaveLocation_Ljava_io_File_Handler ()
			{
				if (cb_saveLocation_Ljava_io_File_ == null)
					cb_saveLocation_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveLocation_Ljava_io_File_);
				return cb_saveLocation_Ljava_io_File_;
			}

			static IntPtr n_SaveLocation_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_saveLocation)
			{
				global::Bastiaan.TorrentStream.TorrentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.IO.File saveLocation = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_saveLocation, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SaveLocation (saveLocation));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentOptions.Builder']/method[@name='saveLocation' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
			[Register ("saveLocation", "(Ljava/io/File;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;", "GetSaveLocation_Ljava_io_File_Handler")]
			public virtual unsafe global::Bastiaan.TorrentStream.TorrentOptions.Builder SaveLocation (global::Java.IO.File saveLocation)
			{
				const string __id = "saveLocation.(Ljava/io/File;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((saveLocation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) saveLocation).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_saveLocation_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSaveLocation_Ljava_lang_String_Handler ()
			{
				if (cb_saveLocation_Ljava_lang_String_ == null)
					cb_saveLocation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveLocation_Ljava_lang_String_);
				return cb_saveLocation_Ljava_lang_String_;
			}

			static IntPtr n_SaveLocation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_saveLocation)
			{
				global::Bastiaan.TorrentStream.TorrentOptions.Builder __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string saveLocation = JNIEnv.GetString (native_saveLocation, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SaveLocation (saveLocation));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentOptions.Builder']/method[@name='saveLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("saveLocation", "(Ljava/lang/String;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;", "GetSaveLocation_Ljava_lang_String_Handler")]
			public virtual unsafe global::Bastiaan.TorrentStream.TorrentOptions.Builder SaveLocation (string saveLocation)
			{
				const string __id = "saveLocation.(Ljava/lang/String;)Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;";
				IntPtr native_saveLocation = JNIEnv.NewString (saveLocation);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_saveLocation);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_saveLocation);
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/se_bastiaan/torrentstream/TorrentOptions", typeof (TorrentOptions));
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

		internal TorrentOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='TorrentOptions']/method[@name='toBuilder' and count(parameter)=0]"
		[Register ("toBuilder", "()Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;", "")]
		public unsafe global::Bastiaan.TorrentStream.TorrentOptions.Builder ToBuilder ()
		{
			const string __id = "toBuilder.()Lcom/github/se_bastiaan/torrentstream/TorrentOptions$Builder;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.TorrentOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
