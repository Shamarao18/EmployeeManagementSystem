
namespace EmployeeManagementSystem;
public class Employee
{
    public int empId{get; private set;}
    public string empName{get; private set;}="";
     public string empDept{get; private set;}="";
     public double Salary{get; private set;}

     public Employee(int Id,string Name,string Dept,double salary)
    {
        empId = Id;
        empName = Name ;
        empDept = Dept ;
        Salary = salary ;
    }


}