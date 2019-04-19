using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtSampleInfohashesAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/DhtSampleInfohashesAlert", DoNotGenerateAcw=true)]
	public sealed partial class DhtSampleInfohashesAlert : global::FrostWire.Libtorrent.Alerts.AbstractAlert {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/DhtSampleInfohashesAlert", typeof (DhtSampleInfohashesAlert));
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

		internal DhtSampleInfohashesAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtSampleInfohashesAlert']/method[@name='endpoint' and count(parameter)=0]"
		[Register ("endpoint", "()Lcom/frostwire/jlibtorrent/UdpEndpoint;", "")]
		public unsafe global::FrostWire.Libtorrent.UdpEndpoint Endpoint ()
		{
			const string __id = "endpoint.()Lcom/frostwire/jlibtorrent/UdpEndpoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.UdpEndpoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtSampleInfohashesAlert']/method[@name='interval' and count(parameter)=0]"
		[Register ("interval", "()J", "")]
		public unsafe long Interval ()
		{
			const string __id = "interval.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtSampleInfohashesAlert']/method[@name='nodes' and count(parameter)=0]"
		[Register ("nodes", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Pair> Nodes ()
		{
			const string __id = "nodes.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Pair>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtSampleInfohashesAlert']/method[@name='numInfohashes' and count(parameter)=0]"
		[Register ("numInfohashes", "()I", "")]
		public unsafe int NumInfohashes ()
		{
			const string __id = "numInfohashes.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtSampleInfohashesAlert']/method[@name='numNodes' and count(parameter)=0]"
		[Register ("numNodes", "()I", "")]
		public unsafe int NumNodes ()
		{
			const string __id = "numNodes.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtSampleInfohashesAlert']/method[@name='numSamples' and count(parameter)=0]"
		[Register ("numSamples", "()I", "")]
		public unsafe int NumSamples ()
		{
			const string __id = "numSamples.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='DhtSampleInfohashesAlert']/method[@name='samples' and count(parameter)=0]"
		[Register ("samples", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Sha1Hash> Samples ()
		{
			const string __id = "samples.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Sha1Hash>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
