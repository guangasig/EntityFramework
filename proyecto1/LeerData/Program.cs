using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppConetionContext() ){
                var usuarios = db.Usuario.AsNoTracking(); // arreglo IQueryable
                foreach (var usuario in usuarios)
                {
                    Console.WriteLine(usuario.UserName);
                }
            }
        }
    }
}

