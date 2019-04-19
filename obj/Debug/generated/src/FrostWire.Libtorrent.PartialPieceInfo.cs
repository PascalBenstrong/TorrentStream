using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PartialPieceInfo']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/PartialPieceInfo", DoNotGenerateAcw=true)]
	public sealed partial class PartialPieceInfo : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/PartialPieceInfo", typeof (PartialPieceInfo));
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

		internal PartialPieceInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PartialPieceInfo']/constructor[@name='PartialPieceInfo' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.partial_piece_info']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/partial_piece_info;)V", "")]
		public unsafe PartialPieceInfo (global::FrostWire.Libtorrent.Swig.Partial_piece_info p)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/partial_piece_info;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PartialPieceInfo']/method[@name='blocksInPiece' and count(parameter)=0]"
		[Register ("blocksInPiece", "()I", "")]
		public unsafe int BlocksInPiece ()
		{
			const string __id = "blocksInPiece.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PartialPieceInfo']/method[@name='finished' and count(parameter)=0]"
		[Register ("finished", "()I", "")]
		public unsafe int Finished ()
		{
			const string __id = "finished.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PartialPieceInfo']/method[@name='pieceIndex' and count(parameter)=0]"
		[Register ("pieceIndex", "()I", "")]
		public unsafe int PieceIndex ()
		{
			const string __id = "pieceIndex.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PartialPieceInfo']/method[@name='requested' and count(parameter)=0]"
		[Register ("requested", "()I", "")]
		public unsafe int Requested ()
		{
			const string __id = "requested.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PartialPieceInfo']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/partial_piece_info;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Partial_piece_info Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/partial_piece_info;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Partial_piece_info> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PartialPieceInfo']/method[@name='writing' and count(parameter)=0]"
		[Register ("writing", "()I", "")]
		public unsafe int Writing ()
		{
			const string __id = "writing.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
