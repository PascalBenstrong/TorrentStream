using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Bastiaan.TorrentStream.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.utils']/class[@name='ThreadUtils']"
	[global::Android.Runtime.Register ("com/github/se_bastiaan/torrentstream/utils/ThreadUtils", DoNotGenerateAcw=true)]
	public sealed partial class ThreadUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/se_bastiaan/torrentstream/utils/ThreadUtils", typeof (ThreadUtils));
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

		internal ThreadUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.utils']/class[@name='ThreadUtils']/method[@name='runOnUiThread' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("runOnUiThread", "(Ljava/lang/Runnable;)V", "")]
		public static unsafe void RunOnUiThread (global::Java.Lang.IRunnable runnable)
		{
			const string __id = "runOnUiThread.(Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((runnable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) runnable).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
