using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/peer_info", DoNotGenerateAcw=true)]
	public partial class Peer_info : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='bw_disk']"
		[Register ("bw_disk")]
		public static global::FrostWire.Libtorrent.Swig.Bandwidth_state_flags_t BwDisk {
			get {
				const string __id = "bw_disk.Lcom/frostwire/jlibtorrent/swig/bandwidth_state_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bandwidth_state_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='bw_idle']"
		[Register ("bw_idle")]
		public static global::FrostWire.Libtorrent.Swig.Bandwidth_state_flags_t BwIdle {
			get {
				const string __id = "bw_idle.Lcom/frostwire/jlibtorrent/swig/bandwidth_state_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bandwidth_state_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='bw_limit']"
		[Register ("bw_limit")]
		public static global::FrostWire.Libtorrent.Swig.Bandwidth_state_flags_t BwLimit {
			get {
				const string __id = "bw_limit.Lcom/frostwire/jlibtorrent/swig/bandwidth_state_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bandwidth_state_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='bw_network']"
		[Register ("bw_network")]
		public static global::FrostWire.Libtorrent.Swig.Bandwidth_state_flags_t BwNetwork {
			get {
				const string __id = "bw_network.Lcom/frostwire/jlibtorrent/swig/bandwidth_state_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bandwidth_state_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='choked']"
		[Register ("choked")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t Choked {
			get {
				const string __id = "choked.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='connecting']"
		[Register ("connecting")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t Connecting {
			get {
				const string __id = "connecting.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='dht']"
		[Register ("dht")]
		public static global::FrostWire.Libtorrent.Swig.Peer_source_flags_t Dht {
			get {
				const string __id = "dht.Lcom/frostwire/jlibtorrent/swig/peer_source_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_source_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='endgame_mode']"
		[Register ("endgame_mode")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t EndgameMode {
			get {
				const string __id = "endgame_mode.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='handshake']"
		[Register ("handshake")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t Handshake {
			get {
				const string __id = "handshake.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='holepunched']"
		[Register ("holepunched")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t Holepunched {
			get {
				const string __id = "holepunched.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='i2p_socket']"
		[Register ("i2p_socket")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t I2pSocket {
			get {
				const string __id = "i2p_socket.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='incoming']"
		[Register ("incoming")]
		public static global::FrostWire.Libtorrent.Swig.Peer_source_flags_t Incoming {
			get {
				const string __id = "incoming.Lcom/frostwire/jlibtorrent/swig/peer_source_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_source_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='interesting']"
		[Register ("interesting")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t Interesting {
			get {
				const string __id = "interesting.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='local_connection']"
		[Register ("local_connection")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t LocalConnection {
			get {
				const string __id = "local_connection.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='lsd']"
		[Register ("lsd")]
		public static global::FrostWire.Libtorrent.Swig.Peer_source_flags_t Lsd {
			get {
				const string __id = "lsd.Lcom/frostwire/jlibtorrent/swig/peer_source_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_source_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='on_parole']"
		[Register ("on_parole")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t OnParole {
			get {
				const string __id = "on_parole.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='optimistic_unchoke']"
		[Register ("optimistic_unchoke")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t OptimisticUnchoke {
			get {
				const string __id = "optimistic_unchoke.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='pex']"
		[Register ("pex")]
		public static global::FrostWire.Libtorrent.Swig.Peer_source_flags_t Pex {
			get {
				const string __id = "pex.Lcom/frostwire/jlibtorrent/swig/peer_source_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_source_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='plaintext_encrypted']"
		[Register ("plaintext_encrypted")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t PlaintextEncrypted {
			get {
				const string __id = "plaintext_encrypted.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='rc4_encrypted']"
		[Register ("rc4_encrypted")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t Rc4Encrypted {
			get {
				const string __id = "rc4_encrypted.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='remote_choked']"
		[Register ("remote_choked")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t RemoteChoked {
			get {
				const string __id = "remote_choked.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='remote_interested']"
		[Register ("remote_interested")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t RemoteInterested {
			get {
				const string __id = "remote_interested.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='resume_data']"
		[Register ("resume_data")]
		public static global::FrostWire.Libtorrent.Swig.Peer_source_flags_t ResumeData {
			get {
				const string __id = "resume_data.Lcom/frostwire/jlibtorrent/swig/peer_source_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_source_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='seed']"
		[Register ("seed")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t Seed {
			get {
				const string __id = "seed.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='snubbed']"
		[Register ("snubbed")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t Snubbed {
			get {
				const string __id = "snubbed.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='ssl_socket']"
		[Register ("ssl_socket")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t SslSocket {
			get {
				const string __id = "ssl_socket.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='supports_extensions']"
		[Register ("supports_extensions")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t SupportsExtensions {
			get {
				const string __id = "supports_extensions.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='swigCMemOwn']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='tracker']"
		[Register ("tracker")]
		public static global::FrostWire.Libtorrent.Swig.Peer_source_flags_t Tracker {
			get {
				const string __id = "tracker.Lcom/frostwire/jlibtorrent/swig/peer_source_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_source_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='upload_only']"
		[Register ("upload_only")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t UploadOnly {
			get {
				const string __id = "upload_only.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/field[@name='utp_socket']"
		[Register ("utp_socket")]
		public static global::FrostWire.Libtorrent.Swig.Peer_flags_t UtpSocket {
			get {
				const string __id = "utp_socket.Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info.connection_type_t']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/peer_info$connection_type_t", DoNotGenerateAcw=true)]
		public sealed partial class Connection_type_t : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info.connection_type_t']/field[@name='http_seed']"
			[Register ("http_seed")]
			public static global::FrostWire.Libtorrent.Swig.Peer_info.Connection_type_t HttpSeed {
				get {
					const string __id = "http_seed.Lcom/frostwire/jlibtorrent/swig/peer_info$connection_type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info.Connection_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info.connection_type_t']/field[@name='standard_bittorrent']"
			[Register ("standard_bittorrent")]
			public static global::FrostWire.Libtorrent.Swig.Peer_info.Connection_type_t StandardBittorrent {
				get {
					const string __id = "standard_bittorrent.Lcom/frostwire/jlibtorrent/swig/peer_info$connection_type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info.Connection_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info.connection_type_t']/field[@name='web_seed']"
			[Register ("web_seed")]
			public static global::FrostWire.Libtorrent.Swig.Peer_info.Connection_type_t WebSeed {
				get {
					const string __id = "web_seed.Lcom/frostwire/jlibtorrent/swig/peer_info$connection_type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info.Connection_type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/peer_info$connection_type_t", typeof (Connection_type_t));
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

			internal Connection_type_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info.connection_type_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/peer_info$connection_type_t;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Peer_info.Connection_type_t SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/peer_info$connection_type_t;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info.Connection_type_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info.connection_type_t']/method[@name='swigValue' and count(parameter)=0]"
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/peer_info", typeof (Peer_info));
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

		protected Peer_info (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/constructor[@name='peer_info' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Peer_info ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/constructor[@name='peer_info' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Peer_info (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getBusy_requests;
#pragma warning disable 0169
		static Delegate GetGetBusy_requestsHandler ()
		{
			if (cb_getBusy_requests == null)
				cb_getBusy_requests = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBusy_requests);
			return cb_getBusy_requests;
		}

		static int n_GetBusy_requests (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Busy_requests;
		}
#pragma warning restore 0169

		static Delegate cb_setBusy_requests_I;
#pragma warning disable 0169
		static Delegate GetSetBusy_requests_IHandler ()
		{
			if (cb_setBusy_requests_I == null)
				cb_setBusy_requests_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBusy_requests_I);
			return cb_setBusy_requests_I;
		}

		static void n_SetBusy_requests_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Busy_requests = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Busy_requests {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getBusy_requests' and count(parameter)=0]"
			[Register ("getBusy_requests", "()I", "GetGetBusy_requestsHandler")]
			get {
				const string __id = "getBusy_requests.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setBusy_requests' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBusy_requests", "(I)V", "GetSetBusy_requests_IHandler")]
			set {
				const string __id = "setBusy_requests.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getConnection_type;
#pragma warning disable 0169
		static Delegate GetGetConnection_typeHandler ()
		{
			if (cb_getConnection_type == null)
				cb_getConnection_type = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConnection_type);
			return cb_getConnection_type;
		}

		static int n_GetConnection_type (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Connection_type;
		}
#pragma warning restore 0169

		static Delegate cb_setConnection_type_I;
#pragma warning disable 0169
		static Delegate GetSetConnection_type_IHandler ()
		{
			if (cb_setConnection_type_I == null)
				cb_setConnection_type_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetConnection_type_I);
			return cb_setConnection_type_I;
		}

		static void n_SetConnection_type_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connection_type = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Connection_type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getConnection_type' and count(parameter)=0]"
			[Register ("getConnection_type", "()I", "GetGetConnection_typeHandler")]
			get {
				const string __id = "getConnection_type.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setConnection_type' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConnection_type", "(I)V", "GetSetConnection_type_IHandler")]
			set {
				const string __id = "setConnection_type.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDown_speed;
#pragma warning disable 0169
		static Delegate GetGetDown_speedHandler ()
		{
			if (cb_getDown_speed == null)
				cb_getDown_speed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDown_speed);
			return cb_getDown_speed;
		}

		static int n_GetDown_speed (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Down_speed;
		}
#pragma warning restore 0169

		static Delegate cb_setDown_speed_I;
#pragma warning disable 0169
		static Delegate GetSetDown_speed_IHandler ()
		{
			if (cb_setDown_speed_I == null)
				cb_setDown_speed_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDown_speed_I);
			return cb_setDown_speed_I;
		}

		static void n_SetDown_speed_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Down_speed = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Down_speed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getDown_speed' and count(parameter)=0]"
			[Register ("getDown_speed", "()I", "GetGetDown_speedHandler")]
			get {
				const string __id = "getDown_speed.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setDown_speed' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDown_speed", "(I)V", "GetSetDown_speed_IHandler")]
			set {
				const string __id = "setDown_speed.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDownload_queue_length;
#pragma warning disable 0169
		static Delegate GetGetDownload_queue_lengthHandler ()
		{
			if (cb_getDownload_queue_length == null)
				cb_getDownload_queue_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDownload_queue_length);
			return cb_getDownload_queue_length;
		}

		static int n_GetDownload_queue_length (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Download_queue_length;
		}
#pragma warning restore 0169

		static Delegate cb_setDownload_queue_length_I;
#pragma warning disable 0169
		static Delegate GetSetDownload_queue_length_IHandler ()
		{
			if (cb_setDownload_queue_length_I == null)
				cb_setDownload_queue_length_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDownload_queue_length_I);
			return cb_setDownload_queue_length_I;
		}

		static void n_SetDownload_queue_length_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Download_queue_length = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Download_queue_length {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getDownload_queue_length' and count(parameter)=0]"
			[Register ("getDownload_queue_length", "()I", "GetGetDownload_queue_lengthHandler")]
			get {
				const string __id = "getDownload_queue_length.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setDownload_queue_length' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDownload_queue_length", "(I)V", "GetSetDownload_queue_length_IHandler")]
			set {
				const string __id = "setDownload_queue_length.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDownload_rate_peak;
#pragma warning disable 0169
		static Delegate GetGetDownload_rate_peakHandler ()
		{
			if (cb_getDownload_rate_peak == null)
				cb_getDownload_rate_peak = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDownload_rate_peak);
			return cb_getDownload_rate_peak;
		}

		static int n_GetDownload_rate_peak (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Download_rate_peak;
		}
#pragma warning restore 0169

		static Delegate cb_setDownload_rate_peak_I;
#pragma warning disable 0169
		static Delegate GetSetDownload_rate_peak_IHandler ()
		{
			if (cb_setDownload_rate_peak_I == null)
				cb_setDownload_rate_peak_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDownload_rate_peak_I);
			return cb_setDownload_rate_peak_I;
		}

		static void n_SetDownload_rate_peak_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Download_rate_peak = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Download_rate_peak {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getDownload_rate_peak' and count(parameter)=0]"
			[Register ("getDownload_rate_peak", "()I", "GetGetDownload_rate_peakHandler")]
			get {
				const string __id = "getDownload_rate_peak.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setDownload_rate_peak' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDownload_rate_peak", "(I)V", "GetSetDownload_rate_peak_IHandler")]
			set {
				const string __id = "setDownload_rate_peak.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDownloading_block_index;
#pragma warning disable 0169
		static Delegate GetGetDownloading_block_indexHandler ()
		{
			if (cb_getDownloading_block_index == null)
				cb_getDownloading_block_index = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDownloading_block_index);
			return cb_getDownloading_block_index;
		}

		static int n_GetDownloading_block_index (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Downloading_block_index;
		}
#pragma warning restore 0169

		static Delegate cb_setDownloading_block_index_I;
#pragma warning disable 0169
		static Delegate GetSetDownloading_block_index_IHandler ()
		{
			if (cb_setDownloading_block_index_I == null)
				cb_setDownloading_block_index_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDownloading_block_index_I);
			return cb_setDownloading_block_index_I;
		}

		static void n_SetDownloading_block_index_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Downloading_block_index = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Downloading_block_index {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getDownloading_block_index' and count(parameter)=0]"
			[Register ("getDownloading_block_index", "()I", "GetGetDownloading_block_indexHandler")]
			get {
				const string __id = "getDownloading_block_index.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setDownloading_block_index' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDownloading_block_index", "(I)V", "GetSetDownloading_block_index_IHandler")]
			set {
				const string __id = "setDownloading_block_index.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDownloading_piece_index;
#pragma warning disable 0169
		static Delegate GetGetDownloading_piece_indexHandler ()
		{
			if (cb_getDownloading_piece_index == null)
				cb_getDownloading_piece_index = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDownloading_piece_index);
			return cb_getDownloading_piece_index;
		}

		static int n_GetDownloading_piece_index (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Downloading_piece_index;
		}
#pragma warning restore 0169

		static Delegate cb_setDownloading_piece_index_I;
#pragma warning disable 0169
		static Delegate GetSetDownloading_piece_index_IHandler ()
		{
			if (cb_setDownloading_piece_index_I == null)
				cb_setDownloading_piece_index_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDownloading_piece_index_I);
			return cb_setDownloading_piece_index_I;
		}

		static void n_SetDownloading_piece_index_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Downloading_piece_index = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Downloading_piece_index {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getDownloading_piece_index' and count(parameter)=0]"
			[Register ("getDownloading_piece_index", "()I", "GetGetDownloading_piece_indexHandler")]
			get {
				const string __id = "getDownloading_piece_index.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setDownloading_piece_index' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDownloading_piece_index", "(I)V", "GetSetDownloading_piece_index_IHandler")]
			set {
				const string __id = "setDownloading_piece_index.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDownloading_progress;
#pragma warning disable 0169
		static Delegate GetGetDownloading_progressHandler ()
		{
			if (cb_getDownloading_progress == null)
				cb_getDownloading_progress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDownloading_progress);
			return cb_getDownloading_progress;
		}

		static int n_GetDownloading_progress (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Downloading_progress;
		}
#pragma warning restore 0169

		static Delegate cb_setDownloading_progress_I;
#pragma warning disable 0169
		static Delegate GetSetDownloading_progress_IHandler ()
		{
			if (cb_setDownloading_progress_I == null)
				cb_setDownloading_progress_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDownloading_progress_I);
			return cb_setDownloading_progress_I;
		}

		static void n_SetDownloading_progress_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Downloading_progress = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Downloading_progress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getDownloading_progress' and count(parameter)=0]"
			[Register ("getDownloading_progress", "()I", "GetGetDownloading_progressHandler")]
			get {
				const string __id = "getDownloading_progress.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setDownloading_progress' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDownloading_progress", "(I)V", "GetSetDownloading_progress_IHandler")]
			set {
				const string __id = "setDownloading_progress.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDownloading_total;
#pragma warning disable 0169
		static Delegate GetGetDownloading_totalHandler ()
		{
			if (cb_getDownloading_total == null)
				cb_getDownloading_total = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDownloading_total);
			return cb_getDownloading_total;
		}

		static int n_GetDownloading_total (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Downloading_total;
		}
#pragma warning restore 0169

		static Delegate cb_setDownloading_total_I;
#pragma warning disable 0169
		static Delegate GetSetDownloading_total_IHandler ()
		{
			if (cb_setDownloading_total_I == null)
				cb_setDownloading_total_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDownloading_total_I);
			return cb_setDownloading_total_I;
		}

		static void n_SetDownloading_total_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Downloading_total = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Downloading_total {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getDownloading_total' and count(parameter)=0]"
			[Register ("getDownloading_total", "()I", "GetGetDownloading_totalHandler")]
			get {
				const string __id = "getDownloading_total.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setDownloading_total' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDownloading_total", "(I)V", "GetSetDownloading_total_IHandler")]
			set {
				const string __id = "setDownloading_total.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEstimated_reciprocation_rate;
#pragma warning disable 0169
		static Delegate GetGetEstimated_reciprocation_rateHandler ()
		{
			if (cb_getEstimated_reciprocation_rate == null)
				cb_getEstimated_reciprocation_rate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEstimated_reciprocation_rate);
			return cb_getEstimated_reciprocation_rate;
		}

		static int n_GetEstimated_reciprocation_rate (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Estimated_reciprocation_rate;
		}
#pragma warning restore 0169

		static Delegate cb_setEstimated_reciprocation_rate_I;
#pragma warning disable 0169
		static Delegate GetSetEstimated_reciprocation_rate_IHandler ()
		{
			if (cb_setEstimated_reciprocation_rate_I == null)
				cb_setEstimated_reciprocation_rate_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetEstimated_reciprocation_rate_I);
			return cb_setEstimated_reciprocation_rate_I;
		}

		static void n_SetEstimated_reciprocation_rate_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Estimated_reciprocation_rate = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Estimated_reciprocation_rate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getEstimated_reciprocation_rate' and count(parameter)=0]"
			[Register ("getEstimated_reciprocation_rate", "()I", "GetGetEstimated_reciprocation_rateHandler")]
			get {
				const string __id = "getEstimated_reciprocation_rate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setEstimated_reciprocation_rate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setEstimated_reciprocation_rate", "(I)V", "GetSetEstimated_reciprocation_rate_IHandler")]
			set {
				const string __id = "setEstimated_reciprocation_rate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFailcount;
#pragma warning disable 0169
		static Delegate GetGetFailcountHandler ()
		{
			if (cb_getFailcount == null)
				cb_getFailcount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFailcount);
			return cb_getFailcount;
		}

		static int n_GetFailcount (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Failcount;
		}
#pragma warning restore 0169

		static Delegate cb_setFailcount_I;
#pragma warning disable 0169
		static Delegate GetSetFailcount_IHandler ()
		{
			if (cb_setFailcount_I == null)
				cb_setFailcount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFailcount_I);
			return cb_setFailcount_I;
		}

		static void n_SetFailcount_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Failcount = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Failcount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getFailcount' and count(parameter)=0]"
			[Register ("getFailcount", "()I", "GetGetFailcountHandler")]
			get {
				const string __id = "getFailcount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setFailcount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFailcount", "(I)V", "GetSetFailcount_IHandler")]
			set {
				const string __id = "setFailcount.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFlags;
#pragma warning disable 0169
		static Delegate GetGetFlagsHandler ()
		{
			if (cb_getFlags == null)
				cb_getFlags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFlags);
			return cb_getFlags;
		}

		static IntPtr n_GetFlags (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Flags);
		}
#pragma warning restore 0169

		static Delegate cb_setFlags_Lcom_frostwire_jlibtorrent_swig_peer_flags_t_;
#pragma warning disable 0169
		static Delegate GetSetFlags_Lcom_frostwire_jlibtorrent_swig_peer_flags_t_Handler ()
		{
			if (cb_setFlags_Lcom_frostwire_jlibtorrent_swig_peer_flags_t_ == null)
				cb_setFlags_Lcom_frostwire_jlibtorrent_swig_peer_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFlags_Lcom_frostwire_jlibtorrent_swig_peer_flags_t_);
			return cb_setFlags_Lcom_frostwire_jlibtorrent_swig_peer_flags_t_;
		}

		static void n_SetFlags_Lcom_frostwire_jlibtorrent_swig_peer_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Peer_flags_t value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Flags = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Peer_flags_t Flags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getFlags' and count(parameter)=0]"
			[Register ("getFlags", "()Lcom/frostwire/jlibtorrent/swig/peer_flags_t;", "GetGetFlagsHandler")]
			get {
				const string __id = "getFlags.()Lcom/frostwire/jlibtorrent/swig/peer_flags_t;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setFlags' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_flags_t']]"
			[Register ("setFlags", "(Lcom/frostwire/jlibtorrent/swig/peer_flags_t;)V", "GetSetFlags_Lcom_frostwire_jlibtorrent_swig_peer_flags_t_Handler")]
			set {
				const string __id = "setFlags.(Lcom/frostwire/jlibtorrent/swig/peer_flags_t;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIp;
#pragma warning disable 0169
		static Delegate GetGetIpHandler ()
		{
			if (cb_getIp == null)
				cb_getIp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIp);
			return cb_getIp;
		}

		static IntPtr n_GetIp (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Ip);
		}
#pragma warning restore 0169

		static Delegate cb_setIp_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_;
#pragma warning disable 0169
		static Delegate GetSetIp_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Handler ()
		{
			if (cb_setIp_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_ == null)
				cb_setIp_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIp_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_);
			return cb_setIp_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_;
		}

		static void n_SetIp_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Tcp_endpoint value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tcp_endpoint> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Ip = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Tcp_endpoint Ip {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getIp' and count(parameter)=0]"
			[Register ("getIp", "()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;", "GetGetIpHandler")]
			get {
				const string __id = "getIp.()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tcp_endpoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setIp' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.tcp_endpoint']]"
			[Register ("setIp", "(Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;)V", "GetSetIp_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Handler")]
			set {
				const string __id = "setIp.(Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLocal_endpoint;
#pragma warning disable 0169
		static Delegate GetGetLocal_endpointHandler ()
		{
			if (cb_getLocal_endpoint == null)
				cb_getLocal_endpoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocal_endpoint);
			return cb_getLocal_endpoint;
		}

		static IntPtr n_GetLocal_endpoint (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Local_endpoint);
		}
#pragma warning restore 0169

		static Delegate cb_setLocal_endpoint_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_;
#pragma warning disable 0169
		static Delegate GetSetLocal_endpoint_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Handler ()
		{
			if (cb_setLocal_endpoint_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_ == null)
				cb_setLocal_endpoint_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocal_endpoint_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_);
			return cb_setLocal_endpoint_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_;
		}

		static void n_SetLocal_endpoint_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Tcp_endpoint value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tcp_endpoint> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Local_endpoint = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Tcp_endpoint Local_endpoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getLocal_endpoint' and count(parameter)=0]"
			[Register ("getLocal_endpoint", "()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;", "GetGetLocal_endpointHandler")]
			get {
				const string __id = "getLocal_endpoint.()Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Tcp_endpoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setLocal_endpoint' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.tcp_endpoint']]"
			[Register ("setLocal_endpoint", "(Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;)V", "GetSetLocal_endpoint_Lcom_frostwire_jlibtorrent_swig_tcp_endpoint_Handler")]
			set {
				const string __id = "setLocal_endpoint.(Lcom/frostwire/jlibtorrent/swig/tcp_endpoint;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNum_hashfails;
#pragma warning disable 0169
		static Delegate GetGetNum_hashfailsHandler ()
		{
			if (cb_getNum_hashfails == null)
				cb_getNum_hashfails = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNum_hashfails);
			return cb_getNum_hashfails;
		}

		static int n_GetNum_hashfails (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_hashfails;
		}
#pragma warning restore 0169

		static Delegate cb_setNum_hashfails_I;
#pragma warning disable 0169
		static Delegate GetSetNum_hashfails_IHandler ()
		{
			if (cb_setNum_hashfails_I == null)
				cb_setNum_hashfails_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNum_hashfails_I);
			return cb_setNum_hashfails_I;
		}

		static void n_SetNum_hashfails_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Num_hashfails = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Num_hashfails {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getNum_hashfails' and count(parameter)=0]"
			[Register ("getNum_hashfails", "()I", "GetGetNum_hashfailsHandler")]
			get {
				const string __id = "getNum_hashfails.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setNum_hashfails' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNum_hashfails", "(I)V", "GetSetNum_hashfails_IHandler")]
			set {
				const string __id = "setNum_hashfails.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNum_pieces;
#pragma warning disable 0169
		static Delegate GetGetNum_piecesHandler ()
		{
			if (cb_getNum_pieces == null)
				cb_getNum_pieces = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNum_pieces);
			return cb_getNum_pieces;
		}

		static int n_GetNum_pieces (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num_pieces;
		}
#pragma warning restore 0169

		static Delegate cb_setNum_pieces_I;
#pragma warning disable 0169
		static Delegate GetSetNum_pieces_IHandler ()
		{
			if (cb_setNum_pieces_I == null)
				cb_setNum_pieces_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNum_pieces_I);
			return cb_setNum_pieces_I;
		}

		static void n_SetNum_pieces_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Num_pieces = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Num_pieces {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getNum_pieces' and count(parameter)=0]"
			[Register ("getNum_pieces", "()I", "GetGetNum_piecesHandler")]
			get {
				const string __id = "getNum_pieces.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setNum_pieces' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNum_pieces", "(I)V", "GetSetNum_pieces_IHandler")]
			set {
				const string __id = "setNum_pieces.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPayload_down_speed;
#pragma warning disable 0169
		static Delegate GetGetPayload_down_speedHandler ()
		{
			if (cb_getPayload_down_speed == null)
				cb_getPayload_down_speed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPayload_down_speed);
			return cb_getPayload_down_speed;
		}

		static int n_GetPayload_down_speed (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Payload_down_speed;
		}
#pragma warning restore 0169

		static Delegate cb_setPayload_down_speed_I;
#pragma warning disable 0169
		static Delegate GetSetPayload_down_speed_IHandler ()
		{
			if (cb_setPayload_down_speed_I == null)
				cb_setPayload_down_speed_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPayload_down_speed_I);
			return cb_setPayload_down_speed_I;
		}

		static void n_SetPayload_down_speed_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Payload_down_speed = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Payload_down_speed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getPayload_down_speed' and count(parameter)=0]"
			[Register ("getPayload_down_speed", "()I", "GetGetPayload_down_speedHandler")]
			get {
				const string __id = "getPayload_down_speed.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setPayload_down_speed' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPayload_down_speed", "(I)V", "GetSetPayload_down_speed_IHandler")]
			set {
				const string __id = "setPayload_down_speed.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPayload_up_speed;
#pragma warning disable 0169
		static Delegate GetGetPayload_up_speedHandler ()
		{
			if (cb_getPayload_up_speed == null)
				cb_getPayload_up_speed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPayload_up_speed);
			return cb_getPayload_up_speed;
		}

		static int n_GetPayload_up_speed (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Payload_up_speed;
		}
#pragma warning restore 0169

		static Delegate cb_setPayload_up_speed_I;
#pragma warning disable 0169
		static Delegate GetSetPayload_up_speed_IHandler ()
		{
			if (cb_setPayload_up_speed_I == null)
				cb_setPayload_up_speed_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPayload_up_speed_I);
			return cb_setPayload_up_speed_I;
		}

		static void n_SetPayload_up_speed_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Payload_up_speed = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Payload_up_speed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getPayload_up_speed' and count(parameter)=0]"
			[Register ("getPayload_up_speed", "()I", "GetGetPayload_up_speedHandler")]
			get {
				const string __id = "getPayload_up_speed.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setPayload_up_speed' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPayload_up_speed", "(I)V", "GetSetPayload_up_speed_IHandler")]
			set {
				const string __id = "setPayload_up_speed.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPending_disk_bytes;
#pragma warning disable 0169
		static Delegate GetGetPending_disk_bytesHandler ()
		{
			if (cb_getPending_disk_bytes == null)
				cb_getPending_disk_bytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPending_disk_bytes);
			return cb_getPending_disk_bytes;
		}

		static int n_GetPending_disk_bytes (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Pending_disk_bytes;
		}
#pragma warning restore 0169

		static Delegate cb_setPending_disk_bytes_I;
#pragma warning disable 0169
		static Delegate GetSetPending_disk_bytes_IHandler ()
		{
			if (cb_setPending_disk_bytes_I == null)
				cb_setPending_disk_bytes_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPending_disk_bytes_I);
			return cb_setPending_disk_bytes_I;
		}

		static void n_SetPending_disk_bytes_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pending_disk_bytes = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Pending_disk_bytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getPending_disk_bytes' and count(parameter)=0]"
			[Register ("getPending_disk_bytes", "()I", "GetGetPending_disk_bytesHandler")]
			get {
				const string __id = "getPending_disk_bytes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setPending_disk_bytes' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPending_disk_bytes", "(I)V", "GetSetPending_disk_bytes_IHandler")]
			set {
				const string __id = "setPending_disk_bytes.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPending_disk_read_bytes;
#pragma warning disable 0169
		static Delegate GetGetPending_disk_read_bytesHandler ()
		{
			if (cb_getPending_disk_read_bytes == null)
				cb_getPending_disk_read_bytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPending_disk_read_bytes);
			return cb_getPending_disk_read_bytes;
		}

		static int n_GetPending_disk_read_bytes (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Pending_disk_read_bytes;
		}
#pragma warning restore 0169

		static Delegate cb_setPending_disk_read_bytes_I;
#pragma warning disable 0169
		static Delegate GetSetPending_disk_read_bytes_IHandler ()
		{
			if (cb_setPending_disk_read_bytes_I == null)
				cb_setPending_disk_read_bytes_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPending_disk_read_bytes_I);
			return cb_setPending_disk_read_bytes_I;
		}

		static void n_SetPending_disk_read_bytes_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pending_disk_read_bytes = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Pending_disk_read_bytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getPending_disk_read_bytes' and count(parameter)=0]"
			[Register ("getPending_disk_read_bytes", "()I", "GetGetPending_disk_read_bytesHandler")]
			get {
				const string __id = "getPending_disk_read_bytes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setPending_disk_read_bytes' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPending_disk_read_bytes", "(I)V", "GetSetPending_disk_read_bytes_IHandler")]
			set {
				const string __id = "setPending_disk_read_bytes.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPid;
#pragma warning disable 0169
		static Delegate GetGetPidHandler ()
		{
			if (cb_getPid == null)
				cb_getPid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPid);
			return cb_getPid;
		}

		static IntPtr n_GetPid (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pid);
		}
#pragma warning restore 0169

		static Delegate cb_setPid_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
#pragma warning disable 0169
		static Delegate GetSetPid_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler ()
		{
			if (cb_setPid_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ == null)
				cb_setPid_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPid_Lcom_frostwire_jlibtorrent_swig_sha1_hash_);
			return cb_setPid_Lcom_frostwire_jlibtorrent_swig_sha1_hash_;
		}

		static void n_SetPid_Lcom_frostwire_jlibtorrent_swig_sha1_hash_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Sha1_hash value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Pid = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash Pid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getPid' and count(parameter)=0]"
			[Register ("getPid", "()Lcom/frostwire/jlibtorrent/swig/sha1_hash;", "GetGetPidHandler")]
			get {
				const string __id = "getPid.()Lcom/frostwire/jlibtorrent/swig/sha1_hash;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setPid' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
			[Register ("setPid", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V", "GetSetPid_Lcom_frostwire_jlibtorrent_swig_sha1_hash_Handler")]
			set {
				const string __id = "setPid.(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPieces;
#pragma warning disable 0169
		static Delegate GetGetPiecesHandler ()
		{
			if (cb_getPieces == null)
				cb_getPieces = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPieces);
			return cb_getPieces;
		}

		static IntPtr n_GetPieces (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Pieces);
		}
#pragma warning restore 0169

		static Delegate cb_setPieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_;
#pragma warning disable 0169
		static Delegate GetSetPieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_Handler ()
		{
			if (cb_setPieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_ == null)
				cb_setPieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_);
			return cb_setPieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_;
		}

		static void n_SetPieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Piece_index_bitfield value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Pieces = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Piece_index_bitfield Pieces {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getPieces' and count(parameter)=0]"
			[Register ("getPieces", "()Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;", "GetGetPiecesHandler")]
			get {
				const string __id = "getPieces.()Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setPieces' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.piece_index_bitfield']]"
			[Register ("setPieces", "(Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;)V", "GetSetPieces_Lcom_frostwire_jlibtorrent_swig_piece_index_bitfield_Handler")]
			set {
				const string __id = "setPieces.(Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProgress;
#pragma warning disable 0169
		static Delegate GetGetProgressHandler ()
		{
			if (cb_getProgress == null)
				cb_getProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetProgress);
			return cb_getProgress;
		}

		static float n_GetProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Progress;
		}
#pragma warning restore 0169

		static Delegate cb_setProgress_F;
#pragma warning disable 0169
		static Delegate GetSetProgress_FHandler ()
		{
			if (cb_setProgress_F == null)
				cb_setProgress_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetProgress_F);
			return cb_setProgress_F;
		}

		static void n_SetProgress_F (IntPtr jnienv, IntPtr native__this, float value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Progress = value;
		}
#pragma warning restore 0169

		public virtual unsafe float Progress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getProgress' and count(parameter)=0]"
			[Register ("getProgress", "()F", "GetGetProgressHandler")]
			get {
				const string __id = "getProgress.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setProgress' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setProgress", "(F)V", "GetSetProgress_FHandler")]
			set {
				const string __id = "setProgress.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProgress_ppm;
#pragma warning disable 0169
		static Delegate GetGetProgress_ppmHandler ()
		{
			if (cb_getProgress_ppm == null)
				cb_getProgress_ppm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetProgress_ppm);
			return cb_getProgress_ppm;
		}

		static int n_GetProgress_ppm (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Progress_ppm;
		}
#pragma warning restore 0169

		static Delegate cb_setProgress_ppm_I;
#pragma warning disable 0169
		static Delegate GetSetProgress_ppm_IHandler ()
		{
			if (cb_setProgress_ppm_I == null)
				cb_setProgress_ppm_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetProgress_ppm_I);
			return cb_setProgress_ppm_I;
		}

		static void n_SetProgress_ppm_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Progress_ppm = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Progress_ppm {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getProgress_ppm' and count(parameter)=0]"
			[Register ("getProgress_ppm", "()I", "GetGetProgress_ppmHandler")]
			get {
				const string __id = "getProgress_ppm.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setProgress_ppm' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setProgress_ppm", "(I)V", "GetSetProgress_ppm_IHandler")]
			set {
				const string __id = "setProgress_ppm.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getQueue_bytes;
#pragma warning disable 0169
		static Delegate GetGetQueue_bytesHandler ()
		{
			if (cb_getQueue_bytes == null)
				cb_getQueue_bytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetQueue_bytes);
			return cb_getQueue_bytes;
		}

		static int n_GetQueue_bytes (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Queue_bytes;
		}
#pragma warning restore 0169

		static Delegate cb_setQueue_bytes_I;
#pragma warning disable 0169
		static Delegate GetSetQueue_bytes_IHandler ()
		{
			if (cb_setQueue_bytes_I == null)
				cb_setQueue_bytes_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetQueue_bytes_I);
			return cb_setQueue_bytes_I;
		}

		static void n_SetQueue_bytes_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Queue_bytes = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Queue_bytes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getQueue_bytes' and count(parameter)=0]"
			[Register ("getQueue_bytes", "()I", "GetGetQueue_bytesHandler")]
			get {
				const string __id = "getQueue_bytes.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setQueue_bytes' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setQueue_bytes", "(I)V", "GetSetQueue_bytes_IHandler")]
			set {
				const string __id = "setQueue_bytes.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRead_state;
#pragma warning disable 0169
		static Delegate GetGetRead_stateHandler ()
		{
			if (cb_getRead_state == null)
				cb_getRead_state = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRead_state);
			return cb_getRead_state;
		}

		static IntPtr n_GetRead_state (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Read_state);
		}
#pragma warning restore 0169

		static Delegate cb_setRead_state_Lcom_frostwire_jlibtorrent_swig_bandwidth_state_flags_t_;
#pragma warning disable 0169
		static Delegate GetSetRead_state_Lcom_frostwire_jlibtorrent_swig_bandwidth_state_flags_t_Handler ()
		{
			if (cb_setRead_state_Lcom_frostwire_jlibtorrent_swig_bandwidth_state_flags_t_ == null)
				cb_setRead_state_Lcom_frostwire_jlibtorrent_swig_bandwidth_state_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRead_state_Lcom_frostwire_jlibtorrent_swig_bandwidth_state_flags_t_);
			return cb_setRead_state_Lcom_frostwire_jlibtorrent_swig_bandwidth_state_flags_t_;
		}

		static void n_SetRead_state_Lcom_frostwire_jlibtorrent_swig_bandwidth_state_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Bandwidth_state_flags_t value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bandwidth_state_flags_t> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Read_state = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Bandwidth_state_flags_t Read_state {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getRead_state' and count(parameter)=0]"
			[Register ("getRead_state", "()Lcom/frostwire/jlibtorrent/swig/bandwidth_state_flags_t;", "GetGetRead_stateHandler")]
			get {
				const string __id = "getRead_state.()Lcom/frostwire/jlibtorrent/swig/bandwidth_state_flags_t;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bandwidth_state_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setRead_state' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.bandwidth_state_flags_t']]"
			[Register ("setRead_state", "(Lcom/frostwire/jlibtorrent/swig/bandwidth_state_flags_t;)V", "GetSetRead_state_Lcom_frostwire_jlibtorrent_swig_bandwidth_state_flags_t_Handler")]
			set {
				const string __id = "setRead_state.(Lcom/frostwire/jlibtorrent/swig/bandwidth_state_flags_t;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getReceive_buffer_size;
#pragma warning disable 0169
		static Delegate GetGetReceive_buffer_sizeHandler ()
		{
			if (cb_getReceive_buffer_size == null)
				cb_getReceive_buffer_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReceive_buffer_size);
			return cb_getReceive_buffer_size;
		}

		static int n_GetReceive_buffer_size (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Receive_buffer_size;
		}
#pragma warning restore 0169

		static Delegate cb_setReceive_buffer_size_I;
#pragma warning disable 0169
		static Delegate GetSetReceive_buffer_size_IHandler ()
		{
			if (cb_setReceive_buffer_size_I == null)
				cb_setReceive_buffer_size_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetReceive_buffer_size_I);
			return cb_setReceive_buffer_size_I;
		}

		static void n_SetReceive_buffer_size_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Receive_buffer_size = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Receive_buffer_size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getReceive_buffer_size' and count(parameter)=0]"
			[Register ("getReceive_buffer_size", "()I", "GetGetReceive_buffer_sizeHandler")]
			get {
				const string __id = "getReceive_buffer_size.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setReceive_buffer_size' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setReceive_buffer_size", "(I)V", "GetSetReceive_buffer_size_IHandler")]
			set {
				const string __id = "setReceive_buffer_size.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getReceive_buffer_watermark;
#pragma warning disable 0169
		static Delegate GetGetReceive_buffer_watermarkHandler ()
		{
			if (cb_getReceive_buffer_watermark == null)
				cb_getReceive_buffer_watermark = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReceive_buffer_watermark);
			return cb_getReceive_buffer_watermark;
		}

		static int n_GetReceive_buffer_watermark (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Receive_buffer_watermark;
		}
#pragma warning restore 0169

		static Delegate cb_setReceive_buffer_watermark_I;
#pragma warning disable 0169
		static Delegate GetSetReceive_buffer_watermark_IHandler ()
		{
			if (cb_setReceive_buffer_watermark_I == null)
				cb_setReceive_buffer_watermark_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetReceive_buffer_watermark_I);
			return cb_setReceive_buffer_watermark_I;
		}

		static void n_SetReceive_buffer_watermark_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Receive_buffer_watermark = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Receive_buffer_watermark {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getReceive_buffer_watermark' and count(parameter)=0]"
			[Register ("getReceive_buffer_watermark", "()I", "GetGetReceive_buffer_watermarkHandler")]
			get {
				const string __id = "getReceive_buffer_watermark.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setReceive_buffer_watermark' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setReceive_buffer_watermark", "(I)V", "GetSetReceive_buffer_watermark_IHandler")]
			set {
				const string __id = "setReceive_buffer_watermark.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getReceive_quota;
#pragma warning disable 0169
		static Delegate GetGetReceive_quotaHandler ()
		{
			if (cb_getReceive_quota == null)
				cb_getReceive_quota = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReceive_quota);
			return cb_getReceive_quota;
		}

		static int n_GetReceive_quota (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Receive_quota;
		}
#pragma warning restore 0169

		static Delegate cb_setReceive_quota_I;
#pragma warning disable 0169
		static Delegate GetSetReceive_quota_IHandler ()
		{
			if (cb_setReceive_quota_I == null)
				cb_setReceive_quota_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetReceive_quota_I);
			return cb_setReceive_quota_I;
		}

		static void n_SetReceive_quota_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Receive_quota = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Receive_quota {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getReceive_quota' and count(parameter)=0]"
			[Register ("getReceive_quota", "()I", "GetGetReceive_quotaHandler")]
			get {
				const string __id = "getReceive_quota.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setReceive_quota' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setReceive_quota", "(I)V", "GetSetReceive_quota_IHandler")]
			set {
				const string __id = "setReceive_quota.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRequest_timeout;
#pragma warning disable 0169
		static Delegate GetGetRequest_timeoutHandler ()
		{
			if (cb_getRequest_timeout == null)
				cb_getRequest_timeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRequest_timeout);
			return cb_getRequest_timeout;
		}

		static int n_GetRequest_timeout (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Request_timeout;
		}
#pragma warning restore 0169

		static Delegate cb_setRequest_timeout_I;
#pragma warning disable 0169
		static Delegate GetSetRequest_timeout_IHandler ()
		{
			if (cb_setRequest_timeout_I == null)
				cb_setRequest_timeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRequest_timeout_I);
			return cb_setRequest_timeout_I;
		}

		static void n_SetRequest_timeout_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Request_timeout = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Request_timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getRequest_timeout' and count(parameter)=0]"
			[Register ("getRequest_timeout", "()I", "GetGetRequest_timeoutHandler")]
			get {
				const string __id = "getRequest_timeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setRequest_timeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRequest_timeout", "(I)V", "GetSetRequest_timeout_IHandler")]
			set {
				const string __id = "setRequest_timeout.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRequests_in_buffer;
#pragma warning disable 0169
		static Delegate GetGetRequests_in_bufferHandler ()
		{
			if (cb_getRequests_in_buffer == null)
				cb_getRequests_in_buffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRequests_in_buffer);
			return cb_getRequests_in_buffer;
		}

		static int n_GetRequests_in_buffer (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Requests_in_buffer;
		}
#pragma warning restore 0169

		static Delegate cb_setRequests_in_buffer_I;
#pragma warning disable 0169
		static Delegate GetSetRequests_in_buffer_IHandler ()
		{
			if (cb_setRequests_in_buffer_I == null)
				cb_setRequests_in_buffer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRequests_in_buffer_I);
			return cb_setRequests_in_buffer_I;
		}

		static void n_SetRequests_in_buffer_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Requests_in_buffer = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Requests_in_buffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getRequests_in_buffer' and count(parameter)=0]"
			[Register ("getRequests_in_buffer", "()I", "GetGetRequests_in_bufferHandler")]
			get {
				const string __id = "getRequests_in_buffer.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setRequests_in_buffer' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRequests_in_buffer", "(I)V", "GetSetRequests_in_buffer_IHandler")]
			set {
				const string __id = "setRequests_in_buffer.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRtt;
#pragma warning disable 0169
		static Delegate GetGetRttHandler ()
		{
			if (cb_getRtt == null)
				cb_getRtt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRtt);
			return cb_getRtt;
		}

		static int n_GetRtt (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Rtt;
		}
#pragma warning restore 0169

		static Delegate cb_setRtt_I;
#pragma warning disable 0169
		static Delegate GetSetRtt_IHandler ()
		{
			if (cb_setRtt_I == null)
				cb_setRtt_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRtt_I);
			return cb_setRtt_I;
		}

		static void n_SetRtt_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Rtt = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Rtt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getRtt' and count(parameter)=0]"
			[Register ("getRtt", "()I", "GetGetRttHandler")]
			get {
				const string __id = "getRtt.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setRtt' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRtt", "(I)V", "GetSetRtt_IHandler")]
			set {
				const string __id = "setRtt.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSend_buffer_size;
#pragma warning disable 0169
		static Delegate GetGetSend_buffer_sizeHandler ()
		{
			if (cb_getSend_buffer_size == null)
				cb_getSend_buffer_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSend_buffer_size);
			return cb_getSend_buffer_size;
		}

		static int n_GetSend_buffer_size (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Send_buffer_size;
		}
#pragma warning restore 0169

		static Delegate cb_setSend_buffer_size_I;
#pragma warning disable 0169
		static Delegate GetSetSend_buffer_size_IHandler ()
		{
			if (cb_setSend_buffer_size_I == null)
				cb_setSend_buffer_size_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSend_buffer_size_I);
			return cb_setSend_buffer_size_I;
		}

		static void n_SetSend_buffer_size_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Send_buffer_size = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Send_buffer_size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getSend_buffer_size' and count(parameter)=0]"
			[Register ("getSend_buffer_size", "()I", "GetGetSend_buffer_sizeHandler")]
			get {
				const string __id = "getSend_buffer_size.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setSend_buffer_size' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSend_buffer_size", "(I)V", "GetSetSend_buffer_size_IHandler")]
			set {
				const string __id = "setSend_buffer_size.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSend_quota;
#pragma warning disable 0169
		static Delegate GetGetSend_quotaHandler ()
		{
			if (cb_getSend_quota == null)
				cb_getSend_quota = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSend_quota);
			return cb_getSend_quota;
		}

		static int n_GetSend_quota (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Send_quota;
		}
#pragma warning restore 0169

		static Delegate cb_setSend_quota_I;
#pragma warning disable 0169
		static Delegate GetSetSend_quota_IHandler ()
		{
			if (cb_setSend_quota_I == null)
				cb_setSend_quota_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSend_quota_I);
			return cb_setSend_quota_I;
		}

		static void n_SetSend_quota_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Send_quota = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Send_quota {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getSend_quota' and count(parameter)=0]"
			[Register ("getSend_quota", "()I", "GetGetSend_quotaHandler")]
			get {
				const string __id = "getSend_quota.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setSend_quota' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSend_quota", "(I)V", "GetSetSend_quota_IHandler")]
			set {
				const string __id = "setSend_quota.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSource;
#pragma warning disable 0169
		static Delegate GetGetSourceHandler ()
		{
			if (cb_getSource == null)
				cb_getSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSource);
			return cb_getSource;
		}

		static IntPtr n_GetSource (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Source);
		}
#pragma warning restore 0169

		static Delegate cb_setSource_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_;
#pragma warning disable 0169
		static Delegate GetSetSource_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_Handler ()
		{
			if (cb_setSource_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_ == null)
				cb_setSource_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSource_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_);
			return cb_setSource_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_;
		}

		static void n_SetSource_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Peer_source_flags_t value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_source_flags_t> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Source = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Peer_source_flags_t Source {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getSource' and count(parameter)=0]"
			[Register ("getSource", "()Lcom/frostwire/jlibtorrent/swig/peer_source_flags_t;", "GetGetSourceHandler")]
			get {
				const string __id = "getSource.()Lcom/frostwire/jlibtorrent/swig/peer_source_flags_t;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_source_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setSource' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_source_flags_t']]"
			[Register ("setSource", "(Lcom/frostwire/jlibtorrent/swig/peer_source_flags_t;)V", "GetSetSource_Lcom_frostwire_jlibtorrent_swig_peer_source_flags_t_Handler")]
			set {
				const string __id = "setSource.(Lcom/frostwire/jlibtorrent/swig/peer_source_flags_t;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTarget_dl_queue_length;
#pragma warning disable 0169
		static Delegate GetGetTarget_dl_queue_lengthHandler ()
		{
			if (cb_getTarget_dl_queue_length == null)
				cb_getTarget_dl_queue_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTarget_dl_queue_length);
			return cb_getTarget_dl_queue_length;
		}

		static int n_GetTarget_dl_queue_length (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Target_dl_queue_length;
		}
#pragma warning restore 0169

		static Delegate cb_setTarget_dl_queue_length_I;
#pragma warning disable 0169
		static Delegate GetSetTarget_dl_queue_length_IHandler ()
		{
			if (cb_setTarget_dl_queue_length_I == null)
				cb_setTarget_dl_queue_length_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTarget_dl_queue_length_I);
			return cb_setTarget_dl_queue_length_I;
		}

		static void n_SetTarget_dl_queue_length_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Target_dl_queue_length = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Target_dl_queue_length {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getTarget_dl_queue_length' and count(parameter)=0]"
			[Register ("getTarget_dl_queue_length", "()I", "GetGetTarget_dl_queue_lengthHandler")]
			get {
				const string __id = "getTarget_dl_queue_length.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setTarget_dl_queue_length' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTarget_dl_queue_length", "(I)V", "GetSetTarget_dl_queue_length_IHandler")]
			set {
				const string __id = "setTarget_dl_queue_length.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTimed_out_requests;
#pragma warning disable 0169
		static Delegate GetGetTimed_out_requestsHandler ()
		{
			if (cb_getTimed_out_requests == null)
				cb_getTimed_out_requests = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTimed_out_requests);
			return cb_getTimed_out_requests;
		}

		static int n_GetTimed_out_requests (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Timed_out_requests;
		}
#pragma warning restore 0169

		static Delegate cb_setTimed_out_requests_I;
#pragma warning disable 0169
		static Delegate GetSetTimed_out_requests_IHandler ()
		{
			if (cb_setTimed_out_requests_I == null)
				cb_setTimed_out_requests_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTimed_out_requests_I);
			return cb_setTimed_out_requests_I;
		}

		static void n_SetTimed_out_requests_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Timed_out_requests = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Timed_out_requests {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getTimed_out_requests' and count(parameter)=0]"
			[Register ("getTimed_out_requests", "()I", "GetGetTimed_out_requestsHandler")]
			get {
				const string __id = "getTimed_out_requests.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setTimed_out_requests' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTimed_out_requests", "(I)V", "GetSetTimed_out_requests_IHandler")]
			set {
				const string __id = "setTimed_out_requests.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotal_download;
#pragma warning disable 0169
		static Delegate GetGetTotal_downloadHandler ()
		{
			if (cb_getTotal_download == null)
				cb_getTotal_download = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTotal_download);
			return cb_getTotal_download;
		}

		static long n_GetTotal_download (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Total_download;
		}
#pragma warning restore 0169

		static Delegate cb_setTotal_download_J;
#pragma warning disable 0169
		static Delegate GetSetTotal_download_JHandler ()
		{
			if (cb_setTotal_download_J == null)
				cb_setTotal_download_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTotal_download_J);
			return cb_setTotal_download_J;
		}

		static void n_SetTotal_download_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Total_download = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Total_download {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getTotal_download' and count(parameter)=0]"
			[Register ("getTotal_download", "()J", "GetGetTotal_downloadHandler")]
			get {
				const string __id = "getTotal_download.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setTotal_download' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTotal_download", "(J)V", "GetSetTotal_download_JHandler")]
			set {
				const string __id = "setTotal_download.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotal_upload;
#pragma warning disable 0169
		static Delegate GetGetTotal_uploadHandler ()
		{
			if (cb_getTotal_upload == null)
				cb_getTotal_upload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTotal_upload);
			return cb_getTotal_upload;
		}

		static long n_GetTotal_upload (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Total_upload;
		}
#pragma warning restore 0169

		static Delegate cb_setTotal_upload_J;
#pragma warning disable 0169
		static Delegate GetSetTotal_upload_JHandler ()
		{
			if (cb_setTotal_upload_J == null)
				cb_setTotal_upload_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTotal_upload_J);
			return cb_setTotal_upload_J;
		}

		static void n_SetTotal_upload_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Total_upload = value;
		}
#pragma warning restore 0169

		public virtual unsafe long Total_upload {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getTotal_upload' and count(parameter)=0]"
			[Register ("getTotal_upload", "()J", "GetGetTotal_uploadHandler")]
			get {
				const string __id = "getTotal_upload.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setTotal_upload' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setTotal_upload", "(J)V", "GetSetTotal_upload_JHandler")]
			set {
				const string __id = "setTotal_upload.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUp_speed;
#pragma warning disable 0169
		static Delegate GetGetUp_speedHandler ()
		{
			if (cb_getUp_speed == null)
				cb_getUp_speed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUp_speed);
			return cb_getUp_speed;
		}

		static int n_GetUp_speed (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Up_speed;
		}
#pragma warning restore 0169

		static Delegate cb_setUp_speed_I;
#pragma warning disable 0169
		static Delegate GetSetUp_speed_IHandler ()
		{
			if (cb_setUp_speed_I == null)
				cb_setUp_speed_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUp_speed_I);
			return cb_setUp_speed_I;
		}

		static void n_SetUp_speed_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Up_speed = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Up_speed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getUp_speed' and count(parameter)=0]"
			[Register ("getUp_speed", "()I", "GetGetUp_speedHandler")]
			get {
				const string __id = "getUp_speed.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setUp_speed' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUp_speed", "(I)V", "GetSetUp_speed_IHandler")]
			set {
				const string __id = "setUp_speed.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUpload_queue_length;
#pragma warning disable 0169
		static Delegate GetGetUpload_queue_lengthHandler ()
		{
			if (cb_getUpload_queue_length == null)
				cb_getUpload_queue_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUpload_queue_length);
			return cb_getUpload_queue_length;
		}

		static int n_GetUpload_queue_length (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Upload_queue_length;
		}
#pragma warning restore 0169

		static Delegate cb_setUpload_queue_length_I;
#pragma warning disable 0169
		static Delegate GetSetUpload_queue_length_IHandler ()
		{
			if (cb_setUpload_queue_length_I == null)
				cb_setUpload_queue_length_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUpload_queue_length_I);
			return cb_setUpload_queue_length_I;
		}

		static void n_SetUpload_queue_length_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Upload_queue_length = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Upload_queue_length {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getUpload_queue_length' and count(parameter)=0]"
			[Register ("getUpload_queue_length", "()I", "GetGetUpload_queue_lengthHandler")]
			get {
				const string __id = "getUpload_queue_length.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setUpload_queue_length' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUpload_queue_length", "(I)V", "GetSetUpload_queue_length_IHandler")]
			set {
				const string __id = "setUpload_queue_length.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUpload_rate_peak;
#pragma warning disable 0169
		static Delegate GetGetUpload_rate_peakHandler ()
		{
			if (cb_getUpload_rate_peak == null)
				cb_getUpload_rate_peak = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUpload_rate_peak);
			return cb_getUpload_rate_peak;
		}

		static int n_GetUpload_rate_peak (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Upload_rate_peak;
		}
#pragma warning restore 0169

		static Delegate cb_setUpload_rate_peak_I;
#pragma warning disable 0169
		static Delegate GetSetUpload_rate_peak_IHandler ()
		{
			if (cb_setUpload_rate_peak_I == null)
				cb_setUpload_rate_peak_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUpload_rate_peak_I);
			return cb_setUpload_rate_peak_I;
		}

		static void n_SetUpload_rate_peak_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Upload_rate_peak = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Upload_rate_peak {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getUpload_rate_peak' and count(parameter)=0]"
			[Register ("getUpload_rate_peak", "()I", "GetGetUpload_rate_peakHandler")]
			get {
				const string __id = "getUpload_rate_peak.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setUpload_rate_peak' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUpload_rate_peak", "(I)V", "GetSetUpload_rate_peak_IHandler")]
			set {
				const string __id = "setUpload_rate_peak.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUsed_receive_buffer;
#pragma warning disable 0169
		static Delegate GetGetUsed_receive_bufferHandler ()
		{
			if (cb_getUsed_receive_buffer == null)
				cb_getUsed_receive_buffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUsed_receive_buffer);
			return cb_getUsed_receive_buffer;
		}

		static int n_GetUsed_receive_buffer (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Used_receive_buffer;
		}
#pragma warning restore 0169

		static Delegate cb_setUsed_receive_buffer_I;
#pragma warning disable 0169
		static Delegate GetSetUsed_receive_buffer_IHandler ()
		{
			if (cb_setUsed_receive_buffer_I == null)
				cb_setUsed_receive_buffer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUsed_receive_buffer_I);
			return cb_setUsed_receive_buffer_I;
		}

		static void n_SetUsed_receive_buffer_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Used_receive_buffer = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Used_receive_buffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getUsed_receive_buffer' and count(parameter)=0]"
			[Register ("getUsed_receive_buffer", "()I", "GetGetUsed_receive_bufferHandler")]
			get {
				const string __id = "getUsed_receive_buffer.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setUsed_receive_buffer' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUsed_receive_buffer", "(I)V", "GetSetUsed_receive_buffer_IHandler")]
			set {
				const string __id = "setUsed_receive_buffer.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUsed_send_buffer;
#pragma warning disable 0169
		static Delegate GetGetUsed_send_bufferHandler ()
		{
			if (cb_getUsed_send_buffer == null)
				cb_getUsed_send_buffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUsed_send_buffer);
			return cb_getUsed_send_buffer;
		}

		static int n_GetUsed_send_buffer (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Used_send_buffer;
		}
#pragma warning restore 0169

		static Delegate cb_setUsed_send_buffer_I;
#pragma warning disable 0169
		static Delegate GetSetUsed_send_buffer_IHandler ()
		{
			if (cb_setUsed_send_buffer_I == null)
				cb_setUsed_send_buffer_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUsed_send_buffer_I);
			return cb_setUsed_send_buffer_I;
		}

		static void n_SetUsed_send_buffer_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Used_send_buffer = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Used_send_buffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getUsed_send_buffer' and count(parameter)=0]"
			[Register ("getUsed_send_buffer", "()I", "GetGetUsed_send_bufferHandler")]
			get {
				const string __id = "getUsed_send_buffer.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setUsed_send_buffer' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUsed_send_buffer", "(I)V", "GetSetUsed_send_buffer_IHandler")]
			set {
				const string __id = "setUsed_send_buffer.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWrite_state;
#pragma warning disable 0169
		static Delegate GetGetWrite_stateHandler ()
		{
			if (cb_getWrite_state == null)
				cb_getWrite_state = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWrite_state);
			return cb_getWrite_state;
		}

		static IntPtr n_GetWrite_state (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Write_state);
		}
#pragma warning restore 0169

		static Delegate cb_setWrite_state_Lcom_frostwire_jlibtorrent_swig_bandwidth_state_flags_t_;
#pragma warning disable 0169
		static Delegate GetSetWrite_state_Lcom_frostwire_jlibtorrent_swig_bandwidth_state_flags_t_Handler ()
		{
			if (cb_setWrite_state_Lcom_frostwire_jlibtorrent_swig_bandwidth_state_flags_t_ == null)
				cb_setWrite_state_Lcom_frostwire_jlibtorrent_swig_bandwidth_state_flags_t_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWrite_state_Lcom_frostwire_jlibtorrent_swig_bandwidth_state_flags_t_);
			return cb_setWrite_state_Lcom_frostwire_jlibtorrent_swig_bandwidth_state_flags_t_;
		}

		static void n_SetWrite_state_Lcom_frostwire_jlibtorrent_swig_bandwidth_state_flags_t_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Bandwidth_state_flags_t value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bandwidth_state_flags_t> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Write_state = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Bandwidth_state_flags_t Write_state {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getWrite_state' and count(parameter)=0]"
			[Register ("getWrite_state", "()Lcom/frostwire/jlibtorrent/swig/bandwidth_state_flags_t;", "GetGetWrite_stateHandler")]
			get {
				const string __id = "getWrite_state.()Lcom/frostwire/jlibtorrent/swig/bandwidth_state_flags_t;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bandwidth_state_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='setWrite_state' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.bandwidth_state_flags_t']]"
			[Register ("setWrite_state", "(Lcom/frostwire/jlibtorrent/swig/bandwidth_state_flags_t;)V", "GetSetWrite_state_Lcom_frostwire_jlibtorrent_swig_bandwidth_state_flags_t_Handler")]
			set {
				const string __id = "setWrite_state.(Lcom/frostwire/jlibtorrent/swig/bandwidth_state_flags_t;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.peer_info']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/peer_info;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Peer_info obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/peer_info;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_client;
#pragma warning disable 0169
		static Delegate GetGet_clientHandler ()
		{
			if (cb_get_client == null)
				cb_get_client = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_client);
			return cb_get_client;
		}

		static IntPtr n_Get_client (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_client ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='get_client' and count(parameter)=0]"
		[Register ("get_client", "()Lcom/frostwire/jlibtorrent/swig/byte_vector;", "GetGet_clientHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Get_client ()
		{
			const string __id = "get_client.()Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_download_queue_time;
#pragma warning disable 0169
		static Delegate GetGet_download_queue_timeHandler ()
		{
			if (cb_get_download_queue_time == null)
				cb_get_download_queue_time = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Get_download_queue_time);
			return cb_get_download_queue_time;
		}

		static long n_Get_download_queue_time (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_download_queue_time ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='get_download_queue_time' and count(parameter)=0]"
		[Register ("get_download_queue_time", "()J", "GetGet_download_queue_timeHandler")]
		public virtual unsafe long Get_download_queue_time ()
		{
			const string __id = "get_download_queue_time.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_flags;
#pragma warning disable 0169
		static Delegate GetGet_flagsHandler ()
		{
			if (cb_get_flags == null)
				cb_get_flags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Get_flags);
			return cb_get_flags;
		}

		static int n_Get_flags (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_flags ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='get_flags' and count(parameter)=0]"
		[Register ("get_flags", "()I", "GetGet_flagsHandler")]
		public virtual unsafe int Get_flags ()
		{
			const string __id = "get_flags.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_last_active;
#pragma warning disable 0169
		static Delegate GetGet_last_activeHandler ()
		{
			if (cb_get_last_active == null)
				cb_get_last_active = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Get_last_active);
			return cb_get_last_active;
		}

		static long n_Get_last_active (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_last_active ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='get_last_active' and count(parameter)=0]"
		[Register ("get_last_active", "()J", "GetGet_last_activeHandler")]
		public virtual unsafe long Get_last_active ()
		{
			const string __id = "get_last_active.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_last_request;
#pragma warning disable 0169
		static Delegate GetGet_last_requestHandler ()
		{
			if (cb_get_last_request == null)
				cb_get_last_request = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Get_last_request);
			return cb_get_last_request;
		}

		static long n_Get_last_request (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_last_request ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='get_last_request' and count(parameter)=0]"
		[Register ("get_last_request", "()J", "GetGet_last_requestHandler")]
		public virtual unsafe long Get_last_request ()
		{
			const string __id = "get_last_request.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_read_state;
#pragma warning disable 0169
		static Delegate GetGet_read_stateHandler ()
		{
			if (cb_get_read_state == null)
				cb_get_read_state = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_Get_read_state);
			return cb_get_read_state;
		}

		static sbyte n_Get_read_state (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_read_state ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='get_read_state' and count(parameter)=0]"
		[Register ("get_read_state", "()B", "GetGet_read_stateHandler")]
		public virtual unsafe sbyte Get_read_state ()
		{
			const string __id = "get_read_state.()B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_source;
#pragma warning disable 0169
		static Delegate GetGet_sourceHandler ()
		{
			if (cb_get_source == null)
				cb_get_source = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_Get_source);
			return cb_get_source;
		}

		static sbyte n_Get_source (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_source ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='get_source' and count(parameter)=0]"
		[Register ("get_source", "()B", "GetGet_sourceHandler")]
		public virtual unsafe sbyte Get_source ()
		{
			const string __id = "get_source.()B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_write_state;
#pragma warning disable 0169
		static Delegate GetGet_write_stateHandler ()
		{
			if (cb_get_write_state == null)
				cb_get_write_state = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_Get_write_state);
			return cb_get_write_state;
		}

		static sbyte n_Get_write_state (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Peer_info __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Peer_info> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_write_state ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='peer_info']/method[@name='get_write_state' and count(parameter)=0]"
		[Register ("get_write_state", "()B", "GetGet_write_stateHandler")]
		public virtual unsafe sbyte Get_write_state ()
		{
			const string __id = "get_write_state.()B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
