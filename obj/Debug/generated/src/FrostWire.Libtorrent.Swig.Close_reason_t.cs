using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/close_reason_t", DoNotGenerateAcw=true)]
	public sealed partial class Close_reason_t : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='blocked']"
		[Register ("blocked")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t Blocked {
			get {
				const string __id = "blocked.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='corrupt_pieces']"
		[Register ("corrupt_pieces")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t CorruptPieces {
			get {
				const string __id = "corrupt_pieces.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='duplicate_peer_id']"
		[Register ("duplicate_peer_id")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t DuplicatePeerId {
			get {
				const string __id = "duplicate_peer_id.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='encryption_error']"
		[Register ("encryption_error")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t EncryptionError {
			get {
				const string __id = "encryption_error.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_allow_fast_message']"
		[Register ("invalid_allow_fast_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidAllowFastMessage {
			get {
				const string __id = "invalid_allow_fast_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_bitfield_message']"
		[Register ("invalid_bitfield_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidBitfieldMessage {
			get {
				const string __id = "invalid_bitfield_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_cancel_message']"
		[Register ("invalid_cancel_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidCancelMessage {
			get {
				const string __id = "invalid_cancel_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_choke_message']"
		[Register ("invalid_choke_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidChokeMessage {
			get {
				const string __id = "invalid_choke_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_dht_port_message']"
		[Register ("invalid_dht_port_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidDhtPortMessage {
			get {
				const string __id = "invalid_dht_port_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_dont_have_message']"
		[Register ("invalid_dont_have_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidDontHaveMessage {
			get {
				const string __id = "invalid_dont_have_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_extended_message']"
		[Register ("invalid_extended_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidExtendedMessage {
			get {
				const string __id = "invalid_extended_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_have_all_message']"
		[Register ("invalid_have_all_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidHaveAllMessage {
			get {
				const string __id = "invalid_have_all_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_have_message']"
		[Register ("invalid_have_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidHaveMessage {
			get {
				const string __id = "invalid_have_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_have_none_message']"
		[Register ("invalid_have_none_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidHaveNoneMessage {
			get {
				const string __id = "invalid_have_none_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_info_hash']"
		[Register ("invalid_info_hash")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidInfoHash {
			get {
				const string __id = "invalid_info_hash.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_interested_message']"
		[Register ("invalid_interested_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidInterestedMessage {
			get {
				const string __id = "invalid_interested_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_message']"
		[Register ("invalid_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidMessage {
			get {
				const string __id = "invalid_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_message_id']"
		[Register ("invalid_message_id")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidMessageId {
			get {
				const string __id = "invalid_message_id.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_metadata']"
		[Register ("invalid_metadata")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidMetadata {
			get {
				const string __id = "invalid_metadata.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_metadata_message']"
		[Register ("invalid_metadata_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidMetadataMessage {
			get {
				const string __id = "invalid_metadata_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_metadata_offset']"
		[Register ("invalid_metadata_offset")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidMetadataOffset {
			get {
				const string __id = "invalid_metadata_offset.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_metadata_request_message']"
		[Register ("invalid_metadata_request_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidMetadataRequestMessage {
			get {
				const string __id = "invalid_metadata_request_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_not_interested_message']"
		[Register ("invalid_not_interested_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidNotInterestedMessage {
			get {
				const string __id = "invalid_not_interested_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_pex_message']"
		[Register ("invalid_pex_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidPexMessage {
			get {
				const string __id = "invalid_pex_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_piece_message']"
		[Register ("invalid_piece_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidPieceMessage {
			get {
				const string __id = "invalid_piece_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_reject_message']"
		[Register ("invalid_reject_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidRejectMessage {
			get {
				const string __id = "invalid_reject_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_request_message']"
		[Register ("invalid_request_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidRequestMessage {
			get {
				const string __id = "invalid_request_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_suggest_message']"
		[Register ("invalid_suggest_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidSuggestMessage {
			get {
				const string __id = "invalid_suggest_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='invalid_unchoke_message']"
		[Register ("invalid_unchoke_message")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t InvalidUnchokeMessage {
			get {
				const string __id = "invalid_unchoke_message.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='message_too_big']"
		[Register ("message_too_big")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t MessageTooBig {
			get {
				const string __id = "message_too_big.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='metadata_too_big']"
		[Register ("metadata_too_big")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t MetadataTooBig {
			get {
				const string __id = "metadata_too_big.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='no_memory']"
		[Register ("no_memory")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t NoMemory {
			get {
				const string __id = "no_memory.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='none']"
		[Register ("none")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t None {
			get {
				const string __id = "none.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='not_interested_upload_only']"
		[Register ("not_interested_upload_only")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t NotInterestedUploadOnly {
			get {
				const string __id = "not_interested_upload_only.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='peer_churn']"
		[Register ("peer_churn")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t PeerChurn {
			get {
				const string __id = "peer_churn.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='pex_message_too_big']"
		[Register ("pex_message_too_big")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t PexMessageTooBig {
			get {
				const string __id = "pex_message_too_big.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='pex_too_frequent']"
		[Register ("pex_too_frequent")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t PexTooFrequent {
			get {
				const string __id = "pex_too_frequent.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='port_blocked']"
		[Register ("port_blocked")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t PortBlocked {
			get {
				const string __id = "port_blocked.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='protocol_blocked']"
		[Register ("protocol_blocked")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t ProtocolBlocked {
			get {
				const string __id = "protocol_blocked.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='request_when_choked']"
		[Register ("request_when_choked")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t RequestWhenChoked {
			get {
				const string __id = "request_when_choked.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='self_connection']"
		[Register ("self_connection")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t SelfConnection {
			get {
				const string __id = "self_connection.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='timed_out_activity']"
		[Register ("timed_out_activity")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t TimedOutActivity {
			get {
				const string __id = "timed_out_activity.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='timed_out_handshake']"
		[Register ("timed_out_handshake")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t TimedOutHandshake {
			get {
				const string __id = "timed_out_handshake.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='timed_out_interest']"
		[Register ("timed_out_interest")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t TimedOutInterest {
			get {
				const string __id = "timed_out_interest.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='timed_out_request']"
		[Register ("timed_out_request")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t TimedOutRequest {
			get {
				const string __id = "timed_out_request.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='timeout']"
		[Register ("timeout")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t Timeout {
			get {
				const string __id = "timeout.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='too_many_connections']"
		[Register ("too_many_connections")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t TooManyConnections {
			get {
				const string __id = "too_many_connections.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='too_many_files']"
		[Register ("too_many_files")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t TooManyFiles {
			get {
				const string __id = "too_many_files.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='torrent_removed']"
		[Register ("torrent_removed")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t TorrentRemoved {
			get {
				const string __id = "torrent_removed.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/field[@name='upload_to_upload']"
		[Register ("upload_to_upload")]
		public static global::FrostWire.Libtorrent.Swig.Close_reason_t UploadToUpload {
			get {
				const string __id = "upload_to_upload.Lcom/frostwire/jlibtorrent/swig/close_reason_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/close_reason_t", typeof (Close_reason_t));
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

		internal Close_reason_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/close_reason_t;", "")]
		public static unsafe global::FrostWire.Libtorrent.Swig.Close_reason_t SwigToEnum (int swigValue)
		{
			const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/close_reason_t;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (swigValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Close_reason_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='close_reason_t']/method[@name='swigValue' and count(parameter)=0]"
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
}
