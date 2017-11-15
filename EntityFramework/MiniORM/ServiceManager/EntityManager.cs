using MiniORM.Attributes;
using MiniORM.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM.ServiceManager
{
    class EntityManager : IDbContext
    {
        private SqlConnection connection;

        private string connectionString;

        private bool isCodeFirst;

        public EntityManager(string connectionString,bool isCodeFirst)
        {
            this.connectionString = connectionString;
            this.isCodeFirst = isCodeFirst;
        }
        
        public void Delete(object entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById<T>(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll<T>()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll<T>(string where)
        {
            throw new NotImplementedException();
        }

        public T FindBy<T>(int id)
        {
            throw new NotImplementedException();
        }

        public T FindFirst<T>(string where)
        {
            throw new NotImplementedException();
        }

        public T First<T>()
        {
            throw new NotImplementedException();
        }

        public bool Persist(object entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Cannot persist null entity");
            }
            if()
        }
        private FieldInfo GetId(Type entity)
        {
            if(entity == null)
            {
                throw new ArgumentException("Cannot get id for null type");
            }
            FieldInfo info = entity.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).FirstOrDefault(x => x.IsDefined(typeof(IdAttribute)));

            if(info == null)
            {
                throw new ArgumentException("No id field was found in current class");
            }

            return info;
        }
        private string GetTableName(Type entity)
        {
            if(entity == null)
            {
                throw new ArgumentException("Cannot get table");
            }

            if (!entity.IsDefined(typeof(EntityAttribute)))
            {
                throw new ArgumentException("Cannot get table name of entity");
            }
            string table = entity.GetCustomAttribute<EntityAttribute>().TableName;

            if(table == null)
            {
                throw new ArgumentException("Table name cannot be null!");
            }

            return table;
        }

        private string GetColumnName(FieldInfo field)
        {
            if(field == null)
            {
                throw new ArgumentException("Field cannot be null");
            }

            if (!field.IsDefined(typeof(ColumnAttribute)))
            {
                return field.Name;
            }
            string columnName = field.GetCustomAttribute<ColumnAttribute>().ColumnName;
            if(columnName == null)
            {
                throw new ArgumentException("Column name cannot be empty");
            }
            return columnName;
        }

        public void CreateTable(Type entity)
        {

        }
    }
}
