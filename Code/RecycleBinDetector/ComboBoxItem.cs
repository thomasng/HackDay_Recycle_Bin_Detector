using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebEye.Controls.WinForms.WebCameraControl;

namespace RecycleApp
{
    public class ComboBoxItem
    {
        public ComboBoxItem(WebCameraId id)
        {
            _id = id;
        }

        private readonly WebCameraId _id;

        public WebCameraId Id
        {
            get { return _id; }
        }

        public override string ToString()
        {
            // Generates the text shown in the combo box.
            return _id.Name;
        }
    }
}
