/*
* @Author: Jingyuexing
* @Date:   2021-06-21 20:35:19
* @Last Modified by:   Jingyuexing
* @Last Modified time: 2021-06-23 16:54:05
*/
drop table if exists `reader`;
create table `bookManager`.`reader`(
    `id` int not null,
    `name` nvarchar(255) not null, -- 读者姓名 
    `sex` int not null, -- 读者性别 0 男 / 1 女 
    `type` smallint not null,
    `dept` nvarchar(20) not null,
    `phone` nvarchar(25) not null,
    `email` nvarchar(25) not null,
    `dateReg` datetime ,
    `photo` varchar,
    `status` nvarchar(2) not null, -- 证件状态 有效 挂失 注销
    `borrowNumber` nvarchar(2) default(0), -- 证件状态 有效 挂失 注销
    `password` nvarchar(255) default MD5('123'),
    `adminRoles` smallint, -- 0 读者 1 借书证管理 2 图书管理 4 借阅管理 8 系统管理 ：可组合
);
insert  into `reader`(`id`,`name`,`sex`,`type`,`dept`,`phone`,`email`,`dateReg`,`photo`,`status`,`borrowNumber`,`password`,`adminRoles`) values
();
