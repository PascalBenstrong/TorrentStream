using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='string_string_pair']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/string_string_pair", DoNotGenerateAcw=true)]
	public partial class String_string_pair : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='string_string_pair']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/string_string_pair", typeof (String_string_pair));
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

		protected String_string_pair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='string_string_pair']/constructor[@name='string_string_pair' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe String_string_pair ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='string_string_pair']/constructor[@name='string_string_pair' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_string_pair']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/string_string_pair;)V", "")]
		public unsafe String_string_pair (global::FrostWire.Libtorrent.Swig.String_string_pair p)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/string_string_pair;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='string_string_pair']/constructor[@name='string_string_pair' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe String_string_pair (string first, string second)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_first = JNIEnv.NewString (first);
			IntPtr native_second = JNIEnv.NewString (second);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_first);
				__args [1] = new JniArgumentValue (native_second);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_first);
				JNIEnv.DeleteLocalRef (native_second);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='string_string_pair']/constructor[@name='string_string_pair' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe String_string_pair (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getFirst;
#pragma warning disable 0169
		static Delegate GetGetFirstHandler ()
		{
			if (cb_getFirst == null)
				cb_getFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirst);
			return cb_getFirst;
		}

		static IntPtr n_GetFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.String_string_pair __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_string_pair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.First);
		}
#pragma warning restore 0169

		static Delegate cb_setFirst_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFirst_Ljava_lang_String_Handler ()
		{
			if (cb_setFirst_Ljava_lang_String_ == null)
				cb_setFirst_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFirst_Ljava_lang_String_);
			return cb_setFirst_Ljava_lang_String_;
		}

		static void n_SetFirst_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.String_string_pair __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_string_pair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.First = value;
		}
#pragma warning restore 0169

		public virtual unsafe string First {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='string_string_pair']/method[@name='getFirst' and count(parameter)=0]"
			[Register ("getFirst", "()Ljava/lang/String;", "GetGetFirstHandler")]
			get {
				const string __id = "getFirst.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='string_string_pair']/method[@name='setFirst' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFirst", "(Ljava/lang/String;)V", "GetSetFirst_Ljava_lang_String_Handler")]
			set {
				const string __id = "setFirst.(Ljava/lang/String;)V";
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

		static Delegate cb_getSecond;
#pragma warning disable 0169
		static Delegate GetGetSecondHandler ()
		{
			if (cb_getSecond == null)
				cb_getSecond = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecond);
			return cb_getSecond;
		}

		static IntPtr n_GetSecond (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.String_string_pair __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_string_pair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Second);
		}
#pragma warning restore 0169

		static Delegate cb_setSecond_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecond_Ljava_lang_String_Handler ()
		{
			if (cb_setSecond_Ljava_lang_String_ == null)
				cb_setSecond_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSecond_Ljava_lang_String_);
			return cb_setSecond_Ljava_lang_String_;
		}

		static void n_SetSecond_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::FrostWire.Libtorrent.Swig.String_string_pair __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_string_pair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Second = value;
		}
#pragma warning restore 0169

		public virtual unsafe string Second {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='string_string_pair']/method[@name='getSecond' and count(parameter)=0]"
			[Register ("getSecond", "()Ljava/lang/String;", "GetGetSecondHandler")]
			get {
				const string __id = "getSecond.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='string_string_pair']/method[@name='setSecond' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSecond", "(Ljava/lang/String;)V", "GetSetSecond_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSecond.(Ljava/lang/String;)V";
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
			global::FrostWire.Libtorrent.Swig.String_string_pair __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.String_string_pair> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='string_string_pair']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='string_string_pair']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.string_string_pair']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/string_string_pair;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.String_string_pair obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/string_string_pair;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
