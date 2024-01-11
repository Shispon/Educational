create table auth.user(
	id integer primary key generated by default as identity,
	login text not null unique,
	password text not null,
	first_name text not null,
	middle_name text not null,
	last_name text not null,
	mail text not null,
	number_phone text not null
)
