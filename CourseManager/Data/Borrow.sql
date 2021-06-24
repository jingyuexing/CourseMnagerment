/*
* @Author: Jingyuexing
* @Date:   2021-06-21 20:41:15
* @Last Modified by:   Jingyuexing
* @Last Modified time: 2021-06-21 20:50:46
*/
drop table if exists `borrow`;
create table `bookManager`.`borrow`(
    `id` numeric(12,0) not null primary key,
    `readerID` int, -- 读者序号
    `bookID` int, -- 图书序号
    `count` int default 0, -- 续借次数
    `Outdate` datetime, -- 借书日期
    `dateRetPlan` datetime, -- 应还日期
    `dateRetAct` datetime, -- 实际归还日期
    `overDay` int ,-- 超期天数
    `overmoney` money, -- 超期金额
    `publishmoney` money, -- 罚款金额
    `isHasReturn` bit default 0, -- 是否已经还书 0 未还
    `operatorLend` nvarchar(20), -- 借书操作员
    `operatorRet` nvarchar(20), -- 还书操作员
);
