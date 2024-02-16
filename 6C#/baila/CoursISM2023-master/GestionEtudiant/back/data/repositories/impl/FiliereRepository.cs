using GestionEtudiant.back.core.impl;
using GestionEtudiant.back.data.entites;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GestionEtudiant.back.data.repositories.impl
{
    public class FiliereRepository : DataBase, IFiliereRepository
    {
        private readonly string SQL_ALL = "select * from filiere";
        public int add(Filiere entity)
        {
            throw new NotImplementedException();
        }

        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll()
        {
            TableName = "ALLFILIERE";
            return ExecuteSelect(SQL_ALL);
        }

        public Filiere GetValue(int id)
        {
            throw new NotImplementedException();
        }

        public int update(Filiere entity)
        {
            throw new NotImplementedException();
        }
    }
}
