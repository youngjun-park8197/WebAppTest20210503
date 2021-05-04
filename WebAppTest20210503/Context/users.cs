using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAppTest20210503.Models;

namespace WebAppTest20210503.Context
{
    public class userinfo : DbContext // 테이블명과 같은 클래스명을 사용하지 말 것
    {
        public userinfo() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KOSTA\source\repos\MyDatabase.mdf;Integrated Security=True;Connect Timeout=30") 
        { }

        public DbSet<user> users { get; set; } 

    }
}