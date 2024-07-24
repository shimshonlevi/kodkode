--יצירת טבלת אורח
create table Guests(id int primary key identity,name varchar(50))

-- הוספת אורחים לדוגמה
INSERT INTO Guests (name) VALUES ('John Doe');
INSERT INTO Guests (name) VALUES ('Jane Smith');
INSERT INTO Guests (name) VALUES ('Michael Johnson');
INSERT INTO Guests (name) VALUES ('Emily Davis');


--יצירת טבלת קטגוריות
create table Categories(id int primary key identity,name varchar(50))

-- הוספת קטגוריות לדוגמה
INSERT INTO Categories (name) VALUES ('fish');
INSERT INTO Categories (name) VALUES ('meat');
INSERT INTO Categories (name) VALUES ('vegetables');
INSERT INTO Categories (name) VALUES ('desserts');


--יצירת טבלת אוכל
--המכילה תעודת זהות שם המאכל 
create table Food(Id int primary key identity,name varchar(50),
Category_id int foreign key references Categories(id),
Guests_id int foreign key references Guests(id)
)
--שאילתה אם לא קיים הקטוגריה מוסיפה אותה
declare @name varchar(250) = 'מרק' ,@answer varchar(250);
--בודק אם קיים
if not exists(select name from Categories where name = @name)
--אם לא קיים מכניס
	begin
		insert into Categories values(@name)
	end

--שאילתה חיפוש קטגוריות
declare @filter varchar(100) = 'f' ;

select name from Categories 
where name like '%' + @filter +'%'

--להוסיף אורח
declare @guest_name varchar(250) ='moshe';
--בודק אם קיים
if not exists(select name from Guests where name = @guest_name)
--אם לא קיים מכניס
	begin
		insert into Guests values(@guest_name)
	end

--שאילתה חיפוש קטגוריות
declare @filter_guest varchar(100) = 'i' ;

select name from Guests 
where name like '%' + @filter_guest +'%'

--להוסיף אוכל
declare @food_name varchar(100) = 'מרק ירקות' ,@category_name varchar(100) = 'מרק', @guest__name varchar(100) ='John Doe' ;
declare @category_code int,@guest_code int;

select @category_code = (select id from Categories where name = @category_name)
select @guest_code = (select id from Guests where name = @guest__name)

if (@category_code is not null and @guest_code is not null)
	begin
		insert into Food values (@food_name, @category_code,@guest_code)
		end

-- יצרת שאילתה שתחזיר את כל האוכל שהוזמן מאותה קטגוריה +מספר של הכמות מאותה מנה
-- הגדרת משתנה הקטגוריה

DECLARE @category_name VARCHAR(100) = 'fish'; -- שם הקטגוריה הרצויה
select Food.name as name,count(*)as quality
from Food
join Categories on Categories.id = Food.Category_id
where  Categories.name = @category_name
GROUP BY Food.name;




--שאילתה שמחזירה סיכום למשתמש מה הוא בחר
declare @category_name2 varchar(100)  = 'fish'
declare @user_name  varchar(100)= 'John Doe'
select Food.name as name,count(Food.name) from Food
join Categories on Categories.id = Food.Category_id
join Guests on Guests.id = Food.Category_id
where @category_name2 = Categories.name and @user_name !=Guests.name
group by Food.name

select * from Categories
select * from Guests
select * from Food


DECLARE @category_name2 VARCHAR(100) = 'מרק'
DECLARE @user_name VARCHAR(100) = 'John Doe'

SELECT Food.name AS name, COUNT(Food.name)
FROM Food
JOIN Categories ON Categories.id = Food.Category_id
JOIN Guests ON Guests.id = Food.Category_id
WHERE @category_name4 = Categories.name AND @user_name != Guests.name
GROUP BY Food.name;

DECLARE @category_name4 VARCHAR(100) = 'מרק';
DECLARE @user_name1 VARCHAR(100) = 'John Doe';

SELECT f.name AS name, COUNT(f.name) AS count
FROM Food f
JOIN Categories c ON c.id = f.Category_id
JOIN Guests g ON g.id = f.Guests_id
WHERE c.name = @category_name4 AND g.name = @user_name1
GROUP BY f.name;


