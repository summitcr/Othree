-- Database: othree

-- DROP DATABASE othree;

CREATE DATABASE othree
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'en_US.utf8'
    LC_CTYPE = 'en_US.utf8'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1;
	

-- Table: public."Custumer"

-- DROP TABLE public."Custumer";

CREATE TABLE public."Custumer"
(
    customer_id integer NOT NULL DEFAULT nextval('"Custumer_customer_id_seq"'::regclass),
    name character varying(50) COLLATE pg_catalog."default" NOT NULL,
    lastname character varying(50) COLLATE pg_catalog."default" NOT NULL,
    birth date NOT NULL,
    email character varying(150) COLLATE pg_catalog."default" NOT NULL,
    phonenumber character varying(20) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT "Custumer_pkey" PRIMARY KEY (customer_id)
)
WITH (
    OIDS = FALSE
)
TABLESPACE pg_default;

ALTER TABLE public."Custumer"
    OWNER to postgres;
	
	
