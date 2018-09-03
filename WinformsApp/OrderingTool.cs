using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsApp
{
    public partial class OrderingTool : Form
    {
        OpenFinIntegration _openFin;

        public OrderingTool()
        {
            InitializeComponent();

            tickerComboBox.SelectedIndex = 0;
            actionComboBox.SelectedIndex = 0;
            orderTypeComboBox.SelectedIndex = 0;

            // OpenFin Integration
            _openFin = new OpenFinIntegration();
            _openFin.OrderReceived += openFin_OrderReceived;
            _openFin.RuntimeConnected += openFin_RuntimeConnected;
            _openFin.RuntimeDisconnected += openFin_RuntimeDisconnected;
            _openFin.AppConnected += openFin_AppConnected;
            _openFin.AppDisconnected += openFin_AppDisconnected;
        }

        private void orderTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(orderTypeComboBox.SelectedItem.ToString() == "Market Order")
            {
                limitUpDown.Value = 0;
                limitUpDown.Enabled = false;
            }
            else
            {
                limitUpDown.Enabled = true;
            }
        }

        private void submitOrderButton_Click(object sender, EventArgs e)
        {
            // Simulate submitting an order

            Enabled = false;
            orderStatusLabel.Text = "Processing Order...";

            var timer = new Timer()
            {
                Interval = 2000
            };

            timer.Tick += order_Complete;
            timer.Start();
        }

        private void order_Complete(object sender, EventArgs e)
        {
            var timer = sender as Timer;

            timer.Stop();

            orderStatusLabel.Text = "";
            Enabled = true;
        }

        private void launchCalculatorButton_Click(object sender, EventArgs e)
        {
            launchCalculatorButton.Enabled = false;
            _openFin.LaunchOpenFinApp();
        }

        #region OpenFin Events

        private void openFin_OrderReceived(object sender, ProcessOrderEventArgs e)
        {
            Invoke(new Action(() => 
            {
                tickerComboBox.SelectedItem = e.Order.Security;
                actionComboBox.SelectedItem = e.Order.OrderAction;
                orderTypeComboBox.SelectedItem = e.Order.OrderType;
                sharesUpDown.Value = e.Order.Shares;
                limitUpDown.Value = e.Order.Limit;

                submitOrderButton.PerformClick();
            }));
        }

        private void openFin_RuntimeConnected(object sender, EventArgs e)
        {
            Invoke(new Action(() => openFinStatusLabel.Text = "OpenFin Connected"));
        }

        private void openFin_RuntimeDisconnected(object sender, EventArgs e)
        {
            Invoke(new Action(() => 
            {
                openFinStatusLabel.Text = "OpenFin Disconnected";
                launchCalculatorButton.Enabled = true;
            }));
        }

        private void openFin_AppConnected(object sender, EventArgs e)
        {
            Invoke(new Action(() => openFinStatusLabel.Text = "DeepThought Connected"));
        }

        private void openFin_AppDisconnected(object sender, EventArgs e)
        {
            Invoke(new Action(() => 
            {
                openFinStatusLabel.Text = "OpenFin Connected";
                launchCalculatorButton.Enabled = true;
            }));
        }

        #endregion
    }
}
