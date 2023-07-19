using Application.Interface;
using Domain;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class LaunchesRepository : ILaunchesRepository
    {
        private readonly DataContext _dataContext;
        public LaunchesRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Launche> GetAll()
        {
            return _dataContext.Launches.ToList();
        }

        public Launche GetById(int id)
        {
            var launche = _dataContext.Launches.Find(id);
            if (launche == null)
            {
                return new Launche();
            }
            return launche;
        }
    }
}

