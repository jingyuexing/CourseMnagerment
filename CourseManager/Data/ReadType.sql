/*
* @Author: Jingyuexing
* @Date:   2021-06-21 20:41:27
* @Last Modified by:   Jingyuexing
* @Last Modified time: 2021-06-21 20:51:05
*/
drop table if exists `readType`;
create table `bookManager`.`readType`(
    `type` smallint primary key, -- 读者类别
    `typeName` nvarchar(20) not null unique, -- 唯一 
    `canLend` int ,-- 可借书数量
    `canLendDay` int ,-- 可借书天数
    `countimes` int ,-- 可续借的次数
    `punishRate` float, -- 罚款率,
    `dateValid` smallint default 0, --证书有效期(年) 0表示永久有效
)
