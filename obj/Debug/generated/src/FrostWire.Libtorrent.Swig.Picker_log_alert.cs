using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/picker_log_alert", DoNotGenerateAcw=true)]
	public partial class Picker_log_alert : global::FrostWire.Libtorrent.Swig.Peer_alert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='alert_type']"
		[Register ("alert_type")]
		public static int AlertType {
			get {
				const string __id = "alert_type.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='backup1']"
		[Register ("backup1")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t Backup1 {
			get {
				const string __id = "backup1.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='backup2']"
		[Register ("backup2")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t Backup2 {
			get {
				const string __id = "backup2.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='end_game']"
		[Register ("end_game")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t EndGame {
			get {
				const string __id = "end_game.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='partial_ratio']"
		[Register ("partial_ratio")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t PartialRatio {
			get {
				const string __id = "partial_ratio.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='prefer_contiguous']"
		[Register ("prefer_contiguous")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t PreferContiguous {
			get {
				const string __id = "prefer_contiguous.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='prio_sequential_pieces']"
		[Register ("prio_sequential_pieces")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t PrioSequentialPieces {
			get {
				const string __id = "prio_sequential_pieces.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='prioritize_partials']"
		[Register ("prioritize_partials")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t PrioritizePartials {
			get {
				const string __id = "prioritize_partials.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='priority']"
		[Register ("priority")]
		public static int Priority {
			get {
				const string __id = "priority.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='random_pieces']"
		[Register ("random_pieces")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t RandomPieces {
			get {
				const string __id = "random_pieces.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='rarest_first']"
		[Register ("rarest_first")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t RarestFirst {
			get {
				const string __id = "rarest_first.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='rarest_first_partials']"
		[Register ("rarest_first_partials")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t RarestFirstPartials {
			get {
				const string __id = "rarest_first_partials.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='reverse_pieces']"
		[Register ("reverse_pieces")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t ReversePieces {
			get {
				const string __id = "reverse_pieces.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='reverse_rarest_first']"
		[Register ("reverse_rarest_first")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t ReverseRarestFirst {
			get {
				const string __id = "reverse_rarest_first.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='reverse_sequential']"
		[Register ("reverse_sequential")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t ReverseSequential {
			get {
				const string __id = "reverse_sequential.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='sequential_pieces']"
		[Register ("sequential_pieces")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t SequentialPieces {
			get {
				const string __id = "sequential_pieces.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='static_category']"
		[Register ("static_category")]
		public static global::FrostWire.Libtorrent.Swig.Alert_category_t StaticCategory {
			get {
				const string __id = "static_category.Lcom/frostwire/jlibtorrent/swig/alert_category_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Alert_category_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='suggested_pieces']"
		[Register ("suggested_pieces")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t SuggestedPieces {
			get {
				const string __id = "suggested_pieces.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/field[@name='time_critical']"
		[Register ("time_critical")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t TimeCritical {
			get {
				const string __id = "time_critical.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/picker_log_alert", typeof (Picker_log_alert));
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

		protected Picker_log_alert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/constructor[@name='picker_log_alert' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Picker_log_alert (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getPicker_flags;
#pragma warning disable 0169
		static Delegate GetGetPicker_flagsHandler ()
		{
			if (cb_getPicker_flags == null)
				cb_getPicker_flags = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPicker_flags);
			return cb_getPicker_flags;
		}

		static IntPtr n_GetPicker_flags (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Picker_log_alert __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_log_alert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Picker_flags);
		}
#pragma warning restore 0169

		public virtual unsafe global::FrostWire.Libtorrent.Swig.Picker_flags_t Picker_flags {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/method[@name='getPicker_flags' and count(parameter)=0]"
			[Register ("getPicker_flags", "()Lcom/frostwire/jlibtorrent/swig/picker_flags_t;", "GetGetPicker_flagsHandler")]
			get {
				const string __id = "getPicker_flags.()Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='picker_log_alert']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.picker_log_alert']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/picker_log_alert;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Picker_log_alert obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/picker_log_alert;)J";
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
