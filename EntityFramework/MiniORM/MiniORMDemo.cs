using MiniORM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM
{
    class MiniORMDemo
    {
        static void Main(string[] args)
        {
            string connectionToDB = new ConnectionStringBuilder("DataBaseORM").ConnectionString();
        }
    }
}
