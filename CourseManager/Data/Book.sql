/*
* @Author: Jingyuexing
* @Date:   2021-06-21 20:41:39
* @Last Modified by:   Jingyuexing
* @Last Modified time: 2021-06-21 20:50:16
*/
drop table if exists `book`;
create table `bookManager`.`book`(
    `id` int NOT NULL,
    `bookCode` nvarchar(20), -- 图书编码或者条码号
    `bookName` nvarchar(20), -- 书名
    `bookAuthor` nvarchar(20), -- 作者
    `bookPress` nvarchar(20), -- 出版社
    `datePress` datetime , -- 出版日期
    `ISBN` nvarchar(15) , -- ISBN号
    `catalog` nvarchar(30), -- 分类号
    `language` smallint, -- 语言 0 中文 1英文 2日文 3 俄文 4 德文 5 法文 
    `pages` int, -- 页数
    `inDate` datetime, -- 入馆日期
    `brief` text, -- 简介
    `cover` text, -- 封面
    `cover` text, -- 页数
    `status` nvarchar(2), -- 图书状态 在馆 借出 遗失 变卖 销毁
);
