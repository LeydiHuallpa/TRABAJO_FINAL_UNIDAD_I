CREATE TABLE [dbo].[fichero] (
    [id_fichero]     INT        NOT NULL,
    [nombre_fichero] CHAR (250) NOT NULL,
    [descripcion]    CHAR (50)  NULL,
    [tamaño]         INT        NOT NULL,
    [formato]        CHAR (50)  NOT NULL,
    PRIMARY KEY CLUSTERED ([id_fichero] ASC)
);

