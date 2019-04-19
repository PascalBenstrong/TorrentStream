using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Sha1Hash']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/Sha1Hash", DoNotGenerateAcw=true)]
	public sealed partial class Sha1Hash : global::Java.Lang.Object, global::Java.Lang.ICloneable, global::Java.Lang.IComparable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/Sha1Hash", typeof (Sha1Hash));
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

		internal Sha1Hash (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Sha1Hash']/constructor[@name='Sha1Hash' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Sha1Hash ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Sha1Hash']/constructor[@name='Sha1Hash' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe Sha1Hash (byte[] bytes)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([B)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Sha1Hash']/constructor[@name='Sha1Hash' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.sha1_hash']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V", "")]
		public unsafe Sha1Hash (global::FrostWire.Libtorrent.Swig.Sha1_hash h)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/sha1_hash;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((h == null) ? IntPtr.Zero : ((global::Java.Lang.Object) h).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Sha1Hash']/constructor[@name='Sha1Hash' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Sha1Hash (string hex)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_hex = JNIEnv.NewString (hex);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hex);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_hex);
			}
		}

		public unsafe bool IsAllZeros {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Sha1Hash']/method[@name='isAllZeros' and count(parameter)=0]"
			[Register ("isAllZeros", "()Z", "GetIsAllZerosHandler")]
			get {
				const string __id = "isAllZeros.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Sha1Hash']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Sha1Hash']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/frostwire/jlibtorrent/Sha1Hash;", "")]
		public unsafe global::FrostWire.Libtorrent.Sha1Hash Clone ()
		{
			const string __id = "clone.()Lcom/frostwire/jlibtorrent/Sha1Hash;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Sha1Hash']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Sha1Hash']]"
		[Register ("compareTo", "(Lcom/frostwire/jlibtorrent/Sha1Hash;)I", "")]
		public unsafe int CompareTo (global::FrostWire.Libtorrent.Sha1Hash o)
		{
			const string __id = "compareTo.(Lcom/frostwire/jlibtorrent/Sha1Hash;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Sha1Hash']/method[@name='countLeadingZeroes' and count(parameter)=0]"
		[Register ("countLeadingZeroes", "()I", "")]
		public unsafe int CountLeadingZeroes ()
		{
			const string __id = "countLeadingZeroes.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Sha1Hash']/method[@name='max' and count(parameter)=0]"
		[Register ("max", "()Lcom/frostwire/jlibtorrent/Sha1Hash;", "")]
		public static unsafe global::FrostWire.Libtorrent.Sha1Hash Max ()
		{
			const string __id = "max.()Lcom/frostwire/jlibtorrent/Sha1Hash;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Sha1Hash']/method[@name='min' and count(parameter)=0]"
		[Register ("min", "()Lcom/frostwire/jlibtorrent/Sha1Hash;", "")]
		public static unsafe global::FrostWire.Libtorrent.Sha1Hash Min ()
		{
			const string __id = "min.()Lcom/frostwire/jlibtorrent/Sha1Hash;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Sha1Hash']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/sha1_hash;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Sha1_hash Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/sha1_hash;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Sha1_hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Sha1Hash']/method[@name='toHex' and count(parameter)=0]"
		[Register ("toHex", "()Ljava/lang/String;", "")]
		public unsafe string ToHex ()
		{
			const string __id = "toHex.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Sha1Hash']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("compareTo", "(Ljava/lang/Object;)I", "")]
		public unsafe int CompareTo (global::Java.Lang.Object @object)
		{
			const string __id = "compareTo.(Ljava/lang/Object;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
