using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StatsAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/StatsAlert", DoNotGenerateAcw=true)]
	public sealed partial class StatsAlert : global::FrostWire.Libtorrent.Alerts.TorrentAlert {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StatsAlert.StatsChannel']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/StatsAlert$StatsChannel", DoNotGenerateAcw=true)]
		public sealed partial class StatsChannel : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StatsAlert.StatsChannel']/field[@name='DOWNLOAD_IP_PROTOCOL']"
			[Register ("DOWNLOAD_IP_PROTOCOL")]
			public static global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel DownloadIpProtocol {
				get {
					const string __id = "DOWNLOAD_IP_PROTOCOL.Lcom/frostwire/jlibtorrent/alerts/StatsAlert$StatsChannel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StatsAlert.StatsChannel']/field[@name='DOWNLOAD_PAYLOAD']"
			[Register ("DOWNLOAD_PAYLOAD")]
			public static global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel DownloadPayload {
				get {
					const string __id = "DOWNLOAD_PAYLOAD.Lcom/frostwire/jlibtorrent/alerts/StatsAlert$StatsChannel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StatsAlert.StatsChannel']/field[@name='DOWNLOAD_PROTOCOL']"
			[Register ("DOWNLOAD_PROTOCOL")]
			public static global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel DownloadProtocol {
				get {
					const string __id = "DOWNLOAD_PROTOCOL.Lcom/frostwire/jlibtorrent/alerts/StatsAlert$StatsChannel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StatsAlert.StatsChannel']/field[@name='NUM_CHANNELS']"
			[Register ("NUM_CHANNELS")]
			public static global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel NumChannels {
				get {
					const string __id = "NUM_CHANNELS.Lcom/frostwire/jlibtorrent/alerts/StatsAlert$StatsChannel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StatsAlert.StatsChannel']/field[@name='UPLOAD_IP_PROTOCOL']"
			[Register ("UPLOAD_IP_PROTOCOL")]
			public static global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel UploadIpProtocol {
				get {
					const string __id = "UPLOAD_IP_PROTOCOL.Lcom/frostwire/jlibtorrent/alerts/StatsAlert$StatsChannel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StatsAlert.StatsChannel']/field[@name='UPLOAD_PAYLOAD']"
			[Register ("UPLOAD_PAYLOAD")]
			public static global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel UploadPayload {
				get {
					const string __id = "UPLOAD_PAYLOAD.Lcom/frostwire/jlibtorrent/alerts/StatsAlert$StatsChannel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StatsAlert.StatsChannel']/field[@name='UPlOAD_PROTOCOL']"
			[Register ("UPlOAD_PROTOCOL")]
			public static global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel UPlOADPROTOCOL {
				get {
					const string __id = "UPlOAD_PROTOCOL.Lcom/frostwire/jlibtorrent/alerts/StatsAlert$StatsChannel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/StatsAlert$StatsChannel", typeof (StatsChannel));
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

			internal StatsChannel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe int Index {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StatsAlert.StatsChannel']/method[@name='getIndex' and count(parameter)=0]"
				[Register ("getIndex", "()I", "GetGetIndexHandler")]
				get {
					const string __id = "getIndex.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StatsAlert.StatsChannel']/method[@name='swig' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StatsAlert.StatsChannel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/StatsAlert$StatsChannel;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/StatsAlert$StatsChannel;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StatsAlert.StatsChannel']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/frostwire/jlibtorrent/alerts/StatsAlert$StatsChannel;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel[] Values ()
			{
				const string __id = "values.()[Lcom/frostwire/jlibtorrent/alerts/StatsAlert$StatsChannel;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.Alerts.StatsAlert.StatsChannel));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/StatsAlert", typeof (StatsAlert));
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

		internal StatsAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StatsAlert']/method[@name='interval' and count(parameter)=0]"
		[Register ("interval", "()I", "")]
		public unsafe int Interval ()
		{
			const string __id = "interval.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='StatsAlert']/method[@name='transferred' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("transferred", "(I)I", "")]
		public unsafe int Transferred (int index)
		{
			const string __id = "transferred.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
