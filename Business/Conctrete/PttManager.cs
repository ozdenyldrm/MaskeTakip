using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Conctrete
{
    public class PttManager:ISupplierService
    {
        private IApplicationService _applicationService;

        public PttManager(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        public void GiveMask(Person person)
        {
            PttManager pttManager = new PttManager(new PersonManager());
            PersonManager personManager = new PersonManager();
            if (personManager.CheckPerson(person)) 
            {
                Console.WriteLine(person.FirstName+ " için maske verildi");
            }
            else { Console.WriteLine(person.LastName + "maske verilemedi"); }
        }
    }
}
