using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/DhtSettings", DoNotGenerateAcw=true)]
	public sealed partial class DhtSettings : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/DhtSettings", typeof (DhtSettings));
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

		internal DhtSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/constructor[@name='DhtSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DhtSettings ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/constructor[@name='DhtSettings' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_settings']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/dht_settings;)V", "")]
		public unsafe DhtSettings (global::FrostWire.Libtorrent.Swig.Dht_settings s)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/dht_settings;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe bool EnforceNodeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='isEnforceNodeId' and count(parameter)=0]"
			[Register ("isEnforceNodeId", "()Z", "GetIsEnforceNodeIdHandler")]
			get {
				const string __id = "isEnforceNodeId.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='setEnforceNodeId' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnforceNodeId", "(Z)V", "GetSetEnforceNodeId_ZHandler")]
			set {
				const string __id = "setEnforceNodeId.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool ExtendedRoutingTable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='isExtendedRoutingTable' and count(parameter)=0]"
			[Register ("isExtendedRoutingTable", "()Z", "GetIsExtendedRoutingTableHandler")]
			get {
				const string __id = "isExtendedRoutingTable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='setExtendedRoutingTable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setExtendedRoutingTable", "(Z)V", "GetSetExtendedRoutingTable_ZHandler")]
			set {
				const string __id = "setExtendedRoutingTable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool IgnoreDarkInternet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='isIgnoreDarkInternet' and count(parameter)=0]"
			[Register ("isIgnoreDarkInternet", "()Z", "GetIsIgnoreDarkInternetHandler")]
			get {
				const string __id = "isIgnoreDarkInternet.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='setIgnoreDarkInternet' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIgnoreDarkInternet", "(Z)V", "GetSetIgnoreDarkInternet_ZHandler")]
			set {
				const string __id = "setIgnoreDarkInternet.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool IsAggressiveLookups {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='isAggressiveLookups' and count(parameter)=0]"
			[Register ("isAggressiveLookups", "()Z", "GetIsAggressiveLookupsHandler")]
			get {
				const string __id = "isAggressiveLookups.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int MaxFailCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='getMaxFailCount' and count(parameter)=0]"
			[Register ("getMaxFailCount", "()I", "GetGetMaxFailCountHandler")]
			get {
				const string __id = "getMaxFailCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='setMaxFailCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxFailCount", "(I)V", "GetSetMaxFailCount_IHandler")]
			set {
				const string __id = "setMaxFailCount.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int MaxTorrentSearchReply {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='getMaxTorrentSearchReply' and count(parameter)=0]"
			[Register ("getMaxTorrentSearchReply", "()I", "GetGetMaxTorrentSearchReplyHandler")]
			get {
				const string __id = "getMaxTorrentSearchReply.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='setMaxTorrentSearchReply' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxTorrentSearchReply", "(I)V", "GetSetMaxTorrentSearchReply_IHandler")]
			set {
				const string __id = "setMaxTorrentSearchReply.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool PrivacyLookups {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='isPrivacyLookups' and count(parameter)=0]"
			[Register ("isPrivacyLookups", "()Z", "GetIsPrivacyLookupsHandler")]
			get {
				const string __id = "isPrivacyLookups.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='setPrivacyLookups' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPrivacyLookups", "(Z)V", "GetSetPrivacyLookups_ZHandler")]
			set {
				const string __id = "setPrivacyLookups.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool RestrictRoutingIPs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='isRestrictRoutingIPs' and count(parameter)=0]"
			[Register ("isRestrictRoutingIPs", "()Z", "GetIsRestrictRoutingIPsHandler")]
			get {
				const string __id = "isRestrictRoutingIPs.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='setRestrictRoutingIPs' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRestrictRoutingIPs", "(Z)V", "GetSetRestrictRoutingIPs_ZHandler")]
			set {
				const string __id = "setRestrictRoutingIPs.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool RestrictSearchIPs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='isRestrictSearchIPs' and count(parameter)=0]"
			[Register ("isRestrictSearchIPs", "()Z", "GetIsRestrictSearchIPsHandler")]
			get {
				const string __id = "isRestrictSearchIPs.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='setRestrictSearchIPs' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRestrictSearchIPs", "(Z)V", "GetSetRestrictSearchIPs_ZHandler")]
			set {
				const string __id = "setRestrictSearchIPs.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int SearchBranching {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='getSearchBranching' and count(parameter)=0]"
			[Register ("getSearchBranching", "()I", "GetGetSearchBranchingHandler")]
			get {
				const string __id = "getSearchBranching.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='setSearchBranching' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSearchBranching", "(I)V", "GetSetSearchBranching_IHandler")]
			set {
				const string __id = "setSearchBranching.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='blockRatelimit' and count(parameter)=0]"
		[Register ("blockRatelimit", "()I", "")]
		public unsafe int BlockRatelimit ()
		{
			const string __id = "blockRatelimit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='blockRatelimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("blockRatelimit", "(I)V", "")]
		public unsafe void BlockRatelimit (int value)
		{
			const string __id = "blockRatelimit.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='blockTimeout' and count(parameter)=0]"
		[Register ("blockTimeout", "()I", "")]
		public unsafe int BlockTimeout ()
		{
			const string __id = "blockTimeout.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='blockTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("blockTimeout", "(I)V", "")]
		public unsafe void BlockTimeout (int value)
		{
			const string __id = "blockTimeout.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='getAggressiveLookups' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getAggressiveLookups", "(Z)V", "")]
		public unsafe void GetAggressiveLookups (bool value)
		{
			const string __id = "getAggressiveLookups.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='itemLifetime' and count(parameter)=0]"
		[Register ("itemLifetime", "()I", "")]
		public unsafe int ItemLifetime ()
		{
			const string __id = "itemLifetime.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='itemLifetime' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("itemLifetime", "(I)V", "")]
		public unsafe void ItemLifetime (int value)
		{
			const string __id = "itemLifetime.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='maxDhtItems' and count(parameter)=0]"
		[Register ("maxDhtItems", "()I", "")]
		public unsafe int MaxDhtItems ()
		{
			const string __id = "maxDhtItems.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='maxDhtItems' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("maxDhtItems", "(I)V", "")]
		public unsafe void MaxDhtItems (int value)
		{
			const string __id = "maxDhtItems.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='maxPeers' and count(parameter)=0]"
		[Register ("maxPeers", "()I", "")]
		public unsafe int MaxPeers ()
		{
			const string __id = "maxPeers.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='maxPeers' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("maxPeers", "(I)V", "")]
		public unsafe void MaxPeers (int value)
		{
			const string __id = "maxPeers.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='maxPeersReply' and count(parameter)=0]"
		[Register ("maxPeersReply", "()I", "")]
		public unsafe int MaxPeersReply ()
		{
			const string __id = "maxPeersReply.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='maxPeersReply' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("maxPeersReply", "(I)V", "")]
		public unsafe void MaxPeersReply (int value)
		{
			const string __id = "maxPeersReply.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='maxTorrents' and count(parameter)=0]"
		[Register ("maxTorrents", "()I", "")]
		public unsafe int MaxTorrents ()
		{
			const string __id = "maxTorrents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='maxTorrents' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("maxTorrents", "(I)V", "")]
		public unsafe void MaxTorrents (int value)
		{
			const string __id = "maxTorrents.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='readOnly' and count(parameter)=0]"
		[Register ("readOnly", "()Z", "")]
		public unsafe bool ReadOnly ()
		{
			const string __id = "readOnly.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='readOnly' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("readOnly", "(Z)V", "")]
		public unsafe void ReadOnly (bool value)
		{
			const string __id = "readOnly.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/dht_settings;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Dht_settings Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/dht_settings;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='uploadRateLimit' and count(parameter)=0]"
		[Register ("uploadRateLimit", "()I", "")]
		public unsafe int UploadRateLimit ()
		{
			const string __id = "uploadRateLimit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtSettings']/method[@name='uploadRateLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("uploadRateLimit", "(I)V", "")]
		public unsafe void UploadRateLimit (int value)
		{
			const string __id = "uploadRateLimit.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
