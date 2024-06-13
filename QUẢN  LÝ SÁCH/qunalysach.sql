CREATE DATABASE THZEDG;
USE THZEDG;


CREATE TABLE QLySACH (
maSach varchar (4) primary key,
tenSach nvarchar (50),
nhaXuatBan nvarchar (50),
namXuatBan int,
giaTien varchar (100),
);


INSERT INTO QLySACH( maSach, tenSach, nhaXuatBan, namXuatBan, giaTien ) values 
('01' , N' Tiếng gọi từ vì sao xa ', 'IPM' , '2022' , '80000') ;
INSERT INTO QLySACH( maSach, tenSach, nhaXuatBan, namXuatBan, giaTien ) values 
('02' , N' Những đứa con của sói ', 'IPM' , '2015' , '70000') ;
INSERT INTO QLySACH( maSach, tenSach, nhaXuatBan, namXuatBan, giaTien ) values 
('03' , N' Cô gái văn chương ', 'Hikari' , '2014' , '62000') ;
INSERT INTO QLySACH( maSach, tenSach, nhaXuatBan, namXuatBan, giaTien ) values
('04' , N' Ánh trăng ', N'Phụ nữ' , '2019' , '100000') ;

SELECT * FROM QLySACH
DELETE FROM QLySACH WHERE maSach = 04;