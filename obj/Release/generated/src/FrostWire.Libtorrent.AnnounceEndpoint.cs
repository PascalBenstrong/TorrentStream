using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEndpoint']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/AnnounceEndpoint", DoNotGenerateAcw=true)]
	public partial class AnnounceEndpoint : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/AnnounceEndpoint", typeof (AnnounceEndpoint));
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

		protected AnnounceEndpoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEndpoint']/constructor[@name='AnnounceEndpoint' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.announce_endpoint']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/announce_endpoint;)V", "")]
		public unsafe AnnounceEndpoint (global::FrostWire.Libtorrent.Swig.Announce_endpoint e)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/announce_endpoint;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isWorking;
#pragma warning disable 0169
		static Delegate GetIsWorkingHandler ()
		{
			if (cb_isWorking == null)
				cb_isWorking = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsWorking);
			return cb_isWorking;
		}

		static bool n_IsWorking (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.AnnounceEndpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.AnnounceEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsWorking;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsWorking {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEndpoint']/method[@name='isWorking' and count(parameter)=0]"
			[Register ("isWorking", "()Z", "GetIsWorkingHandler")]
			get {
				const string __id = "isWorking.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_fails;
#pragma warning disable 0169
		static Delegate GetFailsHandler ()
		{
			if (cb_fails == null)
				cb_fails = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Fails);
			return cb_fails;
		}

		static int n_Fails (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.AnnounceEndpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.AnnounceEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Fails ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEndpoint']/method[@name='fails' and count(parameter)=0]"
		[Register ("fails", "()I", "GetFailsHandler")]
		public virtual unsafe int Fails ()
		{
			const string __id = "fails.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_init_Lcom_frostwire_jlibtorrent_swig_announce_endpoint_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_frostwire_jlibtorrent_swig_announce_endpoint_Handler ()
		{
			if (cb_init_Lcom_frostwire_jlibtorrent_swig_announce_endpoint_ == null)
				cb_init_Lcom_frostwire_jlibtorrent_swig_announce_endpoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Lcom_frostwire_jlibtorrent_swig_announce_endpoint_);
			return cb_init_Lcom_frostwire_jlibtorrent_swig_announce_endpoint_;
		}

		static void n_Init_Lcom_frostwire_jlibtorrent_swig_announce_endpoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::FrostWire.Libtorrent.AnnounceEndpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.AnnounceEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Announce_endpoint e = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.Init (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEndpoint']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.announce_endpoint']]"
		[Register ("init", "(Lcom/frostwire/jlibtorrent/swig/announce_endpoint;)V", "GetInit_Lcom_frostwire_jlibtorrent_swig_announce_endpoint_Handler")]
		protected virtual unsafe void Init (global::FrostWire.Libtorrent.Swig.Announce_endpoint e)
		{
			const string __id = "init.(Lcom/frostwire/jlibtorrent/swig/announce_endpoint;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_lastError;
#pragma warning disable 0169
		static Delegate GetLastErrorHandler ()
		{
			if (cb_lastError == null)
				cb_lastError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_LastError);
			return cb_lastError;
		}

		static IntPtr n_LastError (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.AnnounceEndpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.AnnounceEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastError ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEndpoint']/method[@name='lastError' and count(parameter)=0]"
		[Register ("lastError", "()Lcom/frostwire/jlibtorrent/ErrorCode;", "GetLastErrorHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.ErrorCode LastError ()
		{
			const string __id = "lastError.()Lcom/frostwire/jlibtorrent/ErrorCode;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.ErrorCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_localEndpoint;
#pragma warning disable 0169
		static Delegate GetLocalEndpointHandler ()
		{
			if (cb_localEndpoint == null)
				cb_localEndpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_LocalEndpoint);
			return cb_localEndpoint;
		}

		static IntPtr n_LocalEndpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.AnnounceEndpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.AnnounceEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalEndpoint ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEndpoint']/method[@name='localEndpoint' and count(parameter)=0]"
		[Register ("localEndpoint", "()Ljava/lang/String;", "GetLocalEndpointHandler")]
		public virtual unsafe string LocalEndpoint ()
		{
			const string __id = "localEndpoint.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_message;
#pragma warning disable 0169
		static Delegate GetMessageHandler ()
		{
			if (cb_message == null)
				cb_message = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Message);
			return cb_message;
		}

		static IntPtr n_Message (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.AnnounceEndpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.AnnounceEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEndpoint']/method[@name='message' and count(parameter)=0]"
		[Register ("message", "()Ljava/lang/String;", "GetMessageHandler")]
		public virtual unsafe string Message ()
		{
			const string __id = "message.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_minAnnounce;
#pragma warning disable 0169
		static Delegate GetMinAnnounceHandler ()
		{
			if (cb_minAnnounce == null)
				cb_minAnnounce = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_MinAnnounce);
			return cb_minAnnounce;
		}

		static long n_MinAnnounce (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.AnnounceEndpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.AnnounceEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinAnnounce ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEndpoint']/method[@name='minAnnounce' and count(parameter)=0]"
		[Register ("minAnnounce", "()J", "GetMinAnnounceHandler")]
		public virtual unsafe long MinAnnounce ()
		{
			const string __id = "minAnnounce.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_nextAnnounce;
#pragma warning disable 0169
		static Delegate GetNextAnnounceHandler ()
		{
			if (cb_nextAnnounce == null)
				cb_nextAnnounce = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_NextAnnounce);
			return cb_nextAnnounce;
		}

		static long n_NextAnnounce (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.AnnounceEndpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.AnnounceEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextAnnounce ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEndpoint']/method[@name='nextAnnounce' and count(parameter)=0]"
		[Register ("nextAnnounce", "()J", "GetNextAnnounceHandler")]
		public virtual unsafe long NextAnnounce ()
		{
			const string __id = "nextAnnounce.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_scrapeComplete;
#pragma warning disable 0169
		static Delegate GetScrapeCompleteHandler ()
		{
			if (cb_scrapeComplete == null)
				cb_scrapeComplete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ScrapeComplete);
			return cb_scrapeComplete;
		}

		static int n_ScrapeComplete (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.AnnounceEndpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.AnnounceEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScrapeComplete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEndpoint']/method[@name='scrapeComplete' and count(parameter)=0]"
		[Register ("scrapeComplete", "()I", "GetScrapeCompleteHandler")]
		public virtual unsafe int ScrapeComplete ()
		{
			const string __id = "scrapeComplete.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_scrapeDownloaded;
#pragma warning disable 0169
		static Delegate GetScrapeDownloadedHandler ()
		{
			if (cb_scrapeDownloaded == null)
				cb_scrapeDownloaded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ScrapeDownloaded);
			return cb_scrapeDownloaded;
		}

		static int n_ScrapeDownloaded (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.AnnounceEndpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.AnnounceEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScrapeDownloaded ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEndpoint']/method[@name='scrapeDownloaded' and count(parameter)=0]"
		[Register ("scrapeDownloaded", "()I", "GetScrapeDownloadedHandler")]
		public virtual unsafe int ScrapeDownloaded ()
		{
			const string __id = "scrapeDownloaded.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_scrapeIncomplete;
#pragma warning disable 0169
		static Delegate GetScrapeIncompleteHandler ()
		{
			if (cb_scrapeIncomplete == null)
				cb_scrapeIncomplete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ScrapeIncomplete);
			return cb_scrapeIncomplete;
		}

		static int n_ScrapeIncomplete (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.AnnounceEndpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.AnnounceEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScrapeIncomplete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEndpoint']/method[@name='scrapeIncomplete' and count(parameter)=0]"
		[Register ("scrapeIncomplete", "()I", "GetScrapeIncompleteHandler")]
		public virtual unsafe int ScrapeIncomplete ()
		{
			const string __id = "scrapeIncomplete.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_updating;
#pragma warning disable 0169
		static Delegate GetUpdatingHandler ()
		{
			if (cb_updating == null)
				cb_updating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Updating);
			return cb_updating;
		}

		static bool n_Updating (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.AnnounceEndpoint __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.AnnounceEndpoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Updating ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEndpoint']/method[@name='updating' and count(parameter)=0]"
		[Register ("updating", "()Z", "GetUpdatingHandler")]
		public virtual unsafe bool Updating ()
		{
			const string __id = "updating.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
