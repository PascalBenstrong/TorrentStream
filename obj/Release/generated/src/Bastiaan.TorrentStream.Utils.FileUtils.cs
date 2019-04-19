using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Bastiaan.TorrentStream.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.utils']/class[@name='FileUtils']"
	[global::Android.Runtime.Register ("com/github/se_bastiaan/torrentstream/utils/FileUtils", DoNotGenerateAcw=true)]
	public sealed partial class FileUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/se_bastiaan/torrentstream/utils/FileUtils", typeof (FileUtils));
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

		internal FileUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.utils']/class[@name='FileUtils']/method[@name='recursiveDelete' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("recursiveDelete", "(Ljava/io/File;)Z", "")]
		public static unsafe bool RecursiveDelete (global::Java.IO.File file)
		{
			const string __id = "recursiveDelete.(Ljava/io/File;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((file == null) ? IntPtr.Zero : ((global::Java.Lang.Object) file).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
