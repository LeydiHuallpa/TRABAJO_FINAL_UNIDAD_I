CREATE TABLE [dbo].[documento] (
    [id_documento]      INT        NOT NULL,
    [id_comunidad]      INT        NOT NULL,
    [id_escuela]        INT        NOT NULL,
    [id_autor]          INT        NOT NULL,
    [id_fichero]        INT        NOT NULL,
    [id_tipo_documento] INT        NOT NULL,
    [id_editorial]      INT        NOT NULL,
    [nombre_libro]      CHAR (350) NOT NULL,
    PRIMARY KEY CLUSTERED ([id_documento] ASC),
    CONSTRAINT [FK_autor_en_documento] FOREIGN KEY ([id_autor]) REFERENCES [dbo].[autor] ([id_autor]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_comunidad_en_documento] FOREIGN KEY ([id_comunidad]) REFERENCES [dbo].[comunidad] ([id_comunidad]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_editorial_en_documento] FOREIGN KEY ([id_editorial]) REFERENCES [dbo].[editorial] ([id_editorial]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_escuela_en_documento] FOREIGN KEY ([id_escuela]) REFERENCES [dbo].[escuela] ([id_escuela]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_fichero_en_documento] FOREIGN KEY ([id_fichero]) REFERENCES [dbo].[fichero] ([id_fichero]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_tipo_documento_en_documento] FOREIGN KEY ([id_tipo_documento]) REFERENCES [dbo].[tipo_documento] ([id_tipo_documento]) ON DELETE CASCADE ON UPDATE CASCADE
);

