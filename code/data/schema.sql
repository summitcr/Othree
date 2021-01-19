

-- Table: public."Custumer"

-- DROP TABLE public."Custumer";

CREATE TABLE public."Customer"
(
    id SERIAL,
    name character varying(50) COLLATE pg_catalog."default" NOT NULL,
    lastname character varying(50) COLLATE pg_catalog."default" NOT NULL,
    birth date NOT NULL,
    email character varying(150) COLLATE pg_catalog."default" NOT NULL,
    phonenumber character varying(20) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT "Custumer_pkey" PRIMARY KEY (id)
)
WITH (
    OIDS = FALSE
)



TABLESPACE pg_default;

ALTER TABLE public."Customer"
    OWNER to postgres;
	

	
