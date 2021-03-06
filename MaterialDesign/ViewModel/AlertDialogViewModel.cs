using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialDesign.ViewModel
{
    public class AlertDialogViewModel : ViewModel
    {
        private string m_message;

        public string Message
        {
            get
            {
                return m_message;
            }

            set
            {
                m_message = value;

                OnPropertyChanged(nameof(Message));
            }
        }

        public AlertDialogViewModel(string message)
            : base()
        {
            m_message = message;
        }
    }
}
