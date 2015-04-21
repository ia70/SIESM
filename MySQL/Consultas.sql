#show databases;
use siesm;
#show tables;
#CALL articulo_insertar('2154857582','Cocacola 1L','Botella de Cocacola de 1 Litro','Refresco enbotellado','sfs6d4f6sdsd4f6sd6f','20150120');
#CALL articulo_insertar('12345678','Cocacola 1L','Cocacola de un Litro','Botella de refresco','55555','20150122');
#DELETE FROM articulo WHERE id_articulo='';

CALL articulo_mostrar();
#CALL articulo_editar('2154857582','Cocacola 1L','Botella de Cocacola de 1 Litro','Refresco enbotellado','Daniel','20150119');
