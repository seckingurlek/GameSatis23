using DataAccess.Abstarct;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCampaignDal : ICampaign
    {
        List<Campaign> _campaigns;
        public InMemoryCampaignDal()
        {
            _campaigns = new List<Campaign>
            { new Campaign() {Name = "kampanya25", Rate = 0.25 ,id = 1},
            { new Campaign() {Name = "kampanya50", Rate = 0.50,id =2}
            }
        };


        }
        public Campaign GetByIdCampaign(int id)
        {
            Campaign campaign = _campaigns.FirstOrDefault(p => p.id == id);
            return campaign;
        }
        public void Add(Campaign campaign)
        {

        }

        public void Delete(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public Campaign Get(Expression<Func<Campaign, bool>> filter = null)
        {
            throw new NotImplementedException();
        }



        public void Update(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public double getByCampaignRate(Campaign campaign)
        {
           
            Campaign filteredCampaign = _campaigns.FirstOrDefault(p => p.id == campaign.id);
            if (filteredCampaign != null)
            {
                return filteredCampaign.Rate;
            }
            return 0.0;  // Filtrelenmiş kampanyanın oranını döndürüyoruz
        }


            public List<Campaign> GetAll(Expression<Func<Campaign, bool>> filter = null)
            {
                throw new NotImplementedException();
            }
        }
    }

    

