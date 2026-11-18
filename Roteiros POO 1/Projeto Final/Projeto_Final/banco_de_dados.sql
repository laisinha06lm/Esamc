-- Table: public.categoria

-- DROP TABLE IF EXISTS public.categoria;

CREATE TABLE IF NOT EXISTS public.categoria
(
    id_categoria serial NOT NULL,
    nome character varying(100) COLLATE pg_catalog."default" NOT NULL,
    ativa boolean NOT NULL DEFAULT true,
    CONSTRAINT categoria_pkey PRIMARY KEY (id_categoria)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.categoria
    OWNER to postgres;



-- Table: public.produto

-- DROP TABLE IF EXISTS public.produto;

CREATE TABLE IF NOT EXISTS public.produto
(
    id_produto serial NOT NULL,
    id_categoria integer NOT NULL,
    codigo_barras character varying(100) COLLATE pg_catalog."default",
    nome character varying(100) COLLATE pg_catalog."default" NOT NULL,
    preco numeric(10,2) NOT NULL,
    estoque integer NOT NULL DEFAULT 0,
    ativo boolean NOT NULL DEFAULT true,
    CONSTRAINT produto_pkey PRIMARY KEY (id_produto),
    CONSTRAINT produto_codigo_barras_key UNIQUE (codigo_barras),
    CONSTRAINT fk_produto_categoria FOREIGN KEY (id_categoria)
        REFERENCES public.categoria (id_categoria) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT produto_preco_check CHECK (preco > 0::numeric),
    CONSTRAINT produto_estoque_check CHECK (estoque >= 0)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.produto
    OWNER to postgres;



-- Table: public.venda

-- DROP TABLE IF EXISTS public.venda;

CREATE TABLE IF NOT EXISTS public.venda
(
    id_venda serial NOT NULL,
    data_hora timestamp without time zone NOT NULL DEFAULT CURRENT_TIMESTAMP,
    valor_total numeric(10,2) NOT NULL DEFAULT 0,
    forma_pagamento character varying(20) COLLATE pg_catalog."default" NOT NULL,
    status character varying(20) COLLATE pg_catalog."default" NOT NULL DEFAULT 'Concluida'::character varying,
    subtotal numeric(10,2),
    percentual_desconto numeric(5,2),
    valor_desconto numeric(10,2),
    CONSTRAINT venda_pkey PRIMARY KEY (id_venda),
    CONSTRAINT venda_valor_total_check CHECK (valor_total >= 0::numeric),
    CONSTRAINT chk_venda_status CHECK (status::text = ANY (ARRAY['Concluida'::character varying, 'Cancelada'::character varying]::text[])),
    CONSTRAINT chk_venda_pagamento CHECK (forma_pagamento::text = ANY (ARRAY['Dinheiro'::character varying, 'Pix'::character varying, 'Credito'::character varying, 'Debito'::character varying]::text[]))
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.venda
    OWNER to postgres;



-- Table: public.item_venda

-- DROP TABLE IF EXISTS public.item_venda;

CREATE TABLE IF NOT EXISTS public.item_venda
(
    id_item serial NOT NULL,
    id_venda integer NOT NULL,
    id_produto integer NOT NULL,
    quantidade integer NOT NULL,
    preco_unitario numeric(10,2) NOT NULL,
    subtotal numeric(10,2) NOT NULL,
    CONSTRAINT item_venda_pkey PRIMARY KEY (id_item),
    CONSTRAINT fk_item_produto FOREIGN KEY (id_produto)
        REFERENCES public.produto (id_produto) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT fk_item_venda FOREIGN KEY (id_venda)
        REFERENCES public.venda (id_venda) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION,
    CONSTRAINT item_venda_quantidade_check CHECK (quantidade > 0),
    CONSTRAINT item_venda_preco_unitario_check CHECK (preco_unitario > 0::numeric),
    CONSTRAINT item_venda_subtotal_check CHECK (subtotal >= 0::numeric)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.item_venda
    OWNER to postgres;