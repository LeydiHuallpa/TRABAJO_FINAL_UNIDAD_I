CREATE TABLE [dbo].[detalle_consulta] (
    [id_detalle_consulta] INT NOT NULL,
    [id_documento]        INT NOT NULL,
    [id_usuario]          INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id_detalle_consulta] ASC),
    CONSTRAINT [FK_documento_en_detalle_consulta] FOREIGN KEY ([id_documento]) REFERENCES [dbo].[documento] ([id_documento]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_usuario_en_detalle_consulta] FOREIGN KEY ([id_usuario]) REFERENCES [dbo].[usuario] ([id_usuario]) ON DELETE CASCADE ON UPDATE CASCADE
);

