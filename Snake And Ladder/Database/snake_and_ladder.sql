create database snake_and_ladder

use [snake_and_ladder]

create table player_data
(
  player1 varchar(50),
  player2 varchar(50),
 
)

insert into player_data (player1,player2)values ('Hafsa','Bilal')

select *from players_data


create table winner_data
(
 id int identity(1,1),
 winner varchar(50),
)

insert into winner_data (winner)values ('Hafsa')

select *from winner_data