using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace Bastiaan.TorrentStream
{
    public partial class TorrentOptions
    {
        public partial class Builder
        {
            public Builder AnonymousMode(bool enabled)
            {
                return AnonymousMode((Java.Lang.Boolean)enabled);
            }

            public Builder RemoveFilesAfterStop(bool enabled)
            {
                return RemoveFilesAfterStop((Java.Lang.Boolean)enabled);
            }
        }
    }
}