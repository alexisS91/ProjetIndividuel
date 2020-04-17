﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DalDB.Services;
using G = DalDB.Models;
using C = APICrow.Models;
using APICrow.Mapper;

namespace APICrow.Services
{
    public class ProjetService 
    {

        private ProjetRepository _repo = new ProjetRepository();

        public void Create(C.Projet entity)
        {
            _repo.Create(entity.ToGlobal());
        }


        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public IEnumerable<C.Projet> Get()
        {
            return _repo.Get().Select(e=> e.ToClient()); 
        }


        public C.Projet Get(int id)
        {
            return _repo.Get(id).ToClient();
        }

       

        public void Update(int id, C.Projet entity)
        {
            _repo.Update(id, entity.ToGlobal());
        }
    }
    
}