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
INSERT INTO facultad(id_facultad,nombre_facultad)
VALUES (1,'Facultad de Ingeniería')
INSERT INTO facultad(id_facultad,nombre_facultad)
VALUES (2,'Facultad de Arquitectura y Urbanismo')
INSERT INTO facultad(id_facultad,nombre_facultad)
VALUES (3,'Facultad de Ciencias de la Salud')
INSERT INTO facultad(id_facultad,nombre_facultad)
VALUES (4,'Facultad de Ciencias Empresariales')
INSERT INTO facultad(id_facultad,nombre_facultad)
VALUES (5,'Facultad de Derecho y Ciencias Políticas')
INSERT INTO facultad(id_facultad,nombre_facultad)
VALUES (6,'Facultad de Educación, Ciencias de la Comunicación y Humanidades')

