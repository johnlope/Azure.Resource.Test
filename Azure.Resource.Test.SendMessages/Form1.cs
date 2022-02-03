using Azure.Resource.Test.ServiceBus.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azure.Resource.Test.SendMessages
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConnectionString.Text) || string.IsNullOrEmpty(txtMessage.Text)) return;

            string topicName = "saleorderevents";
            string subscriptionName = "ProductionPlanningOrders";

            ServiceBusManager manager = new ServiceBusManager(txtConnectionString.Text);
            await manager.SendMessageAsync(topicName, subscriptionName, txtMessage.Text);
        }
    }
}
