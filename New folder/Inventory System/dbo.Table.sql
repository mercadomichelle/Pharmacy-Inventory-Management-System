CREATE TABLE [dbo].[tblMedicine] (
    [medID]       INT           NOT NULL,
    [brandName]   VARCHAR (50)  NOT NULL,
    [genName]     VARCHAR (50)  NOT NULL,
    [dosage]      VARCHAR (50)  NOT NULL,
    [desc] VARCHAR (255) NULL,
    [effects] VARCHAR (255) NULL,
    [mfgDate]     DATE          NULL,
    [expDate]     DATE          NULL,
    [stocks]      INT           NOT NULL,
    CONSTRAINT [PK_tblMedicine] PRIMARY KEY CLUSTERED ([medID] ASC)
);

