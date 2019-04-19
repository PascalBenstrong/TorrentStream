using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='LibTorrent']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/LibTorrent", DoNotGenerateAcw=true)]
	public sealed partial class LibTorrent : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/LibTorrent", typeof (LibTorrent));
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

		internal LibTorrent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe bool HasArmNeonSupport {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='LibTorrent']/method[@name='hasArmNeonSupport' and count(parameter)=0]"
			[Register ("hasArmNeonSupport", "()Z", "GetHasArmNeonSupportHandler")]
			get {
				const string __id = "hasArmNeonSupport.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='LibTorrent']/method[@name='boostVersion' and count(parameter)=0]"
		[Register ("boostVersion", "()Ljava/lang/String;", "")]
		public static unsafe string BoostVersion ()
		{
			const string __id = "boostVersion.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='LibTorrent']/method[@name='boostVersionNum' and count(parameter)=0]"
		[Register ("boostVersionNum", "()I", "")]
		public static unsafe int BoostVersionNum ()
		{
			const string __id = "boostVersionNum.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='LibTorrent']/method[@name='findMetricIdx' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("findMetricIdx", "(Ljava/lang/String;)I", "")]
		public static unsafe int FindMetricIdx (string name)
		{
			const string __id = "findMetricIdx.(Ljava/lang/String;)I";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='LibTorrent']/method[@name='jlibtorrentVersion' and count(parameter)=0]"
		[Register ("jlibtorrentVersion", "()Ljava/lang/String;", "")]
		public static unsafe string JlibtorrentVersion ()
		{
			const string __id = "jlibtorrentVersion.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='LibTorrent']/method[@name='opensslVersion' and count(parameter)=0]"
		[Register ("opensslVersion", "()Ljava/lang/String;", "")]
		public static unsafe string OpensslVersion ()
		{
			const string __id = "opensslVersion.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='LibTorrent']/method[@name='opensslVersionNum' and count(parameter)=0]"
		[Register ("opensslVersionNum", "()I", "")]
		public static unsafe int OpensslVersionNum ()
		{
			const string __id = "opensslVersionNum.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='LibTorrent']/method[@name='revision' and count(parameter)=0]"
		[Register ("revision", "()Ljava/lang/String;", "")]
		public static unsafe string Revision ()
		{
			const string __id = "revision.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='LibTorrent']/method[@name='sessionStatsMetrics' and count(parameter)=0]"
		[Register ("sessionStatsMetrics", "()Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.StatsMetric> SessionStatsMetrics ()
		{
			const string __id = "sessionStatsMetrics.()Ljava/util/List;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.StatsMetric>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='LibTorrent']/method[@name='version' and count(parameter)=0]"
		[Register ("version", "()Ljava/lang/String;", "")]
		public static unsafe string Version ()
		{
			const string __id = "version.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='LibTorrent']/method[@name='versionNum' and count(parameter)=0]"
		[Register ("versionNum", "()I", "")]
		public static unsafe int VersionNum ()
		{
			const string __id = "versionNum.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

	}
}
