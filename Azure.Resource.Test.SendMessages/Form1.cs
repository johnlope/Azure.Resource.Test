using Azure.Resource.Test.EventGrid.Model;
using Azure.Resource.Test.ServiceBus.Services;
using Azure.Resource.Test.Services.EventGrid;
using Newtonsoft.Json;
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

        private async void btnSendToEventGrid_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConnectionString.Text) || string.IsNullOrEmpty(txtMessage.Text) || string.IsNullOrEmpty(txtAccessKey.Text)) return;

            btnSendMessage.Enabled = !btnSendMessage.Enabled;
            btnSendToEventGrid.Enabled = !btnSendToEventGrid.Enabled;

            EventGridManager manager = new EventGridManager(txtConnectionString.Text, txtAccessKey.Text);

            try
            {
                var gridEvents = Newtonsoft.Json.JsonConvert.DeserializeObject<List<GridEvent>>(txtMessage.Text);
                if (gridEvents.Any()) gridEvents[0].Id = Guid.NewGuid();

                string jsonContent = JsonConvert.SerializeObject(gridEvents);
                await manager.PublishEventsAsync(jsonContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btnSendMessage.Enabled = !btnSendMessage.Enabled;
            btnSendToEventGrid.Enabled = !btnSendToEventGrid.Enabled;

        }
    }
}
