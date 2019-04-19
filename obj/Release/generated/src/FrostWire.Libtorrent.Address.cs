using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Address']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/Address", DoNotGenerateAcw=true)]
	public sealed partial class Address : global::Java.Lang.Object, global::Java.Lang.ICloneable, global::Java.Lang.IComparable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/Address", typeof (Address));
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

		internal Address (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Address']/constructor[@name='Address' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Address ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Address']/constructor[@name='Address' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.address']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/address;)V", "")]
		public unsafe Address (global::FrostWire.Libtorrent.Swig.Address addr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/address;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((addr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) addr).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Address']/constructor[@name='Address' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Address (string ip)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_ip = JNIEnv.NewString (ip);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_ip);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_ip);
			}
		}

		public unsafe bool IsLoopback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Address']/method[@name='isLoopback' and count(parameter)=0]"
			[Register ("isLoopback", "()Z", "GetIsLoopbackHandler")]
			get {
				const string __id = "isLoopback.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsMulticast {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Address']/method[@name='isMulticast' and count(parameter)=0]"
			[Register ("isMulticast", "()Z", "GetIsMulticastHandler")]
			get {
				const string __id = "isMulticast.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsUnspecified {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Address']/method[@name='isUnspecified' and count(parameter)=0]"
			[Register ("isUnspecified", "()Z", "GetIsUnspecifiedHandler")]
			get {
				const string __id = "isUnspecified.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsV4 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Address']/method[@name='isV4' and count(parameter)=0]"
			[Register ("isV4", "()Z", "GetIsV4Handler")]
			get {
				const string __id = "isV4.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsV6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Address']/method[@name='isV6' and count(parameter)=0]"
			[Register ("isV6", "()Z", "GetIsV6Handler")]
			get {
				const string __id = "isV6.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Address']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/frostwire/jlibtorrent/Address;", "")]
		public unsafe global::FrostWire.Libtorrent.Address Clone ()
		{
			const string __id = "clone.()Lcom/frostwire/jlibtorrent/Address;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Address']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Address']]"
		[Register ("compareTo", "(Lcom/frostwire/jlibtorrent/Address;)I", "")]
		public unsafe int CompareTo (global::FrostWire.Libtorrent.Address o)
		{
			const string __id = "compareTo.(Lcom/frostwire/jlibtorrent/Address;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Address']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/address;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Address Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/address;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Address']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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
