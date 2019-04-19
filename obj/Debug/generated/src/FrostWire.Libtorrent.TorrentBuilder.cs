using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/TorrentBuilder", DoNotGenerateAcw=true)]
	public sealed partial class TorrentBuilder : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/field[@name='MERKLE']"
		[Register ("MERKLE")]
		public static global::FrostWire.Libtorrent.Swig.Create_flags_t Merkle {
			get {
				const string __id = "MERKLE.Lcom/frostwire/jlibtorrent/swig/create_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/field[@name='MODIFICATION_TIME']"
		[Register ("MODIFICATION_TIME")]
		public static global::FrostWire.Libtorrent.Swig.Create_flags_t ModificationTime {
			get {
				const string __id = "MODIFICATION_TIME.Lcom/frostwire/jlibtorrent/swig/create_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/field[@name='MUTABLE_TORRENT_SUPPORT']"
		[Register ("MUTABLE_TORRENT_SUPPORT")]
		public static global::FrostWire.Libtorrent.Swig.Create_flags_t MutableTorrentSupport {
			get {
				const string __id = "MUTABLE_TORRENT_SUPPORT.Lcom/frostwire/jlibtorrent/swig/create_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/field[@name='OPTIMIZE_ALIGNMENT']"
		[Register ("OPTIMIZE_ALIGNMENT")]
		public static global::FrostWire.Libtorrent.Swig.Create_flags_t OptimizeAlignment {
			get {
				const string __id = "OPTIMIZE_ALIGNMENT.Lcom/frostwire/jlibtorrent/swig/create_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/field[@name='SYMLINKS']"
		[Register ("SYMLINKS")]
		public static global::FrostWire.Libtorrent.Swig.Create_flags_t Symlinks {
			get {
				const string __id = "SYMLINKS.Lcom/frostwire/jlibtorrent/swig/create_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.frostwire.jlibtorrent']/interface[@name='TorrentBuilder.Listener']"
		[Register ("com/frostwire/jlibtorrent/TorrentBuilder$Listener", "", "FrostWire.Libtorrent.TorrentBuilder/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/interface[@name='TorrentBuilder.Listener']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("accept", "(Ljava/lang/String;)Z", "GetAccept_Ljava_lang_String_Handler:FrostWire.Libtorrent.TorrentBuilder/IListenerInvoker, TorrentStream")]
			bool Accept (string p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/interface[@name='TorrentBuilder.Listener']/method[@name='progress' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("progress", "(II)V", "GetProgress_IIHandler:FrostWire.Libtorrent.TorrentBuilder/IListenerInvoker, TorrentStream")]
			void Progress (int p0, int p1);

		}

		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/TorrentBuilder$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/frostwire/jlibtorrent/TorrentBuilder$Listener", typeof (IListenerInvoker));

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

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.frostwire.jlibtorrent.TorrentBuilder.Listener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_accept_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetAccept_Ljava_lang_String_Handler ()
			{
				if (cb_accept_Ljava_lang_String_ == null)
					cb_accept_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Accept_Ljava_lang_String_);
				return cb_accept_Ljava_lang_String_;
			}

			static bool n_Accept_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::FrostWire.Libtorrent.TorrentBuilder.IListener __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Accept (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_accept_Ljava_lang_String_;
			public unsafe bool Accept (string p0)
			{
				if (id_accept_Ljava_lang_String_ == IntPtr.Zero)
					id_accept_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "accept", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_accept_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_progress_II;
#pragma warning disable 0169
			static Delegate GetProgress_IIHandler ()
			{
				if (cb_progress_II == null)
					cb_progress_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_Progress_II);
				return cb_progress_II;
			}

			static void n_Progress_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::FrostWire.Libtorrent.TorrentBuilder.IListener __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Progress (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_progress_II;
			public unsafe void Progress (int p0, int p1)
			{
				if (id_progress_II == IntPtr.Zero)
					id_progress_II = JNIEnv.GetMethodID (class_ref, "progress", "(II)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_progress_II, __args);
			}

		}

		// event args for com.frostwire.jlibtorrent.TorrentBuilder.Listener.accept
		public partial class AcceptEventArgs : global::System.EventArgs {

			public AcceptEventArgs (bool handled, string p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			string p0;
			public string P0 {
				get { return p0; }
			}
		}

		// event args for com.frostwire.jlibtorrent.TorrentBuilder.Listener.progress
		public partial class ProgressEventArgs : global::System.EventArgs {

			public ProgressEventArgs (int p0, int p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/frostwire/jlibtorrent/TorrentBuilder_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/frostwire/jlibtorrent/TorrentBuilder_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<AcceptEventArgs> AcceptHandler;
#pragma warning restore 0649

			public bool Accept (string p0)
			{
				var __h = AcceptHandler;
				if (__h == null)
					return false;
				var __e = new AcceptEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}
#pragma warning disable 0649
			public EventHandler<ProgressEventArgs> ProgressHandler;
#pragma warning restore 0649

			public void Progress (int p0, int p1)
			{
				var __h = ProgressHandler;
				if (__h != null)
					__h (sender, new ProgressEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.AcceptHandler == null && value.ProgressHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder.Result']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/TorrentBuilder$Result", DoNotGenerateAcw=true)]
		public sealed partial class Result : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/TorrentBuilder$Result", typeof (Result));
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

			internal Result (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder.Result']/method[@name='entry' and count(parameter)=0]"
			[Register ("entry", "()Lcom/frostwire/jlibtorrent/Entry;", "")]
			public unsafe global::FrostWire.Libtorrent.Entry Entry ()
			{
				const string __id = "entry.()Lcom/frostwire/jlibtorrent/Entry;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder.Result']/method[@name='merkleTree' and count(parameter)=0]"
			[Register ("merkleTree", "()Ljava/util/ArrayList;", "")]
			public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Sha1Hash> MerkleTree ()
			{
				const string __id = "merkleTree.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Sha1Hash>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder.Result']/method[@name='numPieces' and count(parameter)=0]"
			[Register ("numPieces", "()I", "")]
			public unsafe int NumPieces ()
			{
				const string __id = "numPieces.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder.Result']/method[@name='pieceLength' and count(parameter)=0]"
			[Register ("pieceLength", "()I", "")]
			public unsafe int PieceLength ()
			{
				const string __id = "pieceLength.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder.Result']/method[@name='pieceSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("pieceSize", "(I)I", "")]
			public unsafe int PieceSize (int index)
			{
				const string __id = "pieceSize.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (index);
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/TorrentBuilder", typeof (TorrentBuilder));
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

		internal TorrentBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/constructor[@name='TorrentBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TorrentBuilder ()
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

		public unsafe bool IsPrivate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='isPrivate' and count(parameter)=0]"
			[Register ("isPrivate", "()Z", "GetIsPrivateHandler")]
			get {
				const string __id = "isPrivate.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='addCollection' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addCollection", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder AddCollection (string value)
		{
			const string __id = "addCollection.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='addCollections' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("addCollections", "(Ljava/util/List;)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder AddCollections (global::System.Collections.Generic.IList<string> value)
		{
			const string __id = "addCollections.(Ljava/util/List;)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='addHttpSeed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addHttpSeed", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder AddHttpSeed (string value)
		{
			const string __id = "addHttpSeed.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='addHttpSeeds' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("addHttpSeeds", "(Ljava/util/List;)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder AddHttpSeeds (global::System.Collections.Generic.IList<string> value)
		{
			const string __id = "addHttpSeeds.(Ljava/util/List;)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='addNode' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Pair&lt;java.lang.String, java.lang.Integer&gt;']]"
		[Register ("addNode", "(Lcom/frostwire/jlibtorrent/Pair;)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder AddNode (global::FrostWire.Libtorrent.Pair value)
		{
			const string __id = "addNode.(Lcom/frostwire/jlibtorrent/Pair;)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='addNodes' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.frostwire.jlibtorrent.Pair&lt;java.lang.String, java.lang.Integer&gt;&gt;']]"
		[Register ("addNodes", "(Ljava/util/List;)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder AddNodes (global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Pair> value)
		{
			const string __id = "addNodes.(Ljava/util/List;)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			IntPtr native_value = global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Pair>.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='addSimilarTorrent' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Sha1Hash']]"
		[Register ("addSimilarTorrent", "(Lcom/frostwire/jlibtorrent/Sha1Hash;)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder AddSimilarTorrent (global::FrostWire.Libtorrent.Sha1Hash value)
		{
			const string __id = "addSimilarTorrent.(Lcom/frostwire/jlibtorrent/Sha1Hash;)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='addSimilarTorrents' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.frostwire.jlibtorrent.Sha1Hash&gt;']]"
		[Register ("addSimilarTorrents", "(Ljava/util/List;)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder AddSimilarTorrents (global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Sha1Hash> value)
		{
			const string __id = "addSimilarTorrents.(Ljava/util/List;)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			IntPtr native_value = global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Sha1Hash>.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='addTracker' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.Pair&lt;java.lang.String, java.lang.Integer&gt;']]"
		[Register ("addTracker", "(Lcom/frostwire/jlibtorrent/Pair;)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder AddTracker (global::FrostWire.Libtorrent.Pair value)
		{
			const string __id = "addTracker.(Lcom/frostwire/jlibtorrent/Pair;)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='addTracker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addTracker", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder AddTracker (string url)
		{
			const string __id = "addTracker.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='addTracker' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("addTracker", "(Ljava/lang/String;I)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder AddTracker (string url, int tier)
		{
			const string __id = "addTracker.(Ljava/lang/String;I)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (tier);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='addTrackers' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.frostwire.jlibtorrent.Pair&lt;java.lang.String, java.lang.Integer&gt;&gt;']]"
		[Register ("addTrackers", "(Ljava/util/List;)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder AddTrackers (global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Pair> value)
		{
			const string __id = "addTrackers.(Ljava/util/List;)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			IntPtr native_value = global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Pair>.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='addUrlSeed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addUrlSeed", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder AddUrlSeed (string value)
		{
			const string __id = "addUrlSeed.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='addUrlSeeds' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("addUrlSeeds", "(Ljava/util/List;)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder AddUrlSeeds (global::System.Collections.Generic.IList<string> value)
		{
			const string __id = "addUrlSeeds.(Ljava/util/List;)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='alignment' and count(parameter)=0]"
		[Register ("alignment", "()I", "")]
		public unsafe int Alignment ()
		{
			const string __id = "alignment.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='alignment' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("alignment", "(I)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder Alignment (int value)
		{
			const string __id = "alignment.(I)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='collections' and count(parameter)=0]"
		[Register ("collections", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> Collections ()
		{
			const string __id = "collections.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='comment' and count(parameter)=0]"
		[Register ("comment", "()Ljava/lang/String;", "")]
		public unsafe string Comment ()
		{
			const string __id = "comment.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='comment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("comment", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder Comment (string value)
		{
			const string __id = "comment.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='creator' and count(parameter)=0]"
		[Register ("creator", "()Ljava/lang/String;", "")]
		public unsafe string Creator ()
		{
			const string __id = "creator.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='creator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("creator", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder Creator (string value)
		{
			const string __id = "creator.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='flags' and count(parameter)=0]"
		[Register ("flags", "()Lcom/frostwire/jlibtorrent/swig/create_flags_t;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Create_flags_t Flags ()
		{
			const string __id = "flags.()Lcom/frostwire/jlibtorrent/swig/create_flags_t;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Create_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='flags' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.create_flags_t']]"
		[Register ("flags", "(Lcom/frostwire/jlibtorrent/swig/create_flags_t;)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder Flags (global::FrostWire.Libtorrent.Swig.Create_flags_t value)
		{
			const string __id = "flags.(Lcom/frostwire/jlibtorrent/swig/create_flags_t;)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='generate' and count(parameter)=0]"
		[Register ("generate", "()Lcom/frostwire/jlibtorrent/TorrentBuilder$Result;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder.Result Generate ()
		{
			const string __id = "generate.()Lcom/frostwire/jlibtorrent/TorrentBuilder$Result;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder.Result> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='httpSeeds' and count(parameter)=0]"
		[Register ("httpSeeds", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> HttpSeeds ()
		{
			const string __id = "httpSeeds.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='listener' and count(parameter)=0]"
		[Register ("listener", "()Lcom/frostwire/jlibtorrent/TorrentBuilder$Listener;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder.IListener Listener ()
		{
			const string __id = "listener.()Lcom/frostwire/jlibtorrent/TorrentBuilder$Listener;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder.IListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='listener' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.TorrentBuilder.Listener']]"
		[Register ("listener", "(Lcom/frostwire/jlibtorrent/TorrentBuilder$Listener;)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder Listener (global::FrostWire.Libtorrent.TorrentBuilder.IListener value)
		{
			const string __id = "listener.(Lcom/frostwire/jlibtorrent/TorrentBuilder$Listener;)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='nodes' and count(parameter)=0]"
		[Register ("nodes", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Pair> Nodes ()
		{
			const string __id = "nodes.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Pair>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='padFileLimit' and count(parameter)=0]"
		[Register ("padFileLimit", "()I", "")]
		public unsafe int PadFileLimit ()
		{
			const string __id = "padFileLimit.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='padFileLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("padFileLimit", "(I)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder PadFileLimit (int value)
		{
			const string __id = "padFileLimit.(I)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='path' and count(parameter)=0]"
		[Register ("path", "()Ljava/io/File;", "")]
		public unsafe global::Java.IO.File Path ()
		{
			const string __id = "path.()Ljava/io/File;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='path' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("path", "(Ljava/io/File;)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder Path (global::Java.IO.File value)
		{
			const string __id = "path.(Ljava/io/File;)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='pieceSize' and count(parameter)=0]"
		[Register ("pieceSize", "()I", "")]
		public unsafe int PieceSize ()
		{
			const string __id = "pieceSize.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='pieceSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pieceSize", "(I)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder PieceSize (int value)
		{
			const string __id = "pieceSize.(I)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='setPrivate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPrivate", "(Z)Lcom/frostwire/jlibtorrent/TorrentBuilder;", "")]
		public unsafe global::FrostWire.Libtorrent.TorrentBuilder SetPrivate (bool value)
		{
			const string __id = "setPrivate.(Z)Lcom/frostwire/jlibtorrent/TorrentBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.TorrentBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='similarTorrents' and count(parameter)=0]"
		[Register ("similarTorrents", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Sha1Hash> SimilarTorrents ()
		{
			const string __id = "similarTorrents.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Sha1Hash>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='trackers' and count(parameter)=0]"
		[Register ("trackers", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.Pair> Trackers ()
		{
			const string __id = "trackers.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.Pair>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='TorrentBuilder']/method[@name='urlSeeds' and count(parameter)=0]"
		[Register ("urlSeeds", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<string> UrlSeeds ()
		{
			const string __id = "urlSeeds.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
