using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	[Register ("com/frostwire/jlibtorrent/swig/libtorrentConstants", DoNotGenerateAcw=true)]
	public abstract class LibtorrentConstants : Java.Lang.Object {

		internal LibtorrentConstants ()
		{
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/interface[@name='libtorrentConstants']/field[@name='LIBTORRENT_REVISION']"
		[Register ("LIBTORRENT_REVISION")]
		public static string LibtorrentRevision {
			get {
				const string __id = "LIBTORRENT_REVISION.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/interface[@name='libtorrentConstants']/field[@name='LIBTORRENT_VERSION']"
		[Register ("LIBTORRENT_VERSION")]
		public static string LibtorrentVersion {
			get {
				const string __id = "LIBTORRENT_VERSION.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/interface[@name='libtorrentConstants']/field[@name='LIBTORRENT_VERSION_MAJOR']"
		[Register ("LIBTORRENT_VERSION_MAJOR")]
		public static int LibtorrentVersionMajor {
			get {
				const string __id = "LIBTORRENT_VERSION_MAJOR.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/interface[@name='libtorrentConstants']/field[@name='LIBTORRENT_VERSION_MINOR']"
		[Register ("LIBTORRENT_VERSION_MINOR")]
		public static int LibtorrentVersionMinor {
			get {
				const string __id = "LIBTORRENT_VERSION_MINOR.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/interface[@name='libtorrentConstants']/field[@name='LIBTORRENT_VERSION_NUM']"
		[Register ("LIBTORRENT_VERSION_NUM")]
		public static int LibtorrentVersionNum {
			get {
				const string __id = "LIBTORRENT_VERSION_NUM.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/interface[@name='libtorrentConstants']/field[@name='LIBTORRENT_VERSION_TINY']"
		[Register ("LIBTORRENT_VERSION_TINY")]
		public static int LibtorrentVersionTiny {
			get {
				const string __id = "LIBTORRENT_VERSION_TINY.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}

		new static JniPeerMembers _members = new JniPeerMembers ("com/frostwire/jlibtorrent/swig/libtorrentConstants", typeof (LibtorrentConstants));
	}

	[Register ("com/frostwire/jlibtorrent/swig/libtorrentConstants", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'LibtorrentConstants' type. This type will be removed in a future release.")]
	public abstract class LibtorrentConstantsConsts : LibtorrentConstants {

		private LibtorrentConstantsConsts ()
		{
		}
	}

}
