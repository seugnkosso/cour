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
    public class ClasseRepository : DataBase, IClasseRepository
    {
        private readonly string SQL_ALL = "select * from classe";
       // private readonly string SQL_DEL= string.Format"delete  * from classe id={0} ");
        public int add(Classe entity)
        {
             string sql = string.Format("INSERT INTO classe ([name],[filiere], [niveau])  OUTPUT INSERTED.ID  VALUES('{0}','{1}','{2}')", entity.Name, entity.Filiere.Name, entity.Niveau.Name)  ;
            return ExecuteUpdate(sql);
        }

        public int delete(int id)
        {
            string SQL_DEL = string.Format("delete from classe where id={0} ",id);
            return ExecuteUpdate(SQL_DEL);
        }

        public DataTable GetAll()
        {
            TableName = "ALLCLASSE";
           
            return ExecuteSelect(SQL_ALL);
        }

        public Classe GetValue(int id)
        {
            throw new NotImplementedException();
        }

        public int update(Classe entity)
        {
            
            string sql = string.Format("UPDATE classe   SET [name] = '{0}',[filiere] ='{1}',[niveau] = '{2}' where [id] = {3}", entity.Name, entity.Filiere.Name, entity.Niveau.Name,entity.Id);
            return ExecuteUpdate(sql);
        }
    }
}
