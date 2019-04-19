using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Bastiaan.TorrentStream.Listeners {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/class[@name='TorrentAddedAlertListener']"
	[global::Android.Runtime.Register ("com/github/se_bastiaan/torrentstream/listeners/TorrentAddedAlertListener", DoNotGenerateAcw=true)]
	public abstract partial class TorrentAddedAlertListener : global::Java.Lang.Object, global::FrostWire.Libtorrent.IAlertListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/se_bastiaan/torrentstream/listeners/TorrentAddedAlertListener", typeof (TorrentAddedAlertListener));
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

		protected TorrentAddedAlertListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/class[@name='TorrentAddedAlertListener']/constructor[@name='TorrentAddedAlertListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TorrentAddedAlertListener ()
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
			global::Bastiaan.TorrentStream.Listeners.TorrentAddedAlertListener __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Listeners.TorrentAddedAlertListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Alerts.IAlert alert = (global::FrostWire.Libtorrent.Alerts.IAlert)global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IAlert> (native_alert, JniHandleOwnership.DoNotTransfer);
			__this.Alert (alert);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/class[@name='TorrentAddedAlertListener']/method[@name='alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.alerts.Alert&lt;?&gt;']]"
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

		static Delegate cb_torrentAdded_Lcom_frostwire_jlibtorrent_alerts_AddTorrentAlert_;
#pragma warning disable 0169
		static Delegate GetTorrentAdded_Lcom_frostwire_jlibtorrent_alerts_AddTorrentAlert_Handler ()
		{
			if (cb_torrentAdded_Lcom_frostwire_jlibtorrent_alerts_AddTorrentAlert_ == null)
				cb_torrentAdded_Lcom_frostwire_jlibtorrent_alerts_AddTorrentAlert_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TorrentAdded_Lcom_frostwire_jlibtorrent_alerts_AddTorrentAlert_);
			return cb_torrentAdded_Lcom_frostwire_jlibtorrent_alerts_AddTorrentAlert_;
		}

		static void n_TorrentAdded_Lcom_frostwire_jlibtorrent_alerts_AddTorrentAlert_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Bastiaan.TorrentStream.Listeners.TorrentAddedAlertListener __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Listeners.TorrentAddedAlertListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Alerts.AddTorrentAlert p0 = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.AddTorrentAlert> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TorrentAdded (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/class[@name='TorrentAddedAlertListener']/method[@name='torrentAdded' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.alerts.AddTorrentAlert']]"
		[Register ("torrentAdded", "(Lcom/frostwire/jlibtorrent/alerts/AddTorrentAlert;)V", "GetTorrentAdded_Lcom_frostwire_jlibtorrent_alerts_AddTorrentAlert_Handler")]
		public abstract void TorrentAdded (global::FrostWire.Libtorrent.Alerts.AddTorrentAlert p0);

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
			global::Bastiaan.TorrentStream.Listeners.TorrentAddedAlertListener __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Listeners.TorrentAddedAlertListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Types ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/class[@name='TorrentAddedAlertListener']/method[@name='types' and count(parameter)=0]"
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

	[global::Android.Runtime.Register ("com/github/se_bastiaan/torrentstream/listeners/TorrentAddedAlertListener", DoNotGenerateAcw=true)]
	internal partial class TorrentAddedAlertListenerInvoker : TorrentAddedAlertListener {

		public TorrentAddedAlertListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/se_bastiaan/torrentstream/listeners/TorrentAddedAlertListener", typeof (TorrentAddedAlertListenerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/class[@name='TorrentAddedAlertListener']/method[@name='torrentAdded' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.alerts.AddTorrentAlert']]"
		[Register ("torrentAdded", "(Lcom/frostwire/jlibtorrent/alerts/AddTorrentAlert;)V", "GetTorrentAdded_Lcom_frostwire_jlibtorrent_alerts_AddTorrentAlert_Handler")]
		public override unsafe void TorrentAdded (global::FrostWire.Libtorrent.Alerts.AddTorrentAlert p0)
		{
			const string __id = "torrentAdded.(Lcom/frostwire/jlibtorrent/alerts/AddTorrentAlert;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
