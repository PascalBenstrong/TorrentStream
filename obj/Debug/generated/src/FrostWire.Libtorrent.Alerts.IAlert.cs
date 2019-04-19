using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	[Register ("com/frostwire/jlibtorrent/alerts/Alert", DoNotGenerateAcw=true)]
	public abstract class Alert : Java.Lang.Object {

		internal Alert ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='ALL_CATEGORIES']"
		[Register ("ALL_CATEGORIES")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t AllCategories {
			get {
				const string __id = "ALL_CATEGORIES.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='BLOCK_PROGRESS_NOTIFICATION']"
		[Register ("BLOCK_PROGRESS_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t BlockProgressNotification {
			get {
				const string __id = "BLOCK_PROGRESS_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='DEBUG_NOTIFICATION']"
		[Register ("DEBUG_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t DebugNotification {
			get {
				const string __id = "DEBUG_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='DHT_LOG_NOTIFICATION']"
		[Register ("DHT_LOG_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t DhtLogNotification {
			get {
				const string __id = "DHT_LOG_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='DHT_NOTIFICATION']"
		[Register ("DHT_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t DhtNotification {
			get {
				const string __id = "DHT_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='DHT_OPERATION_NOTIFICATION']"
		[Register ("DHT_OPERATION_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t DhtOperationNotification {
			get {
				const string __id = "DHT_OPERATION_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='ERROR_NOTIFICATION']"
		[Register ("ERROR_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t ErrorNotification {
			get {
				const string __id = "ERROR_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='FILE_PROGRESS_NOTIFICATION']"
		[Register ("FILE_PROGRESS_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t FileProgressNotification {
			get {
				const string __id = "FILE_PROGRESS_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='INCOMING_REQUEST_NOTIFICATION']"
		[Register ("INCOMING_REQUEST_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t IncomingRequestNotification {
			get {
				const string __id = "INCOMING_REQUEST_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='IP_BLOCK_NOTIFICATION']"
		[Register ("IP_BLOCK_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t IpBlockNotification {
			get {
				const string __id = "IP_BLOCK_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='PEER_LOG_NOTIFICATION']"
		[Register ("PEER_LOG_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t PeerLogNotification {
			get {
				const string __id = "PEER_LOG_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='PEER_NOTIFICATION']"
		[Register ("PEER_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t PeerNotification {
			get {
				const string __id = "PEER_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='PERFORMANCE_WARNING']"
		[Register ("PERFORMANCE_WARNING")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t PerformanceWarning {
			get {
				const string __id = "PERFORMANCE_WARNING.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='PICKER_LOG_NOTIFICATION']"
		[Register ("PICKER_LOG_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t PickerLogNotification {
			get {
				const string __id = "PICKER_LOG_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='PIECE_PROGRESS_NOTIFICATION']"
		[Register ("PIECE_PROGRESS_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t PieceProgressNotification {
			get {
				const string __id = "PIECE_PROGRESS_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='PORT_MAPPING_LOG_NOTIFICATION']"
		[Register ("PORT_MAPPING_LOG_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t PortMappingLogNotification {
			get {
				const string __id = "PORT_MAPPING_LOG_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='PORT_MAPPING_NOTIFICATION']"
		[Register ("PORT_MAPPING_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t PortMappingNotification {
			get {
				const string __id = "PORT_MAPPING_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='SESSION_LOG_NOTIFICATION']"
		[Register ("SESSION_LOG_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t SessionLogNotification {
			get {
				const string __id = "SESSION_LOG_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='STATS_NOTIFICATION']"
		[Register ("STATS_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StatsNotification {
			get {
				const string __id = "STATS_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='STATUS_NOTIFICATION']"
		[Register ("STATUS_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StatusNotification {
			get {
				const string __id = "STATUS_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='STORAGE_NOTIFICATION']"
		[Register ("STORAGE_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StorageNotification {
			get {
				const string __id = "STORAGE_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='TORRENT_LOG_NOTIFICATION']"
		[Register ("TORRENT_LOG_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t TorrentLogNotification {
			get {
				const string __id = "TORRENT_LOG_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='TRACKER_NOTIFICATION']"
		[Register ("TRACKER_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t TrackerNotification {
			get {
				const string __id = "TRACKER_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/field[@name='UPLOAD_NOTIFICATION']"
		[Register ("UPLOAD_NOTIFICATION")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t UploadNotification {
			get {
				const string __id = "UPLOAD_NOTIFICATION.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		new static JniPeerMembers _members = new JniPeerMembers ("com/frostwire/jlibtorrent/alerts/Alert", typeof (Alert));
	}

	[Register ("com/frostwire/jlibtorrent/alerts/Alert", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'Alert' type. This type will be removed in a future release.")]
	public abstract class AlertConsts : Alert {

		private AlertConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']"
	[Register ("com/frostwire/jlibtorrent/alerts/Alert", "", "FrostWire.Libtorrent.Alerts.IAlertInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.frostwire.jlibtorrent.swig.alert"})]
	public partial interface IAlert : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/method[@name='category' and count(parameter)=0]"
		[Register ("category", "()Lcom/frostwire/jlibtorrent/swig/alert_category_t;", "GetCategoryHandler:FrostWire.Libtorrent.Alerts.IAlertInvoker, TorrentStream")]
		global::FrostWire.Libtorrent.Swig.Alert_category_t Category ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/method[@name='message' and count(parameter)=0]"
		[Register ("message", "()Ljava/lang/String;", "GetMessageHandler:FrostWire.Libtorrent.Alerts.IAlertInvoker, TorrentStream")]
		string Message ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/alert;", "GetSwigHandler:FrostWire.Libtorrent.Alerts.IAlertInvoker, TorrentStream")]
		global::Java.Lang.Object Swig ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/method[@name='timestamp' and count(parameter)=0]"
		[Register ("timestamp", "()J", "GetTimestampHandler:FrostWire.Libtorrent.Alerts.IAlertInvoker, TorrentStream")]
		long Timestamp ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Lcom/frostwire/jlibtorrent/alerts/AlertType;", "GetTypeHandler:FrostWire.Libtorrent.Alerts.IAlertInvoker, TorrentStream")]
		global::FrostWire.Libtorrent.Alerts.AlertType Type ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/interface[@name='Alert']/method[@name='what' and count(parameter)=0]"
		[Register ("what", "()Ljava/lang/String;", "GetWhatHandler:FrostWire.Libtorrent.Alerts.IAlertInvoker, TorrentStream")]
		string What ();

	}

	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/Alert", DoNotGenerateAcw=true)]
	internal class IAlertInvoker : global::Java.Lang.Object, IAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/frostwire/jlibtorrent/alerts/Alert", typeof (IAlertInvoker));

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

		public static IAlert GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAlert> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.frostwire.jlibtorrent.alerts.Alert"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAlertInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_category;
#pragma warning disable 0169
		static Delegate GetCategoryHandler ()
		{
			if (cb_category == null)
				cb_category = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Category);
			return cb_category;
		}

		static IntPtr n_Category (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Alerts.IAlert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Category ());
		}
#pragma warning restore 0169

		IntPtr id_category;
		public unsafe global::FrostWire.Libtorrent.Swig.Alert_category_t Category ()
		{
			if (id_category == IntPtr.Zero)
				id_category = JNIEnv.GetMethodID (class_ref, "category", "()Lcom/frostwire/jlibtorrent/swig/alert_category_t;");
			return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_category), JniHandleOwnership.TransferLocalRef);
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
			global::FrostWire.Libtorrent.Alerts.IAlert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message ());
		}
#pragma warning restore 0169

		IntPtr id_message;
		public unsafe string Message ()
		{
			if (id_message == IntPtr.Zero)
				id_message = JNIEnv.GetMethodID (class_ref, "message", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_message), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_swig;
#pragma warning disable 0169
		static Delegate GetSwigHandler ()
		{
			if (cb_swig == null)
				cb_swig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Swig);
			return cb_swig;
		}

		static IntPtr n_Swig (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Alerts.IAlert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Swig ());
		}
#pragma warning restore 0169

		IntPtr id_swig;
		public unsafe global::Java.Lang.Object Swig ()
		{
			if (id_swig == IntPtr.Zero)
				id_swig = JNIEnv.GetMethodID (class_ref, "swig", "()Lcom/frostwire/jlibtorrent/swig/alert;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_swig), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_timestamp;
#pragma warning disable 0169
		static Delegate GetTimestampHandler ()
		{
			if (cb_timestamp == null)
				cb_timestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Timestamp);
			return cb_timestamp;
		}

		static long n_Timestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Alerts.IAlert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp ();
		}
#pragma warning restore 0169

		IntPtr id_timestamp;
		public unsafe long Timestamp ()
		{
			if (id_timestamp == IntPtr.Zero)
				id_timestamp = JNIEnv.GetMethodID (class_ref, "timestamp", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_timestamp);
		}

		static Delegate cb_type;
#pragma warning disable 0169
		static Delegate GetTypeHandler ()
		{
			if (cb_type == null)
				cb_type = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Type);
			return cb_type;
		}

		static IntPtr n_Type (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Alerts.IAlert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type ());
		}
#pragma warning restore 0169

		IntPtr id_type;
		public unsafe global::FrostWire.Libtorrent.Alerts.AlertType Type ()
		{
			if (id_type == IntPtr.Zero)
				id_type = JNIEnv.GetMethodID (class_ref, "type", "()Lcom/frostwire/jlibtorrent/alerts/AlertType;");
			return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.AlertType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_type), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_what;
#pragma warning disable 0169
		static Delegate GetWhatHandler ()
		{
			if (cb_what == null)
				cb_what = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_What);
			return cb_what;
		}

		static IntPtr n_What (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Alerts.IAlert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.IAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.What ());
		}
#pragma warning restore 0169

		IntPtr id_what;
		public unsafe string What ()
		{
			if (id_what == IntPtr.Zero)
				id_what = JNIEnv.GetMethodID (class_ref, "what", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_what), JniHandleOwnership.TransferLocalRef);
		}

	}

}
