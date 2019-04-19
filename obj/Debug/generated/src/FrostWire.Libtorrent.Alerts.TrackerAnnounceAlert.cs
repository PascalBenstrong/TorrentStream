using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerAnnounceAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert", DoNotGenerateAcw=true)]
	public sealed partial class TrackerAnnounceAlert : global::FrostWire.Libtorrent.Alerts.TrackerAlert {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerAnnounceAlert.TrackerAnnounceEvent']"
		[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert$TrackerAnnounceEvent", DoNotGenerateAcw=true)]
		public sealed partial class TrackerAnnounceEvent : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerAnnounceAlert.TrackerAnnounceEvent']/field[@name='COMPLETED']"
			[Register ("COMPLETED")]
			public static global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent Completed {
				get {
					const string __id = "COMPLETED.Lcom/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert$TrackerAnnounceEvent;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerAnnounceAlert.TrackerAnnounceEvent']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent None {
				get {
					const string __id = "NONE.Lcom/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert$TrackerAnnounceEvent;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerAnnounceAlert.TrackerAnnounceEvent']/field[@name='STARTED']"
			[Register ("STARTED")]
			public static global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent Started {
				get {
					const string __id = "STARTED.Lcom/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert$TrackerAnnounceEvent;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerAnnounceAlert.TrackerAnnounceEvent']/field[@name='STOPPED']"
			[Register ("STOPPED")]
			public static global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent Stopped {
				get {
					const string __id = "STOPPED.Lcom/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert$TrackerAnnounceEvent;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerAnnounceAlert.TrackerAnnounceEvent']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent Unknown {
				get {
					const string __id = "UNKNOWN.Lcom/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert$TrackerAnnounceEvent;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert$TrackerAnnounceEvent", typeof (TrackerAnnounceEvent));
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

			internal TrackerAnnounceEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe int Swig {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerAnnounceAlert.TrackerAnnounceEvent']/method[@name='getSwig' and count(parameter)=0]"
				[Register ("getSwig", "()I", "GetGetSwigHandler")]
				get {
					const string __id = "getSwig.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerAnnounceAlert.TrackerAnnounceEvent']/method[@name='fromSwig' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("fromSwig", "(I)Lcom/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert$TrackerAnnounceEvent;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent FromSwig (int swigValue)
			{
				const string __id = "fromSwig.(I)Lcom/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert$TrackerAnnounceEvent;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (swigValue);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerAnnounceAlert.TrackerAnnounceEvent']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert$TrackerAnnounceEvent;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert$TrackerAnnounceEvent;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerAnnounceAlert.TrackerAnnounceEvent']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert$TrackerAnnounceEvent;", "")]
			public static unsafe global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent[] Values ()
			{
				const string __id = "values.()[Lcom/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert$TrackerAnnounceEvent;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert", typeof (TrackerAnnounceAlert));
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

		internal TrackerAnnounceAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerAnnounceAlert']/constructor[@name='TrackerAnnounceAlert' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.tracker_announce_alert']]"
		[Register (".ctor", "(Lcom/frostwire/jlibtorrent/swig/tracker_announce_alert;)V", "")]
		public unsafe TrackerAnnounceAlert (global::FrostWire.Libtorrent.Swig.Tracker_announce_alert alert)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/frostwire/jlibtorrent/swig/tracker_announce_alert;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((alert == null) ? IntPtr.Zero : ((global::Java.Lang.Object) alert).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent Event {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='TrackerAnnounceAlert']/method[@name='getEvent' and count(parameter)=0]"
			[Register ("getEvent", "()Lcom/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert$TrackerAnnounceEvent;", "GetGetEventHandler")]
			get {
				const string __id = "getEvent.()Lcom/frostwire/jlibtorrent/alerts/TrackerAnnounceAlert$TrackerAnnounceEvent;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Alerts.TrackerAnnounceAlert.TrackerAnnounceEvent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
