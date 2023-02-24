
use vpproject;
CREATE TABLE login
(
  email varchar(100),
  id int,
  password varchar(100),
  status varchar(100)
);
Select  count(student.id) as student_id  from student  Inner join courses on courses.semester_id = student.semester and courses.teacher_id= '002' group  by teacher_id;
SELECT  t.id,t.name,c.name from teacher t INNER JOIN courses c on t.id ='002' and t.id=c.teacher_id
Select email,password from login where id='001';
insert into login values('fakhar884@gmail.com',023,'fakhar023','student');
insert into login values('mani001@gmail.com',022,'fakhar023','student');
insert into login values('iram001@gmail.com',001,'fakhar023','teacher');
insert into login values('kaleem002@gmail.com',002,'fakhar023','teacher');
insert into login values('umer003@gmail.com',003,'fakhar023','management');
Select fname+lname from student where id='23';
select id from login where email='umer003@gmail.com' and password='fakhar023' and status='management';
insert into student values(022,'Abdurehman','mani','mani001@gmail.com',0331456475,'cs',4);
drop table login;
CREATE TABLE student 
(
    id int  primary key,
    fname varchar(100) NOT NULL,
    lname varchar(100) NOT NULL,
	email varchar(100),
	phone int,
	programe varchar(10),
	semester int
);
select*from student;
SELECT *FROM courses inner join teacher on teacher.id=courses.teacher_id order by courses.id;
SELECT courses.id,courses.name as course_name,courses.credit_hour,teacher.name as Teacher_name ,courses.semester_id as Semester FROM courses inner join teacher on teacher.id=courses.teacher_id order by courses.id;
        

select count(id) from student;
insert into student values(023,'Fakhar','Alam','fakhar884@gmail.com',030695640,'cs',4);
insert into student values(022,'Abdurehman','mani','mani001@gmail.com',0331456475,'cs',4);
insert into student values(032,'Ali','Hamza','alihamza093@gmail.com',033457575,'cs',2);
insert into student values(011,'Kinza','Hashmi','kinza321@gmail.com',03067181,'se',4);
insert into student values(051,'Aliza','Shah','aliza123@gmail.com',03067181,'se',2);
insert into student values(109,'Ibrahim','Shah','ibrahim98@gmail.com',03067181,'cs',2);

select name from teacher where id='3';
CREATE TABLE courses
(
    id int , 
    name varchar(100) NOT NULL,
    teacher_id int NOT NULL,
	credit_hour int,
	semester_id int ,

);
CREATE TABLE quiz
(
    num int , 
    teacher_id int NOT NULL,
	course_id int,
	student_id int ,
	omarks int,
	tmarks int,

);
CREATE TABLE assignmnet
(
    num int , 
    teacher_id int NOT NULL,
	course_id int,
	student_id int ,
	omarks int,
	tmarks int,

);
drop table courses;

insert into courses values(70,'visual programing',001,4,4);
insert into courses values(71,'software engeneering ',002,3,4);
insert into courses values(72,'Stats and probability',003,3,4);
insert into courses values(73,'Programming fundamentals',004,3,3);
insert into courses values(74,'Coal',001,4,4);
insert into courses values(75,'Differential Equation ',001,3,3);

CREATE TABLE course
(
    id int primary key,
    name varchar(100) NOT NULL,
    teacher_id int NOT NULL,
);
ALTER TABLE teacher
ALTER COLUMN rename teacher_id varchar(100) to email varchar(100);
ALTER TABLE teacher
RENAME COLUMN teacher_id TO new_name;

drop table teacher;
insert into teacher values(001,'Iram hina',1);
insert into teacher values(002,'Kaleem Ullah',2);
insert into teacher values(003,'Umer farooq',1);
insert into teacher values(004,'Alina shahid',3);

select id from login where 

CREATE TABLE enrolled
(
    semester_id int,
    student_id int NOT NULL,
    course_id int NOT NULL,

);

CREATE TABLE announcement
(
    semester_id int,
    programe varchar(20) NOT NULL,
	message varchar(200)

);
drop table announcement;

insert into enrolled values(4,23,70);
insert into enrolled values(4,23,71);
insert into enrolled values(4,23,74);

insert into enrolled values(4,22,70);
insert into enrolled values(4,22,71);
insert into enrolled values(4,22,74);

insert into enrolled values(4,92,70);
insert into enrolled values(4,92,71);

insert into enrolled values(2,12,72);
insert into enrolled values(2,12,73);



drop table quiz;
ALTER TABLE enrolled
ADD FOREIGN KEY (student_id) REFERENCES student(id);
ALTER TABLE enrolled
ADD FOREIGN KEY (course_id) REFERENCES courses(id);
ALTER TABLE courses
ADD FOREIGN KEY (teacher_id) REFERENCES teacher(id);

select v.fName,v.lname,s.student_id,c.name from courses c,student_rec v,enrolled s where s.student_id='23';
select fName ,lname from student_rec  inner join on  (select * from enrolled where student_id ='23');


SELECT DISTINCT v.fName,v.lname,v.id ,e.name,e.id
FROM student_rec v 
INNER JOIN teacher e ON e.name='iram hina' ;

select *from login where id='001';

Select  student.id as student_id ,courses.teacher_id,student.fname , courses.name,courses.id as course_id ,courses.semester_id from student  Inner join courses on courses.semester_id = student.semester and courses.teacher_id= '001' order by courses.id;

SELECT courses.id,courses.name as course_name,courses.credit_hour,teacher.name as Teacher_name ,courses.semester_id as Semester FROM courses inner join teacher on teacher.id=courses.teacher_id  and courses.semester_id='3' order by courses.id;

Select distinct * from login where status='teacher';
SELECT distinct*
FROM teacher
CROSS JOIN student limit 4;
Select distinct student.id,student.fname,student.email from student;

SELECT DISTINCT v.fName,v.lname,v.id ,e.name,e.id FROM student v INNER JOIN teacher e ON e.id = '001';
SELECT distinct t.id,t.name,c.name from teacher t INNER JOIN courses c on t.id ='001' and t.id=c.teacher_id;
Select distinct  quiz.num,student.fname,quiz.course_id,quiz.teacher_id,quiz.omarks,quiz.tmarks from quiz  inner join student  on student.id=quiz.student_id and quiz.teacher_id='001' inner join courses on quiz.course_id='70';
   select count(student_id)from assignmnet where omarks<(select avg(omarks) from quiz)
   select count(quiz.student_id)from quiz  inner join teacher on teacher.teacher_id='001' and  quiz.omarks<(select avg(quiz.omarks);

Select  num,student_id,course_id,omarks,tmarks from quiz where teacher_id ='001' from quiz where omarks < (select avg(omarks) ;
Select distinct num,student_id,course_id,omarks,tmarks from quiz where  omarks Any <(select avg(omarks) from quiz);
SELECT num,student_id,course_id,omarks,tmarks FROM quiz WHERE omarks < All (SELECT avg(omarks) FROM quiz WHERE teacher_id ='001');

select sum(omarks)from quiz where student_id='23';

SELECT *FROM announcement  inner join  student on id='23' and student.programe=announcement.programe;
SELECT assignmnet.course_id,courses.name,assignmnet.num As assignment_num,assignmnet.omarks as obtained_Marks,assignmnet.tmarks as Total_Marks from assignmnet  inner join  student on student.id='23' and student.id=assignmnet.student_id inner join courses on courses.id=assignmnet.course_id;
SELECT course_id FROM enrolled where student_id ='23';
SELECT quiz.course_id,courses.name,quiz.num As Quiz_Num,quiz.omarks as obtained_Marks,quiz.tmarks as Total_Marks from quiz  inner join  student on student.id='23' and student.id=quiz.student_id inner join courses on courses.id=quiz.course_id;

Select  count(student.id) as student_id  from student  Inner join courses on courses.semester_id = student.semester and courses.teacher_id= '001' group  by teacher_id