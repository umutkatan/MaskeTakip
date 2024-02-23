using Busines.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Busines.Abstract;
using Entities.Concrete;

namespace Busines.Concrete
{
    public class PttManager:ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //Constructor new yapıldığında çalışır 
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
           
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.Firstname + " için maske verildi. ");
            }
            else
            {
                Console.WriteLine(person.Firstname + " için maske verilemedi. ");
            }
        }
    }
}
