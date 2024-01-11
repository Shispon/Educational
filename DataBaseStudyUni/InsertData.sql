insert into production.region (title) 
values 
('Кузова'),
('Двигателя'),
('Коробка передач'),
('Салон'),
('Шасси'); -- title

insert into production.knot (title,cost,region_id) 
values
('Крыло',7000,1),
('Крыша',12000,1),
('Багажник',8000,1),
('Капот',5000,1),
('Дверь',4000,1),
('Ремень ГРМ',1000,2),
('Крышка Двигателя',3000,2),
('Цилиндр',4000,2),
('Поршень',3000,2),
('Шестерни',6000,3),
('Передний Вал',3000,3),
('Задний Вал',8000,3),
('Сиденье',5000,4),
('Руль',2000,4),
('Ремни безопасности',1000,4),
('Колено',3000,5),
('Переднее шасси',7000,5),
('Заднее шасси',7000,5);

insert into production.product (title,complexity,datecreated) 
values
('Skoda Octavia',4,'2023-09-21 13:00:00'),
('BMW m5',8,'2023-07-21 12:00:00'),
('VOLVO s80',8,'2023-08-24 14:00:00');

insert into production.product_knot (product_id,knot_id) 
values
(1,1),
(2,1),
(3,1),
(1,2),
(2,2),
(3,2),
(1,3),
(2,3),
(3,3),
(1,4),
(2,4),
(3,4),
(1,5),
(2,5),
(3,5),
(1,6),
(2,6),
(3,6);

insert into production.staff (title,first_name,second_name,last_name,phone_number,address,post) 
values
('Контрактный найм','Цыганков','Егор','Михайлович','89658397521','г.Брянск ул.Финансово д.25','Начальник'),
('Контрактный найм','Буглаев','Тимофей','Алексеевич','89008244521','г.Брянск ул.Симаво д.21','Зам Начальника'),
('Контрактный найм','Филов','Джейк','Карпович','893158397521','г.Брянск ул.Фоксово д.1','Рабочий');

with inserted_staff as (
  select * from production.staff
  where post = 'Начальник'
)
-- Вставьте данные в таблицу workshop
insert into production.workshop (title, chef_name)
select 'Сборочный цех', full_name
from inserted_staff;

insert into production.working_shift (title,shift_start_date,shift_end_date,staff_id) 
values
('1','2023-09-21 13:00:00','2023-09-21 20:00:00',1),
('2','2023-09-21 8:00:00','2023-09-21 13:00:00',2),
('3','2023-09-21 13:00:00','2023-09-21 20:00:00',3);

insert into production.workshop_region (workshop_id,region_id) 
values
(1,1),
(1,2),
(1,3),
(1,4),
(1,5);

insert into production.staff_workshop (staff_id,workshop_id) 
values
(1,1),
(2,1),
(3,1);

insert into production.staff_region (staff_id,region_id) 
values
(1,1),
(1,2),
(1,3),
(2,4),
(2,5),
(3,2);

insert into production.production (title,datecreated,product_id,workshop_id,staff_id) 
values
('Кто сделал шкоду','2023-03-22',1,1,1),
('Кто сделал BMW','2023-08-22',2,1,2),
('Кто сделал VOLVO','2023-09-22',3,1,3);
