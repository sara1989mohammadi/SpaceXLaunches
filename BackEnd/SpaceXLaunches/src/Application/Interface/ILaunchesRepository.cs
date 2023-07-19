using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface ILaunchesRepository
    {
        List<Launche> GetAll();
        Launche GetById(int id);
    }
}
