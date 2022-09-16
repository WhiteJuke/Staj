      SELECT DATABASE master;
      CREATE TABLE IF NOT EXISTS [Videostats] (
          [Id] int NOT NULL IDENTITY,
          [Link] nvarchar(max) NULL,
          [Title] nvarchar(max) NULL,
          [Author] nvarchar(max) NULL,
          CONSTRAINT [PK_Videostats] PRIMARY KEY ([Id])
      );
      
