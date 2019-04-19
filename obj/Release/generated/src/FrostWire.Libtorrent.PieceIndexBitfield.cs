using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/PieceIndexBitfield", DoNotGenerateAcw=true)]
	public sealed partial class PieceIndexBitfield : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/PieceIndexBitfield", typeof (PieceIndexBitfield));
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

		internal PieceIndexBitfield (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/constructor[@name='PieceIndexBitfield' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.piece_index_bitfield']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;)V", "")]
		public unsafe PieceIndexBitfield (global::FrostWire.Libtorrent.Swig.Piece_index_bitfield f)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe bool IsAllSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/method[@name='isAllSet' and count(parameter)=0]"
			[Register ("isAllSet", "()Z", "GetIsAllSetHandler")]
			get {
				const string __id = "isAllSet.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				const string __id = "isEmpty.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsNoneSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/method[@name='isNoneSet' and count(parameter)=0]"
			[Register ("isNoneSet", "()Z", "GetIsNoneSetHandler")]
			get {
				const string __id = "isNoneSet.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/method[@name='clearAll' and count(parameter)=0]"
		[Register ("clearAll", "()V", "")]
		public unsafe void ClearAll ()
		{
			const string __id = "clearAll.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/method[@name='clearBit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("clearBit", "(I)V", "")]
		public unsafe void ClearBit (int index)
		{
			const string __id = "clearBit.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/method[@name='count' and count(parameter)=0]"
		[Register ("count", "()I", "")]
		public unsafe int Count ()
		{
			const string __id = "count.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/method[@name='endIndex' and count(parameter)=0]"
		[Register ("endIndex", "()I", "")]
		public unsafe int EndIndex ()
		{
			const string __id = "endIndex.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/method[@name='findFirstSet' and count(parameter)=0]"
		[Register ("findFirstSet", "()I", "")]
		public unsafe int FindFirstSet ()
		{
			const string __id = "findFirstSet.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/method[@name='findLastClear' and count(parameter)=0]"
		[Register ("findLastClear", "()I", "")]
		public unsafe int FindLastClear ()
		{
			const string __id = "findLastClear.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/method[@name='getBit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBit", "(I)Z", "")]
		public unsafe bool GetBit (int index)
		{
			const string __id = "getBit.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/method[@name='resize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("resize", "(I)V", "")]
		public unsafe void Resize (int bits)
		{
			const string __id = "resize.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bits);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/method[@name='resize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("resize", "(IZ)V", "")]
		public unsafe void Resize (int bits, bool val)
		{
			const string __id = "resize.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (bits);
				__args [1] = new JniArgumentValue (val);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/method[@name='setAll' and count(parameter)=0]"
		[Register ("setAll", "()V", "")]
		public unsafe void SetAll ()
		{
			const string __id = "setAll.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/method[@name='setBit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBit", "(I)V", "")]
		public unsafe void SetBit (int index)
		{
			const string __id = "setBit.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "")]
		public unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Piece_index_bitfield Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/piece_index_bitfield;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Piece_index_bitfield> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='PieceIndexBitfield']/method[@name='ts' and count(parameter)=0]"
		[Register ("ts", "()Lcom/frostwire/jlibtorrent/swig/torrent_status;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Torrent_status Ts ()
		{
			const string __id = "ts.()Lcom/frostwire/jlibtorrent/swig/torrent_status;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_status> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
