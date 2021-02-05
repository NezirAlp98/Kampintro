using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager=new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id=1,
                BirthYear = 1984,
                FirstName = "NEZİR ALP",
                LastName = "ARSLAN",
                IdentityNumber = 12345
            });
            CampaignManager campaignManager=new CampaignManager();
            campaignManager.Delete(new Gamer());
        }
    }
}
