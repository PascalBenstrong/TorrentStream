using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.frostwire.jlibtorrent']/interface[@name='AlertListener']"
	[Register ("com/frostwire/jlibtorrent/AlertListener", "", "FrostWire.Libtorrent.IAlertListenerInvoker")]
	public partial interface IAlertListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/interface[@name='AlertListener']/method[@name='alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.alerts.Alert&lt;?&gt;']]"
		[Register ("alert", "(Lcom/frostwire/jlibtorrent/alerts/Alert;)V", "GetAlert_Lcom_frostwire_jlibtorrent_alerts_Alert_Handler:FrostWire.Libtorrent.IAlertListenerInvoker, TorrentStream")]
		void Alert (global::FrostWire.Libtorrent.Alerts.IAlert p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/interface[@name='AlertListener']/method[@name='types' and count(parameter)=0]"
		[Register ("types", "()[I", "GetTypesHandler:FrostWire.Libtorrent.IAlertListenerInvoker, TorrentStream")]
		int[] Types ();

	}

	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/AlertListener", DoNotGenerateAcw=true)]
	internal class IAlertListenerInvoker : global::Java.Lang.Object, IAlertListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/frostwire/jlibtorrent/AlertListener", typeof (IAlertListenerInvoker));

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

		public static IAlertListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAlertListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.frostwire.jlibtorrent.AlertListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAlertListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_alert_Lcom_frostwire_jlibtorrent_alerts_Alert_;
#pragma warning disable 0169
		static Delegate GetAlert_Lcom_frostwire_jlibtorrent_alerts_Alert_Handler ()
		{
			if (cb_alert_Lcom_frostwire_jlibtorrent_alerts_Alert_ == null)
				cb_alert_Lcom_frostwire_jlibtorrent_alerts_Alert_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Alert_Lcom_frostwire_jlibtorrent_alerts_Alert_);
			return cb_alert_Lcom_frostwire_jlibtorrent_alerts_Alert_;
		}

		static void n_Alert_Lcom_frostwire_jlibtorrent_alerts_Alert_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::FrostWire.Libtorrent.IAlertListener __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.IAlertListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Alerts.IAlert p0 = (global::FrostWire.Libtorrent.Alerts.IAlert)global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IAlert> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Alert (p0);
		}
#pragma warning restore 0169

		IntPtr id_alert_Lcom_frostwire_jlibtorrent_alerts_Alert_;
		public unsafe void Alert (global::FrostWire.Libtorrent.Alerts.IAlert p0)
		{
			if (id_alert_Lcom_frostwire_jlibtorrent_alerts_Alert_ == IntPtr.Zero)
				id_alert_Lcom_frostwire_jlibtorrent_alerts_Alert_ = JNIEnv.GetMethodID (class_ref, "alert", "(Lcom/frostwire/jlibtorrent/alerts/Alert;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_alert_Lcom_frostwire_jlibtorrent_alerts_Alert_, __args);
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
			global::FrostWire.Libtorrent.IAlertListener __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.IAlertListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Types ());
		}
#pragma warning restore 0169

		IntPtr id_types;
		public unsafe int[] Types ()
		{
			if (id_types == IntPtr.Zero)
				id_types = JNIEnv.GetMethodID (class_ref, "types", "()[I");
			return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_types), JniHandleOwnership.TransferLocalRef, typeof (int));
		}

	}

	// event args for com.frostwire.jlibtorrent.AlertListener.alert
	public partial class AlertEventArgs : global::System.EventArgs {

		public AlertEventArgs (global::FrostWire.Libtorrent.Alerts.IAlert p0)
		{
			this.p0 = p0;
		}

		global::FrostWire.Libtorrent.Alerts.IAlert p0;
		public global::FrostWire.Libtorrent.Alerts.IAlert P0 {
			get { return p0; }
		}
	}

	public delegate int[] AlertTypesHandler ();

	[global::Android.Runtime.Register ("mono/com/frostwire/jlibtorrent/AlertListenerImplementor")]
	internal sealed partial class IAlertListenerImplementor : global::Java.Lang.Object, IAlertListener {

		object sender;

		public IAlertListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/frostwire/jlibtorrent/AlertListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AlertEventArgs> AlertHandler;
#pragma warning restore 0649

		public void Alert (global::FrostWire.Libtorrent.Alerts.IAlert p0)
		{
			var __h = AlertHandler;
			if (__h != null)
				__h (sender, new AlertEventArgs (p0));
		}
#pragma warning disable 0649
		public AlertTypesHandler TypesHandler;
#pragma warning restore 0649

		public int[] Types ()
		{
			var __h = TypesHandler;
			return __h != null ? __h () : default (int[]);
		}

		internal static bool __IsEmpty (IAlertListenerImplementor value)
		{
			return value.AlertHandler == null && value.TypesHandler == null;
		}
	}

}
