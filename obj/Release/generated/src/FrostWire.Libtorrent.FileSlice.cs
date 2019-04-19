using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileSlice']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/FileSlice", DoNotGenerateAcw=true)]
	public sealed partial class FileSlice : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/FileSlice", typeof (FileSlice));
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

		internal FileSlice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileSlice']/constructor[@name='FileSlice' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.file_slice']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/file_slice;)V", "")]
		public unsafe FileSlice (global::FrostWire.Libtorrent.Swig.File_slice fs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/file_slice;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileSlice']/method[@name='fileIndex' and count(parameter)=0]"
		[Register ("fileIndex", "()I", "")]
		public unsafe int FileIndex ()
		{
			const string __id = "fileIndex.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileSlice']/method[@name='offset' and count(parameter)=0]"
		[Register ("offset", "()J", "")]
		public unsafe long Offset ()
		{
			const string __id = "offset.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileSlice']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()J", "")]
		public unsafe long Size ()
		{
			const string __id = "size.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
