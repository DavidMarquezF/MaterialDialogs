using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFollestad.MaterialDialogs
{
    public partial class MaterialDialog
    {
        public MaterialDialog(Context windowContext): this(windowContext, DEFAULT_BEHAVIOR)
        {
        }

        public MaterialDialog Title( string title)
        {
            return Title(null, title);
        }

        public MaterialDialog Message(string message)
        {
            return Message(null, message, null);
        }
    }
}