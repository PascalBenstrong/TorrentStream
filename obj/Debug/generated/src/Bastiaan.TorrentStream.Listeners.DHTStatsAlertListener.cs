using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Bastiaan.TorrentStream.Listeners {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/class[@name='DHTStatsAlertListener']"
	[global::Android.Runtime.Register ("com/github/se_bastiaan/torrentstream/listeners/DHTStatsAlertListener", DoNotGenerateAcw=true)]
	public abstract partial class DHTStatsAlertListener : global::Java.Lang.Object, global::FrostWire.Libtorrent.IAlertListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/se_bastiaan/torrentstream/listeners/DHTStatsAlertListener", typeof (DHTStatsAlertListener));
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

		protected DHTStatsAlertListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/class[@name='DHTStatsAlertListener']/constructor[@name='DHTStatsAlertListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DHTStatsAlertListener ()
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
			global::Bastiaan.TorrentStream.Listeners.DHTStatsAlertListener __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Listeners.DHTStatsAlertListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Alerts.IAlert alert = (global::FrostWire.Libtorrent.Alerts.IAlert)global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IAlert> (native_alert, JniHandleOwnership.DoNotTransfer);
			__this.Alert (alert);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/class[@name='DHTStatsAlertListener']/method[@name='alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.alerts.Alert&lt;?&gt;']]"
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

		static Delegate cb_stats_I;
#pragma warning disable 0169
		static Delegate GetStats_IHandler ()
		{
			if (cb_stats_I == null)
				cb_stats_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Stats_I);
			return cb_stats_I;
		}

		static void n_Stats_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Bastiaan.TorrentStream.Listeners.DHTStatsAlertListener __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Listeners.DHTStatsAlertListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stats (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/class[@name='DHTStatsAlertListener']/method[@name='stats' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("stats", "(I)V", "GetStats_IHandler")]
		public abstract void Stats (int p0);

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
			global::Bastiaan.TorrentStream.Listeners.DHTStatsAlertListener __this = global::Java.Lang.Object.GetObject<global::Bastiaan.TorrentStream.Listeners.DHTStatsAlertListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Types ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/class[@name='DHTStatsAlertListener']/method[@name='types' and count(parameter)=0]"
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

	[global::Android.Runtime.Register ("com/github/se_bastiaan/torrentstream/listeners/DHTStatsAlertListener", DoNotGenerateAcw=true)]
	internal partial class DHTStatsAlertListenerInvoker : DHTStatsAlertListener {

		public DHTStatsAlertListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/se_bastiaan/torrentstream/listeners/DHTStatsAlertListener", typeof (DHTStatsAlertListenerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.listeners']/class[@name='DHTStatsAlertListener']/method[@name='stats' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("stats", "(I)V", "GetStats_IHandler")]
		public override unsafe void Stats (int p0)
		{
			const string __id = "stats.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
