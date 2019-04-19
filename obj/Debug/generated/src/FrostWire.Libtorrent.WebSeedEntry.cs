using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='WebSeedEntry']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/WebSeedEntry", DoNotGenerateAcw=true)]
	public sealed partial class WebSeedEntry : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='WebSeedEntry.Type']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/WebSeedEntry$Type", DoNotGenerateAcw=true)]
		public sealed partial class Type : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='WebSeedEntry.Type']/field[@name='HTTP_SEED']"
			[Register ("HTTP_SEED")]
			public static global::FrostWire.Libtorrent.WebSeedEntry.Type HttpSeed {
				get {
					const string __id = "HTTP_SEED.Lcom/frostwire/jlibtorrent/WebSeedEntry$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.WebSeedEntry.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='WebSeedEntry.Type']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::FrostWire.Libtorrent.WebSeedEntry.Type Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/frostwire/jlibtorrent/WebSeedEntry$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.WebSeedEntry.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='WebSeedEntry.Type']/field[@name='URL_SEED']"
			[Register ("URL_SEED")]
			public static global::FrostWire.Libtorrent.WebSeedEntry.Type UrlSeed {
				get {
					const string __id = "URL_SEED.Lcom/frostwire/jlibtorrent/WebSeedEntry$Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.WebSeedEntry.Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/WebSeedEntry$Type", typeof (Type));
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

			internal Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='WebSeedEntry.Type']/method[@name='fromSwig' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromSwig", "(I)Lcom/frostwire/jlibtorrent/WebSeedEntry$Type;", "")]
			public static unsafe global::FrostWire.Libtorrent.WebSeedEntry.Type FromSwig (int swigValue)
			{
				const string __id = "fromSwig.(I)Lcom/frostwire/jlibtorrent/WebSeedEntry$Type;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.WebSeedEntry.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='WebSeedEntry.Type']/method[@name='swig' and count(parameter)=0]"
			[Register ("swig", "()I", "")]
			public unsafe int Swig ()
			{
				const string __id = "swig.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='WebSeedEntry.Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/WebSeedEntry$Type;", "")]
			public static unsafe global::FrostWire.Libtorrent.WebSeedEntry.Type ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/WebSeedEntry$Type;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.WebSeedEntry.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='WebSeedEntry.Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/frostwire/jlibtorrent/WebSeedEntry$Type;", "")]
			public static unsafe global::FrostWire.Libtorrent.WebSeedEntry.Type[] Values ()
			{
				const string __id = "values.()[Lcom/frostwire/jlibtorrent/WebSeedEntry$Type;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::FrostWire.Libtorrent.WebSeedEntry.Type[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.WebSeedEntry.Type));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/WebSeedEntry", typeof (WebSeedEntry));
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

		internal WebSeedEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='WebSeedEntry']/constructor[@name='WebSeedEntry' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.web_seed_entry']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/web_seed_entry;)V", "")]
		public unsafe WebSeedEntry (global::FrostWire.Libtorrent.Swig.Web_seed_entry e)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/web_seed_entry;)V";

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='WebSeedEntry']/method[@name='auth' and count(parameter)=0]"
		[Register ("auth", "()Ljava/lang/String;", "")]
		public unsafe string Auth ()
		{
			const string __id = "auth.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='WebSeedEntry']/method[@name='extraHeaders' and count(parameter)=0]"
		[Register ("extraHeaders", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Pair> ExtraHeaders ()
		{
			const string __id = "extraHeaders.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Pair>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='WebSeedEntry']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/web_seed_entry;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Web_seed_entry Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/web_seed_entry;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Web_seed_entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='WebSeedEntry']/method[@name='type' and count(parameter)=0]"
		[Register ("type", "()Lcom/frostwire/jlibtorrent/WebSeedEntry$Type;", "")]
		public unsafe global::FrostWire.Libtorrent.WebSeedEntry.Type InvokeType ()
		{
			const string __id = "type.()Lcom/frostwire/jlibtorrent/WebSeedEntry$Type;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.WebSeedEntry.Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='WebSeedEntry']/method[@name='url' and count(parameter)=0]"
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

	}
}
