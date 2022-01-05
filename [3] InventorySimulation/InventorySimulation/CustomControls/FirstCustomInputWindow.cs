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

    }
}
