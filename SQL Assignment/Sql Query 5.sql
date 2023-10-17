create or alter procedure payslip
as
begin
declare @employeename varchar(50)
set @employeename = 'Hima Bindu'
print ' Employee Name :' + '' + cast(@employeename as nvarchar(50))

declare @basicsalary decimal
set @basicsalary = 50000
print 'BasicSalary : ' + ' ' + cast(@basicsalary as nvarchar(10))

declare @HRA decimal
set @HRA = 0.1 * @basicsalary
print 'HRA : ' + ' ' + cast(@HRA as nvarchar(10))

declare @DA decimal
set @DA = 0.2*@basicsalary
print 'DA : ' + ' ' + cast(@DA as nvarchar(10))
declare @PF decimal
set @Pf = 0.08* @basicsalary
print 'Pf : ' + ' ' + cast(@Pf as nvarchar(10))

declare @IT decimal
set @IT = 0.05* @basicsalary
print 'IT : ' + ' ' + cast(@IT as nvarchar(10))

declare @deductions decimal
set @deductions = @Pf + @IT
print 'DA : ' + ' ' + cast(@DA as nvarchar(10))

declare @Grosssalary decimal
set @Grosssalary = @basicsalary + @HRA + @DA
print 'Grosssalary : ' + ' ' + cast(@Grosssalary as nvarchar(10))

declare @Netsalary decimal
set @Netsalary = @Grosssalary - @deductions
print 'Netsalary : ' + ' ' + cast(@Netsalary as nvarchar(10))
end

execute payslip









