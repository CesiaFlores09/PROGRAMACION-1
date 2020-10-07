
select  nombre, email from clientes where email like '%com%'
select * from clientes
insert into clientes(codigo,nombre,direccion,telefono,email) values ( '005', 'Alexander Romero','San Miguel','7890-2345','alex@gmail.com')
delete from clientes where Idclientes=1
update clientes set codigo ='002', nombre=	'Monica Rodriguez', telefono ='5643-0987', email='Monicar@gmail.com' where Idclientes=2