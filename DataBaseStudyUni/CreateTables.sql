create schema production;



create table production.region
(
	id integer primary key generated by default as identity,
	title text not null
);


create table production.product
(
	id integer primary key generated by default as identity,
	title text not null,
	complexity int not null,
	DateCreated timestamp(6) with time zone not null
);

create table production.knot
(
	id integer primary key generated by default as identity,
	title text not null,
	cost integer NOT NULL CHECK (cost >= 0),
	region_id int not null,
	foreign key(region_id) references production.region(id)
	on delete cascade
);

create table production.workshop
(
	id integer primary key generated by default as identity,
	title text not null,
	chef_name text not null
);

CREATE TABLE production.staff
(
    id serial PRIMARY KEY,
    title text NOT NULL,
    first_name text NOT NULL,
    second_name text NOT NULL,
    last_name text NOT NULL,
    phone_number text NOT NULL UNIQUE,
    address text NOT NULL UNIQUE,
    post text NOT NULL UNIQUE,
    full_name text GENERATED ALWAYS AS (
        first_name || ' ' || LEFT(second_name, 1) || '.' || LEFT(last_name, 1) || '.'
    ) STORED
);


create table production.production
(
	id integer primary key generated by default as identity,
	title text not null,
	DateCreated timestamp(6) with time zone not null,
	DateDelete timestamp(6) with time zone,
	product_id int not null,
	workshop_id int not null,
	region_id int not null,
	staff_id int not null,
	foreign key(product_id) references production.product(id)
	on delete cascade,
	foreign key(workshop_id) references production.workshop(id)
	on delete cascade,
	foreign key(region_id) references production.region(id)
	on delete cascade,
	foreign key(staff_id) references production.staff(id)
	on delete cascade
);


create table production.product_knot
(
	product_id int not null,
	knot_id int not null,
	foreign key(product_id) references production.product(id)
	on delete cascade,
	foreign key(knot_id) references production.knot(id)
	on delete cascade
);

create table production.workshop_region
(
	workshop_id int not null,
	region_id int not null,
	foreign key(workshop_id) references production.workshop(id)
	on delete cascade,
	foreign key(region_id) references production.region(id)
	on delete cascade
);


create table production.working_shift
(
	id integer primary key generated by default as identity,
	title text not null,
	shift_start_date timestamp(6) with time zone not null,
	shift_end_date timestamp(6) with time zone not null,
	staff_id int not null,
	foreign key(staff_id) references production.staff(id)
	on delete cascade
);


create table production.staff_region
(
	staff_id int not null,
	region_id int not null,
	foreign key(staff_id) references production.staff(id)
	on delete cascade,
	foreign key(region_id) references production.region(id)
	on delete cascade
);

create table production.staff_workshop
(
	staff_id int not null,
	workshop_id int not null,
	foreign key(staff_id) references production.staff(id)
	on delete cascade,
	foreign key(workshop_id) references production.workshop(id)
	on delete cascade
);