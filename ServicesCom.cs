using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saloon
{
    public partial class ServicesCom : UserControl
    {
        private Service serviceData;

        public ServicesCom()
        {
            InitializeComponent();
        }

        public void SetServiceData(Service service)
        {
            serviceData = service;
            ServiceNameLbl.Text = service.Name;
            DescLbl.Text = service.Description;
            PriceLbl.Text = $"RP {service.Price:N0}"; // Format price in Rupiah
        }

        public void ResetCheckBox()
        {
            BookingBox.Checked = false;
        }

        private void BookingBox_CheckedChanged(object sender, EventArgs e)
        {
            // Notify BookingServices of the change in selection state
            var parentForm = this.FindForm() as BookingServices;
            if (parentForm != null)
            {
                parentForm.UpdateSelectedServices(serviceData, BookingBox.Checked);
            }
        }
    }
}
