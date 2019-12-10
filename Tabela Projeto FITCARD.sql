create table Estabelecimento(
id int identity(1,1) primary key,
NomeFantasia varchar(300) not null,
CNPJ varchar(20) not null,
Email varchar(200)not null,
Endereço varchar(150)not null,
Cidade varchar(50)not null,
Estado varchar(50)not null,
Telefone varchar(9)not null,
DataCadastro date not null,
Categoria varchar(20)not null,
StatusEstabelecimento varchar(20)not null,
Agência varchar(10)not null,
Conta varchar(10)not null)

select * from Estabelecimento