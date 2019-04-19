using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtLookup']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/DhtLookup", DoNotGenerateAcw=true)]
	public sealed partial class DhtLookup : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/DhtLookup", typeof (DhtLookup));
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

		internal DhtLookup (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtLookup']/constructor[@name='DhtLookup' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_lookup']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/dht_lookup;)V", "")]
		public unsafe DhtLookup (global::FrostWire.Libtorrent.Swig.Dht_lookup l)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/dht_lookup;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((l == null) ? IntPtr.Zero : ((global::Java.Lang.Object) l).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtLookup']/method[@name='branchFactor' and count(parameter)=0]"
		[Register ("branchFactor", "()I", "")]
		public unsafe int BranchFactor ()
		{
			const string __id = "branchFactor.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtLookup']/method[@name='firstTimeout' and count(parameter)=0]"
		[Register ("firstTimeout", "()I", "")]
		public unsafe int FirstTimeout ()
		{
			const string __id = "firstTimeout.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtLookup']/method[@name='lastSent' and count(parameter)=0]"
		[Register ("lastSent", "()I", "")]
		public unsafe int LastSent ()
		{
			const string __id = "lastSent.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtLookup']/method[@name='nodesLeft' and count(parameter)=0]"
		[Register ("nodesLeft", "()I", "")]
		public unsafe int NodesLeft ()
		{
			const string __id = "nodesLeft.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtLookup']/method[@name='outstandingRequests' and count(parameter)=0]"
		[Register ("outstandingRequests", "()I", "")]
		public unsafe int OutstandingRequests ()
		{
			const string __id = "outstandingRequests.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtLookup']/method[@name='responses' and count(parameter)=0]"
		[Register ("responses", "()I", "")]
		public unsafe int Responses ()
		{
			const string __id = "responses.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtLookup']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/dht_lookup;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Dht_lookup Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/dht_lookup;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_lookup> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtLookup']/method[@name='target' and count(parameter)=0]"
		[Register ("target", "()Lcom/frostwire/jlibtorrent/Sha1Hash;", "")]
		public unsafe global::FrostWire.Libtorrent.Sha1Hash Target ()
		{
			const string __id = "target.()Lcom/frostwire/jlibtorrent/Sha1Hash;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtLookup']/method[@name='timeouts' and count(parameter)=0]"
		[Register ("timeouts", "()I", "")]
		public unsafe int Timeouts ()
		{
			const string __id = "timeouts.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='DhtLookup']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Ljava/lang/String;", "")]
		public unsafe string Type ()
		{
			const string __id = "type.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
