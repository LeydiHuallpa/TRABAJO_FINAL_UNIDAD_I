CREATE TABLE [dbo].[escuela] (
    [id_escuela]     INT        NOT NULL,
    [id_facultad]    INT        NOT NULL,
    [nombre_escuela] CHAR (250) NOT NULL,
    PRIMARY KEY CLUSTERED ([id_escuela] ASC),
    CONSTRAINT [FK_facultad_en_escuela] FOREIGN KEY ([id_facultad]) REFERENCES [dbo].[facultad] ([id_facultad]) ON DELETE CASCADE ON UPDATE CASCADE
);

