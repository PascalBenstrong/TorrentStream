using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/alert", DoNotGenerateAcw=true)]
	public partial class Alert : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='all_categories']"
		[Register ("all_categories")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t AllCategories {
			get {
				const string __id = "all_categories.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='block_progress_notification']"
		[Register ("block_progress_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t BlockProgressNotification {
			get {
				const string __id = "block_progress_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='debug_notification']"
		[Register ("debug_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t DebugNotification {
			get {
				const string __id = "debug_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='dht_log_notification']"
		[Register ("dht_log_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t DhtLogNotification {
			get {
				const string __id = "dht_log_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='dht_notification']"
		[Register ("dht_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t DhtNotification {
			get {
				const string __id = "dht_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='dht_operation_notification']"
		[Register ("dht_operation_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t DhtOperationNotification {
			get {
				const string __id = "dht_operation_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='error_notification']"
		[Register ("error_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t ErrorNotification {
			get {
				const string __id = "error_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='file_progress_notification']"
		[Register ("file_progress_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t FileProgressNotification {
			get {
				const string __id = "file_progress_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='incoming_request_notification']"
		[Register ("incoming_request_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t IncomingRequestNotification {
			get {
				const string __id = "incoming_request_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='ip_block_notification']"
		[Register ("ip_block_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t IpBlockNotification {
			get {
				const string __id = "ip_block_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='peer_log_notification']"
		[Register ("peer_log_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t PeerLogNotification {
			get {
				const string __id = "peer_log_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='peer_notification']"
		[Register ("peer_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t PeerNotification {
			get {
				const string __id = "peer_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='performance_warning']"
		[Register ("performance_warning")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t PerformanceWarning {
			get {
				const string __id = "performance_warning.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='picker_log_notification']"
		[Register ("picker_log_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t PickerLogNotification {
			get {
				const string __id = "picker_log_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='piece_progress_notification']"
		[Register ("piece_progress_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t PieceProgressNotification {
			get {
				const string __id = "piece_progress_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='port_mapping_log_notification']"
		[Register ("port_mapping_log_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t PortMappingLogNotification {
			get {
				const string __id = "port_mapping_log_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='port_mapping_notification']"
		[Register ("port_mapping_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t PortMappingNotification {
			get {
				const string __id = "port_mapping_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='session_log_notification']"
		[Register ("session_log_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t SessionLogNotification {
			get {
				const string __id = "session_log_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='stats_notification']"
		[Register ("stats_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StatsNotification {
			get {
				const string __id = "stats_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='status_notification']"
		[Register ("status_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StatusNotification {
			get {
				const string __id = "status_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='storage_notification']"
		[Register ("storage_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StorageNotification {
			get {
				const string __id = "storage_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='swigCMemOwn']"
		[Register ("swigCMemOwn")]
		protected bool SwigCMemOwn {
			get {
				const string __id = "swigCMemOwn.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "swigCMemOwn.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='torrent_log_notification']"
		[Register ("torrent_log_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t TorrentLogNotification {
			get {
				const string __id = "torrent_log_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='tracker_notification']"
		[Register ("tracker_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t TrackerNotification {
			get {
				const string __id = "tracker_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/field[@name='upload_notification']"
		[Register ("upload_notification")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t UploadNotification {
			get {
				const string __id = "upload_notification.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/alert", typeof (Alert));
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

		protected Alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/constructor[@name='alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Alert (long cPtr, bool cMemoryOwn)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (cPtr);
				__args [1] = new JniArgumentValue (cMemoryOwn);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_add_torrent_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_add_torrent_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/add_torrent_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Add_torrent_alert Cast_to_add_torrent_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_add_torrent_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/add_torrent_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_alerts_dropped_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_alerts_dropped_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/alerts_dropped_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Alerts_dropped_alert Cast_to_alerts_dropped_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_alerts_dropped_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/alerts_dropped_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alerts_dropped_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_block_downloading_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_block_downloading_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/block_downloading_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Block_downloading_alert Cast_to_block_downloading_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_block_downloading_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/block_downloading_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_downloading_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_block_finished_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_block_finished_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/block_finished_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Block_finished_alert Cast_to_block_finished_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_block_finished_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/block_finished_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_finished_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_block_timeout_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_block_timeout_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/block_timeout_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Block_timeout_alert Cast_to_block_timeout_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_block_timeout_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/block_timeout_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_timeout_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_block_uploaded_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_block_uploaded_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/block_uploaded_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Block_uploaded_alert Cast_to_block_uploaded_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_block_uploaded_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/block_uploaded_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_uploaded_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_cache_flushed_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_cache_flushed_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/cache_flushed_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Cache_flushed_alert Cast_to_cache_flushed_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_cache_flushed_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/cache_flushed_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Cache_flushed_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_dht_announce_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_dht_announce_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_announce_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Dht_announce_alert Cast_to_dht_announce_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_dht_announce_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_announce_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_announce_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_dht_bootstrap_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_dht_bootstrap_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_bootstrap_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Dht_bootstrap_alert Cast_to_dht_bootstrap_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_dht_bootstrap_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_bootstrap_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_bootstrap_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_dht_direct_response_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_dht_direct_response_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_direct_response_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Dht_direct_response_alert Cast_to_dht_direct_response_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_dht_direct_response_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_direct_response_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_direct_response_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_dht_error_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_dht_error_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_error_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Dht_error_alert Cast_to_dht_error_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_dht_error_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_error_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_error_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_dht_get_peers_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_dht_get_peers_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_get_peers_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Dht_get_peers_alert Cast_to_dht_get_peers_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_dht_get_peers_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_get_peers_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_get_peers_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_dht_get_peers_reply_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_dht_get_peers_reply_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_get_peers_reply_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Dht_get_peers_reply_alert Cast_to_dht_get_peers_reply_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_dht_get_peers_reply_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_get_peers_reply_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_get_peers_reply_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_dht_immutable_item_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_dht_immutable_item_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_immutable_item_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Dht_immutable_item_alert Cast_to_dht_immutable_item_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_dht_immutable_item_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_immutable_item_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_immutable_item_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_dht_live_nodes_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_dht_live_nodes_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_live_nodes_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Dht_live_nodes_alert Cast_to_dht_live_nodes_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_dht_live_nodes_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_live_nodes_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_live_nodes_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_dht_log_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_dht_log_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_log_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Dht_log_alert Cast_to_dht_log_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_dht_log_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_log_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_log_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_dht_mutable_item_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_dht_mutable_item_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_mutable_item_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert Cast_to_dht_mutable_item_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_dht_mutable_item_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_mutable_item_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_mutable_item_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_dht_outgoing_get_peers_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_dht_outgoing_get_peers_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_outgoing_get_peers_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Dht_outgoing_get_peers_alert Cast_to_dht_outgoing_get_peers_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_dht_outgoing_get_peers_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_outgoing_get_peers_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_outgoing_get_peers_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_dht_pkt_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_dht_pkt_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_pkt_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Dht_pkt_alert Cast_to_dht_pkt_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_dht_pkt_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_pkt_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_pkt_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_dht_put_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_dht_put_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_put_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Dht_put_alert Cast_to_dht_put_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_dht_put_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_put_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_put_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_dht_reply_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_dht_reply_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_reply_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Dht_reply_alert Cast_to_dht_reply_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_dht_reply_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_reply_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_reply_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_dht_sample_infohashes_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_dht_sample_infohashes_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_sample_infohashes_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Dht_sample_infohashes_alert Cast_to_dht_sample_infohashes_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_dht_sample_infohashes_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_sample_infohashes_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_sample_infohashes_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_dht_stats_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_dht_stats_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_stats_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Dht_stats_alert Cast_to_dht_stats_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_dht_stats_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/dht_stats_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_stats_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_external_ip_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_external_ip_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/external_ip_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.External_ip_alert Cast_to_external_ip_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_external_ip_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/external_ip_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.External_ip_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_fastresume_rejected_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_fastresume_rejected_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/fastresume_rejected_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Fastresume_rejected_alert Cast_to_fastresume_rejected_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_fastresume_rejected_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/fastresume_rejected_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Fastresume_rejected_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_file_completed_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_file_completed_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/file_completed_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.File_completed_alert Cast_to_file_completed_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_file_completed_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/file_completed_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_completed_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_file_error_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_file_error_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/file_error_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.File_error_alert Cast_to_file_error_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_file_error_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/file_error_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_error_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_file_rename_failed_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_file_rename_failed_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/file_rename_failed_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.File_rename_failed_alert Cast_to_file_rename_failed_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_file_rename_failed_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/file_rename_failed_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_rename_failed_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_file_renamed_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_file_renamed_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/file_renamed_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.File_renamed_alert Cast_to_file_renamed_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_file_renamed_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/file_renamed_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_renamed_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_hash_failed_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_hash_failed_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/hash_failed_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Hash_failed_alert Cast_to_hash_failed_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_hash_failed_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/hash_failed_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Hash_failed_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_i2p_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_i2p_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/i2p_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.I2p_alert Cast_to_i2p_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_i2p_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/i2p_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.I2p_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_incoming_connection_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_incoming_connection_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/incoming_connection_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Incoming_connection_alert Cast_to_incoming_connection_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_incoming_connection_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/incoming_connection_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Incoming_connection_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_incoming_request_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_incoming_request_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/incoming_request_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Incoming_request_alert Cast_to_incoming_request_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_incoming_request_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/incoming_request_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Incoming_request_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_invalid_request_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_invalid_request_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/invalid_request_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Invalid_request_alert Cast_to_invalid_request_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_invalid_request_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/invalid_request_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Invalid_request_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_listen_failed_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_listen_failed_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/listen_failed_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Listen_failed_alert Cast_to_listen_failed_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_listen_failed_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/listen_failed_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Listen_failed_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_listen_succeeded_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_listen_succeeded_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/listen_succeeded_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Listen_succeeded_alert Cast_to_listen_succeeded_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_listen_succeeded_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/listen_succeeded_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Listen_succeeded_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_log_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_log_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/log_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Log_alert Cast_to_log_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_log_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/log_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Log_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_lsd_error_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_lsd_error_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/lsd_error_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Lsd_error_alert Cast_to_lsd_error_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_lsd_error_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/lsd_error_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Lsd_error_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_lsd_peer_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_lsd_peer_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/lsd_peer_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Lsd_peer_alert Cast_to_lsd_peer_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_lsd_peer_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/lsd_peer_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Lsd_peer_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_metadata_failed_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_metadata_failed_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/metadata_failed_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Metadata_failed_alert Cast_to_metadata_failed_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_metadata_failed_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/metadata_failed_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Metadata_failed_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_metadata_received_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_metadata_received_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/metadata_received_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Metadata_received_alert Cast_to_metadata_received_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_metadata_received_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/metadata_received_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Metadata_received_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_peer_ban_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_peer_ban_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/peer_ban_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Peer_ban_alert Cast_to_peer_ban_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_peer_ban_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/peer_ban_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_ban_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_peer_blocked_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_peer_blocked_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/peer_blocked_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Peer_blocked_alert Cast_to_peer_blocked_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_peer_blocked_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/peer_blocked_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_blocked_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_peer_connect_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_peer_connect_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/peer_connect_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Peer_connect_alert Cast_to_peer_connect_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_peer_connect_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/peer_connect_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_connect_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_peer_disconnected_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_peer_disconnected_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/peer_disconnected_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Peer_disconnected_alert Cast_to_peer_disconnected_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_peer_disconnected_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/peer_disconnected_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_disconnected_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_peer_error_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_peer_error_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/peer_error_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Peer_error_alert Cast_to_peer_error_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_peer_error_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/peer_error_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_error_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_peer_log_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_peer_log_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/peer_log_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Peer_log_alert Cast_to_peer_log_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_peer_log_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/peer_log_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_log_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_peer_snubbed_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_peer_snubbed_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/peer_snubbed_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Peer_snubbed_alert Cast_to_peer_snubbed_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_peer_snubbed_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/peer_snubbed_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_snubbed_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_peer_unsnubbed_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_peer_unsnubbed_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/peer_unsnubbed_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Peer_unsnubbed_alert Cast_to_peer_unsnubbed_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_peer_unsnubbed_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/peer_unsnubbed_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_unsnubbed_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_performance_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_performance_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/performance_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Performance_alert Cast_to_performance_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_performance_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/performance_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Performance_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_picker_log_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_picker_log_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/picker_log_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Picker_log_alert Cast_to_picker_log_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_picker_log_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/picker_log_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_log_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_piece_finished_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_piece_finished_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/piece_finished_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Piece_finished_alert Cast_to_piece_finished_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_piece_finished_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/piece_finished_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_finished_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_portmap_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_portmap_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/portmap_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Portmap_alert Cast_to_portmap_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_portmap_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/portmap_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_portmap_error_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_portmap_error_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/portmap_error_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Portmap_error_alert Cast_to_portmap_error_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_portmap_error_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/portmap_error_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_error_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_portmap_log_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_portmap_log_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/portmap_log_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Portmap_log_alert Cast_to_portmap_log_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_portmap_log_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/portmap_log_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Portmap_log_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_read_piece_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_read_piece_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/read_piece_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Read_piece_alert Cast_to_read_piece_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_read_piece_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/read_piece_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Read_piece_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_request_dropped_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_request_dropped_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/request_dropped_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Request_dropped_alert Cast_to_request_dropped_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_request_dropped_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/request_dropped_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Request_dropped_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_save_resume_data_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_save_resume_data_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/save_resume_data_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Save_resume_data_alert Cast_to_save_resume_data_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_save_resume_data_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/save_resume_data_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Save_resume_data_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_save_resume_data_failed_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_save_resume_data_failed_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/save_resume_data_failed_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Save_resume_data_failed_alert Cast_to_save_resume_data_failed_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_save_resume_data_failed_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/save_resume_data_failed_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Save_resume_data_failed_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_scrape_failed_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_scrape_failed_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/scrape_failed_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Scrape_failed_alert Cast_to_scrape_failed_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_scrape_failed_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/scrape_failed_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Scrape_failed_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_scrape_reply_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_scrape_reply_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/scrape_reply_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Scrape_reply_alert Cast_to_scrape_reply_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_scrape_reply_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/scrape_reply_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Scrape_reply_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_session_error_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_session_error_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/session_error_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Session_error_alert Cast_to_session_error_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_session_error_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/session_error_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_error_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_session_stats_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_session_stats_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/session_stats_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Session_stats_alert Cast_to_session_stats_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_session_stats_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/session_stats_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_stats_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_session_stats_header_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_session_stats_header_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/session_stats_header_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Session_stats_header_alert Cast_to_session_stats_header_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_session_stats_header_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/session_stats_header_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Session_stats_header_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_state_changed_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_state_changed_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/state_changed_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.State_changed_alert Cast_to_state_changed_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_state_changed_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/state_changed_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.State_changed_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_state_update_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_state_update_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/state_update_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.State_update_alert Cast_to_state_update_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_state_update_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/state_update_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.State_update_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_stats_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_stats_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/stats_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Stats_alert Cast_to_stats_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_stats_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/stats_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Stats_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_storage_moved_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_storage_moved_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/storage_moved_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Storage_moved_alert Cast_to_storage_moved_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_storage_moved_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/storage_moved_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Storage_moved_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_storage_moved_failed_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_storage_moved_failed_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/storage_moved_failed_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Storage_moved_failed_alert Cast_to_storage_moved_failed_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_storage_moved_failed_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/storage_moved_failed_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Storage_moved_failed_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_torrent_checked_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_torrent_checked_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_checked_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_checked_alert Cast_to_torrent_checked_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_torrent_checked_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_checked_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_checked_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_torrent_delete_failed_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_torrent_delete_failed_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_delete_failed_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_delete_failed_alert Cast_to_torrent_delete_failed_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_torrent_delete_failed_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_delete_failed_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_delete_failed_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_torrent_deleted_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_torrent_deleted_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_deleted_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_deleted_alert Cast_to_torrent_deleted_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_torrent_deleted_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_deleted_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_deleted_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_torrent_error_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_torrent_error_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_error_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_error_alert Cast_to_torrent_error_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_torrent_error_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_error_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_error_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_torrent_finished_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_torrent_finished_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_finished_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_finished_alert Cast_to_torrent_finished_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_torrent_finished_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_finished_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_finished_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_torrent_log_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_torrent_log_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_log_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_log_alert Cast_to_torrent_log_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_torrent_log_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_log_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_log_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_torrent_need_cert_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_torrent_need_cert_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_need_cert_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_need_cert_alert Cast_to_torrent_need_cert_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_torrent_need_cert_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_need_cert_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_need_cert_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_torrent_paused_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_torrent_paused_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_paused_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_paused_alert Cast_to_torrent_paused_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_torrent_paused_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_paused_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_paused_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_torrent_removed_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_torrent_removed_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_removed_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_removed_alert Cast_to_torrent_removed_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_torrent_removed_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_removed_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_removed_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_torrent_resumed_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_torrent_resumed_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_resumed_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Torrent_resumed_alert Cast_to_torrent_resumed_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_torrent_resumed_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/torrent_resumed_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_resumed_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_tracker_announce_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_tracker_announce_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/tracker_announce_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Tracker_announce_alert Cast_to_tracker_announce_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_tracker_announce_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/tracker_announce_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tracker_announce_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_tracker_error_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_tracker_error_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/tracker_error_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Tracker_error_alert Cast_to_tracker_error_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_tracker_error_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/tracker_error_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tracker_error_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_tracker_reply_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_tracker_reply_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/tracker_reply_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Tracker_reply_alert Cast_to_tracker_reply_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_tracker_reply_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/tracker_reply_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tracker_reply_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_tracker_warning_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_tracker_warning_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/tracker_warning_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Tracker_warning_alert Cast_to_tracker_warning_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_tracker_warning_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/tracker_warning_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tracker_warning_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_trackerid_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_trackerid_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/trackerid_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Trackerid_alert Cast_to_trackerid_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_trackerid_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/trackerid_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Trackerid_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_udp_error_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_udp_error_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/udp_error_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Udp_error_alert Cast_to_udp_error_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_udp_error_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/udp_error_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Udp_error_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_unwanted_block_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_unwanted_block_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/unwanted_block_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Unwanted_block_alert Cast_to_unwanted_block_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_unwanted_block_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/unwanted_block_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Unwanted_block_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='cast_to_url_seed_alert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("cast_to_url_seed_alert", "(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/url_seed_alert;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Url_seed_alert Cast_to_url_seed_alert (global::FrostWire.Libtorrent.Swig.Alert a)
		{
			const string __id = "cast_to_url_seed_alert.(Lcom/frostwire/jlibtorrent/swig/alert;)Lcom/frostwire/jlibtorrent/swig/url_seed_alert;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Url_seed_alert> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::FrostWire.Libtorrent.Swig.Alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Category ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='category' and count(parameter)=0]"
		[Register ("category", "()Lcom/frostwire/jlibtorrent/swig/alert_category_t;", "GetCategoryHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Alert_category_t Category ()
		{
			const string __id = "category.()Lcom/frostwire/jlibtorrent/swig/alert_category_t;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_delete;
#pragma warning disable 0169
		static Delegate GetDeleteHandler ()
		{
			if (cb_delete == null)
				cb_delete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Delete);
			return cb_delete;
		}

		static void n_Delete (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/alert;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_timestamp;
#pragma warning disable 0169
		static Delegate GetGet_timestampHandler ()
		{
			if (cb_get_timestamp == null)
				cb_get_timestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Get_timestamp);
			return cb_get_timestamp;
		}

		static long n_Get_timestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_timestamp ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='get_timestamp' and count(parameter)=0]"
		[Register ("get_timestamp", "()J", "GetGet_timestampHandler")]
		public virtual unsafe long Get_timestamp ()
		{
			const string __id = "get_timestamp.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
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
			global::FrostWire.Libtorrent.Swig.Alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='message' and count(parameter)=0]"
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

		static Delegate cb_type;
#pragma warning disable 0169
		static Delegate GetTypeHandler ()
		{
			if (cb_type == null)
				cb_type = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Type);
			return cb_type;
		}

		static int n_Type (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()I", "GetTypeHandler")]
		public virtual unsafe int Type ()
		{
			const string __id = "type.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
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
			global::FrostWire.Libtorrent.Swig.Alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.What ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='alert']/method[@name='what' and count(parameter)=0]"
		[Register ("what", "()Ljava/lang/String;", "GetWhatHandler")]
		public virtual unsafe string What ()
		{
			const string __id = "what.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
