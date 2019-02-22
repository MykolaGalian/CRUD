namespace PersonDepartLib
{
    using PersonDepartLib.Context;
    using PersonDepartLib.Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PerDepContext : DbContext 
    {
        // Контекст настроен для использования строки подключения "ModelPersonDepDB" из файла конфигурации  
        // приложения (App.config). По умолчанию эта строка подключения указывает на базу данных 
        // "PersonDepartLib.ModelPersonDepDB" в экземпляре LocalDb.        
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "ModelPersonDepDB" 
        // в файле конфигурации приложения.

        public PerDepContext()
            : base("name=ModelPersonDepDB") // name = - имя строки подключения с БД - connectionStrings
        {
            
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. 
        
        //Code First
        // подход TPH - Table Per Hierarchy - Таблица на одну иерархию классов
        public virtual DbSet<Person> Persons_ { get; set; } // таблица Person базового класса

        public virtual DbSet<User> Users_ { get; set; }  // таблицы классов наследников от Person
        

        public virtual DbSet<Employee> Employees_ { get; set; } // таблица класса наследника от User 

        public virtual DbSet<Department> Departments_ { get; set; }    


        public virtual DbSet<Position> Position_ { get; set; }
        public virtual DbSet<StaffRestrict> StaffRestrict_ { get; set; }
    }

    
}