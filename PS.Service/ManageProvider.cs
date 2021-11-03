using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Service
{
    public class ManageProvider
    {
        public List<Provider> listProvider = new List<Provider>();
        public ManageProvider(List<Provider> listProvider)
        {
            this.listProvider = listProvider;
        }

        public IEnumerable<Provider> GetProviderByName(String name)
        {
            var req =
                from p in listProvider
                where p.UserName.Contains(name)
                select p;

            // Si type de retour est List<> faire :
            //return req.ToList();

            return req;
        }

        public Provider GetFirstProviderByName(String name)
        {
            var req =
                from p in listProvider
                where p.UserName.StartsWith(name)
                select p;

            // Si type de retour est List<> faire :
            //return req.ToList();

            return req.FirstOrDefault();
            //retourne null si la liste est vide
        }

        public Provider GetProviderById(int id)
        {
            var req =
                from p in listProvider
                where p.Id==id
                select p;

            // Si type de retour est List<> faire :
            //return req.ToList();

            return req.SingleOrDefault();
            //retourne null si element n'existe pas
        }
    }
}
