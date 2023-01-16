CREATE TABLE IF NOT EXISTS "ProdutoEntity" (
  "CodProduto" SERIAL NOT NULL,
  "NomeProduto" varchar(250) NOT NULL,
  "Quantidade" INT NOT NULL,
  "ValorProduto" NUMERIC(4,2),
  PRIMARY KEY ("CodProduto")
);

CREATE TABLE IF NOT EXISTS "EmpresaEntity" (
  "CodEmpresa" SERIAL  NOT NULL,
  "NomeEmpresa" varchar(450) NOT NULL,
  "CnpjEmpresa" varchar(15) NOT NULL,
  PRIMARY KEY ("CodEmpresa")
);

CREATE TABLE IF NOT EXISTS "CompraEntity" (
  "CodCompra" SERIAL NOT NULL,
  "CodProduto" INT  NOT NULL REFERENCES "ProdutoEntity"("CodProduto"),
  "CodEmpresa" INT NOT NULL REFERENCES "EmpresaEntity"("CodEmpresa"),
  "Quantidade" INT NOT NULL,
  "ValorCompra" NUMERIC,
  "DataCompra" timestamp
);



