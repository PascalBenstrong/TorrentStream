using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PiecesTracker']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/PiecesTracker", DoNotGenerateAcw=true)]
	public sealed partial class PiecesTracker : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/PiecesTracker", typeof (PiecesTracker));
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

		internal PiecesTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PiecesTracker']/constructor[@name='PiecesTracker' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.TorrentInfo']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/TorrentInfo;)V", "")]
		public unsafe PiecesTracker (global::FrostWire.Libtorrent.TorrentInfo ti)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/TorrentInfo;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((ti == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ti).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PiecesTracker']/method[@name='getSequentialDownloadedBytes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSequentialDownloadedBytes", "(I)J", "")]
		public unsafe long GetSequentialDownloadedBytes (int fileIndex)
		{
			const string __id = "getSequentialDownloadedBytes.(I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (fileIndex);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PiecesTracker']/method[@name='getSequentialDownloadedPieces' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSequentialDownloadedPieces", "(I)I", "")]
		public unsafe int GetSequentialDownloadedPieces (int fileIndex)
		{
			const string __id = "getSequentialDownloadedPieces.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (fileIndex);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PiecesTracker']/method[@name='isComplete' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isComplete", "(I)Z", "")]
		public unsafe bool IsComplete (int pieceIndex)
		{
			const string __id = "isComplete.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pieceIndex);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PiecesTracker']/method[@name='numFiles' and count(parameter)=0]"
		[Register ("numFiles", "()I", "")]
		public unsafe int NumFiles ()
		{
			const string __id = "numFiles.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PiecesTracker']/method[@name='numPieces' and count(parameter)=0]"
		[Register ("numPieces", "()I", "")]
		public unsafe int NumPieces ()
		{
			const string __id = "numPieces.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PiecesTracker']/method[@name='setComplete' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setComplete", "(IZ)V", "")]
		public unsafe void SetComplete (int pieceIndex, bool complete)
		{
			const string __id = "setComplete.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (pieceIndex);
				__args [1] = new JniArgumentValue (complete);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
