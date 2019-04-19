using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionStats']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/SessionStats", DoNotGenerateAcw=true)]
	public sealed partial class SessionStats : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/SessionStats", typeof (SessionStats));
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

		internal SessionStats (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionStats']/method[@name='dhtNodes' and count(parameter)=0]"
		[Register ("dhtNodes", "()J", "")]
		public unsafe long DhtNodes ()
		{
			const string __id = "dhtNodes.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionStats']/method[@name='downloadRate' and count(parameter)=0]"
		[Register ("downloadRate", "()J", "")]
		public unsafe long DownloadRate ()
		{
			const string __id = "downloadRate.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionStats']/method[@name='totalDownload' and count(parameter)=0]"
		[Register ("totalDownload", "()J", "")]
		public unsafe long TotalDownload ()
		{
			const string __id = "totalDownload.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionStats']/method[@name='totalUpload' and count(parameter)=0]"
		[Register ("totalUpload", "()J", "")]
		public unsafe long TotalUpload ()
		{
			const string __id = "totalUpload.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='SessionStats']/method[@name='uploadRate' and count(parameter)=0]"
		[Register ("uploadRate", "()J", "")]
		public unsafe long UploadRate ()
		{
			const string __id = "uploadRate.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
