select * from tabela_pessoa
select * from tabela_evento


--2.1 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' e os respectivos eventos 
--'tabela_evento' o qual elas participam.

SELECT * FROM tabela_pessoa p
INNER JOIN tabela_evento e ON p.id = e.pessoa_id 


--2.2 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' com sobrenome 'Doe'.
SELECT * FROM tabela_pessoa WHERE nome LIKE '%Doe%'

-- 2.3 Crie uma query para adicionar um novo evento 'tabela_evento' e relacionar à pessoa 'Lisa Romero'.
insert into tabela_evento
values('Evento E',5)

--2.4 Crie uma query para atualizar 'Evento D' na 'tabela_evento' e relacionar à pessoa 'Joh Doe'
UPDATE tabela_evento 
SET pessoa_id = (select id from tabela_pessoa where nome ='Joh Doe')
WHERE id = 4

--2.5 Crie uma query para remover o 'Evento B' na 'tabela_evento'.
DELETE FROM tabela_evento
WHERE id = (SELECT id FROM tabela_evento WHERE evento = 'Evento D') 

