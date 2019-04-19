using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Alerts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PickerLogAlert']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/alerts/PickerLogAlert", DoNotGenerateAcw=true)]
	public sealed partial class PickerLogAlert : global::FrostWire.Libtorrent.Alerts.PeerAlert {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PickerLogAlert']/field[@name='BACKUP1']"
		[Register ("BACKUP1")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t Backup1 {
			get {
				const string __id = "BACKUP1.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PickerLogAlert']/field[@name='BACKUP2']"
		[Register ("BACKUP2")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t Backup2 {
			get {
				const string __id = "BACKUP2.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PickerLogAlert']/field[@name='END_GAME']"
		[Register ("END_GAME")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t EndGame {
			get {
				const string __id = "END_GAME.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PickerLogAlert']/field[@name='PARTIAL_RATIO']"
		[Register ("PARTIAL_RATIO")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t PartialRatio {
			get {
				const string __id = "PARTIAL_RATIO.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PickerLogAlert']/field[@name='PREFER_CONTIGUOUS']"
		[Register ("PREFER_CONTIGUOUS")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t PreferContiguous {
			get {
				const string __id = "PREFER_CONTIGUOUS.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PickerLogAlert']/field[@name='PRIORITIZE_PARTIALS']"
		[Register ("PRIORITIZE_PARTIALS")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t PrioritizePartials {
			get {
				const string __id = "PRIORITIZE_PARTIALS.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PickerLogAlert']/field[@name='PRIO_SEQUENTIAL_PIECES']"
		[Register ("PRIO_SEQUENTIAL_PIECES")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t PrioSequentialPieces {
			get {
				const string __id = "PRIO_SEQUENTIAL_PIECES.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PickerLogAlert']/field[@name='RANDOM_PIECES']"
		[Register ("RANDOM_PIECES")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t RandomPieces {
			get {
				const string __id = "RANDOM_PIECES.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PickerLogAlert']/field[@name='RAREST_FIRST']"
		[Register ("RAREST_FIRST")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t RarestFirst {
			get {
				const string __id = "RAREST_FIRST.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PickerLogAlert']/field[@name='RAREST_FIRST_PARTIALS']"
		[Register ("RAREST_FIRST_PARTIALS")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t RarestFirstPartials {
			get {
				const string __id = "RAREST_FIRST_PARTIALS.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PickerLogAlert']/field[@name='REVERSE_PIECES']"
		[Register ("REVERSE_PIECES")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t ReversePieces {
			get {
				const string __id = "REVERSE_PIECES.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PickerLogAlert']/field[@name='REVERSE_RAREST_FIRST']"
		[Register ("REVERSE_RAREST_FIRST")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t ReverseRarestFirst {
			get {
				const string __id = "REVERSE_RAREST_FIRST.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PickerLogAlert']/field[@name='REVERSE_SEQUENTIAL']"
		[Register ("REVERSE_SEQUENTIAL")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t ReverseSequential {
			get {
				const string __id = "REVERSE_SEQUENTIAL.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PickerLogAlert']/field[@name='SEQUENTIAL_PIECES']"
		[Register ("SEQUENTIAL_PIECES")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t SequentialPieces {
			get {
				const string __id = "SEQUENTIAL_PIECES.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PickerLogAlert']/field[@name='SUGGESTED_PIECES']"
		[Register ("SUGGESTED_PIECES")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t SuggestedPieces {
			get {
				const string __id = "SUGGESTED_PIECES.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PickerLogAlert']/field[@name='TIME_CRITICAL']"
		[Register ("TIME_CRITICAL")]
		public static global::FrostWire.Libtorrent.Swig.Picker_flags_t TimeCritical {
			get {
				const string __id = "TIME_CRITICAL.Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/alerts/PickerLogAlert", typeof (PickerLogAlert));
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

		internal PickerLogAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.alerts']/class[@name='PickerLogAlert']/method[@name='pickerFlags' and count(parameter)=0]"
		[Register ("pickerFlags", "()Lcom/frostwire/jlibtorrent/swig/picker_flags_t;", "")]
		public unsafe global::FrostWire.Libtorrent.Swig.Picker_flags_t PickerFlags ()
		{
			const string __id = "pickerFlags.()Lcom/frostwire/jlibtorrent/swig/picker_flags_t;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Picker_flags_t> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
