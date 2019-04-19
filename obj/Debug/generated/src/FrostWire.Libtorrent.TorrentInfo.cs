using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/TorrentInfo", DoNotGenerateAcw=true)]
	public sealed partial class TorrentInfo : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/TorrentInfo", typeof (TorrentInfo));
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

		internal TorrentInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/constructor[@name='TorrentInfo' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe TorrentInfo (byte[] data)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/constructor[@name='TorrentInfo' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.torrent_info']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/torrent_info;)V", "")]
		public unsafe TorrentInfo (global::FrostWire.Libtorrent.Swig.Torrent_info ti)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/torrent_info;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ti == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ti).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/constructor[@name='TorrentInfo' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register (".ctor", "(Ljava/io/File;)V", "")]
		public unsafe TorrentInfo (global::Java.IO.File torrent)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/io/File;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((torrent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) torrent).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/constructor[@name='TorrentInfo' and count(parameter)=1 and parameter[1][@type='java.nio.MappedByteBuffer']]"
		[Register (".ctor", "(Ljava/nio/MappedByteBuffer;)V", "")]
		public unsafe TorrentInfo (global::Java.Nio.MappedByteBuffer buffer)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/nio/MappedByteBuffer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe bool IsI2p {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='isI2p' and count(parameter)=0]"
			[Register ("isI2p", "()Z", "GetIsI2pHandler")]
			get {
				const string __id = "isI2p.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsLoaded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='isLoaded' and count(parameter)=0]"
			[Register ("isLoaded", "()Z", "GetIsLoadedHandler")]
			get {
				const string __id = "isLoaded.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsMerkleTorrent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='isMerkleTorrent' and count(parameter)=0]"
			[Register ("isMerkleTorrent", "()Z", "GetIsMerkleTorrentHandler")]
			get {
				const string __id = "isMerkleTorrent.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsPrivate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='isPrivate' and count(parameter)=0]"
			[Register ("isPrivate", "()Z", "GetIsPrivateHandler")]
			get {
				const string __id = "isPrivate.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				const string __id = "isValid.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='addHttpSeed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addHttpSeed", "(Ljava/lang/String;)V", "")]
		public unsafe void AddHttpSeed (string url)
		{
			const string __id = "addHttpSeed.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='addHttpSeed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addHttpSeed", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void AddHttpSeed (string url, string externAuth)
		{
			const string __id = "addHttpSeed.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_externAuth = JNIEnv.NewString (externAuth);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_externAuth);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_externAuth);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='addHttpSeed' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;com.frostwire.jlibtorrent.Pair&lt;java.lang.String, java.lang.String&gt;&gt;']]"
		[Register ("addHttpSeed", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V", "")]
		public unsafe void AddHttpSeed (string url, string externAuth, global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Pair> extraHeaders)
		{
			const string __id = "addHttpSeed.(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_externAuth = JNIEnv.NewString (externAuth);
			IntPtr native_extraHeaders = global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Pair>.ToLocalJniHandle (extraHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_externAuth);
				__args [2] = new JniArgumentValue (native_extraHeaders);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_externAuth);
				JNIEnv.DeleteLocalRef (native_extraHeaders);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='addNode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("addNode", "(Ljava/lang/String;I)V", "")]
		public unsafe void AddNode (string host, int port)
		{
			const string __id = "addNode.(Ljava/lang/String;I)V";
			IntPtr native_host = JNIEnv.NewString (host);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_host);
				__args [1] = new JniArgumentValue (port);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_host);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='addTracker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addTracker", "(Ljava/lang/String;)V", "")]
		public unsafe void AddTracker (string url)
		{
			const string __id = "addTracker.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='addTracker' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("addTracker", "(Ljava/lang/String;I)V", "")]
		public unsafe void AddTracker (string url, int tier)
		{
			const string __id = "addTracker.(Ljava/lang/String;I)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (tier);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='addUrlSeed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addUrlSeed", "(Ljava/lang/String;)V", "")]
		public unsafe void AddUrlSeed (string url)
		{
			const string __id = "addUrlSeed.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='addUrlSeed' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addUrlSeed", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void AddUrlSeed (string url, string externAuth)
		{
			const string __id = "addUrlSeed.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_externAuth = JNIEnv.NewString (externAuth);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_externAuth);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_externAuth);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='addUrlSeed' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;com.frostwire.jlibtorrent.Pair&lt;java.lang.String, java.lang.String&gt;&gt;']]"
		[Register ("addUrlSeed", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V", "")]
		public unsafe void AddUrlSeed (string url, string externAuth, global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Pair> extraHeaders)
		{
			const string __id = "addUrlSeed.(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			IntPtr native_externAuth = JNIEnv.NewString (externAuth);
			IntPtr native_extraHeaders = global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Pair>.ToLocalJniHandle (extraHeaders);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (native_externAuth);
				__args [2] = new JniArgumentValue (native_extraHeaders);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
				JNIEnv.DeleteLocalRef (native_externAuth);
				JNIEnv.DeleteLocalRef (native_extraHeaders);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='bdecode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("bdecode", "([B)Lcom/frostwire/jlibtorrent/TorrentInfo;", "")]
		public static unsafe global::FrostWire.Libtorrent.TorrentInfo Bdecode (byte[] data)
		{
			const string __id = "bdecode.([B)Lcom/frostwire/jlibtorrent/TorrentInfo;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='bencode' and count(parameter)=0]"
		[Register ("bencode", "()[B", "")]
		public unsafe byte[] Bencode ()
		{
			const string __id = "bencode.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='clearTrackers' and count(parameter)=0]"
		[Register ("clearTrackers", "()V", "")]
		public unsafe void ClearTrackers ()
		{
			const string __id = "clearTrackers.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='collections' and count(parameter)=0]"
		[Register ("collections", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<string> Collections ()
		{
			const string __id = "collections.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='comment' and count(parameter)=0]"
		[Register ("comment", "()Ljava/lang/String;", "")]
		public unsafe string Comment ()
		{
			const string __id = "comment.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='creationDate' and count(parameter)=0]"
		[Register ("creationDate", "()J", "")]
		public unsafe long CreationDate ()
		{
			const string __id = "creationDate.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='creator' and count(parameter)=0]"
		[Register ("creator", "()Ljava/lang/String;", "")]
		public unsafe string Creator ()
		{
			const string __id = "creator.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='files' and count(parameter)=0]"
		[Register ("files", "()Lcom/frostwire/jlibtorrent/FileStorage;", "")]
		public unsafe global::FrostWire.Libtorrent.FileStorage Files ()
		{
			const string __id = "files.()Lcom/frostwire/jlibtorrent/FileStorage;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.FileStorage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='hashForPiece' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hashForPiece", "(I)Lcom/frostwire/jlibtorrent/Sha1Hash;", "")]
		public unsafe global::FrostWire.Libtorrent.Sha1Hash HashForPiece (int index)
		{
			const string __id = "hashForPiece.(I)Lcom/frostwire/jlibtorrent/Sha1Hash;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='info' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("info", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/bdecode_node;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Bdecode_node Info (string key)
		{
			const string __id = "info.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/swig/bdecode_node;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='infoHash' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='makeMagnetUri' and count(parameter)=0]"
		[Register ("makeMagnetUri", "()Ljava/lang/String;", "")]
		public unsafe string MakeMagnetUri ()
		{
			const string __id = "makeMagnetUri.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='mapBlock' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("mapBlock", "(IJI)Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.FileSlice> MapBlock (int piece, long offset, int size)
		{
			const string __id = "mapBlock.(IJI)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (piece);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.FileSlice>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='mapFile' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("mapFile", "(IJI)Lcom/frostwire/jlibtorrent/PeerRequest;", "")]
		public unsafe global::FrostWire.Libtorrent.PeerRequest MapFile (int file, long offset, int size)
		{
			const string __id = "mapFile.(IJI)Lcom/frostwire/jlibtorrent/PeerRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (file);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='merkleTree' and count(parameter)=0]"
		[Register ("merkleTree", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Sha1Hash> MerkleTree ()
		{
			const string __id = "merkleTree.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Sha1Hash>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='merkleTree' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.frostwire.jlibtorrent.Sha1Hash&gt;']]"
		[Register ("merkleTree", "(Ljava/util/List;)V", "")]
		public unsafe void MerkleTree (global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Sha1Hash> tree)
		{
			const string __id = "merkleTree.(Ljava/util/List;)V";
			IntPtr native_tree = global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Sha1Hash>.ToLocalJniHandle (tree);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tree);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tree);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='name' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='nodes' and count(parameter)=0]"
		[Register ("nodes", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Pair> Nodes ()
		{
			const string __id = "nodes.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Pair>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='numFiles' and count(parameter)=0]"
		[Register ("numFiles", "()I", "")]
		public unsafe int NumFiles ()
		{
			const string __id = "numFiles.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='numPieces' and count(parameter)=0]"
		[Register ("numPieces", "()I", "")]
		public unsafe int NumPieces ()
		{
			const string __id = "numPieces.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='origFiles' and count(parameter)=0]"
		[Register ("origFiles", "()Lcom/frostwire/jlibtorrent/FileStorage;", "")]
		public unsafe global::FrostWire.Libtorrent.FileStorage OrigFiles ()
		{
			const string __id = "origFiles.()Lcom/frostwire/jlibtorrent/FileStorage;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.FileStorage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='pieceLength' and count(parameter)=0]"
		[Register ("pieceLength", "()I", "")]
		public unsafe int PieceLength ()
		{
			const string __id = "pieceLength.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='pieceSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pieceSize", "(I)I", "")]
		public unsafe int PieceSize (int index)
		{
			const string __id = "pieceSize.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='remapFiles' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.FileStorage']]"
		[Register ("remapFiles", "(Lcom/frostwire/jlibtorrent/FileStorage;)V", "")]
		public unsafe void RemapFiles (global::FrostWire.Libtorrent.FileStorage f)
		{
			const string __id = "remapFiles.(Lcom/frostwire/jlibtorrent/FileStorage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='renameFile' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("renameFile", "(ILjava/lang/String;)V", "")]
		public unsafe void RenameFile (int index, string newFilename)
		{
			const string __id = "renameFile.(ILjava/lang/String;)V";
			IntPtr native_newFilename = JNIEnv.NewString (newFilename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (native_newFilename);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_newFilename);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='setWebSeeds' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.frostwire.jlibtorrent.WebSeedEntry&gt;']]"
		[Register ("setWebSeeds", "(Ljava/util/List;)V", "")]
		public unsafe void SetWebSeeds (global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.WebSeedEntry> seeds)
		{
			const string __id = "setWebSeeds.(Ljava/util/List;)V";
			IntPtr native_seeds = global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.WebSeedEntry>.ToLocalJniHandle (seeds);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_seeds);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_seeds);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='similarTorrents' and count(parameter)=0]"
		[Register ("similarTorrents", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Sha1Hash> SimilarTorrents ()
		{
			const string __id = "similarTorrents.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Sha1Hash>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/torrent_info;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Torrent_info Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/torrent_info;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='toEntry' and count(parameter)=0]"
		[Register ("toEntry", "()Lcom/frostwire/jlibtorrent/Entry;", "")]
		public unsafe global::FrostWire.Libtorrent.Entry ToEntry ()
		{
			const string __id = "toEntry.()Lcom/frostwire/jlibtorrent/Entry;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='totalSize' and count(parameter)=0]"
		[Register ("totalSize", "()J", "")]
		public unsafe long TotalSize ()
		{
			const string __id = "totalSize.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='trackers' and count(parameter)=0]"
		[Register ("trackers", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.AnnounceEntry> Trackers ()
		{
			const string __id = "trackers.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.AnnounceEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentInfo']/method[@name='webSeeds' and count(parameter)=0]"
		[Register ("webSeeds", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.WebSeedEntry> WebSeeds ()
		{
			const string __id = "webSeeds.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.WebSeedEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
