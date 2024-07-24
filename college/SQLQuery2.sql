select * from Passwords
select * from Employees
--השוואת סיסמא לפי תעודת זהות
declare @old_pass varchar(10) = '4325'
declare @id_number varchar (20) = ''
declare @new_password varchar(20) = ''
declare @validation_new_password varchar(20) = ''
declare @answer varchar (100) = ''

	if exists(
	select password_string from Passwords
	join Employees on Employees.code = Passwords.employee_code
	where Employees.id = @id_number and Passwords.password_string = @old_pass and Passwords.has_access = 1
	)
	begin
		--בדיקת האם הסיסמא החדשה שונה מהישנה
		if exists(
		select password_string from Passwords
		join Employees on Employees.code = Passwords.employee_code
		where Employees.id = @id_number and Passwords.password_string =
		@old_pass and Passwords.has_access = 1 and @new_password != @old_pass
		)
			begin
				if exists(
				select password_string from Passwords
				join Employees on Employees.code = Passwords.employee_code
				where Employees.id = @id_number and Passwords.password_string =
				@old_pass and Passwords.has_access = 1 and @new_password != @old_pass 
				and @new_password = @validation_new_password 
				) 
	
					begin 
					update Passwords
					set has_access = 0
					from Passwords
					join Employees on Employees.code = Passwords.employee_code
					where Employees.id = @id_number 
					and Passwords.password_string = @old_pass

					      -- הוספת שורה חדשה עם הסיסמה החדשה
					insert into Passwords (employee_code, password_string,password_expiry_date, has_access)
					select Employees.code, @new_password,DATEADD(day, 180, GETDATE()), 1
					from Employees
					where Employees.id = @id_number

					select @answer = 'Password changed successfully'
					end

			

					else 
					begin
					select @answer = 'The passwords are incorrect'
					end

				end

		else
		begin
		select @answer =  'Enter a password that has not been used'
		end
	end
						
else 
begin
select @answer = 'One of the details is wrong'
end


select @answer								
			
				
					
		

						

	




