CREATE OR REPLACE FUNCTION production.add_new_staff_with_shift(
    p_title text,
    p_first_name text,
    p_second_name text,
    p_last_name text,
    p_phone_number text,
    p_address text,
    p_post text,
    p_shift_title text,
    p_shift_start_date timestamp with time zone,
    p_shift_end_date timestamp with time zone
) RETURNS text AS $$
DECLARE
    v_staff_id integer;
    v_full_name text;
BEGIN
    -- Добавление нового сотрудника
    INSERT INTO production.staff(title, first_name, second_name, last_name, phone_number, address, post)
    VALUES (p_title, p_first_name, p_second_name, p_last_name, p_phone_number, p_address, p_post)
    RETURNING id INTO v_staff_id;

    -- Добавление смены для нового сотрудника
    INSERT INTO production.working_shift(title, shift_start_date, shift_end_date, staff_id)
    VALUES (p_shift_title, p_shift_start_date, p_shift_end_date, v_staff_id);

    -- Получение полного имени сотрудника
    SELECT INTO v_full_name
        first_name || ' ' || COALESCE(second_name || ' ', '') || last_name
    FROM production.staff
    WHERE id = v_staff_id;

    -- Возвращение полного имени нового сотрудника
    RETURN v_full_name;
END;
$$ LANGUAGE plpgsql;


select production.add_new_staff_with_shift(
        'Умный парень', 
        'Кирил', 
        'И.', 
        'Финов', 
        '12345682149', 
        'Ленинград', 
        'Поэт', 
        'Day Shift', 
        NOW(), 
        NOW() + interval '8 hours'
    ); 
	
select * from production.staff
select * from production.working_shift
select * from production.staff_region
