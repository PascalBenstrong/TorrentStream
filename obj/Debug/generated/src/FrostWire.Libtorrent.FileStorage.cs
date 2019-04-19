using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/FileStorage", DoNotGenerateAcw=true)]
	public sealed partial class FileStorage : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/field[@name='FLAG_EXECUTABLE']"
		[Register ("FLAG_EXECUTABLE")]
		public static global::FrostWire.Libtorrent.Swig.File_flags_t FlagExecutable {
			get {
				const string __id = "FLAG_EXECUTABLE.Lcom/frostwire/jlibtorrent/swig/file_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/field[@name='FLAG_HIDDEN']"
		[Register ("FLAG_HIDDEN")]
		public static global::FrostWire.Libtorrent.Swig.File_flags_t FlagHidden {
			get {
				const string __id = "FLAG_HIDDEN.Lcom/frostwire/jlibtorrent/swig/file_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/field[@name='FLAG_PAD_FILE']"
		[Register ("FLAG_PAD_FILE")]
		public static global::FrostWire.Libtorrent.Swig.File_flags_t FlagPadFile {
			get {
				const string __id = "FLAG_PAD_FILE.Lcom/frostwire/jlibtorrent/swig/file_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/field[@name='FLAG_SYMLINK']"
		[Register ("FLAG_SYMLINK")]
		public static global::FrostWire.Libtorrent.Swig.File_flags_t FlagSymlink {
			get {
				const string __id = "FLAG_SYMLINK.Lcom/frostwire/jlibtorrent/swig/file_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/FileStorage", typeof (FileStorage));
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

		internal FileStorage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/constructor[@name='FileStorage' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.file_storage']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/file_storage;)V", "")]
		public unsafe FileStorage (global::FrostWire.Libtorrent.Swig.File_storage fs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/file_storage;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((fs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				const string __id = "isValid.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='addFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("addFile", "(Ljava/lang/String;J)V", "")]
		public unsafe void AddFile (string p, long size)
		{
			const string __id = "addFile.(Ljava/lang/String;J)V";
			IntPtr native_p = JNIEnv.NewString (p);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p);
				__args [1] = new JniArgumentValue (size);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='addFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.file_flags_t']]"
		[Register ("addFile", "(Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;)V", "")]
		public unsafe void AddFile (string path, long size, global::FrostWire.Libtorrent.Swig.File_flags_t flags)
		{
			const string __id = "addFile.(Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (size);
				__args [2] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='addFile' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.file_flags_t'] and parameter[4][@type='int']]"
		[Register ("addFile", "(Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;I)V", "")]
		public unsafe void AddFile (string path, long size, global::FrostWire.Libtorrent.Swig.File_flags_t flags, int mtime)
		{
			const string __id = "addFile.(Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;I)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (size);
				__args [2] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				__args [3] = new JniArgumentValue (mtime);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='addFile' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='com.frostwire.jlibtorrent.swig.file_flags_t'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register ("addFile", "(Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;ILjava/lang/String;)V", "")]
		public unsafe void AddFile (string path, long size, global::FrostWire.Libtorrent.Swig.File_flags_t flags, int mtime, string symlink)
		{
			const string __id = "addFile.(Ljava/lang/String;JLcom/frostwire/jlibtorrent/swig/file_flags_t;ILjava/lang/String;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			IntPtr native_symlink = JNIEnv.NewString (symlink);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (size);
				__args [2] = new JniArgumentValue ((flags == null) ? IntPtr.Zero : ((global::Java.Lang.Object) flags).Handle);
				__args [3] = new JniArgumentValue (mtime);
				__args [4] = new JniArgumentValue (native_symlink);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				JNIEnv.DeleteLocalRef (native_symlink);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='fileAbsolutePath' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fileAbsolutePath", "(I)Z", "")]
		public unsafe bool FileAbsolutePath (int index)
		{
			const string __id = "fileAbsolutePath.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='fileFlags' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fileFlags", "(I)Lcom/frostwire/jlibtorrent/swig/file_flags_t;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.File_flags_t FileFlags (int index)
		{
			const string __id = "fileFlags.(I)Lcom/frostwire/jlibtorrent/swig/file_flags_t;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='fileIndexAtOffset' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("fileIndexAtOffset", "(J)I", "")]
		public unsafe int FileIndexAtOffset (long offset)
		{
			const string __id = "fileIndexAtOffset.(J)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='fileName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fileName", "(I)Ljava/lang/String;", "")]
		public unsafe string FileName (int index)
		{
			const string __id = "fileName.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='fileOffset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fileOffset", "(I)J", "")]
		public unsafe long FileOffset (int index)
		{
			const string __id = "fileOffset.(I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='filePath' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("filePath", "(I)Ljava/lang/String;", "")]
		public unsafe string FilePath (int index)
		{
			const string __id = "filePath.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='filePath' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("filePath", "(ILjava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string FilePath (int index, string savePath)
		{
			const string __id = "filePath.(ILjava/lang/String;)Ljava/lang/String;";
			IntPtr native_savePath = JNIEnv.NewString (savePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (native_savePath);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_savePath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='fileSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fileSize", "(I)J", "")]
		public unsafe long FileSize (int index)
		{
			const string __id = "fileSize.(I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='hash' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hash", "(I)Lcom/frostwire/jlibtorrent/Sha1Hash;", "")]
		public unsafe global::FrostWire.Libtorrent.Sha1Hash Hash (int index)
		{
			const string __id = "hash.(I)Lcom/frostwire/jlibtorrent/Sha1Hash;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Sha1Hash> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='mapBlock' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("mapBlock", "(IJI)Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<global::FrostWire.Libtorrent.FileSlice> MapBlock (int piece, long offset, int size)
		{
			const string __id = "mapBlock.(IJI)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (piece);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::FrostWire.Libtorrent.FileSlice>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='mapFile' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("mapFile", "(IJI)Lcom/frostwire/jlibtorrent/PeerRequest;", "")]
		public unsafe global::FrostWire.Libtorrent.PeerRequest MapFile (int file, long offset, int size)
		{
			const string __id = "mapFile.(IJI)Lcom/frostwire/jlibtorrent/PeerRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (file);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (size);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.PeerRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='name' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='name' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("name", "(Ljava/lang/String;)V", "")]
		public unsafe void Name (string name)
		{
			const string __id = "name.(Ljava/lang/String;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='numFiles' and count(parameter)=0]"
		[Register ("numFiles", "()I", "")]
		public unsafe int NumFiles ()
		{
			const string __id = "numFiles.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='numPieces' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='numPieces' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("numPieces", "(I)V", "")]
		public unsafe void NumPieces (int n)
		{
			const string __id = "numPieces.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (n);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='padFileAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("padFileAt", "(I)Z", "")]
		public unsafe bool PadFileAt (int index)
		{
			const string __id = "padFileAt.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='paths' and count(parameter)=0]"
		[Register ("paths", "()Ljava/util/ArrayList;", "")]
		public unsafe global::System.Collections.Generic.IList<string> Paths ()
		{
			const string __id = "paths.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='pieceLength' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='pieceLength' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pieceLength", "(I)V", "")]
		public unsafe void PieceLength (int l)
		{
			const string __id = "pieceLength.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (l);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='pieceSize' and count(parameter)=1 and parameter[1][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='renameFile' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("renameFile", "(ILjava/lang/String;)V", "")]
		public unsafe void RenameFile (int index, string newFilename)
		{
			const string __id = "renameFile.(ILjava/lang/String;)V";
			IntPtr native_newFilename = JNIEnv.NewString (newFilename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (native_newFilename);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_newFilename);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='reserve' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reserve", "(I)V", "")]
		public unsafe void Reserve (int numFiles)
		{
			const string __id = "reserve.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (numFiles);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='swig' and count(parameter)=0]"
		[Register ("swig", "()Lcom/frostwire/jlibtorrent/swig/file_storage;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.File_storage Swig ()
		{
			const string __id = "swig.()Lcom/frostwire/jlibtorrent/swig/file_storage;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.File_storage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='ti' and count(parameter)=0]"
		[Register ("ti", "()Lcom/frostwire/jlibtorrent/swig/torrent_info;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Torrent_info Ti ()
		{
			const string __id = "ti.()Lcom/frostwire/jlibtorrent/swig/torrent_info;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Torrent_info> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent']/class[@name='FileStorage']/method[@name='totalSize' and count(parameter)=0]"
		[Register ("totalSize", "()J", "")]
		public unsafe long TotalSize ()
		{
			const string __id = "totalSize.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
