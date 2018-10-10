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
INSERT INTO escuela(id_escuela,nombre_escuela)
VALUES (1,'Escuela Profesional de Arquitectura')
INSERT INTO escuela(id_escuela,nombre_escuela)
VALUES (2,'Escuela Profesional de Medicina Humana')
INSERT INTO escuela(id_escuela,nombre_escuela)
VALUES (3,'Escuela Profesional de Administración de Negocios Internacionales')
INSERT INTO escuela(id_escuela,nombre_escuela)
VALUES (4,'Escuela Profesional de Derecho')
INSERT INTO escuela(id_escuela,nombre_escuela)
VALUES (5,'Escuela Profesional de Ciencias de la Comunicación')
INSERT INTO escuela(id_escuela,nombre_escuela)
VALUES (6,'Escuela Profesional de Ingeniería de Sistemas')
