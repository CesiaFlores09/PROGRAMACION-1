select  nombre, email from Clientes where email like '%com%'
select * from Clientes
insert into Clientes(codigo,nombre,direccion,telefono,email) values ( '004', 'Yanci Espinoza','Usulutan','5907-7867','yanci@gmail.com')
delete from Clientes where IdClientes=1
update Clientes set codigo ='0002', nombre=	'Monica Rodriguez', telefono ='5643-0987', email='Monicar@gmail.com' where IdClientes=2
update Clientes set codigo='002' where IdClientes=2