CREATE TABLE [dbo].[SendProducts] (
    [Prod_Id]        INT           IDENTITY (1, 1) NOT NULL,
    [ProdName]       NVARCHAR (50) NULL,
    [comBoProds]     NVARCHAR (50) NULL,
    [ProdBareCod]    INT           NULL,
    [ProdPriceBuy]   INT           NULL,
    [ProdPriceSell]  INT           NULL,
    [ProdQoulty]     INT           NULL,
    [ProdPriceByQty] INT           NULL,
    [ProdPriceSeQty] INT           NULL,
    [EnterDate]      NVARCHAR(50)      NULL,
    [EndDate]        NVARCHAR(50)      NULL,
    PRIMARY KEY CLUSTERED ([Prod_Id] ASC)
);

