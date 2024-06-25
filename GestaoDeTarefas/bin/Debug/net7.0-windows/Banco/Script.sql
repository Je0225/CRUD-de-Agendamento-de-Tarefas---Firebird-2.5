create table tarefas(
  id         integer not null,
  titulo     varchar(100) not null,
  descricao  varchar(300) not null,
  data       date not null,
  status     varchar(15) not null,
  lista      integer not null  
);

create table listas_tarefas(
  id     integer not null,
  nome   varchar(50) not null
);

alter table tarefas add constraint pk_tarefas primary key (id);
alter table listas_tarefas add constraint pk_listas_tarefas primary key (id);
alter table tarefas add constraint fk_lista_tarefa foreign key (lista) references listas_tarefas(id) on delete cascade;

create generator gen_id_tarefas;
set generator gen_id_tarefas to 0;

create generator gen_id_listas_tarefas;
set generator gen_id_listas_tarefas to 0;