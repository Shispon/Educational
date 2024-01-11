CREATE OR REPLACE FUNCTION auth.insert__user(
    p_login text,
    p_password text,
    p_first_name text,
    p_middle_name text,
    p_last_name text,
    p_mail text,
    p_number_phone text
) RETURNS integer AS $$
DECLARE
    new_user_id integer;
BEGIN
    INSERT INTO auth.user (login, password, first_name, middle_name, last_name, mail, number_phone)
    VALUES (p_login, p_password, p_first_name, p_middle_name, p_last_name, p_mail, p_number_phone)
    RETURNING id INTO new_user_id;

    
    RETURN new_user_id;
END;
$$ LANGUAGE plpgsql;
