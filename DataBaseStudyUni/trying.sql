select * from production.product_knot
select * from production.product
select * from production.production
select * from production.region
select * from production.knot

select pr.title,p.title, sum(k.cost) as summa
from production.production  as pr
join production.product as p on p.id = pr.product_id
join production.product_knot as pk on p.id=pk.product_id
join production.knot as k on pk.knot_id = k.id
group by pr.id, p.id


select r.title
from production.region as r
join production.knot as k on r.id = k.region_id
where min(select sum(k.cost) from production.knot as k )


select r.title
from production.region as r
join production.knot as k on r.id = k.region_id
where any(
	(select sum(k.cost) as summa
	from production.region as r 
	join production.knot k on r.id = k.region_id
	where 
	r.id = (select r_min.id 
			from production.region r_min
			join production.knot k_min on r_min.id = k_min.region_id
			group by r_min.id
			order by sum(k_min.cost)
			limit 1
		   )
			GROUP BY
				r.id;
	)  
	> (select  ))


SELECT
    r.id,
    r.title AS region_title,
    SUM(k.cost) AS total_cost
FROM
    production.region r
JOIN
    production.knot k ON r.id = k.region_id
GROUP BY
    r.id, r.title
ORDER BY
    total_cost;

SELECT
    r.title AS region_title,
    SUM(k.cost) AS total_cost
FROM
    production.region r
JOIN
    production.knot k ON r.id = k.region_id
WHERE
    r.id = (
        SELECT
            r_min.id
        FROM
            production.region r_min
        JOIN
            production.knot k_min ON r_min.id = k_min.region_id
        GROUP BY
            r_min.id
        ORDER BY
            SUM(k_min.cost)
        LIMIT 1
    )
GROUP BY
    r.id;