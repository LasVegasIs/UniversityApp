create table dbo.Students (
  Id int primary key,
  Fio nvarchar(128) not null
)

insert into dbo.Students(Id, Fio) values (1,'Иванов')
insert into dbo.Students(Id, Fio) values (2,'Петров')
insert into dbo.Students(Id, Fio) values (3,'Сидоров')


create table Teachers (
  Id integer primary key,
  Fio varchar(128) not null
)

insert into dbo.Teachers(Id, Fio) values (1,'Петр Сергеевич')
insert into dbo.Teachers(Id, Fio) values (2,'Степан Леонидович')
insert into dbo.Teachers(Id, Fio) values (3,'Евгений Ильич')

create table Subjects (
  Id integer primary key,
  Title varchar(50) not null
)

insert into dbo.Subjects(Id, Title) values (1,'Математика')
insert into dbo.Subjects(Id, Title) values (2,'Физика')
insert into dbo.Subjects(Id, Title) values (3,'Астрономия')

create table Student_Teacher_Subject (
  Id integer primary key,
  IdStudent int foreign key references dbo.Students(id),
  IdTeacher int foreign key references dbo.Teachers(id),
  IdSubject int foreign key references dbo.Subjects(id)
)

insert into dbo.Student_Teacher_Subject(Id, IdStudent, IdTeacher, IdSubject) values (1,1,2,3)
insert into dbo.Student_Teacher_Subject(Id, IdStudent, IdTeacher, IdSubject) values (2,2,2,2)
insert into dbo.Student_Teacher_Subject(Id, IdStudent, IdTeacher, IdSubject) values (3,3,1,2)
insert into dbo.Student_Teacher_Subject(Id, IdStudent, IdTeacher, IdSubject) values (4,3,3,1)


