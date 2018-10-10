CREATE TABLE [dbo].[editorial] (
    [id_editorial]      INT        NOT NULL,
    [nombre_editorial]  CHAR (150) NOT NULL,
    [fecha_publicacion] DATE       NOT NULL,
    PRIMARY KEY CLUSTERED ([id_editorial] ASC)
);

