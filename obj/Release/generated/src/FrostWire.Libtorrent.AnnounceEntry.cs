using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEntry']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/AnnounceEntry", DoNotGenerateAcw=true)]
	public sealed partial class AnnounceEntry : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/AnnounceEntry", typeof (AnnounceEntry));
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

		internal AnnounceEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEntry']/constructor[@name='AnnounceEntry' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.announce_entry']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/announce_entry;)V", "")]
		public unsafe AnnounceEntry (global::FrostWire.Libtorrent.Swig.Announce_entry e)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/announce_entry;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEntry']/constructor[@name='AnnounceEntry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe AnnounceEntry (string url)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		public unsafe bool IsVerified {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEntry']/method[@name='isVerified' and count(parameter)=0]"
			[Register ("isVerified", "()Z", "GetIsVerifiedHandler")]
			get {
				const string __id = "isVerified.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEntry']/method[@name='endpoints' and count(parameter)=0]"
		[Register ("endpoints", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.AnnounceEndpoint> Endpoints ()
		{
			const string __id = "endpoints.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.AnnounceEndpoint>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEntry']/method[@name='failLimit' and count(parameter)=0]"
		[Register ("failLimit", "()I", "")]
		public unsafe int FailLimit ()
		{
			const string __id = "failLimit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEntry']/method[@name='failLimit' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("failLimit", "(S)V", "")]
		public unsafe void FailLimit (short value)
		{
			const string __id = "failLimit.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEntry']/method[@name='source' and count(parameter)=0]"
		[Register ("source", "()I", "")]
		public unsafe int Source ()
		{
			const string __id = "source.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEntry']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/announce_entry;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Announce_entry Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/announce_entry;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEntry']/method[@name='tier' and count(parameter)=0]"
		[Register ("tier", "()I", "")]
		public unsafe int Tier ()
		{
			const string __id = "tier.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEntry']/method[@name='tier' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("tier", "(S)V", "")]
		public unsafe void Tier (short value)
		{
			const string __id = "tier.(S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEntry']/method[@name='trackerId' and count(parameter)=0]"
		[Register ("trackerId", "()Ljava/lang/String;", "")]
		public unsafe string TrackerId ()
		{
			const string __id = "trackerId.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEntry']/method[@name='trackerId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("trackerId", "(Ljava/lang/String;)V", "")]
		public unsafe void TrackerId (string value)
		{
			const string __id = "trackerId.(Ljava/lang/String;)V";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEntry']/method[@name='url' and count(parameter)=0]"
		[Register ("url", "()Ljava/lang/String;", "")]
		public unsafe string Url ()
		{
			const string __id = "url.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='AnnounceEntry']/method[@name='url' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("url", "(Ljava/lang/String;)V", "")]
		public unsafe void Url (string value)
		{
			const string __id = "url.(Ljava/lang/String;)V";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
