using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/performance_alert", DoNotGenerateAcw=true)]
	public partial class Performance_alert : global::FrostWire.Libtorrent.Swig.Torrent_alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert.performance_warning_t']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t", DoNotGenerateAcw=true)]
		public sealed partial class Performance_warning_t : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert.performance_warning_t']/field[@name='aio_limit_reached']"
			[Register ("aio_limit_reached")]
			public static global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t AioLimitReached {
				get {
					const string __id = "aio_limit_reached.Lcom/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert.performance_warning_t']/field[@name='bittyrant_with_no_uplimit']"
			[Register ("bittyrant_with_no_uplimit")]
			public static global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t BittyrantWithNoUplimit {
				get {
					const string __id = "bittyrant_with_no_uplimit.Lcom/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert.performance_warning_t']/field[@name='download_limit_too_low']"
			[Register ("download_limit_too_low")]
			public static global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t DownloadLimitTooLow {
				get {
					const string __id = "download_limit_too_low.Lcom/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert.performance_warning_t']/field[@name='num_warnings']"
			[Register ("num_warnings")]
			public static global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t NumWarnings {
				get {
					const string __id = "num_warnings.Lcom/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert.performance_warning_t']/field[@name='outstanding_disk_buffer_limit_reached']"
			[Register ("outstanding_disk_buffer_limit_reached")]
			public static global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t OutstandingDiskBufferLimitReached {
				get {
					const string __id = "outstanding_disk_buffer_limit_reached.Lcom/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert.performance_warning_t']/field[@name='outstanding_request_limit_reached']"
			[Register ("outstanding_request_limit_reached")]
			public static global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t OutstandingRequestLimitReached {
				get {
					const string __id = "outstanding_request_limit_reached.Lcom/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert.performance_warning_t']/field[@name='send_buffer_watermark_too_low']"
			[Register ("send_buffer_watermark_too_low")]
			public static global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t SendBufferWatermarkTooLow {
				get {
					const string __id = "send_buffer_watermark_too_low.Lcom/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert.performance_warning_t']/field[@name='too_few_file_descriptors']"
			[Register ("too_few_file_descriptors")]
			public static global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t TooFewFileDescriptors {
				get {
					const string __id = "too_few_file_descriptors.Lcom/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert.performance_warning_t']/field[@name='too_few_outgoing_ports']"
			[Register ("too_few_outgoing_ports")]
			public static global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t TooFewOutgoingPorts {
				get {
					const string __id = "too_few_outgoing_ports.Lcom/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert.performance_warning_t']/field[@name='too_high_disk_queue_limit']"
			[Register ("too_high_disk_queue_limit")]
			public static global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t TooHighDiskQueueLimit {
				get {
					const string __id = "too_high_disk_queue_limit.Lcom/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert.performance_warning_t']/field[@name='too_many_optimistic_unchoke_slots']"
			[Register ("too_many_optimistic_unchoke_slots")]
			public static global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t TooManyOptimisticUnchokeSlots {
				get {
					const string __id = "too_many_optimistic_unchoke_slots.Lcom/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert.performance_warning_t']/field[@name='upload_limit_too_low']"
			[Register ("upload_limit_too_low")]
			public static global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t UploadLimitTooLow {
				get {
					const string __id = "upload_limit_too_low.Lcom/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t", typeof (Performance_warning_t));
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

			internal Performance_warning_t (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert.performance_warning_t']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert.performance_warning_t']/method[@name='swigValue' and count(parameter)=0]"
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/performance_alert", typeof (Performance_alert));
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

		protected Performance_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert']/constructor[@name='performance_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Performance_alert (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getWarning_code;
#pragma warning disable 0169
		static Delegate GetGetWarning_codeHandler ()
		{
			if (cb_getWarning_code == null)
				cb_getWarning_code = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWarning_code);
			return cb_getWarning_code;
		}

		static IntPtr n_GetWarning_code (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Performance_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Performance_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Warning_code);
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t Warning_code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert']/method[@name='getWarning_code' and count(parameter)=0]"
			[Register ("getWarning_code", "()Lcom/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t;", "GetGetWarning_codeHandler")]
			get {
				const string __id = "getWarning_code.()Lcom/frostwire/jlibtorrent/swig/performance_alert$performance_warning_t;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Performance_alert.Performance_warning_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='performance_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.performance_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/performance_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Performance_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/performance_alert;)J";
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
