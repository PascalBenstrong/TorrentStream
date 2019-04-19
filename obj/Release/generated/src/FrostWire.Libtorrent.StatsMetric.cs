using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/StatsMetric", DoNotGenerateAcw=true)]
	public sealed partial class StatsMetric : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='DHT_NODES_GAUGE_INDEX']"
		[Register ("DHT_NODES_GAUGE_INDEX")]
		public static int DhtNodesGaugeIndex {
			get {
				const string __id = "DHT_NODES_GAUGE_INDEX.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='DHT_NODES_GAUGE_NAME']"
		[Register ("DHT_NODES_GAUGE_NAME")]
		public const string DhtNodesGaugeName = (string) "dht.dht_nodes";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='NET_RECV_BYTES_COUNTER_INDEX']"
		[Register ("NET_RECV_BYTES_COUNTER_INDEX")]
		public static int NetRecvBytesCounterIndex {
			get {
				const string __id = "NET_RECV_BYTES_COUNTER_INDEX.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='NET_RECV_BYTES_COUNTER_NAME']"
		[Register ("NET_RECV_BYTES_COUNTER_NAME")]
		public const string NetRecvBytesCounterName = (string) "net.recv_bytes";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='NET_RECV_IP_OVERHEAD_BYTES_COUNTER_INDEX']"
		[Register ("NET_RECV_IP_OVERHEAD_BYTES_COUNTER_INDEX")]
		public static int NetRecvIpOverheadBytesCounterIndex {
			get {
				const string __id = "NET_RECV_IP_OVERHEAD_BYTES_COUNTER_INDEX.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='NET_RECV_IP_OVERHEAD_BYTES_COUNTER_NAME']"
		[Register ("NET_RECV_IP_OVERHEAD_BYTES_COUNTER_NAME")]
		public const string NetRecvIpOverheadBytesCounterName = (string) "net.recv_ip_overhead_bytes";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='NET_RECV_PAYLOAD_BYTES_COUNTER_INDEX']"
		[Register ("NET_RECV_PAYLOAD_BYTES_COUNTER_INDEX")]
		public static int NetRecvPayloadBytesCounterIndex {
			get {
				const string __id = "NET_RECV_PAYLOAD_BYTES_COUNTER_INDEX.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='NET_RECV_PAYLOAD_BYTES_COUNTER_NAME']"
		[Register ("NET_RECV_PAYLOAD_BYTES_COUNTER_NAME")]
		public const string NetRecvPayloadBytesCounterName = (string) "net.recv_payload_bytes";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='NET_SENT_BYTES_COUNTER_INDEX']"
		[Register ("NET_SENT_BYTES_COUNTER_INDEX")]
		public static int NetSentBytesCounterIndex {
			get {
				const string __id = "NET_SENT_BYTES_COUNTER_INDEX.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='NET_SENT_BYTES_COUNTER_NAME']"
		[Register ("NET_SENT_BYTES_COUNTER_NAME")]
		public const string NetSentBytesCounterName = (string) "net.sent_bytes";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='NET_SENT_IP_OVERHEAD_BYTES_COUNTER_INDEX']"
		[Register ("NET_SENT_IP_OVERHEAD_BYTES_COUNTER_INDEX")]
		public static int NetSentIpOverheadBytesCounterIndex {
			get {
				const string __id = "NET_SENT_IP_OVERHEAD_BYTES_COUNTER_INDEX.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='NET_SENT_IP_OVERHEAD_BYTES_COUNTER_NAME']"
		[Register ("NET_SENT_IP_OVERHEAD_BYTES_COUNTER_NAME")]
		public const string NetSentIpOverheadBytesCounterName = (string) "net.sent_ip_overhead_bytes";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='NET_SENT_PAYLOAD_BYTES_COUNTER_INDEX']"
		[Register ("NET_SENT_PAYLOAD_BYTES_COUNTER_INDEX")]
		public static int NetSentPayloadBytesCounterIndex {
			get {
				const string __id = "NET_SENT_PAYLOAD_BYTES_COUNTER_INDEX.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='NET_SENT_PAYLOAD_BYTES_COUNTER_NAME']"
		[Register ("NET_SENT_PAYLOAD_BYTES_COUNTER_NAME")]
		public const string NetSentPayloadBytesCounterName = (string) "net.sent_payload_bytes";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='TYPE_COUNTER']"
		[Register ("TYPE_COUNTER")]
		public static int TypeCounter {
			get {
				const string __id = "TYPE_COUNTER.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='TYPE_GAUGE']"
		[Register ("TYPE_GAUGE")]
		public static int TypeGauge {
			get {
				const string __id = "TYPE_GAUGE.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				const string __id = "name.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "name.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='type']"
		[Register ("type")]
		public int Type {
			get {
				const string __id = "type.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "type.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='StatsMetric']/field[@name='valueIndex']"
		[Register ("valueIndex")]
		public int ValueIndex {
			get {
				const string __id = "valueIndex.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "valueIndex.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/StatsMetric", typeof (StatsMetric));
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

		internal StatsMetric (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
