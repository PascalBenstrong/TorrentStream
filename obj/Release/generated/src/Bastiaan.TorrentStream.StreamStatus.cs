using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Bastiaan.TorrentStream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='StreamStatus']"
	[global::Android.Runtime.Register ("com/github/se_bastiaan/torrentstream/StreamStatus", DoNotGenerateAcw=true)]
	public partial class StreamStatus : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='StreamStatus']/field[@name='bufferProgress']"
		[Register ("bufferProgress")]
		public int BufferProgress {
			get {
				const string __id = "bufferProgress.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "bufferProgress.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='StreamStatus']/field[@name='downloadSpeed']"
		[Register ("downloadSpeed")]
		public float DownloadSpeed {
			get {
				const string __id = "downloadSpeed.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "downloadSpeed.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='StreamStatus']/field[@name='progress']"
		[Register ("progress")]
		public float Progress {
			get {
				const string __id = "progress.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "progress.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.se_bastiaan.torrentstream']/class[@name='StreamStatus']/field[@name='seeds']"
		[Register ("seeds")]
		public int Seeds {
			get {
				const string __id = "seeds.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "seeds.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/se_bastiaan/torrentstream/StreamStatus", typeof (StreamStatus));
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

		protected StreamStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
