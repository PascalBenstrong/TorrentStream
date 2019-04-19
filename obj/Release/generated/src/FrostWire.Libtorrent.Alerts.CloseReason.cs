using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/CloseReason", DoNotGenerateAcw=true)]
	public sealed partial class CloseReason : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='BLOCKED']"
		[Register ("BLOCKED")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason Blocked {
			get {
				const string __id = "BLOCKED.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='CORRUPT_PIECES']"
		[Register ("CORRUPT_PIECES")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason CorruptPieces {
			get {
				const string __id = "CORRUPT_PIECES.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='DUPLICATE_PEER_ID']"
		[Register ("DUPLICATE_PEER_ID")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason DuplicatePeerId {
			get {
				const string __id = "DUPLICATE_PEER_ID.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='ENCRYPTION_ERROR']"
		[Register ("ENCRYPTION_ERROR")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason EncryptionError {
			get {
				const string __id = "ENCRYPTION_ERROR.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_ALLOW_FAST_MESSAGE']"
		[Register ("INVALID_ALLOW_FAST_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidAllowFastMessage {
			get {
				const string __id = "INVALID_ALLOW_FAST_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_BITFIELD_MESSAGE']"
		[Register ("INVALID_BITFIELD_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidBitfieldMessage {
			get {
				const string __id = "INVALID_BITFIELD_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_CANCEL_MESSAGE']"
		[Register ("INVALID_CANCEL_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidCancelMessage {
			get {
				const string __id = "INVALID_CANCEL_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_CHOKE_MESSAGE']"
		[Register ("INVALID_CHOKE_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidChokeMessage {
			get {
				const string __id = "INVALID_CHOKE_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_DHT_PORT_MESSAGE']"
		[Register ("INVALID_DHT_PORT_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidDhtPortMessage {
			get {
				const string __id = "INVALID_DHT_PORT_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_DONT_HAVE_MESSAGE']"
		[Register ("INVALID_DONT_HAVE_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidDontHaveMessage {
			get {
				const string __id = "INVALID_DONT_HAVE_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_HAVE_ALL_MESSAGE']"
		[Register ("INVALID_HAVE_ALL_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidHaveAllMessage {
			get {
				const string __id = "INVALID_HAVE_ALL_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_HAVE_MESSAGE']"
		[Register ("INVALID_HAVE_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidHaveMessage {
			get {
				const string __id = "INVALID_HAVE_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_HAVE_NONE_MESSAGE']"
		[Register ("INVALID_HAVE_NONE_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidHaveNoneMessage {
			get {
				const string __id = "INVALID_HAVE_NONE_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_INFO_HASH']"
		[Register ("INVALID_INFO_HASH")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidInfoHash {
			get {
				const string __id = "INVALID_INFO_HASH.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_INTERESTED_MESSAGE']"
		[Register ("INVALID_INTERESTED_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidInterestedMessage {
			get {
				const string __id = "INVALID_INTERESTED_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_MESSAGE']"
		[Register ("INVALID_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidMessage {
			get {
				const string __id = "INVALID_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_MESSAGE_ID']"
		[Register ("INVALID_MESSAGE_ID")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidMessageId {
			get {
				const string __id = "INVALID_MESSAGE_ID.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_METADATA']"
		[Register ("INVALID_METADATA")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidMetadata {
			get {
				const string __id = "INVALID_METADATA.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_METADATA_MESSAGE']"
		[Register ("INVALID_METADATA_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidMetadataMessage {
			get {
				const string __id = "INVALID_METADATA_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_METADATA_OFFSET']"
		[Register ("INVALID_METADATA_OFFSET")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidMetadataOffset {
			get {
				const string __id = "INVALID_METADATA_OFFSET.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_METADATA_REQUEST_MESSAGE']"
		[Register ("INVALID_METADATA_REQUEST_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidMetadataRequestMessage {
			get {
				const string __id = "INVALID_METADATA_REQUEST_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_NOT_INTERESTED_MESSAGE']"
		[Register ("INVALID_NOT_INTERESTED_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidNotInterestedMessage {
			get {
				const string __id = "INVALID_NOT_INTERESTED_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_PEX_MESSAGE']"
		[Register ("INVALID_PEX_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidPexMessage {
			get {
				const string __id = "INVALID_PEX_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_PIECE_MESSAGE']"
		[Register ("INVALID_PIECE_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidPieceMessage {
			get {
				const string __id = "INVALID_PIECE_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_REJECT_MESSAGE']"
		[Register ("INVALID_REJECT_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidRejectMessage {
			get {
				const string __id = "INVALID_REJECT_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_REQUEST_MESSAGE']"
		[Register ("INVALID_REQUEST_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidRequestMessage {
			get {
				const string __id = "INVALID_REQUEST_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_SUGGEST_MESSAGE']"
		[Register ("INVALID_SUGGEST_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidSuggestMessage {
			get {
				const string __id = "INVALID_SUGGEST_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='INVALID_UNCHOKE_MESSAGE']"
		[Register ("INVALID_UNCHOKE_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason InvalidUnchokeMessage {
			get {
				const string __id = "INVALID_UNCHOKE_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='MESSAGE_TOO_BIG']"
		[Register ("MESSAGE_TOO_BIG")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason MessageTooBig {
			get {
				const string __id = "MESSAGE_TOO_BIG.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='METADATA_TOO_BIG']"
		[Register ("METADATA_TOO_BIG")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason MetadataTooBig {
			get {
				const string __id = "METADATA_TOO_BIG.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason None {
			get {
				const string __id = "NONE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='NOT_INTERESTED_UPLOAD_ONLY']"
		[Register ("NOT_INTERESTED_UPLOAD_ONLY")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason NotInterestedUploadOnly {
			get {
				const string __id = "NOT_INTERESTED_UPLOAD_ONLY.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='NO_MEMORY']"
		[Register ("NO_MEMORY")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason NoMemory {
			get {
				const string __id = "NO_MEMORY.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='NVALID_EXTENDED_MESSAGE']"
		[Register ("NVALID_EXTENDED_MESSAGE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason NvalidExtendedMessage {
			get {
				const string __id = "NVALID_EXTENDED_MESSAGE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='PEER_CHURN']"
		[Register ("PEER_CHURN")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason PeerChurn {
			get {
				const string __id = "PEER_CHURN.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='PEX_MESSAGE_TOO_BIG']"
		[Register ("PEX_MESSAGE_TOO_BIG")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason PexMessageTooBig {
			get {
				const string __id = "PEX_MESSAGE_TOO_BIG.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='PEX_TOO_FREQUENT']"
		[Register ("PEX_TOO_FREQUENT")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason PexTooFrequent {
			get {
				const string __id = "PEX_TOO_FREQUENT.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='PORT_BLOCKED']"
		[Register ("PORT_BLOCKED")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason PortBlocked {
			get {
				const string __id = "PORT_BLOCKED.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='PROTOCOL_BLOCKED']"
		[Register ("PROTOCOL_BLOCKED")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason ProtocolBlocked {
			get {
				const string __id = "PROTOCOL_BLOCKED.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='REQUEST_WHEN_CHOKED']"
		[Register ("REQUEST_WHEN_CHOKED")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason RequestWhenChoked {
			get {
				const string __id = "REQUEST_WHEN_CHOKED.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='SELF_CONNECTION']"
		[Register ("SELF_CONNECTION")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason SelfConnection {
			get {
				const string __id = "SELF_CONNECTION.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='TIMED_OUT_ACTIVITY']"
		[Register ("TIMED_OUT_ACTIVITY")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason TimedOutActivity {
			get {
				const string __id = "TIMED_OUT_ACTIVITY.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='TIMED_OUT_HANDSHAKE']"
		[Register ("TIMED_OUT_HANDSHAKE")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason TimedOutHandshake {
			get {
				const string __id = "TIMED_OUT_HANDSHAKE.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='TIMED_OUT_INTEREST']"
		[Register ("TIMED_OUT_INTEREST")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason TimedOutInterest {
			get {
				const string __id = "TIMED_OUT_INTEREST.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='TIMED_OUT_REQUEST']"
		[Register ("TIMED_OUT_REQUEST")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason TimedOutRequest {
			get {
				const string __id = "TIMED_OUT_REQUEST.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='TIMEOUT']"
		[Register ("TIMEOUT")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason Timeout {
			get {
				const string __id = "TIMEOUT.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='TOO_MANY_CONNECTIONS']"
		[Register ("TOO_MANY_CONNECTIONS")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason TooManyConnections {
			get {
				const string __id = "TOO_MANY_CONNECTIONS.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='TOO_MANY_FILES']"
		[Register ("TOO_MANY_FILES")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason TooManyFiles {
			get {
				const string __id = "TOO_MANY_FILES.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='TORRENT_REMOVED']"
		[Register ("TORRENT_REMOVED")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason TorrentRemoved {
			get {
				const string __id = "TORRENT_REMOVED.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason Unknown {
			get {
				const string __id = "UNKNOWN.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/field[@name='UPLOAD_TO_UPLOAD']"
		[Register ("UPLOAD_TO_UPLOAD")]
		public static global::FrostWire.Libtorrent.Alerts.CloseReason UploadToUpload {
			get {
				const string __id = "UPLOAD_TO_UPLOAD.Lcom/frostwire/jlibtorrent/alerts/CloseReason;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/CloseReason", typeof (CloseReason));
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

		internal CloseReason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/method[@name='fromSwig' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromSwig", "(I)Lcom/frostwire/jlibtorrent/alerts/CloseReason;", "")]
		public static unsafe global::FrostWire.Libtorrent.Alerts.CloseReason FromSwig (int swigValue)
		{
			const string __id = "fromSwig.(I)Lcom/frostwire/jlibtorrent/alerts/CloseReason;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (swigValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/method[@name='swig' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/CloseReason;", "")]
		public static unsafe global::FrostWire.Libtorrent.Alerts.CloseReason ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/CloseReason;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.CloseReason> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='CloseReason']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/frostwire/jlibtorrent/alerts/CloseReason;", "")]
		public static unsafe global::FrostWire.Libtorrent.Alerts.CloseReason[] Values ()
		{
			const string __id = "values.()[Lcom/frostwire/jlibtorrent/alerts/CloseReason;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::FrostWire.Libtorrent.Alerts.CloseReason[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.Alerts.CloseReason));
			} finally {
			}
		}

	}
}
