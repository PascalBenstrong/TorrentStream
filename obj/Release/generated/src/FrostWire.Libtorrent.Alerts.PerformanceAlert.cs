using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/PerformanceAlert", DoNotGenerateAcw=true)]
	public sealed partial class PerformanceAlert : global::FrostWire.Libtorrent.Alerts.TorrentAlert {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert.PerformanceWarning']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning", DoNotGenerateAcw=true)]
		public sealed partial class PerformanceWarning : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert.PerformanceWarning']/field[@name='BITTYRANT_WITH_NO_UPLIMIT']"
			[Register ("BITTYRANT_WITH_NO_UPLIMIT")]
			public static global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning BittyrantWithNoUplimit {
				get {
					const string __id = "BITTYRANT_WITH_NO_UPLIMIT.Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert.PerformanceWarning']/field[@name='DOWNLOAD_LIMIT_TOO_LOW']"
			[Register ("DOWNLOAD_LIMIT_TOO_LOW")]
			public static global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning DownloadLimitTooLow {
				get {
					const string __id = "DOWNLOAD_LIMIT_TOO_LOW.Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert.PerformanceWarning']/field[@name='NUM_WARNINGS']"
			[Register ("NUM_WARNINGS")]
			public static global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning NumWarnings {
				get {
					const string __id = "NUM_WARNINGS.Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert.PerformanceWarning']/field[@name='OUTSTANDING_DISK_BUFFER_LIMIT_REACHED']"
			[Register ("OUTSTANDING_DISK_BUFFER_LIMIT_REACHED")]
			public static global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning OutstandingDiskBufferLimitReached {
				get {
					const string __id = "OUTSTANDING_DISK_BUFFER_LIMIT_REACHED.Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert.PerformanceWarning']/field[@name='OUTSTANDING_REQUEST_LIMIT_REACHED']"
			[Register ("OUTSTANDING_REQUEST_LIMIT_REACHED")]
			public static global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning OutstandingRequestLimitReached {
				get {
					const string __id = "OUTSTANDING_REQUEST_LIMIT_REACHED.Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert.PerformanceWarning']/field[@name='SEND_BUFFER_WATERMARK_TOO_LOW']"
			[Register ("SEND_BUFFER_WATERMARK_TOO_LOW")]
			public static global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning SendBufferWatermarkTooLow {
				get {
					const string __id = "SEND_BUFFER_WATERMARK_TOO_LOW.Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert.PerformanceWarning']/field[@name='TOO_FEW_FILE_DESCRIPTORS']"
			[Register ("TOO_FEW_FILE_DESCRIPTORS")]
			public static global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning TooFewFileDescriptors {
				get {
					const string __id = "TOO_FEW_FILE_DESCRIPTORS.Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert.PerformanceWarning']/field[@name='TOO_FEW_OUTGOING_PORTS']"
			[Register ("TOO_FEW_OUTGOING_PORTS")]
			public static global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning TooFewOutgoingPorts {
				get {
					const string __id = "TOO_FEW_OUTGOING_PORTS.Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert.PerformanceWarning']/field[@name='TOO_HIGH_DISK_QUEUE_LIMIT']"
			[Register ("TOO_HIGH_DISK_QUEUE_LIMIT")]
			public static global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning TooHighDiskQueueLimit {
				get {
					const string __id = "TOO_HIGH_DISK_QUEUE_LIMIT.Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert.PerformanceWarning']/field[@name='TOO_MANY_OPTIMISTIC_UNCHOKE_SLOTS']"
			[Register ("TOO_MANY_OPTIMISTIC_UNCHOKE_SLOTS")]
			public static global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning TooManyOptimisticUnchokeSlots {
				get {
					const string __id = "TOO_MANY_OPTIMISTIC_UNCHOKE_SLOTS.Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert.PerformanceWarning']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert.PerformanceWarning']/field[@name='UPLOAD_LIMIT_TOO_LOW']"
			[Register ("UPLOAD_LIMIT_TOO_LOW")]
			public static global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning UploadLimitTooLow {
				get {
					const string __id = "UPLOAD_LIMIT_TOO_LOW.Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning", typeof (PerformanceWarning));
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

			internal PerformanceWarning (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe int Swig {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert.PerformanceWarning']/method[@name='getSwig' and count(parameter)=0]"
				[Register ("getSwig", "()I", "GetGetSwigHandler")]
				get {
					const string __id = "getSwig.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert.PerformanceWarning']/method[@name='fromSwig' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromSwig", "(I)Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning FromSwig (int swigValue)
			{
				const string __id = "fromSwig.(I)Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert.PerformanceWarning']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert.PerformanceWarning']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning[] Values ()
			{
				const string __id = "values.()[Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/PerformanceAlert", typeof (PerformanceAlert));
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

		internal PerformanceAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert']/constructor[@name='PerformanceAlert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.performance_alert']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/performance_alert;)V", "")]
		public unsafe PerformanceAlert (global::FrostWire.Libtorrent.Swig.Performance_alert alert)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/performance_alert;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((alert == null) ? IntPtr.Zero : ((global::Java.Lang.Object) alert).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning WarningCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PerformanceAlert']/method[@name='getWarningCode' and count(parameter)=0]"
			[Register ("getWarningCode", "()Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;", "GetGetWarningCodeHandler")]
			get {
				const string __id = "getWarningCode.()Lcom/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.PerformanceAlert.PerformanceWarning> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
