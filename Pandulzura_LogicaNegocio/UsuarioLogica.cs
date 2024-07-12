﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pandulzura_AccesoDatos.DAO;
using Pandulzura_AccesoDatos.Entidades;

namespace Pandulzura_LogicaNegocio
{
    public class UsuarioLogica
    {
        private UsuarioDAO usuarioDao = new UsuarioDAO();

        public bool InsertarUsuario(Usuario nuevoUser)
        {
            try
            {
                usuarioDao.InsertUser(nuevoUser);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }

        }

        public DataTable ListarUser()
        {
            try
            {
                return usuarioDao.ListarUser();


            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}

