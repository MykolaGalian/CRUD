using Moq;
using NUnit.Framework;
using PersonDepartLib.Mocking;
using PersonDepartLib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Staff 
{
    [TestFixture]
    public class Tests_Strict
    {
        private Mock<IStaffRestrictRepository> _staffRestrictRepository;
        private Department Dep;
        Position pos_ = new Position() { PositionID = 1 };
        Department dep_ = new Department() { DepartmentID = 1 };

        [SetUp]
        public void Setup()
        {
            _staffRestrictRepository = new Mock<IStaffRestrictRepository>(MockBehavior.Strict);  // инициализация Mock обьекта - строгий
            Dep = new Department(null, _staffRestrictRepository.Object); // передача Mock обьекта конструктору Department
        }

        [Test]  // Moq Framework- Stub
        public void GetMaxAmount_Return_4() 
        {
            _staffRestrictRepository.Setup(r => r.Chek_ValueMaxNumerEmployee_rep(pos_, dep_)).Returns(new StaffRestrict() // возврат не пустого обьекта
            {
                 MaxAmount = 4  
            });
            var res = Dep.Chek_ValueMaxNumerEmployee(pos_, dep_); // действие -  штатное расписания для данной должности в данном отделе (макс. ограничения) 
                                                                            //(метод внутри вызывает Chek_ValueMaxNumerEmployee_rep - настроеный Moq)
            Assert.That(res, Is.EqualTo(4)); // проверка утверждения
        }
    }

    [TestFixture]
    public class Tests_Loose
    {
        private Mock<IStaffRestrictRepository> _staffRestrictRepository;
        private Department Dep;
        Position pos_ = new Position() { PositionID = 1 };
        Department dep_ = new Department() { DepartmentID = 1 };

        [SetUp]
        public void Setup()
        {
            _staffRestrictRepository = new Mock<IStaffRestrictRepository>(MockBehavior.Loose);  // инициализация Mock обьекта - не строгий
            Dep = new Department(null, _staffRestrictRepository.Object); // передача Mock обьекта конструктору Department
        }

        [Test]  // Moq Framework- Stub
        public void GetMaxAmount_Return_0()
        {                                                                    // обьекты заглушки - не строгий Moq
            _staffRestrictRepository.Setup(r => r.Chek_ValueMaxNumerEmployee_rep(null, null)).Returns(new StaffRestrict()); // возврат  пустого обьекта
            
            var res = Dep.Chek_ValueMaxNumerEmployee(pos_, dep_); // действие -  штатное расписания для данной должности в данном отделе (макс. ограничения) 
                                                                  //(метод внутри вызывает Chek_ValueMaxNumerEmployee_rep - настроеный Moq)
            Assert.That(res, Is.EqualTo(0)); // проверка утверждения 
        }
    }
}
