using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/frostwire/jlibtorrent",
						"com/frostwire/jlibtorrent/alerts",
						"com/frostwire/jlibtorrent/swig",
						"com/github/se_bastiaan/torrentstream",
						"com/github/se_bastiaan/torrentstream/exceptions",
						"com/github/se_bastiaan/torrentstream/listeners",
						"com/github/se_bastiaan/torrentstream/utils",
					},
					new Converter<string, Type>[]{
						lookup_com_frostwire_jlibtorrent_package,
						lookup_com_frostwire_jlibtorrent_alerts_package,
						lookup_com_frostwire_jlibtorrent_swig_package,
						lookup_com_github_se_bastiaan_torrentstream_package,
						lookup_com_github_se_bastiaan_torrentstream_exceptions_package,
						lookup_com_github_se_bastiaan_torrentstream_listeners_package,
						lookup_com_github_se_bastiaan_torrentstream_utils_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_frostwire_jlibtorrent_mappings;
		static Type lookup_com_frostwire_jlibtorrent_package (string klass)
		{
			if (package_com_frostwire_jlibtorrent_mappings == null) {
				package_com_frostwire_jlibtorrent_mappings = new string[]{
					"com/frostwire/jlibtorrent/Address:FrostWire.Libtorrent.Address",
					"com/frostwire/jlibtorrent/AddTorrentParams:FrostWire.Libtorrent.AddTorrentParams",
					"com/frostwire/jlibtorrent/AnnounceEndpoint:FrostWire.Libtorrent.AnnounceEndpoint",
					"com/frostwire/jlibtorrent/AnnounceEntry:FrostWire.Libtorrent.AnnounceEntry",
					"com/frostwire/jlibtorrent/BDecodeNode:FrostWire.Libtorrent.BDecodeNode",
					"com/frostwire/jlibtorrent/BlockInfo:FrostWire.Libtorrent.BlockInfo",
					"com/frostwire/jlibtorrent/BlockInfo$BlockState:FrostWire.Libtorrent.BlockInfo/BlockState",
					"com/frostwire/jlibtorrent/DhtLookup:FrostWire.Libtorrent.DhtLookup",
					"com/frostwire/jlibtorrent/DhtRoutingBucket:FrostWire.Libtorrent.DhtRoutingBucket",
					"com/frostwire/jlibtorrent/DhtSettings:FrostWire.Libtorrent.DhtSettings",
					"com/frostwire/jlibtorrent/Ed25519:FrostWire.Libtorrent.Ed25519",
					"com/frostwire/jlibtorrent/Entry:FrostWire.Libtorrent.Entry",
					"com/frostwire/jlibtorrent/EnumNet:FrostWire.Libtorrent.EnumNet",
					"com/frostwire/jlibtorrent/EnumNet$IpInterface:FrostWire.Libtorrent.EnumNet/IpInterface",
					"com/frostwire/jlibtorrent/EnumNet$IpRoute:FrostWire.Libtorrent.EnumNet/IpRoute",
					"com/frostwire/jlibtorrent/ErrorCode:FrostWire.Libtorrent.ErrorCode",
					"com/frostwire/jlibtorrent/FileSlice:FrostWire.Libtorrent.FileSlice",
					"com/frostwire/jlibtorrent/FileStorage:FrostWire.Libtorrent.FileStorage",
					"com/frostwire/jlibtorrent/IntSeries:FrostWire.Libtorrent.IntSeries",
					"com/frostwire/jlibtorrent/LibTorrent:FrostWire.Libtorrent.LibTorrent",
					"com/frostwire/jlibtorrent/MoveFlags:FrostWire.Libtorrent.MoveFlags",
					"com/frostwire/jlibtorrent/Operation:FrostWire.Libtorrent.Operation",
					"com/frostwire/jlibtorrent/Pair:FrostWire.Libtorrent.Pair",
					"com/frostwire/jlibtorrent/PartialPieceInfo:FrostWire.Libtorrent.PartialPieceInfo",
					"com/frostwire/jlibtorrent/PeerInfo:FrostWire.Libtorrent.PeerInfo",
					"com/frostwire/jlibtorrent/PeerInfo$ConnectionType:FrostWire.Libtorrent.PeerInfo/ConnectionType",
					"com/frostwire/jlibtorrent/PeerRequest:FrostWire.Libtorrent.PeerRequest",
					"com/frostwire/jlibtorrent/PieceIndexBitfield:FrostWire.Libtorrent.PieceIndexBitfield",
					"com/frostwire/jlibtorrent/PiecesTracker:FrostWire.Libtorrent.PiecesTracker",
					"com/frostwire/jlibtorrent/PortmapProtocol:FrostWire.Libtorrent.PortmapProtocol",
					"com/frostwire/jlibtorrent/PortmapTransport:FrostWire.Libtorrent.PortmapTransport",
					"com/frostwire/jlibtorrent/Priority:FrostWire.Libtorrent.Priority",
					"com/frostwire/jlibtorrent/SessionHandle:FrostWire.Libtorrent.SessionHandle",
					"com/frostwire/jlibtorrent/SessionManager:FrostWire.Libtorrent.SessionManager",
					"com/frostwire/jlibtorrent/SessionManager$MutableItem:FrostWire.Libtorrent.SessionManager/MutableItem",
					"com/frostwire/jlibtorrent/SessionParams:FrostWire.Libtorrent.SessionParams",
					"com/frostwire/jlibtorrent/SessionStats:FrostWire.Libtorrent.SessionStats",
					"com/frostwire/jlibtorrent/SettingsPack:FrostWire.Libtorrent.SettingsPack",
					"com/frostwire/jlibtorrent/Sha1Hash:FrostWire.Libtorrent.Sha1Hash",
					"com/frostwire/jlibtorrent/StatsMetric:FrostWire.Libtorrent.StatsMetric",
					"com/frostwire/jlibtorrent/StorageMode:FrostWire.Libtorrent.StorageMode",
					"com/frostwire/jlibtorrent/TcpEndpoint:FrostWire.Libtorrent.TcpEndpoint",
					"com/frostwire/jlibtorrent/TorrentBuilder:FrostWire.Libtorrent.TorrentBuilder",
					"com/frostwire/jlibtorrent/TorrentBuilder$Result:FrostWire.Libtorrent.TorrentBuilder/Result",
					"com/frostwire/jlibtorrent/TorrentFlags:FrostWire.Libtorrent.TorrentFlags",
					"com/frostwire/jlibtorrent/TorrentHandle:FrostWire.Libtorrent.TorrentHandle",
					"com/frostwire/jlibtorrent/TorrentHandle$FileProgressFlags:FrostWire.Libtorrent.TorrentHandle/FileProgressFlags",
					"com/frostwire/jlibtorrent/TorrentInfo:FrostWire.Libtorrent.TorrentInfo",
					"com/frostwire/jlibtorrent/TorrentStats:FrostWire.Libtorrent.TorrentStats",
					"com/frostwire/jlibtorrent/TorrentStats$SeriesMetric:FrostWire.Libtorrent.TorrentStats/SeriesMetric",
					"com/frostwire/jlibtorrent/TorrentStatus:FrostWire.Libtorrent.TorrentStatus",
					"com/frostwire/jlibtorrent/TorrentStatus$State:FrostWire.Libtorrent.TorrentStatus/State",
					"com/frostwire/jlibtorrent/UdpEndpoint:FrostWire.Libtorrent.UdpEndpoint",
					"com/frostwire/jlibtorrent/Vectors:FrostWire.Libtorrent.Vectors",
					"com/frostwire/jlibtorrent/WebSeedEntry:FrostWire.Libtorrent.WebSeedEntry",
					"com/frostwire/jlibtorrent/WebSeedEntry$Type:FrostWire.Libtorrent.WebSeedEntry/Type",
				};
			}

			return Lookup (package_com_frostwire_jlibtorrent_mappings, klass);
		}

		static string[] package_com_frostwire_jlibtorrent_alerts_mappings;
		static Type lookup_com_frostwire_jlibtorrent_alerts_package (string klass)
		{
			if (package_com_frostwire_jlibtorrent_alerts_mappings == null) {
				package_com_frostwire_jlibtorrent_alerts_mappings = new string[]{
					"com/frostwire/jlibtorrent/alerts/AbstractAlert:FrostWire.Libtorrent.Alerts.AbstractAlert",
					"com/frostwire/jlibtorrent/alerts/AddTorrentAlert:FrostWire.Libtorrent.Alerts.AddTorrentAlert",
					"com/frostwire/jlibtorrent/alerts/Alerts:FrostWire.Libtorrent.Alerts.Alerts",
					"com/frostwire/jlibtorrent/alerts/AlertsDroppedAlert:FrostWire.Libtorrent.Alerts.AlertsDroppedAlert",
					"com/frostwire/jlibtorrent/alerts/AlertType:FrostWire.Libtorrent.Alerts.AlertType",
					"com/frostwire/jlibtorrent/alerts/BlockDownloadingAlert:FrostWire.Libtorrent.Alerts.BlockDownloadingAlert",
					"com/frostwire/jlibtorrent/alerts/BlockFinishedAlert:FrostWire.Libtorrent.Alerts.BlockFinishedAlert",
					"com/frostwire/jlibtorrent/alerts/BlockTimeoutAlert:FrostWire.Libtorrent.Alerts.BlockTimeoutAlert",
					"com/frostwire/jlibtorrent/alerts/BlockUploadedAlert:FrostWire.Libtorrent.Alerts.BlockUploadedAlert",
					"com/frostwire/jlibtorrent/alerts/CacheFlushedAlert:FrostWire.Libtorrent.Alerts.CacheFlushedAlert",
					"com/frostwire/jlibtorrent/alerts/CloseReason:FrostWire.Libtorrent.Alerts.CloseReason",
					"com/frostwire/jlibtorrent/alerts/DhtAnnounceAlert:FrostWire.Libtorrent.Alerts.DhtAnnounceAlert",
					"com/frostwire/jlibtorrent/alerts/DhtBootstrapAlert:FrostWire.Libtorrent.Alerts.DhtBootstrapAlert",
					"com/frostwire/jlibtorrent/alerts/DhtDirectResponseAlert:FrostWire.Libtorrent.Alerts.DhtDirectResponseAlert",
					"com/frostwire/jlibtorrent/alerts/DhtErrorAlert:FrostWire.Libtorrent.Alerts.DhtErrorAlert",
					"com/frostwire/jlibtorrent/alerts/DhtGetPeersAlert:FrostWire.Libtorrent.Alerts.DhtGetPeersAlert",
					"com/frostwire/jlibtorrent/alerts/DhtGetPeersReplyAlert:FrostWire.Libtorrent.Alerts.DhtGetPeersReplyAlert",
					"com/frostwire/jlibtorrent/alerts/DhtImmutableItemAlert:FrostWire.Libtorrent.Alerts.DhtImmutableItemAlert",
					"com/frostwire/jlibtorrent/alerts/DhtLiveNodesAlert:FrostWire.Libtorrent.Alerts.DhtLiveNodesAlert",
					"com/frostwire/jlibtorrent/alerts/DhtLogAlert:FrostWire.Libtorrent.Alerts.DhtLogAlert",
					"com/frostwire/jlibtorrent/alerts/DhtLogAlert$DhtModule:FrostWire.Libtorrent.Alerts.DhtLogAlert/DhtModule",
					"com/frostwire/jlibtorrent/alerts/DhtMutableItemAlert:FrostWire.Libtorrent.Alerts.DhtMutableItemAlert",
					"com/frostwire/jlibtorrent/alerts/DhtOutgoingGetPeersAlert:FrostWire.Libtorrent.Alerts.DhtOutgoingGetPeersAlert",
					"com/frostwire/jlibtorrent/alerts/DhtPktAlert:FrostWire.Libtorrent.Alerts.DhtPktAlert",
					"com/frostwire/jlibtorrent/alerts/DhtPktAlert$Direction:FrostWire.Libtorrent.Alerts.DhtPktAlert/Direction",
					"com/frostwire/jlibtorrent/alerts/DhtPutAlert:FrostWire.Libtorrent.Alerts.DhtPutAlert",
					"com/frostwire/jlibtorrent/alerts/DhtReplyAlert:FrostWire.Libtorrent.Alerts.DhtReplyAlert",
					"com/frostwire/jlibtorrent/alerts/DhtSampleInfohashesAlert:FrostWire.Libtorrent.Alerts.DhtSampleInfohashesAlert",
					"com/frostwire/jlibtorrent/alerts/DhtStatsAlert:FrostWire.Libtorrent.Alerts.DhtStatsAlert",
					"com/frostwire/jlibtorrent/alerts/ExternalIpAlert:FrostWire.Libtorrent.Alerts.ExternalIpAlert",
					"com/frostwire/jlibtorrent/alerts/FastresumeRejectedAlert:FrostWire.Libtorrent.Alerts.FastresumeRejectedAlert",
					"com/frostwire/jlibtorrent/alerts/FileCompletedAlert:FrostWire.Libtorrent.Alerts.FileCompletedAlert",
					"com/frostwire/jlibtorrent/alerts/FileErrorAlert:FrostWire.Libtorrent.Alerts.FileErrorAlert",
					"com/frostwire/jlibtorrent/alerts/FileRenamedAlert:FrostWire.Libtorrent.Alerts.FileRenamedAlert",
					"com/frostwire/jlibtorrent/alerts/FileRenameFailedAlert:FrostWire.Libtorrent.Alerts.FileRenameFailedAlert",
					"com/frostwire/jlibtorrent/alerts/HashFailedAlert:FrostWire.Libtorrent.Alerts.HashFailedAlert",
					"com/frostwire/jlibtorrent/alerts/I2pAlert:FrostWire.Libtorrent.Alerts.I2pAlert",
					"com/frostwire/jlibtorrent/alerts/IncomingConnectionAlert:FrostWire.Libtorrent.Alerts.IncomingConnectionAlert",
					"com/frostwire/jlibtorrent/alerts/IncomingConnectionAlert$SocketType:FrostWire.Libtorrent.Alerts.IncomingConnectionAlert/SocketType",
					"com/frostwire/jlibtorrent/alerts/IncomingRequestAlert:FrostWire.Libtorrent.Alerts.IncomingRequestAlert",
					"com/frostwire/jlibtorrent/alerts/InvalidRequestAlert:FrostWire.Libtorrent.Alerts.InvalidRequestAlert",
					"com/frostwire/jlibtorrent/alerts/ListenFailedAlert:FrostWire.Libtorrent.Alerts.ListenFailedAlert",
					"com/frostwire/jlibtorrent/alerts/ListenSucceededAlert:FrostWire.Libtorrent.Alerts.ListenSucceededAlert",
					"com/frostwire/jlibtorrent/alerts/LogAlert:FrostWire.Libtorrent.Alerts.LogAlert",
					"com/frostwire/jlibtorrent/alerts/LsdErrorAlert:FrostWire.Libtorrent.Alerts.LsdErrorAlert",
					"com/frostwire/jlibtorrent/alerts/LsdPeerAlert:FrostWire.Libtorrent.Alerts.LsdPeerAlert",
					"com/frostwire/jlibtorrent/alerts/MetadataFailedAlert:FrostWire.Libtorrent.Alerts.MetadataFailedAlert",
					"com/frostwire/jlibtorrent/alerts/MetadataReceivedAlert:FrostWire.Libtorrent.Alerts.MetadataReceivedAlert",
					"com/frostwire/jlibtorrent/alerts/PeerAlert:FrostWire.Libtorrent.Alerts.PeerAlert",
					"com/frostwire/jlibtorrent/alerts/PeerBanAlert:FrostWire.Libtorrent.Alerts.PeerBanAlert",
					"com/frostwire/jlibtorrent/alerts/PeerBlockedAlert:FrostWire.Libtorrent.Alerts.PeerBlockedAlert",
					"com/frostwire/jlibtorrent/alerts/PeerBlockedAlert$Reason:FrostWire.Libtorrent.Alerts.PeerBlockedAlert/Reason",
					"com/frostwire/jlibtorrent/alerts/PeerConnectAlert:FrostWire.Libtorrent.Alerts.PeerConnectAlert",
					"com/frostwire/jlibtorrent/alerts/PeerDisconnectedAlert:FrostWire.Libtorrent.Alerts.PeerDisconnectedAlert",
					"com/frostwire/jlibtorrent/alerts/PeerErrorAlert:FrostWire.Libtorrent.Alerts.PeerErrorAlert",
					"com/frostwire/jlibtorrent/alerts/PeerLogAlert:FrostWire.Libtorrent.Alerts.PeerLogAlert",
					"com/frostwire/jlibtorrent/alerts/PeerLogAlert$Direction:FrostWire.Libtorrent.Alerts.PeerLogAlert/Direction",
					"com/frostwire/jlibtorrent/alerts/PeerSnubbedAlert:FrostWire.Libtorrent.Alerts.PeerSnubbedAlert",
					"com/frostwire/jlibtorrent/alerts/PeerUnsnubbedAlert:FrostWire.Libtorrent.Alerts.PeerUnsnubbedAlert",
					"com/frostwire/jlibtorrent/alerts/PerformanceAlert:FrostWire.Libtorrent.Alerts.PerformanceAlert",
					"com/frostwire/jlibtorrent/alerts/PerformanceAlert$PerformanceWarning:FrostWire.Libtorrent.Alerts.PerformanceAlert/PerformanceWarning",
					"com/frostwire/jlibtorrent/alerts/PickerLogAlert:FrostWire.Libtorrent.Alerts.PickerLogAlert",
					"com/frostwire/jlibtorrent/alerts/PieceFinishedAlert:FrostWire.Libtorrent.Alerts.PieceFinishedAlert",
					"com/frostwire/jlibtorrent/alerts/PortmapAlert:FrostWire.Libtorrent.Alerts.PortmapAlert",
					"com/frostwire/jlibtorrent/alerts/PortmapErrorAlert:FrostWire.Libtorrent.Alerts.PortmapErrorAlert",
					"com/frostwire/jlibtorrent/alerts/PortmapLogAlert:FrostWire.Libtorrent.Alerts.PortmapLogAlert",
					"com/frostwire/jlibtorrent/alerts/ReadPieceAlert:FrostWire.Libtorrent.Alerts.ReadPieceAlert",
					"com/frostwire/jlibtorrent/alerts/RequestDroppedAlert:FrostWire.Libtorrent.Alerts.RequestDroppedAlert",
					"com/frostwire/jlibtorrent/alerts/SaveResumeDataAlert:FrostWire.Libtorrent.Alerts.SaveResumeDataAlert",
					"com/frostwire/jlibtorrent/alerts/SaveResumeDataFailedAlert:FrostWire.Libtorrent.Alerts.SaveResumeDataFailedAlert",
					"com/frostwire/jlibtorrent/alerts/ScrapeFailedAlert:FrostWire.Libtorrent.Alerts.ScrapeFailedAlert",
					"com/frostwire/jlibtorrent/alerts/ScrapeReplyAlert:FrostWire.Libtorrent.Alerts.ScrapeReplyAlert",
					"com/frostwire/jlibtorrent/alerts/SessionErrorAlert:FrostWire.Libtorrent.Alerts.SessionErrorAlert",
					"com/frostwire/jlibtorrent/alerts/SessionStatsAlert:FrostWire.Libtorrent.Alerts.SessionStatsAlert",
					"com/frostwire/jlibtorrent/alerts/SessionStatsHeaderAlert:FrostWire.Libtorrent.Alerts.SessionStatsHeaderAlert",
					"com/frostwire/jlibtorrent/alerts/SocketType:FrostWire.Libtorrent.Alerts.SocketType",
					"com/frostwire/jlibtorrent/alerts/StateChangedAlert:FrostWire.Libtorrent.Alerts.StateChangedAlert",
					"com/frostwire/jlibtorrent/alerts/StateUpdateAlert:FrostWire.Libtorrent.Alerts.StateUpdateAlert",
					"com/frostwire/jlibtorrent/alerts/StatsAlert:FrostWire.Libtorrent.Alerts.StatsAlert",
					"com/frostwire/jlibtorrent/alerts/StatsAlert$StatsChannel:FrostWire.Libtorrent.Alerts.StatsAlert/StatsChannel",
					"com/frostwire/jlibtorrent/alerts/StorageMovedAlert:FrostWire.Libtorrent.Alerts.StorageMovedAlert",
					"com/frostwire/jlibtorrent/alerts/StorageMovedFailedAlert:FrostWire.Libtorrent.Alerts.StorageMovedFailedAlert",
					"com/frostwire/jlibtorrent/alerts/TorrentAlert:FrostWire.Libtorrent.Alerts.TorrentAlert",
					"com/frostwire/jlibtorrent/alerts/TorrentCheckedAlert:FrostWire.Libtorrent.Alerts.TorrentCheckedAlert",
					"com/frostwire/jlibtorrent/alerts/TorrentDeletedAlert:FrostWire.Libtorrent.Alerts.TorrentDeletedAlert",
					"com/frostwire/jlibtorrent/alerts/TorrentDeleteFailedAlert:FrostWire.Libtorrent.Alerts.TorrentDeleteFailedAlert",
					"com/frostwire/jlibtorrent/alerts/TorrentErrorAlert:FrostWire.Libtorrent.Alerts.TorrentErrorAlert",
					"com/frostwire/jlibtorrent/alerts/TorrentFinishedAlert:FrostWire.Libtorrent.Alerts.TorrentFinishedAlert",
					"com/frostwire/jlibtorrent/alerts/TorrentLogAlert:FrostWire.Libtorrent.Alerts.TorrentLogAlert",
					"com/frostwire/jlibtorrent/alerts/TorrentNeedCertAlert:FrostWire.Libtorrent.Alerts.TorrentNeedCertAlert",
					"com/frostwire/jlibtorrent/alerts/TorrentPausedAlert:FrostWire.Libtorrent.Alerts.TorrentPausedAlert",
					"com/frostwire/jlibtorrent/alerts/TorrentRemovedAlert:FrostWire.Libtorrent.Alerts.TorrentRemovedAlert",
					"com/frostwire/jlibtorrent/alerts/TorrentResumedAlert:FrostWire.Libtorrent.Alerts.TorrentResumedAlert",
					"com/frostwire/jlibtorrent/alerts/TrackerAlert:FrostWire.Libtorrent.Alerts.TrackerAlert",
					"com/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert:FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert",
					"com/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert$TrackerAnnounceEvent:FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert/TrackerAnnounceEvent",
					"com/frostwire/jlibtorrent/alerts/TrackerErrorAlert:FrostWire.Libtorrent.Alerts.TrackerErrorAlert",
					"com/frostwire/jlibtorrent/alerts/TrackeridAlert:FrostWire.Libtorrent.Alerts.TrackeridAlert",
					"com/frostwire/jlibtorrent/alerts/TrackerReplyAlert:FrostWire.Libtorrent.Alerts.TrackerReplyAlert",
					"com/frostwire/jlibtorrent/alerts/TrackerWarningAlert:FrostWire.Libtorrent.Alerts.TrackerWarningAlert",
					"com/frostwire/jlibtorrent/alerts/UdpErrorAlert:FrostWire.Libtorrent.Alerts.UdpErrorAlert",
					"com/frostwire/jlibtorrent/alerts/UnwantedBlockAlert:FrostWire.Libtorrent.Alerts.UnwantedBlockAlert",
					"com/frostwire/jlibtorrent/alerts/UrlSeedAlert:FrostWire.Libtorrent.Alerts.UrlSeedAlert",
				};
			}

			return Lookup (package_com_frostwire_jlibtorrent_alerts_mappings, klass);
		}

		static string[] package_com_frostwire_jlibtorrent_swig_mappings;
		static Type lookup_com_frostwire_jlibtorrent_swig_package (string klass)
		{
			if (package_com_frostwire_jlibtorrent_swig_mappings == null) {
				package_com_frostwire_jlibtorrent_swig_mappings = new string[]{
					"com/frostwire/jlibtorrent/swig/add_files_listener:FrostWire.Libtorrent.Swig.Add_files_listener",
					"com/frostwire/jlibtorrent/swig/add_piece_flags_t:FrostWire.Libtorrent.Swig.Add_piece_flags_t",
					"com/frostwire/jlibtorrent/swig/add_torrent_alert:FrostWire.Libtorrent.Swig.Add_torrent_alert",
					"com/frostwire/jlibtorrent/swig/add_torrent_params:FrostWire.Libtorrent.Swig.Add_torrent_params",
					"com/frostwire/jlibtorrent/swig/address:FrostWire.Libtorrent.Swig.Address",
					"com/frostwire/jlibtorrent/swig/address_sha1_hash_pair:FrostWire.Libtorrent.Swig.Address_sha1_hash_pair",
					"com/frostwire/jlibtorrent/swig/address_sha1_hash_pair_vector:FrostWire.Libtorrent.Swig.Address_sha1_hash_pair_vector",
					"com/frostwire/jlibtorrent/swig/alert:FrostWire.Libtorrent.Swig.Alert",
					"com/frostwire/jlibtorrent/swig/alert_category_t:FrostWire.Libtorrent.Swig.Alert_category_t",
					"com/frostwire/jlibtorrent/swig/alert_notify_callback:FrostWire.Libtorrent.Swig.Alert_notify_callback",
					"com/frostwire/jlibtorrent/swig/alert_priority:FrostWire.Libtorrent.Swig.Alert_priority",
					"com/frostwire/jlibtorrent/swig/alert_ptr_vector:FrostWire.Libtorrent.Swig.Alert_ptr_vector",
					"com/frostwire/jlibtorrent/swig/alerts_dropped_alert:FrostWire.Libtorrent.Swig.Alerts_dropped_alert",
					"com/frostwire/jlibtorrent/swig/announce_endpoint:FrostWire.Libtorrent.Swig.Announce_endpoint",
					"com/frostwire/jlibtorrent/swig/announce_endpoint_vector:FrostWire.Libtorrent.Swig.Announce_endpoint_vector",
					"com/frostwire/jlibtorrent/swig/announce_entry:FrostWire.Libtorrent.Swig.Announce_entry",
					"com/frostwire/jlibtorrent/swig/announce_entry$tracker_source:FrostWire.Libtorrent.Swig.Announce_entry/Tracker_source",
					"com/frostwire/jlibtorrent/swig/announce_entry_vector:FrostWire.Libtorrent.Swig.Announce_entry_vector",
					"com/frostwire/jlibtorrent/swig/bandwidth_state_flags_t:FrostWire.Libtorrent.Swig.Bandwidth_state_flags_t",
					"com/frostwire/jlibtorrent/swig/bdecode_errors:FrostWire.Libtorrent.Swig.Bdecode_errors",
					"com/frostwire/jlibtorrent/swig/bdecode_node:FrostWire.Libtorrent.Swig.Bdecode_node",
					"com/frostwire/jlibtorrent/swig/bdecode_node$type_t:FrostWire.Libtorrent.Swig.Bdecode_node/Type_t",
					"com/frostwire/jlibtorrent/swig/bitset_96:FrostWire.Libtorrent.Swig.Bitset_96",
					"com/frostwire/jlibtorrent/swig/block_downloading_alert:FrostWire.Libtorrent.Swig.Block_downloading_alert",
					"com/frostwire/jlibtorrent/swig/block_finished_alert:FrostWire.Libtorrent.Swig.Block_finished_alert",
					"com/frostwire/jlibtorrent/swig/block_info:FrostWire.Libtorrent.Swig.Block_info",
					"com/frostwire/jlibtorrent/swig/block_info$block_state_t:FrostWire.Libtorrent.Swig.Block_info/Block_state_t",
					"com/frostwire/jlibtorrent/swig/block_info_vector:FrostWire.Libtorrent.Swig.Block_info_vector",
					"com/frostwire/jlibtorrent/swig/block_timeout_alert:FrostWire.Libtorrent.Swig.Block_timeout_alert",
					"com/frostwire/jlibtorrent/swig/block_uploaded_alert:FrostWire.Libtorrent.Swig.Block_uploaded_alert",
					"com/frostwire/jlibtorrent/swig/bloom_filter_128:FrostWire.Libtorrent.Swig.Bloom_filter_128",
					"com/frostwire/jlibtorrent/swig/bloom_filter_256:FrostWire.Libtorrent.Swig.Bloom_filter_256",
					"com/frostwire/jlibtorrent/swig/bt_peer_connection_handle:FrostWire.Libtorrent.Swig.Bt_peer_connection_handle",
					"com/frostwire/jlibtorrent/swig/byte_const_span:FrostWire.Libtorrent.Swig.Byte_const_span",
					"com/frostwire/jlibtorrent/swig/byte_span:FrostWire.Libtorrent.Swig.Byte_span",
					"com/frostwire/jlibtorrent/swig/byte_vector:FrostWire.Libtorrent.Swig.Byte_vector",
					"com/frostwire/jlibtorrent/swig/byte_vectors_pair:FrostWire.Libtorrent.Swig.Byte_vectors_pair",
					"com/frostwire/jlibtorrent/swig/cache_flushed_alert:FrostWire.Libtorrent.Swig.Cache_flushed_alert",
					"com/frostwire/jlibtorrent/swig/close_reason_t:FrostWire.Libtorrent.Swig.Close_reason_t",
					"com/frostwire/jlibtorrent/swig/connection_type:FrostWire.Libtorrent.Swig.Connection_type",
					"com/frostwire/jlibtorrent/swig/create_flags_t:FrostWire.Libtorrent.Swig.Create_flags_t",
					"com/frostwire/jlibtorrent/swig/create_torrent:FrostWire.Libtorrent.Swig.Create_torrent",
					"com/frostwire/jlibtorrent/swig/deadline_flags_t:FrostWire.Libtorrent.Swig.Deadline_flags_t",
					"com/frostwire/jlibtorrent/swig/dht_announce_alert:FrostWire.Libtorrent.Swig.Dht_announce_alert",
					"com/frostwire/jlibtorrent/swig/dht_bootstrap_alert:FrostWire.Libtorrent.Swig.Dht_bootstrap_alert",
					"com/frostwire/jlibtorrent/swig/dht_direct_response_alert:FrostWire.Libtorrent.Swig.Dht_direct_response_alert",
					"com/frostwire/jlibtorrent/swig/dht_error_alert:FrostWire.Libtorrent.Swig.Dht_error_alert",
					"com/frostwire/jlibtorrent/swig/dht_get_peers_alert:FrostWire.Libtorrent.Swig.Dht_get_peers_alert",
					"com/frostwire/jlibtorrent/swig/dht_get_peers_reply_alert:FrostWire.Libtorrent.Swig.Dht_get_peers_reply_alert",
					"com/frostwire/jlibtorrent/swig/dht_immutable_item_alert:FrostWire.Libtorrent.Swig.Dht_immutable_item_alert",
					"com/frostwire/jlibtorrent/swig/dht_live_nodes_alert:FrostWire.Libtorrent.Swig.Dht_live_nodes_alert",
					"com/frostwire/jlibtorrent/swig/dht_log_alert:FrostWire.Libtorrent.Swig.Dht_log_alert",
					"com/frostwire/jlibtorrent/swig/dht_log_alert$dht_module_t:FrostWire.Libtorrent.Swig.Dht_log_alert/Dht_module_t",
					"com/frostwire/jlibtorrent/swig/dht_lookup:FrostWire.Libtorrent.Swig.Dht_lookup",
					"com/frostwire/jlibtorrent/swig/dht_lookup_vector:FrostWire.Libtorrent.Swig.Dht_lookup_vector",
					"com/frostwire/jlibtorrent/swig/dht_mutable_item_alert:FrostWire.Libtorrent.Swig.Dht_mutable_item_alert",
					"com/frostwire/jlibtorrent/swig/dht_outgoing_get_peers_alert:FrostWire.Libtorrent.Swig.Dht_outgoing_get_peers_alert",
					"com/frostwire/jlibtorrent/swig/dht_pkt_alert:FrostWire.Libtorrent.Swig.Dht_pkt_alert",
					"com/frostwire/jlibtorrent/swig/dht_pkt_alert$direction_t:FrostWire.Libtorrent.Swig.Dht_pkt_alert/Direction_t",
					"com/frostwire/jlibtorrent/swig/dht_put_alert:FrostWire.Libtorrent.Swig.Dht_put_alert",
					"com/frostwire/jlibtorrent/swig/dht_reply_alert:FrostWire.Libtorrent.Swig.Dht_reply_alert",
					"com/frostwire/jlibtorrent/swig/dht_routing_bucket:FrostWire.Libtorrent.Swig.Dht_routing_bucket",
					"com/frostwire/jlibtorrent/swig/dht_routing_bucket_vector:FrostWire.Libtorrent.Swig.Dht_routing_bucket_vector",
					"com/frostwire/jlibtorrent/swig/dht_sample_infohashes_alert:FrostWire.Libtorrent.Swig.Dht_sample_infohashes_alert",
					"com/frostwire/jlibtorrent/swig/dht_settings:FrostWire.Libtorrent.Swig.Dht_settings",
					"com/frostwire/jlibtorrent/swig/dht_state:FrostWire.Libtorrent.Swig.Dht_state",
					"com/frostwire/jlibtorrent/swig/dht_stats_alert:FrostWire.Libtorrent.Swig.Dht_stats_alert",
					"com/frostwire/jlibtorrent/swig/entry:FrostWire.Libtorrent.Swig.Entry",
					"com/frostwire/jlibtorrent/swig/entry$data_type:FrostWire.Libtorrent.Swig.Entry/Data_type",
					"com/frostwire/jlibtorrent/swig/entry_vector:FrostWire.Libtorrent.Swig.Entry_vector",
					"com/frostwire/jlibtorrent/swig/errc_t:FrostWire.Libtorrent.Swig.Errc_t",
					"com/frostwire/jlibtorrent/swig/error_code:FrostWire.Libtorrent.Swig.Error_code",
					"com/frostwire/jlibtorrent/swig/external_ip_alert:FrostWire.Libtorrent.Swig.External_ip_alert",
					"com/frostwire/jlibtorrent/swig/fastresume_rejected_alert:FrostWire.Libtorrent.Swig.Fastresume_rejected_alert",
					"com/frostwire/jlibtorrent/swig/file_completed_alert:FrostWire.Libtorrent.Swig.File_completed_alert",
					"com/frostwire/jlibtorrent/swig/file_error_alert:FrostWire.Libtorrent.Swig.File_error_alert",
					"com/frostwire/jlibtorrent/swig/file_flags_t:FrostWire.Libtorrent.Swig.File_flags_t",
					"com/frostwire/jlibtorrent/swig/file_index_string_map:FrostWire.Libtorrent.Swig.File_index_string_map",
					"com/frostwire/jlibtorrent/swig/file_index_vector:FrostWire.Libtorrent.Swig.File_index_vector",
					"com/frostwire/jlibtorrent/swig/file_rename_failed_alert:FrostWire.Libtorrent.Swig.File_rename_failed_alert",
					"com/frostwire/jlibtorrent/swig/file_renamed_alert:FrostWire.Libtorrent.Swig.File_renamed_alert",
					"com/frostwire/jlibtorrent/swig/file_slice:FrostWire.Libtorrent.Swig.File_slice",
					"com/frostwire/jlibtorrent/swig/file_slice_vector:FrostWire.Libtorrent.Swig.File_slice_vector",
					"com/frostwire/jlibtorrent/swig/file_storage:FrostWire.Libtorrent.Swig.File_storage",
					"com/frostwire/jlibtorrent/swig/hash_failed_alert:FrostWire.Libtorrent.Swig.Hash_failed_alert",
					"com/frostwire/jlibtorrent/swig/http_errors:FrostWire.Libtorrent.Swig.Http_errors",
					"com/frostwire/jlibtorrent/swig/i2p_alert:FrostWire.Libtorrent.Swig.I2p_alert",
					"com/frostwire/jlibtorrent/swig/incoming_connection_alert:FrostWire.Libtorrent.Swig.Incoming_connection_alert",
					"com/frostwire/jlibtorrent/swig/incoming_request_alert:FrostWire.Libtorrent.Swig.Incoming_request_alert",
					"com/frostwire/jlibtorrent/swig/int_vector:FrostWire.Libtorrent.Swig.Int_vector",
					"com/frostwire/jlibtorrent/swig/int64_vector:FrostWire.Libtorrent.Swig.Int64_vector",
					"com/frostwire/jlibtorrent/swig/invalid_request_alert:FrostWire.Libtorrent.Swig.Invalid_request_alert",
					"com/frostwire/jlibtorrent/swig/ip_filter:FrostWire.Libtorrent.Swig.Ip_filter",
					"com/frostwire/jlibtorrent/swig/ip_filter$access_flags:FrostWire.Libtorrent.Swig.Ip_filter/Access_flags",
					"com/frostwire/jlibtorrent/swig/ip_interface:FrostWire.Libtorrent.Swig.Ip_interface",
					"com/frostwire/jlibtorrent/swig/ip_interface_vector:FrostWire.Libtorrent.Swig.Ip_interface_vector",
					"com/frostwire/jlibtorrent/swig/ip_route:FrostWire.Libtorrent.Swig.Ip_route",
					"com/frostwire/jlibtorrent/swig/ip_route_vector:FrostWire.Libtorrent.Swig.Ip_route_vector",
					"com/frostwire/jlibtorrent/swig/libtorrent:FrostWire.Libtorrent.Swig.Libtorrent",
					"com/frostwire/jlibtorrent/swig/libtorrent_errors:FrostWire.Libtorrent.Swig.Libtorrent_errors",
					"com/frostwire/jlibtorrent/swig/libtorrent_jni:FrostWire.Libtorrent.Swig.Libtorrent_jni",
					"com/frostwire/jlibtorrent/swig/listen_failed_alert:FrostWire.Libtorrent.Swig.Listen_failed_alert",
					"com/frostwire/jlibtorrent/swig/listen_succeeded_alert:FrostWire.Libtorrent.Swig.Listen_succeeded_alert",
					"com/frostwire/jlibtorrent/swig/log_alert:FrostWire.Libtorrent.Swig.Log_alert",
					"com/frostwire/jlibtorrent/swig/lsd_error_alert:FrostWire.Libtorrent.Swig.Lsd_error_alert",
					"com/frostwire/jlibtorrent/swig/lsd_peer_alert:FrostWire.Libtorrent.Swig.Lsd_peer_alert",
					"com/frostwire/jlibtorrent/swig/metadata_failed_alert:FrostWire.Libtorrent.Swig.Metadata_failed_alert",
					"com/frostwire/jlibtorrent/swig/metadata_received_alert:FrostWire.Libtorrent.Swig.Metadata_received_alert",
					"com/frostwire/jlibtorrent/swig/metric_type_t:FrostWire.Libtorrent.Swig.Metric_type_t",
					"com/frostwire/jlibtorrent/swig/move_flags_t:FrostWire.Libtorrent.Swig.Move_flags_t",
					"com/frostwire/jlibtorrent/swig/operation_t:FrostWire.Libtorrent.Swig.Operation_t",
					"com/frostwire/jlibtorrent/swig/partial_piece_info:FrostWire.Libtorrent.Swig.Partial_piece_info",
					"com/frostwire/jlibtorrent/swig/partial_piece_info_vector:FrostWire.Libtorrent.Swig.Partial_piece_info_vector",
					"com/frostwire/jlibtorrent/swig/pause_flags_t:FrostWire.Libtorrent.Swig.Pause_flags_t",
					"com/frostwire/jlibtorrent/swig/peer_alert:FrostWire.Libtorrent.Swig.Peer_alert",
					"com/frostwire/jlibtorrent/swig/peer_ban_alert:FrostWire.Libtorrent.Swig.Peer_ban_alert",
					"com/frostwire/jlibtorrent/swig/peer_blocked_alert:FrostWire.Libtorrent.Swig.Peer_blocked_alert",
					"com/frostwire/jlibtorrent/swig/peer_blocked_alert$reason_t:FrostWire.Libtorrent.Swig.Peer_blocked_alert/Reason_t",
					"com/frostwire/jlibtorrent/swig/peer_class_info:FrostWire.Libtorrent.Swig.Peer_class_info",
					"com/frostwire/jlibtorrent/swig/peer_class_type_filter:FrostWire.Libtorrent.Swig.Peer_class_type_filter",
					"com/frostwire/jlibtorrent/swig/peer_class_type_filter$socket_type_t:FrostWire.Libtorrent.Swig.Peer_class_type_filter/Socket_type_t",
					"com/frostwire/jlibtorrent/swig/peer_connect_alert:FrostWire.Libtorrent.Swig.Peer_connect_alert",
					"com/frostwire/jlibtorrent/swig/peer_connection_handle:FrostWire.Libtorrent.Swig.Peer_connection_handle",
					"com/frostwire/jlibtorrent/swig/peer_disconnected_alert:FrostWire.Libtorrent.Swig.Peer_disconnected_alert",
					"com/frostwire/jlibtorrent/swig/peer_error_alert:FrostWire.Libtorrent.Swig.Peer_error_alert",
					"com/frostwire/jlibtorrent/swig/peer_flags_t:FrostWire.Libtorrent.Swig.Peer_flags_t",
					"com/frostwire/jlibtorrent/swig/peer_info:FrostWire.Libtorrent.Swig.Peer_info",
					"com/frostwire/jlibtorrent/swig/peer_info$connection_type_t:FrostWire.Libtorrent.Swig.Peer_info/Connection_type_t",
					"com/frostwire/jlibtorrent/swig/peer_info_vector:FrostWire.Libtorrent.Swig.Peer_info_vector",
					"com/frostwire/jlibtorrent/swig/peer_log_alert:FrostWire.Libtorrent.Swig.Peer_log_alert",
					"com/frostwire/jlibtorrent/swig/peer_log_alert$direction_t:FrostWire.Libtorrent.Swig.Peer_log_alert/Direction_t",
					"com/frostwire/jlibtorrent/swig/peer_request:FrostWire.Libtorrent.Swig.Peer_request",
					"com/frostwire/jlibtorrent/swig/peer_snubbed_alert:FrostWire.Libtorrent.Swig.Peer_snubbed_alert",
					"com/frostwire/jlibtorrent/swig/peer_source_flags_t:FrostWire.Libtorrent.Swig.Peer_source_flags_t",
					"com/frostwire/jlibtorrent/swig/peer_unsnubbed_alert:FrostWire.Libtorrent.Swig.Peer_unsnubbed_alert",
					"com/frostwire/jlibtorrent/swig/performance_alert:FrostWire.Libtorrent.Swig.Performance_alert",
					"com/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t:FrostWire.Libtorrent.Swig.Performance_alert/Performance_warning_t",
					"com/frostwire/jlibtorrent/swig/pex_flags_t:FrostWire.Libtorrent.Swig.Pex_flags_t",
					"com/frostwire/jlibtorrent/swig/picker_flags_t:FrostWire.Libtorrent.Swig.Picker_flags_t",
					"com/frostwire/jlibtorrent/swig/picker_log_alert:FrostWire.Libtorrent.Swig.Picker_log_alert",
					"com/frostwire/jlibtorrent/swig/piece_finished_alert:FrostWire.Libtorrent.Swig.Piece_finished_alert",
					"com/frostwire/jlibtorrent/swig/piece_index_bitfield:FrostWire.Libtorrent.Swig.Piece_index_bitfield",
					"com/frostwire/jlibtorrent/swig/piece_index_int_pair:FrostWire.Libtorrent.Swig.Piece_index_int_pair",
					"com/frostwire/jlibtorrent/swig/piece_index_int_pair_vector:FrostWire.Libtorrent.Swig.Piece_index_int_pair_vector",
					"com/frostwire/jlibtorrent/swig/piece_index_vector:FrostWire.Libtorrent.Swig.Piece_index_vector",
					"com/frostwire/jlibtorrent/swig/port_filter:FrostWire.Libtorrent.Swig.Port_filter",
					"com/frostwire/jlibtorrent/swig/port_filter$access_flags:FrostWire.Libtorrent.Swig.Port_filter/Access_flags",
					"com/frostwire/jlibtorrent/swig/port_mapping_t_vector:FrostWire.Libtorrent.Swig.Port_mapping_t_vector",
					"com/frostwire/jlibtorrent/swig/portmap_alert:FrostWire.Libtorrent.Swig.Portmap_alert",
					"com/frostwire/jlibtorrent/swig/portmap_error_alert:FrostWire.Libtorrent.Swig.Portmap_error_alert",
					"com/frostwire/jlibtorrent/swig/portmap_log_alert:FrostWire.Libtorrent.Swig.Portmap_log_alert",
					"com/frostwire/jlibtorrent/swig/portmap_protocol:FrostWire.Libtorrent.Swig.Portmap_protocol",
					"com/frostwire/jlibtorrent/swig/portmap_transport:FrostWire.Libtorrent.Swig.Portmap_transport",
					"com/frostwire/jlibtorrent/swig/posix_stat_t:FrostWire.Libtorrent.Swig.Posix_stat_t",
					"com/frostwire/jlibtorrent/swig/posix_wrapper:FrostWire.Libtorrent.Swig.Posix_wrapper",
					"com/frostwire/jlibtorrent/swig/read_piece_alert:FrostWire.Libtorrent.Swig.Read_piece_alert",
					"com/frostwire/jlibtorrent/swig/reannounce_flags_t:FrostWire.Libtorrent.Swig.Reannounce_flags_t",
					"com/frostwire/jlibtorrent/swig/remove_flags_t:FrostWire.Libtorrent.Swig.Remove_flags_t",
					"com/frostwire/jlibtorrent/swig/reopen_network_flags_t:FrostWire.Libtorrent.Swig.Reopen_network_flags_t",
					"com/frostwire/jlibtorrent/swig/request_dropped_alert:FrostWire.Libtorrent.Swig.Request_dropped_alert",
					"com/frostwire/jlibtorrent/swig/resume_data_flags_t:FrostWire.Libtorrent.Swig.Resume_data_flags_t",
					"com/frostwire/jlibtorrent/swig/save_resume_data_alert:FrostWire.Libtorrent.Swig.Save_resume_data_alert",
					"com/frostwire/jlibtorrent/swig/save_resume_data_failed_alert:FrostWire.Libtorrent.Swig.Save_resume_data_failed_alert",
					"com/frostwire/jlibtorrent/swig/save_state_flags_t:FrostWire.Libtorrent.Swig.Save_state_flags_t",
					"com/frostwire/jlibtorrent/swig/scrape_failed_alert:FrostWire.Libtorrent.Swig.Scrape_failed_alert",
					"com/frostwire/jlibtorrent/swig/scrape_reply_alert:FrostWire.Libtorrent.Swig.Scrape_reply_alert",
					"com/frostwire/jlibtorrent/swig/session:FrostWire.Libtorrent.Swig.Session",
					"com/frostwire/jlibtorrent/swig/session_error_alert:FrostWire.Libtorrent.Swig.Session_error_alert",
					"com/frostwire/jlibtorrent/swig/session_flags_t:FrostWire.Libtorrent.Swig.Session_flags_t",
					"com/frostwire/jlibtorrent/swig/session_handle:FrostWire.Libtorrent.Swig.Session_handle",
					"com/frostwire/jlibtorrent/swig/session_params:FrostWire.Libtorrent.Swig.Session_params",
					"com/frostwire/jlibtorrent/swig/session_proxy:FrostWire.Libtorrent.Swig.Session_proxy",
					"com/frostwire/jlibtorrent/swig/session_stats_alert:FrostWire.Libtorrent.Swig.Session_stats_alert",
					"com/frostwire/jlibtorrent/swig/session_stats_header_alert:FrostWire.Libtorrent.Swig.Session_stats_header_alert",
					"com/frostwire/jlibtorrent/swig/set_piece_hashes_listener:FrostWire.Libtorrent.Swig.Set_piece_hashes_listener",
					"com/frostwire/jlibtorrent/swig/settings_pack:FrostWire.Libtorrent.Swig.Settings_pack",
					"com/frostwire/jlibtorrent/swig/settings_pack$bandwidth_mixed_algo_t:FrostWire.Libtorrent.Swig.Settings_pack/Bandwidth_mixed_algo_t",
					"com/frostwire/jlibtorrent/swig/settings_pack$bool_types:FrostWire.Libtorrent.Swig.Settings_pack/Bool_types",
					"com/frostwire/jlibtorrent/swig/settings_pack$choking_algorithm_t:FrostWire.Libtorrent.Swig.Settings_pack/Choking_algorithm_t",
					"com/frostwire/jlibtorrent/swig/settings_pack$enc_level:FrostWire.Libtorrent.Swig.Settings_pack/Enc_level",
					"com/frostwire/jlibtorrent/swig/settings_pack$enc_policy:FrostWire.Libtorrent.Swig.Settings_pack/Enc_policy",
					"com/frostwire/jlibtorrent/swig/settings_pack$int_types:FrostWire.Libtorrent.Swig.Settings_pack/Int_types",
					"com/frostwire/jlibtorrent/swig/settings_pack$io_buffer_mode_t:FrostWire.Libtorrent.Swig.Settings_pack/Io_buffer_mode_t",
					"com/frostwire/jlibtorrent/swig/settings_pack$proxy_type_t:FrostWire.Libtorrent.Swig.Settings_pack/Proxy_type_t",
					"com/frostwire/jlibtorrent/swig/settings_pack$seed_choking_algorithm_t:FrostWire.Libtorrent.Swig.Settings_pack/Seed_choking_algorithm_t",
					"com/frostwire/jlibtorrent/swig/settings_pack$settings_counts_t:FrostWire.Libtorrent.Swig.Settings_pack/Settings_counts_t",
					"com/frostwire/jlibtorrent/swig/settings_pack$string_types:FrostWire.Libtorrent.Swig.Settings_pack/String_types",
					"com/frostwire/jlibtorrent/swig/settings_pack$suggest_mode_t:FrostWire.Libtorrent.Swig.Settings_pack/Suggest_mode_t",
					"com/frostwire/jlibtorrent/swig/settings_pack$type_bases:FrostWire.Libtorrent.Swig.Settings_pack/Type_bases",
					"com/frostwire/jlibtorrent/swig/sha1_hash:FrostWire.Libtorrent.Swig.Sha1_hash",
					"com/frostwire/jlibtorrent/swig/sha1_hash_udp_endpoint_pair:FrostWire.Libtorrent.Swig.Sha1_hash_udp_endpoint_pair",
					"com/frostwire/jlibtorrent/swig/sha1_hash_udp_endpoint_pair_vector:FrostWire.Libtorrent.Swig.Sha1_hash_udp_endpoint_pair_vector",
					"com/frostwire/jlibtorrent/swig/sha1_hash_vector:FrostWire.Libtorrent.Swig.Sha1_hash_vector",
					"com/frostwire/jlibtorrent/swig/socket_type_t:FrostWire.Libtorrent.Swig.Socket_type_t",
					"com/frostwire/jlibtorrent/swig/state_changed_alert:FrostWire.Libtorrent.Swig.State_changed_alert",
					"com/frostwire/jlibtorrent/swig/state_update_alert:FrostWire.Libtorrent.Swig.State_update_alert",
					"com/frostwire/jlibtorrent/swig/stats_alert:FrostWire.Libtorrent.Swig.Stats_alert",
					"com/frostwire/jlibtorrent/swig/stats_alert$stats_channel:FrostWire.Libtorrent.Swig.Stats_alert/Stats_channel",
					"com/frostwire/jlibtorrent/swig/stats_metric:FrostWire.Libtorrent.Swig.Stats_metric",
					"com/frostwire/jlibtorrent/swig/stats_metric_vector:FrostWire.Libtorrent.Swig.Stats_metric_vector",
					"com/frostwire/jlibtorrent/swig/status_flags_t:FrostWire.Libtorrent.Swig.Status_flags_t",
					"com/frostwire/jlibtorrent/swig/storage_mode_t:FrostWire.Libtorrent.Swig.Storage_mode_t",
					"com/frostwire/jlibtorrent/swig/storage_moved_alert:FrostWire.Libtorrent.Swig.Storage_moved_alert",
					"com/frostwire/jlibtorrent/swig/storage_moved_failed_alert:FrostWire.Libtorrent.Swig.Storage_moved_failed_alert",
					"com/frostwire/jlibtorrent/swig/string_entry_map:FrostWire.Libtorrent.Swig.String_entry_map",
					"com/frostwire/jlibtorrent/swig/string_int_pair:FrostWire.Libtorrent.Swig.String_int_pair",
					"com/frostwire/jlibtorrent/swig/string_int_pair_vector:FrostWire.Libtorrent.Swig.String_int_pair_vector",
					"com/frostwire/jlibtorrent/swig/string_long_map:FrostWire.Libtorrent.Swig.String_long_map",
					"com/frostwire/jlibtorrent/swig/string_string_pair:FrostWire.Libtorrent.Swig.String_string_pair",
					"com/frostwire/jlibtorrent/swig/string_string_pair_vector:FrostWire.Libtorrent.Swig.String_string_pair_vector",
					"com/frostwire/jlibtorrent/swig/string_vector:FrostWire.Libtorrent.Swig.String_vector",
					"com/frostwire/jlibtorrent/swig/string_view:FrostWire.Libtorrent.Swig.String_view",
					"com/frostwire/jlibtorrent/swig/string_view_bdecode_node_pair:FrostWire.Libtorrent.Swig.String_view_bdecode_node_pair",
					"com/frostwire/jlibtorrent/swig/swig_plugin:FrostWire.Libtorrent.Swig.Swig_plugin",
					"com/frostwire/jlibtorrent/swig/tcp_endpoint:FrostWire.Libtorrent.Swig.Tcp_endpoint",
					"com/frostwire/jlibtorrent/swig/tcp_endpoint_vector:FrostWire.Libtorrent.Swig.Tcp_endpoint_vector",
					"com/frostwire/jlibtorrent/swig/torrent_alert:FrostWire.Libtorrent.Swig.Torrent_alert",
					"com/frostwire/jlibtorrent/swig/torrent_checked_alert:FrostWire.Libtorrent.Swig.Torrent_checked_alert",
					"com/frostwire/jlibtorrent/swig/torrent_delete_failed_alert:FrostWire.Libtorrent.Swig.Torrent_delete_failed_alert",
					"com/frostwire/jlibtorrent/swig/torrent_deleted_alert:FrostWire.Libtorrent.Swig.Torrent_deleted_alert",
					"com/frostwire/jlibtorrent/swig/torrent_error_alert:FrostWire.Libtorrent.Swig.Torrent_error_alert",
					"com/frostwire/jlibtorrent/swig/torrent_finished_alert:FrostWire.Libtorrent.Swig.Torrent_finished_alert",
					"com/frostwire/jlibtorrent/swig/torrent_flags_t:FrostWire.Libtorrent.Swig.Torrent_flags_t",
					"com/frostwire/jlibtorrent/swig/torrent_handle:FrostWire.Libtorrent.Swig.Torrent_handle",
					"com/frostwire/jlibtorrent/swig/torrent_handle$file_progress_flags_t:FrostWire.Libtorrent.Swig.Torrent_handle/File_progress_flags_t",
					"com/frostwire/jlibtorrent/swig/torrent_handle_vector:FrostWire.Libtorrent.Swig.Torrent_handle_vector",
					"com/frostwire/jlibtorrent/swig/torrent_info:FrostWire.Libtorrent.Swig.Torrent_info",
					"com/frostwire/jlibtorrent/swig/torrent_log_alert:FrostWire.Libtorrent.Swig.Torrent_log_alert",
					"com/frostwire/jlibtorrent/swig/torrent_need_cert_alert:FrostWire.Libtorrent.Swig.Torrent_need_cert_alert",
					"com/frostwire/jlibtorrent/swig/torrent_paused_alert:FrostWire.Libtorrent.Swig.Torrent_paused_alert",
					"com/frostwire/jlibtorrent/swig/torrent_removed_alert:FrostWire.Libtorrent.Swig.Torrent_removed_alert",
					"com/frostwire/jlibtorrent/swig/torrent_resumed_alert:FrostWire.Libtorrent.Swig.Torrent_resumed_alert",
					"com/frostwire/jlibtorrent/swig/torrent_status:FrostWire.Libtorrent.Swig.Torrent_status",
					"com/frostwire/jlibtorrent/swig/torrent_status$state_t:FrostWire.Libtorrent.Swig.Torrent_status/State_t",
					"com/frostwire/jlibtorrent/swig/torrent_status_vector:FrostWire.Libtorrent.Swig.Torrent_status_vector",
					"com/frostwire/jlibtorrent/swig/tracker_alert:FrostWire.Libtorrent.Swig.Tracker_alert",
					"com/frostwire/jlibtorrent/swig/tracker_announce_alert:FrostWire.Libtorrent.Swig.Tracker_announce_alert",
					"com/frostwire/jlibtorrent/swig/tracker_error_alert:FrostWire.Libtorrent.Swig.Tracker_error_alert",
					"com/frostwire/jlibtorrent/swig/tracker_reply_alert:FrostWire.Libtorrent.Swig.Tracker_reply_alert",
					"com/frostwire/jlibtorrent/swig/tracker_warning_alert:FrostWire.Libtorrent.Swig.Tracker_warning_alert",
					"com/frostwire/jlibtorrent/swig/trackerid_alert:FrostWire.Libtorrent.Swig.Trackerid_alert",
					"com/frostwire/jlibtorrent/swig/udp_endpoint:FrostWire.Libtorrent.Swig.Udp_endpoint",
					"com/frostwire/jlibtorrent/swig/udp_endpoint_vector:FrostWire.Libtorrent.Swig.Udp_endpoint_vector",
					"com/frostwire/jlibtorrent/swig/udp_error_alert:FrostWire.Libtorrent.Swig.Udp_error_alert",
					"com/frostwire/jlibtorrent/swig/unwanted_block_alert:FrostWire.Libtorrent.Swig.Unwanted_block_alert",
					"com/frostwire/jlibtorrent/swig/url_seed_alert:FrostWire.Libtorrent.Swig.Url_seed_alert",
					"com/frostwire/jlibtorrent/swig/web_seed_entry:FrostWire.Libtorrent.Swig.Web_seed_entry",
					"com/frostwire/jlibtorrent/swig/web_seed_entry$type_t:FrostWire.Libtorrent.Swig.Web_seed_entry/Type_t",
					"com/frostwire/jlibtorrent/swig/web_seed_entry_vector:FrostWire.Libtorrent.Swig.Web_seed_entry_vector",
				};
			}

			return Lookup (package_com_frostwire_jlibtorrent_swig_mappings, klass);
		}

		static string[] package_com_github_se_bastiaan_torrentstream_mappings;
		static Type lookup_com_github_se_bastiaan_torrentstream_package (string klass)
		{
			if (package_com_github_se_bastiaan_torrentstream_mappings == null) {
				package_com_github_se_bastiaan_torrentstream_mappings = new string[]{
					"com/github/se_bastiaan/torrentstream/BuildConfig:Bastiaan.TorrentStream.BuildConfig",
					"com/github/se_bastiaan/torrentstream/StreamStatus:Bastiaan.TorrentStream.StreamStatus",
					"com/github/se_bastiaan/torrentstream/Torrent:Bastiaan.TorrentStream.Torrent",
					"com/github/se_bastiaan/torrentstream/Torrent$State:Bastiaan.TorrentStream.Torrent/State",
					"com/github/se_bastiaan/torrentstream/TorrentOptions:Bastiaan.TorrentStream.TorrentOptions",
					"com/github/se_bastiaan/torrentstream/TorrentOptions$Builder:Bastiaan.TorrentStream.TorrentOptions/Builder",
					"com/github/se_bastiaan/torrentstream/TorrentStream:Bastiaan.TorrentStream.TorrentStream",
					"com/github/se_bastiaan/torrentstream/TorrentStream$InternalTorrentListener:Bastiaan.TorrentStream.TorrentStream/InternalTorrentListener",
				};
			}

			return Lookup (package_com_github_se_bastiaan_torrentstream_mappings, klass);
		}

		static string[] package_com_github_se_bastiaan_torrentstream_exceptions_mappings;
		static Type lookup_com_github_se_bastiaan_torrentstream_exceptions_package (string klass)
		{
			if (package_com_github_se_bastiaan_torrentstream_exceptions_mappings == null) {
				package_com_github_se_bastiaan_torrentstream_exceptions_mappings = new string[]{
					"com/github/se_bastiaan/torrentstream/exceptions/DirectoryModifyException:Bastiaan.TorrentStream.Exceptions.DirectoryModifyException",
					"com/github/se_bastiaan/torrentstream/exceptions/NotInitializedException:Bastiaan.TorrentStream.Exceptions.NotInitializedException",
					"com/github/se_bastiaan/torrentstream/exceptions/TorrentInfoException:Bastiaan.TorrentStream.Exceptions.TorrentInfoException",
				};
			}

			return Lookup (package_com_github_se_bastiaan_torrentstream_exceptions_mappings, klass);
		}

		static string[] package_com_github_se_bastiaan_torrentstream_listeners_mappings;
		static Type lookup_com_github_se_bastiaan_torrentstream_listeners_package (string klass)
		{
			if (package_com_github_se_bastiaan_torrentstream_listeners_mappings == null) {
				package_com_github_se_bastiaan_torrentstream_listeners_mappings = new string[]{
					"com/github/se_bastiaan/torrentstream/listeners/DHTStatsAlertListener:Bastiaan.TorrentStream.Listeners.DHTStatsAlertListener",
					"com/github/se_bastiaan/torrentstream/listeners/TorrentAddedAlertListener:Bastiaan.TorrentStream.Listeners.TorrentAddedAlertListener",
				};
			}

			return Lookup (package_com_github_se_bastiaan_torrentstream_listeners_mappings, klass);
		}

		static string[] package_com_github_se_bastiaan_torrentstream_utils_mappings;
		static Type lookup_com_github_se_bastiaan_torrentstream_utils_package (string klass)
		{
			if (package_com_github_se_bastiaan_torrentstream_utils_mappings == null) {
				package_com_github_se_bastiaan_torrentstream_utils_mappings = new string[]{
					"com/github/se_bastiaan/torrentstream/utils/FileUtils:Bastiaan.TorrentStream.Utils.FileUtils",
					"com/github/se_bastiaan/torrentstream/utils/ThreadUtils:Bastiaan.TorrentStream.Utils.ThreadUtils",
				};
			}

			return Lookup (package_com_github_se_bastiaan_torrentstream_utils_mappings, klass);
		}
	}
}
