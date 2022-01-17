using InventorySimulation.SimulationCore;
using System;
using System.Windows.Forms;

namespace InventorySimulation
{
    public partial class FirstCustomInputWindow : UserControl
    {
        public FirstCustomInputWindow()
        {
            InitializeComponent();
            setDefaults();
        }

        private void setDefaults()
        {
            orderUpToTxt.Text = Defaults.ORDER_UP_TO.ToString();
            reviewPeriodTxt.Text = Defaults.REVIEW_PERIOD.ToString();
            startInventoryQuantityTxt.Text = Defaults.START_INVENTORY_QUANTITY.ToString();
            startLeadDaysTxt.Text = Defaults.START_LEAD_DAYS.ToString();
            startOrderQuantityTxt.Text = Defaults.START_ORDER_QUANTITY.ToString();
            numberOfDaysTxt.Text = Defaults.NUMBER_OF_DAYS.ToString();
        }

        #region HANDLING_INSTANT_VALUE_CHANGES
        private void orderUpToTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void orderUpToTxt_TextChanged(object sender, EventArgs e)
        {
            Program.mSystem.OrderUpTo = int.Parse(orderUpToTxt.Text);
            Program.mSystem.ReviewPeriod = int.Parse(reviewPeriodTxt.Text);
            Program.mSystem.StartInventoryQuantity = int.Parse(startInventoryQuantityTxt.Text);
            Program.mSystem.StartLeadDays = int.Parse(startLeadDaysTxt.Text);
            Program.mSystem.StartOrderQuantity = int.Parse(startOrderQuantityTxt.Text);
            Program.mSystem.NumberOfDays = int.Parse(numberOfDaysTxt.Text);
        }
        #endregion
        
    }
}
