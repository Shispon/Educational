CREATE OR REPLACE FUNCTION production.add_staff_to_random_region()
RETURNS TRIGGER AS $$
DECLARE
    v_region_ids integer[];
    v_random_region_id integer;
BEGIN
    -- Получаем массив id регионов
    SELECT array_agg(id) INTO v_region_ids FROM production.region;

    -- Выбираем случайный id региона
    v_random_region_id := v_region_ids[FLOOR(random() * array_length(v_region_ids, 1)) + 1];

    -- Добавляем сотрудника в выбранный регион
    INSERT INTO production.staff_region(staff_id, region_id)
    VALUES (NEW.id, v_random_region_id);

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER add_staff_to_region_trigger
AFTER INSERT ON production.staff
FOR EACH ROW
EXECUTE FUNCTION production.add_staff_to_random_region();
