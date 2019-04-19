using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Ed25519']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/Ed25519", DoNotGenerateAcw=true)]
	public sealed partial class Ed25519 : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Ed25519']/field[@name='PUBLIC_KEY_SIZE']"
		[Register ("PUBLIC_KEY_SIZE")]
		public const int PublicKeySize = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Ed25519']/field[@name='SCALAR_SIZE']"
		[Register ("SCALAR_SIZE")]
		public const int ScalarSize = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Ed25519']/field[@name='SECRET_KEY_SIZE']"
		[Register ("SECRET_KEY_SIZE")]
		public const int SecretKeySize = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Ed25519']/field[@name='SEED_SIZE']"
		[Register ("SEED_SIZE")]
		public const int SeedSize = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Ed25519']/field[@name='SHARED_SECRET_SIZE']"
		[Register ("SHARED_SECRET_SIZE")]
		public const int SharedSecretSize = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Ed25519']/field[@name='SIGNATURE_SIZE']"
		[Register ("SIGNATURE_SIZE")]
		public const int SignatureSize = (int) 64;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/Ed25519", typeof (Ed25519));
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

		internal Ed25519 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Ed25519']/method[@name='addScalarPublic' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("addScalarPublic", "([B[B)[B", "")]
		public static unsafe byte[] AddScalarPublic (byte[] publicKey, byte[] scalar)
		{
			const string __id = "addScalarPublic.([B[B)[B";
			IntPtr native_publicKey = JNIEnv.NewArray (publicKey);
			IntPtr native_scalar = JNIEnv.NewArray (scalar);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_publicKey);
				__args [1] = new JniArgumentValue (native_scalar);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (publicKey != null) {
					JNIEnv.CopyArray (native_publicKey, publicKey);
					JNIEnv.DeleteLocalRef (native_publicKey);
				}
				if (scalar != null) {
					JNIEnv.CopyArray (native_scalar, scalar);
					JNIEnv.DeleteLocalRef (native_scalar);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Ed25519']/method[@name='addScalarSecret' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("addScalarSecret", "([B[B)[B", "")]
		public static unsafe byte[] AddScalarSecret (byte[] secretKey, byte[] scalar)
		{
			const string __id = "addScalarSecret.([B[B)[B";
			IntPtr native_secretKey = JNIEnv.NewArray (secretKey);
			IntPtr native_scalar = JNIEnv.NewArray (scalar);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_secretKey);
				__args [1] = new JniArgumentValue (native_scalar);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (secretKey != null) {
					JNIEnv.CopyArray (native_secretKey, secretKey);
					JNIEnv.DeleteLocalRef (native_secretKey);
				}
				if (scalar != null) {
					JNIEnv.CopyArray (native_scalar, scalar);
					JNIEnv.DeleteLocalRef (native_scalar);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Ed25519']/method[@name='createKeypair' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("createKeypair", "([B)Lcom/frostwire/jlibtorrent/Pair;", "")]
		public static unsafe global::FrostWire.Libtorrent.Pair CreateKeypair (byte[] seed)
		{
			const string __id = "createKeypair.([B)Lcom/frostwire/jlibtorrent/Pair;";
			IntPtr native_seed = JNIEnv.NewArray (seed);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_seed);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (seed != null) {
					JNIEnv.CopyArray (native_seed, seed);
					JNIEnv.DeleteLocalRef (native_seed);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Ed25519']/method[@name='createSeed' and count(parameter)=0]"
		[Register ("createSeed", "()[B", "")]
		public static unsafe byte[] CreateSeed ()
		{
			const string __id = "createSeed.()[B";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Ed25519']/method[@name='keyExchange' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("keyExchange", "([B[B)[B", "")]
		public unsafe byte[] KeyExchange (byte[] publicKey, byte[] secretKey)
		{
			const string __id = "keyExchange.([B[B)[B";
			IntPtr native_publicKey = JNIEnv.NewArray (publicKey);
			IntPtr native_secretKey = JNIEnv.NewArray (secretKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_publicKey);
				__args [1] = new JniArgumentValue (native_secretKey);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (publicKey != null) {
					JNIEnv.CopyArray (native_publicKey, publicKey);
					JNIEnv.DeleteLocalRef (native_publicKey);
				}
				if (secretKey != null) {
					JNIEnv.CopyArray (native_secretKey, secretKey);
					JNIEnv.DeleteLocalRef (native_secretKey);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Ed25519']/method[@name='sign' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("sign", "([B[B[B)[B", "")]
		public static unsafe byte[] Sign (byte[] message, byte[] publicKey, byte[] secretKey)
		{
			const string __id = "sign.([B[B[B)[B";
			IntPtr native_message = JNIEnv.NewArray (message);
			IntPtr native_publicKey = JNIEnv.NewArray (publicKey);
			IntPtr native_secretKey = JNIEnv.NewArray (secretKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue (native_publicKey);
				__args [2] = new JniArgumentValue (native_secretKey);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (message != null) {
					JNIEnv.CopyArray (native_message, message);
					JNIEnv.DeleteLocalRef (native_message);
				}
				if (publicKey != null) {
					JNIEnv.CopyArray (native_publicKey, publicKey);
					JNIEnv.DeleteLocalRef (native_publicKey);
				}
				if (secretKey != null) {
					JNIEnv.CopyArray (native_secretKey, secretKey);
					JNIEnv.DeleteLocalRef (native_secretKey);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='Ed25519']/method[@name='verify' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("verify", "([B[B[B)Z", "")]
		public static unsafe bool Verify (byte[] signature, byte[] message, byte[] publicKey)
		{
			const string __id = "verify.([B[B[B)Z";
			IntPtr native_signature = JNIEnv.NewArray (signature);
			IntPtr native_message = JNIEnv.NewArray (message);
			IntPtr native_publicKey = JNIEnv.NewArray (publicKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_signature);
				__args [1] = new JniArgumentValue (native_message);
				__args [2] = new JniArgumentValue (native_publicKey);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (signature != null) {
					JNIEnv.CopyArray (native_signature, signature);
					JNIEnv.DeleteLocalRef (native_signature);
				}
				if (message != null) {
					JNIEnv.CopyArray (native_message, message);
					JNIEnv.DeleteLocalRef (native_message);
				}
				if (publicKey != null) {
					JNIEnv.CopyArray (native_publicKey, publicKey);
					JNIEnv.DeleteLocalRef (native_publicKey);
				}
			}
		}

	}
}
