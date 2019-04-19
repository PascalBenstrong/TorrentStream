using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/stats_alert", DoNotGenerateAcw=true)]
	public partial class Stats_alert : global::FrostWire.Libtorrent.Swig.Torrent_alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_alert.stats_channel']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/stats_alert$stats_channel", DoNotGenerateAcw=true)]
		public sealed partial class Stats_channel : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_alert.stats_channel']/field[@name='download_ip_protocol']"
			[Register ("download_ip_protocol")]
			public static global::FrostWire.Libtorrent.Swig.Stats_alert.Stats_channel DownloadIpProtocol {
				get {
					const string __id = "download_ip_protocol.Lcom/frostwire/jlibtorrent/swig/stats_alert$stats_channel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Stats_alert.Stats_channel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_alert.stats_channel']/field[@name='download_payload']"
			[Register ("download_payload")]
			public static global::FrostWire.Libtorrent.Swig.Stats_alert.Stats_channel DownloadPayload {
				get {
					const string __id = "download_payload.Lcom/frostwire/jlibtorrent/swig/stats_alert$stats_channel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Stats_alert.Stats_channel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_alert.stats_channel']/field[@name='download_protocol']"
			[Register ("download_protocol")]
			public static global::FrostWire.Libtorrent.Swig.Stats_alert.Stats_channel DownloadProtocol {
				get {
					const string __id = "download_protocol.Lcom/frostwire/jlibtorrent/swig/stats_alert$stats_channel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Stats_alert.Stats_channel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_alert.stats_channel']/field[@name='num_channels']"
			[Register ("num_channels")]
			public static global::FrostWire.Libtorrent.Swig.Stats_alert.Stats_channel NumChannels {
				get {
					const string __id = "num_channels.Lcom/frostwire/jlibtorrent/swig/stats_alert$stats_channel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Stats_alert.Stats_channel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_alert.stats_channel']/field[@name='upload_ip_protocol']"
			[Register ("upload_ip_protocol")]
			public static global::FrostWire.Libtorrent.Swig.Stats_alert.Stats_channel UploadIpProtocol {
				get {
					const string __id = "upload_ip_protocol.Lcom/frostwire/jlibtorrent/swig/stats_alert$stats_channel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Stats_alert.Stats_channel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_alert.stats_channel']/field[@name='upload_payload']"
			[Register ("upload_payload")]
			public static global::FrostWire.Libtorrent.Swig.Stats_alert.Stats_channel UploadPayload {
				get {
					const string __id = "upload_payload.Lcom/frostwire/jlibtorrent/swig/stats_alert$stats_channel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Stats_alert.Stats_channel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_alert.stats_channel']/field[@name='upload_protocol']"
			[Register ("upload_protocol")]
			public static global::FrostWire.Libtorrent.Swig.Stats_alert.Stats_channel UploadProtocol {
				get {
					const string __id = "upload_protocol.Lcom/frostwire/jlibtorrent/swig/stats_alert$stats_channel;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Stats_alert.Stats_channel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/stats_alert$stats_channel", typeof (Stats_channel));
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

			internal Stats_channel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_alert.stats_channel']/method[@name='swigToEnum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("swigToEnum", "(I)Lcom/frostwire/jlibtorrent/swig/stats_alert$stats_channel;", "")]
			public static unsafe global::FrostWire.Libtorrent.Swig.Stats_alert.Stats_channel SwigToEnum (int swigValue)
			{
				const string __id = "swigToEnum.(I)Lcom/frostwire/jlibtorrent/swig/stats_alert$stats_channel;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Stats_alert.Stats_channel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_alert.stats_channel']/method[@name='swigValue' and count(parameter)=0]"
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/stats_alert", typeof (Stats_alert));
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

		protected Stats_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_alert']/constructor[@name='stats_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Stats_alert (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getInterval;
#pragma warning disable 0169
		static Delegate GetGetIntervalHandler ()
		{
			if (cb_getInterval == null)
				cb_getInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInterval);
			return cb_getInterval;
		}

		static int n_GetInterval (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Stats_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Stats_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Interval;
		}
#pragma warning restore 0169

		public virtual unsafe int Interval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_alert']/method[@name='getInterval' and count(parameter)=0]"
			[Register ("getInterval", "()I", "GetGetIntervalHandler")]
			get {
				const string __id = "getInterval.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.stats_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/stats_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Stats_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/stats_alert;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_get_transferred_I;
#pragma warning disable 0169
		static Delegate GetGet_transferred_IHandler ()
		{
			if (cb_get_transferred_I == null)
				cb_get_transferred_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_Get_transferred_I);
			return cb_get_transferred_I;
		}

		static int n_Get_transferred_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::FrostWire.Libtorrent.Swig.Stats_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Stats_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_transferred (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='stats_alert']/method[@name='get_transferred' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get_transferred", "(I)I", "GetGet_transferred_IHandler")]
		public virtual unsafe int Get_transferred (int index)
		{
			const string __id = "get_transferred.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
