using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtRoutingBucket']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/DhtRoutingBucket", DoNotGenerateAcw=true)]
	public sealed partial class DhtRoutingBucket : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/DhtRoutingBucket", typeof (DhtRoutingBucket));
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

		internal DhtRoutingBucket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtRoutingBucket']/constructor[@name='DhtRoutingBucket' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_routing_bucket']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/dht_routing_bucket;)V", "")]
		public unsafe DhtRoutingBucket (global::FrostWire.Libtorrent.Swig.Dht_routing_bucket t)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/dht_routing_bucket;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Object) t).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtRoutingBucket']/method[@name='lastActive' and count(parameter)=0]"
		[Register ("lastActive", "()I", "")]
		public unsafe int LastActive ()
		{
			const string __id = "lastActive.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtRoutingBucket']/method[@name='numNodes' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtRoutingBucket']/method[@name='numReplacements' and count(parameter)=0]"
		[Register ("numReplacements", "()I", "")]
		public unsafe int NumReplacements ()
		{
			const string __id = "numReplacements.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtRoutingBucket']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/dht_routing_bucket;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Dht_routing_bucket Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/dht_routing_bucket;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_routing_bucket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
