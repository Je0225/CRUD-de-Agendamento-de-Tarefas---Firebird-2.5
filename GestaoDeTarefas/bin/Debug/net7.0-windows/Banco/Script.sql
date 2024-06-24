create table Tarefas(
  id         integer not null,
  titulo     varchar(100) not null,
  descricao  varchar(300) not null,
  data       date not null,
  status     varchar(15) not null,
);

alter table tarefas add constraint pk_tarefas primary key (id);

create generator gen_id_tarefas;
set generator gen_id_tarefas to 0;