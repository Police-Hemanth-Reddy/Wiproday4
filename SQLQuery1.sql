create database Wipro
create table Employee(empid int,empname varchar(30),salary decimal(8,2))
insert into Employee values(1,'hemanth',20000)
select * from Employee
-- DDL
/* has create alter drop truncate rename*/
alter table Employee add dept varchar(20)
--using alter can add or alter the data type of the column
alter table Employee alter column empname varchar(20)
insert into Employee values(2,'hmanth',10000,'it')
truncate table Employee
drop table Employee --here the table struct is deleted need to create table again

--DML
create table Employee(empid int not null, empnum int primary key,empname varchar(20)) 
insert into Employee(empid,empnum) values(1,12345)
insert into Employee values(2,3456,'raju')

update Employee set empname='hemanth' 
select * from Employee
delete from Employee where empid=2

select * from Employee where empid=2
select empname,empnum from Employee where empnum=12345
select * from Employee where empname Like '%h'
select * from Employee where empname like 'h%'
select * from Employee where empname like '_a%'
----constraints
/* are rules which is used to maintain accuracy intigrity like not null,primary key,foreign key,default,check*/
drop table Department
create table Department(deptid int not null,deptname varchar(20),deptnum int foreign key references Employee(empnum))
insert into Department values(111,'IT',12345)
alter table Department alter column deptnum int 
alter table Department alter column deptid int
drop table Employee
drop table Department
create table Employee(empid int,empname varchar(30),empsalary decimal)
create table Department(deptid int,deptname varchar(30))
insert into Employee values(1,'hemanth',200)
insert into Department values(111,'IT')
select count(*) as "count" from Employee
select sum(empsalary) as totalsal from Employee
select min(deptid) as deptid from Department
select max(empsalary) as highestsal from Employee 
select avg(deptid) as avgerage from Department where deptname='IT'

--groupby
select deptname from Department group by deptname order by deptname desc
select deptid from Department group by deptid having count(*)>2


--functions
--system functions
select getdate() as todaydate
select sysdatetime() as currentdate

--userdefined functionns
--scalar valued means single value which returns only one value in fun
create function GetCountEmp()
returns int
as 
begin
	declare @noofemp int;
	select @noofemp=count(*) from Employee;
	return @noofemp;
end;
select dbo.GetCountEmp()

--Table valued function
create or alter function 
GetEmployeeSal(@minsalary decimal,@maxsalary decimal)
returns table
as
return 
(  
   select * from Employee where empsalary between @minsalary and @maxsalary
) 

select * from dbo.GetEmployeeSal(200,500)

---joins
select Employee.empname,Department.deptname from Employee join Department on Employee.empid=Department.deptid
select Employee.empname,Department.deptname from Employee,Department where Employee.empid=Department.deptid
select Department.deptname,Employee.empname from Department left join Employee on Employee.empid=Department.deptid
select Employee.empname,Department.deptname from Department right join Employee on Department.deptid=Employee.empid
select Employee.empname,Department.deptname from Employee full outer join Department on Employee.empid=Department.deptid
select Employee.empname,Department.deptname from Employee cross join Department
select e.empid,e.empname,e2.empname from Employee e join Employee e2
on e.empid=e2.empid