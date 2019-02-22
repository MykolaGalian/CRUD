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
            _departmentRepository = new Mock<IDepartmentRepository>(MockBehavior.Strict);  // ������������� Mock ������� - �������
            Dep = new Department(_departmentRepository.Object, null); // �������� Mock ������� ������������ Department
        }               


        [Test]  // Moq Framework- Stub
        public void GetListDepartment_NoEmptyList_Return_3()
        {
            _departmentRepository.Setup(r => r.ChekCurrentNumerEmployee_rep(pos_, dep_)).Returns(new List<Employee>() // ��������� - ������� �� ������� ������
            {
              new Employee() { PositionID = 1 },
              new Employee() { PositionID = 2 },
              new Employee() { PositionID = 3 }
        });
            var res = Dep.ChekCurrentNumerEmployee(pos_, dep_); // �������� - ������� ���������� (����� ������ �������� ChekCurrentNumerEmployee_rep - ���������� Moq)

            Assert.That(res, Is.EqualTo(3));  // �������� �����������
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
            _departmentRepository = new Mock<IDepartmentRepository>(MockBehavior.Loose);  // ������������� Mock ������� - �� �������
                                                                                            // ������������ ������ ������

            Dep = new Department(_departmentRepository.Object, null); // �������� Mock ������� ������������ Department
        }


        [Test]  // Moq Framework- Stub
        public void GetListDepartment_EmptyList_ReturnZero()
        {                                                                  // ������� �������� - �� ������� Moq         
            _departmentRepository.Setup(r => r.ChekCurrentNumerEmployee_rep(null, null)).Returns(new List<Employee>()); // ��������� - ������� ������� ������

            var res = Dep.ChekCurrentNumerEmployee(pos_, dep_); // �������� - ������� ���������� (����� ������ �������� ChekCurrentNumerEmployee_rep - ���������� Moq)

            Assert.That(res, Is.EqualTo(0));// �������� �����������
        }       
    }
}