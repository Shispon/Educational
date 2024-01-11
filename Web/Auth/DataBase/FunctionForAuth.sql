CREATE OR REPLACE FUNCTION auth.authenticate_user(
    p_login text,
    p_password text
) RETURNS SETOF auth.user AS $$
BEGIN
    RETURN QUERY
    SELECT * FROM auth.user
    WHERE login = p_login AND password = p_password;
END;
$$ LANGUAGE plpgsql;