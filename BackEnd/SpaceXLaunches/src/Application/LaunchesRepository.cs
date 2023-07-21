using Application.Interface;
using Domain;
using Microsoft.EntityFrameworkCore;
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
            return _dataContext.Launches.Include(launche=> launche.links).ToList();
        }

        public Launche GetById(int id)
        {
            var launche = _dataContext.Launches.Include(launche => launche.links).Include(launche => launche.rocket).FirstOrDefault(launche=>launche.Id==id);
            if (launche == null)
            {
                return new Launche();
            }
            return launche;
        }
    }
}

