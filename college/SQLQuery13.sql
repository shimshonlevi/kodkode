--טבלה קורסים
create table Courses(
id int primary key identity,
price int);

ALTER TABLE Courses
ADD name VARCHAR(100);

-- הכנסת רשומה עם שם ומחיר
INSERT INTO Courses (name, price)
VALUES ('english', 1000);

-- הכנסת רשומה עם שם ומחיר
INSERT INTO Courses (name, price)
VALUES ('math', 1200);

-- הכנסת רשומה עם שם ומחיר
INSERT INTO Courses (name, price)
VALUES ('history', 1800);



--טבלת מרצים
create table Teachers(
teacher_id int primary key identity,
name varchar(100),
price_hour int);

-- הכנסת רשומות לטבלת מרצים
INSERT INTO Teachers (name, price_hour)
VALUES ('david', 150),
       ('ron', 180),
       ('moshe', 160);


--טבלת נושאים
create table Subjects(
subjects_id int primary key identity,
namw varchar(100),
teacher_id int,
num_hours int,
FOREIGN KEY (teacher_id) REFERENCES Teachers(teacher_id));


-- הכנסת רשומות לטבלת נושאים
INSERT INTO Subjects (namw, teacher_id, num_hours)
VALUES ('Grammar', 1, 30),
       ('Algebra', 2, 40),
       ('Ancient Civilizations', 3, 35);



--טבלה מקשרת מרצים ונושאים
create table Teachers_and_cours(teacher_id int, subjects_id int,
FOREIGN KEY (teacher_id) REFERENCES Teachers(teacher_id),
FOREIGN KEY (subjects_id) REFERENCES Subjects(subjects_id));

-- הכנסת רשומות לטבלה מקשרת מרצים ונושאים
INSERT INTO Teachers_and_cours (teacher_id, subjects_id)
VALUES (1, 1),
       (2, 2),
       (3, 3);



--טבלה תלמידים
create table Studens(
id int primary key identity,
Amount_to_pay int);

ALTER TABLE Studens
ADD name VARCHAR(100);



-- הכנסת רשומות לטבלת תלמידים
INSERT INTO Studens (id, Amount_to_pay, name)
VALUES (1, 0, 'John Doe'),
       (2, 0, 'Jane Smith'),
       (3, 0, 'Michael Brown');



--טבלה מקשרת קורסים תלמידים
create table studens_and_courss(student_id int,cours_id int,
FOREIGN KEY (student_id) REFERENCES Studens(id),
FOREIGN KEY (cours_id) REFERENCES Courses(id));

INSERT INTO studens_and_courss (student_id, cours_id)
VALUES (1, 1),
       (1, 2),
       (2, 1),
       (3, 3);


--טבלת מחזורים
create table Times(
cours_id int,
Start_Date datetime,
day_in_week varchar(100),
hours time,
hoursnum int,
FOREIGN KEY (cours_id) REFERENCES Courses(id));

-- הכנסת רשומות לטבלת מחזורים
INSERT INTO Times (cours_id, Start_Date, day_in_week, hours, hoursnum)
VALUES (1, '2024-08-01', 'Monday', '09:00', 30),
       (2, '2024-08-05', 'Wednesday', '14:00', 40),
       (3, '2024-08-10', 'Friday', '10:00', 35);


--טבלה תשלומים
create table Sum(
student_id int,
amount_paid int,
FOREIGN KEY (student_id) REFERENCES Studens(id));


DECLARE @student_name VARCHAR(100) = 'John Doe'; 

SELECT Courses.name
FROM Courses
WHERE Courses.id NOT IN (
    SELECT studens_and_courss.cours_id
    FROM studens_and_courss
    JOIN Studens ON studens_and_courss.student_id = Studens.id
    WHERE Studens.name = @student_name
);

declare @cours varchar(100) = 'english'

SELECT day_in_week, start_date, subjects.namw AS subject_name, Teachers.name AS lecturer 
                           FROM Courses
                           INNER JOIN Times ON Courses.id = Times.cours_id 
                           INNER JOIN Subjects ON Courses.id = Subjects.subjects_id 
                           INNER JOIN Teachers ON Subjects.teacher_id = Teachers.teacher_id 
                           WHERE Courses.name = @cours



DECLARE @StudentName VARCHAR(100) = 'John Doe';
DECLARE @CourseName VARCHAR(100) = 'Math';

IF NOT EXISTS (SELECT 1 FROM Studens WHERE name = @StudentName)
BEGIN
    INSERT INTO Studens (name, Amount_to_pay) VALUES (@StudentName, 0);
END

INSERT INTO studens_and_courss (student_id, cours_id)
SELECT s.id, c.id
FROM Studens s
CROSS JOIN Courses c
WHERE s.name = @StudentName AND c.name = @CourseName;

DECLARE @filter VARCHAR(100) = 'e';

select name from Courses where name like '%' + @filter +'%'

DECLARE @StudentName VARCHAR(100) = 'John Doe';

SELECT c.name AS CourseName
FROM Courses c
JOIN studens_and_courss sc ON c.id = sc.cours_id
JOIN Studens s ON sc.student_id = s.id
WHERE s.name = @StudentName;


DECLARE @StudentName VARCHAR(100) = 'שמשון'; -- החלף לשם הסטודנט הרלוונטי

SELECT SUM(c.price) AS TotalAmountToPay
FROM Courses c
JOIN studens_and_courss sc ON c.id = sc.cours_id
JOIN Studens s ON sc.student_id = s.id
WHERE s.name = @StudentName;

