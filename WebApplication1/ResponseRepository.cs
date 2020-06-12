using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class ResponseRepository
    {
        private static ResponseRepository repository = new ResponseRepository();
        private List<Anketa> responses = new List<Anketa>();

        public static ResponseRepository GetRepository()
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