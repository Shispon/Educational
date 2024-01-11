CREATE OR REPLACE FUNCTION production.add_new_production()
RETURNS TRIGGER AS $$
BEGIN
    -- Добавление нового производства
    INSERT INTO production.production(title, DateCreated, product_id, workshop_id,  staff_id)
    VALUES (NEW.title, NOW(), NEW.id,1,1 );

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER new_product_trigger
AFTER INSERT ON production.product
FOR EACH ROW
EXECUTE FUNCTION production.add_new_production();


select * from production.region