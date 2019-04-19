using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='EnumNet']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/EnumNet", DoNotGenerateAcw=true)]
	public sealed partial class EnumNet : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='EnumNet.IpInterface']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/EnumNet$IpInterface", DoNotGenerateAcw=true)]
		public sealed partial class IpInterface : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/EnumNet$IpInterface", typeof (IpInterface));
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

			internal IpInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='EnumNet.IpInterface']/method[@name='description' and count(parameter)=0]"
			[Register ("description", "()Ljava/lang/String;", "")]
			public unsafe string Description ()
			{
				const string __id = "description.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='EnumNet.IpInterface']/method[@name='friendlyName' and count(parameter)=0]"
			[Register ("friendlyName", "()Ljava/lang/String;", "")]
			public unsafe string FriendlyName ()
			{
				const string __id = "friendlyName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='EnumNet.IpInterface']/method[@name='interfaceAddress' and count(parameter)=0]"
			[Register ("interfaceAddress", "()Lcom/frostwire/jlibtorrent/Address;", "")]
			public unsafe global::FrostWire.Libtorrent.Address InterfaceAddress ()
			{
				const string __id = "interfaceAddress.()Lcom/frostwire/jlibtorrent/Address;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='EnumNet.IpInterface']/method[@name='name' and count(parameter)=0]"
			[Register ("name", "()Ljava/lang/String;", "")]
			public unsafe string Name ()
			{
				const string __id = "name.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='EnumNet.IpInterface']/method[@name='netmask' and count(parameter)=0]"
			[Register ("netmask", "()Lcom/frostwire/jlibtorrent/Address;", "")]
			public unsafe global::FrostWire.Libtorrent.Address Netmask ()
			{
				const string __id = "netmask.()Lcom/frostwire/jlibtorrent/Address;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='EnumNet.IpInterface']/method[@name='preferred' and count(parameter)=0]"
			[Register ("preferred", "()Z", "")]
			public unsafe bool Preferred ()
			{
				const string __id = "preferred.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='EnumNet.IpRoute']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/EnumNet$IpRoute", DoNotGenerateAcw=true)]
		public sealed partial class IpRoute : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/EnumNet$IpRoute", typeof (IpRoute));
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

			internal IpRoute (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='EnumNet.IpRoute']/method[@name='destination' and count(parameter)=0]"
			[Register ("destination", "()Lcom/frostwire/jlibtorrent/Address;", "")]
			public unsafe global::FrostWire.Libtorrent.Address Destination ()
			{
				const string __id = "destination.()Lcom/frostwire/jlibtorrent/Address;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='EnumNet.IpRoute']/method[@name='gateway' and count(parameter)=0]"
			[Register ("gateway", "()Lcom/frostwire/jlibtorrent/Address;", "")]
			public unsafe global::FrostWire.Libtorrent.Address Gateway ()
			{
				const string __id = "gateway.()Lcom/frostwire/jlibtorrent/Address;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='EnumNet.IpRoute']/method[@name='mtu' and count(parameter)=0]"
			[Register ("mtu", "()I", "")]
			public unsafe int Mtu ()
			{
				const string __id = "mtu.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='EnumNet.IpRoute']/method[@name='name' and count(parameter)=0]"
			[Register ("name", "()Ljava/lang/String;", "")]
			public unsafe string Name ()
			{
				const string __id = "name.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='EnumNet.IpRoute']/method[@name='netmask' and count(parameter)=0]"
			[Register ("netmask", "()Lcom/frostwire/jlibtorrent/Address;", "")]
			public unsafe global::FrostWire.Libtorrent.Address Netmask ()
			{
				const string __id = "netmask.()Lcom/frostwire/jlibtorrent/Address;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/EnumNet", typeof (EnumNet));
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

		internal EnumNet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='EnumNet']/method[@name='defaultGateway' and count(parameter)=3 and parameter[1][@type='com.frostwire.jlibtorrent.SessionManager'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("defaultGateway", "(Lcom/frostwire/jlibtorrent/SessionManager;Ljava/lang/String;Z)Lcom/frostwire/jlibtorrent/Address;", "")]
		public static unsafe global::FrostWire.Libtorrent.Address DefaultGateway (global::FrostWire.Libtorrent.SessionManager session, string device, bool v6)
		{
			const string __id = "defaultGateway.(Lcom/frostwire/jlibtorrent/SessionManager;Ljava/lang/String;Z)Lcom/frostwire/jlibtorrent/Address;";
			IntPtr native_device = JNIEnv.NewString (device);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((session == null) ? IntPtr.Zero : ((global::Java.Lang.Object) session).Handle);
				__args [1] = new JniArgumentValue (native_device);
				__args [2] = new JniArgumentValue (v6);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_device);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='EnumNet']/method[@name='enumInterfaces' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.SessionManager']]"
		[Register ("enumInterfaces", "(Lcom/frostwire/jlibtorrent/SessionManager;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.EnumNet.IpInterface> EnumInterfaces (global::FrostWire.Libtorrent.SessionManager session)
		{
			const string __id = "enumInterfaces.(Lcom/frostwire/jlibtorrent/SessionManager;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((session == null) ? IntPtr.Zero : ((global::Java.Lang.Object) session).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.EnumNet.IpInterface>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='EnumNet']/method[@name='enumRoutes' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.SessionManager']]"
		[Register ("enumRoutes", "(Lcom/frostwire/jlibtorrent/SessionManager;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.EnumNet.IpRoute> EnumRoutes (global::FrostWire.Libtorrent.SessionManager session)
		{
			const string __id = "enumRoutes.(Lcom/frostwire/jlibtorrent/SessionManager;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((session == null) ? IntPtr.Zero : ((global::Java.Lang.Object) session).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.EnumNet.IpRoute>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
