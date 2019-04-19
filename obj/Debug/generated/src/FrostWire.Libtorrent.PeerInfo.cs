using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/PeerInfo", DoNotGenerateAcw=true)]
	public partial class PeerInfo : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo.ConnectionType']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/PeerInfo$ConnectionType", DoNotGenerateAcw=true)]
		public sealed partial class ConnectionType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo.ConnectionType']/field[@name='HTTP_SEED']"
			[Register ("HTTP_SEED")]
			public static global::FrostWire.Libtorrent.PeerInfo.ConnectionType HttpSeed {
				get {
					const string __id = "HTTP_SEED.Lcom/frostwire/jlibtorrent/PeerInfo$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo.ConnectionType']/field[@name='STANDARD_BITTORRENT']"
			[Register ("STANDARD_BITTORRENT")]
			public static global::FrostWire.Libtorrent.PeerInfo.ConnectionType StandardBittorrent {
				get {
					const string __id = "STANDARD_BITTORRENT.Lcom/frostwire/jlibtorrent/PeerInfo$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo.ConnectionType']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::FrostWire.Libtorrent.PeerInfo.ConnectionType Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/frostwire/jlibtorrent/PeerInfo$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo.ConnectionType']/field[@name='WEB_SEED']"
			[Register ("WEB_SEED")]
			public static global::FrostWire.Libtorrent.PeerInfo.ConnectionType WebSeed {
				get {
					const string __id = "WEB_SEED.Lcom/frostwire/jlibtorrent/PeerInfo$ConnectionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo.ConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/PeerInfo$ConnectionType", typeof (ConnectionType));
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

			internal ConnectionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo.ConnectionType']/method[@name='fromSwig' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromSwig", "(I)Lcom/frostwire/jlibtorrent/PeerInfo$ConnectionType;", "")]
			public static unsafe global::FrostWire.Libtorrent.PeerInfo.ConnectionType FromSwig (int swigValue)
			{
				const string __id = "fromSwig.(I)Lcom/frostwire/jlibtorrent/PeerInfo$ConnectionType;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo.ConnectionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo.ConnectionType']/method[@name='swig' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo.ConnectionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/PeerInfo$ConnectionType;", "")]
			public static unsafe global::FrostWire.Libtorrent.PeerInfo.ConnectionType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/PeerInfo$ConnectionType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo.ConnectionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo.ConnectionType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/frostwire/jlibtorrent/PeerInfo$ConnectionType;", "")]
			public static unsafe global::FrostWire.Libtorrent.PeerInfo.ConnectionType[] Values ()
			{
				const string __id = "values.()[Lcom/frostwire/jlibtorrent/PeerInfo$ConnectionType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::FrostWire.Libtorrent.PeerInfo.ConnectionType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.PeerInfo.ConnectionType));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/PeerInfo", typeof (PeerInfo));
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

		protected PeerInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo']/constructor[@name='PeerInfo' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_info']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/peer_info;)V", "")]
		public unsafe PeerInfo (global::FrostWire.Libtorrent.Swig.Peer_info p)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/peer_info;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_client;
#pragma warning disable 0169
		static Delegate GetClientHandler ()
		{
			if (cb_client == null)
				cb_client = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Client);
			return cb_client;
		}

		static IntPtr n_Client (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.PeerInfo __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Client ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo']/method[@name='client' and count(parameter)=0]"
		[Register ("client", "()Ljava/lang/String;", "GetClientHandler")]
		public virtual unsafe string Client ()
		{
			const string __id = "client.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_connectionType;
#pragma warning disable 0169
		static Delegate GetInvokeConnectionTypeHandler ()
		{
			if (cb_connectionType == null)
				cb_connectionType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_InvokeConnectionType);
			return cb_connectionType;
		}

		static IntPtr n_InvokeConnectionType (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.PeerInfo __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InvokeConnectionType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo']/method[@name='connectionType' and count(parameter)=0]"
		[Register ("connectionType", "()Lcom/frostwire/jlibtorrent/PeerInfo$ConnectionType;", "GetInvokeConnectionTypeHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.PeerInfo.ConnectionType InvokeConnectionType ()
		{
			const string __id = "connectionType.()Lcom/frostwire/jlibtorrent/PeerInfo$ConnectionType;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo.ConnectionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_downSpeed;
#pragma warning disable 0169
		static Delegate GetDownSpeedHandler ()
		{
			if (cb_downSpeed == null)
				cb_downSpeed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DownSpeed);
			return cb_downSpeed;
		}

		static int n_DownSpeed (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.PeerInfo __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DownSpeed ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo']/method[@name='downSpeed' and count(parameter)=0]"
		[Register ("downSpeed", "()I", "GetDownSpeedHandler")]
		public virtual unsafe int DownSpeed ()
		{
			const string __id = "downSpeed.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_flags;
#pragma warning disable 0169
		static Delegate GetFlagsHandler ()
		{
			if (cb_flags == null)
				cb_flags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Flags);
			return cb_flags;
		}

		static int n_Flags (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.PeerInfo __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Flags ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo']/method[@name='flags' and count(parameter)=0]"
		[Register ("flags", "()I", "GetFlagsHandler")]
		public virtual unsafe int Flags ()
		{
			const string __id = "flags.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_init_Lcom_frostwire_jlibtorrent_swig_peer_info_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_frostwire_jlibtorrent_swig_peer_info_Handler ()
		{
			if (cb_init_Lcom_frostwire_jlibtorrent_swig_peer_info_ == null)
				cb_init_Lcom_frostwire_jlibtorrent_swig_peer_info_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Lcom_frostwire_jlibtorrent_swig_peer_info_);
			return cb_init_Lcom_frostwire_jlibtorrent_swig_peer_info_;
		}

		static void n_Init_Lcom_frostwire_jlibtorrent_swig_peer_info_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			global::FrostWire.Libtorrent.PeerInfo __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Peer_info p = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (native_p, JniHandleOwnership.DoNotTransfer);
			__this.Init (p);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_info']]"
		[Register ("init", "(Lcom/frostwire/jlibtorrent/swig/peer_info;)V", "GetInit_Lcom_frostwire_jlibtorrent_swig_peer_info_Handler")]
		protected virtual unsafe void Init (global::FrostWire.Libtorrent.Swig.Peer_info p)
		{
			const string __id = "init.(Lcom/frostwire/jlibtorrent/swig/peer_info;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_ip;
#pragma warning disable 0169
		static Delegate GetIpHandler ()
		{
			if (cb_ip == null)
				cb_ip = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Ip);
			return cb_ip;
		}

		static IntPtr n_Ip (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.PeerInfo __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Ip ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo']/method[@name='ip' and count(parameter)=0]"
		[Register ("ip", "()Ljava/lang/String;", "GetIpHandler")]
		public virtual unsafe string Ip ()
		{
			const string __id = "ip.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_progress;
#pragma warning disable 0169
		static Delegate GetProgressHandler ()
		{
			if (cb_progress == null)
				cb_progress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_Progress);
			return cb_progress;
		}

		static float n_Progress (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.PeerInfo __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Progress ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo']/method[@name='progress' and count(parameter)=0]"
		[Register ("progress", "()F", "GetProgressHandler")]
		public virtual unsafe float Progress ()
		{
			const string __id = "progress.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_progressPpm;
#pragma warning disable 0169
		static Delegate GetProgressPpmHandler ()
		{
			if (cb_progressPpm == null)
				cb_progressPpm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ProgressPpm);
			return cb_progressPpm;
		}

		static int n_ProgressPpm (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.PeerInfo __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProgressPpm ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo']/method[@name='progressPpm' and count(parameter)=0]"
		[Register ("progressPpm", "()I", "GetProgressPpmHandler")]
		public virtual unsafe int ProgressPpm ()
		{
			const string __id = "progressPpm.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_source;
#pragma warning disable 0169
		static Delegate GetSourceHandler ()
		{
			if (cb_source == null)
				cb_source = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_Source);
			return cb_source;
		}

		static sbyte n_Source (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.PeerInfo __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Source ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo']/method[@name='source' and count(parameter)=0]"
		[Register ("source", "()B", "GetSourceHandler")]
		public virtual unsafe sbyte Source ()
		{
			const string __id = "source.()B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_totalDownload;
#pragma warning disable 0169
		static Delegate GetTotalDownloadHandler ()
		{
			if (cb_totalDownload == null)
				cb_totalDownload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_TotalDownload);
			return cb_totalDownload;
		}

		static long n_TotalDownload (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.PeerInfo __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalDownload ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo']/method[@name='totalDownload' and count(parameter)=0]"
		[Register ("totalDownload", "()J", "GetTotalDownloadHandler")]
		public virtual unsafe long TotalDownload ()
		{
			const string __id = "totalDownload.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_totalUpload;
#pragma warning disable 0169
		static Delegate GetTotalUploadHandler ()
		{
			if (cb_totalUpload == null)
				cb_totalUpload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_TotalUpload);
			return cb_totalUpload;
		}

		static long n_TotalUpload (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.PeerInfo __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalUpload ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo']/method[@name='totalUpload' and count(parameter)=0]"
		[Register ("totalUpload", "()J", "GetTotalUploadHandler")]
		public virtual unsafe long TotalUpload ()
		{
			const string __id = "totalUpload.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_upSpeed;
#pragma warning disable 0169
		static Delegate GetUpSpeedHandler ()
		{
			if (cb_upSpeed == null)
				cb_upSpeed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_UpSpeed);
			return cb_upSpeed;
		}

		static int n_UpSpeed (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.PeerInfo __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UpSpeed ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PeerInfo']/method[@name='upSpeed' and count(parameter)=0]"
		[Register ("upSpeed", "()I", "GetUpSpeedHandler")]
		public virtual unsafe int UpSpeed ()
		{
			const string __id = "upSpeed.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
