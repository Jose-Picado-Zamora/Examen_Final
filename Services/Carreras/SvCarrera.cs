﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Services.Carreras
{
    public class SvCarrera : ISvCarrera
    {
        private MyContext _myDbContext = default!;
        public SvCarrera()
        {
            _myDbContext = new MyContext();
        }

        #region reads
        public List<Carrera> GetAllCarrera()
        {
            return _myDbContext.Carreras.ToList();
        }

        public Carrera GetCarreraById(int id)
        {
            return _myDbContext.Carreras.SingleOrDefault(x => x.id == id);
        }
        #endregion

        #region writes
        public Carrera AddCarrera(Carrera Carrera)
        {
            _myDbContext.Carreras.Add(Carrera);
            _myDbContext.SaveChanges();
            return Carrera;
        }
        #endregion
    }
}
