create proc insert_SendProducts
@Prod_Id int ,
@ProdName nvarchar(50),
@comBoProds nvarchar(50),
@ProdBareCod int ,
@ProdPriceBuy int ,
@ProdPriceSell int ,
@ProdQoulty int ,
@ProdPriceByQty int ,
@ProdPriceSeQty int ,
@EnterDate datetime,
@EndDate datetime
as 
begin 
insert into SendProducts(ProdName,comBoProds,ProdBareCod,ProdPriceBuy,ProdPriceSell,ProdPriceByQty,ProdPriceSeQty,ProdPriceSeQty,EnterDate,EndDate )
values(@ProdName,@comBoProds,@ProdBareCod,@ProdPriceBuy,@ProdPriceSell,@ProdQoulty,@ProdPriceByQty,@ProdPriceSeQty,@EnterDate,@EndDate)
end

