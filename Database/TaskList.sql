create database TaskList

use TaskList

create table TaskType
(id_type int identity(1, 1) not null primary key,
typeName nvarchar(100),
typeDescription nvarchar(255));


create table Task 
(id_task int identity(1, 1) not null primary key,
taskDescription text,
ifDone bit,
id_type int not null foreign key (id_type) references
dbo.TaskType(id_type) on delete no action on update no action);


select * from TaskType
select * from Task