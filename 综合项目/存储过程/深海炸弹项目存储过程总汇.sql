--操作人廖鑫
use [shenhaizhadan]
go
--登录信息
if exists(select * from sysobjects where name='Pro_dengluxinxi')
drop proc Pro_dengluxinxi
go 
create proc Pro_dengluxinxi(@yhdlname varchar(50))
as
SELECT [yhdlname]
      ,[yhmima]
      ,[yhname]
      ,[gender]
      ,[sfz]
      ,[phone]
      ,[age]
      ,[area]
  FROM [dbo].[yonghuzhuce]
where yhdlname = @yhdlname
--实名信息
if exists(select * from sysobjects where name='Pro_shimingxinxii')
drop proc Pro_dengluxinxi
go 
create proc Pro_shimingxinxii(@yhdlname varchar(50))
as
select * from [yonghuzhuce] where yhdlname = @yhdlname

--查看车位
--(无参)
if exists (select * from sysobjects where name='Pro_chakanchewei1')
drop proc Pro_chakanchewei1
go 
create proc Pro_chakanchewei1
as 
select * from Cheweixinxi
--(有参)
if exists (select * from sysobjects where name='Pro_chakanchewei2')
drop proc Pro_chakanchewei2
go 
create proc Pro_chakanchewei2( @CheZhang varchar(50),@Chetype varchar(50))
as 
SELECT [cwID]
      ,[CheIDs]
      ,[ChePrice]
     ,[CheZhang]
     ,[Chetype]
  FROM [dbo].[Cheweixinxi]
where [CheZhang] like @CheZhang   and [Chetype] like @Chetype


--查看商品价格信息
if exists (select * from sysobjects where name='Pro_chakanshangpingjiage')
drop proc Pro_chakanshangpingjiage
go 
create proc Pro_chakanshangpingjiage
as 
select * from Goods

--查看楼盘
if exists (select * from sysobjects where name='Pro_chakanloupan')
drop proc chakanloupan
go 
create proc Pro_chakanloupan( @loupantype varchar(50),@LouZhang varchar(50))
as 
SELECT [lfID]
      ,[LouID]
    ,[LouPrice]
      ,[LouZhang]
      ,[loupantype]
  FROM [dbo].[LouPan]
where [loupantype]like @loupantype and [LouZhang]like @LouZhang

--查看通知栏
if exists (select * from sysobjects where name='Pro_chakantongzhilan')
drop proc Pro_chakantongzhilan
go
create proc Pro_chakantongzhilan
as
select * from[dbo].[TongZhi]

--个人楼盘信息查看
if exists (select * from sysobjects where name='Pro_loupanxinxixiugai')
drop proc Pro_loupanxinxixiugai
go
create proc Pro_loupanxinxixiugai(@yhname varchar(50))
as
select [LouID],[LouPrice],[LouZhang],[loupantype],[yhname] from [dbo].[LouPan],[dbo].[yonghuzhuce]
where  [dbo].[LouPan].lfID=[dbo].[yonghuzhuce].lfID and [yhname]=@yhname
group by[LouID],[LouPrice],[LouZhang],[loupantype],[yhname] 



--操作人刘祖明

go
--管理员登陆存储过程
if exists(select * from sysobjects where name='proc_adminLogin')
drop proc proc_adminLogin
go
create proc proc_adminLogin (@name nvarchar(50),@pwd nvarchar(50) )

as
select * from [dbo].[guanliyuzhucexinxi]
where [dengluname]=@name and [glmima]=@pwd

go
exec proc_adminLogin '10086','123456'
--用户登录存储过程
go
if exists(select * from sysobjects where name='proc_yongLogin')
drop proc proc_yongLogin
go

create proc proc_yongLogin(@name nvarchar(50),@pwd nvarchar(50))
as
select* from [dbo].[yonghuzhuce]
where [yhdlname]=@name and [yhmima]=@pwd

go
exec  proc_yongLogin '123','123'
--管理注册存储过程
if exists(select * from sysobjects where name='proc_adminzhu')
drop proc proc_adminzhu
go
create proc proc_adminzhu(
@dname nvarchar(50),
@pwd nvarchar(50),
@rname nvarchar(50),
@gender nvarchar(50),
@idcard nvarchar(50),
@workid nvarchar(50),
@phone nvarchar(50),
@age int,
@area nvarchar(50),
@job nvarchar(50),
@jobtime nvarchar(50)
)
as
insert [dbo].[guanliyuzhucexinxi]
values(@dname,@pwd,@rname,@gender,@idcard,@workid,@phone,@age,@area,@job,@jobtime)
go
--用户注册存储过程
if exists(select * from sysobjects where name='proc_yongzhu')
drop proc proc_adminzhu
go
create proc proc_yongzhu(
@dname nvarchar(50),
@pwd nvarchar(50),
@rname nvarchar(50),
@gender nvarchar(50),
@idcard nvarchar(50),
@workid nvarchar(50),
@phone nvarchar(50),
@age int,
@area nvarchar(50)

)
as
insert [dbo].[yonghuzhuce]
values(@dname,@pwd,@rname,@gender,@idcard,@workid,@phone,@age,@area,default,default,default,default,default)

--操作人：周文韬
--楼盘信息
if exists(select * from sysobjects where name='P_louoanxinxi')
drop proc P_louoanxinxi
go
create proc P_louoanxinxi
as
select [LouID],[LouPrice],[LouZhang],[loupantype],[yhname] from [dbo].[LouPan],[dbo].[yonghuzhuce]
where [dbo].[LouPan].lfID=[dbo].[yonghuzhuce].lfID
group by [LouID],[LouPrice],[LouZhang],[loupantype],[yhname]

--楼盘信息查
if exists(select * from sysobjects where name='P_louoanxinxicha')
drop proc P_louoanxinxicha
go
create proc P_louoanxinxicha(@name nvarchar(50))
as
select  [LouID],[LouPrice],[LouZhang],[loupantype],[yhname] from [dbo].[LouPan],[dbo].[yonghuzhuce]
where [dbo].[LouPan].lfID=[dbo].[yonghuzhuce].lfID  and  [yhname]like'%'+@name+'%'
group by  [LouID],[LouPrice],[LouZhang],[loupantype],[yhname]

exec P_louoanxinxicha '123'

--楼盘信息修改
if exists(select * from sysobjects where name='P_louoanxinxigai')
drop proc P_louoanxinxigai
go
create proc P_louoanxinxigai(@gaiid nvarchar(50),@id nvarchar(50),@jg numeric(18,0),@you nvarchar(50),@lx nvarchar(50))
as
UPDATE [dbo].[LouPan]
  SET 
  [LouID] = @gaiid
     ,[LouPrice] = @jg
     ,[LouZhang] = @you
      ,[loupantype] = @lx
 WHERE [LouID]=@id
 
 --楼盘信息删除
 if exists(select * from sysobjects where name='P_louoanxinxishan')
drop proc P_louoanxinxishan
go
create proc P_louoanxinxishan(@id nvarchar(50))
as
delete from LouPan where LouID=@id

--楼盘信息完善！


--最新信息(有错！！！未做)

select [yhname],[neirong],[shijian] from [dbo].[gerentongzhi],[dbo].[yonghuzhuce]
where [dbo].[gerentongzhi].grtzID=[dbo].[yonghuzhuce].grtzID
group by[yhname],[neirong],[shijian]


--住房信息
 if exists(select * from sysobjects where name='P_zhufangxinxicha')
drop proc P_zhufangxinxicha
go
create proc P_zhufangxinxicha
as
select [yhname],[LouZhang],[loupantype] from [dbo].[yonghuzhuce],[dbo].[LouPan]
where [dbo].[yonghuzhuce].lfID=[dbo].[LouPan].lfID
group by[yhname],[LouZhang],[loupantype]

--业主信息维护
 if exists(select * from sysobjects where name='P_yezhuxinxicha')
drop proc P_yezhuxinxicha
go
create proc P_yezhuxinxicha
as
select [yhdlname],[yhmima],[yhname],[gender],[sfz],[phone],[age],[area],[dbo].[yonghuzhuce].[lfID],[dbo].[yonghuzhuce].[cwID],[LouID],[CheIDs]from [dbo].[yonghuzhuce],[dbo].[LouPan],[dbo].[Cheweixinxi]
where [dbo].[yonghuzhuce].lfID=[dbo].[LouPan].lfID  and  [dbo].[yonghuzhuce].cwID=[dbo].[Cheweixinxi].cwID
group by [yhdlname],[yhmima],[yhname],[gender],[sfz],[phone],[age],[area],[dbo].[yonghuzhuce].[lfID],[dbo].[yonghuzhuce].[cwID],[LouID],[CheIDs]

--业主信息维护修改

 if exists(select * from sysobjects where name='P_yezhuxinxigai')
drop proc P_yezhuxinxigai
go
create proc P_yezhuxinxigai(@name nvarchar(50),@mima nvarchar(50),@xb nvarchar(50),@sfz nvarchar(50),@dh nvarchar(50),@age int,@dz nvarchar(50),@ifid int,@cwid int,@mz nvarchar(50))
as
UPDATE [dbo].[yonghuzhuce]
   SET [yhdlname] = @name
      ,[yhmima] = @mima
      ,[gender] = @xb
      ,[sfz] = @sfz
      ,[phone] = @dh
      ,[age] = @age
      ,[area] = @dz
      ,[lfID] = @ifid
      ,[cwID] = @cwid
 WHERE  [yhname]=@mz

 --业主缴费信息指定查
  if exists(select * from sysobjects where name='P_yezhujiaofeixinxi')
drop proc P_yezhujiaofeixinxi
go
create proc P_yezhujiaofeixinxi(@name nvarchar(50))
as
select  [yhname],[ChongDate],[Chongmoney]from [dbo].[yonghuzhuce],[dbo].[Userchong]
where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID  and [yhname] like'%'+@name+'%'
group by [yhname],[ChongDate],[Chongmoney]
--业主缴费信息
 if exists(select * from sysobjects where name='P_yezhujiaofeixinxiquan')
drop proc P_yezhujiaofeixinxiquan
go
create proc P_yezhujiaofeixinxiquan(@name nvarchar(50))
as
select  [yhname],[ChongDate],[Chongmoney]from [dbo].[yonghuzhuce],[dbo].[Userchong]
where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID 
group by [yhname],[ChongDate],[Chongmoney]

--新户入住
if exists(select * from sysobjects where name='P_xinhuruzhucha')
drop proc P_xinhuruzhucha
go
create proc P_xinhuruzhucha
as
SELECT * FROM [dbo].[yonghuzhuce]
--新户入住修改
if exists(select * from sysobjects where name='P_xinhuruzhuxiugai')
drop proc P_xinhuruzhuxiugai
go
create proc P_xinhuruzhuxiugai(@name nvarchar(50),@cz int,@if int,@cw int,@namegai nvarchar(50))
as
UPDATE [dbo].[yonghuzhuce]
   SET  [yhname] = @name
       ,[chongzhiID] =  @cz
       ,[lfID] =  @if
       ,[cwID] =  @cw
       
 WHERE   [yhname] = @namegai


 --用户反馈信息cha
if exists(select * from sysobjects where name='P_yonghufankuaixinxi')
drop proc P_yonghufankuaixinxi
go
create proc P_yonghufankuaixinxianxinxi
as
select [yhname],[neirong],[shijian] from [dbo].[yonghuzhuce],[dbo].[kefu]
where [dbo].[yonghuzhuce].kfID=[dbo].[kefu].kfID
group by [yhname],[neirong],[shijian]
--业主缴费信息
if exists(select * from sysobjects where name='P_yonghujiaofeixinxi')
drop proc P_yonghujiaofeixinxi
go
create proc P_yonghujiaofeixinxi(@name nvarchar(50))
as
select  [yhname],[ChongDate],[Chongmoney]from [dbo].[yonghuzhuce],[dbo].[Userchong]
where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID  and [yhname] like'%'+@name+'%'
group by [yhname],[ChongDate],[Chongmoney]

--业主缴费所有信息
if exists(select * from sysobjects where name='P_yonghujiaofeixinxiq')
drop proc P_yonghujiaofeixinxiq
go
create proc P_yonghujiaofeixinxiq
as
select  [yhname],[ChongDate],[Chongmoney]from [dbo].[yonghuzhuce],[dbo].[Userchong]
where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID 
group by [yhname],[ChongDate],[Chongmoney]

--发送信息   (该过程有问题待处理)
if exists(select * from sysobjects where name='P_fasongxinxi')
drop proc P_fasongxinxi
go
create proc P_fasongxinxi(@id int,@time date,@nr nvarchar(max))
as
INSERT INTO [dbo].[TongZhi]
           ([yhtzID]
           ,[TZtime]
           ,[TZnr])
     VALUES
           (@id
           ,@time
           ,@nr)
--添加卡号
if exists(select * from sysobjects where name='P_tianjiakh')
drop proc P_tianjiakh
go
create proc P_tianjiakh(@id int)
as
INSERT INTO [dbo].[Userchong]
           ([chongzhiID]
          )
     VALUES
           (@id
           )

--实名信息
if exists(select * from sysobjects where name='P_shimingxinxi')
drop proc P_shimingxinxi
go
create proc P_shimingxinxi(@name nvarchar(50))
as
select * from [yonghuzhuce] where yhdlname = @name
--提醒信息添加(无表！！！！)
if exists(select * from sysobjects where name='P_shimingxinxi')
drop proc P_shimingxinxi
go
create proc P_shimingxinxi(@name nvarchar(50))
as
INSERT INTO [dbo].[gerentongzhi]
           ([grtzID]
           ,[neirong]
           )
     VALUES
           ('{0}'
           ,'{1}'
           )
--提示信息修改(表有错误!)
if exists(select * from sysobjects where name='P_shimingxinxi')
drop proc P_shimingxinxi
go
create proc P_shimingxinxi(@name nvarchar(50))
as
UPDATE [dbo].[yonghuzhuce]
   SET  [grtzID] = '{0}'
     
 WHERE yhname ='{1}'

--楼盘信息修改
if exists(select * from sysobjects where name='P_loupanxinxigai')
drop proc P_loupanxinxigai
go
create proc P_loupanxinxigai(@id nvarchar(50),@jg numeric(18,0),@zhang nvarchar(50),@type nvarchar(50),@idg nvarchar(50))
as
UPDATE [dbo].[LouPan]
   SET [LouID] = @id
      ,[LouPrice] = @jg
      ,[LouZhang] = @zhang
      ,[loupantype] = @type
 WHERE [LouID]=@idg
--流水信息
if exists(select * from sysobjects where name='P_liushuixinxi')
drop proc P_liushuixinxi
go
create proc P_liushuixinxi(@name nvarchar(50))
as
select * from UserXiao,yonghuzhuce where  dbo.UserXiao.xiaofeiID = dbo.yonghuzhuce.xiaofeiID and yhdlname = @name

--充值
if exists(select * from sysobjects where name='P_chongzhi')
drop proc P_chongzhi
go
create proc P_chongzhi(@money numeric(18,0),@id int)
as
update [dbo].[Userchong] set [Yue]+=@money
where [chongzhiID]=@id

--车位信息维护
if exists(select * from sysobjects where name='P_chewei')
drop proc P_chewei
go
create proc P_chewei
as
SELECT [CheIDs]
      ,[ChePrice]
      ,[CheZhang]
      ,[yhname]
  FROM [dbo].[Cheweixinxi] c,[dbo].[yonghuzhuce] y
  where c.cwID=y.cwID
--车位信息删除
if exists(select * from sysobjects where name='P_cheweishan')
drop proc P_cheweishan
go
create proc P_cheweishan(@id nvarchar(50))
as
delete [dbo].[Cheweixinxi]
  where CheIDs=@id
 
 --车位信息查
 if exists(select * from sysobjects where name='P_cheweiy')
drop proc P_cheweiy
go
create proc P_cheweiy(@name nvarchar(50))
as
SELECT [CheIDs]
      ,[ChePrice]
      ,[CheZhang]
      ,[yhname]
  FROM [dbo].[Cheweixinxi] c,[dbo].[yonghuzhuce] y
  where c.cwID=y.cwID and yhname=@name
 --车位信息添加
  if exists(select * from sysobjects where name='P_cheweijia')
drop proc P_cheweijia
go
create proc P_cheweijia(@cwid int,@cheid nvarchar(50),@jg nvarchar(50),@zhang nvarchar(50),@type nvarchar(50))
as
 INSERT INTO [dbo].[Cheweixinxi]
           ([cwID]
           ,[CheIDs]
           ,[ChePrice]
           ,[CheZhang]
           ,[Chetype])
     VALUES
           (@cwid
           ,@cheid
           ,@jg
           ,@zhang
           ,@type)
--车位信息查看
  if exists(select * from sysobjects where name='P_cheweikan')
drop proc P_cheweikan
go
create proc P_cheweikan
as
select [CheIDs],[ChePrice],[CheZhang],[Chetype],[yhname] from [dbo].[yonghuzhuce],[dbo].[Cheweixinxi]
where [dbo].[yonghuzhuce].cwID=[dbo].[Cheweixinxi].cwID
group by [CheIDs],[ChePrice],[CheZhang],[Chetype],[yhname]

--车位信息删
  if exists(select * from sysobjects where name='P_cheweishanchu')
drop proc P_cheweishanchu
go
create proc P_cheweishanchu(@cheid nvarchar(50))
as
DELETE FROM [dbo].[Cheweixinxi]
      WHERE CheIDs=@cheid
--车位信息查询
  if exists(select * from sysobjects where name='P_cheweichaxun')
drop proc P_cheweichaxun
go
create proc P_cheweichaxun(@cheid nvarchar(50))
as
select [CheIDs],[ChePrice],[CheZhang],[Chetype],[yhname] from [dbo].[yonghuzhuce],[dbo].[Cheweixinxi]
where [dbo].[yonghuzhuce].cwID=[dbo].[Cheweixinxi].cwID and  [CheIDs]like'%'+@cheid+'%'
group by [CheIDs],[ChePrice],[CheZhang],[Chetype],[yhname]

--车位信息改
  if exists(select * from sysobjects where name='P_cheweixinxigai')
drop proc P_cheweixinxigai
go
create proc P_cheweixinxigai(@cheid nvarchar(50),@jg nvarchar(50),@zhang nvarchar(50),@type nvarchar(50),@id nvarchar(50))
as
UPDATE [dbo].[Cheweixinxi]
   SET 
      [CheIDs] =@cheid
      ,[ChePrice] =@jg
      ,[CheZhang] = @zhang
      ,[Chetype] = @type
 WHERE [CheIDs]=@id
 --查看余额
 select [yhmenhao],[yhname],[Yue],[phone] from [dbo].[yonghuzhuce],[dbo].[Userchong]
            where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID --and [yhname] like'%{0}%'
            group by [yhmenhao],[yhname],[Yue],[phone]

if exists(select * from sysobjects where name='Pro_chakanyezhuyue')
drop proc Pro_chakanyezhuyue
go
create proc Pro_chakanyezhuyue(@yhname varchar(50))
as
select [yhmenhao],[yhname],[Yue],[phone] from [dbo].[yonghuzhuce],[dbo].[Userchong]
            where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID and [yhname] =@yhname
            group by [yhmenhao],[yhname],[Yue],[phone]

--用户反馈
if exists(select * from sysobjects where name ='Pro_yonghufankui')
drop proc Pro_yonghufankui
go
create proc Pro_yonghufankui(@fkname varchar(50),@fknr varchar(max),@fkshijian date)
as
insert into [dbo].[hyfk]
values(@fkname,@fknr,@fkshijian )


--查看用户反馈

if exists(select * from sysobjects where name ='Pro_YongHuFanKuixinxi')
drop proc Pro_YongHuFanKuixinxi
go
create proc Pro_YongHuFanKuixinxi
as
select * from hyfk

--管理员发送通知栏
if exists(select * from sysobjects where name ='Pro_TongZhiYongHu')
drop proc Pro_TongZhiYongHu
go
create proc Pro_TongZhiYongHu(@TZtime date,@TZnr varchar(max))
as
INSERT INTO [dbo].[TongZhi]
           ([TZtime]
           ,[TZnr])
     VALUES
           (@TZtime
           ,@TZnr)
--分页查询
--select top 6* from [dbo].[Goods]

--select top 6* from [dbo].[Goods]
--where [GoodId] not in (select top 6 [GoodId] from [dbo].[Goods])


if exists(select * from sysobjects where name ='Pro_shangpingguanli')
drop proc Pro_shangpingguanli
go
create proc Pro_shangpingguanli(
@row int ,--每页显示的行数
	@page int,--页码
	@count int output) --总行数)
as
select top (@row) * from [dbo].[Goods]
where [GoodId] not in (select top ((@page-1)*@row) [GoodId] from [dbo].[Goods])         
select @count=count(* ) from [dbo].[Goods]
--查询商品信息
if exists(select * from sysobjects where name ='Pro_shangpingguanlichaxun')
drop proc Pro_shangpingguanlichaxun
go
create proc Pro_shangpingguanlichaxun(@GoodName varchar(50))
as
select * from [dbo].[Goods]
where [GoodName]=@GoodName
--添加商品
if exists(select * from sysobjects where name ='Pro_shangpingguanlitianjia')
drop proc Pro_shangpingguanlitianjia
go
create proc Pro_shangpingguanlitianjia(
@GoodName varchar(50),
@GoodPrice varchar(50),
@GoodShenqi varchar(50),
@GoodDaoqi varchar(50),
@GoodBaoqi varchar(50),
@GoodType varchar(50)
)
as

INSERT INTO [dbo].[Goods]
           ([GoodPrice]
           ,[GoodShenqi]
           ,[GoodDaoqi]
           ,[GoodBaoqi]
           ,[GoodType]
           ,[GoodName])
     VALUES
           (@GoodPrice
           ,@GoodShenqi
           ,@GoodDaoqi 
           ,@GoodBaoqi
           ,@GoodType
           ,@GoodName)


--删除商品
if exists(select * from sysobjects where name ='Pro_shangpingguanlishanchu')
drop proc Pro_shangpingguanlishanchu
go
create proc Pro_shangpingguanlishanchu(@GoodName varchar(50))
as


DELETE FROM [dbo].[Goods]
      WHERE [GoodName]=@GoodName

--查看用户余额
if exists(select * from sysobjects where name ='Pro_guanliyuanchakanyue')
drop proc Pro_guanliyuanchakanyue
go
create proc Pro_guanliyuanchakanyue(@yhname varchar(50))
as

select [yhmenhao],[yhname],[Yue],[phone] from [dbo].[yonghuzhuce],[dbo].[Userchong]
            where [dbo].[yonghuzhuce].chongzhiID=[dbo].[Userchong].chongzhiID and [yhname] like'%'+@yhname+'%'
            group by [yhmenhao],[yhname],[Yue],[phone]
