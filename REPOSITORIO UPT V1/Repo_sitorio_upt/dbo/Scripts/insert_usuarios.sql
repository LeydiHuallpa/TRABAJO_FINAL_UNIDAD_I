/*
Plantilla de script posterior a la implementación							
--------------------------------------------------------------------------------------
 Este archivo contiene instrucciones de SQL que se anexarán al script de compilación.		
 Use la sintaxis de SQLCMD para incluir un archivo en el script posterior a la implementación.			
 Ejemplo:      :r .\miArchivo.sql								
 Use la sintaxis de SQLCMD para hacer referencia a una variable en el script posterior a la implementación.		
 Ejemplo:      :setvar TableName miTabla							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO usuario(id_usuario,direccion_ip,region)
VALUES (1,'123.123.123.10','Tacna')
INSERT INTO usuario(id_usuario,direccion_ip,region)
VALUES (1,'123.123.123.11','Tacna')
INSERT INTO usuario(id_usuario,direccion_ip,region)
VALUES (1,'123.123.123.12','Tacna')
INSERT INTO usuario(id_usuario,direccion_ip,region)
VALUES (1,'123.123.123.13','Lima')
INSERT INTO usuario(id_usuario,direccion_ip,region)
VALUES (1,'123.123.123.14','Lima')
INSERT INTO usuario(id_usuario,direccion_ip,region)
VALUES (1,'123.123.123.15','Lima')
INSERT INTO usuario(id_usuario,direccion_ip,region)
VALUES (1,'123.123.123.16','Tacna')
INSERT INTO usuario(id_usuario,direccion_ip,region)
VALUES (1,'123.123.123.17','Tacna')
INSERT INTO usuario(id_usuario,direccion_ip,region)
VALUES (1,'123.123.123.18','Cuzco')
INSERT INTO usuario(id_usuario,direccion_ip,region)
VALUES (1,'123.123.123.19','Moquegua')
INSERT INTO usuario(id_usuario,direccion_ip,region)
VALUES (1,'123.123.123.20','Arequipa')
INSERT INTO usuario(id_usuario,direccion_ip,region)
VALUES (1,'123.123.123.21','Cuzco')
