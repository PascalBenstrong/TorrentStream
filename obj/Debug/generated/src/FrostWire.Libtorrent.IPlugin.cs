using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.frostwire.jlibtorrent']/interface[@name='Plugin']"
	[Register ("com/frostwire/jlibtorrent/Plugin", "", "FrostWire.Libtorrent.IPluginInvoker")]
	public partial interface IPlugin : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/interface[@name='Plugin']/method[@name='onDhtRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.frostwire.jlibtorrent.UdpEndpoint'] and parameter[3][@type='com.frostwire.jlibtorrent.BDecodeNode'] and parameter[4][@type='com.frostwire.jlibtorrent.Entry']]"
		[Register ("onDhtRequest", "(Ljava/lang/String;Lcom/frostwire/jlibtorrent/UdpEndpoint;Lcom/frostwire/jlibtorrent/BDecodeNode;Lcom/frostwire/jlibtorrent/Entry;)Z", "GetOnDhtRequest_Ljava_lang_String_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_BDecodeNode_Lcom_frostwire_jlibtorrent_Entry_Handler:FrostWire.Libtorrent.IPluginInvoker, TorrentStream")]
		bool OnDhtRequest (string p0, global::FrostWire.Libtorrent.UdpEndpoint p1, global::FrostWire.Libtorrent.BDecodeNode p2, global::FrostWire.Libtorrent.Entry p3);

	}

	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/Plugin", DoNotGenerateAcw=true)]
	internal class IPluginInvoker : global::Java.Lang.Object, IPlugin {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/frostwire/jlibtorrent/Plugin", typeof (IPluginInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IPlugin GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPlugin> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.frostwire.jlibtorrent.Plugin"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPluginInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDhtRequest_Ljava_lang_String_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_BDecodeNode_Lcom_frostwire_jlibtorrent_Entry_;
#pragma warning disable 0169
		static Delegate GetOnDhtRequest_Ljava_lang_String_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_BDecodeNode_Lcom_frostwire_jlibtorrent_Entry_Handler ()
		{
			if (cb_onDhtRequest_Ljava_lang_String_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_BDecodeNode_Lcom_frostwire_jlibtorrent_Entry_ == null)
				cb_onDhtRequest_Ljava_lang_String_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_BDecodeNode_Lcom_frostwire_jlibtorrent_Entry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnDhtRequest_Ljava_lang_String_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_BDecodeNode_Lcom_frostwire_jlibtorrent_Entry_);
			return cb_onDhtRequest_Ljava_lang_String_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_BDecodeNode_Lcom_frostwire_jlibtorrent_Entry_;
		}

		static bool n_OnDhtRequest_Ljava_lang_String_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_BDecodeNode_Lcom_frostwire_jlibtorrent_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::FrostWire.Libtorrent.IPlugin __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.IPlugin> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.UdpEndpoint p1 = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.UdpEndpoint> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.BDecodeNode p2 = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.BDecodeNode> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Entry p3 = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Entry> (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnDhtRequest (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onDhtRequest_Ljava_lang_String_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_BDecodeNode_Lcom_frostwire_jlibtorrent_Entry_;
		public unsafe bool OnDhtRequest (string p0, global::FrostWire.Libtorrent.UdpEndpoint p1, global::FrostWire.Libtorrent.BDecodeNode p2, global::FrostWire.Libtorrent.Entry p3)
		{
			if (id_onDhtRequest_Ljava_lang_String_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_BDecodeNode_Lcom_frostwire_jlibtorrent_Entry_ == IntPtr.Zero)
				id_onDhtRequest_Ljava_lang_String_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_BDecodeNode_Lcom_frostwire_jlibtorrent_Entry_ = JNIEnv.GetMethodID (class_ref, "onDhtRequest", "(Ljava/lang/String;Lcom/frostwire/jlibtorrent/UdpEndpoint;Lcom/frostwire/jlibtorrent/BDecodeNode;Lcom/frostwire/jlibtorrent/Entry;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onDhtRequest_Ljava_lang_String_Lcom_frostwire_jlibtorrent_UdpEndpoint_Lcom_frostwire_jlibtorrent_BDecodeNode_Lcom_frostwire_jlibtorrent_Entry_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
