using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager:IOrderManager
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Kampanya oluşturuldu.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
