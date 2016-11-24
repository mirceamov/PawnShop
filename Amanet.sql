--se creaza login amanet
IF NOT EXISTS (SELECT name FROM sys.server_principals WHERE name = 'amanet')
BEGIN
	CREATE LOGIN amanet WITH PASSWORD = 'Amanet@2015'
	,CHECK_EXPIRATION = OFF
	,CHECK_POLICY = OFF;
END
GO

USE master
GO
--GRANT CONTROL SERVER TO amanet;
--GO

--se creeaza baza de date Amanet
IF DB_ID('Amanet') IS NULL
BEGIN
	CREATE DATABASE Amanet
END
GO

ALTER AUTHORIZATION ON DATABASE::Amanet TO amanet
GO

USE Amanet;
GO

--creaza tabele pentru baza de date Amanet
BEGIN TRANSACTION tabele;
GO

IF OBJECT_ID('Clienti', 'U') IS NULL
BEGIN 
	CREATE TABLE Clienti (
		id int IDENTITY(1,1) PRIMARY KEY
		,nume nvarchar(50) NOT NULL
		,prenume nvarchar(50) NOT NULL
		,domiciliul nvarchar(500) NOT NULL
		,ciSerie nvarchar(2)
		,ciNumar nvarchar(6)
		,ciEliberatDe nvarchar(20)
		,ciEliberatLa datetime2
		,telefon nvarchar(20)
		,creatLa datetime2 NOT NULL DEFAULT GETDATE()
		,modificatLa datetime2 NOT NULL DEFAULT GETDATE()
		,inactiv bit NOT NULL DEFAULT 0
		,lockVersion int NOT NULL DEFAULT 0
		,CONSTRAINT ClientUnic_NumePrenume UNIQUE(nume, prenume, ciSerie, ciNumar)
	);
END
GO

IF OBJECT_ID('Produse', 'U') IS NULL
BEGIN 
	CREATE TABLE Produse (
		id int IDENTITY(1,1) PRIMARY KEY
		,denumire nvarchar(250) NOT NULL
		,creatLa datetime2 NOT NULL DEFAULT GETDATE()
		,modificatLa datetime2 NOT NULL DEFAULT GETDATE()
		,inactiv bit NOT NULL DEFAULT 0
		,lockVersion int NOT NULL DEFAULT 0
		,CONSTRAINT ProdusUnic_Denumire UNIQUE(denumire)
	);
END
GO

IF OBJECT_ID('Calitati', 'U') IS NULL
BEGIN 
	CREATE TABLE Calitati (
		id int IDENTITY(1,1) PRIMARY KEY
		,denumire nvarchar(250) NOT NULL
		,creatLa datetime2 NOT NULL DEFAULT GETDATE()
		,modificatLa datetime2 NOT NULL DEFAULT GETDATE()
		,inactiv bit NOT NULL DEFAULT 0
		,lockVersion int NOT NULL DEFAULT 0
		,CONSTRAINT CalitateUnica_Denumire UNIQUE(denumire)
	);
END
GO

IF OBJECT_ID('ContracteAntet', 'U') IS NULL
BEGIN 
	CREATE TABLE ContracteAntet (
		id int IDENTITY(1,1) PRIMARY KEY
		,nrContract int NOT NULL
		,dataContract datetime2 NOT NULL
		,idClient int NOT NULL
		,valoareCredit decimal(15,6) 
		,comisionProcZi decimal(8,4)
		,valoareCreditZi decimal(15,6)
		,valoareDebit decimal(15,6)
		,nrZile int
		,dataScadenta datetime2
		/*
		stareContract poate avea valorile : 
			'ACTIV' contractul este in derulare (valoare implicita) 
			'ACHITAT' contractul a fost terminat prin achitarea debitului
			'NEACHITAT' contractul nu a fost achitat iar produsele au ramas in gestiunea amanetului 
		*/
		,stareContract nvarchar(10) NOT NULL DEFAULT 'ACTIV'		
		,observatii nvarchar(500)
		,creatLa datetime2 NOT NULL DEFAULT GETDATE()
		,modificatLa datetime2 NOT NULL DEFAULT GETDATE()
		,inactiv bit NOT NULL DEFAULT 0
		,lockVersion int NOT NULL DEFAULT 0
		,CONSTRAINT ContractUnic_nrContract UNIQUE(nrContract, dataContract)
		,CONSTRAINT FK_Contracte_Clienti FOREIGN KEY (idClient) REFERENCES Clienti(id)
	);
END
GO

IF OBJECT_ID('ContracteProduse', 'U') IS NULL
BEGIN 
	CREATE TABLE ContracteProduse (
		id int IDENTITY(1,1) PRIMARY KEY
		,idContract int NOT NULL
		,idProdus int NOT NULL
		,idCalitate int NOT NULL
		,bucati int NOT NULL
		,descriere nvarchar(250)
		,gramajPiesa decimal(15,6)
		,gramajAur decimal(15,6)
		,creatLa datetime2 NOT NULL DEFAULT GETDATE()
		,modificatLa datetime2 NOT NULL DEFAULT GETDATE()
		,inactiv bit NOT NULL DEFAULT 0
		,lockVersion int NOT NULL DEFAULT 0
		,CONSTRAINT FK_ContracteProduse_ContracteAntet FOREIGN KEY (idContract) REFERENCES ContracteAntet(id)
		,CONSTRAINT FK_ContracteProduse_Produse FOREIGN KEY (idProdus) REFERENCES Produse(id)
		,CONSTRAINT FK_ContracteProduse_Calitati FOREIGN KEY (idCalitate) REFERENCES Calitati(id)	
	);
END
GO

IF OBJECT_ID('PROC_RptPrintareContract', 'P') IS NOT NULL
BEGIN
	DROP PROCEDURE PROC_RptPrintareContract
END
GO

CREATE PROCEDURE PROC_RptPrintareContract
	@idContract INT
AS 
BEGIN
	DECLARE @sql NVARCHAR(MAX)

	IF OBJECT_ID ('lstPrintareContract', 'U') IS NOT NULL
	BEGIN
		DROP TABLE lstPrintareContract;
	END
			SELECT ca.nrContract NumarContract
			,ca.dataContract DataContract
			,cli.nume + ' ' + cli.prenume AS NumePrenume
			,cli.domiciliul AS Domiciliul
			,cli.ciSerie AS SerieCI
			,cli.ciNumar AS NumarCI
			,cli.ciEliberatDe AS EliberatDe
			,cli.ciEliberatLa AS EliberatLa
			,cli.telefon AS Telefon
			,prod.denumire AS Denumire
			,cp.bucati AS Bucati
			,cp.descriere AS Descriere
			,cp.gramajPiesa AS GramajPiesa
			,cp.gramajAur AS GramajAur
			,cal.denumire AS Calitate
			,ca.valoareCredit AS ValoareCredit
			,ca.comisionProcZi AS ComisionProcZi
			,ca.valoareCreditZi AS ValoareComisionZi
			,ca.valoareDebit AS ValoareDebit
			,ca.nrZile AS NrZileImprumut
			,ca.dataScadenta AS DataScadenta

		INTO lstPrintareContract

		FROM dbo.ContracteAntet ca
			JOIN dbo.Clienti cli ON ca.idClient = cli.id
			JOIN dbo.ContracteProduse cp ON ca.id = cp.idContract
			JOIN dbo.Produse prod ON cp.idProdus = prod.id
			JOIN dbo.Calitati cal ON cp.idCalitate = cal.id
		WHERE ca.id = @idContract
END

GO

COMMIT TRANSACTION tabele;
GO



