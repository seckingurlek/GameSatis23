using Business.Abstract;
using DataAccess.Abstarct;
using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CampaignManager : CampaignService
    {
        InMemoryCampaignDal _inMemoryCampaignDal;
        public CampaignManager(InMemoryCampaignDal inMemoryCampaignDal )
        {
            _inMemoryCampaignDal = inMemoryCampaignDal;
            
        }
        public void CampaignToProduct(Campaign campaign, Product product) 
        {
            InMemoryProductDal inMemoryProductDal = new InMemoryProductDal(); 
            ProductManager productManager = new ProductManager(inMemoryProductDal); 
            productManager.UpdatePreis(_inMemoryCampaignDal.getByCampaignRate(campaign),product);
        }
    }

        
    }

