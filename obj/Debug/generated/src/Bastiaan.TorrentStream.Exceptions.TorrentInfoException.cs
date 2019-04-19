using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Bastiaan.TorrentStream.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.exceptions']/class[@name='TorrentInfoException']"
	[global::Android.Runtime.Register ("com/github/se_bastiaan/torrentstream/exceptions/TorrentInfoException", DoNotGenerateAcw=true)]
	public partial class TorrentInfoException : global::Java.Lang.Exception {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/se_bastiaan/torrentstream/exceptions/TorrentInfoException", typeof (TorrentInfoException));
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

		protected TorrentInfoException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream.exceptions']/class[@name='TorrentInfoException']/constructor[@name='TorrentInfoException' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/Throwable;)V", "")]
		public unsafe TorrentInfoException (global::Java.Lang.Throwable cause)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
