using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/web_seed_entry", DoNotGenerateAcw=true)]
	public partial class Web_seed_entry : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry']/field[@name='swigCMemOwn']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry.type_t']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/web_seed_entry$type_t", DoNotGenerateAcw=true)]
		public sealed partial class Type_t : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry.type_t']/field[@name='http_seed']"
			[Register ("http_seed")]
			public static global::FrostWire.Libtorrent.Swig.Web_seed_entry.Type_t HttpSeed {
				get {
					const string __id = "http_seed.Lcom/frostwire/jlibtorrent/swig/web_seed_entry$type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry.Type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry.type_t']/field[@name='url_seed']"
			[Register ("url_seed")]
			public static global::FrostWire.Libtorrent.Swig.Web_seed_entry.Type_t UrlSeed {
				get {
					const string __id = "url_seed.Lcom/frostwire/jlibtorrent/swig/web_seed_entry$type_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry.Type_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/web_seed_entry$type_t", typeof (Type_t));
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

			internal Type_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry.type_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/web_seed_entry$type_t;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Web_seed_entry.Type_t SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/web_seed_entry$type_t;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry.Type_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry.type_t']/method[@name='swigValue' and count(parameter)=0]"
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/web_seed_entry", typeof (Web_seed_entry));
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

		protected Web_seed_entry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry']/constructor[@name='web_seed_entry' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.web_seed_entry.type_t']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/web_seed_entry$type_t;)V", "")]
		public unsafe Web_seed_entry (string url_, global::FrostWire.Libtorrent.Swig.Web_seed_entry.Type_t type_)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/web_seed_entry$type_t;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_url_ = JNIEnv.NewString (url_);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url_);
				__args [1] = new JniArgumentValue ((type_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type_).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url_);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry']/constructor[@name='web_seed_entry' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.web_seed_entry.type_t'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/web_seed_entry$type_t;Ljava/lang/String;)V", "")]
		public unsafe Web_seed_entry (string url_, global::FrostWire.Libtorrent.Swig.Web_seed_entry.Type_t type_, string auth_)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/web_seed_entry$type_t;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_url_ = JNIEnv.NewString (url_);
			IntPtr native_auth_ = JNIEnv.NewString (auth_);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_url_);
				__args [1] = new JniArgumentValue ((type_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type_).Handle);
				__args [2] = new JniArgumentValue (native_auth_);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url_);
				JNIEnv.DeleteLocalRef (native_auth_);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry']/constructor[@name='web_seed_entry' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.frostwire.jlibtorrent.swig.web_seed_entry.type_t'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.frostwire.jlibtorrent.swig.string_string_pair_vector']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/web_seed_entry$type_t;Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/string_string_pair_vector;)V", "")]
		public unsafe Web_seed_entry (string url_, global::FrostWire.Libtorrent.Swig.Web_seed_entry.Type_t type_, string auth_, global::FrostWire.Libtorrent.Swig.String_string_pair_vector extra_headers_)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/web_seed_entry$type_t;Ljava/lang/String;Lcom/frostwire/jlibtorrent/swig/string_string_pair_vector;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_url_ = JNIEnv.NewString (url_);
			IntPtr native_auth_ = JNIEnv.NewString (auth_);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_url_);
				__args [1] = new JniArgumentValue ((type_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type_).Handle);
				__args [2] = new JniArgumentValue (native_auth_);
				__args [3] = new JniArgumentValue ((extra_headers_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) extra_headers_).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url_);
				JNIEnv.DeleteLocalRef (native_auth_);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry']/constructor[@name='web_seed_entry' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Web_seed_entry (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getAuth;
#pragma warning disable 0169
		static Delegate GetGetAuthHandler ()
		{
			if (cb_getAuth == null)
				cb_getAuth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuth);
			return cb_getAuth;
		}

		static IntPtr n_GetAuth (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Web_seed_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Auth);
		}
#pragma warning restore 0169

		static Delegate cb_setAuth_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuth_Ljava_lang_String_Handler ()
		{
			if (cb_setAuth_Ljava_lang_String_ == null)
				cb_setAuth_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuth_Ljava_lang_String_);
			return cb_setAuth_Ljava_lang_String_;
		}

		static void n_SetAuth_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Web_seed_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Auth = value;
		}
#pragma warning restore 0169

		public virtual unsafe string Auth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry']/method[@name='getAuth' and count(parameter)=0]"
			[Register ("getAuth", "()Ljava/lang/String;", "GetGetAuthHandler")]
			get {
				const string __id = "getAuth.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry']/method[@name='setAuth' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAuth", "(Ljava/lang/String;)V", "GetSetAuth_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAuth.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getExtra_headers;
#pragma warning disable 0169
		static Delegate GetGetExtra_headersHandler ()
		{
			if (cb_getExtra_headers == null)
				cb_getExtra_headers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtra_headers);
			return cb_getExtra_headers;
		}

		static IntPtr n_GetExtra_headers (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Web_seed_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Extra_headers);
		}
#pragma warning restore 0169

		static Delegate cb_setExtra_headers_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_;
#pragma warning disable 0169
		static Delegate GetSetExtra_headers_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_Handler ()
		{
			if (cb_setExtra_headers_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_ == null)
				cb_setExtra_headers_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExtra_headers_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_);
			return cb_setExtra_headers_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_;
		}

		static void n_SetExtra_headers_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Web_seed_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.String_string_pair_vector value = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_string_pair_vector> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Extra_headers = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.String_string_pair_vector Extra_headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry']/method[@name='getExtra_headers' and count(parameter)=0]"
			[Register ("getExtra_headers", "()Lcom/frostwire/jlibtorrent/swig/string_string_pair_vector;", "GetGetExtra_headersHandler")]
			get {
				const string __id = "getExtra_headers.()Lcom/frostwire/jlibtorrent/swig/string_string_pair_vector;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_string_pair_vector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry']/method[@name='setExtra_headers' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_string_pair_vector']]"
			[Register ("setExtra_headers", "(Lcom/frostwire/jlibtorrent/swig/string_string_pair_vector;)V", "GetSetExtra_headers_Lcom_frostwire_jlibtorrent_swig_string_string_pair_vector_Handler")]
			set {
				const string __id = "setExtra_headers.(Lcom/frostwire/jlibtorrent/swig/string_string_pair_vector;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetType);
			return cb_getType;
		}

		static short n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Web_seed_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static Delegate cb_setType_S;
#pragma warning disable 0169
		static Delegate GetSetType_SHandler ()
		{
			if (cb_setType_S == null)
				cb_setType_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetType_S);
			return cb_setType_S;
		}

		static void n_SetType_S (IntPtr jnienv, IntPtr native__this, short value)
		{
			global::FrostWire.Libtorrent.Swig.Web_seed_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Type = value;
		}
#pragma warning restore 0169

		public virtual unsafe short Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()S", "GetGetTypeHandler")]
			get {
				const string __id = "getType.()S";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt16Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='short']]"
			[Register ("setType", "(S)V", "GetSetType_SHandler")]
			set {
				const string __id = "setType.(S)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Web_seed_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static Delegate cb_setUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setUrl_Ljava_lang_String_ == null)
				cb_setUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_lang_String_);
			return cb_setUrl_Ljava_lang_String_;
		}

		static void n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.Web_seed_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Url = value;
		}
#pragma warning restore 0169

		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				const string __id = "getUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUrl", "(Ljava/lang/String;)V", "GetSetUrl_Ljava_lang_String_Handler")]
			set {
				const string __id = "setUrl.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::FrostWire.Libtorrent.Swig.Web_seed_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.web_seed_entry']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/web_seed_entry;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Web_seed_entry obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/web_seed_entry;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_op_eq_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_;
#pragma warning disable 0169
		static Delegate GetOp_eq_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_Handler ()
		{
			if (cb_op_eq_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_ == null)
				cb_op_eq_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Op_eq_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_);
			return cb_op_eq_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_;
		}

		static bool n_Op_eq_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::FrostWire.Libtorrent.Swig.Web_seed_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Web_seed_entry e = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Op_eq (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry']/method[@name='op_eq' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.web_seed_entry']]"
		[Register ("op_eq", "(Lcom/frostwire/jlibtorrent/swig/web_seed_entry;)Z", "GetOp_eq_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_Handler")]
		public virtual unsafe bool Op_eq (global::FrostWire.Libtorrent.Swig.Web_seed_entry e)
		{
			const string __id = "op_eq.(Lcom/frostwire/jlibtorrent/swig/web_seed_entry;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_op_lt_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_;
#pragma warning disable 0169
		static Delegate GetOp_lt_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_Handler ()
		{
			if (cb_op_lt_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_ == null)
				cb_op_lt_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Op_lt_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_);
			return cb_op_lt_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_;
		}

		static bool n_Op_lt_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::FrostWire.Libtorrent.Swig.Web_seed_entry __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::FrostWire.Libtorrent.Swig.Web_seed_entry e = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Op_lt (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='web_seed_entry']/method[@name='op_lt' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.web_seed_entry']]"
		[Register ("op_lt", "(Lcom/frostwire/jlibtorrent/swig/web_seed_entry;)Z", "GetOp_lt_Lcom_frostwire_jlibtorrent_swig_web_seed_entry_Handler")]
		public virtual unsafe bool Op_lt (global::FrostWire.Libtorrent.Swig.Web_seed_entry e)
		{
			const string __id = "op_lt.(Lcom/frostwire/jlibtorrent/swig/web_seed_entry;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
