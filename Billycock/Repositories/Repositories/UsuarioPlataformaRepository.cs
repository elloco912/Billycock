﻿using Billycock.Data;
using Billycock.Models;
using Billycock.Repositories.Interfaces;
using Billycock.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Billycock.Repositories.Repositories
{
    public class UsuarioPlataformaRepository : IUsuarioPlataformaRepository
    {
        private readonly BillycockServiceContext _context;
        private readonly ICommonRepository<Historia> _commonRepository;
        public Task<string> DeleteUsuarioPlataforma(UsuarioPlataforma usuarioPlataforma)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioPlataforma> GetUsuarioPlataformabyId(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioPlataforma> GetUsuarioPlataformabyName(string Name)
        {
            throw new NotImplementedException();
        }

        public Task<List<UsuarioPlataforma>> GetUsuarioPlataformas()
        {
            throw new NotImplementedException();
        }

        public Task<string> InsertUsuarioPlataforma(UsuarioPlataforma usuarioPlataforma)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateUsuarioPlataforma(UsuarioPlataforma UsuarioPlataforma)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UsuarioPlataformaExists(int id)
        {
            throw new NotImplementedException();
        }
    }
}
