CREATE TABLE [dbo].[usuario] (
    [id_usuario]   INT          NOT NULL,
    [direccion_ip] VARCHAR (25) NOT NULL,
    [region]       CHAR (250)   NOT NULL,
    PRIMARY KEY CLUSTERED ([id_usuario] ASC)
);

