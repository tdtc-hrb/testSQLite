/*==============================================================*/
/* DBMS name:      SQLite v3                                    */
/* Created on:     2020/5/23 22:15:54                           */
/*==============================================================*/


drop table if exists factoryCar;

drop table if exists marqueCar;

/*==============================================================*/
/* Table: factoryCar                                            */
/*==============================================================*/
create table factoryCar
(
   sn                   INTEGER not null,
   name                 TEXT not null,
   acronym              TEXT not null,
   primary key (sn)
);

/*==============================================================*/
/* Table: marqueCar                                             */
/*==============================================================*/
create table marqueCar
(
   sn                   INTEGER not null,
   fac_sn               INTEGER,
   name                 TEXT not null,
   deadweight           INTEGER not null,
   standardweight       INTEGER not null,
   primary key (sn),
   foreign key (fac_sn) references factoryCar (sn)
);


