CREATE OR REPLACE FUNCTION production.add_new_product(
    p_title text,
    p_complexity int,
    p_knots integer[]
) RETURNS integer AS $$
DECLARE
    v_product_id integer;
    v_total_cost integer := 0;
BEGIN
    -- Добавление нового продукта
    INSERT INTO production.product(title, complexity, DateCreated)
    VALUES (p_title, p_complexity, NOW())
    RETURNING id INTO v_product_id;

    -- Связывание узлов с продуктом в таблице product_knot
    FOR i IN 1..array_length(p_knots, 1) LOOP
        INSERT INTO production.product_knot(product_id, knot_id)
        VALUES (v_product_id, p_knots[i]);
    END LOOP;

    -- Рассчет общей стоимости узлов для нового продукта
    SELECT INTO v_total_cost
        SUM(k.cost)
    FROM production.product_knot pk
    JOIN production.knot k ON pk.knot_id = k.id
    WHERE pk.product_id = v_product_id;

    -- Обновление общей стоимости в таблице product
    UPDATE production.product
    SET complexity = v_total_cost
    WHERE id = v_product_id;

    -- Возвращение общей стоимости нового продукта
    RETURN v_total_cost;
END;
$$ LANGUAGE plpgsql;


select * from production.knot


    select production.add_new_product('Lada Vesta', 3, ARRAY[1, 2, 3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18]); 

select * from production.product

select * from production.production
