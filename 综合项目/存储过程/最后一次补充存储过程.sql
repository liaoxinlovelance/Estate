use shenhaizhadan
go

if exists(select * from sysobjects where name='Pr_xinhuruzhuxiugai')
drop proc Pr_xinhuruzhuxiugai
go
create proc Pr_xinhuruzhuxiugai(@name nvarchar(50),
@cz int,
@if int,
@cw int,
@namegai nvarchar(50)
)
as
UPDATE [dbo].[yonghuzhuce]
              SET  [yhname] = @name
                  ,[chongzhiID] = @cz
                  ,[lfID] = @if 
                  ,[cwID] = @cw
                  
             WHERE   [yhname] = @namegai

exec  Pr_xinhuruzhuxiugai'Ð»Çï',4,10,102,'Ð»Çï'

 
if exists(select * from sysobjects where name='Pro_cheweixinxiweihubaocun')
drop proc Pro_cheweixinxiweihubaocun
go
create proc Pro_cheweixinxiweihubaocun(
@cheid nvarchar(50),
@jg nvarchar(50),
@zhang nvarchar(50),
@type nvarchar(50),
@id nvarchar(50)
)
as
UPDATE [dbo].[Cheweixinxi]
                 SET 
                    [CheIDs] =@cheid
                     ,[ChePrice] =@jg
                      ,[CheZhang] = @zhang 
                      ,[Chetype] = @type
                 WHERE [CheIDs]=@id
                