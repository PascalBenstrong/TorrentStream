using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='AbstractAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/AbstractAlert", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.frostwire.jlibtorrent.swig.alert"})]
	public abstract partial class AbstractAlert : global::Java.Lang.Object, global::FrostWire.Libtorrent.Alerts.IAlert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='AbstractAlert']/field[@name='alert']"
		[Register ("alert")]
		protected global::FrostWire.Libtorrent.Swig.Alert Alert {
			get {
				const string __id = "alert.Lcom/frostwire/jlibtorrent/swig/alert;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "alert.Lcom/frostwire/jlibtorrent/swig/alert;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: com.frostwire.jlibtorrent.alerts.Alert


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
		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/AbstractAlert", typeof (AbstractAlert));
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

		protected AbstractAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::FrostWire.Libtorrent.Alerts.AbstractAlert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.AbstractAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Category ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='AbstractAlert']/method[@name='category' and count(parameter)=0]"
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
			global::FrostWire.Libtorrent.Alerts.AbstractAlert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.AbstractAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='AbstractAlert']/method[@name='message' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='AbstractAlert']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/alert;", "")]
		public unsafe global::Java.Lang.Object Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/alert;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
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
			global::FrostWire.Libtorrent.Alerts.AbstractAlert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.AbstractAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timestamp ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='AbstractAlert']/method[@name='timestamp' and count(parameter)=0]"
		[Register ("timestamp", "()J", "GetTimestampHandler")]
		public virtual unsafe long Timestamp ()
		{
			const string __id = "timestamp.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
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
			global::FrostWire.Libtorrent.Alerts.AbstractAlert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.AbstractAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='AbstractAlert']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Lcom/frostwire/jlibtorrent/alerts/AlertType;", "GetTypeHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Alerts.AlertType Type ()
		{
			const string __id = "type.()Lcom/frostwire/jlibtorrent/alerts/AlertType;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.AlertType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::FrostWire.Libtorrent.Alerts.AbstractAlert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.AbstractAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.What ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='AbstractAlert']/method[@name='what' and count(parameter)=0]"
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

	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/AbstractAlert", DoNotGenerateAcw=true)]
	internal partial class AbstractAlertInvoker : AbstractAlert, global::FrostWire.Libtorrent.Alerts.IAlert {

		public AbstractAlertInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/frostwire/jlibtorrent/alerts/AbstractAlert", typeof (AbstractAlertInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
