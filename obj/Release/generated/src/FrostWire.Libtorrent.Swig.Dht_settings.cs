using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace FrostWire.Libtorrent.Swig {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']"
	[global::Android.Runtime.Register ("com/frostwire/jlibtorrent/swig/dht_settings", DoNotGenerateAcw=true)]
	public partial class Dht_settings : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/field[@name='swigCMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/frostwire/jlibtorrent/swig/dht_settings", typeof (Dht_settings));
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

		protected Dht_settings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/constructor[@name='dht_settings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Dht_settings ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/constructor[@name='dht_settings' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(JZ)V", "")]
		protected unsafe Dht_settings (long cPtr, bool cMemoryOwn)
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

		static Delegate cb_getAggressive_lookups;
#pragma warning disable 0169
		static Delegate GetGetAggressive_lookupsHandler ()
		{
			if (cb_getAggressive_lookups == null)
				cb_getAggressive_lookups = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAggressive_lookups);
			return cb_getAggressive_lookups;
		}

		static bool n_GetAggressive_lookups (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Aggressive_lookups;
		}
#pragma warning restore 0169

		static Delegate cb_setAggressive_lookups_Z;
#pragma warning disable 0169
		static Delegate GetSetAggressive_lookups_ZHandler ()
		{
			if (cb_setAggressive_lookups_Z == null)
				cb_setAggressive_lookups_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAggressive_lookups_Z);
			return cb_setAggressive_lookups_Z;
		}

		static void n_SetAggressive_lookups_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Aggressive_lookups = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Aggressive_lookups {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getAggressive_lookups' and count(parameter)=0]"
			[Register ("getAggressive_lookups", "()Z", "GetGetAggressive_lookupsHandler")]
			get {
				const string __id = "getAggressive_lookups.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setAggressive_lookups' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAggressive_lookups", "(Z)V", "GetSetAggressive_lookups_ZHandler")]
			set {
				const string __id = "setAggressive_lookups.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBlock_ratelimit;
#pragma warning disable 0169
		static Delegate GetGetBlock_ratelimitHandler ()
		{
			if (cb_getBlock_ratelimit == null)
				cb_getBlock_ratelimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBlock_ratelimit);
			return cb_getBlock_ratelimit;
		}

		static int n_GetBlock_ratelimit (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Block_ratelimit;
		}
#pragma warning restore 0169

		static Delegate cb_setBlock_ratelimit_I;
#pragma warning disable 0169
		static Delegate GetSetBlock_ratelimit_IHandler ()
		{
			if (cb_setBlock_ratelimit_I == null)
				cb_setBlock_ratelimit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBlock_ratelimit_I);
			return cb_setBlock_ratelimit_I;
		}

		static void n_SetBlock_ratelimit_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Block_ratelimit = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Block_ratelimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getBlock_ratelimit' and count(parameter)=0]"
			[Register ("getBlock_ratelimit", "()I", "GetGetBlock_ratelimitHandler")]
			get {
				const string __id = "getBlock_ratelimit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setBlock_ratelimit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBlock_ratelimit", "(I)V", "GetSetBlock_ratelimit_IHandler")]
			set {
				const string __id = "setBlock_ratelimit.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBlock_timeout;
#pragma warning disable 0169
		static Delegate GetGetBlock_timeoutHandler ()
		{
			if (cb_getBlock_timeout == null)
				cb_getBlock_timeout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBlock_timeout);
			return cb_getBlock_timeout;
		}

		static int n_GetBlock_timeout (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Block_timeout;
		}
#pragma warning restore 0169

		static Delegate cb_setBlock_timeout_I;
#pragma warning disable 0169
		static Delegate GetSetBlock_timeout_IHandler ()
		{
			if (cb_setBlock_timeout_I == null)
				cb_setBlock_timeout_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBlock_timeout_I);
			return cb_setBlock_timeout_I;
		}

		static void n_SetBlock_timeout_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Block_timeout = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Block_timeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getBlock_timeout' and count(parameter)=0]"
			[Register ("getBlock_timeout", "()I", "GetGetBlock_timeoutHandler")]
			get {
				const string __id = "getBlock_timeout.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setBlock_timeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBlock_timeout", "(I)V", "GetSetBlock_timeout_IHandler")]
			set {
				const string __id = "setBlock_timeout.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEnforce_node_id;
#pragma warning disable 0169
		static Delegate GetGetEnforce_node_idHandler ()
		{
			if (cb_getEnforce_node_id == null)
				cb_getEnforce_node_id = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetEnforce_node_id);
			return cb_getEnforce_node_id;
		}

		static bool n_GetEnforce_node_id (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Enforce_node_id;
		}
#pragma warning restore 0169

		static Delegate cb_setEnforce_node_id_Z;
#pragma warning disable 0169
		static Delegate GetSetEnforce_node_id_ZHandler ()
		{
			if (cb_setEnforce_node_id_Z == null)
				cb_setEnforce_node_id_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEnforce_node_id_Z);
			return cb_setEnforce_node_id_Z;
		}

		static void n_SetEnforce_node_id_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enforce_node_id = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Enforce_node_id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getEnforce_node_id' and count(parameter)=0]"
			[Register ("getEnforce_node_id", "()Z", "GetGetEnforce_node_idHandler")]
			get {
				const string __id = "getEnforce_node_id.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setEnforce_node_id' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnforce_node_id", "(Z)V", "GetSetEnforce_node_id_ZHandler")]
			set {
				const string __id = "setEnforce_node_id.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExtended_routing_table;
#pragma warning disable 0169
		static Delegate GetGetExtended_routing_tableHandler ()
		{
			if (cb_getExtended_routing_table == null)
				cb_getExtended_routing_table = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetExtended_routing_table);
			return cb_getExtended_routing_table;
		}

		static bool n_GetExtended_routing_table (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Extended_routing_table;
		}
#pragma warning restore 0169

		static Delegate cb_setExtended_routing_table_Z;
#pragma warning disable 0169
		static Delegate GetSetExtended_routing_table_ZHandler ()
		{
			if (cb_setExtended_routing_table_Z == null)
				cb_setExtended_routing_table_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetExtended_routing_table_Z);
			return cb_setExtended_routing_table_Z;
		}

		static void n_SetExtended_routing_table_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Extended_routing_table = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Extended_routing_table {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getExtended_routing_table' and count(parameter)=0]"
			[Register ("getExtended_routing_table", "()Z", "GetGetExtended_routing_tableHandler")]
			get {
				const string __id = "getExtended_routing_table.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setExtended_routing_table' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setExtended_routing_table", "(Z)V", "GetSetExtended_routing_table_ZHandler")]
			set {
				const string __id = "setExtended_routing_table.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIgnore_dark_internet;
#pragma warning disable 0169
		static Delegate GetGetIgnore_dark_internetHandler ()
		{
			if (cb_getIgnore_dark_internet == null)
				cb_getIgnore_dark_internet = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetIgnore_dark_internet);
			return cb_getIgnore_dark_internet;
		}

		static bool n_GetIgnore_dark_internet (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ignore_dark_internet;
		}
#pragma warning restore 0169

		static Delegate cb_setIgnore_dark_internet_Z;
#pragma warning disable 0169
		static Delegate GetSetIgnore_dark_internet_ZHandler ()
		{
			if (cb_setIgnore_dark_internet_Z == null)
				cb_setIgnore_dark_internet_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIgnore_dark_internet_Z);
			return cb_setIgnore_dark_internet_Z;
		}

		static void n_SetIgnore_dark_internet_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Ignore_dark_internet = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Ignore_dark_internet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getIgnore_dark_internet' and count(parameter)=0]"
			[Register ("getIgnore_dark_internet", "()Z", "GetGetIgnore_dark_internetHandler")]
			get {
				const string __id = "getIgnore_dark_internet.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setIgnore_dark_internet' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIgnore_dark_internet", "(Z)V", "GetSetIgnore_dark_internet_ZHandler")]
			set {
				const string __id = "setIgnore_dark_internet.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getItem_lifetime;
#pragma warning disable 0169
		static Delegate GetGetItem_lifetimeHandler ()
		{
			if (cb_getItem_lifetime == null)
				cb_getItem_lifetime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItem_lifetime);
			return cb_getItem_lifetime;
		}

		static int n_GetItem_lifetime (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Item_lifetime;
		}
#pragma warning restore 0169

		static Delegate cb_setItem_lifetime_I;
#pragma warning disable 0169
		static Delegate GetSetItem_lifetime_IHandler ()
		{
			if (cb_setItem_lifetime_I == null)
				cb_setItem_lifetime_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetItem_lifetime_I);
			return cb_setItem_lifetime_I;
		}

		static void n_SetItem_lifetime_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Item_lifetime = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Item_lifetime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getItem_lifetime' and count(parameter)=0]"
			[Register ("getItem_lifetime", "()I", "GetGetItem_lifetimeHandler")]
			get {
				const string __id = "getItem_lifetime.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setItem_lifetime' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItem_lifetime", "(I)V", "GetSetItem_lifetime_IHandler")]
			set {
				const string __id = "setItem_lifetime.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMax_dht_items;
#pragma warning disable 0169
		static Delegate GetGetMax_dht_itemsHandler ()
		{
			if (cb_getMax_dht_items == null)
				cb_getMax_dht_items = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMax_dht_items);
			return cb_getMax_dht_items;
		}

		static int n_GetMax_dht_items (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Max_dht_items;
		}
#pragma warning restore 0169

		static Delegate cb_setMax_dht_items_I;
#pragma warning disable 0169
		static Delegate GetSetMax_dht_items_IHandler ()
		{
			if (cb_setMax_dht_items_I == null)
				cb_setMax_dht_items_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMax_dht_items_I);
			return cb_setMax_dht_items_I;
		}

		static void n_SetMax_dht_items_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Max_dht_items = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Max_dht_items {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getMax_dht_items' and count(parameter)=0]"
			[Register ("getMax_dht_items", "()I", "GetGetMax_dht_itemsHandler")]
			get {
				const string __id = "getMax_dht_items.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setMax_dht_items' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMax_dht_items", "(I)V", "GetSetMax_dht_items_IHandler")]
			set {
				const string __id = "setMax_dht_items.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMax_fail_count;
#pragma warning disable 0169
		static Delegate GetGetMax_fail_countHandler ()
		{
			if (cb_getMax_fail_count == null)
				cb_getMax_fail_count = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMax_fail_count);
			return cb_getMax_fail_count;
		}

		static int n_GetMax_fail_count (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Max_fail_count;
		}
#pragma warning restore 0169

		static Delegate cb_setMax_fail_count_I;
#pragma warning disable 0169
		static Delegate GetSetMax_fail_count_IHandler ()
		{
			if (cb_setMax_fail_count_I == null)
				cb_setMax_fail_count_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMax_fail_count_I);
			return cb_setMax_fail_count_I;
		}

		static void n_SetMax_fail_count_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Max_fail_count = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Max_fail_count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getMax_fail_count' and count(parameter)=0]"
			[Register ("getMax_fail_count", "()I", "GetGetMax_fail_countHandler")]
			get {
				const string __id = "getMax_fail_count.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setMax_fail_count' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMax_fail_count", "(I)V", "GetSetMax_fail_count_IHandler")]
			set {
				const string __id = "setMax_fail_count.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMax_infohashes_sample_count;
#pragma warning disable 0169
		static Delegate GetGetMax_infohashes_sample_countHandler ()
		{
			if (cb_getMax_infohashes_sample_count == null)
				cb_getMax_infohashes_sample_count = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMax_infohashes_sample_count);
			return cb_getMax_infohashes_sample_count;
		}

		static int n_GetMax_infohashes_sample_count (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Max_infohashes_sample_count;
		}
#pragma warning restore 0169

		static Delegate cb_setMax_infohashes_sample_count_I;
#pragma warning disable 0169
		static Delegate GetSetMax_infohashes_sample_count_IHandler ()
		{
			if (cb_setMax_infohashes_sample_count_I == null)
				cb_setMax_infohashes_sample_count_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMax_infohashes_sample_count_I);
			return cb_setMax_infohashes_sample_count_I;
		}

		static void n_SetMax_infohashes_sample_count_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Max_infohashes_sample_count = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Max_infohashes_sample_count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getMax_infohashes_sample_count' and count(parameter)=0]"
			[Register ("getMax_infohashes_sample_count", "()I", "GetGetMax_infohashes_sample_countHandler")]
			get {
				const string __id = "getMax_infohashes_sample_count.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setMax_infohashes_sample_count' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMax_infohashes_sample_count", "(I)V", "GetSetMax_infohashes_sample_count_IHandler")]
			set {
				const string __id = "setMax_infohashes_sample_count.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMax_peers;
#pragma warning disable 0169
		static Delegate GetGetMax_peersHandler ()
		{
			if (cb_getMax_peers == null)
				cb_getMax_peers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMax_peers);
			return cb_getMax_peers;
		}

		static int n_GetMax_peers (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Max_peers;
		}
#pragma warning restore 0169

		static Delegate cb_setMax_peers_I;
#pragma warning disable 0169
		static Delegate GetSetMax_peers_IHandler ()
		{
			if (cb_setMax_peers_I == null)
				cb_setMax_peers_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMax_peers_I);
			return cb_setMax_peers_I;
		}

		static void n_SetMax_peers_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Max_peers = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Max_peers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getMax_peers' and count(parameter)=0]"
			[Register ("getMax_peers", "()I", "GetGetMax_peersHandler")]
			get {
				const string __id = "getMax_peers.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setMax_peers' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMax_peers", "(I)V", "GetSetMax_peers_IHandler")]
			set {
				const string __id = "setMax_peers.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMax_peers_reply;
#pragma warning disable 0169
		static Delegate GetGetMax_peers_replyHandler ()
		{
			if (cb_getMax_peers_reply == null)
				cb_getMax_peers_reply = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMax_peers_reply);
			return cb_getMax_peers_reply;
		}

		static int n_GetMax_peers_reply (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Max_peers_reply;
		}
#pragma warning restore 0169

		static Delegate cb_setMax_peers_reply_I;
#pragma warning disable 0169
		static Delegate GetSetMax_peers_reply_IHandler ()
		{
			if (cb_setMax_peers_reply_I == null)
				cb_setMax_peers_reply_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMax_peers_reply_I);
			return cb_setMax_peers_reply_I;
		}

		static void n_SetMax_peers_reply_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Max_peers_reply = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Max_peers_reply {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getMax_peers_reply' and count(parameter)=0]"
			[Register ("getMax_peers_reply", "()I", "GetGetMax_peers_replyHandler")]
			get {
				const string __id = "getMax_peers_reply.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setMax_peers_reply' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMax_peers_reply", "(I)V", "GetSetMax_peers_reply_IHandler")]
			set {
				const string __id = "setMax_peers_reply.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMax_torrent_search_reply;
#pragma warning disable 0169
		static Delegate GetGetMax_torrent_search_replyHandler ()
		{
			if (cb_getMax_torrent_search_reply == null)
				cb_getMax_torrent_search_reply = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMax_torrent_search_reply);
			return cb_getMax_torrent_search_reply;
		}

		static int n_GetMax_torrent_search_reply (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Max_torrent_search_reply;
		}
#pragma warning restore 0169

		static Delegate cb_setMax_torrent_search_reply_I;
#pragma warning disable 0169
		static Delegate GetSetMax_torrent_search_reply_IHandler ()
		{
			if (cb_setMax_torrent_search_reply_I == null)
				cb_setMax_torrent_search_reply_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMax_torrent_search_reply_I);
			return cb_setMax_torrent_search_reply_I;
		}

		static void n_SetMax_torrent_search_reply_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Max_torrent_search_reply = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Max_torrent_search_reply {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getMax_torrent_search_reply' and count(parameter)=0]"
			[Register ("getMax_torrent_search_reply", "()I", "GetGetMax_torrent_search_replyHandler")]
			get {
				const string __id = "getMax_torrent_search_reply.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setMax_torrent_search_reply' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMax_torrent_search_reply", "(I)V", "GetSetMax_torrent_search_reply_IHandler")]
			set {
				const string __id = "setMax_torrent_search_reply.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMax_torrents;
#pragma warning disable 0169
		static Delegate GetGetMax_torrentsHandler ()
		{
			if (cb_getMax_torrents == null)
				cb_getMax_torrents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMax_torrents);
			return cb_getMax_torrents;
		}

		static int n_GetMax_torrents (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Max_torrents;
		}
#pragma warning restore 0169

		static Delegate cb_setMax_torrents_I;
#pragma warning disable 0169
		static Delegate GetSetMax_torrents_IHandler ()
		{
			if (cb_setMax_torrents_I == null)
				cb_setMax_torrents_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMax_torrents_I);
			return cb_setMax_torrents_I;
		}

		static void n_SetMax_torrents_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Max_torrents = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Max_torrents {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getMax_torrents' and count(parameter)=0]"
			[Register ("getMax_torrents", "()I", "GetGetMax_torrentsHandler")]
			get {
				const string __id = "getMax_torrents.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setMax_torrents' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMax_torrents", "(I)V", "GetSetMax_torrents_IHandler")]
			set {
				const string __id = "setMax_torrents.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPrivacy_lookups;
#pragma warning disable 0169
		static Delegate GetGetPrivacy_lookupsHandler ()
		{
			if (cb_getPrivacy_lookups == null)
				cb_getPrivacy_lookups = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetPrivacy_lookups);
			return cb_getPrivacy_lookups;
		}

		static bool n_GetPrivacy_lookups (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Privacy_lookups;
		}
#pragma warning restore 0169

		static Delegate cb_setPrivacy_lookups_Z;
#pragma warning disable 0169
		static Delegate GetSetPrivacy_lookups_ZHandler ()
		{
			if (cb_setPrivacy_lookups_Z == null)
				cb_setPrivacy_lookups_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPrivacy_lookups_Z);
			return cb_setPrivacy_lookups_Z;
		}

		static void n_SetPrivacy_lookups_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Privacy_lookups = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Privacy_lookups {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getPrivacy_lookups' and count(parameter)=0]"
			[Register ("getPrivacy_lookups", "()Z", "GetGetPrivacy_lookupsHandler")]
			get {
				const string __id = "getPrivacy_lookups.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setPrivacy_lookups' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPrivacy_lookups", "(Z)V", "GetSetPrivacy_lookups_ZHandler")]
			set {
				const string __id = "setPrivacy_lookups.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRead_only;
#pragma warning disable 0169
		static Delegate GetGetRead_onlyHandler ()
		{
			if (cb_getRead_only == null)
				cb_getRead_only = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetRead_only);
			return cb_getRead_only;
		}

		static bool n_GetRead_only (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Read_only;
		}
#pragma warning restore 0169

		static Delegate cb_setRead_only_Z;
#pragma warning disable 0169
		static Delegate GetSetRead_only_ZHandler ()
		{
			if (cb_setRead_only_Z == null)
				cb_setRead_only_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRead_only_Z);
			return cb_setRead_only_Z;
		}

		static void n_SetRead_only_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Read_only = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Read_only {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getRead_only' and count(parameter)=0]"
			[Register ("getRead_only", "()Z", "GetGetRead_onlyHandler")]
			get {
				const string __id = "getRead_only.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setRead_only' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRead_only", "(Z)V", "GetSetRead_only_ZHandler")]
			set {
				const string __id = "setRead_only.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRestrict_routing_ips;
#pragma warning disable 0169
		static Delegate GetGetRestrict_routing_ipsHandler ()
		{
			if (cb_getRestrict_routing_ips == null)
				cb_getRestrict_routing_ips = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetRestrict_routing_ips);
			return cb_getRestrict_routing_ips;
		}

		static bool n_GetRestrict_routing_ips (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Restrict_routing_ips;
		}
#pragma warning restore 0169

		static Delegate cb_setRestrict_routing_ips_Z;
#pragma warning disable 0169
		static Delegate GetSetRestrict_routing_ips_ZHandler ()
		{
			if (cb_setRestrict_routing_ips_Z == null)
				cb_setRestrict_routing_ips_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRestrict_routing_ips_Z);
			return cb_setRestrict_routing_ips_Z;
		}

		static void n_SetRestrict_routing_ips_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Restrict_routing_ips = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Restrict_routing_ips {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getRestrict_routing_ips' and count(parameter)=0]"
			[Register ("getRestrict_routing_ips", "()Z", "GetGetRestrict_routing_ipsHandler")]
			get {
				const string __id = "getRestrict_routing_ips.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setRestrict_routing_ips' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRestrict_routing_ips", "(Z)V", "GetSetRestrict_routing_ips_ZHandler")]
			set {
				const string __id = "setRestrict_routing_ips.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRestrict_search_ips;
#pragma warning disable 0169
		static Delegate GetGetRestrict_search_ipsHandler ()
		{
			if (cb_getRestrict_search_ips == null)
				cb_getRestrict_search_ips = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetRestrict_search_ips);
			return cb_getRestrict_search_ips;
		}

		static bool n_GetRestrict_search_ips (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Restrict_search_ips;
		}
#pragma warning restore 0169

		static Delegate cb_setRestrict_search_ips_Z;
#pragma warning disable 0169
		static Delegate GetSetRestrict_search_ips_ZHandler ()
		{
			if (cb_setRestrict_search_ips_Z == null)
				cb_setRestrict_search_ips_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRestrict_search_ips_Z);
			return cb_setRestrict_search_ips_Z;
		}

		static void n_SetRestrict_search_ips_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Restrict_search_ips = value;
		}
#pragma warning restore 0169

		public virtual unsafe bool Restrict_search_ips {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getRestrict_search_ips' and count(parameter)=0]"
			[Register ("getRestrict_search_ips", "()Z", "GetGetRestrict_search_ipsHandler")]
			get {
				const string __id = "getRestrict_search_ips.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setRestrict_search_ips' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRestrict_search_ips", "(Z)V", "GetSetRestrict_search_ips_ZHandler")]
			set {
				const string __id = "setRestrict_search_ips.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSample_infohashes_interval;
#pragma warning disable 0169
		static Delegate GetGetSample_infohashes_intervalHandler ()
		{
			if (cb_getSample_infohashes_interval == null)
				cb_getSample_infohashes_interval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSample_infohashes_interval);
			return cb_getSample_infohashes_interval;
		}

		static int n_GetSample_infohashes_interval (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sample_infohashes_interval;
		}
#pragma warning restore 0169

		static Delegate cb_setSample_infohashes_interval_I;
#pragma warning disable 0169
		static Delegate GetSetSample_infohashes_interval_IHandler ()
		{
			if (cb_setSample_infohashes_interval_I == null)
				cb_setSample_infohashes_interval_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSample_infohashes_interval_I);
			return cb_setSample_infohashes_interval_I;
		}

		static void n_SetSample_infohashes_interval_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Sample_infohashes_interval = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Sample_infohashes_interval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getSample_infohashes_interval' and count(parameter)=0]"
			[Register ("getSample_infohashes_interval", "()I", "GetGetSample_infohashes_intervalHandler")]
			get {
				const string __id = "getSample_infohashes_interval.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setSample_infohashes_interval' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSample_infohashes_interval", "(I)V", "GetSetSample_infohashes_interval_IHandler")]
			set {
				const string __id = "setSample_infohashes_interval.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSearch_branching;
#pragma warning disable 0169
		static Delegate GetGetSearch_branchingHandler ()
		{
			if (cb_getSearch_branching == null)
				cb_getSearch_branching = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSearch_branching);
			return cb_getSearch_branching;
		}

		static int n_GetSearch_branching (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Search_branching;
		}
#pragma warning restore 0169

		static Delegate cb_setSearch_branching_I;
#pragma warning disable 0169
		static Delegate GetSetSearch_branching_IHandler ()
		{
			if (cb_setSearch_branching_I == null)
				cb_setSearch_branching_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSearch_branching_I);
			return cb_setSearch_branching_I;
		}

		static void n_SetSearch_branching_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Search_branching = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Search_branching {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getSearch_branching' and count(parameter)=0]"
			[Register ("getSearch_branching", "()I", "GetGetSearch_branchingHandler")]
			get {
				const string __id = "getSearch_branching.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setSearch_branching' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSearch_branching", "(I)V", "GetSetSearch_branching_IHandler")]
			set {
				const string __id = "setSearch_branching.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUpload_rate_limit;
#pragma warning disable 0169
		static Delegate GetGetUpload_rate_limitHandler ()
		{
			if (cb_getUpload_rate_limit == null)
				cb_getUpload_rate_limit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUpload_rate_limit);
			return cb_getUpload_rate_limit;
		}

		static int n_GetUpload_rate_limit (IntPtr jnienv, IntPtr native__this)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Upload_rate_limit;
		}
#pragma warning restore 0169

		static Delegate cb_setUpload_rate_limit_I;
#pragma warning disable 0169
		static Delegate GetSetUpload_rate_limit_IHandler ()
		{
			if (cb_setUpload_rate_limit_I == null)
				cb_setUpload_rate_limit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUpload_rate_limit_I);
			return cb_setUpload_rate_limit_I;
		}

		static void n_SetUpload_rate_limit_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Upload_rate_limit = value;
		}
#pragma warning restore 0169

		public virtual unsafe int Upload_rate_limit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getUpload_rate_limit' and count(parameter)=0]"
			[Register ("getUpload_rate_limit", "()I", "GetGetUpload_rate_limitHandler")]
			get {
				const string __id = "getUpload_rate_limit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='setUpload_rate_limit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUpload_rate_limit", "(I)V", "GetSetUpload_rate_limit_IHandler")]
			set {
				const string __id = "setUpload_rate_limit.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
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
			global::FrostWire.Libtorrent.Swig.Dht_settings __this = global::Java.Lang.Object.GetObject<global::FrostWire.Libtorrent.Swig.Dht_settings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Delete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='delete' and count(parameter)=0]"
		[Register ("delete", "()V", "GetDeleteHandler")]
		public virtual unsafe void Delete ()
		{
			const string __id = "delete.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.frostwire.jlibtorrent.swig']/class[@name='dht_settings']/method[@name='getCPtr' and count(parameter)=1 and parameter[1][@type='com.frostwire.jlibtorrent.swig.dht_settings']]"
		[Register ("getCPtr", "(Lcom/frostwire/jlibtorrent/swig/dht_settings;)J", "")]
		protected static unsafe long GetCPtr (global::FrostWire.Libtorrent.Swig.Dht_settings obj)
		{
			const string __id = "getCPtr.(Lcom/frostwire/jlibtorrent/swig/dht_settings;)J";
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
