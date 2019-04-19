using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/AddTorrentParams", DoNotGenerateAcw=true)]
	public sealed partial class AddTorrentParams : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/AddTorrentParams", typeof (AddTorrentParams));
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

		internal AddTorrentParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/constructor[@name='AddTorrentParams' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AddTorrentParams ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/constructor[@name='AddTorrentParams' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.add_torrent_params']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/add_torrent_params;)V", "")]
		public unsafe AddTorrentParams (global::FrostWire.Libtorrent.Swig.Add_torrent_params p)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/add_torrent_params;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='bannedPeers' and count(parameter)=0]"
		[Register ("bannedPeers", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.TcpEndpoint> BannedPeers ()
		{
			const string __id = "bannedPeers.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.TcpEndpoint>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='bannedPeers' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.frostwire.jlibtorrent.TcpEndpoint&gt;']]"
		[Register ("bannedPeers", "(Ljava/util/List;)V", "")]
		public unsafe void BannedPeers (global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.TcpEndpoint> value)
		{
			const string __id = "bannedPeers.(Ljava/util/List;)V";
			IntPtr native_value = global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.TcpEndpoint>.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='createInstance' and count(parameter)=0]"
		[Register ("createInstance", "()Lcom/frostwire/jlibtorrent/AddTorrentParams;", "")]
		public static unsafe global::FrostWire.Libtorrent.AddTorrentParams CreateInstance ()
		{
			const string __id = "createInstance.()Lcom/frostwire/jlibtorrent/AddTorrentParams;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.AddTorrentParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='createInstanceDisabledStorage' and count(parameter)=0]"
		[Register ("createInstanceDisabledStorage", "()Lcom/frostwire/jlibtorrent/AddTorrentParams;", "")]
		public static unsafe global::FrostWire.Libtorrent.AddTorrentParams CreateInstanceDisabledStorage ()
		{
			const string __id = "createInstanceDisabledStorage.()Lcom/frostwire/jlibtorrent/AddTorrentParams;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.AddTorrentParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='createInstanceZeroStorage' and count(parameter)=0]"
		[Register ("createInstanceZeroStorage", "()Lcom/frostwire/jlibtorrent/AddTorrentParams;", "")]
		public static unsafe global::FrostWire.Libtorrent.AddTorrentParams CreateInstanceZeroStorage ()
		{
			const string __id = "createInstanceZeroStorage.()Lcom/frostwire/jlibtorrent/AddTorrentParams;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.AddTorrentParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='dhtNodes' and count(parameter)=0]"
		[Register ("dhtNodes", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Pair> DhtNodes ()
		{
			const string __id = "dhtNodes.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Pair>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='dhtNodes' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.frostwire.jlibtorrent.Pair&lt;java.lang.String, java.lang.Integer&gt;&gt;']]"
		[Register ("dhtNodes", "(Ljava/util/List;)V", "")]
		public unsafe void DhtNodes (global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Pair> value)
		{
			const string __id = "dhtNodes.(Ljava/util/List;)V";
			IntPtr native_value = global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Pair>.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='downloadLimit' and count(parameter)=0]"
		[Register ("downloadLimit", "()I", "")]
		public unsafe int DownloadLimit ()
		{
			const string __id = "downloadLimit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='downloadLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("downloadLimit", "(I)V", "")]
		public unsafe void DownloadLimit (int value)
		{
			const string __id = "downloadLimit.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='filePriorities' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Priority[]']]"
		[Register ("filePriorities", "([Lcom/frostwire/jlibtorrent/Priority;)V", "")]
		public unsafe void FilePriorities (global::FrostWire.Libtorrent.Priority[] priorities)
		{
			const string __id = "filePriorities.([Lcom/frostwire/jlibtorrent/Priority;)V";
			IntPtr native_priorities = JNIEnv.NewArray (priorities);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_priorities);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (priorities != null) {
					JNIEnv.CopyArray (native_priorities, priorities);
					JNIEnv.DeleteLocalRef (native_priorities);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='flags' and count(parameter)=0]"
		[Register ("flags", "()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Torrent_flags_t Flags ()
		{
			const string __id = "flags.()Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='flags' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_flags_t']]"
		[Register ("flags", "(Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;)V", "")]
		public unsafe void Flags (global::FrostWire.Libtorrent.Swig.Torrent_flags_t flags)
		{
			const string __id = "flags.(Lcom/frostwire/jlibtorrent/swig/torrent_flags_t;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='infoHash' and count(parameter)=0]"
		[Register ("infoHash", "()Lcom/frostwire/jlibtorrent/Sha1Hash;", "")]
		public unsafe global::FrostWire.Libtorrent.Sha1Hash InfoHash ()
		{
			const string __id = "infoHash.()Lcom/frostwire/jlibtorrent/Sha1Hash;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='infoHash' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Sha1Hash']]"
		[Register ("infoHash", "(Lcom/frostwire/jlibtorrent/Sha1Hash;)V", "")]
		public unsafe void InfoHash (global::FrostWire.Libtorrent.Sha1Hash value)
		{
			const string __id = "infoHash.(Lcom/frostwire/jlibtorrent/Sha1Hash;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='maxConnections' and count(parameter)=0]"
		[Register ("maxConnections", "()I", "")]
		public unsafe int MaxConnections ()
		{
			const string __id = "maxConnections.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='maxConnections' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("maxConnections", "(I)V", "")]
		public unsafe void MaxConnections (int value)
		{
			const string __id = "maxConnections.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='maxUploads' and count(parameter)=0]"
		[Register ("maxUploads", "()I", "")]
		public unsafe int MaxUploads ()
		{
			const string __id = "maxUploads.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='maxUploads' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("maxUploads", "(I)V", "")]
		public unsafe void MaxUploads (int value)
		{
			const string __id = "maxUploads.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='name' and count(parameter)=0]"
		[Register ("name", "()Ljava/lang/String;", "")]
		public unsafe string Name ()
		{
			const string __id = "name.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='name' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("name", "(Ljava/lang/String;)V", "")]
		public unsafe void Name (string value)
		{
			const string __id = "name.(Ljava/lang/String;)V";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='parseMagnetUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseMagnetUri", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/AddTorrentParams;", "")]
		public static unsafe global::FrostWire.Libtorrent.AddTorrentParams ParseMagnetUri (string uri)
		{
			const string __id = "parseMagnetUri.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/AddTorrentParams;";
			IntPtr native_uri = JNIEnv.NewString (uri);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uri);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.AddTorrentParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_uri);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='peers' and count(parameter)=0]"
		[Register ("peers", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.TcpEndpoint> Peers ()
		{
			const string __id = "peers.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.TcpEndpoint>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='peers' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.frostwire.jlibtorrent.TcpEndpoint&gt;']]"
		[Register ("peers", "(Ljava/util/List;)V", "")]
		public unsafe void Peers (global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.TcpEndpoint> value)
		{
			const string __id = "peers.(Ljava/util/List;)V";
			IntPtr native_value = global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.TcpEndpoint>.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='piecePriorities' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Priority[]']]"
		[Register ("piecePriorities", "([Lcom/frostwire/jlibtorrent/Priority;)V", "")]
		public unsafe void PiecePriorities (global::FrostWire.Libtorrent.Priority[] priorities)
		{
			const string __id = "piecePriorities.([Lcom/frostwire/jlibtorrent/Priority;)V";
			IntPtr native_priorities = JNIEnv.NewArray (priorities);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_priorities);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (priorities != null) {
					JNIEnv.CopyArray (native_priorities, priorities);
					JNIEnv.DeleteLocalRef (native_priorities);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='savePath' and count(parameter)=0]"
		[Register ("savePath", "()Ljava/lang/String;", "")]
		public unsafe string SavePath ()
		{
			const string __id = "savePath.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='savePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("savePath", "(Ljava/lang/String;)V", "")]
		public unsafe void SavePath (string value)
		{
			const string __id = "savePath.(Ljava/lang/String;)V";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='storageMode' and count(parameter)=0]"
		[Register ("storageMode", "()Lcom/frostwire/jlibtorrent/StorageMode;", "")]
		public unsafe global::FrostWire.Libtorrent.StorageMode StorageMode ()
		{
			const string __id = "storageMode.()Lcom/frostwire/jlibtorrent/StorageMode;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.StorageMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='storageMode' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.StorageMode']]"
		[Register ("storageMode", "(Lcom/frostwire/jlibtorrent/StorageMode;)V", "")]
		public unsafe void StorageMode (global::FrostWire.Libtorrent.StorageMode value)
		{
			const string __id = "storageMode.(Lcom/frostwire/jlibtorrent/StorageMode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/add_torrent_params;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Add_torrent_params Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/add_torrent_params;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Add_torrent_params> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='torrentInfo' and count(parameter)=0]"
		[Register ("torrentInfo", "()Lcom/frostwire/jlibtorrent/TorrentInfo;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentInfo TorrentInfo ()
		{
			const string __id = "torrentInfo.()Lcom/frostwire/jlibtorrent/TorrentInfo;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='torrentInfo' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.TorrentInfo']]"
		[Register ("torrentInfo", "(Lcom/frostwire/jlibtorrent/TorrentInfo;)V", "")]
		public unsafe void TorrentInfo (global::FrostWire.Libtorrent.TorrentInfo ti)
		{
			const string __id = "torrentInfo.(Lcom/frostwire/jlibtorrent/TorrentInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ti == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ti).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='trackerId' and count(parameter)=0]"
		[Register ("trackerId", "()Ljava/lang/String;", "")]
		public unsafe string TrackerId ()
		{
			const string __id = "trackerId.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='trackerId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("trackerId", "(Ljava/lang/String;)V", "")]
		public unsafe void TrackerId (string value)
		{
			const string __id = "trackerId.(Ljava/lang/String;)V";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='trackerTiers' and count(parameter)=0]"
		[Register ("trackerTiers", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> TrackerTiers ()
		{
			const string __id = "trackerTiers.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='trackerTiers' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;']]"
		[Register ("trackerTiers", "(Ljava/util/List;)V", "")]
		public unsafe void TrackerTiers (global::System.Collections.Generic.IList<global::Java.Lang.Integer> value)
		{
			const string __id = "trackerTiers.(Ljava/util/List;)V";
			IntPtr native_value = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='trackers' and count(parameter)=0]"
		[Register ("trackers", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<string> Trackers ()
		{
			const string __id = "trackers.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='trackers' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("trackers", "(Ljava/util/List;)V", "")]
		public unsafe void Trackers (global::System.Collections.Generic.IList<string> value)
		{
			const string __id = "trackers.(Ljava/util/List;)V";
			IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='uploadLimit' and count(parameter)=0]"
		[Register ("uploadLimit", "()I", "")]
		public unsafe int UploadLimit ()
		{
			const string __id = "uploadLimit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='uploadLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("uploadLimit", "(I)V", "")]
		public unsafe void UploadLimit (int value)
		{
			const string __id = "uploadLimit.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='urlSeeds' and count(parameter)=0]"
		[Register ("urlSeeds", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<string> UrlSeeds ()
		{
			const string __id = "urlSeeds.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='urlSeeds' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("urlSeeds", "(Ljava/util/List;)V", "")]
		public unsafe void UrlSeeds (global::System.Collections.Generic.IList<string> value)
		{
			const string __id = "urlSeeds.(Ljava/util/List;)V";
			IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AddTorrentParams']/method[@name='version' and count(parameter)=0]"
		[Register ("version", "()I", "")]
		public unsafe int Version ()
		{
			const string __id = "version.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
