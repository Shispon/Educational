truncate table production.production restart identity cascade;
truncate table production.product_knot restart identity cascade;
truncate table production.workshop_region restart identity cascade;
truncate table production.staff_workshop restart identity cascade;
truncate table production.staff_region restart identity cascade;
--truncate table machines_status restart identity cascade;
truncate table production.workshop restart identity cascade;
truncate table production.region restart identity cascade;
truncate table production.product restart identity cascade;
truncate table production.knot restart identity cascade;
truncate table production.working_shift restart identity cascade;
truncate table production.staff restart identity cascade;



drop table if exists production.production cascade;
drop table if exists production.product_knot cascade;
drop table if exists production.workshop_region cascade;
drop table if exists production.staff_workshop cascade;
drop table if exists production.staff_region cascade;
--drop table if exists machines_status cascade;
drop table if exists production.workshop cascade;
drop table if exists production.region cascade;
drop table if exists production.product cascade;
drop table if exists production.knot cascade;
drop table if exists production.working_shift cascade;
drop table if exists production.staff cascade;