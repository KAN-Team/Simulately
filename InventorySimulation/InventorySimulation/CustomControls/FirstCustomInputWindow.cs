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
        private void numberOfNewspapersTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void PurchasePriceTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow number, backspace and dot
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
                e.Handled = true;

            //allow only one dot
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
                e.Handled = true;
        }

        private void numberOfNewspapersTxt_TextChanged(object sender, EventArgs e)
        {
            //Program.mSystem.NumOfNewspapers = int.Parse(OrderUpToTxt.Text);
            //Program.mSystem.NumOfRecords = int.Parse(numberOfRecordsTxt.Text);
            //Program.mSystem.PurchasePrice = decimal.Parse(purchasePriceTxt.Text);
            //Program.mSystem.ScrapPrice = decimal.Parse(scrapPriceTxt.Text);
            //Program.mSystem.SellingPrice = decimal.Parse(sellingPriceTxt.Text);
        }
        #endregion

        private void containerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newspapersNumGroup_Enter(object sender, EventArgs e)
        {

        }

        private void scrapPriceGroup_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
