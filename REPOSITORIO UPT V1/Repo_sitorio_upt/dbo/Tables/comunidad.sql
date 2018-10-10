CREATE TABLE [dbo].[comunidad] (
    [id_comunidad]     INT      NOT NULL,
    [nombre_comunidad] CHAR (9) NOT NULL,
    [id_subcomunidad]  INT      NULL,
    [id_coleccion]     INT      NULL,
    PRIMARY KEY CLUSTERED ([id_comunidad] ASC),
    CONSTRAINT [FK_comunidad_en_coleccion] FOREIGN KEY ([id_coleccion]) REFERENCES [dbo].[coleccion] ([id_coleccion]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_comunidad_en_subcomunidad] FOREIGN KEY ([id_subcomunidad]) REFERENCES [dbo].[subcomunidad] ([id_subcomunidad]) ON DELETE CASCADE ON UPDATE CASCADE
);

