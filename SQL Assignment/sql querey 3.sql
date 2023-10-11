select * from emp
insert into emp values (7369, 'SMITH', 'CLERK',7902,'1980-12-17',800,20, null)


--Retrieve a list of MANAGERS.
select * from emp where job like 'Manager'

--Find out the names and salaries of all employees earning more than 1000 per month.
select ename , sal from emp where sal > 1000

-- Display the names and salaries of all employees except JAMES
select ename, sal from emp where ename not like 'James'

--Find out the details of employees whose names begin with ‘S’
select * from emp where ename like 's%'

-- Find out the names of all employees that have ‘A’ anywhere in their name
select * from emp where ename like '%a%'

--Find out the names of all employees that have ‘L’ as their third character in their name.
select * from emp where ename like '__l%'

--Compute daily salary of JONES
select ename, (sal/30) as dailysal from emp where ename like 'Jones'

--Calculate the total monthly salary of all employees
select sum(sal) as totalmonthlysal from emp

--Print the average annual salary . 
select avg(sal*12) as avgannualsal from emp

-- Select the name, job, salary, department number of all employees except SALESMAN from department number 30.
select ename, job, sal, deptno from emp where job not like ' salesman' and not deptno = 30

--List unique departments of the EMP table
select distinct(deptno) from emp

--List the name and salary of employees who earn more than 1500 and are in department 10 or 30.
--Label the columns Employee and Monthly Salary respectively.
select ename,deptno, (sal/30) as 'monthlysalary'from emp where sal > 1500 and deptno in (10,30)

--Display the name, job, and salary of all the employees whose job is MANAGER or 
--ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select ename, job, sal from emp where job in('manager', 'analyst') and   sal not in (1000,3000,5000) 

--Display the name, salary and commission for all employees whose commission 
--amount is greater than their salary increased by 10%.
select ename, sal, comm from emp where (comm > (Sal +(sal*0.1)))
                                             

-- Display the name of all employees who have two Ls in their name and are in 
--department 30 or their manager is 7782.
select ename from emp where ename like '%ll%' and deptno = 30 or mgrid = 7782

--Display the names of employees with experience of over 30 years and under 40 yrs.
-- Count the total number of employees. 
 select ename, datediff(year,hiredate,getdate())  as 'Experience' 
 from emp
 where datediff(year,hiredate,getdate()) between 30 and 40 
 

--Retrieve the names of departments in ascending order and their employees in descending order.

select department.deptno, emp.ename,department.dname
from department
inner join emp on emp.deptno = department.deptno
order by dname asc, ename desc;


--Find out experience of MILLER. 
select ename, Datediff(year, hiredate, getdate()) as experience from emp where ename like 'miller' 
