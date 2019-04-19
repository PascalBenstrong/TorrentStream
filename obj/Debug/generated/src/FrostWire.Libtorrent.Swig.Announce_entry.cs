using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/announce_entry", DoNotGenerateAcw=true)]
	public partial class Announce_entry : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/field[@name='swigCMemOwn']"
		[Register ("swigCMemOwn")]
		protected bool SwigCMemOwn {
			get {
				const string __id = "swigCMemOwn.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "swigCMemOwn.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry.tracker_source']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/announce_entry$tracker_source", DoNotGenerateAcw=true)]
		public sealed partial class Tracker_source : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry.tracker_source']/field[@name='source_client']"
			[Register ("source_client")]
			public static global::FrostWire.Libtorrent.Swig.Announce_entry.Tracker_source SourceClient {
				get {
					const string __id = "source_client.Lcom/frostwire/jlibtorrent/swig/announce_entry$tracker_source;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry.Tracker_source> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry.tracker_source']/field[@name='source_magnet_link']"
			[Register ("source_magnet_link")]
			public static global::FrostWire.Libtorrent.Swig.Announce_entry.Tracker_source SourceMagnetLink {
				get {
					const string __id = "source_magnet_link.Lcom/frostwire/jlibtorrent/swig/announce_entry$tracker_source;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry.Tracker_source> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry.tracker_source']/field[@name='source_tex']"
			[Register ("source_tex")]
			public static global::FrostWire.Libtorrent.Swig.Announce_entry.Tracker_source SourceTex {
				get {
					const string __id = "source_tex.Lcom/frostwire/jlibtorrent/swig/announce_entry$tracker_source;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry.Tracker_source> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry.tracker_source']/field[@name='source_torrent']"
			[Register ("source_torrent")]
			public static global::FrostWire.Libtorrent.Swig.Announce_entry.Tracker_source SourceTorrent {
				get {
					const string __id = "source_torrent.Lcom/frostwire/jlibtorrent/swig/announce_entry$tracker_source;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry.Tracker_source> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/announce_entry$tracker_source", typeof (Tracker_source));
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

			internal Tracker_source (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry.tracker_source']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/announce_entry$tracker_source;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Announce_entry.Tracker_source SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/announce_entry$tracker_source;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry.Tracker_source> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry.tracker_source']/method[@name='swigValue' and count(parameter)=0]"
			[Register ("swigValue", "()I", "")]
			public unsafe int SwigValue ()
			{
				const string __id = "swigValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/announce_entry", typeof (Announce_entry));
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

		protected Announce_entry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/constructor[@name='announce_entry' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V", "")]
		public unsafe Announce_entry (global::FrostWire.Libtorrent.Swig.Byte_vector u)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((u == null) ? IntPtr.Zero : ((global::Java.Lang.Object) u).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/constructor[@name='announce_entry' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Announce_entry (long cPtr, bool cMemoryOwn)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (cPtr);
				__args [1] = new JniArgumentValue (cMemoryOwn);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getEndpoints;
#pragma warning disable 0169
		static Delegate GetGetEndpointsHandler ()
		{
			if (cb_getEndpoints == null)
				cb_getEndpoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndpoints);
			return cb_getEndpoints;
		}

		static IntPtr n_GetEndpoints (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Endpoints);
		}
#pragma warning restore 0169

		static Delegate cb_setEndpoints_Lcom_frostwire_jlibtorrent_swig_announce_endpoint_vector_;
#pragma warning disable 0169
		static Delegate GetSetEndpoints_Lcom_frostwire_jlibtorrent_swig_announce_endpoint_vector_Handler ()
		{
			if (cb_setEndpoints_Lcom_frostwire_jlibtorrent_swig_announce_endpoint_vector_ == null)
				cb_setEndpoints_Lcom_frostwire_jlibtorrent_swig_announce_endpoint_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEndpoints_Lcom_frostwire_jlibtorrent_swig_announce_endpoint_vector_);
			return cb_setEndpoints_Lcom_frostwire_jlibtorrent_swig_announce_endpoint_vector_;
		}

		static void n_SetEndpoints_Lcom_frostwire_jlibtorrent_swig_announce_endpoint_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Announce_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Announce_endpoint_vector value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint_vector> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Endpoints = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Announce_endpoint_vector Endpoints {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/method[@name='getEndpoints' and count(parameter)=0]"
			[Register ("getEndpoints", "()Lcom/frostwire/jlibtorrent/swig/announce_endpoint_vector;", "GetGetEndpointsHandler")]
			get {
				const string __id = "getEndpoints.()Lcom/frostwire/jlibtorrent/swig/announce_endpoint_vector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_endpoint_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/method[@name='setEndpoints' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.announce_endpoint_vector']]"
			[Register ("setEndpoints", "(Lcom/frostwire/jlibtorrent/swig/announce_endpoint_vector;)V", "GetSetEndpoints_Lcom_frostwire_jlibtorrent_swig_announce_endpoint_vector_Handler")]
			set {
				const string __id = "setEndpoints.(Lcom/frostwire/jlibtorrent/swig/announce_endpoint_vector;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFail_limit;
#pragma warning disable 0169
		static Delegate GetGetFail_limitHandler ()
		{
			if (cb_getFail_limit == null)
				cb_getFail_limit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetFail_limit);
			return cb_getFail_limit;
		}

		static short n_GetFail_limit (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Fail_limit;
		}
#pragma warning restore 0169

		static Delegate cb_setFail_limit_S;
#pragma warning disable 0169
		static Delegate GetSetFail_limit_SHandler ()
		{
			if (cb_setFail_limit_S == null)
				cb_setFail_limit_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetFail_limit_S);
			return cb_setFail_limit_S;
		}

		static void n_SetFail_limit_S (IntPtr jnienv, IntPtr native__this, short value)
		{
			global::FrostWire.Libtorrent.Swig.Announce_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Fail_limit = value;
		}
#pragma warning restore 0169

		public virtual unsafe short Fail_limit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/method[@name='getFail_limit' and count(parameter)=0]"
			[Register ("getFail_limit", "()S", "GetGetFail_limitHandler")]
			get {
				const string __id = "getFail_limit.()S";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt16Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/method[@name='setFail_limit' and count(parameter)=1 and parameter[1][@type='short']]"
			[Register ("setFail_limit", "(S)V", "GetSetFail_limit_SHandler")]
			set {
				const string __id = "setFail_limit.(S)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSource;
#pragma warning disable 0169
		static Delegate GetGetSourceHandler ()
		{
			if (cb_getSource == null)
				cb_getSource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetSource);
			return cb_getSource;
		}

		static short n_GetSource (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Source;
		}
#pragma warning restore 0169

		static Delegate cb_setSource_S;
#pragma warning disable 0169
		static Delegate GetSetSource_SHandler ()
		{
			if (cb_setSource_S == null)
				cb_setSource_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetSource_S);
			return cb_setSource_S;
		}

		static void n_SetSource_S (IntPtr jnienv, IntPtr native__this, short value)
		{
			global::FrostWire.Libtorrent.Swig.Announce_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Source = value;
		}
#pragma warning restore 0169

		public virtual unsafe short Source {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/method[@name='getSource' and count(parameter)=0]"
			[Register ("getSource", "()S", "GetGetSourceHandler")]
			get {
				const string __id = "getSource.()S";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt16Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/method[@name='setSource' and count(parameter)=1 and parameter[1][@type='short']]"
			[Register ("setSource", "(S)V", "GetSetSource_SHandler")]
			set {
				const string __id = "setSource.(S)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTier;
#pragma warning disable 0169
		static Delegate GetGetTierHandler ()
		{
			if (cb_getTier == null)
				cb_getTier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetTier);
			return cb_getTier;
		}

		static short n_GetTier (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Tier;
		}
#pragma warning restore 0169

		static Delegate cb_setTier_S;
#pragma warning disable 0169
		static Delegate GetSetTier_SHandler ()
		{
			if (cb_setTier_S == null)
				cb_setTier_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetTier_S);
			return cb_setTier_S;
		}

		static void n_SetTier_S (IntPtr jnienv, IntPtr native__this, short value)
		{
			global::FrostWire.Libtorrent.Swig.Announce_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Tier = value;
		}
#pragma warning restore 0169

		public virtual unsafe short Tier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/method[@name='getTier' and count(parameter)=0]"
			[Register ("getTier", "()S", "GetGetTierHandler")]
			get {
				const string __id = "getTier.()S";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt16Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/method[@name='setTier' and count(parameter)=1 and parameter[1][@type='short']]"
			[Register ("setTier", "(S)V", "GetSetTier_SHandler")]
			set {
				const string __id = "setTier.(S)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVerified;
#pragma warning disable 0169
		static Delegate GetGetVerifiedHandler ()
		{
			if (cb_getVerified == null)
				cb_getVerified = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetVerified);
			return cb_getVerified;
		}

		static bool n_GetVerified (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Verified;
		}
#pragma warning restore 0169

		static Delegate cb_setVerified_Z;
#pragma warning disable 0169
		static Delegate GetSetVerified_ZHandler ()
		{
			if (cb_setVerified_Z == null)
				cb_setVerified_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVerified_Z);
			return cb_setVerified_Z;
		}

		static void n_SetVerified_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Announce_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Verified = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Verified {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/method[@name='getVerified' and count(parameter)=0]"
			[Register ("getVerified", "()Z", "GetGetVerifiedHandler")]
			get {
				const string __id = "getVerified.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/method[@name='setVerified' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVerified", "(Z)V", "GetSetVerified_ZHandler")]
			set {
				const string __id = "setVerified.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_delete;
#pragma warning disable 0169
		static Delegate GetDeleteHandler ()
		{
			if (cb_delete == null)
				cb_delete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Delete);
			return cb_delete;
		}

		static void n_Delete (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.announce_entry']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/announce_entry;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Announce_entry obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/announce_entry;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_trackerid;
#pragma warning disable 0169
		static Delegate GetGet_trackeridHandler ()
		{
			if (cb_get_trackerid == null)
				cb_get_trackerid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_trackerid);
			return cb_get_trackerid;
		}

		static IntPtr n_Get_trackerid (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_trackerid ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/method[@name='get_trackerid' and count(parameter)=0]"
		[Register ("get_trackerid", "()Lcom/frostwire/jlibtorrent/swig/byte_vector;", "GetGet_trackeridHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Get_trackerid ()
		{
			const string __id = "get_trackerid.()Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_url;
#pragma warning disable 0169
		static Delegate GetGet_urlHandler ()
		{
			if (cb_get_url == null)
				cb_get_url = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get_url);
			return cb_get_url;
		}

		static IntPtr n_Get_url (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Announce_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get_url ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/method[@name='get_url' and count(parameter)=0]"
		[Register ("get_url", "()Lcom/frostwire/jlibtorrent/swig/byte_vector;", "GetGet_urlHandler")]
		public virtual unsafe global::FrostWire.Libtorrent.Swig.Byte_vector Get_url ()
		{
			const string __id = "get_url.()Lcom/frostwire/jlibtorrent/swig/byte_vector;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_set_trackerid_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
#pragma warning disable 0169
		static Delegate GetSet_trackerid_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler ()
		{
			if (cb_set_trackerid_Lcom_frostwire_jlibtorrent_swig_byte_vector_ == null)
				cb_set_trackerid_Lcom_frostwire_jlibtorrent_swig_byte_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_trackerid_Lcom_frostwire_jlibtorrent_swig_byte_vector_);
			return cb_set_trackerid_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
		}

		static void n_Set_trackerid_Lcom_frostwire_jlibtorrent_swig_byte_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			global::FrostWire.Libtorrent.Swig.Announce_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector s = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_s, JniHandleOwnership.DoNotTransfer);
			__this.Set_trackerid (s);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/method[@name='set_trackerid' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("set_trackerid", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V", "GetSet_trackerid_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler")]
		public virtual unsafe void Set_trackerid (global::FrostWire.Libtorrent.Swig.Byte_vector s)
		{
			const string __id = "set_trackerid.(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_set_url_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
#pragma warning disable 0169
		static Delegate GetSet_url_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler ()
		{
			if (cb_set_url_Lcom_frostwire_jlibtorrent_swig_byte_vector_ == null)
				cb_set_url_Lcom_frostwire_jlibtorrent_swig_byte_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Set_url_Lcom_frostwire_jlibtorrent_swig_byte_vector_);
			return cb_set_url_Lcom_frostwire_jlibtorrent_swig_byte_vector_;
		}

		static void n_Set_url_Lcom_frostwire_jlibtorrent_swig_byte_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			global::FrostWire.Libtorrent.Swig.Announce_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Announce_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Byte_vector s = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Byte_vector> (native_s, JniHandleOwnership.DoNotTransfer);
			__this.Set_url (s);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='announce_entry']/method[@name='set_url' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.byte_vector']]"
		[Register ("set_url", "(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V", "GetSet_url_Lcom_frostwire_jlibtorrent_swig_byte_vector_Handler")]
		public virtual unsafe void Set_url (global::FrostWire.Libtorrent.Swig.Byte_vector s)
		{
			const string __id = "set_url.(Lcom/frostwire/jlibtorrent/swig/byte_vector;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
