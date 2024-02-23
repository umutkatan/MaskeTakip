using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);
        List<Person> GetList();
        bool CheckPerson(Person person);

    }
}
