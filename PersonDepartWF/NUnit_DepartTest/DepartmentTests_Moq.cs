using Moq;
using NUnit.Framework;
using PersonDepartLib.Mocking;
using PersonDepartLib.Model;
using System.Collections.Generic;

namespace Tests_Department
{
    [TestFixture]
    public class Tests_Strict
    {
        private Mock<IDepartmentRepository> _departmentRepository;
        private Department Dep;
        Position pos_ = new Position() { PositionID =1 }; 
        Department dep_ = new Department() { DepartmentID =1};

        [SetUp]
        public void Setup()
        {
            _departmentRepository = new Mock<IDepartmentRepository>(MockBehavior.Strict);  // инициализация Mock обьекта - строгий
            Dep = new Department(_departmentRepository.Object, null); // передача Mock обьекта конструктору Department
        }               


        [Test]  // Moq Framework- Stub
        public void GetListDepartment_NoEmptyList_Return_3()
        {
            _departmentRepository.Setup(r => r.ChekCurrentNumerEmployee_rep(pos_, dep_)).Returns(new List<Employee>() // настройка - возврат не пустого списка
            {
              new Employee() { PositionID = 1 },
              new Employee() { PositionID = 2 },
              new Employee() { PositionID = 3 }
        });
            var res = Dep.ChekCurrentNumerEmployee(pos_, dep_); // действие - подсчет работников (метод внутри вызывает ChekCurrentNumerEmployee_rep - настроеный Moq)

            Assert.That(res, Is.EqualTo(3));  // проверка утверждения
        }
    }

    [TestFixture]
    public class Tests_Loose
    {
        private Mock<IDepartmentRepository> _departmentRepository;
        private Department Dep;
        Position pos_ = new Position() { PositionID = 1 };
        Department dep_ = new Department() { DepartmentID = 1 };


        [SetUp]
        public void Setup()
        {
            _departmentRepository = new Mock<IDepartmentRepository>(MockBehavior.Loose);  // инициализация Mock обьекта - не строгий
                                                                                            // присутствуют пустые списки

            Dep = new Department(_departmentRepository.Object, null); // передача Mock обьекта конструктору Department
        }


        [Test]  // Moq Framework- Stub
        public void GetListDepartment_EmptyList_ReturnZero()
        {                                                                  // обьекты заглушки - не строгий Moq         
            _departmentRepository.Setup(r => r.ChekCurrentNumerEmployee_rep(null, null)).Returns(new List<Employee>()); // настройка - возврат пустого списка

            var res = Dep.ChekCurrentNumerEmployee(pos_, dep_); // действие - подсчет работников (метод внутри вызывает ChekCurrentNumerEmployee_rep - настроеный Moq)

            Assert.That(res, Is.EqualTo(0));// проверка утверждения
        }       
    }
}