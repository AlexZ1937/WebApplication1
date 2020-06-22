using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class AnketaRepository
    {
        private static AnketaRepository repository = new AnketaRepository();
        private List<Anketa> responses = new List<Anketa>();

        public static AnketaRepository GetRepository()
        {
            return repository;
        }
        public IEnumerable<Anketa> GetAllResponses()
        {
            return responses;
        }
        public void AddResponse(Anketa response)
        {
            responses.Add(response);
        }
    }
}