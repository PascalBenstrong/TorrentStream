using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/SettingsPack", DoNotGenerateAcw=true)]
	public sealed partial class SettingsPack : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/SettingsPack", typeof (SettingsPack));
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

		internal SettingsPack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/constructor[@name='SettingsPack' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SettingsPack ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/constructor[@name='SettingsPack' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.settings_pack']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/settings_pack;)V", "")]
		public unsafe SettingsPack (global::FrostWire.Libtorrent.Swig.Settings_pack sp)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/settings_pack;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sp).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='activeChecking' and count(parameter)=0]"
		[Register ("activeChecking", "()I", "")]
		public unsafe int ActiveChecking ()
		{
			const string __id = "activeChecking.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='activeChecking' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("activeChecking", "(I)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack ActiveChecking (int value)
		{
			const string __id = "activeChecking.(I)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='activeDhtLimit' and count(parameter)=0]"
		[Register ("activeDhtLimit", "()I", "")]
		public unsafe int ActiveDhtLimit ()
		{
			const string __id = "activeDhtLimit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='activeDhtLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("activeDhtLimit", "(I)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack ActiveDhtLimit (int value)
		{
			const string __id = "activeDhtLimit.(I)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='activeDownloads' and count(parameter)=0]"
		[Register ("activeDownloads", "()I", "")]
		public unsafe int ActiveDownloads ()
		{
			const string __id = "activeDownloads.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='activeDownloads' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("activeDownloads", "(I)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack ActiveDownloads (int value)
		{
			const string __id = "activeDownloads.(I)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='activeLimit' and count(parameter)=0]"
		[Register ("activeLimit", "()I", "")]
		public unsafe int ActiveLimit ()
		{
			const string __id = "activeLimit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='activeLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("activeLimit", "(I)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack ActiveLimit (int value)
		{
			const string __id = "activeLimit.(I)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='activeLsdLimit' and count(parameter)=0]"
		[Register ("activeLsdLimit", "()I", "")]
		public unsafe int ActiveLsdLimit ()
		{
			const string __id = "activeLsdLimit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='activeLsdLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("activeLsdLimit", "(I)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack ActiveLsdLimit (int value)
		{
			const string __id = "activeLsdLimit.(I)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='activeSeeds' and count(parameter)=0]"
		[Register ("activeSeeds", "()I", "")]
		public unsafe int ActiveSeeds ()
		{
			const string __id = "activeSeeds.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='activeSeeds' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("activeSeeds", "(I)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack ActiveSeeds (int value)
		{
			const string __id = "activeSeeds.(I)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='activeTrackerLimit' and count(parameter)=0]"
		[Register ("activeTrackerLimit", "()I", "")]
		public unsafe int ActiveTrackerLimit ()
		{
			const string __id = "activeTrackerLimit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='activeTrackerLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("activeTrackerLimit", "(I)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack ActiveTrackerLimit (int value)
		{
			const string __id = "activeTrackerLimit.(I)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='alertQueueSize' and count(parameter)=0]"
		[Register ("alertQueueSize", "()I", "")]
		public unsafe int AlertQueueSize ()
		{
			const string __id = "alertQueueSize.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='alertQueueSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("alertQueueSize", "(I)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack AlertQueueSize (int value)
		{
			const string __id = "alertQueueSize.(I)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='anonymousMode' and count(parameter)=0]"
		[Register ("anonymousMode", "()Z", "")]
		public unsafe bool AnonymousMode ()
		{
			const string __id = "anonymousMode.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='anonymousMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("anonymousMode", "(Z)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack AnonymousMode (bool value)
		{
			const string __id = "anonymousMode.(Z)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='broadcastLSD' and count(parameter)=0]"
		[Register ("broadcastLSD", "()Z", "")]
		public unsafe bool BroadcastLSD ()
		{
			const string __id = "broadcastLSD.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='broadcastLSD' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("broadcastLSD", "(Z)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack BroadcastLSD (bool value)
		{
			const string __id = "broadcastLSD.(Z)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='cacheSize' and count(parameter)=0]"
		[Register ("cacheSize", "()I", "")]
		public unsafe int CacheSize ()
		{
			const string __id = "cacheSize.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='cacheSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("cacheSize", "(I)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack CacheSize (int value)
		{
			const string __id = "cacheSize.(I)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='clear' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("clear", "(I)V", "")]
		public unsafe void Clear (int name)
		{
			const string __id = "clear.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (name);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='connectionsLimit' and count(parameter)=0]"
		[Register ("connectionsLimit", "()I", "")]
		public unsafe int ConnectionsLimit ()
		{
			const string __id = "connectionsLimit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='connectionsLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("connectionsLimit", "(I)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack ConnectionsLimit (int value)
		{
			const string __id = "connectionsLimit.(I)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='downloadRateLimit' and count(parameter)=0]"
		[Register ("downloadRateLimit", "()I", "")]
		public unsafe int DownloadRateLimit ()
		{
			const string __id = "downloadRateLimit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='downloadRateLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("downloadRateLimit", "(I)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack DownloadRateLimit (int value)
		{
			const string __id = "downloadRateLimit.(I)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='enableDht' and count(parameter)=0]"
		[Register ("enableDht", "()Z", "")]
		public unsafe bool EnableDht ()
		{
			const string __id = "enableDht.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='enableDht' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableDht", "(Z)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack EnableDht (bool value)
		{
			const string __id = "enableDht.(Z)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='getBoolean' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBoolean", "(I)Z", "")]
		public unsafe bool GetBoolean (int name)
		{
			const string __id = "getBoolean.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (name);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='getInteger' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getInteger", "(I)I", "")]
		public unsafe int GetInteger (int name)
		{
			const string __id = "getInteger.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (name);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getString", "(I)Ljava/lang/String;", "")]
		public unsafe string GetString (int name)
		{
			const string __id = "getString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (name);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='inactivityTimeout' and count(parameter)=0]"
		[Register ("inactivityTimeout", "()I", "")]
		public unsafe int InactivityTimeout ()
		{
			const string __id = "inactivityTimeout.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='inactivityTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("inactivityTimeout", "(I)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack InactivityTimeout (int value)
		{
			const string __id = "inactivityTimeout.(I)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='listenInterfaces' and count(parameter)=0]"
		[Register ("listenInterfaces", "()Ljava/lang/String;", "")]
		public unsafe string ListenInterfaces ()
		{
			const string __id = "listenInterfaces.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='listenInterfaces' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("listenInterfaces", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack ListenInterfaces (string value)
		{
			const string __id = "listenInterfaces.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/SettingsPack;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='maxPeerlistSize' and count(parameter)=0]"
		[Register ("maxPeerlistSize", "()I", "")]
		public unsafe int MaxPeerlistSize ()
		{
			const string __id = "maxPeerlistSize.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='maxPeerlistSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("maxPeerlistSize", "(I)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack MaxPeerlistSize (int value)
		{
			const string __id = "maxPeerlistSize.(I)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='maxQueuedDiskBytes' and count(parameter)=0]"
		[Register ("maxQueuedDiskBytes", "()I", "")]
		public unsafe int MaxQueuedDiskBytes ()
		{
			const string __id = "maxQueuedDiskBytes.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='maxQueuedDiskBytes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("maxQueuedDiskBytes", "(I)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack MaxQueuedDiskBytes (int value)
		{
			const string __id = "maxQueuedDiskBytes.(I)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='seedingOutgoingConnections' and count(parameter)=0]"
		[Register ("seedingOutgoingConnections", "()Z", "")]
		public unsafe bool SeedingOutgoingConnections ()
		{
			const string __id = "seedingOutgoingConnections.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='seedingOutgoingConnections' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("seedingOutgoingConnections", "(Z)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack SeedingOutgoingConnections (bool value)
		{
			const string __id = "seedingOutgoingConnections.(Z)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='sendBufferWatermark' and count(parameter)=0]"
		[Register ("sendBufferWatermark", "()I", "")]
		public unsafe int SendBufferWatermark ()
		{
			const string __id = "sendBufferWatermark.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='sendBufferWatermark' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sendBufferWatermark", "(I)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack SendBufferWatermark (int value)
		{
			const string __id = "sendBufferWatermark.(I)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='setBoolean' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setBoolean", "(IZ)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack SetBoolean (int name, bool value)
		{
			const string __id = "setBoolean.(IZ)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (name);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='setInteger' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setInteger", "(II)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack SetInteger (int name, int value)
		{
			const string __id = "setInteger.(II)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (name);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='setString' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("setString", "(ILjava/lang/String;)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack SetString (int name, string value)
		{
			const string __id = "setString.(ILjava/lang/String;)Lcom/frostwire/jlibtorrent/SettingsPack;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (name);
				__args [1] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='stopTrackerTimeout' and count(parameter)=0]"
		[Register ("stopTrackerTimeout", "()I", "")]
		public unsafe int StopTrackerTimeout ()
		{
			const string __id = "stopTrackerTimeout.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='stopTrackerTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("stopTrackerTimeout", "(I)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack StopTrackerTimeout (int value)
		{
			const string __id = "stopTrackerTimeout.(I)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/settings_pack;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Settings_pack Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/settings_pack;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Settings_pack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='tickInterval' and count(parameter)=0]"
		[Register ("tickInterval", "()I", "")]
		public unsafe int TickInterval ()
		{
			const string __id = "tickInterval.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='tickInterval' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("tickInterval", "(I)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack TickInterval (int value)
		{
			const string __id = "tickInterval.(I)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='uploadRateLimit' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='uploadRateLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("uploadRateLimit", "(I)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack UploadRateLimit (int value)
		{
			const string __id = "uploadRateLimit.(I)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='upnpIgnoreNonRouters' and count(parameter)=0]"
		[Register ("upnpIgnoreNonRouters", "()Z", "")]
		public unsafe bool UpnpIgnoreNonRouters ()
		{
			const string __id = "upnpIgnoreNonRouters.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SettingsPack']/method[@name='upnpIgnoreNonRouters' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("upnpIgnoreNonRouters", "(Z)Lcom/frostwire/jlibtorrent/SettingsPack;", "")]
		public unsafe global::FrostWire.Libtorrent.SettingsPack UpnpIgnoreNonRouters (bool value)
		{
			const string __id = "upnpIgnoreNonRouters.(Z)Lcom/frostwire/jlibtorrent/SettingsPack;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.SettingsPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
