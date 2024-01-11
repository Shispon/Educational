--запрос с выборкой полей и условиями--
SELECT id, title, cost
FROM production.knot
WHERE cost < 5000;
--запрос с distinct
SELECT  distinct title
FROM production.knot;
select * from production.knot
--специальный операторы
SELECT id, title, cost
FROM production.knot
WHERE title LIKE 'Р%' AND cost < 5000;
--запрос с еденичной агрегатной функцией
SELECT COUNT(*) AS total_product
FROM production.product;
--запрос с агрегатной функцией группировкой и использованием условия
SELECT
    title,
    COUNT(cost) AS count_knot_amount
FROM
    production.knot
WHERE 
    title LIKE 'Р%' AND
    cost IS NOT NULL
GROUP BY
    title;

  select * from production.knot
--запрос с внутренним соединением двух таблиц
SELECT
    k.id AS knot_id,
    k.title AS knot_title,
    k.cost,
    r.id AS region_id,
    r.title AS region_title
FROM
    production.knot k
JOIN
    production.region r ON k.region_id = r.id;--информация о узлах в соответствующих регионах

--Запрос использующий одно из внешних соединений двух таблиц
SELECT s.full_name, w.chef_name
FROM production.staff s
LEFT JOIN production.workshop w ON s.full_name = w.chef_name;
--Составной запрос
SELECT
    id,
    title,
    cost
FROM
    production.knot
WHERE
    region_id IN (SELECT id FROM production.region WHERE title = 'Кузова');

--Составной запрос с использованием  опреаторов ANY ALL EXISTS
SELECT
    r.id AS region_id,
    r.title AS region_title
FROM
    production.region r
WHERE
    EXISTS (
        SELECT 1
        FROM
            production.workshop_region wr
        WHERE
            wr.region_id = r.id
    );--узнаем все регионы для которыхсуществует хотя бы один цех
	
SELECT
    p.title AS product_title,
    r.title AS region_title
FROM
    production.product p
JOIN
    production.production pd ON p.id = pd.product_id
JOIN
    production.product_knot pk ON p.id = pk.product_id
JOIN
    production.knot k ON pk.knot_id = k.id
JOIN
    production.region r ON pd.region_id = r.id
WHERE
    k.cost <= ALL (SELECT k.cost FROM production.knot as k where k.cost>5000); -- тот запрос выбирает продукты и связанные с ними регионы, для которых стоимость каждого крепления не превышает 12000
select * from production.knot

	
	


SELECT
    p.title AS product_title,
    k.title AS knot_title,
    k.cost
FROM
    production.product p
JOIN
    production.product_knot pk ON p.id = pk.product_id
JOIN
    production.knot k ON pk.knot_id = k.id
WHERE
    k.cost > ANY (SELECT 6000 FROM production.knot);--сравнения стоимости каждого узла с пороговым значением



select * from production.staff


--Соотнесенный запрос
SELECT
    p.title AS product_title
FROM
    production.product p
WHERE
    EXISTS (
        SELECT *
        FROM production.production pd
        WHERE pd.product_id = p.id
          AND pd.DateCreated::date = '2023-03-22'::date
    );
SELECT *
FROM production.staff s
WHERE '2023-09-22'::date IN (
    SELECT shift_start_date::date
    FROM production.working_shift ws
    WHERE s.id = ws.staff_id
);
select * from production.working_shift
 
select * from production.production
--обновление 
UPDATE production.product
SET complexity = 6
WHERE id = 1; 
--удаление 
DELETE FROM production.product
WHERE id = 1; 









