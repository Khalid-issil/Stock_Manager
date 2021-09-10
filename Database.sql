--Creation de Baase De donnée 
Create database ProjetFF

use ProjetFF;

select Mot_De_Passe from Utilisateur where Nom_Utilisateur like 'issilk16@gmail.com'

select COUNT(*) from Categorie
select * from Client
select * from Produit
select * from Categorie
select * from Commande
select * from Details_Commande
-- Creation Des Tables 
-- Table Client
create table Client
(
	Id_Client int identity(1,1),
	Nom_Client varchar(30),
	Prenom_Client varchar(30),
	Adresse_Client varchar(200),
	Telephone_Client varchar(100),
	Pays_Client varchar(100),
	Ville_Client varchar(100),
	--Primary Key
	Constraint PK_Client primary Key(Id_Client)
)


alter table Client add Email_Client varchar(50)
-- Reset Conteur Client
DBCC CHECKIDENT('Details_Commande',RESEED,0);
--Afficher La table Client
select * from Client
delete from Details_Commande
--Table Produit 
create table Produit
(
	Id_Produit int identity(1,1),
	Nom_Produit varchar(50),
	Quantite_Produit int,
	Prix_Produit varchar(50),
	Image_Produit Image,
	-- Cle Etranger De table Categorie
	Id_Categorie int,
	-- Primary Key
	Constraint PK_Produit Primary Key(Id_Produit)
)
select * from Details_Commande where Id_Commande = 3
select Id_Categorie,Nom_Produit,Quantite_Produit,Prix_Produit,Image_Produit from Produit
-- Create Table CATEGORIE 

create table Categorie
(
	Id_Categorie int,
	Nom_Categorie varchar(100),
	-- Primary Key
	Constraint PK_Categorie Primary Key(Id_Categorie)
)
alter table Produit add constraint FK_Categorie foreign Key(Id_Categorie) references Categorie(Id_Categorie)
select * from Categorie

---- Table Commande 
create table Commande
(
	Id_Commande int identity(1,1),
	Date_Commande dateTime,

	----- foreign Key de table Client
	Id_Client int,
	constraint PK_Commande primary Key(Id_Commande)
)
select MAX(Id_Commande) from Commande
select * from Details_Commande
select * from Commande
select C.Date_Commande,CL.Nom_Client,Total_Ht,Tva,Total_Ttc from Commande C,Client CL
where C.Id_Client=CL.Id_Client
alter table Commande add constraint FK_Commande foreign Key(Id_Client) references Client(Id_Client)
alter table Commande add Total_Ht nvarchar(250),Tva nvarchar(250),Total_Ttc nvarchar(250);
alter table Commande
alter column Date_Commande date 
-- Table Details Commande

create table Details_Commande
(
	Id_Commande int foreign key references Commande(Id_Commande),
	Id_Produit int foreign key references Produit(Id_Produit),
	Quantite int
)
select * from Produit
select * from Commande
select * from Details_Commande

-- Create TABLE Utilisateur

create table Utilisateur
(
	Nom_Utilisateur varchar(100),
	Mot_De_Passe varchar(100),
	constraint PK_Utilisateur primary Key(Nom_Utilisateur)
)
alter table Utilisateur add Type_Utilisateur varchar(50)
alter table Utilisateur add constraint checkType check(Type_Utilisateur like 'admin' or Type_Utilisateur like 'user') 
-- Inserer des Users
insert into Utilisateur values('issilk16@gmail.com','issil123','admin')
-- afficher la table Utilisateurs
select * from Utilisateur

select Nom_Client,Prenom_Client,Adresse_Client,Telephone_Client,Pays_Client,Ville_Client,Email_Client from Client
select * from Client

select * from Details_Commande
select * from Commande

alter table Details_Commande
add  IdDetails int not null identity(1,1) primary key


select * from Utilisateur
insert into Utilisateur values('issilk12@gmail.com','issil123','user')


--Function Pour Ajouter Un Client
alter procedure InsertClient @nom varchar(50),@prenom varchar(50),@adresse varchar(50),@tel varchar(50),@pays varchar(50),@ville varchar(50),@email varchar(50),@cin varchar(50),@status int output
as 
begin
if exists(select Id_Client from Client where CIN_Client like @cin)
set @status=-1
else
begin
insert into Client values(@nom,@prenom,@adresse,@tel,@pays,@ville,@email,@cin)
set @status=1
end
end
--Procedure Afficher La liste des client
alter procedure AfficherTousLesClient
as
begin
select CIN_Client, Nom_Client,Prenom_Client,Adresse_Client,Telephone_Client,Pays_Client,Ville_Client,Email_Client from Client
end


--Procedure Afficher Client dapre le nom est le prenom est tel
alter procedure AfficheDetaislClient @cin varchar(50)
as
begin
select CIN_Client,Nom_Client,Prenom_Client,Adresse_Client,Telephone_Client,Pays_Client,Ville_Client,Email_Client from Client
where CIN_Client like @cin
end
select * from Client
--Procedure Pour Modifier Une Client
alter procedure ModifierClient @lastcin varchar(50),@cin varchar(50),@nom varchar(50),@prenom varchar(50),@adresse varchar(50),@tel varchar(50),@pays varchar(50),@ville varchar(50),@email varchar(50),@status int output
as 
begin
update Client 
set Nom_Client=@nom,Prenom_Client=@prenom,Adresse_Client=@adresse,Telephone_Client=@tel,Pays_Client=@pays,Ville_Client=@ville,Email_Client=@email,CIN_Client=@cin
where CIN_Client like @lastcin
set @status=1;
end
select * from Commande
-- Procedure Pour Supprimer Une Client
alter procedure SupprimerClient  @cin varchar(50),@status int output
as
begin 
if not exists(select Id_Client from Client where CIN_Client like @cin)
set @status= -1 
else if not exists (select distinct cl.Id_Client from Client cl,Commande C where (C.Id_Client=cl.Id_Client) and cl.CIN_Client like @cin)
begin
delete from Client where CIN_Client like @cin
set @status= 1
end
else
set @status=-2
end



--Procedure Pour Rechercher Une Client
alter procedure RechercheClient @nom varchar(50)
as
begin
select CIN_Client,Nom_Client,Prenom_Client,Adresse_Client,Telephone_Client,Pays_Client,Ville_Client,Email_Client from Client
where Nom_Client like '%'+@nom+'%'
end

--Afficher Tous Les Categories
Create procedure AfficherCetgorie 
as 
begin 
select Nom_Categorie from Categorie
end
-- Afficher Le Id De Categorie
create procedure AfficherId @nomCategorie varchar(100)
as 
begin
if exists (select Id_Categorie from Categorie where Nom_Categorie like @nomCategorie)
select Id_Categorie from Categorie where Nom_Categorie like @nomCategorie
else
select -2 
end
-- Afficher Le Nom De Categorie
Create function AfficherNomCategorie(@id int) returns varchar(100)
as
begin 
declare @nomCat varchar(100)=(select Nom_Categorie from Categorie where Id_Categorie = @id)
return @nomCat
end
--Ajouter Un Nouveau Produit 
select * from Produit
create procedure AjouterProduit @nom varchar(50),@Quantite int,@prix varchar(50),@image image,@idcategorie int,@status int output
as 
begin 
if not exists(select Id_Produit from Produit where Nom_Produit like @nom)
begin
insert into Produit values(@nom,@Quantite,@prix,@image,@idcategorie);
set @status=1
end
else
set @status=-1
end
--Afficher Les Produits
create procedure AfficherTousProduit
as
begin 
select  Id_Categorie,Nom_Produit,Quantite_Produit,Prix_Produit from Produit
end
select * from Produit
--Afficher Produit Par Categorie
create procedure AfficherProduitParCategorie @id int 
as 
begin
select Nom_Produit,Quantite_Produit,Prix_Produit from Produit where Id_Categorie=@id
end
--Afficher Image Produit
Create procedure AfficherImageProduit @nomProduit varchar(50)
as 
begin 
select Image_Produit from Produit
where Nom_Produit like @nomProduit
end
--Modifier Produit
Create Procedure ModifierProduit @lastnom varchar(50),@nom varchar(50),@prix varchar(50),@quantite int,@idcategorie int,@image image,@status int output
as
begin
update Produit
set Nom_Produit=@nom,Prix_Produit=@prix,Quantite_Produit=@quantite,Id_Categorie=@idcategorie,Image_Produit=@image
where Nom_Produit like @lastnom
set @status=1
end
select * from Produit
select * from Commande 
select * from Details_Commande
-- Supprimer Produit 
alter procedure SupprimerProduit @lastnom varchar(50)
as 
begin 
if not exists(select Id_Produit from Produit where Nom_Produit like @lastnom)
select -1
else if exists(select P.Id_Produit from Produit P,Details_Commande D where D.Id_Produit=P.Id_Produit and P.Nom_Produit like @lastnom)
select -2
else
delete from Produit where Nom_Produit like @lastnom
end
----- Recherche Produit Par Nom
alter procedure RechercheProduit @lastnom varchar(50),@nomCat varchar(50)
as
begin
select  C.Id_Categorie,P.Nom_Produit,P.Quantite_Produit,P.Prix_Produit from Produit P,Categorie C where P.Id_Categorie=C.Id_Categorie and P.Nom_Produit like '%'+@lastnom+'%'and C.Nom_Categorie like '%'+@nomCat+'%'
end


--Procedure RECHERCHE client Commande
alter procedure RechercheClientCmd @nom varchar(50),@prenom varchar(50),@cin varchar(50),@tel varchar(50)
as
begin 
select * from Client where Nom_Client like CONCAT('%',@nom,'%') and Prenom_Client like CONCAT('%',@prenom,'%') and CIN_Client like CONCAT('%',@cin,'%') and Telephone_Client like CONCAT('%',@tel,'%')
end

--procedure Ajouter Command
alter procedure AjouteCommande @cin varchar(50),@date datetime,@totalht Decimal,@tva int,@totalttc decimal,@status int output
as begin
declare @idclient int=(select Id_Client from Client where CIN_Client like @cin)
insert into Commande values(@date,@idclient,@totalht,@tva,@totalttc)
set @status=1
end
--Function Return Dernier Commande
create function DernierCommande() returns int
as begin
declare @max int=(select MAX(Id_Commande) from Commande)
return @max
end
--Procedure Pour Ajouter Les Details_Commande
select * from Details_Commande
create procedure AjouterDetailsCommande @idcmd int,@produit varchar(50),@quantite int,@prix varchar(50),@remise int,@totale varchar(50)
as begin
declare @idproduit int=(select Id_Produit from Produit where Nom_Produit like @produit)
insert into Details_Commande values(@idcmd,@idproduit,@quantite,@prix,@remise,@totale)
end
--Peocedure Mise Ajoure De Stock
create procedure MiseAjoureDestock @nomProduit varchar(50),@Quantite int
as begin
declare @stock int=(select Quantite_Produit from Produit where Nom_Produit like @nomProduit)
declare @newquantite int=@stock-@Quantite
update Produit
set Quantite_Produit=@newquantite where Nom_Produit like @nomProduit
end

--Recherche Commande Entre Deux Dates
alter Procedure RechercheCommandeDeuxdate @firstdate datetime,@lastdate datetime
as begin
select C.Date_Commande,CL.CIN_Client,Total_Ht,Tva,Total_Ttc from Commande C,Client CL where C.Id_Client = CL.Id_Client and (C.Date_Commande between @firstdate and @lastdate)
end
--Procedure Supprimer Une Commande
alter procedure SupprimerCommande @date date,@client varchar(50),@totalht varchar(50),@tva int,@totalttc varchar(50)
as begin
declare @idclient int=(select Id_Client from Client where CIN_Client like @client)
declare @idcommande int =(select Id_Commande from Commande where Id_Client = @idclient and Date_Commande like @date and Total_Ht like @totalht and Total_Ttc like @totalttc and Tva =@tva)
delete from Details_Commande where Id_Commande = @idcommande
delete from Commande where Id_Commande =@idcommande
end
--Procedure AfficherDetails Commande
create procedure AfficherDetails @date date,@client varchar(50),@totalht varchar(50),@tva int,@totalttc varchar(50)
as begin
declare @idclient int=(select Id_Client from Client where CIN_Client like @client)
declare @idcommande int =(select Id_Commande from Commande where Id_Client = @idclient and Date_Commande like @date and Total_Ht like @totalht and Total_Ttc like @totalttc and Tva =@tva)
select Nom_Produit,Quantite,Prix,Remise,Total from Details_Commande,Produit where Produit.Id_Produit=Details_Commande.Id_Produit and Details_Commande.Id_Commande=@idcommande
end
--Procedure recherche Dutilisateur
create procedure RechercheUtilisateur @nom varchar(50)
as begin
select * from Utilisateur where Nom_Utilisateur like '%'+@nom+'%'
end
--Procedure Lables DetailsCommande
create procedure lblDetailsCommande @cin varchar(50)
as begin
declare @nomclient varchar(50)=(select Nom_Client from Client where CIN_Client like @cin)
declare @idclient varchar(50)=(select Id_Client from Client where CIN_Client like @cin)
declare @DernierCommande date=(select MAX(Date_Commande) from Commande where Id_Client = @idclient)
declare @NombreCommandes int=(select COUNT(*) from Commande where Id_Client =@idclient)
declare @TotalCommandes varchar(50)=(select SUM(CONVERT(decimal,Total_Ttc)) from Commande where Id_Client = @idclient)
select @nomclient,@DernierCommande,@NombreCommandes,@TotalCommandes
end



