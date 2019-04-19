using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/settings_pack", DoNotGenerateAcw=true)]
	public partial class Settings_pack : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack']/field[@name='swigCMemOwn']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bandwidth_mixed_algo_t']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/settings_pack$bandwidth_mixed_algo_t", DoNotGenerateAcw=true)]
		public sealed partial class Bandwidth_mixed_algo_t : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bandwidth_mixed_algo_t']/field[@name='peer_proportional']"
			[Register ("peer_proportional")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bandwidth_mixed_algo_t PeerProportional {
				get {
					const string __id = "peer_proportional.Lcom/frostwire/jlibtorrent/swig/settings_pack$bandwidth_mixed_algo_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bandwidth_mixed_algo_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bandwidth_mixed_algo_t']/field[@name='prefer_tcp']"
			[Register ("prefer_tcp")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bandwidth_mixed_algo_t PreferTcp {
				get {
					const string __id = "prefer_tcp.Lcom/frostwire/jlibtorrent/swig/settings_pack$bandwidth_mixed_algo_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bandwidth_mixed_algo_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/settings_pack$bandwidth_mixed_algo_t", typeof (Bandwidth_mixed_algo_t));
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

			internal Bandwidth_mixed_algo_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bandwidth_mixed_algo_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$bandwidth_mixed_algo_t;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Settings_pack.Bandwidth_mixed_algo_t SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$bandwidth_mixed_algo_t;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bandwidth_mixed_algo_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bandwidth_mixed_algo_t']/method[@name='swigValue' and count(parameter)=0]"
			[Register ("swigValue", "()I", "")]
			public unsafe int SwigValue ()
			{
				const string __id = "swigValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/settings_pack$bool_types", DoNotGenerateAcw=true)]
		public sealed partial class Bool_types : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='allow_i2p_mixed']"
			[Register ("allow_i2p_mixed")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types AllowI2pMixed {
				get {
					const string __id = "allow_i2p_mixed.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='allow_multiple_connections_per_ip']"
			[Register ("allow_multiple_connections_per_ip")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types AllowMultipleConnectionsPerIp {
				get {
					const string __id = "allow_multiple_connections_per_ip.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='allow_partial_disk_writes']"
			[Register ("allow_partial_disk_writes")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types AllowPartialDiskWrites {
				get {
					const string __id = "allow_partial_disk_writes.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='always_send_user_agent']"
			[Register ("always_send_user_agent")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types AlwaysSendUserAgent {
				get {
					const string __id = "always_send_user_agent.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='announce_crypto_support']"
			[Register ("announce_crypto_support")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types AnnounceCryptoSupport {
				get {
					const string __id = "announce_crypto_support.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='announce_to_all_tiers']"
			[Register ("announce_to_all_tiers")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types AnnounceToAllTiers {
				get {
					const string __id = "announce_to_all_tiers.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='announce_to_all_trackers']"
			[Register ("announce_to_all_trackers")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types AnnounceToAllTrackers {
				get {
					const string __id = "announce_to_all_trackers.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='anonymous_mode']"
			[Register ("anonymous_mode")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types AnonymousMode {
				get {
					const string __id = "anonymous_mode.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='apply_ip_filter_to_trackers']"
			[Register ("apply_ip_filter_to_trackers")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types ApplyIpFilterToTrackers {
				get {
					const string __id = "apply_ip_filter_to_trackers.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='auto_manage_prefer_seeds']"
			[Register ("auto_manage_prefer_seeds")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types AutoManagePreferSeeds {
				get {
					const string __id = "auto_manage_prefer_seeds.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='auto_sequential']"
			[Register ("auto_sequential")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types AutoSequential {
				get {
					const string __id = "auto_sequential.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='ban_web_seeds']"
			[Register ("ban_web_seeds")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types BanWebSeeds {
				get {
					const string __id = "ban_web_seeds.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='broadcast_lsd']"
			[Register ("broadcast_lsd")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types BroadcastLsd {
				get {
					const string __id = "broadcast_lsd.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='close_redundant_connections']"
			[Register ("close_redundant_connections")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types CloseRedundantConnections {
				get {
					const string __id = "close_redundant_connections.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='coalesce_reads']"
			[Register ("coalesce_reads")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types CoalesceReads {
				get {
					const string __id = "coalesce_reads.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='coalesce_writes']"
			[Register ("coalesce_writes")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types CoalesceWrites {
				get {
					const string __id = "coalesce_writes.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='disable_hash_checks']"
			[Register ("disable_hash_checks")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types DisableHashChecks {
				get {
					const string __id = "disable_hash_checks.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='dont_count_slow_torrents']"
			[Register ("dont_count_slow_torrents")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types DontCountSlowTorrents {
				get {
					const string __id = "dont_count_slow_torrents.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='enable_dht']"
			[Register ("enable_dht")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types EnableDht {
				get {
					const string __id = "enable_dht.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='enable_incoming_tcp']"
			[Register ("enable_incoming_tcp")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types EnableIncomingTcp {
				get {
					const string __id = "enable_incoming_tcp.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='enable_incoming_utp']"
			[Register ("enable_incoming_utp")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types EnableIncomingUtp {
				get {
					const string __id = "enable_incoming_utp.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='enable_ip_notifier']"
			[Register ("enable_ip_notifier")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types EnableIpNotifier {
				get {
					const string __id = "enable_ip_notifier.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='enable_lsd']"
			[Register ("enable_lsd")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types EnableLsd {
				get {
					const string __id = "enable_lsd.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='enable_natpmp']"
			[Register ("enable_natpmp")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types EnableNatpmp {
				get {
					const string __id = "enable_natpmp.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='enable_outgoing_tcp']"
			[Register ("enable_outgoing_tcp")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types EnableOutgoingTcp {
				get {
					const string __id = "enable_outgoing_tcp.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='enable_outgoing_utp']"
			[Register ("enable_outgoing_utp")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types EnableOutgoingUtp {
				get {
					const string __id = "enable_outgoing_utp.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='enable_upnp']"
			[Register ("enable_upnp")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types EnableUpnp {
				get {
					const string __id = "enable_upnp.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='incoming_starts_queued_torrents']"
			[Register ("incoming_starts_queued_torrents")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types IncomingStartsQueuedTorrents {
				get {
					const string __id = "incoming_starts_queued_torrents.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='listen_system_port_fallback']"
			[Register ("listen_system_port_fallback")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types ListenSystemPortFallback {
				get {
					const string __id = "listen_system_port_fallback.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='max_bool_setting_internal']"
			[Register ("max_bool_setting_internal")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types MaxBoolSettingInternal {
				get {
					const string __id = "max_bool_setting_internal.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='no_atime_storage']"
			[Register ("no_atime_storage")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types NoAtimeStorage {
				get {
					const string __id = "no_atime_storage.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='no_connect_privileged_ports']"
			[Register ("no_connect_privileged_ports")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types NoConnectPrivilegedPorts {
				get {
					const string __id = "no_connect_privileged_ports.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='no_recheck_incomplete_resume']"
			[Register ("no_recheck_incomplete_resume")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types NoRecheckIncompleteResume {
				get {
					const string __id = "no_recheck_incomplete_resume.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='prefer_rc4']"
			[Register ("prefer_rc4")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types PreferRc4 {
				get {
					const string __id = "prefer_rc4.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='prefer_udp_trackers']"
			[Register ("prefer_udp_trackers")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types PreferUdpTrackers {
				get {
					const string __id = "prefer_udp_trackers.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='prioritize_partial_pieces']"
			[Register ("prioritize_partial_pieces")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types PrioritizePartialPieces {
				get {
					const string __id = "prioritize_partial_pieces.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='proxy_hostnames']"
			[Register ("proxy_hostnames")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types ProxyHostnames {
				get {
					const string __id = "proxy_hostnames.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='proxy_peer_connections']"
			[Register ("proxy_peer_connections")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types ProxyPeerConnections {
				get {
					const string __id = "proxy_peer_connections.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='proxy_tracker_connections']"
			[Register ("proxy_tracker_connections")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types ProxyTrackerConnections {
				get {
					const string __id = "proxy_tracker_connections.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='rate_limit_ip_overhead']"
			[Register ("rate_limit_ip_overhead")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types RateLimitIpOverhead {
				get {
					const string __id = "rate_limit_ip_overhead.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='report_redundant_bytes']"
			[Register ("report_redundant_bytes")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types ReportRedundantBytes {
				get {
					const string __id = "report_redundant_bytes.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='report_true_downloaded']"
			[Register ("report_true_downloaded")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types ReportTrueDownloaded {
				get {
					const string __id = "report_true_downloaded.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='report_web_seed_downloads']"
			[Register ("report_web_seed_downloads")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types ReportWebSeedDownloads {
				get {
					const string __id = "report_web_seed_downloads.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='seeding_outgoing_connections']"
			[Register ("seeding_outgoing_connections")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types SeedingOutgoingConnections {
				get {
					const string __id = "seeding_outgoing_connections.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='send_redundant_have']"
			[Register ("send_redundant_have")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types SendRedundantHave {
				get {
					const string __id = "send_redundant_have.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='smooth_connects']"
			[Register ("smooth_connects")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types SmoothConnects {
				get {
					const string __id = "smooth_connects.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='strict_end_game_mode']"
			[Register ("strict_end_game_mode")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types StrictEndGameMode {
				get {
					const string __id = "strict_end_game_mode.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='strict_super_seeding']"
			[Register ("strict_super_seeding")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types StrictSuperSeeding {
				get {
					const string __id = "strict_super_seeding.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='support_merkle_torrents']"
			[Register ("support_merkle_torrents")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types SupportMerkleTorrents {
				get {
					const string __id = "support_merkle_torrents.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='support_share_mode']"
			[Register ("support_share_mode")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types SupportShareMode {
				get {
					const string __id = "support_share_mode.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='upnp_ignore_nonrouters']"
			[Register ("upnp_ignore_nonrouters")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types UpnpIgnoreNonrouters {
				get {
					const string __id = "upnp_ignore_nonrouters.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='use_dht_as_fallback']"
			[Register ("use_dht_as_fallback")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types UseDhtAsFallback {
				get {
					const string __id = "use_dht_as_fallback.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='use_parole_mode']"
			[Register ("use_parole_mode")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types UseParoleMode {
				get {
					const string __id = "use_parole_mode.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='use_read_cache']"
			[Register ("use_read_cache")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types UseReadCache {
				get {
					const string __id = "use_read_cache.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/field[@name='volatile_read_cache']"
			[Register ("volatile_read_cache")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types VolatileReadCache {
				get {
					const string __id = "volatile_read_cache.Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/settings_pack$bool_types", typeof (Bool_types));
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

			internal Bool_types (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$bool_types;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Bool_types> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.bool_types']/method[@name='swigValue' and count(parameter)=0]"
			[Register ("swigValue", "()I", "")]
			public unsafe int SwigValue ()
			{
				const string __id = "swigValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.choking_algorithm_t']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/settings_pack$choking_algorithm_t", DoNotGenerateAcw=true)]
		public sealed partial class Choking_algorithm_t : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.choking_algorithm_t']/field[@name='bittyrant_choker']"
			[Register ("bittyrant_choker")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Choking_algorithm_t BittyrantChoker {
				get {
					const string __id = "bittyrant_choker.Lcom/frostwire/jlibtorrent/swig/settings_pack$choking_algorithm_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Choking_algorithm_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.choking_algorithm_t']/field[@name='fixed_slots_choker']"
			[Register ("fixed_slots_choker")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Choking_algorithm_t FixedSlotsChoker {
				get {
					const string __id = "fixed_slots_choker.Lcom/frostwire/jlibtorrent/swig/settings_pack$choking_algorithm_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Choking_algorithm_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.choking_algorithm_t']/field[@name='rate_based_choker']"
			[Register ("rate_based_choker")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Choking_algorithm_t RateBasedChoker {
				get {
					const string __id = "rate_based_choker.Lcom/frostwire/jlibtorrent/swig/settings_pack$choking_algorithm_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Choking_algorithm_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/settings_pack$choking_algorithm_t", typeof (Choking_algorithm_t));
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

			internal Choking_algorithm_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.choking_algorithm_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$choking_algorithm_t;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Settings_pack.Choking_algorithm_t SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$choking_algorithm_t;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Choking_algorithm_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.choking_algorithm_t']/method[@name='swigValue' and count(parameter)=0]"
			[Register ("swigValue", "()I", "")]
			public unsafe int SwigValue ()
			{
				const string __id = "swigValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.enc_level']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/settings_pack$enc_level", DoNotGenerateAcw=true)]
		public sealed partial class Enc_level : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.enc_level']/field[@name='pe_both']"
			[Register ("pe_both")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Enc_level PeBoth {
				get {
					const string __id = "pe_both.Lcom/frostwire/jlibtorrent/swig/settings_pack$enc_level;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Enc_level> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.enc_level']/field[@name='pe_plaintext']"
			[Register ("pe_plaintext")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Enc_level PePlaintext {
				get {
					const string __id = "pe_plaintext.Lcom/frostwire/jlibtorrent/swig/settings_pack$enc_level;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Enc_level> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.enc_level']/field[@name='pe_rc4']"
			[Register ("pe_rc4")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Enc_level PeRc4 {
				get {
					const string __id = "pe_rc4.Lcom/frostwire/jlibtorrent/swig/settings_pack$enc_level;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Enc_level> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/settings_pack$enc_level", typeof (Enc_level));
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

			internal Enc_level (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.enc_level']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$enc_level;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Settings_pack.Enc_level SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$enc_level;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Enc_level> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.enc_level']/method[@name='swigValue' and count(parameter)=0]"
			[Register ("swigValue", "()I", "")]
			public unsafe int SwigValue ()
			{
				const string __id = "swigValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.enc_policy']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/settings_pack$enc_policy", DoNotGenerateAcw=true)]
		public sealed partial class Enc_policy : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.enc_policy']/field[@name='pe_disabled']"
			[Register ("pe_disabled")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Enc_policy PeDisabled {
				get {
					const string __id = "pe_disabled.Lcom/frostwire/jlibtorrent/swig/settings_pack$enc_policy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Enc_policy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.enc_policy']/field[@name='pe_enabled']"
			[Register ("pe_enabled")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Enc_policy PeEnabled {
				get {
					const string __id = "pe_enabled.Lcom/frostwire/jlibtorrent/swig/settings_pack$enc_policy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Enc_policy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.enc_policy']/field[@name='pe_forced']"
			[Register ("pe_forced")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Enc_policy PeForced {
				get {
					const string __id = "pe_forced.Lcom/frostwire/jlibtorrent/swig/settings_pack$enc_policy;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Enc_policy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/settings_pack$enc_policy", typeof (Enc_policy));
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

			internal Enc_policy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.enc_policy']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$enc_policy;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Settings_pack.Enc_policy SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$enc_policy;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Enc_policy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.enc_policy']/method[@name='swigValue' and count(parameter)=0]"
			[Register ("swigValue", "()I", "")]
			public unsafe int SwigValue ()
			{
				const string __id = "swigValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/settings_pack$int_types", DoNotGenerateAcw=true)]
		public sealed partial class Int_types : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='active_checking']"
			[Register ("active_checking")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ActiveChecking {
				get {
					const string __id = "active_checking.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='active_dht_limit']"
			[Register ("active_dht_limit")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ActiveDhtLimit {
				get {
					const string __id = "active_dht_limit.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='active_downloads']"
			[Register ("active_downloads")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ActiveDownloads {
				get {
					const string __id = "active_downloads.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='active_limit']"
			[Register ("active_limit")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ActiveLimit {
				get {
					const string __id = "active_limit.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='active_lsd_limit']"
			[Register ("active_lsd_limit")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ActiveLsdLimit {
				get {
					const string __id = "active_lsd_limit.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='active_seeds']"
			[Register ("active_seeds")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ActiveSeeds {
				get {
					const string __id = "active_seeds.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='active_tracker_limit']"
			[Register ("active_tracker_limit")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ActiveTrackerLimit {
				get {
					const string __id = "active_tracker_limit.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='aio_max']"
			[Register ("aio_max")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types AioMax {
				get {
					const string __id = "aio_max.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='aio_threads']"
			[Register ("aio_threads")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types AioThreads {
				get {
					const string __id = "aio_threads.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='alert_mask']"
			[Register ("alert_mask")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types AlertMask {
				get {
					const string __id = "alert_mask.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='alert_queue_size']"
			[Register ("alert_queue_size")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types AlertQueueSize {
				get {
					const string __id = "alert_queue_size.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='allowed_enc_level']"
			[Register ("allowed_enc_level")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types AllowedEncLevel {
				get {
					const string __id = "allowed_enc_level.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='allowed_fast_set_size']"
			[Register ("allowed_fast_set_size")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types AllowedFastSetSize {
				get {
					const string __id = "allowed_fast_set_size.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='auto_manage_interval']"
			[Register ("auto_manage_interval")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types AutoManageInterval {
				get {
					const string __id = "auto_manage_interval.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='auto_manage_startup']"
			[Register ("auto_manage_startup")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types AutoManageStartup {
				get {
					const string __id = "auto_manage_startup.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='auto_scrape_interval']"
			[Register ("auto_scrape_interval")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types AutoScrapeInterval {
				get {
					const string __id = "auto_scrape_interval.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='auto_scrape_min_interval']"
			[Register ("auto_scrape_min_interval")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types AutoScrapeMinInterval {
				get {
					const string __id = "auto_scrape_min_interval.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='cache_expiry']"
			[Register ("cache_expiry")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types CacheExpiry {
				get {
					const string __id = "cache_expiry.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='cache_size']"
			[Register ("cache_size")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types CacheSize {
				get {
					const string __id = "cache_size.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='cache_size_volatile']"
			[Register ("cache_size_volatile")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types CacheSizeVolatile {
				get {
					const string __id = "cache_size_volatile.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='checking_mem_usage']"
			[Register ("checking_mem_usage")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types CheckingMemUsage {
				get {
					const string __id = "checking_mem_usage.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='choking_algorithm']"
			[Register ("choking_algorithm")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ChokingAlgorithm {
				get {
					const string __id = "choking_algorithm.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='close_file_interval']"
			[Register ("close_file_interval")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types CloseFileInterval {
				get {
					const string __id = "close_file_interval.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='connect_seed_every_n_download']"
			[Register ("connect_seed_every_n_download")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ConnectSeedEveryNDownload {
				get {
					const string __id = "connect_seed_every_n_download.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='connection_speed']"
			[Register ("connection_speed")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ConnectionSpeed {
				get {
					const string __id = "connection_speed.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='connections_limit']"
			[Register ("connections_limit")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ConnectionsLimit {
				get {
					const string __id = "connections_limit.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='connections_slack']"
			[Register ("connections_slack")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ConnectionsSlack {
				get {
					const string __id = "connections_slack.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='decrease_est_reciprocation_rate']"
			[Register ("decrease_est_reciprocation_rate")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types DecreaseEstReciprocationRate {
				get {
					const string __id = "decrease_est_reciprocation_rate.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='default_est_reciprocation_rate']"
			[Register ("default_est_reciprocation_rate")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types DefaultEstReciprocationRate {
				get {
					const string __id = "default_est_reciprocation_rate.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='dht_announce_interval']"
			[Register ("dht_announce_interval")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types DhtAnnounceInterval {
				get {
					const string __id = "dht_announce_interval.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='disk_io_read_mode']"
			[Register ("disk_io_read_mode")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types DiskIoReadMode {
				get {
					const string __id = "disk_io_read_mode.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='disk_io_write_mode']"
			[Register ("disk_io_write_mode")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types DiskIoWriteMode {
				get {
					const string __id = "disk_io_write_mode.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='download_rate_limit']"
			[Register ("download_rate_limit")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types DownloadRateLimit {
				get {
					const string __id = "download_rate_limit.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='file_pool_size']"
			[Register ("file_pool_size")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types FilePoolSize {
				get {
					const string __id = "file_pool_size.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='handshake_timeout']"
			[Register ("handshake_timeout")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types HandshakeTimeout {
				get {
					const string __id = "handshake_timeout.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='i2p_port']"
			[Register ("i2p_port")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types I2pPort {
				get {
					const string __id = "i2p_port.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='in_enc_policy']"
			[Register ("in_enc_policy")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types InEncPolicy {
				get {
					const string __id = "in_enc_policy.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='inactive_down_rate']"
			[Register ("inactive_down_rate")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types InactiveDownRate {
				get {
					const string __id = "inactive_down_rate.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='inactive_up_rate']"
			[Register ("inactive_up_rate")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types InactiveUpRate {
				get {
					const string __id = "inactive_up_rate.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='inactivity_timeout']"
			[Register ("inactivity_timeout")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types InactivityTimeout {
				get {
					const string __id = "inactivity_timeout.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='increase_est_reciprocation_rate']"
			[Register ("increase_est_reciprocation_rate")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types IncreaseEstReciprocationRate {
				get {
					const string __id = "increase_est_reciprocation_rate.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='initial_picker_threshold']"
			[Register ("initial_picker_threshold")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types InitialPickerThreshold {
				get {
					const string __id = "initial_picker_threshold.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='listen_queue_size']"
			[Register ("listen_queue_size")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ListenQueueSize {
				get {
					const string __id = "listen_queue_size.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='local_service_announce_interval']"
			[Register ("local_service_announce_interval")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types LocalServiceAnnounceInterval {
				get {
					const string __id = "local_service_announce_interval.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='max_allowed_in_request_queue']"
			[Register ("max_allowed_in_request_queue")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types MaxAllowedInRequestQueue {
				get {
					const string __id = "max_allowed_in_request_queue.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='max_failcount']"
			[Register ("max_failcount")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types MaxFailcount {
				get {
					const string __id = "max_failcount.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='max_http_recv_buffer_size']"
			[Register ("max_http_recv_buffer_size")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types MaxHttpRecvBufferSize {
				get {
					const string __id = "max_http_recv_buffer_size.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='max_int_setting_internal']"
			[Register ("max_int_setting_internal")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types MaxIntSettingInternal {
				get {
					const string __id = "max_int_setting_internal.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='max_metadata_size']"
			[Register ("max_metadata_size")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types MaxMetadataSize {
				get {
					const string __id = "max_metadata_size.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='max_out_request_queue']"
			[Register ("max_out_request_queue")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types MaxOutRequestQueue {
				get {
					const string __id = "max_out_request_queue.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='max_paused_peerlist_size']"
			[Register ("max_paused_peerlist_size")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types MaxPausedPeerlistSize {
				get {
					const string __id = "max_paused_peerlist_size.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='max_peer_recv_buffer_size']"
			[Register ("max_peer_recv_buffer_size")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types MaxPeerRecvBufferSize {
				get {
					const string __id = "max_peer_recv_buffer_size.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='max_peerlist_size']"
			[Register ("max_peerlist_size")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types MaxPeerlistSize {
				get {
					const string __id = "max_peerlist_size.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='max_pex_peers']"
			[Register ("max_pex_peers")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types MaxPexPeers {
				get {
					const string __id = "max_pex_peers.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='max_queued_disk_bytes']"
			[Register ("max_queued_disk_bytes")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types MaxQueuedDiskBytes {
				get {
					const string __id = "max_queued_disk_bytes.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='max_rejects']"
			[Register ("max_rejects")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types MaxRejects {
				get {
					const string __id = "max_rejects.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='max_retry_port_bind']"
			[Register ("max_retry_port_bind")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types MaxRetryPortBind {
				get {
					const string __id = "max_retry_port_bind.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='max_suggest_pieces']"
			[Register ("max_suggest_pieces")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types MaxSuggestPieces {
				get {
					const string __id = "max_suggest_pieces.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='max_web_seed_connections']"
			[Register ("max_web_seed_connections")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types MaxWebSeedConnections {
				get {
					const string __id = "max_web_seed_connections.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='min_announce_interval']"
			[Register ("min_announce_interval")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types MinAnnounceInterval {
				get {
					const string __id = "min_announce_interval.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='min_reconnect_time']"
			[Register ("min_reconnect_time")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types MinReconnectTime {
				get {
					const string __id = "min_reconnect_time.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='mixed_mode_algorithm']"
			[Register ("mixed_mode_algorithm")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types MixedModeAlgorithm {
				get {
					const string __id = "mixed_mode_algorithm.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='num_optimistic_unchoke_slots']"
			[Register ("num_optimistic_unchoke_slots")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types NumOptimisticUnchokeSlots {
				get {
					const string __id = "num_optimistic_unchoke_slots.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='num_outgoing_ports']"
			[Register ("num_outgoing_ports")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types NumOutgoingPorts {
				get {
					const string __id = "num_outgoing_ports.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='num_want']"
			[Register ("num_want")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types NumWant {
				get {
					const string __id = "num_want.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='optimistic_disk_retry']"
			[Register ("optimistic_disk_retry")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types OptimisticDiskRetry {
				get {
					const string __id = "optimistic_disk_retry.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='optimistic_unchoke_interval']"
			[Register ("optimistic_unchoke_interval")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types OptimisticUnchokeInterval {
				get {
					const string __id = "optimistic_unchoke_interval.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='out_enc_policy']"
			[Register ("out_enc_policy")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types OutEncPolicy {
				get {
					const string __id = "out_enc_policy.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='outgoing_port']"
			[Register ("outgoing_port")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types OutgoingPort {
				get {
					const string __id = "outgoing_port.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='peer_connect_timeout']"
			[Register ("peer_connect_timeout")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types PeerConnectTimeout {
				get {
					const string __id = "peer_connect_timeout.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='peer_timeout']"
			[Register ("peer_timeout")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types PeerTimeout {
				get {
					const string __id = "peer_timeout.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='peer_tos']"
			[Register ("peer_tos")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types PeerTos {
				get {
					const string __id = "peer_tos.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='peer_turnover']"
			[Register ("peer_turnover")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types PeerTurnover {
				get {
					const string __id = "peer_turnover.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='peer_turnover_cutoff']"
			[Register ("peer_turnover_cutoff")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types PeerTurnoverCutoff {
				get {
					const string __id = "peer_turnover_cutoff.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='peer_turnover_interval']"
			[Register ("peer_turnover_interval")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types PeerTurnoverInterval {
				get {
					const string __id = "peer_turnover_interval.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='piece_timeout']"
			[Register ("piece_timeout")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types PieceTimeout {
				get {
					const string __id = "piece_timeout.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='predictive_piece_announce']"
			[Register ("predictive_piece_announce")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types PredictivePieceAnnounce {
				get {
					const string __id = "predictive_piece_announce.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='proxy_port']"
			[Register ("proxy_port")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ProxyPort {
				get {
					const string __id = "proxy_port.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='proxy_type']"
			[Register ("proxy_type")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ProxyType {
				get {
					const string __id = "proxy_type.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='read_cache_line_size']"
			[Register ("read_cache_line_size")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ReadCacheLineSize {
				get {
					const string __id = "read_cache_line_size.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='recv_socket_buffer_size']"
			[Register ("recv_socket_buffer_size")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types RecvSocketBufferSize {
				get {
					const string __id = "recv_socket_buffer_size.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='request_queue_time']"
			[Register ("request_queue_time")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types RequestQueueTime {
				get {
					const string __id = "request_queue_time.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='request_timeout']"
			[Register ("request_timeout")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types RequestTimeout {
				get {
					const string __id = "request_timeout.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='resolver_cache_timeout']"
			[Register ("resolver_cache_timeout")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ResolverCacheTimeout {
				get {
					const string __id = "resolver_cache_timeout.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='seed_choking_algorithm']"
			[Register ("seed_choking_algorithm")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types SeedChokingAlgorithm {
				get {
					const string __id = "seed_choking_algorithm.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='seed_time_limit']"
			[Register ("seed_time_limit")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types SeedTimeLimit {
				get {
					const string __id = "seed_time_limit.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='seed_time_ratio_limit']"
			[Register ("seed_time_ratio_limit")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types SeedTimeRatioLimit {
				get {
					const string __id = "seed_time_ratio_limit.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='seeding_piece_quota']"
			[Register ("seeding_piece_quota")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types SeedingPieceQuota {
				get {
					const string __id = "seeding_piece_quota.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='send_buffer_low_watermark']"
			[Register ("send_buffer_low_watermark")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types SendBufferLowWatermark {
				get {
					const string __id = "send_buffer_low_watermark.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='send_buffer_watermark']"
			[Register ("send_buffer_watermark")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types SendBufferWatermark {
				get {
					const string __id = "send_buffer_watermark.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='send_buffer_watermark_factor']"
			[Register ("send_buffer_watermark_factor")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types SendBufferWatermarkFactor {
				get {
					const string __id = "send_buffer_watermark_factor.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='send_socket_buffer_size']"
			[Register ("send_socket_buffer_size")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types SendSocketBufferSize {
				get {
					const string __id = "send_socket_buffer_size.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='share_mode_target']"
			[Register ("share_mode_target")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ShareModeTarget {
				get {
					const string __id = "share_mode_target.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='share_ratio_limit']"
			[Register ("share_ratio_limit")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types ShareRatioLimit {
				get {
					const string __id = "share_ratio_limit.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='stop_tracker_timeout']"
			[Register ("stop_tracker_timeout")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types StopTrackerTimeout {
				get {
					const string __id = "stop_tracker_timeout.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='suggest_mode']"
			[Register ("suggest_mode")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types SuggestMode {
				get {
					const string __id = "suggest_mode.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='tick_interval']"
			[Register ("tick_interval")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types TickInterval {
				get {
					const string __id = "tick_interval.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='torrent_connect_boost']"
			[Register ("torrent_connect_boost")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types TorrentConnectBoost {
				get {
					const string __id = "torrent_connect_boost.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='tracker_backoff']"
			[Register ("tracker_backoff")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types TrackerBackoff {
				get {
					const string __id = "tracker_backoff.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='tracker_completion_timeout']"
			[Register ("tracker_completion_timeout")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types TrackerCompletionTimeout {
				get {
					const string __id = "tracker_completion_timeout.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='tracker_maximum_response_length']"
			[Register ("tracker_maximum_response_length")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types TrackerMaximumResponseLength {
				get {
					const string __id = "tracker_maximum_response_length.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='tracker_receive_timeout']"
			[Register ("tracker_receive_timeout")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types TrackerReceiveTimeout {
				get {
					const string __id = "tracker_receive_timeout.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='udp_tracker_token_expiry']"
			[Register ("udp_tracker_token_expiry")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types UdpTrackerTokenExpiry {
				get {
					const string __id = "udp_tracker_token_expiry.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='unchoke_interval']"
			[Register ("unchoke_interval")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types UnchokeInterval {
				get {
					const string __id = "unchoke_interval.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='unchoke_slots_limit']"
			[Register ("unchoke_slots_limit")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types UnchokeSlotsLimit {
				get {
					const string __id = "unchoke_slots_limit.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='upload_rate_limit']"
			[Register ("upload_rate_limit")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types UploadRateLimit {
				get {
					const string __id = "upload_rate_limit.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='urlseed_max_request_bytes']"
			[Register ("urlseed_max_request_bytes")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types UrlseedMaxRequestBytes {
				get {
					const string __id = "urlseed_max_request_bytes.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='urlseed_pipeline_size']"
			[Register ("urlseed_pipeline_size")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types UrlseedPipelineSize {
				get {
					const string __id = "urlseed_pipeline_size.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='urlseed_timeout']"
			[Register ("urlseed_timeout")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types UrlseedTimeout {
				get {
					const string __id = "urlseed_timeout.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='urlseed_wait_retry']"
			[Register ("urlseed_wait_retry")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types UrlseedWaitRetry {
				get {
					const string __id = "urlseed_wait_retry.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='utp_connect_timeout']"
			[Register ("utp_connect_timeout")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types UtpConnectTimeout {
				get {
					const string __id = "utp_connect_timeout.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='utp_fin_resends']"
			[Register ("utp_fin_resends")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types UtpFinResends {
				get {
					const string __id = "utp_fin_resends.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='utp_gain_factor']"
			[Register ("utp_gain_factor")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types UtpGainFactor {
				get {
					const string __id = "utp_gain_factor.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='utp_loss_multiplier']"
			[Register ("utp_loss_multiplier")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types UtpLossMultiplier {
				get {
					const string __id = "utp_loss_multiplier.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='utp_min_timeout']"
			[Register ("utp_min_timeout")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types UtpMinTimeout {
				get {
					const string __id = "utp_min_timeout.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='utp_num_resends']"
			[Register ("utp_num_resends")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types UtpNumResends {
				get {
					const string __id = "utp_num_resends.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='utp_syn_resends']"
			[Register ("utp_syn_resends")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types UtpSynResends {
				get {
					const string __id = "utp_syn_resends.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='utp_target_delay']"
			[Register ("utp_target_delay")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types UtpTargetDelay {
				get {
					const string __id = "utp_target_delay.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='web_seed_name_lookup_retry']"
			[Register ("web_seed_name_lookup_retry")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types WebSeedNameLookupRetry {
				get {
					const string __id = "web_seed_name_lookup_retry.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='whole_pieces_threshold']"
			[Register ("whole_pieces_threshold")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types WholePiecesThreshold {
				get {
					const string __id = "whole_pieces_threshold.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/field[@name='write_cache_line_size']"
			[Register ("write_cache_line_size")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types WriteCacheLineSize {
				get {
					const string __id = "write_cache_line_size.Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/settings_pack$int_types", typeof (Int_types));
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

			internal Int_types (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$int_types;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Int_types> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.int_types']/method[@name='swigValue' and count(parameter)=0]"
			[Register ("swigValue", "()I", "")]
			public unsafe int SwigValue ()
			{
				const string __id = "swigValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.io_buffer_mode_t']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/settings_pack$io_buffer_mode_t", DoNotGenerateAcw=true)]
		public sealed partial class Io_buffer_mode_t : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.io_buffer_mode_t']/field[@name='disable_os_cache']"
			[Register ("disable_os_cache")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Io_buffer_mode_t DisableOsCache {
				get {
					const string __id = "disable_os_cache.Lcom/frostwire/jlibtorrent/swig/settings_pack$io_buffer_mode_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Io_buffer_mode_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.io_buffer_mode_t']/field[@name='enable_os_cache']"
			[Register ("enable_os_cache")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Io_buffer_mode_t EnableOsCache {
				get {
					const string __id = "enable_os_cache.Lcom/frostwire/jlibtorrent/swig/settings_pack$io_buffer_mode_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Io_buffer_mode_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/settings_pack$io_buffer_mode_t", typeof (Io_buffer_mode_t));
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

			internal Io_buffer_mode_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.io_buffer_mode_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$io_buffer_mode_t;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Settings_pack.Io_buffer_mode_t SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$io_buffer_mode_t;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Io_buffer_mode_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.io_buffer_mode_t']/method[@name='swigValue' and count(parameter)=0]"
			[Register ("swigValue", "()I", "")]
			public unsafe int SwigValue ()
			{
				const string __id = "swigValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.proxy_type_t']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/settings_pack$proxy_type_t", DoNotGenerateAcw=true)]
		public sealed partial class Proxy_type_t : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.proxy_type_t']/field[@name='http']"
			[Register ("http")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Proxy_type_t Http {
				get {
					const string __id = "http.Lcom/frostwire/jlibtorrent/swig/settings_pack$proxy_type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Proxy_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.proxy_type_t']/field[@name='http_pw']"
			[Register ("http_pw")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Proxy_type_t HttpPw {
				get {
					const string __id = "http_pw.Lcom/frostwire/jlibtorrent/swig/settings_pack$proxy_type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Proxy_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.proxy_type_t']/field[@name='i2p_proxy']"
			[Register ("i2p_proxy")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Proxy_type_t I2pProxy {
				get {
					const string __id = "i2p_proxy.Lcom/frostwire/jlibtorrent/swig/settings_pack$proxy_type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Proxy_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.proxy_type_t']/field[@name='none']"
			[Register ("none")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Proxy_type_t None {
				get {
					const string __id = "none.Lcom/frostwire/jlibtorrent/swig/settings_pack$proxy_type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Proxy_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.proxy_type_t']/field[@name='socks4']"
			[Register ("socks4")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Proxy_type_t Socks4 {
				get {
					const string __id = "socks4.Lcom/frostwire/jlibtorrent/swig/settings_pack$proxy_type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Proxy_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.proxy_type_t']/field[@name='socks5']"
			[Register ("socks5")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Proxy_type_t Socks5 {
				get {
					const string __id = "socks5.Lcom/frostwire/jlibtorrent/swig/settings_pack$proxy_type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Proxy_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.proxy_type_t']/field[@name='socks5_pw']"
			[Register ("socks5_pw")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Proxy_type_t Socks5Pw {
				get {
					const string __id = "socks5_pw.Lcom/frostwire/jlibtorrent/swig/settings_pack$proxy_type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Proxy_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/settings_pack$proxy_type_t", typeof (Proxy_type_t));
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

			internal Proxy_type_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.proxy_type_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$proxy_type_t;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Settings_pack.Proxy_type_t SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$proxy_type_t;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Proxy_type_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.proxy_type_t']/method[@name='swigValue' and count(parameter)=0]"
			[Register ("swigValue", "()I", "")]
			public unsafe int SwigValue ()
			{
				const string __id = "swigValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.seed_choking_algorithm_t']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/settings_pack$seed_choking_algorithm_t", DoNotGenerateAcw=true)]
		public sealed partial class Seed_choking_algorithm_t : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.seed_choking_algorithm_t']/field[@name='anti_leech']"
			[Register ("anti_leech")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Seed_choking_algorithm_t AntiLeech {
				get {
					const string __id = "anti_leech.Lcom/frostwire/jlibtorrent/swig/settings_pack$seed_choking_algorithm_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Seed_choking_algorithm_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.seed_choking_algorithm_t']/field[@name='fastest_upload']"
			[Register ("fastest_upload")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Seed_choking_algorithm_t FastestUpload {
				get {
					const string __id = "fastest_upload.Lcom/frostwire/jlibtorrent/swig/settings_pack$seed_choking_algorithm_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Seed_choking_algorithm_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.seed_choking_algorithm_t']/field[@name='round_robin']"
			[Register ("round_robin")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Seed_choking_algorithm_t RoundRobin {
				get {
					const string __id = "round_robin.Lcom/frostwire/jlibtorrent/swig/settings_pack$seed_choking_algorithm_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Seed_choking_algorithm_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/settings_pack$seed_choking_algorithm_t", typeof (Seed_choking_algorithm_t));
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

			internal Seed_choking_algorithm_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.seed_choking_algorithm_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$seed_choking_algorithm_t;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Settings_pack.Seed_choking_algorithm_t SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$seed_choking_algorithm_t;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Seed_choking_algorithm_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.seed_choking_algorithm_t']/method[@name='swigValue' and count(parameter)=0]"
			[Register ("swigValue", "()I", "")]
			public unsafe int SwigValue ()
			{
				const string __id = "swigValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.settings_counts_t']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/settings_pack$settings_counts_t", DoNotGenerateAcw=true)]
		public sealed partial class Settings_counts_t : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.settings_counts_t']/field[@name='num_bool_settings']"
			[Register ("num_bool_settings")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Settings_counts_t NumBoolSettings {
				get {
					const string __id = "num_bool_settings.Lcom/frostwire/jlibtorrent/swig/settings_pack$settings_counts_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Settings_counts_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.settings_counts_t']/field[@name='num_int_settings']"
			[Register ("num_int_settings")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Settings_counts_t NumIntSettings {
				get {
					const string __id = "num_int_settings.Lcom/frostwire/jlibtorrent/swig/settings_pack$settings_counts_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Settings_counts_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.settings_counts_t']/field[@name='num_string_settings']"
			[Register ("num_string_settings")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Settings_counts_t NumStringSettings {
				get {
					const string __id = "num_string_settings.Lcom/frostwire/jlibtorrent/swig/settings_pack$settings_counts_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Settings_counts_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/settings_pack$settings_counts_t", typeof (Settings_counts_t));
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

			internal Settings_counts_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.settings_counts_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$settings_counts_t;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Settings_pack.Settings_counts_t SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$settings_counts_t;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Settings_counts_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.settings_counts_t']/method[@name='swigValue' and count(parameter)=0]"
			[Register ("swigValue", "()I", "")]
			public unsafe int SwigValue ()
			{
				const string __id = "swigValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.string_types']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/settings_pack$string_types", DoNotGenerateAcw=true)]
		public sealed partial class String_types : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.string_types']/field[@name='announce_ip']"
			[Register ("announce_ip")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.String_types AnnounceIp {
				get {
					const string __id = "announce_ip.Lcom/frostwire/jlibtorrent/swig/settings_pack$string_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.String_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.string_types']/field[@name='dht_bootstrap_nodes']"
			[Register ("dht_bootstrap_nodes")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.String_types DhtBootstrapNodes {
				get {
					const string __id = "dht_bootstrap_nodes.Lcom/frostwire/jlibtorrent/swig/settings_pack$string_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.String_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.string_types']/field[@name='handshake_client_version']"
			[Register ("handshake_client_version")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.String_types HandshakeClientVersion {
				get {
					const string __id = "handshake_client_version.Lcom/frostwire/jlibtorrent/swig/settings_pack$string_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.String_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.string_types']/field[@name='i2p_hostname']"
			[Register ("i2p_hostname")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.String_types I2pHostname {
				get {
					const string __id = "i2p_hostname.Lcom/frostwire/jlibtorrent/swig/settings_pack$string_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.String_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.string_types']/field[@name='listen_interfaces']"
			[Register ("listen_interfaces")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.String_types ListenInterfaces {
				get {
					const string __id = "listen_interfaces.Lcom/frostwire/jlibtorrent/swig/settings_pack$string_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.String_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.string_types']/field[@name='max_string_setting_internal']"
			[Register ("max_string_setting_internal")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.String_types MaxStringSettingInternal {
				get {
					const string __id = "max_string_setting_internal.Lcom/frostwire/jlibtorrent/swig/settings_pack$string_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.String_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.string_types']/field[@name='outgoing_interfaces']"
			[Register ("outgoing_interfaces")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.String_types OutgoingInterfaces {
				get {
					const string __id = "outgoing_interfaces.Lcom/frostwire/jlibtorrent/swig/settings_pack$string_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.String_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.string_types']/field[@name='peer_fingerprint']"
			[Register ("peer_fingerprint")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.String_types PeerFingerprint {
				get {
					const string __id = "peer_fingerprint.Lcom/frostwire/jlibtorrent/swig/settings_pack$string_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.String_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.string_types']/field[@name='proxy_hostname']"
			[Register ("proxy_hostname")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.String_types ProxyHostname {
				get {
					const string __id = "proxy_hostname.Lcom/frostwire/jlibtorrent/swig/settings_pack$string_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.String_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.string_types']/field[@name='proxy_password']"
			[Register ("proxy_password")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.String_types ProxyPassword {
				get {
					const string __id = "proxy_password.Lcom/frostwire/jlibtorrent/swig/settings_pack$string_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.String_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.string_types']/field[@name='proxy_username']"
			[Register ("proxy_username")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.String_types ProxyUsername {
				get {
					const string __id = "proxy_username.Lcom/frostwire/jlibtorrent/swig/settings_pack$string_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.String_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.string_types']/field[@name='user_agent']"
			[Register ("user_agent")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.String_types UserAgent {
				get {
					const string __id = "user_agent.Lcom/frostwire/jlibtorrent/swig/settings_pack$string_types;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.String_types> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/settings_pack$string_types", typeof (String_types));
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

			internal String_types (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.string_types']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$string_types;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Settings_pack.String_types SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$string_types;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.String_types> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.string_types']/method[@name='swigValue' and count(parameter)=0]"
			[Register ("swigValue", "()I", "")]
			public unsafe int SwigValue ()
			{
				const string __id = "swigValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.suggest_mode_t']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/settings_pack$suggest_mode_t", DoNotGenerateAcw=true)]
		public sealed partial class Suggest_mode_t : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.suggest_mode_t']/field[@name='no_piece_suggestions']"
			[Register ("no_piece_suggestions")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Suggest_mode_t NoPieceSuggestions {
				get {
					const string __id = "no_piece_suggestions.Lcom/frostwire/jlibtorrent/swig/settings_pack$suggest_mode_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Suggest_mode_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.suggest_mode_t']/field[@name='suggest_read_cache']"
			[Register ("suggest_read_cache")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Suggest_mode_t SuggestReadCache {
				get {
					const string __id = "suggest_read_cache.Lcom/frostwire/jlibtorrent/swig/settings_pack$suggest_mode_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Suggest_mode_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/settings_pack$suggest_mode_t", typeof (Suggest_mode_t));
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

			internal Suggest_mode_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.suggest_mode_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$suggest_mode_t;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Settings_pack.Suggest_mode_t SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$suggest_mode_t;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Suggest_mode_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.suggest_mode_t']/method[@name='swigValue' and count(parameter)=0]"
			[Register ("swigValue", "()I", "")]
			public unsafe int SwigValue ()
			{
				const string __id = "swigValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.type_bases']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/settings_pack$type_bases", DoNotGenerateAcw=true)]
		public sealed partial class Type_bases : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.type_bases']/field[@name='bool_type_base']"
			[Register ("bool_type_base")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Type_bases BoolTypeBase {
				get {
					const string __id = "bool_type_base.Lcom/frostwire/jlibtorrent/swig/settings_pack$type_bases;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Type_bases> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.type_bases']/field[@name='index_mask']"
			[Register ("index_mask")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Type_bases IndexMask {
				get {
					const string __id = "index_mask.Lcom/frostwire/jlibtorrent/swig/settings_pack$type_bases;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Type_bases> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.type_bases']/field[@name='int_type_base']"
			[Register ("int_type_base")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Type_bases IntTypeBase {
				get {
					const string __id = "int_type_base.Lcom/frostwire/jlibtorrent/swig/settings_pack$type_bases;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Type_bases> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.type_bases']/field[@name='string_type_base']"
			[Register ("string_type_base")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Type_bases StringTypeBase {
				get {
					const string __id = "string_type_base.Lcom/frostwire/jlibtorrent/swig/settings_pack$type_bases;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Type_bases> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.type_bases']/field[@name='type_mask']"
			[Register ("type_mask")]
			public static global::FrostWire.Libtorrent.Swig.Settings_pack.Type_bases TypeMask {
				get {
					const string __id = "type_mask.Lcom/frostwire/jlibtorrent/swig/settings_pack$type_bases;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Type_bases> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/settings_pack$type_bases", typeof (Type_bases));
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

			internal Type_bases (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.type_bases']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$type_bases;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Settings_pack.Type_bases SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/settings_pack$type_bases;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack.Type_bases> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack.type_bases']/method[@name='swigValue' and count(parameter)=0]"
			[Register ("swigValue", "()I", "")]
			public unsafe int SwigValue ()
			{
				const string __id = "swigValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/settings_pack", typeof (Settings_pack));
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

		protected Settings_pack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack']/constructor[@name='settings_pack' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Settings_pack ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack']/constructor[@name='settings_pack' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.settings_pack']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/settings_pack;)V", "")]
		public unsafe Settings_pack (global::FrostWire.Libtorrent.Swig.Settings_pack arg0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/settings_pack;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((arg0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack']/constructor[@name='settings_pack' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Settings_pack (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Settings_pack __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clear_I;
#pragma warning disable 0169
		static Delegate GetClear_IHandler ()
		{
			if (cb_clear_I == null)
				cb_clear_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Clear_I);
			return cb_clear_I;
		}

		static void n_Clear_I (IntPtr jnienv, IntPtr native__this, int name)
		{
			global::FrostWire.Libtorrent.Swig.Settings_pack __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack']/method[@name='clear' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("clear", "(I)V", "GetClear_IHandler")]
		public virtual unsafe void Clear (int name)
		{
			const string __id = "clear.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (name);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::FrostWire.Libtorrent.Swig.Settings_pack __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.settings_pack']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/settings_pack;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Settings_pack obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/settings_pack;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_bool_I;
#pragma warning disable 0169
		static Delegate GetGet_bool_IHandler ()
		{
			if (cb_get_bool_I == null)
				cb_get_bool_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Get_bool_I);
			return cb_get_bool_I;
		}

		static bool n_Get_bool_I (IntPtr jnienv, IntPtr native__this, int name)
		{
			global::FrostWire.Libtorrent.Swig.Settings_pack __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_bool (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack']/method[@name='get_bool' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get_bool", "(I)Z", "GetGet_bool_IHandler")]
		public virtual unsafe bool Get_bool (int name)
		{
			const string __id = "get_bool.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (name);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_int_I;
#pragma warning disable 0169
		static Delegate GetGet_int_IHandler ()
		{
			if (cb_get_int_I == null)
				cb_get_int_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_Get_int_I);
			return cb_get_int_I;
		}

		static int n_Get_int_I (IntPtr jnienv, IntPtr native__this, int name)
		{
			global::FrostWire.Libtorrent.Swig.Settings_pack __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_int (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack']/method[@name='get_int' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get_int", "(I)I", "GetGet_int_IHandler")]
		public virtual unsafe int Get_int (int name)
		{
			const string __id = "get_int.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (name);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_str_I;
#pragma warning disable 0169
		static Delegate GetGet_str_IHandler ()
		{
			if (cb_get_str_I == null)
				cb_get_str_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Get_str_I);
			return cb_get_str_I;
		}

		static IntPtr n_Get_str_I (IntPtr jnienv, IntPtr native__this, int name)
		{
			global::FrostWire.Libtorrent.Swig.Settings_pack __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Get_str (name));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack']/method[@name='get_str' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get_str", "(I)Ljava/lang/String;", "GetGet_str_IHandler")]
		public virtual unsafe string Get_str (int name)
		{
			const string __id = "get_str.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_has_val_I;
#pragma warning disable 0169
		static Delegate GetHas_val_IHandler ()
		{
			if (cb_has_val_I == null)
				cb_has_val_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Has_val_I);
			return cb_has_val_I;
		}

		static bool n_Has_val_I (IntPtr jnienv, IntPtr native__this, int name)
		{
			global::FrostWire.Libtorrent.Swig.Settings_pack __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Has_val (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack']/method[@name='has_val' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("has_val", "(I)Z", "GetHas_val_IHandler")]
		public virtual unsafe bool Has_val (int name)
		{
			const string __id = "has_val.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (name);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_set_bool_IZ;
#pragma warning disable 0169
		static Delegate GetSet_bool_IZHandler ()
		{
			if (cb_set_bool_IZ == null)
				cb_set_bool_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_Set_bool_IZ);
			return cb_set_bool_IZ;
		}

		static void n_Set_bool_IZ (IntPtr jnienv, IntPtr native__this, int name, bool val)
		{
			global::FrostWire.Libtorrent.Swig.Settings_pack __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_bool (name, val);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack']/method[@name='set_bool' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("set_bool", "(IZ)V", "GetSet_bool_IZHandler")]
		public virtual unsafe void Set_bool (int name, bool val)
		{
			const string __id = "set_bool.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (name);
				__args [1] = new JniArgumentValue (val);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_int_II;
#pragma warning disable 0169
		static Delegate GetSet_int_IIHandler ()
		{
			if (cb_set_int_II == null)
				cb_set_int_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_Set_int_II);
			return cb_set_int_II;
		}

		static void n_Set_int_II (IntPtr jnienv, IntPtr native__this, int name, int val)
		{
			global::FrostWire.Libtorrent.Swig.Settings_pack __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_int (name, val);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack']/method[@name='set_int' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("set_int", "(II)V", "GetSet_int_IIHandler")]
		public virtual unsafe void Set_int (int name, int val)
		{
			const string __id = "set_int.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (name);
				__args [1] = new JniArgumentValue (val);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_str_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSet_str_ILjava_lang_String_Handler ()
		{
			if (cb_set_str_ILjava_lang_String_ == null)
				cb_set_str_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Set_str_ILjava_lang_String_);
			return cb_set_str_ILjava_lang_String_;
		}

		static void n_Set_str_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int name, IntPtr native_val)
		{
			global::FrostWire.Libtorrent.Swig.Settings_pack __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string val = JNIEnv.GetString (native_val, JniHandleOwnership.DoNotTransfer);
			__this.Set_str (name, val);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='settings_pack']/method[@name='set_str' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("set_str", "(ILjava/lang/String;)V", "GetSet_str_ILjava_lang_String_Handler")]
		public virtual unsafe void Set_str (int name, string val)
		{
			const string __id = "set_str.(ILjava/lang/String;)V";
			IntPtr native_val = JNIEnv.NewString (val);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (name);
				__args [1] = new JniArgumentValue (native_val);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_val);
			}
		}

	}
}
