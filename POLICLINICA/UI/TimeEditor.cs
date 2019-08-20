using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace POLICLINICA.UI
{
    public class TimeEditor : BaseGridEditor
    {
        public override object Value
        {
            get
            {
                var editor = (RadTimePickerElement)this.EditorElement;
                var dateValue = editor.Value as DateTime?;
                if (dateValue.HasValue)
                {
                    return new TimeSpan(dateValue.Value.Hour, dateValue.Value.Minute, dateValue.Value.Second);
                }

                return TimeSpan.MinValue;
            }
            set
            {
                var editor = (RadTimePickerElement)this.EditorElement;
                if (value != null && value != DBNull.Value && value is TimeSpan)
                {
                    var timeSpan = (TimeSpan)value;
                    editor.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
                }
            }
        }

        public override void BeginEdit()
        {
            base.BeginEdit();
            ((RadTimePickerElement)this.EditorElement).ValueChanged += TimeEditor_ValueChanged;
            this.EditorElement.Focus();
        }

        private void TimeEditor_ValueChanged(object sender, EventArgs e)
        {
            OnValueChanged();
        }

        public override bool EndEdit()
        {
            ((RadTimePickerElement)this.EditorElement).ValueChanged -= TimeEditor_ValueChanged;
            return base.EndEdit();
        }

        protected override RadElement CreateEditorElement()
        {
            return new RadTimePickerElement();
        }
    }
}
