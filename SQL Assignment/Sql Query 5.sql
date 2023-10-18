create or alter procedure payslipss
as
begin
DECLARE @ename VARCHAR(50), @sal INT, @empno int 
    SELECT @ename = ename, @sal = sal FROM emp WHERE empno = @empno
 
declare @HRA decimal
set @HRA = 0.1 * @sal
print 'HRA : ' + ' ' + cast(@HRA as nvarchar(10))

declare @DA decimal
set @DA = 0.2*@sal
print 'DA : ' + ' ' + cast(@DA as nvarchar(10))

declare @PF decimal
set @Pf = 0.08* @sal
print 'Pf : ' + ' ' + cast(@Pf as nvarchar(10))

declare @IT decimal
set @IT = 0.05* @sal
print 'IT : ' + ' ' + cast(@IT as nvarchar(10))

declare @deductions decimal
set @deductions = @Pf + @IT
print 'DA : ' + ' ' + cast(@DA as nvarchar(10))

declare @Grosssalary decimal
set @Grosssalary = @sal + @HRA + @DA
print 'Grosssalary : ' + ' ' + cast(@Grosssalary as nvarchar(10))

declare @Netsalary decimal
set @Netsalary = @Grosssalary - @deductions
print 'Netsalary : ' + ' ' + cast(@Netsalary as nvarchar(10))
end

execute payslipss @ename = 'smith'









