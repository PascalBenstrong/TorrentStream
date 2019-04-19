using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BlockInfo']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/BlockInfo", DoNotGenerateAcw=true)]
	public sealed partial class BlockInfo : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BlockInfo.BlockState']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/BlockInfo$BlockState", DoNotGenerateAcw=true)]
		public sealed partial class BlockState : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BlockInfo.BlockState']/field[@name='FINISHED']"
			[Register ("FINISHED")]
			public static global::FrostWire.Libtorrent.BlockInfo.BlockState Finished {
				get {
					const string __id = "FINISHED.Lcom/frostwire/jlibtorrent/BlockInfo$BlockState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.BlockInfo.BlockState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BlockInfo.BlockState']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::FrostWire.Libtorrent.BlockInfo.BlockState None {
				get {
					const string __id = "NONE.Lcom/frostwire/jlibtorrent/BlockInfo$BlockState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.BlockInfo.BlockState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BlockInfo.BlockState']/field[@name='REQUESTED']"
			[Register ("REQUESTED")]
			public static global::FrostWire.Libtorrent.BlockInfo.BlockState Requested {
				get {
					const string __id = "REQUESTED.Lcom/frostwire/jlibtorrent/BlockInfo$BlockState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.BlockInfo.BlockState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BlockInfo.BlockState']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::FrostWire.Libtorrent.BlockInfo.BlockState Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/frostwire/jlibtorrent/BlockInfo$BlockState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.BlockInfo.BlockState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BlockInfo.BlockState']/field[@name='WRITING']"
			[Register ("WRITING")]
			public static global::FrostWire.Libtorrent.BlockInfo.BlockState Writing {
				get {
					const string __id = "WRITING.Lcom/frostwire/jlibtorrent/BlockInfo$BlockState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.BlockInfo.BlockState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/BlockInfo$BlockState", typeof (BlockState));
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

			internal BlockState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BlockInfo.BlockState']/method[@name='fromSwig' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromSwig", "(I)Lcom/frostwire/jlibtorrent/BlockInfo$BlockState;", "")]
			public static unsafe global::FrostWire.Libtorrent.BlockInfo.BlockState FromSwig (int swigValue)
			{
				const string __id = "fromSwig.(I)Lcom/frostwire/jlibtorrent/BlockInfo$BlockState;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.BlockInfo.BlockState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BlockInfo.BlockState']/method[@name='swig' and count(parameter)=0]"
			[Register ("swig", "()I", "")]
			public unsafe int Swig ()
			{
				const string __id = "swig.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BlockInfo.BlockState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/BlockInfo$BlockState;", "")]
			public static unsafe global::FrostWire.Libtorrent.BlockInfo.BlockState ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/BlockInfo$BlockState;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.BlockInfo.BlockState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BlockInfo.BlockState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/frostwire/jlibtorrent/BlockInfo$BlockState;", "")]
			public static unsafe global::FrostWire.Libtorrent.BlockInfo.BlockState[] Values ()
			{
				const string __id = "values.()[Lcom/frostwire/jlibtorrent/BlockInfo$BlockState;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::FrostWire.Libtorrent.BlockInfo.BlockState[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.BlockInfo.BlockState));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/BlockInfo", typeof (BlockInfo));
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

		internal BlockInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BlockInfo']/constructor[@name='BlockInfo' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.block_info']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/block_info;)V", "")]
		public unsafe BlockInfo (global::FrostWire.Libtorrent.Swig.Block_info b)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/block_info;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BlockInfo']/method[@name='blockSize' and count(parameter)=0]"
		[Register ("blockSize", "()I", "")]
		public unsafe int BlockSize ()
		{
			const string __id = "blockSize.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BlockInfo']/method[@name='bytesProgress' and count(parameter)=0]"
		[Register ("bytesProgress", "()I", "")]
		public unsafe int BytesProgress ()
		{
			const string __id = "bytesProgress.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BlockInfo']/method[@name='numPeers' and count(parameter)=0]"
		[Register ("numPeers", "()I", "")]
		public unsafe int NumPeers ()
		{
			const string __id = "numPeers.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BlockInfo']/method[@name='peer' and count(parameter)=0]"
		[Register ("peer", "()Lcom/frostwire/jlibtorrent/TcpEndpoint;", "")]
		public unsafe global::FrostWire.Libtorrent.TcpEndpoint Peer ()
		{
			const string __id = "peer.()Lcom/frostwire/jlibtorrent/TcpEndpoint;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TcpEndpoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BlockInfo']/method[@name='state' and count(parameter)=0]"
		[Register ("state", "()Lcom/frostwire/jlibtorrent/BlockInfo$BlockState;", "")]
		public unsafe global::FrostWire.Libtorrent.BlockInfo.BlockState State ()
		{
			const string __id = "state.()Lcom/frostwire/jlibtorrent/BlockInfo$BlockState;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.BlockInfo.BlockState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='BlockInfo']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/block_info;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Block_info Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/block_info;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Block_info> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
