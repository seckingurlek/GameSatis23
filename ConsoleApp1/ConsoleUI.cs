using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class ConsoleUI
    {
        public void main(string[] args)
        {
            ProductManagaer productManager = new ProductManager();
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.campaignToProduct();

        }
    }
}
