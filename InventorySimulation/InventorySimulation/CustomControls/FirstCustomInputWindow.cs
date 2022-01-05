using InventorySimulation;
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
            //numberOfNewspapersTxt.Text = Defaults.NUMBER_OF_NEWSPAPERS.ToString();
            //numberOfRecordsTxt.Text = Defaults.NUMBER_OF_RECORDS.ToString();
            //purchasePriceTxt.Text = Defaults.PURCHASE_PRICE.ToString();
            //scrapPriceTxt.Text = Defaults.SCRAP_PRICE.ToString();
            //sellingPriceTxt.Text = Defaults.SELLING_PRICE.ToString();
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
            //Program.mSystem.NumOfNewspapers = int.Parse(numberOfNewspapersTxt.Text);
            //Program.mSystem.NumOfRecords = int.Parse(numberOfRecordsTxt.Text);
            //Program.mSystem.PurchasePrice = decimal.Parse(purchasePriceTxt.Text);
            //Program.mSystem.ScrapPrice = decimal.Parse(scrapPriceTxt.Text);
            //Program.mSystem.SellingPrice = decimal.Parse(sellingPriceTxt.Text);
        }
        #endregion

    }
}
