using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BDecodeNode']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/BDecodeNode", DoNotGenerateAcw=true)]
	public sealed partial class BDecodeNode : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/BDecodeNode", typeof (BDecodeNode));
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

		internal BDecodeNode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BDecodeNode']/constructor[@name='BDecodeNode' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.bdecode_node']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/bdecode_node;)V", "")]
		public unsafe BDecodeNode (global::FrostWire.Libtorrent.Swig.Bdecode_node n)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/bdecode_node;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((n == null) ? IntPtr.Zero : ((global::Java.Lang.Object) n).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BDecodeNode']/constructor[@name='BDecodeNode' and count(parameter)=2 and parameter[1][@type='com.frostwire.jlibtorrent.swig.bdecode_node'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/bdecode_node;Lcom/frostwire/jlibtorrent/swig/byte_vector;)V", "")]
		public unsafe BDecodeNode (global::FrostWire.Libtorrent.Swig.Bdecode_node n, global::FrostWire.Libtorrent.Swig.Byte_vector buffer)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/bdecode_node;Lcom/frostwire/jlibtorrent/swig/byte_vector;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((n == null) ? IntPtr.Zero : ((global::Java.Lang.Object) n).Handle);
				__args [1] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BDecodeNode']/method[@name='bdecode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("bdecode", "([B)Lcom/frostwire/jlibtorrent/BDecodeNode;", "")]
		public static unsafe global::FrostWire.Libtorrent.BDecodeNode Bdecode (byte[] data)
		{
			const string __id = "bdecode.([B)Lcom/frostwire/jlibtorrent/BDecodeNode;";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.BDecodeNode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BDecodeNode']/method[@name='buffer' and count(parameter)=0]"
		[Register ("buffer", "()Lcom/frostwire/jlibtorrent/swig/byte_vector;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Buffer ()
		{
			const string __id = "buffer.()Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BDecodeNode']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/bdecode_node;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Bdecode_node Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/bdecode_node;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Bdecode_node> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
